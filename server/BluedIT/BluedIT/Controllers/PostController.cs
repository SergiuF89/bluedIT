using BluedIT.Data;
using BluedIT.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace BluedIT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        [HttpPost]
        [Route("user/{userId}/group/{groupId}")]
        public void Post([FromBody] Post post, int userId, int groupId)
        {
            Context context = new Context();
            post.User = context.Users.Find(userId);
            post.Group = context.Groups.Find(groupId);
            
            context.Add(post);
            context.SaveChanges();
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetById(int id)
        {
            Context context = new Context();
            Post post = context.Posts.Find(id);
            context.Entry(post).Reference(u => u.User).Load();
            context.Entry(post).Reference(g => g.Group).Load();
            return Ok(post);
        }

        [HttpDelete]
        [Route("{id}")]
        public ActionResult DeleteById(int id)
        {
            Context context = new Context();
            Post post = context.Posts.Find(id);
            if (post.Id == id)
            {
                context.Remove(post);
                context.SaveChanges();
                return Ok();
            }
            return NotFound();
        }
    }
}
