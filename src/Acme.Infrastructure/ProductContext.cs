using System.Threading;
using System.Threading.Tasks;
using Acme.Domain.AggregatesModel.ProductAggregate;
using Acme.Domain.AggregatesModel.WarehouseAggregate;
using Acme.Domain.Seedwork;
using Acme.Infrastructure.EntityConfiguration;
using Microsoft.EntityFrameworkCore;

namespace Acme.Infrastructure;

public class ProductContext : DbContext, IUnitOfWork
{
   public const string DEFAULT_SCHEMA = "acmedb";
   public DbSet<Product> Products { get; set; }

   //TODO
   // public DbSet<Warehouse> Warehouses { get; set; }
   // public DbSet<ProductPicture> ProductPictures { get; set; }

   public ProductContext(DbContextOptions<ProductContext> options) : base(options)
   {
      
   }


   public async Task<bool> SaveEntitiesAsync(CancellationToken cancellationToken = default)
   {
      var result = await base.SaveChangesAsync(cancellationToken);

      return true;
   }

   protected override void OnModelCreating(ModelBuilder modelBuilder)
   {
      modelBuilder.ApplyConfiguration(new ProductEntityTypeConfiguration());
      
      // modelBuilder.Entity<ProductPicture>().ToTable("picture");
      // modelBuilder.Entity<Warehouse>().ToTable("warehouse");
      // modelBuilder.Entity<Location>().ToTable("location");
   }
}