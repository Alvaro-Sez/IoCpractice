using System;
namespace DIContainer
{
    internal interface IRandomGuidProvider
    {
        Guid RandomGuid { get; }
    }

    public class RandomGuidProviderFactory : IRandomGuidProvider
    {
        public Guid RandomGuid { get; } = Guid.NewGuid();
    }
}