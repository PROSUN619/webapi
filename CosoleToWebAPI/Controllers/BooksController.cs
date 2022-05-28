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
  public class BooksController : ControllerBase
  {
    //if action method name not mentioned in route then in URL action name is not required
    //https://localhost:44345/api/books/1

    [Route("{id:number:min(10):max(100)}")]    
    public string GetBookbyId(int id)
    {
      return "Hello " + id;
    }

    [Route("{id:string}")]
    //https://localhost:44345/api/books/1
    public string GetBookbyStringId(string id)
    {
      return "Hello string " + id;
    }
  }
}
