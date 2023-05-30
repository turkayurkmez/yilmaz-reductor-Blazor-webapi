using Microsoft.AspNetCore.Mvc;
using ProjectTracking.Application;

namespace ProjectTracking.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {
        private readonly IProjectService _projectService;

        public ProjectsController(IProjectService projectService)
        {
            _projectService = projectService;
        }

        [HttpGet]
        public async Task<IActionResult> GetProjects()
        {
            var projects = _projectService.GetProjects();
            return Ok(projects);
        }
    }
}
