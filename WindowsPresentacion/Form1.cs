using LibreriaEmpleado;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsPresentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEmpleadosDepartamento_Click(object sender, EventArgs e)
        {
            List<Empleado>listaEmpleadosAdm = new List<Empleado>();
            List<Empleado> listaEmpleadosCont = new List<Empleado>();

            Departamento departamento1 = new Departamento(1,"Administracion",listaEmpleadosAdm);
            Departamento departamento2 = new Departamento(2, "Contabilidad", listaEmpleadosCont);

            Empleado empleado1 = new Empleado(31452671,"Juan","Garcia",1,departamento1);
            Empleado empleado2 = new Empleado(34561278, "Maria", "Gonzalez", 2, departamento1);
            Empleado empleado3 = new Empleado(45231671, "Pedro", "Lopez", 3, departamento1);

            Empleado empleado4 = new Empleado(45231908, " Rosario", "Perez", 4, departamento2);

            listaEmpleadosAdm.Add(empleado1);
            listaEmpleadosAdm.Add(empleado2);
            listaEmpleadosAdm.Add(empleado3);

            GridDepartamentos.DataSource = listaEmpleadosAdm;

            foreach(Empleado empleado in listaEmpleadosAdm)
            {
                lstEmpleados.Items.Add(empleado.Nombre + empleado.Apellido + empleado.Departamento.Nombre);
            }
        }
    }
}
