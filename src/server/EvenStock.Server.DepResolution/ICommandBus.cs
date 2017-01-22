using System.Threading.Tasks;
using Akka.Actor;
using Even;
using Hse.Contracts.Commands;
using Hse.Domain.Aggregates;
using Hse.IoC;
using LightInject;

namespace Hse
{
    public interface ICommandBus
    {
        Task SendAsync<TCommand>(TCommand command);
    }

    public class CommandActor : ReceiveActor
    {
        public CommandActor()
        {
            var gateway = AppServiceContainer.Default.GetInstance<EvenGateway>();

            Receive<CreateWareHouse>(command =>
            {
                gateway.SendAggregateCommand<WareHouse>(command.Id, command);
            });
        }
    }

    public class CommandBus : ICommandBus
    {
        private readonly IActorRef _busActor;

        public CommandBus(IActorRef busActor)
        {
            _busActor = busActor;
        }

        public Task SendAsync<TCommand>(TCommand command)
        {
            _busActor.Tell(command);
            return Task.CompletedTask;
        }
    }
}