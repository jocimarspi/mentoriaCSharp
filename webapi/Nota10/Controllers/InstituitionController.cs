using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        public InstituitionsController(InstituitionService instituitionService){
            _instituitionService = instituitionService;
        }

        // GET api/instituitions
        [HttpGet]
        public ActionResult<IEnumerable<Instituition>> Get()
        {
            return _instituitionService.All();
        } 

        // GET api/instituitions/5
        [HttpGet("{id}")]
        public ActionResult<IEnumerable<Instituition>> Get(int id)
        {
            var instituition = _instituitionService.FindById(id);
            var instituitions = new List<Instituition>();
            instituitions.Add(instituition);

            return instituitions;
        }
        
        // POST api/instituitions
        [HttpPost]
        public void Post([FromBody] string value)
        {
            var teste = "teste";
        }

        // PUT api/instituitions/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            var teste = "teste";
        }

        // DELETE api/instituitions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _instituitionService.DeleteById(id);
        }
    }
}
