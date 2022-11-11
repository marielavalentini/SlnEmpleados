using LibreriaEmpleado;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsEmpleados.Data
{
    public class DBEmpleadosContext : DbContext
    {
        public DBEmpleadosContext(): base("keyEmpleados") { }

        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Departamento> Departamentos { get; set; }
    }
}
