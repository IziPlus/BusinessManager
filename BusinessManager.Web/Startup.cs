using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using BusinessManager.DataLeyer;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using BusinessManager.Services.Services;
using BusinessManager.Services.Repositories;
using ElmahCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BusinessManager.Web
{
    public class Startup
    {
        public IConfiguration Configuration { get; set; }
        public Startup(IConfiguration configuration)
        {
            this.Configuration = configuration;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

           
            services.AddDbContext<BMDBContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("BMDBContext"))
            );

            //services.AddAntiforgery(o => o.HeaderName = "XSRF-TOKEN");

            services.AddTransient<IMoshtari, MoshtariRepository>();
            services.AddTransient<IHesabMoshtari, HesabMoshtariRepository>();
            services.AddTransient<IRizFroosh, RizFrooshRipository>();

            services.AddTransient<IFrooshande, FrooshandeRipository>();
            services.AddTransient<IHesabFrooshande, HesabFrooshandeRipository>();
            services.AddTransient<IRizKharid, RizKharidRipository>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();
            //app.UseMvcWithDefaultRoute();
            app.UseMvc(routes =>
            {
                //routes.MapRoute(
                //  name: "areas",
                //  template: "{area:exists}/{controller=Moshtaris}/{action=Index}/{id?}"
                //);
                routes.MapRoute(
                    name: "Defult",
                    template: "{controller=Moshtaris}/{action=Index}/{id?}"
                    );
            });


            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync("Invalid Link Address ... ");
            //});
        }

      
    }
}
