using Microsoft.AspNetCore.Mvc;
using TestAPI.Services;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LastController : ControllerBase
    {
        // GET: api/<LastController>
        DbConnect db = new DbConnect();

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
           
            var x = db.Forbind();
            Console.WriteLine("db færdig" + DateTime.Now);
            return new string[] { "value1" , "value2" };
        }

        // GET api/<LastController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<LastController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<LastController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<LastController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
