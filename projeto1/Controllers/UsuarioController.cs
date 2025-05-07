using Microsoft.AspNetCore.Mvc;

namespace projeto1.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
