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
  public class CountriesController : ControllerBase
  {
    [BindProperty]
    public string Name { get; set; }

    [HttpPost("")]
    public IActionResult AddCountry()
    {
      return Ok(this.Name);
    }
  }
}
