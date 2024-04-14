using DotNet_lab_lista_10.Data;
using DotNet_lab_lista_10.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using DotNet_lab_lista_10.Models;
using Microsoft.AspNetCore.Http;
using System;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.IO;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace DotNet_lab_lista_10.Controllers
{
    [Authorize(Policy = "NotAdmin")]
    public class CartController : Controller
    {
        private readonly MyDbContext _context;

        public CartController(MyDbContext context)
        {
            _context = context;
        }

        private List<ArticleCartViewModel> GetCartItems()
        {
            var cartCookies = Request.Cookies.Where(c => c.Key.StartsWith("article")).ToList();

            var items = _context.Article.Include(a => a.Category)
                            .ToList()
                            .Join(cartCookies,
                                    article => article.Id,
                                    cookie => int.Parse(cookie.Key.Substring("article".Length)),
                                    (article, cookie) =>
                                        new ArticleCartViewModel()
                                        {
                                            Id = article.Id,
                                            Name = article.Name,
                                            Price = article.Price,
                                            Image = article.Image,
                                            CategoryId = article.CategoryId,
                                            Category = article.Category,
                                            NumberOfItems = int.Parse(cookie.Value)
                                        })
                            .ToList();
            return items;
        }

        public IActionResult Index()
        {
            var items = GetCartItems();

            ViewBag.Cost = items.Sum(i => i.Price * i.NumberOfItems);

            if (RemoveInvalidCookies())
            {
                ViewBag.Message = "Some articles from your cart have been deleted.";
            }

            if (items.Count == 0)
            {
                return View("EmptyCart");
            }
            
            //return View(items);
            return View("IndexJs", items);
        }

        public bool RemoveInvalidCookies()
        {
            var cartCookies = Request.Cookies.Where(c => c.Key.StartsWith("article")).ToList();

            var missingArticleKeys = cartCookies.Select(cookie => int.Parse(cookie.Key.Substring("article".Length)))
                .Except(_context.Article.Select(article => article.Id))
                .ToList();

            missingArticleKeys.ForEach(id =>
                {
                    CookieOptions cookie = new CookieOptions();
                    cookie.Expires = DateTime.Now.AddDays(-1d);
                    Response.Cookies.Append($"article{id}", "0", cookie);
                }
            );


            return missingArticleKeys.Any();
        }

        public IActionResult Remove(ArticleCartViewModel article) {
            int quantity = article.NumberOfItems - 1;

            if (quantity < 1)
            {
                return RedirectToAction(nameof(RemoveAllItems), new { article.Id });
            }

            CookieOptions cookie = new CookieOptions();
            cookie.Expires = DateTime.Now.AddDays(7);
            Response.Cookies.Append($"article{article.Id}", quantity.ToString(), cookie);

            return RedirectToAction(nameof(Index));
        }

        public IActionResult RemoveAllItems(int id)
        {
            CookieOptions cookie = new CookieOptions();
            cookie.Expires = DateTime.Now.AddDays(-1d);
            Response.Cookies.Append($"article{id}", "0", cookie);

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Add(ArticleCartViewModel article) {

            CookieOptions cookie = new CookieOptions();
            cookie.Expires = DateTime.Now.AddDays(7);
            int quantity = article.NumberOfItems + 1;
            Response.Cookies.Append($"article{article.Id}", quantity.ToString(), cookie);

            return RedirectToAction(nameof(Index));
        }

        [Authorize(Roles = "RegularUser")]
        public IActionResult Order() {
            
            var items = GetCartItems();

            if (items.Count != 0)
            {
                Order order = new Order()
                {
                    Articles = items
                };

                return View("OrderForm", order);
            }

            return RedirectToAction(nameof(Index));
        }

        [Authorize(Roles = "RegularUser")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult OrderDetails([Bind("FirstName, LastName, Address, City, PaymentMethod, Articles")] Order order)
        {
            order.Articles = GetCartItems();

            if (ModelState.IsValid)
            {
                return RedirectToAction(nameof(OrderConfirmation), order);
            }

            return View("OrderForm", order);
        }

        [Authorize(Roles = "RegularUser")]
        public IActionResult OrderConfirmation([Bind("FirstName, LastName, Address, City, PaymentMethod, Articles")] Order order)
        {
            order.Articles = GetCartItems();

            if (order.Articles.Count == 0)
            {
                return RedirectToAction(nameof(Index));
            }

            order.Articles.ToList().ForEach(a => RemoveAllItems(a.Id));

            return View("OrderSummary", order);
        }
    }
}
