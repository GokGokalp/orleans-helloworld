using System.Threading.Tasks;
using Orleans;

namespace HelloWorldGrainInterfaces
{
    /// <summary>
    /// Grain interface IHello
    /// </summary>
    public interface IHello : IGrainWithIntegerKey
    {
        Task<string> SayHello(string name);
    }
}