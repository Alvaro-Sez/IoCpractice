using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIContainer.DependencyInjection
{
    public class DiServiceCollection
    {
        private List<ServiceDescriptor> _servicesDescriptors = new List<ServiceDescriptor>();

        
        public void RegisterSingleton<TService>(TService implementation)
        {
            _servicesDescriptors.Add(new ServiceDescriptor(implementation, ServiceLifetime.Singleton));
        }
        
        public void RegisterSingleton<TService>()
        {
            _servicesDescriptors.Add(new ServiceDescriptor(typeof(TService), ServiceLifetime.Singleton));
        }
        
        public void RegisterTransient<TService>()
        {
            _servicesDescriptors.Add(new ServiceDescriptor(typeof(TService), ServiceLifetime.Transient));
        }
        
        public void RegisterTransient<TService, TImplementation>() where TImplementation : TService
        {
            _servicesDescriptors.Add(new ServiceDescriptor(typeof(TService), typeof(TImplementation), ServiceLifetime.Transient));
        }
        
        public void RegisterSingleton<TService, TImplementation>() where TImplementation : TService
        {
            _servicesDescriptors.Add(new ServiceDescriptor(typeof(TService), typeof(TImplementation), ServiceLifetime.Singleton));
        }

        public DiContainer GenerateContainer()
        {
            return new DiContainer(_servicesDescriptors);
        }
    }
}
