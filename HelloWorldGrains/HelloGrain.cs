using System.Threading.Tasks;
using Orleans;
using HelloWorldGrainInterfaces;

namespace HelloWorldGrains
{
    /// <summary>
    /// Grain implementation class HelloGrain.
    /// </summary>
    public class HelloGrain : Grain, IHello
    {
        public Task<string> SayHello(string name)
        {
            return Task.FromResult($"Hello {name}");
        }
    }
}