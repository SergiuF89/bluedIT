using BluedIT.Data;
using BluedIT.Models;
using Microsoft.AspNetCore.Mvc;

namespace BluedIT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        [HttpPost]
        public void Comment([FromBody] Comment comment)
        {
            Context context = new Context();
            context.Add(comment);
            context.SaveChanges();
        }

        [HttpGet]
        [Route("{CommentId}")]
        public IActionResult GetbyId(int CommentId)
        {
            Context context = new Context();
            return Ok(context.Comments.Find(CommentId));
        }

        [HttpDelete]
        [Route("{CommentId}")]
        public IActionResult DeleteById(int CommentId)
        {
            Context context = new Context();
            Comment comment = context.Comments.Find(CommentId);
            if (comment.CommentId == CommentId)
            {
                context.Remove(comment);
                context.SaveChanges();
                return Ok();
            }
            return NotFound();
        }
    }
}
