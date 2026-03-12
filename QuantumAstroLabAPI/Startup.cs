using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using QuantumAstroLabAPI.Services;
using Microsoft.OpenApi.Models;

namespace QuantumAstroLabAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // Configure Services (Dependency Injection)
        public void ConfigureServices(IServiceCollection services)
        {
            // Add controllers
            services.AddControllers();

            // Register custom services
            services.AddScoped<SignalGeneratorService>();
            services.AddScoped<PlanetDetectionService>();

            // CORS POLICY (Allows Angular Frontend)
            services.AddCors(options =>
            {
                options.AddPolicy("AllowAngular",
                    builder =>
                    {
                        builder.WithOrigins("http://localhost:4200")
                               .AllowAnyHeader()
                               .AllowAnyMethod();
                    });
            });

            // Register Swagger generator
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "Quantum Exoplanet Detection API",
                    Version = "v1",
                    Description = "API for generating star brightness signals and detecting possible exoplanets",
                    Contact = new OpenApiContact
                    {
                        Name = "Quantum Astro Lab",
                        Email = "astro@example.com"
                    }
                });
            });
        }

        // Configure HTTP request pipeline
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // Enable Swagger middleware
            app.UseSwagger();

            // Enable Swagger UI
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Quantum Exoplanet Detection API V1");
                c.RoutePrefix = "swagger";
            });

            app.UseRouting();

            // ENABLE CORS HERE
            app.UseCors("AllowAngular");

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}