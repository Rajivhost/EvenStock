using LightInject;

namespace Hse.IoC
{
    public class AppServiceContainer : ServiceContainer
    {
        public IServiceContainer Default { get; } = new AppServiceContainer();
    }
}
