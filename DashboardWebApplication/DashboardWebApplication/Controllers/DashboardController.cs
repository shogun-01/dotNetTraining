using Microsoft.AspNetCore.Mvc;
using DashboardWebApplication.Models;

namespace DashboardWebApplication.Controllers
{
    [Route("[controller]")]
    public class DashboardController : Controller
    {
        [Route("details")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("ViewDetails")]
        public IActionResult GetStudentDetails()
        {
            List<StudentDetailsModel> students = getStudents();
            return View(students);
        }

        [Route("Save")]
        public IActionResult Save(StudentDetailsModel input)
        {
            if (!ModelState.IsValid)
            {
                return null;
            }
            return View();
        }
        private List<StudentDetailsModel> getStudents()
        {
            List<StudentDetailsModel> students = new List<StudentDetailsModel>();
            var student1 = new StudentDetailsModel();
            student1.FirstName = "James";
            student1.LastName = "Lyons";
            student1.RollNo = "001";
            student1.Contact = "123123123123";
            students.Add(student1);

            var student2 = new StudentDetailsModel();
            student2.FirstName = "Cheryl";
            student2.LastName = "Stanley";
            student2.RollNo = "002";
            student2.Contact = "321321312";
            students.Add(student2);

            var student3 = new StudentDetailsModel();
            student3.FirstName = "Goodwin";
            student3.LastName = "Simonds";
            student3.RollNo = "003";
            student3.Contact = "123321123";
            students.Add(student3);

            return students;
        }
    }

}
