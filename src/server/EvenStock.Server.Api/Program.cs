using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hse;
using Hse.Contracts.Commands;
using Hse.IoC;
using LightInject;

namespace EvenStock.Server.Api
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceContainer = AppServiceContainer.Default;

            var appBootstrapper = serviceContainer.GetInstance<IAppBootstrapper>();

            appBootstrapper.RunAsync().Wait();

            var commandBus = serviceContainer.GetInstance<ICommandBus>();

            commandBus.SendAsync(new CreateWareHouse(Guid.NewGuid(), "La Gare")).Wait();

            Console.Read();
        }
    }
}
