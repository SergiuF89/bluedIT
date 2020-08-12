using BluedIT.Data;
using BluedIT.Models;
using Microsoft.AspNetCore.Mvc;

namespace BluedIT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GroupController : ControllerBase
    {
        [HttpGet]
        [Route("{GroupName}")]

        public IActionResult GetByName(string groupname)
        {
            Context context = new Context();
            return Ok(context.Groups.Find(groupname));
        }

        [HttpPost]
        public void Post([FromBody] Group group)
        {
            Context context = new Context();
            context.Add(group);
            context.SaveChanges();
        }

        [HttpDelete]
        [Route("GroupName")]
        public IActionResult DeleteByName(string groupname, int id)
        {
            Context context = new Context();
            Group group = context.Groups.Find(groupname);
            User user = context.Users.Find(id);
            if (groupname != null && user.UserClass == "admin")
            {
                context.Remove(group);
                context.SaveChanges();
                return Ok();
            }

            return NotFound();
        }
        
    }
}
