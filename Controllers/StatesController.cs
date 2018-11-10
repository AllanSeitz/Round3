using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Round3.Controllers
{
  [Route("api/[controller]")]
  [ApiController]

  public class StatesController : ControllerBase
  {
    [HttpGet]

    public IEnumerable<Models.States> get()
    {
      var db = new StatesContext();
      return db.States.OrderBy(o => o.Id);
    }
  }
}