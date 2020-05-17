using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
/*
 * 4. Добавьте в методы Configure и ConfigureServices класса вызов нужных методов для того чтоб работал вызов созданного 
 * вами метода из контроллера. 
Не стесняйтесь копировать 
]из проекта созданного по шаблону MVC, 
главное запомните, 
каких методов не хватало для правильного вызова метода в контроллере.
Чем меньше лишнего вы скопируете, тем лучше.
 */
namespace IntroductionHomeworkKukhar
{
    public class RedlineKukharHomework
    {

        private IConfiguration _config { get; set; }
       // private Logging logging { get; set; } 
      //  private IHostingEnvironment _env { get; set; }
        public RedlineKukharHomework(IConfiguration config)
        {
            _config = config;
        }
        public void ConfigureServices(IServiceCollection services)
        {
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
            }

            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    // await context.Response.WriteAsync(Microsoft.Hosting.Lifetime); нельзя так делать
                    // await context.Response.WriteAsync(_config["Logging"]);
                    //   await context.Response.WriteAsync(System.Diagnostics.Process.GetCurrentProcess().ProcessName); iisexpress
                    // await context.Response.WriteAsync(_config["Microsoft"]);
                    //  await context.Response.WriteAsync(_config["Microsoft.Hosting.Lifetime"]);
                    //await context.Response.WriteAsync(_config["Logging"]);
                    //await context.Response.WriteAsync(_config["Modules:Logging:Microsoft.Hosting.Lifetime"]);
                    await context.Response.WriteAsync(_config["Logging:LogLevel:Microsoft.Hosting.Lifetime"]);

                
                });
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}");

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=IntIndex}");
                   endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=DoubleIndex}");
                 endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=LongIndex}");
                  endpoints.MapControllerRoute(
                  name: "default",
                  pattern: "{controller=Home}/{action=CharIndex}");






            });


            
        }
        //public ContentResult onGet()
       // {
         ////   var defaultLogLevel = _config["Logging:LogLevel:Microsoft.Hosting.Lifetime"];
        //    return Content($"{defaultLogLevel}");
      //  }
    }
}
