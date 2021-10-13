using System.Collections.Generic;

namespace Factory
{
    public interface IServer
    {
        List<Product> GetProductsOnSale();
    }
}