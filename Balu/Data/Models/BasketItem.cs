﻿namespace Balu.Data.Models
{
    public class BasketItem
    {
        public int Id { get; set; }
        public Product Product { get; set; }
        public string BasketId { get; set; }
    }
}
