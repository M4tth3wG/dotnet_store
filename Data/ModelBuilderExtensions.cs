using Microsoft.EntityFrameworkCore;
using System.Reflection;
using System;
using DotNet_lab_lista_10.Models;
using System.Collections.Generic;

namespace DotNet_lab_lista_10.Data
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            Category[] categories = {
                new Category()
                {
                    Id = 1,
                    Name = "Beverages"
                },
                new Category()
                {
                    Id = 2,
                    Name = "Cosmetics"
                },
                new Category()
                {
                    Id = 3,
                    Name = "Food"
                },
                new Category()
                {
                    Id = 4,
                    Name = "Electronics"
                }};

            modelBuilder.Entity<Category>().HasData(categories);

            var articles = new List<Article>();

            for (int i = 1; i <= 1000; i++)
            {
                articles.Add(new Article()
                {
                    Id = i,
                    Name = $"Article_{i}",
                    Price = i,
                    CategoryId = categories[i % categories.Length].Id
                });
            }

            modelBuilder.Entity<Article>().HasData(articles);
        }
    }
}
