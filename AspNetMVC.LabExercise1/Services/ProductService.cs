using AspNetMVC.LabExercise1.Models;
using System.Collections.Generic;

namespace AspNetMVC.LabExercise1.Services
{
    public class ProductService
    {
        private List<Product> products;
        public ProductService()
        {
            products = new List<Product>();

            products.Add(new Product()
            {
                Id = 1,
                Name = "Masid 1.0",
                Description = "Concerned Citizen!",
                Quantity = 5,
                Price = 600M,
            });
            products.Add(new Product()
            {
                Id = 2,
                Name = "Masid 2.0",
                Description = "All Good In The Hood!",
                Quantity = 10,
                Price = 600M,
            });
            products.Add(new Product()
            {
                Id = 3,
                Name = "Masid 3.0",
                Description = "Live Life!",
                Quantity = 15,
                Price = 750M,
            });
            products.Add(new Product()
            {
                Id = 4,
                Name = "Masid 4.0",
                Description = "Tomorrow Is Not Promised, Do It Now!",
                Quantity = 20,
                Price = 750M,
            });
            products.Add(new Product()
            {
                Id = 5,
                Name = "Masid 5.0",
                Description = "Create Your Own Calm!",
                Quantity = 25,
                Price = 750M,
            });
        }

        public List<Product> GetCatalog()
        {
            return products;
        }
        public decimal GetGrandTotal()
        {
            decimal grandTotal = 0;

            foreach(var product in products)
            {
                grandTotal += (product.Price * product.Quantity);
            }
            return grandTotal;
        }
    }
}
