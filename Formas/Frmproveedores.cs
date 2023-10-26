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
    public partial class Frmproveedores : Form
    {
        Clases.conexion objconexion;
        SqlConnection conexion;
        int existe;

        public Frmproveedores()
        {
            InitializeComponent();
        }

        private void btnmenuproveedores_Click(object sender, EventArgs e)
        {
            Formas.Frmmenu x = new Formas.Frmmenu();
            x.Show();
            this.Hide();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtcodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar ==13)
            {
                objconexion = new Clases.conexion();
                conexion = new SqlConnection(objconexion.conn());
                conexion.Open();
                string query = "select * from Proveedores where pr_clave=@pr_clave";
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@pr_clave", txtcodigo.Text);
                comando.Parameters.AddWithValue("@pr_nombre", txtnombre.Text);
                comando.Parameters.AddWithValue("@pr_domicilio", txtdomicilio.Text);
                comando.Parameters.AddWithValue("@pr_localidad", txtlocalidad.Text);
                comando.Parameters.AddWithValue("@pr_telefono", txttelefono.Text);
                comando.Parameters.AddWithValue("@pr_email", txtemail.Text);
                comando.Parameters.AddWithValue("@pr_producto", txtproducto.Text);
                SqlDataReader leer = comando.ExecuteReader();

                if (leer.Read())
                {
                    existe = 1;
                    txtclave.Text = leer["pr_clave"].ToString();
                    txtnombre.Text = leer["pr_nombre"].ToString();
                    txtdomicilio.Text = leer["pr_domicilio"].ToString();
                    txtlocalidad.Text = leer["pr_localidad"].ToString();
                    txttelefono.Text = leer["pr_telefono"].ToString();
                    txtemail.Text = leer["pr_email"].ToString();
                    txtproducto.Text = leer["pr_producto"].ToString();

                    btnactualizar.Enabled = true;
                    btneliminar.Enabled = true;
                    //btnbaja.Enabled = true;
                    btnguardar.Enabled = false;
                    txtnombre.Enabled = true;
                    txtdomicilio.Enabled = true;
                    txtlocalidad.Enabled = true;
                    txttelefono.Enabled = true;
                    txtemail.Enabled = true;
                    txtproducto.Enabled = true;

                    




                }
                else
                {
                    if (MessageBox.Show("Proveedor no registrado, deseas agregar?", "Atencion!!", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
                    {
                        btnguardar.Enabled = true;
                        txtnombre.Enabled = true;
                        txtdomicilio.Enabled = true;
                        txtlocalidad.Enabled = true;
                        txttelefono.Enabled = true;
                        txtemail.Enabled = true;
                        txtproducto.Enabled = true;


                    }
                }
                conexion.Close();
            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (existe == 0)
            {
                objconexion = new Clases.conexion();
                conexion = new SqlConnection(objconexion.conn());
                conexion.Open();
                string query = "insert into Proveedores values (@pr_clave, @pr_nombre, @pr_domicilio, @pr_localidad, @pr_telefono, @pr_email, @pr_producto)";
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@pr_clave", this.txtclave.Text);
                comando.Parameters.AddWithValue("@pr_nombre", this.txtnombre.Text);
                comando.Parameters.AddWithValue("@pr_domicilio", this.txtdomicilio.Text);
                comando.Parameters.AddWithValue("@pr_localidad", this.txtlocalidad.Text);
                comando.Parameters.AddWithValue("@pr_telefono", this.txttelefono.Text);
                comando.Parameters.AddWithValue("@pr_email", this.txtemail.Text);
                comando.Parameters.AddWithValue("@pr_producto", this.txtproducto.Text);
                comando.ExecuteNonQuery();
                MessageBox.Show("REGISTRO EXITOSO", "GUARDADO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                btnguardar.Enabled = true;
                btneliminar.Enabled = true;
                btnbaja.Enabled = true;
                btnactualizar.Enabled = true;
                txtclave.Clear();
                txtnombre.Clear();
                txtdomicilio.Clear();
                txtlocalidad.Clear();
                txttelefono.Clear();
                txtemail.Clear();
                txtproducto.Clear();
                txtclave.Clear();

            }
            conexion.Close();
        }
    }
}
