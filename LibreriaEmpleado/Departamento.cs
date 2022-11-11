using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaEmpleado
{
    public class Departamento
    {
        public Departamento() { }

        public Departamento(int departamentoId, string nombre, List<Empleado> empleados)
        {
            DepartamentoId = departamentoId;
            Nombre = nombre;
            Empleados = empleados;
        }

        public int DepartamentoId { get; set; }
        public string Nombre { get; set; }

        #region Propiedades de Navegacion
        public List<Empleado> Empleados { get; set; }
        #endregion

    }
}
