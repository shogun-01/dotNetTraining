using Microsoft.AspNetCore.Mvc;

namespace MVCFirstApp1.Models
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
