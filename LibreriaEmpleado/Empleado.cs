using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaEmpleado
{
    public class Empleado
    {
        public Empleado(int id, string nombre, string apellido, int legajo, Departamento departamento)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            Legajo = legajo;
            Departamento = departamento;
        }   

        public Empleado() { }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Legajo { get; set; }
       


        #region Propiedades de Navegacion
        public Departamento Departamento { get; set; }
        #endregion
    }
}
