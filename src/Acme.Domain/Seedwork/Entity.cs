namespace Acme.Domain.Seedwork;

public abstract class Entity
{
   int _Id;
   public virtual int Id
   {
      get
      {
         return _Id;
      }
      protected set
      {
         _Id = value;
      }
   }
}