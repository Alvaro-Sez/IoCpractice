using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIContainer
{
    internal class SomeServiceOne : ISomeService
    {
        private readonly IRandomGuidProvider _randomGuidProvider;

        public SomeServiceOne(IRandomGuidProvider randomGuidProvider)
        {
            _randomGuidProvider = randomGuidProvider;
        }

        public void printSomething()
        {
            Console.WriteLine(_randomGuidProvider.RandomGuid);
        }
    }
}
