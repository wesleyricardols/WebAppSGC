using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using SGC.Infrastructure.Data;
using System;

namespace SGC.UI.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IWebHost host = BuildWebHost(args);

            using(IServiceScope scope = host.Services.CreateScope())
            {
                IServiceProvider services = scope.ServiceProvider;

                try
                {
                    ClienteContext context = services.GetRequiredService<ClienteContext>();
                    DbInitializer.Initialize(context);
                }
                catch(Exception ex)
                {
                    ILogger<Program> logger = services.GetRequiredService<ILogger<Program>>();
                    logger.LogError(ex, "Um erro ocorreu no método seeding do contexto");
                }
            }

            host.Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
    }
}
