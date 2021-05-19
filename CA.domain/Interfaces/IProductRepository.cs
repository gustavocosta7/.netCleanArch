using System.Collections.Generic;
using System.Threading.Tasks;
using CA.Domain.Entities;

namespace CA.Domain.Interfaces
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts();
        Task<Product> GetById(int? id);

        void Add(Product product);
        void Update(Product product);
        void Remove(Product product);
    }
}