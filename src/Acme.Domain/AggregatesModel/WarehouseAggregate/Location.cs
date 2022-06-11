using System;
using Acme.Domain.Seedwork;

namespace Acme.Domain.AggregatesModel.WarehouseAggregate;

public class Location : ValueObject
{
   public String Street { get; private set; }

   public uint StreetNr {get; private set;}
   public String City { get; private set; }
   public String Country { get; private set; }
   public String ZipCode { get; private set; }

   public Location() { }

   public Location(string street, string city, string state, string country, string zipcode)
   {
      Street = street;
      StreetNr = StreetNr;
      City = city;
      Country = country;
      ZipCode = zipcode;
   }

}