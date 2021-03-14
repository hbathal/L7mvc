using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContosoUniversity.Data;
using Microsoft.Extensions.DependencyInjection;
//tinfo200:[2021-03-13-<hbathal>-dykstra2]-- Adding 2 using statements to access student DB and 

namespace ContosoUniversity
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //tinfo200:[2021-03-13-<hbathal>-dykstra2]--replacing fluent API to check if DB exists
            var host = CreateHostBuilder(args).Build();

            CreateDbIfNotExists(host);

            host.Run();
        }

        //tinfo200:[2021-03-13-<hbathal>-dykstra2]-- calling DbInitializer class to create DB if DB is not found 
        private static void CreateDbIfNotExists(IHost host)
        {
            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                try
                {
                    var context = services.GetRequiredService<SchoolContext>(); //tinfo200:[2021-03-13-<hbathal>-dykstra2]--dependency injection container
                    DbInitializer.Initialize(context);
                }
                catch (Exception ex)
                {
                    var logger = services.GetRequiredService<ILogger<Program>>();
                    logger.LogError(ex, "An error occurred creating the DB.");
                }
            }
        }
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
