using SistemaEmpleado.Modelos;
using SistemaEmpleado.VISTA;
using SistemaEmpleado.;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaEmpleado.VISTA.EmpleadoVista
{
    public partial class EmpleadoInsertarVista : Form
    {
        public EmpleadoInsertarVista()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Empleado u = new Empleado();
            u.IdPersona = IdPersonaSeleccionada;
            u.Puesto = textBox2.Text;
            u.Salario = Convert.ToDecimal(textBox3.Text);
            u.FechaContratacion = dateTimePicker1.Value;

            bss.InsertarUsuarioBss(u);
            MessageBox.Show("Se guardo correctamente El Usuario");
        }
    }
}
