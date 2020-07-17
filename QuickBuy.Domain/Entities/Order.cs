using QuickBuy.Domain.ValueObject;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Domain.Entities
{
   public class Order
    {
        public Guid Id { get; set; }
        public DateTime DateStart { get; set; }
        public Guid UserID { get; set; }
        public DateTime DeliverDateExpected { get; set; }
        public string Address { get; set; }
        public int PaymentOptionID { get; set; }
        public PaymentOption PaymentOption { get; set; }

    }
}
