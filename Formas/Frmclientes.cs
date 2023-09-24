using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace punto_de_venta.Formas
{
    public partial class Frmclientes : Form
    {
        int existe;
        int tipo;
        int estatus;
        Clases.conexion objconexion;
        SqlConnection conexion;
        public Frmclientes()
        {
            InitializeComponent();
        }

        private void btnmenu_Click(object sender, EventArgs e)
        {
            Formas.Frmmenu x = new Formas.Frmmenu();
            x.Show();
            this.Hide();
        }

        private void btnventa_Click(object sender, EventArgs e)
        {
            Formas.Frmventa x = new Formas.Frmventa();
            x.Show();
            this.Hide();
        }
    }
    
}
