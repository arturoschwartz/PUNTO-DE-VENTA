using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace punto_de_venta.Formas
{
    public partial class Frmventas : Form
    {
        public Frmventas()
        {
            InitializeComponent();
            menu();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnmenventas_Click(object sender, EventArgs e)
        {
            Formas.Frmmenu x = new Formas.Frmmenu();
            AddOwnedForm(x);
            x.txtnivel11.Text = this.txtnivel16.Text;
            if (x.txtnivel11.Text == "Administrador")
            {
                x.btnauditoria.Enabled = true;
                x.btninventarioo.Enabled = true;
                x.btnempleados.Enabled = true;
                x.btngrupos.Enabled = true;
                x.btnproveedores.Enabled = true;
                x.btnventas.Enabled = true;
                x.btncompras2.Enabled = true;
                x.btnrespaldo2.Enabled = true;
                x.btnconfiguracin.Enabled = true;
                x.btnproductos.Enabled = true;
                x.btnclientes.Enabled = true;

            }
            this.Hide();
            x.ShowDialog();
            this.Close();

        }

        public void menu()
        {
            
        }
    }
}
