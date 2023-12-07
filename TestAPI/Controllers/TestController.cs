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

        /// <summary>
        /// Get all lines
        /// </summary>

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet]
        public ActionResult<IEnumerable<Test>> GetAll()
        {
            return Ok(_manager.GetAll());
        }

        /// <param name="id">Enter the user id</param>
        /// 
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet("{id}")]
        public ActionResult<Test> GetById(int id)
        {
            return _manager.GetByID(id);
        }
        /// <summary>
        /// Get latest timestamp for the table
        /// </summary>
        /// <returns></returns>

        [HttpGet("latest")]
        public ActionResult<Test> Get()
        {
            return Ok(_manager.Get());
        }

        /// <summary>
        /// POST one line
        /// </summary>

        /// <remarks>
        /// Sample request:
        ///
        ///     POST /api/Test
        ///{
        ///  "id": 0,
        ///  "productname": "string",
        ///  "invoiceunitprice": 0,
        ///  "quantity": 0,
        ///  "serversubtotal": 0,
        ///  "servertimestamp": "2023-12-05t11:50:45.468z",
        ///  "serverunitprice": 0,
        ///  "sitename": "string",
        ///  "siteno": 0,
        ///  "terminaltimestamp": "2023-12-05t11:50:45.468z",
        ///  "latitude": 0,
        ///  "longitude": 0,
        ///  "bitimestamp": "2023-12-05t11:50:45.468z"
        ///}
        ///
        /// </remarks>
        /// <returns>A newly created TodoItem</returns>
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
