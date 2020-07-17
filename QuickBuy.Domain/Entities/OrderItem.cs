using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Domain.Entities
{
    public class OrderItem
    {
        public Guid Id { get; set; }
        public Guid ProductID { get; set; }
        public int Quantity { get; set; }
    }
}
