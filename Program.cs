using DIContainer;
using DIContainer.DependencyInjection;
using System;
using System.Collections.Generic;

namespace BlenderInjection;

public class Program
{
    static void Main(string[] args)
    {
        var services = new DiServiceCollection();

        //services.RegisterSingleton<RandomGuidGenerator>();
        //services.RegisterTransient<RandomGuidGenerator>();
        services.RegisterTransient<ISomeService, SomeServiceOne>();
        services.RegisterSingleton<IRandomGuidProvider, RandomGuidProviderFactory>();


        var container = services.GenerateContainer();

        var serviceFirst = container.GetService<ISomeService>();
        var serviceSecond = container.GetService<ISomeService>();

        serviceFirst.printSomething();
        serviceSecond.printSomething();
    }


}