using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AON_Freelancing.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Project : ControllerBase
    {
        private static List<Project> project = new List<Project>();
        [HttpGet]
        public IActionResult getallproject()
        {
            return Ok(project);
        }
        [HttpPost]
        public IActionResult StoreNewProject(Project project)
        {
            return Ok();

        }
        [HttpGet("{id}")]
        public IActionResult GettheId(int id)
        {
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteId(int id)
        {
            return Ok();
        }

    }
}


