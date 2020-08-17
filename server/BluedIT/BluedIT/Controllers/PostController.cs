using BluedIT.Data;
using BluedIT.Models;
using Microsoft.AspNetCore.Mvc;

namespace BluedIT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        [HttpPost]
        public void Post([FromBody] Post post)
        {
            Context context = new Context();
            context.Add(post);
            context.SaveChanges();
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetById(int id)
        {
            Context context = new Context();
            return Ok(context.Posts.Find(id));
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
