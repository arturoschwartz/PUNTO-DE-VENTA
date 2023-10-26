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
                string query= "select * from Usuarios where us_Usuarios=@us_Usuarios";
                SqlCommand comando = new SqlCommand(query, conexion);

                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@us_Usuarios", txtusuario.Text);
                SqlDataReader leer = comando.ExecuteReader();
                if (leer.Read())
                {
                    //existe = 1;
                    //password = leer["us_Password"].ToString();
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
                string query = "select * from Usuarios where us_Password=@us_Password";
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@us_Password", txtpassword.Text);
                SqlDataReader leer = comando.ExecuteReader();
                if (leer.Read())
                {
                    password = leer["us_Password"].ToString();

                    DialogResult res = MessageBox.Show("Bienvenido al sistema: " + txtusuario.Text, "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (res == DialogResult.OK)
                    {
                        
                        Formas.Frmmenu x = new Formas.Frmmenu();
                        x.Show();
                        this.Hide();
                    }
                }
                else
                {
                    
                    MessageBox.Show("Error, password incorrecta", "ERROR!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtpassword.Clear();
                    txtpassword.Focus();
                }
            }
            conexion.Close();
        }

        private void btnacceder_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string consulta = "select * from Usuarios where us_Password=@us_Password";
            SqlCommand comando = new SqlCommand(consulta, conexion);
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@us_Password", txtpassword.Text);
            SqlDataReader leer = comando.ExecuteReader();
            if (leer.Read())
            {

                
            }
            conexion.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
