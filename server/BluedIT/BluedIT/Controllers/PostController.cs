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
        [Route("PostId")]
        public IActionResult GetPostById(int PostId)
        {
            Context context = new Context();
            return Ok(context.Posts.Find(PostId));
        }

        [HttpDelete]
        [Route("PostId")]
        public IActionResult DeletePostById(int postId)
        {
            Context context = new Context();
            Post post = context.Posts.Find(postId);
            if (postId != 0)
            {
                context.Remove(post);
                context.SaveChanges();
                return Ok();
            }
            return NotFound();
        }
    }
}
