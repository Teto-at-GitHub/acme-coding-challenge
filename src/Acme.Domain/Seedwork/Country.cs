namespace Acme.Domain.Seedwork.Countries;

// A list of countries together with their 2-letter representation : https://en.wikipedia.org/wiki/ISO_3166-1
// Could be also kept in a json or xml file 
public static class Country
{
   public static Dictionary<String, String> Alpha2Codes = new(){
      {"Belgium","BE"},
      {"France","FR"},
      {"Germany", "DE"}
      // ...
   };

}