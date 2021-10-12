using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Factory
{
    static class Logger
    {

        private static string FILE_NAME = @"C:\Users\Suz\Desktop\Diplomski Algebra\Semester_02\Advanced Application Development Based on Development Templates\Assignments\Factory\Factory\Factory\products.txt";
        private static string FILE_NAME_LOG = @"C:\Users\Suz\Desktop\Diplomski Algebra\Semester_02\Advanced Application Development Based on Development Templates\Assignments\Factory\Factory\Factory\logs.txt";

        public static void WriteInitialProducts()
        {
            string[] names = new string[] { "ball;20;10", "cake;3;1", "shirt;100;20" };

            using (StreamWriter sw = new StreamWriter(FILE_NAME))
            {
                foreach (string s in names)
                {
                    sw.WriteLine(s);
                }
            }
        }
        /// <summary>
        /// Call this function every 5 seconds.
        /// logs to an external log file information about the time product info was returned by server,
        /// name of the product and discount price
        /// 10/8/2020 3:21:03 PM;ball;10%
        /// </summary>
        public static void WriteToLogFile(Product selected_product)
        {
            var time = DateTime.Now.ToString("dd/MM/yyyy h:m:s tt");
            using (StreamWriter sw = File.AppendText(FILE_NAME_LOG))
            {
                sw.WriteLine($"{time};{selected_product?.Name};{selected_product?.Discount}%");
            }
        }
        public static void WriteToLogFile(object o)
        {
            Product selected_product =  o as Product;
            var time = DateTime.Now.ToString("dd/MM/yyyy h:m:s tt");
            using (StreamWriter sw = File.AppendText(FILE_NAME_LOG))
            {
                sw.WriteLine($"{time};{selected_product?.Name};{selected_product?.Discount}%");
            }
        }
        /// <summary>
        ///this is used for displaying a product
        ///When products.txt content is changed to “racket;300;40” following is displayed (without restarting the program):
        ///        
        ///Name: racket
        ///Price: 300
        ///Discount: 40%
        ///Discount price 180
        /// </summary>
        public static void ReadAllProductsToConsole()
        {
            string line = "";
            using (StreamReader sr = new StreamReader(FILE_NAME))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    var props = line.Split(';');

                    Product product = ProductFactory.MakeProduct(props[0]);
                    Console.WriteLine(product?.ToString());
                }
            }
        }

    }
}
