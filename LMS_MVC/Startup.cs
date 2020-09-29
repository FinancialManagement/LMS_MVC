using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Alipay.AopSdk.AspnetCore;
using Alipay.AopSdk.F2FPay.AspnetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace LMS_MVC
{
    public class Startup//1
    {
        public Startup(IConfiguration configuration)//1
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            Console.WriteLine(Configuration["Alipay:AlipayPublicKey"]);
            services.AddAlipay(options =>
            {
                options.AlipayPublicKey = Configuration["Alipay:AlipayPublicKey"];
                options.AppId = Configuration["Alipay:AppId"];
                options.CharSet = Configuration["Alipay:CharSet"];
                options.Gatewayurl = Configuration["Alipay:Gatewayurl"];
                options.PrivateKey = Configuration["Alipay:PrivateKey"];
                options.SignType = Configuration["Alipay:SignType"];
                options.Uid = Configuration["Alipay:Uid"];
            }).AddAlipayF2F();

            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
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

            app.UseExceptionHandler(errorApp =>
            {
                errorApp.Run(async context =>
                {
                    context.Response.StatusCode = 500;
                    if (context.Request.Headers["X-Requested-With"] != "XMLHttpRequest")
                    {
                        context.Response.ContentType = "text/html";
                        await context.Response.SendFileAsync($@"{env.WebRootPath}/errors/500.html");
                    }
                });
            });
            app.UseStatusCodePagesWithReExecute("/errors/{0}");

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Collection}/{action=Index}/{id?}");
            });
        }
    }
}
