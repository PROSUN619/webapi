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
  public class EmployeeController : ControllerBase
  {
    //here no need to mention the action method name
    [Route("")]
    public EmployeeModel GetAllEmployees()
    {
      return new EmployeeModel() { Id = 1, Name="John" };
    }
    
    //here no need to mention the action method name
    [Route("{id}")]
    public IActionResult GetAllEmployees(int id)
    {
      if (id == 0) return NotFound();
      return Ok(new EmployeeModel() { Id = 1, Name = "John" });
    }

    [Route("get-all/{id}")]
    public ActionResult<EmployeeModel> GetAllEmployeesDetails(int id)
    {
      if (id == 0) return NotFound();
      //return Ok(new Employee() { Id = 2, Name = "Mars" });
      //or
      return new EmployeeModel() { Id = 2, Name = "Mars" };
    }

  }
}
