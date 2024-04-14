using DotNet_lab_lista_10.Data;
using DotNet_lab_lista_10.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet_lab_lista_10.Controllers
{
    [Authorize(Policy = "NotAdmin")]
    public class ShopController : Controller
    {
        private readonly MyDbContext _context;

        public ShopController(MyDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var categories = _context.Category.ToListAsync();
            return View(await categories);
        }

        public async Task<IActionResult> Articles(Category category)
        {
            int numberOfItems = 10;

            var articles = await _context.GetArticlesPagePerCategoryAsync(0, numberOfItems, category.Id);

            var categories = await _context.Category.ToListAsync();

            ViewBag.SelectedCategory = category;
            ViewBag.Categories = categories;
            ViewBag.NumberOfItems = numberOfItems;

            //return View(articles);
            return View("ArticlesScroll", articles);
        }

        public async Task<IActionResult> AddToCart(Article article)
        {
            string cookieValue = Request.Cookies[$"article{article.Id}"];
            int numberOfItems = 0;

            if (cookieValue != null)
            {
                try
                {
                    numberOfItems = int.Parse(cookieValue);
                }
                catch 
                { 
                    numberOfItems = 0;
                }
            }

            numberOfItems++;

            CookieOptions cookie = new CookieOptions();
            cookie.Expires = DateTime.Now.AddDays(7);
            Response.Cookies.Append($"article{article.Id}", numberOfItems.ToString(), cookie);

            var category = _context.Category.Where(c => c.Id == article.CategoryId).FirstOrDefaultAsync();
            return RedirectToAction(nameof(Articles), await category );
            //return RedirectToAction(nameof(Index));
        }
    }
}
