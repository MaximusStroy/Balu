using Balu.Data.Interfaces;
using Balu.Data.Models;
using System;

namespace Balu.Data.Repository
{
    public class OrdersRepository : IOrder
    {
        private readonly ApplicationDbContext db;
        private readonly Basket basket;
        public OrdersRepository(ApplicationDbContext db, Basket basket)
        {
            this.db = db;
            this.basket = basket;
        }

        public void createOrder(Order order)
        {
            order.DateOrder = DateTime.Now;
            db.Order.Add(order);

            var items = basket.ListItemsInBasket;
            foreach (var item in items)
            {
                OrderDetail detail = new OrderDetail()
                {
                    ProductId = item.Product.Id,
                    OrderId = item.Id,
                    Price = item.Product.Price
                };
                db.OrderDetail.Add(detail);
            }

            db.SaveChanges();
        }
    }
}
