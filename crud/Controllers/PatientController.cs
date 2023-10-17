using crud.PostgreSQL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
        [HttpGet("pagination")]
        public async Task<IActionResult> Get(int limit = 10, int offset = 0)
        {
            var items = await hisContext.Patients
                .Skip(offset).Take(limit)
                .ToListAsync();
            var total = await hisContext.Patients.CountAsync();
            return Ok(new { total, limit, offset, items });
        }
        // GET: api/<PatientController>
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var list = await hisContext.Patients.FindAsync(id);
            return Ok(list);
        }

        // GET api/<PatientController>/5
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var list = await hisContext.Patients.ToListAsync();
            return Ok(list);
        }

        // POST api/<PatientController>
        [HttpPost]
        public async Task<IActionResult> Post(Patient pt)
        {
            var result = await hisContext.Patients.AddAsync(pt);
            await hisContext.SaveChangesAsync();
            return Ok(result);
        }

        // PUT api/<PatientController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, Patient pt)
        {
            var target = await hisContext.Patients.FirstOrDefaultAsync( x => x.PatientId == id);
            if (target == null) return NotFound();

            target.idno = pt.idno;
            target.gender = pt.gender;
            target.Name = pt.Name;
            await hisContext.SaveChangesAsync();

            return Ok();
        }

        // DELETE api/<PatientController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            // Retrieve the entity by id
            var entity = await hisContext.Patients.FirstOrDefaultAsync(x => x.PatientId == id);
            if (entity == null) return NotFound();

            hisContext.Patients.Remove(entity);
            await hisContext.SaveChangesAsync();

            return Ok();
        }
    }
}
