using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EngineIoT.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace EngineIoT
{
    public class Startup
    {
        private readonly IConfiguration _config;

        public Startup(IConfiguration _config)
        {
            this._config = _config;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddDbContext<SmartHouseContext>(cfg => { cfg.UseSqlServer(_config.GetConnectionString("EngineIoTConnectionString")); });
            services.AddTransient<ISmartHouseRepository, SmartHouseRepository>();
            services.AddSignalR();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseForwardedHeaders(new ForwardedHeadersOptions
            {
                ForwardedHeaders = ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto
            });
            app.UseDeveloperExceptionPage();
            app.UseStaticFiles();
            app.UseStatusCodePages();
            app.UseMvc(route =>
            {
                route.MapRoute(name: "default", template: "{Controller}/{Action}/{id?}", defaults: new {Controller = "Home", Action = "Index"});
            });

        }
    }
}
