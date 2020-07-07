using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WebAPI.Business;
using WebAPI.Business.Abstract;
using WebAPI.Business.Concrete;
using WebAPI.Business.Repositories;

namespace WebAPI.API
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddSingleton<IUserService, UserManager>();
            services.AddSingleton<IUserRepository, UserRepository>();
            services.AddSwaggerDocument(config =>
            {
                config.PostProcess = (doc =>
                  {
                      doc.Info.Title = "All Web Api";
                      doc.Info.Version = "v1.0.0.1";
                      doc.Info.Contact = new NSwag.OpenApiContact()
                      {
                          Name = "Aylin ÞAHAN",
                          Email = "sahanaylin@gmail.com"
                      };
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

            app.UseRouting();
            app.UseOpenApi();
            app.UseSwaggerUi3();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
