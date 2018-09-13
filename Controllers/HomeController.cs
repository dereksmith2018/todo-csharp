using Microsoft.AspNetCore.Mvc;


namespace ToDoList.Controllers
{
    public class HomeController : Controller
    {
        // public string Index() => "Hello from Tickets!";
        // [HttpGet("/")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
