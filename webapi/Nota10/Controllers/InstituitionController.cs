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

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Instituition>> Get()
        {
            return _instituitionService.All();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
