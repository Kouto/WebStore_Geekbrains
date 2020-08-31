using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace WebStore_Geekbrains
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                // endpoints.MapDefaultControllerRoute(); // краткий аналог
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                // ћаршрут по умолчанию состоит из трЄх частей разделЄнных У/Ф
                // ѕервой частью указываетс€ им€ контроллера,
                // второй - им€ действи€ (метода) в контроллере,
                // третей - опциональный параметр с именем УidФ
                // ≈сли часть не указана - используютс€ значени€ по умолчанию:
                // дл€ контроллера им€ УHomeФ,
                // дл€ действи€ - УIndexФ


                //endpoints.MapGet("/", async context =>
                //{
                //    await context.Response.WriteAsync(helloString);
                //});
        });
        }
    }
}
