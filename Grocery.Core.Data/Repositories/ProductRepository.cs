using Grocery.Core.Interfaces.Repositories;
using Grocery.Core.Models;

namespace Grocery.Core.Data.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly List<Product> products;
        public ProductRepository()
        {
            products = [
                
                 //* 4 new products
                 new Product(1, "Melkvoorraad", 300),
                 new Product(2, "Kaas", 100),
                 new Product(3, "Brood", 400),
                 new Product(4, "Cornflakes", 0)
                ];
        }
        public List<Product> GetAll()
        {
            return products; //Products list returned
        }

        public Product? Get(int id)
        {
            return products.FirstOrDefault(p => p.Id == id);
        }

        public Product Add(Product item)
        {
            throw new NotImplementedException();
        }

        public Product? Delete(Product item)
        {
            throw new NotImplementedException();
        }

        public Product? Update(Product item)
        {
            throw new NotImplementedException();
        }
    }
}
