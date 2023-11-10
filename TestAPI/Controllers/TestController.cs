using TestAPI.Manager;
using TestAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections;

namespace TestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly ITestManagerDb _manager;

        public TestController(ItemDbContext context)
        {
            _manager = new TestManagerDb(context);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet]
        public ActionResult<IEnumerable<Test>> GetAll()
        {
            return Ok(_manager.GetAll());
        }

        [HttpGet("/latest")]
        public ActionResult<Test> Get()
        {
            return Ok(_manager.Get());
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPost]
        public ActionResult<Test> Create(Test test) 
        {
            _manager.Add(test);
            return test;
        }

    }
}
