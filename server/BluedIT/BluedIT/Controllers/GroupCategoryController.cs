using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BluedIT.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BluedIT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GroupCategoryController : ControllerBase
    {
        [HttpGet]
        [Route("{id}")]
        public IActionResult GetById(int id)
        {
            Context context = new Context();
            return Ok(context.GroupCategories.Find(id));
        }
    }
}
