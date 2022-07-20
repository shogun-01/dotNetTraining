using Microsoft.AspNetCore.Mvc;
using WebApplicationAPI.Models;

namespace WebApplicationAPI.Controllers
{
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly StudentsContext _context;

        public StudentController(StudentsContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("[Action]")]
        public async Task<ActionResult<List<Student>>> Index()
        {
            List<Student> users = new List<Student>();

            users.Add(new Student() { StudentId = 1, FirstName = "Aravind", LastName = "S", Address = "asdasd",Contact="123123",RollNo="23" }) ;

            return Ok(_context.Students.ToList<Student>().ToList<Student>());
        }

        [HttpPost]
        [Route("[Action]")]
        public async Task<ActionResult<Object>> Create(Student user)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _context.Add(user);
                    await _context.SaveChangesAsync();
                    return Ok(new { msg = "Success" });
                }
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
            return BadRequest(new { msg = "Something went wrong" });
        }

        [HttpGet]
        [Route("[Action]/{id}")]
        public async Task<ActionResult<Object>> GetUser(int id)
        {
            if (id == null || _context?.Students == null)
                return BadRequest(new { msg = "Id parameter is missing" });
            var user = await _context.Students.FindAsync(id);
            if (user == null)
                return NotFound(new { msg = $"UCannot find user with userId {id}" });
            return Ok(user);
        }
    }
}
