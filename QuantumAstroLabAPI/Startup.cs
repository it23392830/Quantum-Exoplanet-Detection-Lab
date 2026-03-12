using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
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

        // Configure Services
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            // Register custom services
            services.AddScoped<SignalGeneratorService>();
            services.AddScoped<PlanetDetectionService>();

            // CORS POLICY
            services.AddCors(options =>
            {
                options.AddPolicy("AllowFrontend",
                    builder =>
                    {
                        builder
                            .AllowAnyOrigin()
                            .AllowAnyHeader()
                            .AllowAnyMethod();
                    });
            });

            // Swagger
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

                // Fix Railway server port issue
                c.AddServer(new OpenApiServer
                {
                    Url = "/"
                });
            });
        }

        // Configure HTTP Pipeline
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json",
                    "Quantum Exoplanet Detection API V1");

                c.RoutePrefix = "swagger";
            });

            app.UseRouting();

            app.UseCors("AllowFrontend");

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}