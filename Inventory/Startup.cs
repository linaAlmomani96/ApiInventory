using Business.SpecificRepostory;
using DataAccess.Context;
using DataAccess.Generic;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inventory
{
    public class Startup
    {
        private string _loginOrigin = "_loginOrigin";

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddScoped<IBrandService,BrandService>();
            services.AddScoped<ICategoryService,CategoryService>();
            services.AddScoped<IAttributeService,AttributeService>();
            services.AddScoped<IAttributeValueService,AttributeValueService>();
            services.AddScoped<ICompanyService,CompanyService>();
            services.AddScoped<ICountryService,CountryService>();
            services.AddScoped<ICurrencyService,CurrencyService>();
            services.AddScoped<IOrderService,OrderService>();
            services.AddScoped<IProductService,ProductService>();
            services.AddScoped<IStoreService, StoreService>();
            services.AddScoped(typeof(IServiceGeneric<>),typeof(ServiceGeneric<>));

            services.AddDbContext<InventoryContext>();
            services.AddCors(opt =>
            {
                opt.AddPolicy(_loginOrigin, builder =>
                {
                    builder.AllowAnyOrigin();
                    builder.AllowAnyHeader();
                    builder.AllowAnyMethod();
                });

            });




        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseCors(_loginOrigin);

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
