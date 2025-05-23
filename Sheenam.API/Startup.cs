//=================================================
//Copyright (c) Coalition of Good-Hearted Engineers
//FreeTo Use To Find Comfort and Peace
//=================================================

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using Sheenam.API.Brokers.Storages;

namespace Sheenam.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration) =>
            Configuration = configuration;


        public IConfiguration Configuration { get; }


        public void ConfigureServices(IServiceCollection services)
        {
            var apiInfo = new OpenApiInfo
            {
                Title = "Sheenam.API",
                Version = "v1"
            };

            services.AddDbContext<StorageBroker>();
            services.AddTransient<IStorageBroker, StorageBroker>();
            services.AddControllers();

            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc(
                    name: "v1",
                    info: apiInfo);
            });
        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment environment)
        {
            if (environment.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();

                app.UseSwaggerUI(options =>
                {
                    options.SwaggerEndpoint(
                        url: "/swagger/v1/swagger.json",
                        name: "Sheenam.API v1");
                });
            }

            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
                endpoints.MapControllers());
        }
    }
}