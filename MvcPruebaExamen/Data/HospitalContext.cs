using Microsoft.EntityFrameworkCore;
using MvcPruebaExamen.Models;

namespace MvcPruebaExamen.Data
{
    public class HospitalContext: DbContext
    {
        public HospitalContext(DbContextOptions<HospitalContext> options)
            : base(options) { }

        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
    }
}
