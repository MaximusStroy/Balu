using Balu.Data.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Linq;

namespace Balu.Data
{
    public class DBObjects
    {
        public static void Initial(ApplicationDbContext context)
        {

            if (!context.Category.Any())
            {
                context.Category.AddRange(Categories.Select(c => c.Value));
            }

            if (!context.Product.Any())
            {
                context.Product.AddRange (
                    new Product { 
                        Name = "Balu", 
                        Img = "https://i.pinimg.com/originals/2f/15/7e/2f157e568d99c0a2dc6c9737f460d27b.jpg", 
                        Price = 1000, 
                        CategoryId = 1, 
                        IsFavourite = true, 
                        Category = Categories["Футболка"]
                    },
                    new Product
                    {
                        Name = "Balu",
                        Img = "https://i.pinimg.com/originals/2f/15/7e/2f157e568d99c0a2dc6c9737f460d27b.jpg",
                        Price = 1000,
                        CategoryId = 1,
                        IsFavourite = true,
                        Category = Categories["Футболка"]
                    },
                    new Product
                    {
                        Name = "Balu",
                        Img = "https://i.pinimg.com/originals/2f/15/7e/2f157e568d99c0a2dc6c9737f460d27b.jpg",
                        Price = 1000,
                        CategoryId = 1,
                        IsFavourite = true,
                        Category = Categories["Футболка"]
                    },
                    new Product
                    {
                        Name = "Balu",
                        Img = "https://i.pinimg.com/originals/2f/15/7e/2f157e568d99c0a2dc6c9737f460d27b.jpg",
                        Price = 1000,
                        CategoryId = 1,
                        IsFavourite = true,
                        Category = Categories["Футболка"]
                    },
                    new Product
                    {
                        Name = "Balu",
                        Img = "https://i.pinimg.com/originals/2f/15/7e/2f157e568d99c0a2dc6c9737f460d27b.jpg",
                        Price = 1000,
                        CategoryId = 1,
                        IsFavourite = true,
                        Category = Categories["Футболка"]
                    });
            }
            context.SaveChanges();
        }

        private static Dictionary<string, Category> _category;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (_category == null)
                {
                    var list = new List<Category>
                    {
                        new Category {Title = "Футболка"},
                        new Category {Title = "Худи"},
                        new Category {Title = "Шорты"}
                    };

                    _category = new Dictionary<string, Category>();
                    foreach (Category category in list)
                    {
                        _category.Add(category.Title, category);
                    }
                }
                return _category;
            }
        }

    }
}
