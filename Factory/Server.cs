using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Factory
{
    static class Server
    {
        private static string FILE_NAME = @"C:\Users\Suz\Desktop\Diplomski Algebra\Semester_02\Advanced Application Development Based on Development Templates\Assignments\Factory\Factory\Factory\products.txt";
     
        public static Ball GetBall()
        {
            string line = "";
            Ball ball = new Ball();
            using (StreamReader sr = new StreamReader(FILE_NAME))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    var props = line.Split(';');
                    if (props[0].ToUpper() == nameof(ProductEnum.BALL))
                    {
                        ball.fillProps(props);
                        break;
                    }
                }
            }
            return ball;

        }
        public static Shirt GetShirt()
        {
            string line = "";
            Shirt shirt = new Shirt();
            using (StreamReader sr = new StreamReader(FILE_NAME))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    var props = line.Split(';');
                    if (props[0].ToUpper() == nameof(ProductEnum.SHIRT))
                    {
                        shirt.fillProps(props);
                        break;
                    }
                }
            }
            return shirt;

        }
        public static Cake GetCake()
        {
            string line = "";
            Cake cake = new Cake();
            using (StreamReader sr = new StreamReader(FILE_NAME))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    var props = line.Split(';');
                    if (props[0].ToUpper() == nameof(ProductEnum.CAKE))
                    {
                        cake.fillProps(props);
                        break;
                    }
                }
            }
            return cake;

        }

        private static Product fillProps(this Product product, string[] props)
        {
            for (int i = 0; i < props.Length; i++)
            {
                product.Name = props[0];
                product.Price = double.Parse(props[1]);
                product.Discount = double.Parse(props[2]);
            }
            return product;
        }
    }
}
