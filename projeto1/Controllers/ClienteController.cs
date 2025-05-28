using Microsoft.AspNetCore.Mvc;

namespace projeto1.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Cliente()
        {
            return View();
        }
    }
}
