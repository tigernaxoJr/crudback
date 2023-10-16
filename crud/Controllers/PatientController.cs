using crud.PostgreSQL;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace crud.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        private readonly HISContext hisContext;
        public PatientController(HISContext hISContext) { 
            this.hisContext = hISContext;
        }
        // GET: api/<PatientController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            hisContext.Add(new Blog());
            hisContext.SaveChanges();
            //hisContext.Patients.Add(new Patient());
            //hisContext.SaveChanges();
            //var a = hisContext.Patients;
            //var list = hisContext.Patients.ToList();
            return new string[] { "value1", "value2" };
        }

        // GET api/<PatientController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PatientController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<PatientController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PatientController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
