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
  public class AnimalController : ControllerBase
  {

    public List<AnimalModel> props { get; set; }
    public AnimalController()
    {
      props =  new List<AnimalModel>()
      {
          new AnimalModel(){ Id = 1, Name = "Dog" },
          new AnimalModel(){ Id = 1, Name = "Cat" }
      };
    }

    [Route("animal/{id}", Name = "animal")]
    public ActionResult<AnimalModel> GetAnimal(int id)
    {
      return Ok(props.Find(x => x.Id == id));
    }

    [Route("", Name ="data")]
    public ActionResult<AnimalModel> GetData()
    {
      return Ok(props.Find(x => x.Id == 1));
    }

    [Route("animals")]
    public IActionResult GetAnimals()
    {
      //return Accepted(); // return 202


      //return Accepted("animal", props); //return 202 along with complete URL 
      //return AcceptedAtAction("GetData");
      return AcceptedAtRoute("data");
    }
  }
}
