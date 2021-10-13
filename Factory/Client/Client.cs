using System.Collections.Generic;
using System.Threading;

namespace Factory
{
    public class Client
    {

        private readonly IServer _server;
        private readonly ILogger _logger;

        public Client(IServer server, ILogger logger)
        {
            _server = server;
            _logger = logger;

        }
        public void Start()
        {
            while (true)
            {
                List<Product> products = _server.GetProductsOnSale();
              
                _logger.WriteToConsole("====================<<PRODUCTS ON SALE>>=======================");
                foreach (var p in products)
                {
                    _logger.WriteToConsole(p);
                }

                Thread.Sleep(5000);
            }
        }

    }
}
