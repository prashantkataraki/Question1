using MaerskCodingTestQuestion1.Repository;
using MaerskCodingTestQuestion1.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace MaerskCodingTestQuestion1
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddSingleton<IProcessOrderService, ProcessOrderService>();
            services.AddSingleton<IProductRepository, ProductRepository>();
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
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello!. Welcome to Maersk Coding Test\n\n" +
                    "Options available for actions\nUrl                Method  Action  Parameters\n" +
                    "api/test/Add/      Post    Add     Product\n" +
                    "api/test/Get/      Get     Get      --NA--\n" +
                    "api/test/Edit/     Post    Update  Product\n" +
                    "api/test/Calc/     Get     Get      --NA--\n\n\n" +
                    "Product JSON Format is as below\n" +
                    "{ \n   \"Sku\":\"A\", " +
                    "  \n   \"Quantity\":1 \n}" );
            });
        }
    }
}
