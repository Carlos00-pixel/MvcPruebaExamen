using Microsoft.AspNetCore.Mvc;
using MvcPruebaExamen.Models;
using MvcPruebaExamen.Repositories;

namespace MvcPruebaExamen.ViewComponents
{
    [ViewComponent(Name = "MenuDepartamentos")]
    public class MenuDepartamentosViewComponent: ViewComponent
    {
        private RepositoryHospital repo;

        public MenuDepartamentosViewComponent(RepositoryHospital repo)
        {
            this.repo = repo;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<Departamento> departamentos = this.repo.GetDepartamentos();
            return View(departamentos);
        }
    }
}
