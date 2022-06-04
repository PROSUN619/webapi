using CosoleToWebAPI.ModelBinder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CosoleToWebAPI.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class Countries2Controller : ControllerBase
  {
    //using custom model binder
    [HttpGet("search")]
    public IActionResult SearchCountries([ModelBinder(typeof(CustomModelBinder))]string[] countries)
    {
      return Ok(countries);
    }
  }
}
