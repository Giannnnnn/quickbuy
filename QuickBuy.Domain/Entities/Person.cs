using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Domain.Entities
{
    public class Person
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string SecondName { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
