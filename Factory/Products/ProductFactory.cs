using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    class ProductFactory
    {
        public static Product MakeProduct(string name)
        {
            switch (name.ToUpper())
            {
                case nameof(ProductEnum.BALL):
                    var ball = CreateBall();
                    return ball;
                case nameof(ProductEnum.CAKE):
                    var cake = CreateCake();
                    return cake;
                case nameof(ProductEnum.SHIRT):
                    var shirt = CreateShirt();
                    return shirt;
                default:
                    return null;
            }
        }

        private static Shirt CreateShirt()
        {
            return new Shirt();
        }

        private static Cake CreateCake()
        {
            return new Cake();
        }

        private static Ball CreateBall()
        {
            return new Ball();
        }
    }
}
