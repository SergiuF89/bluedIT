using BluedIT.Data;
using BluedIT.Models;
using Microsoft.AspNetCore.Mvc;

namespace BluedIT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        [HttpPost]
        public void Post([FromBody] Category category)
        {
            Context context = new Context();
            context.Add(category);
            context.SaveChanges();
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetById(int id)
        {
            Context context = new Context();
            return Ok(context.Categories.Find(id));
        }

        [HttpDelete]
        [Route("{id}")]

        public IActionResult DeleteById(int id)
        {
            Context context = new Context();
            Category category = context.Categories.Find(id);
            if (category.CategoryId == id)
            {
                context.Remove(category);
                context.SaveChanges();
                return Ok();
            }
            return NotFound();
        }

        
    }
}
