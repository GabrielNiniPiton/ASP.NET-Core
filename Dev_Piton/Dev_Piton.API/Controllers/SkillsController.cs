using Dev_Piton.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Dev_Piton.API.Controllers
{
    [Route("api/skills")]
    public class SkillsController : ControllerBase
    {
        private readonly ISkillService _skillService;

        public SkillsController(ISkillService skillService)
        {
            _skillService = skillService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var skills = _skillService.GetAll();

            return Ok(skills);
        }
    }
}