using GroceryStoreAPI.Interfaces;
using GroceryStoreAPI.Models;
using GroceryStoreAPI.Repositories;
using GroceryStoreAPI.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace GroceryStoreAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddScoped<IGroceryStoreService, GroceryStoreService>();
            services.AddScoped<IGroceryStoreRepository, GroceryStoreRepository>();

             services.AddScoped(typeof(IDataRepository<>), typeof(DataRepository<>));
            services.AddScoped(typeof(IDataRepository<Customers>), typeof(CustomerRepository));
            services.AddScoped(typeof(IDataRepository<Orders>), typeof(OrdersRepository));
            services.AddScoped(typeof(IDataRepository<Products>), typeof(ProductsRepository));
            

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
