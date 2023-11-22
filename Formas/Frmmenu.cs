using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Permissions;
using log4net.Core;

namespace punto_de_venta.Formas
{
    public partial class Frmmenu : Form
    {
        public Frmmenu()
        {
            InitializeComponent();
            llenar();
        }

        private void btnventa_Click(object sender, EventArgs e)
        {
            Formas.Frmventa x = new Formas.Frmventa();
            AddOwnedForm(x);
            x.txtnivel15.Text = this.txtnivel11.Text;
            if (x.txtnivel15.Text == "Administrador")
            {
                x.btnproductos2.Enabled = true;
            }
            x.Show();
            
        }

        private void btninventario_Click(object sender, EventArgs e)
        {
            Formas.Frminventario x = new Formas.Frminventario();
            AddOwnedForm(x);
            x.txtnivel23.Text = this.txtnivel11.Text;
            x.Show();
        }

        private void btnrespaldo_Click(object sender, EventArgs e)
        {
            Formas.Frmrespaldo x = new Formas.Frmrespaldo();
            x.Show();
            this.Hide();
        }

        private void btncompras_Click(object sender, EventArgs e)
        {
            Formas.Frmcompras x = new Formas.Frmcompras();
            x.Show();
            this.Hide();
        }

        private void llenar()
        {

            
        }

        private void btnclientes_Click(object sender, EventArgs e)
        {
            Formas.Frmclientes x = new Formas.Frmclientes();
            AddOwnedForm(x);
            x.txtnivel8.Text = this.txtnivel11.Text;
            x.Show();
        }

        private void btnempleados_Click(object sender, EventArgs e)
        {
            Formas.Frmempleados x = new Formas.Frmempleados();
            AddOwnedForm(x);
            x.txtnivel10.Text = this.txtnivel11.Text;
            x.Show();
        }

        private void btnproveedores_Click(object sender, EventArgs e)
        {
            Formas.Frmproveedores x = new Formas.Frmproveedores();
            AddOwnedForm(x);
            x.txtnivel13.Text = this.txtnivel11.Text;
            x.Show();
        }

        private void btndatos_Click(object sender, EventArgs e)
        {

        }

        private void btnprecios_Click(object sender, EventArgs e)
        {

        }

        private void btnventas_Click(object sender, EventArgs e)
        {
            Formas.Frmventas x = new Formas.Frmventas();
            AddOwnedForm(x);
            x.txtnivel16.Text = this.txtnivel11.Text;
            x.Show();
        }

        private void btncompras2_Click(object sender, EventArgs e)
        {
            Formas.Frmcompras x = new Formas.Frmcompras();
            AddOwnedForm(x);
            x.txtnivel9.Text = this.txtnivel11.Text;
            x.Show();
        }

        private void btninventario2_Click(object sender, EventArgs e)
        {

        }

        private void btncatalagos_Click(object sender, EventArgs e)
        {

        }

        private void btnrespaldo2_Click(object sender, EventArgs e)
        {
            Formas.Frmrespaldo x = new Formas.Frmrespaldo();
            AddOwnedForm(x);
            x.txtnivel14.Text = this.txtnivel11.Text;
            x.Show();
        }

        private void btnconfiguracin_Click(object sender, EventArgs e)
        {
            Formas.Frmconfiguracion x = new Formas.Frmconfiguracion();
            AddOwnedForm(x);
            x.txtnivel21.Text = this.txtnivel11.Text;
            x.Show();
        }

        private void btnusuarios_Click(object sender, EventArgs e)
        {

        }

        private void btnautor_Click(object sender, EventArgs e)
        {
            Formas.Frmacercade x = new Formas.Frmacercade();
            AddOwnedForm(x);
            x.txtnivel6.Text = this.txtnivel11.Text;
            x.Show();
        }

        private void btnproductos_Click(object sender, EventArgs e)
        {
            Formas.Frmproductos x = new Formas.Frmproductos();
            AddOwnedForm(x);
            x.txtnivel12.Text = this.txtnivel11.Text;
            x.Show();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Formas.Frmlogin x = new Formas.Frmlogin();
            x.Show();
            this.Hide();
        }

        private void btnauditoria_Click_1(object sender, EventArgs e)
        {
            Formas.Frmauditoria x = new Formas.Frmauditoria();
            AddOwnedForm(x);
            x.txtnivel7.Text = this.txtnivel11.Text;

            x.Show();
        }

        private void Frmmenu_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
