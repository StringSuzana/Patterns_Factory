using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    class Ball : Product
    {
        public new double GetDiscountPrice()
        {
            Console.WriteLine("GetDiscountPrice in Ball class");
            return Price * Discount;
        }
    }
}
