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
            menu();
            eliminar_celda();
        }

        private void btnmenuempleados_Click(object sender, EventArgs e)
        {
            Formas.Frmmenu x = new Formas.Frmmenu();
            AddOwnedForm(x);
            x.txtnivel11.Text = this.txtnivel10.Text;
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
            this.Hide();
            x.ShowDialog();
            this.Close();
        }
        private void menu()
        {
            
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
                    dgvempleados.Rows.Add(txtclave.Text, txtnombre.Text, txtdomicilio.Text, txtlocalidad.Text, txttelefono.Text, txtemail.Text);

                    btnactualizar.Enabled = true;
                    btneliminar.Enabled = true;
                    btnbaja.Enabled = true;
                    btnguardar.Enabled = false;
                    txtnombre.Enabled = true;
                    txtdomicilio.Enabled = true;
                    txtlocalidad.Enabled = true;
                    txttelefono.Enabled = true;
                    txtemail.Enabled = true;
                    txtclave.Focus();
                    txtclave.SelectAll();



                }
                else
                {
                    if (MessageBox.Show("Empleado no registrado, deseas agregar?", "Atencion!!", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
                    {
                        txtnombre.Focus();
                        txtclave.Enabled = false;
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
            comando.ExecuteNonQuery();
            if (MessageBox.Show("Seguro que quiere eliminar este cliente??", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {

                existe = 0;
                MessageBox.Show("Se elimino con exito", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtclave.Clear();
                txtnombre.Clear();
                txtdomicilio.Clear();
                txtlocalidad.Clear();
                txttelefono.Clear();
                txtemail.Clear();
                txtclave.Focus();
                txtlocalidad.Enabled = false;
                txtdomicilio.Enabled = false;
                txttelefono.Enabled = false;
                txtemail.Enabled = false;


            }
            conexion.Close();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (existe == 0)
            {
                objconexion = new Clases.conexion();
                conexion = new SqlConnection(objconexion.conn());
                conexion.Open();
                string query = "insert into Empleados values (@em_Clave, @em_Nombre, @em_Domicilio, @em_Localidad, @em_Telefono, @em_Email)";
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@em_Clave", this.txtclave.Text);
                comando.Parameters.AddWithValue("@em_Nombre", this.txtnombre.Text);
                comando.Parameters.AddWithValue("@em_Domicilio", this.txtdomicilio.Text);
                comando.Parameters.AddWithValue("@em_Localidad", this.txtlocalidad.Text);
                comando.Parameters.AddWithValue("@em_Telefono", this.txttelefono.Text);
                comando.Parameters.AddWithValue("@em_Email", this.txtemail.Text);
                comando.ExecuteNonQuery();
                dgvempleados.Rows.Add(txtclave.Text, txtnombre.Text, txtdomicilio.Text, txtlocalidad.Text, txttelefono.Text, txtemail.Text);
                MessageBox.Show("REGISTRO EXITOSO", "GUARDADO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtclave.Enabled = true;
                txtnombre.Enabled = true;
                txtdomicilio.Enabled = false;
                txtlocalidad.Enabled = false;
                txttelefono.Enabled = false;
                txtdomicilio.Enabled = false;
                txtemail.Enabled = false;
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
                txtclave.Focus();

            }
            conexion.Close();
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            if (existe == 1)
            {
                objconexion = new Clases.conexion();
                conexion = new SqlConnection(objconexion.conn());
                conexion.Open();
                string query = "update Empleados set em_nombre=@em_nombre, em_domicilio=@em_domicilio, em_localidad=@em_localidad, em_telefono=@em_telefono, em_email=@em_email  where em_clave=@em_clave";
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@em_clave", this.txtclave.Text);
                comando.Parameters.AddWithValue("@em_nombre", this.txtnombre.Text);
                comando.Parameters.AddWithValue("@em_domicilio", this.txtdomicilio.Text);
                comando.Parameters.AddWithValue("@em_localidad", this.txtlocalidad.Text);
                comando.Parameters.AddWithValue("@em_telefono", this.txttelefono.Text);
                comando.Parameters.AddWithValue("@em_email", this.txtemail.Text);
                comando.ExecuteNonQuery();
                dgvempleados.Rows.Add(txtclave.Text, txtnombre.Text, txtdomicilio.Text, txtlocalidad.Text, txttelefono.Text, txtemail.Text);
                MessageBox.Show("ACTUALIZACION EXITOSA", "GUARDADO", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void Deshacer_Click(object sender, EventArgs e)
        {
            txtclave.Clear();
            txtnombre.Clear();
            txtdomicilio.Clear();
            txttelefono.Clear();
            txtemail.Clear();
            txtlocalidad.Clear();
            txtclave.Focus();
            txtnombre.Enabled = true;
            txtdomicilio.Enabled = false;
            txtlocalidad.Enabled = false;
            txttelefono.Enabled = false;
            txtemail.Enabled = false;
            this.dgvempleados.Rows.Clear();


        }

        private void eliminar_celda()
        {
            dgvempleados.AllowUserToAddRows = false;
        }
    }
}
