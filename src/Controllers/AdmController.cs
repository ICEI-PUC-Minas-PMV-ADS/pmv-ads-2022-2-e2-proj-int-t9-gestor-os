using EnumsNET;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GestorOS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdmController : ControllerBase
    {
        // GET: api/<AdmController>
        [HttpGet]
        //   public Enums<string> Get()
        //   {
        //    return new string[] { "value1", "value2" };
        // }
        // GET api/<AdmController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<AdmController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<AdmController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<AdmController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
