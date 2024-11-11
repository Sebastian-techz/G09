
using G09.Modelo;
using Microsoft.EntityFrameworkCore;

namespace G09.Data
{
    public class Contexto : DbContext
    {
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<Proyecto> Proyectos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=EmpresaDB;Integrated Security=True;TrustServerCertificate=True;");
        }
    }
}
