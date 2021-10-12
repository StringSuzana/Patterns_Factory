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
            Shirt shirt = Server.GetShirt();
            return shirt;
        }

        private static Cake CreateCake()
        {
            Cake cake = Server.GetCake();
            return cake;
        }

        private static Ball CreateBall()
        {
            Ball ball = Server.GetBall();
            return ball;
        }
    }
}
