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

        private void txtclave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                objconexion = new Clases.conexion();
                conexion = new SqlConnection(objconexion.conn());
                conexion.Open();
                string query = "select * from Clientes where cl_clave=@cl_clave";
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@cl_clave", txtclave.Text);
                comando.Parameters.AddWithValue("@cl_nombre", txtnombre.Text);
                comando.Parameters.AddWithValue("@cl_domicilio", txtdomicilio.Text);
                comando.Parameters.AddWithValue("@cl_localidad", txtlocalidad.Text);
                comando.Parameters.AddWithValue("@cl_telefono", txttelefono.Text);
                comando.Parameters.AddWithValue("@cl_email", txtemail.Text);
                SqlDataReader leer = comando.ExecuteReader();

                if (leer.Read())
                {
                    existe = 1;
                    txtclave.Text = leer["cl_clave"].ToString();
                    txtnombre.Text = leer["cl_nombre"].ToString();
                    txtdomicilio.Text = leer["cl_domicilio"].ToString();
                    txtlocalidad.Text = leer["cl_localidad"].ToString();
                    txttelefono.Text = leer["cl_telefono"].ToString();
                    txtemail.Text = leer["cl_email"].ToString();
                    dgvcliente.Rows.Add(txtclave.Text, txtnombre.Text, txtdomicilio.Text, txtlocalidad.Text, txttelefono.Text, txtemail.Text);

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
                    if (MessageBox.Show("Cliente no registrado, deseas agregar?", "Atencion!!", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
                    {
                        existe = 0;
                        btnguardar.Enabled = true;
                        txtnombre.Enabled = true;
                        txtdomicilio.Enabled = true;
                        txtlocalidad.Enabled = true;
                        txttelefono.Enabled = true;
                        txtemail.Enabled = true;
                        txtclave.Enabled = false;
                        txtnombre.Clear();
                        txtdomicilio.Clear();
                        txtlocalidad.Clear();
                        txttelefono.Clear();
                        txtemail.Clear();


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
                string query = "insert into Clientes values (@cl_clave, @cl_nombre, @cl_domicilio, @cl_localidad, @cl_telefono, @cl_email)";
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@cl_clave", this.txtclave.Text);
                comando.Parameters.AddWithValue("@cl_nombre", this.txtnombre.Text);
                comando.Parameters.AddWithValue("@cl_domicilio", this.txtdomicilio.Text);
                comando.Parameters.AddWithValue("@cl_localidad", this.txtlocalidad.Text);
                comando.Parameters.AddWithValue("@cl_telefono", this.txttelefono.Text);
                comando.Parameters.AddWithValue("@cl_email", this.txtemail.Text);
                comando.ExecuteNonQuery();

                dgvcliente.Rows.Add(txtclave.Text, txtnombre.Text, txtdomicilio.Text, txtlocalidad.Text, txttelefono.Text, txtemail.Text);
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
                txtclave.Enabled = true;
                txtnombre.Enabled = true;
                txtdomicilio.Enabled = false;
                txtlocalidad.Enabled = false;
                txttelefono.Enabled = false;
                txtemail.Enabled = false;
                
            }
            conexion.Close();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            objconexion = new Clases.conexion();
            conexion = new SqlConnection(objconexion.conn());

            conexion.Open();
            string query = "Delete  Clientes  where cl_clave=@cl_clave";

            SqlCommand comando = new SqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@cl_clave", txtclave.Text);

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
                txtclave.Enabled = true;
                txtnombre.Enabled = true;
                txtdomicilio.Enabled = false;
                txtlocalidad.Enabled = false;
                txttelefono.Enabled = false;
                txtemail.Enabled = false;
                txtclave.Focus();

            }
            conexion.Close();
        }

        private void Deshacer_Click(object sender, EventArgs e)
        {
            txtclave.Clear();
            txtnombre.Clear();
            txtdomicilio.Clear();
            txtlocalidad.Clear();
            txttelefono.Clear();
            txtemail.Clear();
            txtclave.Enabled = true;
            txtnombre.Enabled = true;
            txtdomicilio.Enabled = false;
            txtlocalidad.Enabled = false;
            txttelefono.Enabled = false;
            txtemail.Enabled = false;
            txtclave.Focus();
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            if (existe == 1)
            {
                objconexion = new Clases.conexion();
                conexion = new SqlConnection(objconexion.conn());
                conexion.Open();
                string query = "update Clientes set cl_nombre=@cl_nombre, cl_domicilio=@cl_domicilio, cl_localidad=@cl_localidad, cl_telefono=@cl_telefono, cl_email=@cl_email  where cl_clave=@cl_clave";
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@cl_clave", this.txtclave.Text);
                comando.Parameters.AddWithValue("@cl_nombre", this.txtnombre.Text);
                comando.Parameters.AddWithValue("@cl_domicilio", this.txtdomicilio.Text);
                comando.Parameters.AddWithValue("@cl_localidad", this.txtlocalidad.Text);
                comando.Parameters.AddWithValue("@cl_telefono", this.txttelefono.Text);
                comando.Parameters.AddWithValue("@cl_email", this.txtemail.Text);
                comando.ExecuteNonQuery();
                dgvcliente.Rows.Add(txtclave.Text, txtnombre.Text, txtdomicilio.Text, txtlocalidad.Text, txttelefono.Text, txtemail.Text);
                MessageBox.Show("ACTUALIZACION EXITOSA", "GUARDADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
        }
    }
    
}
