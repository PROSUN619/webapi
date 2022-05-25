using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CosoleToWebAPI
{
  public class Startup
  {
    public void ConfigureServices(IServiceCollection service)
    {
      service.AddControllers();
      //service.AddTransient<CustomMiddleware1>();
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {

      app.Use( async (context, next) =>
      {
         await context.Response.WriteAsync("Hello from Block 1 RUN 1\n");
         await next();
         await context.Response.WriteAsync("Hello from Block 1 RUN 2\n");
      });

      app.Use(async (context, next) =>
      {
        await context.Response.WriteAsync("Hello from Block 2 RUN 1\n");
        await next();
        await context.Response.WriteAsync("Hello from Block 2 RUN 2\n");
      });

      app.Use(async (context, next) =>
      {
        await context.Response.WriteAsync("Request Complete\n");
      });

      //app.UseMiddleware<CustomMiddleware1>();

      //app.Map("/prasun", customClass);

      // app.Run(async context =>
      //{
      //  await context.Response.WriteAsync("Hello from Block 3 RUN 1 \n");
      //  await context.Response.WriteAsync("Hello from Block 3 RUN 2 \n");
      //});



      if (env.IsDevelopment())
      {
        app.UseDeveloperExceptionPage();
      }

      app.UseRouting();

      app.UseEndpoints(endpoints =>
      {
        endpoints.MapControllers();  
      });
    }

    private void customClass(IApplicationBuilder app)
    {
      app.Use(async (context, next) =>
     {
       await context.Response.WriteAsync("Hello from Prasun");
     });
    }
  }
}
