using Microsoft.AspNetCore.Mvc;
using MvcPruebaExamen.Models;
using MvcPruebaExamen.Repositories;

namespace MvcPruebaExamen.Controllers
{
    public class HospitalController : Controller
    {
        private RepositoryHospital repo;

        public HospitalController(RepositoryHospital repo)
        {
            this.repo = repo;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details(int iddepartamento)
        {
            List<Empleado> emp = this.repo.FindEmpleado(iddepartamento);
            return View(emp);
        }
    }
}
