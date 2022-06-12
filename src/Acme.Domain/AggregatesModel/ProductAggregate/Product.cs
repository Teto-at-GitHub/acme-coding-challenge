using System;
using System.Collections.Generic;
using Acme.Domain.Seedwork;

namespace Acme.Domain.AggregatesModel.ProductAggregate;

public class Product : Entity, IAggregateRoot
{
   private string _name;

   private string _description;

   private int _price;

   private Guid _guid;

   public int GetWarehouseId => _warehouseId;

   private int _warehouseId;

   private readonly List<ProductPicture> _productPictures;

   public IReadOnlyCollection<ProductPicture> ProductPictures => _productPictures;

   private string _dangerLevel;

   public Product(string name, string description, string dangerLevel, int price, int warehouseId)
   {
      _name = name;
      _description = description;
      // 
      // (DangerLevel)Enum.Parse(typeof(DangerLevel), dangerLevel, true);
      _dangerLevel = dangerLevel;
      _price = price;
      _warehouseId = warehouseId;
   }

}
