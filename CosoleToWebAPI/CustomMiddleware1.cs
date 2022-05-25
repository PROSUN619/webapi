using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CosoleToWebAPI
{
  public class CustomMiddleware1 : IMiddleware
  {
    public async Task InvokeAsync(HttpContext context, RequestDelegate next)
    {
      await context.Response.WriteAsync("Hello from Custom Middleware");
      await next(context);
    }
  }
}
