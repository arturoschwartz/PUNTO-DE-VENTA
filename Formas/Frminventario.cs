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
    public partial class Frminventario : Form
    {
        public Frminventario()
        {
            InitializeComponent();
            eliminar_celdas();
        }

        private void btnmenuinventario_Click(object sender, EventArgs e)
        {
            Formas.Frmmenu x = new Formas.Frmmenu();
            AddOwnedForm(x);
            x.txtnivel11.Text = this.txtnivel23.Text;
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
            x.Show();
        }

        private void eliminar_celdas()
        {
            dgvinventario.AllowUserToAddRows = false;
        }
    }
}
