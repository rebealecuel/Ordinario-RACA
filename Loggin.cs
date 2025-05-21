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
    public partial class Loggin : Form
    {
        public Loggin()
        {
            InitializeComponent();
        }

        private void Loggin_Load(object sender, EventArgs e)
        {
 
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Usuarios u = new Usuarios(txbUser.Text, txbPassword.Text);
            if (true)
            {
                Form form = new Form();
                form.Visible = true;
                this.Hide();
            }
            else
            {
                MessageBox.Show("Error critico");
            }
        }
    }
}
