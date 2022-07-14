using System;
using System.Collections.Generic;

namespace Balu.Data.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public DateTime DateOrder { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
    }
}
