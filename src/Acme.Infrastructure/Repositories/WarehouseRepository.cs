using System;
using System.Threading.Tasks;
using Acme.Domain.AggregatesModel;
using Acme.Domain.AggregatesModel.ProductAggregate;
using Acme.Domain.AggregatesModel.WarehouseAggregate;
using Acme.Domain.Seedwork;

namespace Acme.Infrastructure.Repositories;

public class WarehouseRepository : IWarehouseRepository
{
   public IUnitOfWork UnitOfWork => throw new NotImplementedException();

   public Warehouse Add(Warehouse warehouse)
   {
      throw new NotImplementedException();
   }

   public Task<Warehouse> GetAsyncByGuid(Guid guid)
   {
      throw new NotImplementedException();
   }

   public Task<Warehouse> GetAsyncById(uint id)
   {
      throw new NotImplementedException();
   }

   public Warehouse Update(Warehouse warehouse)
   {
      throw new NotImplementedException();
   }
}
