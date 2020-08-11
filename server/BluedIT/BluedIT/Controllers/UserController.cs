using BluedIT.Data;
using BluedIT.Models;
using Microsoft.AspNetCore.Mvc;

namespace BluedIT.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class UserController : ControllerBase
  {
    [HttpGet]
    [Route("{id}")]
    public IActionResult GetById(int id)
    {
      Context context = new Context();
      return Ok(context.Users.Find(id));
    }

    [HttpDelete]
    [Route("{id}")]
    public IActionResult DeleteById(int id)
    {
      Context context = new Context();
      User user = context.Users.Find(id);
      if (user != null)
      {
        context.Remove(user);
        context.SaveChanges();
        return Ok();
      }

      return NotFound();
    }

    [HttpPost]
    public void Add([FromBody] User user)
    {
      Context context = new Context();
      context.Add(user);
      context.SaveChanges();
    }
  }
}
