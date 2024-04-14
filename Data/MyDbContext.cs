using DotNet_lab_lista_10.Models;
using Microsoft.EntityFrameworkCore;
using DotNet_lab_lista_10.ViewModels;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;

namespace DotNet_lab_lista_10.Data
{
    public class MyDbContext : IdentityDbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
        }

        public DbSet<Article> Article { get; set; }
        public DbSet<Category> Category { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Seed();
        }

        public async Task<List<Article>> GetArticlesPageAsync(int page_index, int number_of_items)
        {
            var articles = await Article.Include(a => a.Category)
                .OrderBy(s => s.Id)
                .Skip(page_index * number_of_items)
                .Take(number_of_items)
                .ToListAsync();

            articles.ForEach(a => a.Category.Articles = null);

            return articles;
        }

        public async Task<List<Article>> GetArticlesPagePerCategoryAsync(int page_index, int number_of_items, int category_id)
        {
            var articles = await Article.Include(a => a.Category)
                .Where(a => a.CategoryId == category_id)
                .OrderBy(s => s.Id)
                .Skip(page_index * number_of_items)
                .Take(number_of_items)
                .ToListAsync();

            articles.ForEach(a => a.Category.Articles = null);

            return articles;
        }
    }
}
