using punto_de_venta.Clases;
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

namespace punto_de_venta.Formas
{
    public partial class Frmempleados : Form
    {
        Clases.conexion objconexion;
        SqlConnection conexion;
        int existe;

        public Frmempleados()
        {
            InitializeComponent();
        }

        private void btnmenuempleados_Click(object sender, EventArgs e)
        {
            Formas.Frmmenu x = new Formas.Frmmenu();
            x.Show();
            this.Hide();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtclave_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (e.KeyChar == 13)
            {
                objconexion = new Clases.conexion();
                conexion = new SqlConnection(objconexion.conn());
                conexion.Open();
                string query = "select * from Empleados where em_clave=@em_clave";
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@em_clave", txtclave.Text);
                comando.Parameters.AddWithValue("@em_nombre", txtnombre.Text);
                comando.Parameters.AddWithValue("@em_domicilio", txtdomicilio.Text);
                comando.Parameters.AddWithValue("@em_localidad", txtlocalidad.Text);
                comando.Parameters.AddWithValue("@em_telefono", txttelefono.Text);
                comando.Parameters.AddWithValue("@em_email", txtemail.Text);
                SqlDataReader leer = comando.ExecuteReader();

                if (leer.Read())
                {
                    existe = 1;
                    txtclave.Text = leer["em_clave"].ToString();
                    txtnombre.Text = leer["em_nombre"].ToString();
                    txtdomicilio.Text = leer["em_domicilio"].ToString();
                    txtlocalidad.Text = leer["em_localidad"].ToString();
                    txttelefono.Text = leer["em_telefono"].ToString();
                    txtemail.Text = leer["em_email"].ToString();

                    btnactualizar.Enabled = true;
                    btneliminar.Enabled = true;
                    btnbaja.Enabled = true;
                    btnguardar.Enabled = false;
                    txtnombre.Enabled = true;
                    txtdomicilio.Enabled = true;
                    txtlocalidad.Enabled = true;
                    txttelefono.Enabled = true;
                    txtemail.Enabled = true;




                }
                else
                {
                    if (MessageBox.Show("Empleado no registrado, deseas agregar?", "Atencion!!", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
                    {
                        btnguardar.Enabled = true;
                        txtnombre.Enabled = true;
                        txtdomicilio.Enabled = true;
                        txtlocalidad.Enabled = true;
                        txttelefono.Enabled = true;
                        txtemail.Enabled = true;


                    }
                }
                conexion.Close();
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            objconexion = new Clases.conexion();
            conexion = new SqlConnection(objconexion.conn());

            conexion.Open();
            string query = "Delete  Empleados  where em_clave=@em_clave";

            SqlCommand comando = new SqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@em_clave", txtclave.Text);

            if (MessageBox.Show("Seguro que quiere eliminar este cliente??", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {

                comando.ExecuteNonQuery();
                MessageBox.Show("Se elimino con exito", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtclave.Clear();
                txtnombre.Clear();
                txtdomicilio.Clear();
                txtlocalidad.Clear();
                txttelefono.Clear();
                txtemail.Clear();
                txtclave.Focus();


            }
            conexion.Close();
        }
    }
}
