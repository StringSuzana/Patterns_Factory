using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Factory
{
    public class Server : IServer
    {
        private readonly string FILE_NAME = @"C:\Users\Suz\Desktop\Diplomski Algebra\Semester_02\Advanced Application Development Based on Development Templates\Assignments\Factory\Factory\Factory\Data\products.txt";
        private readonly ILogger _logger;

        public Server(ILogger logger)
        {
            _logger = logger;
        }

        private List<String> GetProductsOnSaleNames()
        {
            List<String> products_on_sale_Names = new List<string>();
            string line = "";
            using (StreamReader sr = new StreamReader(FILE_NAME))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    var props = line.Split(';');
                    products_on_sale_Names.Add(props[0]);
                }
            }
            return products_on_sale_Names;

        }
        private Product fillProps(Product product, string[] props)
        {
            for (int i = 0; i < props.Length; i++)
            {
                product.Name = props[0];
                product.Price = double.Parse(props[1]);
                product.Discount = double.Parse(props[2]);
            }
            return product;
        }


        public List<Product> GetProductsOnSale()
        {
            string line = "";
            List<Product> prods = new List<Product>();
            using (StreamReader sr = new StreamReader(FILE_NAME))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    var props = line.Split(';');
                    Product product = ProductFactory.MakeProduct(props[0]);
                    fillProps(product, props);

                    prods.Add(product);

                    _logger.WriteToLogFile(product);

                }
            }
            return prods;
        }
    }

}
