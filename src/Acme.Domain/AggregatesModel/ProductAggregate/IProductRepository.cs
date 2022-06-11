using System.Threading.Tasks;
using Acme.Domain.Seedwork;

namespace Acme.Domain.AggregatesModel.ProductAggregate;

public interface IProductRepository : IRepository<Product>
{
   Product Add(Product product);

   void Update(Product product);

   Task<Product> GetAsync(uint productId);
}