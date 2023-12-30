using Catalog.API;
using DnsClient;
using Microsoft.AspNetCore.Hosting;
using System.Diagnostics;

internal class Program
{
    public static void Main(string[] args)
    {
        Activity.DefaultIdFormat = ActivityIdFormat.W3C;
        CreateHostBuilder(args).Build().Run();
    }

    private static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.UseStartup<Startup>();
            })/*.UseSerilog(Logging.ConfigureLogger)*/;
}