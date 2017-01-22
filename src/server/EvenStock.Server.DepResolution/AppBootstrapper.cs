using System.Threading.Tasks;
using Akka.Actor;
using Even;
using Even.Persistence;
using Hse.IoC;

namespace Hse
{
    public class AppBootstrapper : IAppBootstrapper
    {
        public async Task RunAsync()
        {
            var memoryStore = new InMemoryStore();

            var actorSystem = ActorSystem.Create("stock");

            var gateWay = await actorSystem
                .SetupEven()
                .UseStore(memoryStore)
                .Start("even").ConfigureAwait(false);

            var serviceContainer = AppServiceContainer.Default;

            serviceContainer.RegisterInstance(gateWay);


            var actorRef = actorSystem.ActorOf<CommandActor>();

            serviceContainer.RegisterInstance(actorRef);
        }

    }
}
