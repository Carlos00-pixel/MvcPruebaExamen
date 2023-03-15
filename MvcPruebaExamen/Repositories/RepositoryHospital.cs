using MvcPruebaExamen.Data;
using MvcPruebaExamen.Models;

namespace MvcPruebaExamen.Repositories
{
    public class RepositoryHospital
    {
        private HospitalContext context;

        public RepositoryHospital(HospitalContext context)
        {
            this.context = context;
        }

        public List<Departamento> GetDepartamentos()
        {
            return this.context.Departamentos.ToList();
        }

        public List<Empleado> FindEmpleado(int idDepartamento)
        {
            var consulta = from datos in this.context.Empleados
                           where datos.IdDepartamento == idDepartamento
                           select datos;
            return consulta.ToList();
        }
    }
}
