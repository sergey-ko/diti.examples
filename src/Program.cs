using System.Threading.Tasks;
using SBCE.DT.Host;

namespace DiTi.Examples
{
    class Program
    {
        static async Task Main(string[] args)
        {
            await Deployment.RunAsync<Pendulum>();
        }
    }
}
