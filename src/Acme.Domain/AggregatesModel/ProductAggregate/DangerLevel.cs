using Acme.Domain.Seedwork;

namespace Acme.Domain.AggregatesModel.ProductAggregate;

public class DangerLevel : Enumeration
{
   public static DangerLevel Low = new DangerLevel(1,nameof(Low).ToLower());
   public static DangerLevel Medium = new DangerLevel(1,nameof(Medium).ToLower());
   public static DangerLevel High = new DangerLevel(1,nameof(High).ToLower());
   public DangerLevel(int id, string name) : base(id, name)
   {
   }
}