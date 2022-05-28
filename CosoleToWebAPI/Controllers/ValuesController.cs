using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CosoleToWebAPI.Controllers
{
  [Route("api/[controller]/")]
  [ApiController]
  public class ValuesController : ControllerBase
  {
    [Route("[action]")]
    public string GetAll()
    {
      return "Hello from GetAll";
    }

    [Route("[action]")]
    public string GetAllAuthors()
    {
      return "Hello from GetAll Authors";
    }

    [Route("[action]/{id}")]
    public string GetBookbyId(int id)
    {
      return id.ToString();
    }

    [Route("[action]/{id}/{authid}")]
    public string GetBookbyAuthorId(int id, int authId)
    {
      return id.ToString() + " - " + authId.ToString();
    }

    //get method with query string
    [Route("[action]")]
    public string search(int id, string name, int age)
    {
      return id.ToString() + " - " + name.ToString() + " - " + age.ToString();
    }

  }
}
