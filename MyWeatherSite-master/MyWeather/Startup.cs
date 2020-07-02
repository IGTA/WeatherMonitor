using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace MyWeather
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }


        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseDeveloperExceptionPage(); // подключаем страницу с ошибками 
            app.UseStatusCodePages(); // показать коды страниц
            app.UseStaticFiles(); // подключаем статические файлы 
            app.UseMvcWithDefaultRoute(); // отслеживание url адреса и активация url по умолчанию

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync(
                    $"City: {WeatherData.instance.name}\n" +
                    $"Temp: {WeatherData.instance.main.temp}\n" +
                    $"Description: {WeatherData.instance.weather[0].description}");
            });
        }
    }
}
