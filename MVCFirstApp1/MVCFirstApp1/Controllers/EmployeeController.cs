using Microsoft.AspNetCore.Mvc;

namespace MVCFirstApp1.Controllers
{
    [Route("[controller]")]
    public class EmployeeController : Controller
    {
        [Route("Aravind")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
