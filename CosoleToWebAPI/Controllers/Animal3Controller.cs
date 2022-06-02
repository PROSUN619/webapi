using CosoleToWebAPI.Models;
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
  public class Animal3Controller : ControllerBase
  {
    public List<AnimalModel> props { get; set; }
    public Animal3Controller()
    {
      props = new List<AnimalModel>()
      {
          new AnimalModel(){ Id = 1, Name = "Dog" },
          new AnimalModel(){ Id = 1, Name = "Cat" }
      };
    }

    [Route("")]
    public IActionResult GetAnimals()
    {
      return Ok(props);
    }

    [Route("{id}")]
    public IActionResult GetAnimalsbyId(int id)
    {
      if (id == 0)
      {
        return BadRequest(); // return 400
      }
      var animal = props.Find(x => x.Id == id);
      if (animal == null)
      {
        return NotFound(); // return 404
      }

      return Ok(props);
    }

    [Route("test")]
    public IActionResult GetAnimalTest()
    {
      return LocalRedirect("~/api/animal3"); //return 301
      return LocalRedirectPermanent("~/api/animal3"); //return 302
    }
  }
}
