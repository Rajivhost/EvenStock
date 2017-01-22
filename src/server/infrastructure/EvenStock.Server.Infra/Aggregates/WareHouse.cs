using Even;
using Hse.Contracts.Commands;
using Hse.Contracts.Events;
using Hse.Domain.States;

namespace Hse.Domain.Aggregates
{
    public class WareHouse : Aggregate
    {
        public WareHouse()
        {
            OnCommand<CreateWareHouse>(command =>
            {
                Persist(new WarehouseCreated(command.Id, command.Name));
            });

            OnEvent<WarehouseCreated>(@event =>
            {
                
            });
        }

        public WareHouseState State { get; private set; } = WareHouseState.Empty;
    }
}
