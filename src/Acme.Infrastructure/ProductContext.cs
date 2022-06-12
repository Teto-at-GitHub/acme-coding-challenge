using System.Threading;
using System.Threading.Tasks;
using Acme.Domain.AggregatesModel.ProductAggregate;
using Acme.Domain.AggregatesModel.WarehouseAggregate;
using Acme.Domain.Seedwork;
using Microsoft.EntityFrameworkCore;

namespace Acme.Infrastructure;

public class ProductContext : DbContext, IUnitOfWork
{

   public DbSet<Product> Products { get; set; }

   public DbSet<Warehouse> Warehouses { get; set; }

   public DbSet<ProductPicture> ProductPictures { get; set; }

   public ProductContext(DbContextOptions<ProductContext> options) : base(options)
   {

   }


   public Task<bool> SaveEntitiesAsync(CancellationToken cancellationToken = default)
   {
      throw new System.NotImplementedException();
   }

   protected override void OnModelCreating(ModelBuilder modelBuilder)
   {
      modelBuilder.UseSerialColumns();
   }
}