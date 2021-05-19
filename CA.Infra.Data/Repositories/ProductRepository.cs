using System.Collections.Generic;
using System.Threading.Tasks;
using CA.Domain.Entities;
using CA.Domain.Interfaces;
using CA.Infra.Data.Context;

namespace CA.Infra.Data.Repositories
{
    public class ProductRepository: IProductRepository
    {
        private ApplicationDbContext _context;

        public ProductRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Product> GetProducts()
        {
            return _context.Products;
        }

        public Task<Product> GetById(int? id)
        {
            throw new System.NotImplementedException();
        }

        public void Add(Product product)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Product product)
        {
            throw new System.NotImplementedException();
        }

        public void Remove(Product product)
        {
            throw new System.NotImplementedException();
        }
    }
}