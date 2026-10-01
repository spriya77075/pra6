using prac_6.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace prac_6.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            List<Product> P = new List<Product>();
            P = GetProducts();
            return View(P);
        }

        public ActionResult Details(int id)
        {
            List<Product> PALL = GetProducts();
            Product P1 = PALL.FirstOrDefault(p => p.ProductId == id);
            return View(P1);
        }

        private List<Product> GetProducts()
        {
            return new List<Product>
            {
                new Product
                {
                    ProductId = 1,
                    ProductName = "Samsung S23 Ultra",
                    Description = "Galaxy S23 Ultra 256GB, 12GB RAM",
                    Price = 87000,
                    Category = "Electronics"
                },

                new Product
                {
                    ProductId = 2,
                    ProductName = "MacBook",
                    Description = "Apple MacBook Pro 16-inch, M2 Pro chip",
                    Price = 127000,
                    Category = "Electronics"
                },

                new Product
                {
                    ProductId = 3,
                    ProductName = "Tablet",
                    Description = "Lenovo Tab",
                    Price = 5000,
                    Category = "Electronics"
                },

                new Product
                {
                    ProductId = 4,
                    ProductName = "Mobile Cover",
                    Description = "Mobile cover for iphone 17 pro max",
                    Price = 1700,
                    Category = "Mobile Accessories"
                },

                new Product
                {
                    ProductId = 5,
                    ProductName = "Laptop Bag",
                    Description = "Laptop bag for 15.6 inch",
                    Price = 548,
                    Category = "Laptop Accessories"
                },

                new Product
                {
                    ProductId = 6,
                    ProductName = "Earphone",
                    Description = "MIVI wireless earphone",
                    Price = 799,
                    Category = "Earphones"
                },

                new Product
                {
                    ProductId = 7,
                    ProductName = "Tablet",
                    Description = "Lanovo",
                    Price = 5000,
                    Category = "Electronics"
                },

                new Product
                {
                    ProductId = 8,
                    ProductName = "boAt Karaoke",
                    Description = "boAt PartyPal Karaoke, 90w output",
                    Price = 6999,
                    Category = "Home Audio"
                },

                new Product
                {
                    ProductId = 9,
                    ProductName = "PS5",
                    Description = "Sony PS5 Console DIgital",
                    Price = 64990,
                    Category = "Gaming"
                },

                new Product
                {
                    ProductId = 10,
                    ProductName = "Vara Art Showpiece",
                    Description = "Vara Art Handcrafted Mental Rajasthani showpiece",
                    Price = 667,
                    Category = "Home Decore"
                }
            };
        }
    }
}