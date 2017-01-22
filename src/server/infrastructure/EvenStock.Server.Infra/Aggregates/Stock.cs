using Even;
using Hse.Domain.States;

namespace Hse.Domain.Aggregates
{
    public class Stock : Aggregate
    {
        public StockState State { get; private set; } = StockState.Empty;
    }
}
