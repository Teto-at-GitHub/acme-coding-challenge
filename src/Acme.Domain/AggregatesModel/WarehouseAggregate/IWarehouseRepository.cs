using System;
using System.Threading.Tasks;
using Acme.Domain.AggregatesModel.WarehouseAggregate;
using Acme.Domain.Seedwork;

namespace Acme.Domain.AggregatesModel;

public interface IWarehouseRepository : IRepository<Warehouse>
{
   Warehouse Add(Warehouse warehouse);

   Warehouse Update(Warehouse warehouse);

   Task<Warehouse> GetAsyncByGuid(Guid guid);

   Task<Warehouse> GetAsyncById(uint id);
   
}