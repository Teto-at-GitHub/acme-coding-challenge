using System.ComponentModel.DataAnnotations;

namespace Acme.Api.Dtos
{
   public class ProductDtoIn
   {
      [Required]
      public string Name { get; set; }
      public string Description { get; set; }

      public string DangerLevel { get; set; }

      [Required]
      [Range(0,10000)]
      public int Price { get; set; }

      public string WarehouseFriendlyId { get; set; }
   }
}