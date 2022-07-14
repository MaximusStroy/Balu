using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Balu.Data.Models
{
    public class Basket
    {
        public string BasketId { get; set; }
        public List<BasketItem> ListItemsInBasket { get; set; }

        private readonly ApplicationDbContext db;

        public Basket(ApplicationDbContext db)
        {
            this.db = db;
        }

        public static Basket GetBasket(IServiceProvider service)
        {
            ISession session = service.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = service.GetService<ApplicationDbContext>();
            string basketId = session.GetString("BasketId") ?? Guid.NewGuid().ToString();
            session.SetString("BasketId", basketId);
            
            return new Basket(context) { BasketId = basketId }; 
        }

        public void AddToBasket(Product product)
        {
            this.db.BasketItem.Add(new BasketItem
            {
                BasketId = BasketId,
                Product = product
            });

            db.SaveChanges();
        }

        public List<BasketItem> GetBasketItems()
        {
            return db.BasketItem.Where(b => b.BasketId == BasketId).Include(b => b.Product).ToList();
        }
    }
}
