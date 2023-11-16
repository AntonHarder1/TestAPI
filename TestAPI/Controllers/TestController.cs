using TestAPI.Manager;
using TestAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using Swashbuckle.AspNetCore.Swagger;


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
        
     
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet("{id}")]
        public ActionResult<Test> GetById(int id)
        {
            return _manager.GetByID(id);
        }
        /// <summary>
        /// Test af GetById
        /// </summary>
        /// <returns></returns>

        [HttpGet("latest")]
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
