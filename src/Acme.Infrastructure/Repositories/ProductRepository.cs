using System.Threading.Tasks;
using Acme.Domain.AggregatesModel.ProductAggregate;
using Acme.Domain.Seedwork;

namespace Acme.Infrastructure.Repositories;

public class ProductRepository : IProductRepository
{
   private readonly ProductContext _context;
   public IUnitOfWork UnitOfWork => _context;

   public ProductRepository(ProductContext context)
   {
      _context = context ?? throw new ArgumentNullException(nameof(context));
   }

   public Product Add(Product product)
   {
      return _context.Products.Add(product).Entity;
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