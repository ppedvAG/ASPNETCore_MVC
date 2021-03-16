using ASPNETCoreMVC_Overview.Models;
using DICarSample;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Westwind.AspNetCore.LiveReload;

namespace ASPNETCoreMVC_Overview
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services) // -> IServiceCollection Einstieg f�r IOC Container -> ServiceProvier wird daraus erstellt
        {
            //services.AddMvc();// Alte Schreibweise f�r MVC 
            services.AddControllersWithViews().AddRazorRuntimeCompilation(); //Neue Schreibweise //verewnde das MVC Framework


            services.Configure<SampleWebSettings>(Configuration);

            services.AddSingleton(typeof(ICar), typeof(MockCar));//
   
            services.AddSingleton(typeof(ICarService), typeof(CarService));

            services.AddLiveReload();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseLiveReload();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts(); 
            }
            
            app.UseHttpsRedirection(); 
            app.UseStaticFiles();
            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
