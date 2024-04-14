using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DotNet_lab_lista_10.Data;
using DotNet_lab_lista_10.Models;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting.Internal;

namespace DotNet_lab_lista_10.ApiControllers
{
    [Route("api/articles")]
    [ApiController]
    public class ArticlesApiController : ControllerBase
    {
        private readonly MyDbContext _context;
        private readonly IHostingEnvironment _hostingEnvironment;

        public ArticlesApiController(MyDbContext context, IHostingEnvironment hostingEnvironment)
        {
            _context = context;
            _hostingEnvironment = hostingEnvironment;

        }

        // GET: api/ArticlesApi
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Article>>> GetArticle()
        {
            return await _context.Article.ToListAsync();
        }

        // GET: api/ArticlesApi/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Article>> GetArticle(int id)
        {
            var article = await _context.Article.FindAsync(id);

            if (article == null)
            {
                return NotFound();
            }

            return article;
        }

        // PUT: api/ArticlesApi/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutArticle(int id, Article article)
        {
            if (id != article.Id)
            {
                return BadRequest();
            }

            var originalArticle = await _context.Article.Where(a => a.Id == id).FirstOrDefaultAsync();

            if (originalArticle != null) {
                originalArticle.Name = article.Name;
                originalArticle.Price = article.Price;
                originalArticle.CategoryId = article.CategoryId;
            }

            //article.Image = originalArticle?.Image;
            _context.Entry(originalArticle).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ArticleExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/ArticlesApi
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Article>> PostArticle(Article article)
        {
            if(article.Id != 0)
            {
                return BadRequest();
            }

            if (article == null)
            {
                return NotFound();
            }

            article.Image = null;
            _context.Article.Add(article);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetArticle", new { id = article.Id }, article);
        }

        // DELETE: api/ArticlesApi/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteArticle(int id)
        {
            var article = await _context.Article.FindAsync(id);
            if (article == null)
            {
                return NotFound();
            }

            if (article.Image != null)
            {
                var uploadsPath = Path.Combine(_hostingEnvironment.WebRootPath, "uploads");
                var filePath = Path.Combine(uploadsPath, article.Image);

                DeleteImage(filePath);
            }

            _context.Article.Remove(article);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpGet("nextpage/{page_index},{number_of_items}")]
        public async Task<List<Article>> GetNextPage(int page_index, int number_of_items)
        {
            if (page_index < 0 || number_of_items < 1)
            {
                return new List<Article>();
            }

            return await _context.GetArticlesPageAsync(page_index, number_of_items);
        }

        [HttpGet("nextpage/percategory/{page_index},{number_of_items},{category_id}")]
        public async Task<List<Article>> GetNextPagePerCategory(int page_index, int number_of_items, int category_id)
        {
            if (page_index < 0 || number_of_items < 1)
            {
                return new List<Article>();
            }

            return await _context.GetArticlesPagePerCategoryAsync(page_index, number_of_items, category_id);
        }

        private bool ArticleExists(int id)
        {
            return _context.Article.Any(e => e.Id == id);
        }

        private void DeleteImage(string imagePath)
        {
            try
            {
                if (System.IO.File.Exists(imagePath))
                {
                    System.IO.File.Delete(imagePath);
                }
                else
                {
                    Console.WriteLine("File not found.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deleting file: {ex.Message}");
            }
        }

        
    }
}
