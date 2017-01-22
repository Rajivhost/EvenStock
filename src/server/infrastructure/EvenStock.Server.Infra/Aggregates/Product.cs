using Even;
using Hse.Domain.States;

namespace Hse.Domain.Aggregates
{
    public class Product : Aggregate
    {
        public ProductState State { get; private set; } = ProductState.Empty;
    }
}
