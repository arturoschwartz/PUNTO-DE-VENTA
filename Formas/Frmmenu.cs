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

namespace punto_de_venta.Formas
{
    public partial class Frmmenu : Form
    {
        public Frmmenu()
        {
            InitializeComponent();
            
        }

        private void btnventa_Click(object sender, EventArgs e)
        {
            Formas.Frmventa x = new Formas.Frmventa();
            x.Show();
            this.Hide();
        }

        private void btninventario_Click(object sender, EventArgs e)
        {
            
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

        private void btninventarioo_Click(object sender, EventArgs e)
        {

        }

        private void btnclientes_Click(object sender, EventArgs e)
        {
            Formas.Frmclientes x = new Formas.Frmclientes();
            x.Show();
            this.Hide();
        }

        private void btnempleados_Click(object sender, EventArgs e)
        {
            Formas.Frmempleados x = new Formas.Frmempleados();
            x.Show();
            this.Hide();
        }

        private void btnproveedores_Click(object sender, EventArgs e)
        {
            Formas.Frmproveedores x = new Formas.Frmproveedores();
            x.Show();
            this.Hide();
        }

        private void btndatos_Click(object sender, EventArgs e)
        {

        }

        private void btnsalir2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnprecios_Click(object sender, EventArgs e)
        {

        }

        private void btnventas_Click(object sender, EventArgs e)
        {
            Formas.Frmventas x = new Formas.Frmventas();
            x.Show();
            this.Hide();
        }

        private void btncompras2_Click(object sender, EventArgs e)
        {
            Formas.Frmcompras x = new Formas.Frmcompras();
            x.Show();
            this.Hide();
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
            x.Show();
            this.Hide();
        }

        private void btnconfiguracin_Click(object sender, EventArgs e)
        {

        }

        private void btnusuarios_Click(object sender, EventArgs e)
        {

        }

        private void btnautor_Click(object sender, EventArgs e)
        {
            Formas.Frmacercade x = new Formas.Frmacercade();
            x.Show();
            this.Hide();
        }

        private void btnproductos_Click(object sender, EventArgs e)
        {
            Formas.Frmproductos x = new Formas.Frmproductos();
            x.Show();
            this.Hide();
        }

        private void btnauditoria_Click(object sender, EventArgs e)
        {
            Formas.Frmauditoria x = new Formas.Frmauditoria();
            x.Show();
            this.Hide();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Formas.Frmlogin x = new Formas.Frmlogin();
            x.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Formas.Frmauditoria x = new Formas.Frmauditoria();
            x.Show();
            this.Hide();
        }
    }
}
