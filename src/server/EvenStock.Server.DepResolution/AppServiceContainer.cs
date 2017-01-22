using LightInject;

namespace Hse.IoC
{
    public class AppServiceContainer : ServiceContainer
    {
        public AppServiceContainer()
        {
            Register<ICommandBus, CommandBus>(new PerContainerLifetime());
            Register<IAppBootstrapper, AppBootstrapper>(new PerContainerLifetime());
        }

        public static IServiceContainer Default { get; } = new AppServiceContainer();
    }
}
