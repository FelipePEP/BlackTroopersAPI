using Microsoft.AspNetCore.Mvc;
using Infrastructure.Adapters;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrooperController : ControllerBase
    {
        // GET: api/<TrooperController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<TrooperController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<TrooperController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
            var useCase = new CreateTrooperAdapter(value);
            useCase.execute();
        }

        // PUT api/<TrooperController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TrooperController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
