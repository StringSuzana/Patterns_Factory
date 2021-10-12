using System;
using System.Threading;

namespace Factory
{
    class Program
    {
        /**
         * In Factory pattern, I create object without exposing the creation logic to the client and refer to newly created object using a COMMON INTERFACE.
         * 
         **/
        static void Main(string[] args)
        {
            Logger.WriteInitialProducts();
            Logger.ReadAllProductsToConsole();
            Console.WriteLine("Specify the product you want to watch:");
            var input = Console.ReadLine();
            Console.WriteLine($"You chose to watch the prices for the product: {input}");



            while (true)
            {
                Product product = ProductFactory.MakeProduct(input);
                Logger.WriteToLogFile(product);
                Thread.Sleep(30000);
            }
        }

    }
}
