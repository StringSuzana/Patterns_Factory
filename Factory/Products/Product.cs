using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    public abstract class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public double Discount { get; set; }
        public double GetDiscountPrice()
        {
            return Math.Round(Price * (1-(Discount/100)), 2);
        }
        public override string ToString()
        {
            return $"Product  \n Name: {Name} \n Price: {Price} \n Discount: {Discount} \n Discount price: {GetDiscountPrice()} % \n ";
        }
    }
}
