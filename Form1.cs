using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ordinario_RACA
{
    public partial class Form1 : Form
    {
        Acciones acc = new Acciones();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            DGVMostrar.DataSource = acc.ObtenerAuto();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {

        }

        private void btn_Exportar_Click(object sender, EventArgs e)
        {
            if (acc.ExportarExcel())
            {
                MessageBox.Show("Exportado con exito");
                DGVMostrar.DataSource = null;
            }
            else
            {
                MessageBox.Show("Fallo catastrofico");
            }
        }

        private void btn_Importar_Click(object sender, EventArgs e)
        {
            if (acc.Importar())
            {
                MessageBox.Show("Importando");
                DGVMostrar.DataSource=null;
            }
            else
            {
                MessageBox.Show("Error");
            }
        }
    }
}
