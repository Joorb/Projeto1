using Microsoft.AspNetCore.Mvc;
using projeto1.Repositorio;

namespace projeto1.Controllers
{
    public class UsuarioController : Controller
    {
        /*DECLARANDO UMA VARIAVEL PRIVADA SOMENTE PARA LEITURA DO TIPO UsuarioRepositorio chamada
	    _usuarioRepositorio  */

        private readonly UsuarioRepositorio _usuarioRepositorio;

        /* DEFININDO O CONSTRUTOR DA CLASSE USUARIO CONTROLLER QUE VAI RECEBER UMA INSTANCIA DE UsuarioRepositorio*/

        public UsuarioController(UsuarioRepositorio usuarioRepositorio) 
        { 
            _usuarioRepositorio = usuarioRepositorio;
        }
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string email, string senha)
        {
            return View();
        }

        public IActionResult Contato()
        {
            return View();
        }

    }
}
