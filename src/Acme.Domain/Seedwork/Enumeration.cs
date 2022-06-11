namespace Acme.Domain.Seedwork;

public abstract class Enumeration : IComparable
{
   public string Name { get; private set; }

   public int Id { get; private set; }

   protected Enumeration(int id, string name) => (Id, Name) = (id, name);

   public override string ToString() => Name;

   public int CompareTo(object obj) => Id.CompareTo((((Enumeration)obj).Id));

}