using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Web.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly DataDbContext _dataDbContext;

        public ValuesController(DataDbContext dataDbContext)
        {
            _dataDbContext = dataDbContext;
        }
        // GET api/values
        //[HttpGet]
        //public ActionResult<IEnumerable<Value>> Get()
        //{
        //    return _dataDbContext.Values.ToList();
        //}
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Value>>> Get()
        {
            var data = await _dataDbContext.Values.ToListAsync();
            return Ok(data);
        }
        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Value>> Get(int id)
        {
            var data = await _dataDbContext.Values.FirstOrDefaultAsync(a => a.Id == id);

            return Ok(data);
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
