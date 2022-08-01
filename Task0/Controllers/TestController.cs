using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Task0.Controllers
{
    public class TestController : Controller
    {
        // GET: TestController
        public ActionResult Message()
        {
            return View();
        }
    }
}
