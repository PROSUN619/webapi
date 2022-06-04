using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CosoleToWebAPI.ModelBinder
{
  public class CustomModelBinder : IModelBinder
  {
    public Task BindModelAsync(ModelBindingContext bindingContext)
    {
      var data = bindingContext.HttpContext.Request.Query;
      var result = data.TryGetValue("countries", out var countries);

      if (result)
      {
        var array = countries.ToString().Split('|');
        bindingContext.Result = ModelBindingResult.Success(array);
      }

      return Task.CompletedTask;
    }
  }
}
