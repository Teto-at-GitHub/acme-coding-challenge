using Acme.Domain.AggregatesModel.ProductAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Acme.Infrastructure.EntityConfiguration;

public class ProductEntityTypeConfiguration : IEntityTypeConfiguration<Product>
{
   public void Configure(EntityTypeBuilder<Product> productConfiguration)
   {
      productConfiguration.ToTable("product", ProductContext.DEFAULT_SCHEMA);

      productConfiguration.HasKey(x => x.Id);

      productConfiguration
         .Property<string>("_name")
         .HasColumnName("name")
         .IsRequired(false);

      productConfiguration
         .Property<string>("_description")
         .HasColumnName("description")
         .IsRequired(false);

      productConfiguration
         .Property<int>("_price")
         .HasColumnName("price")
         .IsRequired(true);

      productConfiguration
         .Property<string>("_dangerLevel")
         .HasColumnName("danger_level")
         .IsRequired(false);

      productConfiguration
         .Property<int>("_warehouseId")
         .UsePropertyAccessMode(PropertyAccessMode.Field)
         .HasColumnName("warehouse_id")
         .IsRequired(true);

   }

}