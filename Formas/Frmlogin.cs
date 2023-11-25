using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net.Http.Headers;
using System.Security;
using System.Security.Cryptography.X509Certificates;
using System.Diagnostics.Eventing.Reader;
using CrystalDecisions.ReportAppServer.DataDefModel;
using punto_de_venta.Clases;

namespace punto_de_venta.Formas
{
    public partial class Frmlogin : Form
    {
        Clases.conexion objconexion;
        SqlConnection conexion;
        //int existe;
        //string password;
        //string usuario;
        string nivel;
        int intento = 0;

        public Frmlogin()
        {
            InitializeComponent();
        }


        private void txtusuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtpassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                objconexion = new Clases.conexion();
                conexion = new SqlConnection(objconexion.conn());
                conexion.Open();
                string consulta = "select * from Usuarios where us_Usuarios='" + txtusuario.Text + "' and us_Password='" + txtpassword.Text + "'";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                SqlDataReader leer;
                leer = comando.ExecuteReader();
                if (leer.Read())
                {
                    nivel = leer["us_nivel"].ToString();
                    if (nivel == "1")
                        txtnivel.Text = "Administrador";

                    if (nivel == "2")
                        txtnivel.Text = "Empleado"; 

                    DialogResult res = MessageBox.Show("Bienvenido al sistema: " + txtusuario.Text, "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Formas.Frmmenu x = new Formas.Frmmenu();
                    AddOwnedForm(x);
                    x.txtnivel11.Text = this.txtnivel.Text;
                    

                    if (txtnivel.Text == "Administrador")
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
                else
                {
                    MessageBox.Show("Error: Usuario o Password Incorrecto", "ERROR!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtusuario.Clear();
                    txtpassword.Clear();
                    txtusuario.Focus();
                    intento++;
                    if (intento == 3)
                    {
                        MessageBox.Show("Oportunidades agotadas!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        //el sistema se cierra
                        Application.Exit();
                    }
                }

                conexion.Close();
                
            }
            
        }

        private void btnentrar_Click(object sender, EventArgs e)
        {
            objconexion = new Clases.conexion();
            conexion = new SqlConnection(objconexion.conn());
            conexion.Open();
            string consulta = "select * from Usuarios where us_Usuarios='" + txtusuario.Text + "' and us_Password='" + txtpassword.Text + "'";
            SqlCommand comando = new SqlCommand(consulta, conexion);
            SqlDataReader leer;
            leer = comando.ExecuteReader();
            if (leer.Read())
            {
                nivel = leer["us_nivel"].ToString();
                if (nivel == "1")
                    txtnivel.Text = "Administrador";

                if (nivel == "2")
                    txtnivel.Text = "Empleado";

                DialogResult res = MessageBox.Show("Bienvenido al sistema: " + txtusuario.Text, "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Formas.Frmmenu x = new Formas.Frmmenu();
                AddOwnedForm(x);
                x.txtnivel11.Text = this.txtnivel.Text;
                if (txtnivel.Text == "Administrador")
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
            else
            {
                MessageBox.Show("Error: Usuario o Password Incorrecto", "ERROR!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtusuario.Clear();
                txtpassword.Clear();
                txtusuario.Focus();

                intento++;
                if (intento == 3)
                {
                    MessageBox.Show("Oportunidades agotadas!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //el sistema se cierra
                    Application.Exit();
                }
            }
            conexion.Close();
        }
    }
}
