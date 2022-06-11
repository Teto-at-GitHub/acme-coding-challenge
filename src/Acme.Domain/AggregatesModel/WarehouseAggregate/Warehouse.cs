using Acme.Domain.Seedwork;
using Acme.Domain.Seedwork.Countries;

namespace Acme.Domain.AggregatesModel.Warehouse;

public class Warehouse : Entity, IAggregateRoot
{
   public Location Location { get; private set; }

   public uint MaxCapacity { get; private set; }

   // riendly identifier built as follow: {country}-{ZIP}-{incremental number of 6 digits} (e.g: BE-1070-000 001).
   public string FriendlyId { get; private set; }

   public Warehouse(Location location, uint maxCapacity)
   {
      Location = location;
      MaxCapacity = maxCapacity;
      FriendlyId = buildFriendlyId();
   }

   private string buildFriendlyId()
   {
      // we assume here that validation has been performed in the application layer
      // and thus there is no need to check again if all necessary fields are present
      string countryAlpha2Code = Country.Alpha2Codes[Location.Country];

      // NOTE
      // this is ok for a proof of concept,
      // but in real prod code one should not do this because :
      // - this breaks once the application gets at 10^6 warehouses
      // - you show details of the DB implementation 
      string zeroPaddedId = Id.ToString("D6");

      return $"{countryAlpha2Code}-{Location.ZipCode}-{zeroPaddedId}";
   }
}