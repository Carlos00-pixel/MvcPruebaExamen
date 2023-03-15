using Microsoft.AspNetCore.Mvc;
using MvcPruebaExamen.Helpers;
using MvcPruebaExamen.Models;
using MvcPruebaExamen.Repositories;

namespace MvcPruebaExamen.Controllers
{
    public class UsuariosController : Controller
    {
        private RepositoryUsuarios repo;
        private List<Usuario> user;

        public UsuariosController(RepositoryUsuarios repo)
        {
            this.repo = repo;
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register
            (string nombre, string email, string password, string imagen)
        {
            await this.repo.RegisterUser(nombre, email, password, imagen);
            ViewData["MENSAJE"] = "Usuario registrado correctamente";
            return RedirectToAction("Login");

        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string email, string password)
        {
            Usuario user = this.repo.LogInUser(email, password);
            if (user == null)
            {
                ViewData["MENSAJE"] = "Credenciales incorrectas";
                return View();

            }
            else
            {
                HttpContext.Session.SetString("USUARIO", email);
                HttpContext.Session.SetString("PASS", password);
                return RedirectToAction("Index", "Home");
            }
        }
        public IActionResult CerrarSesion()
        {
            HttpContext.Session.Remove("USUARIO");
            HttpContext.Session.Remove("PASS");
            return RedirectToAction("Index", "Home");
        }
    }
}
