using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace QuantumAstroLabAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args)
        {
            // Railway provides PORT environment variable
            var port = Environment.GetEnvironmentVariable("PORT") ?? "8080";

            return Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();

                    // Bind to Railway port
                    webBuilder.UseUrls($"http://0.0.0.0:{port}");
                });
        }
    }
}