using Microsoft.AspNetCore.Mvc;

namespace Task0.Controllers
{
    public class ListController : Controller
    {
        public IActionResult Info()
        {
            return View();
        }
    }
}
