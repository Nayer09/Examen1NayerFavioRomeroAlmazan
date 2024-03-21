using SistemaEmpleado.Modelos;
using SistemaEmpleado.BSS;
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
    public partial class EmpleadoListarVista : Form
    {
        public EmpleadoListarVista()
        {
            InitializeComponent();
        }
        EmpleadoBss bss = new EmpleadoBss();
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarEmpleadoBss();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EmpleadoInsertarVista fr = new EmpleadoInsertarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarEmpleadoBss();
            }
        }
    }
}
