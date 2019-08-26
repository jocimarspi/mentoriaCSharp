using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Nota10.Models;
using Nota10.Services;

namespace Nota10.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InstituitionsController : ControllerBase
    {
        public readonly InstituitionService _instituitionService;

        public InstituitionsController(InstituitionService instituitionService)
        {
            _instituitionService = instituitionService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Instituition>> Get()
        {
            return _instituitionService.All();
        }

        [HttpGet("{id}")]
        public ActionResult<Instituition> Get(int id)
        {
            var instituition = _instituitionService.FindById(id);

            if (instituition == null)
            {
                return NotFound();
            }

            return instituition;
        }

        [HttpPost]
        public IActionResult Post([FromBody] Instituition instituition)
        {
            _instituitionService.Add(instituition);
            return NoContent();
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Instituition instituition)
        {
            if (id != instituition.Id)
            {
                return BadRequest();
            }

            _instituitionService.Update(instituition);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _instituitionService.DeleteById(id);
        }
    }
}
