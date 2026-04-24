using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace PersonalverwaltungBlazor.Client
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);

            await builder.Build().RunAsync();
        }
    }
}
