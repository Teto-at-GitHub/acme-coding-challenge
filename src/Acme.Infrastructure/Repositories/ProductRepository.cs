using System.Threading.Tasks;
using Acme.Domain.AggregatesModel.ProductAggregate;
using Acme.Domain.Seedwork;

namespace Acme.Infrastructure.Repositories;

public class ProductRepository : IProductRepository
{
   public IUnitOfWork UnitOfWork => throw new System.NotImplementedException();

   public Product Add(Product product)
   {
      throw new System.NotImplementedException();
   }

   public Task<Product> GetAsync(uint productId)
   {
      throw new System.NotImplementedException();
   }

   public void Update(Product product)
   {
      throw new System.NotImplementedException();
   }
}