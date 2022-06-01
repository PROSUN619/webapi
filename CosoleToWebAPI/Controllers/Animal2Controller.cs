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
  public class Animal2Controller : ControllerBase
  {
    public List<AnimalModel> props { get; set; }
    public Animal2Controller()
    {
      props = new List<AnimalModel>()
      {
          new AnimalModel(){ Id = 1, Name = "Dog" },
          new AnimalModel(){ Id = 1, Name = "Cat" }
      };
    }

    [Route("{id}")]
    public ActionResult<AnimalModel> GetAnimal(int id)
    {
      return Ok(props.Find(x => x.Id == id));
    }

    [HttpPost("")]
    public IActionResult CreateAnimal(AnimalModel animalModel)
    {
      props.Add(animalModel);
      //return Created("~/api/animal2/"+ animalModel.Id, animalModel);
      return CreatedAtAction("GetAnimal", new {Id = animalModel.Id }, animalModel);
    }
  }
}
