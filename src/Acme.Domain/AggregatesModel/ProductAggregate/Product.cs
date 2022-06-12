using System;
using System.Collections.Generic;
using Acme.Domain.Seedwork;

namespace Acme.Domain.AggregatesModel.ProductAggregate;

public class Product : Entity, IAggregateRoot
{
   private string _name;

   private string _description;

   private uint _price;

   private Guid _guid;

   public uint? GetWarehouseId => _warehouseId;

   private uint? _warehouseId;

   private readonly List<ProductPicture> _productPictures;

   public IReadOnlyCollection<ProductPicture> ProductPictures => _productPictures;

   private DangerLevel _dangerLevel;

   public Product(string name, string description, string dangerLevel, uint price, uint? warehouseId)
   {
      _name = name;
      _description = description;
      _dangerLevel = (DangerLevel)Enum.Parse(typeof(DangerLevel), dangerLevel, true);
      _price = price;
      _warehouseId = warehouseId;
   }

}
