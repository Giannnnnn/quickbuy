using QuickBuy.Domain.Enumerable;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Domain.ValueObject
{
    public class PaymentOption
    {
        //in this case, as an value object, this ID is the Caracteristic of this object
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
		

        public bool isCash()
        {
            return this.Id == (int)PaymentOptionsTypeEnum.Cash;
        }
        public bool isCreditCard()
        {
            return this.Id == (int)PaymentOptionsTypeEnum.CreditCard;
        } 
        public bool isBillet()
        {
            return this.Id == (int)PaymentOptionsTypeEnum.Billet;
        }  
        public bool isNotDefined()
        {
            return this.Id == (int)PaymentOptionsTypeEnum.NotDefined;
        }
	}

}