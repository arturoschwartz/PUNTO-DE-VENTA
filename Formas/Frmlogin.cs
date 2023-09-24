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

namespace punto_de_venta.Formas
{
    public partial class Frmlogin : Form
    {
        Clases.conexion objconexion;
        SqlConnection conexion;
        int existe;
        string password;
        string usuario;
        string nivel;
        int intentos = 0;

        public Frmlogin()
        {
            InitializeComponent();
        }


        private void txtusuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e. KeyChar == 13)
            {
                objconexion = new Clases.conexion();
                conexion = new SqlConnection(objconexion.conn());
                conexion.Open();
                string query = "select * from Usuarios where us_Usuarios=@us_Usuarios";
                SqlCommand comando = new SqlCommand(query, conexion);

                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@us_Usuarios", txtusuario.Text);
                SqlDataReader leer = comando.ExecuteReader();
                if (leer.Read())
                {
                    existe = 1;
                    password = leer["us_password"].ToString();
                    nivel = leer["us_nivel"].ToString();
                    if (nivel == "1")
                        txtnivel.Text = "Administrador";
                    if (nivel == "2")
                        txtnivel.Text = "Empleado";
                    txtpassword.Enabled = true;
                    txtpassword.Focus();
                    btnacceder.Enabled = true;
                }
                conexion.Close();
            }

        
        }

        private void txtpassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e. KeyChar == 13)
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand("select * from Usuarios where us_Password=@us_Password", conexion);
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("us_Password", txtpassword.Text);
                SqlDataReader leer = comando.ExecuteReader();
                if (leer.Read())
                {
                    password = leer["us_Password"].ToString();

                    Formas.Frmmenu x = new Formas.Frmmenu();
                    x.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Error, password incorrecta", "ERROR!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtpassword.Clear();
                    txtpassword.Focus();
                    intentos++;
                    if (intentos == 3)
                    {
                        MessageBox.Show("Oportunidades agotadas!!", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Application.Exit();
                    }
                }
            }
            conexion.Close();
        }

        private void btnacceder_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string query = "select * from Usuarios where us_Password=@us_Password";
            SqlCommand comando = new SqlCommand(query, conexion);
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@us_Password", txtpassword.Text);
            SqlDataReader leer = comando.ExecuteReader();
            if (leer.Read())
            {
                password = leer["us_Password"].ToString();

                Formas.Frmmenu x = new Formas.Frmmenu();
                x.Show();
                this.Hide();

                txtusuario.Clear();
                txtusuario.Clear();
                txtusuario.Focus();
                txtpassword.Enabled = false;
            }
            conexion.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
