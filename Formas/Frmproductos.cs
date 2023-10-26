using punto_de_venta.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace punto_de_venta.Formas
{
    public partial class Frmproductos : Form
    {
        Clases.conexion objconexion;
        SqlConnection conexion;
        int existe;
        public Frmproductos()
        {
            InitializeComponent();
        }

        private void btnmenuproductos_Click(object sender, EventArgs e)
        {
            Formas.Frmmenu x = new Formas.Frmmenu();
            x.Show();
            this.Hide();
        }

        private void btnventasproductos_Click(object sender, EventArgs e)
        {
            Formas.Frmventa x = new Formas.Frmventa();
            x.Show();
            this.Hide();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtcodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            if (e.KeyChar == 13)
            {
                objconexion = new Clases.conexion();
                conexion = new SqlConnection(objconexion.conn());
                conexion.Open();
                string query = "select * from Productos where pr_clave=@pr_clave";
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@pr_clave", txtcodigo.Text);
                comando.Parameters.AddWithValue("@pr_nombre", txtnombre.Text);
                comando.Parameters.AddWithValue("@pr_precio", txtprecioventa.Text);
                SqlDataReader leer = comando.ExecuteReader();

                if (leer.Read())
                {
                    existe = 1;
                    txtcodigo.Text = leer["pr_clave"].ToString();
                    txtcodigo.Text = leer["pr_clave"].ToString();
                    txtnombre.Text = leer["pr_nombre"].ToString();
                    txtprecioventa.Text = leer["pr_precio"].ToString();

                    
                    btneliminar.Enabled = true;
                    btnactualizar.Enabled = true;
                    txtcodigo.Enabled = true;
                    txtnombre.Enabled = true;
                    txtprecioventa.Enabled = true;
                    btnguaradar.Enabled = true;
                    txtprecioventa.Enabled = true;
                    txtcodigo.Focus();
                    
                    
                   

                }
                else
                {
                    if (MessageBox.Show("Producto no registrado, deseas agregar?", "Atencion!!", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
                    {
                        
                        txtcodigo.Enabled = false;
                        txtnombre.Enabled = true;
                        txtprecioventa.Enabled = true;
                        btnguaradar.Enabled = true;
                        txtcodigo.Enabled = false;
                        txtnombre.Enabled = true;
                        txtcodigo.Focus();

                    }
                }
                conexion.Close();
            }
            
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            if (existe == 1)
            {
                objconexion = new Clases.conexion();
                conexion = new SqlConnection(objconexion.conn());
                conexion.Open();
                string query = "update Productos set pr_nombre=@pr_nombre, pr_precio=@pr_precio where pr_clave=@pr_clave";
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@pr_clave", this.txtcodigo.Text);
                comando.Parameters.AddWithValue("@pr_nombre", this.txtnombre.Text);
                comando.Parameters.AddWithValue("@pr_precio", this.txtprecioventa.Text);
                comando.ExecuteNonQuery();
                MessageBox.Show("ACTUALIZACION EXITOSA", "GUARDADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnguaradar_Click(object sender, EventArgs e)
        {
            if (existe == 0)
            {
                objconexion = new Clases.conexion();
                conexion = new SqlConnection(objconexion.conn());
                conexion.Open();
                string query = "insert into Productos values (@pr_clave, @pr_nombre, @pr_precio)";
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@pr_clave", this.txtcodigo.Text);
                comando.Parameters.AddWithValue("@pr_nombre", this.txtnombre.Text);
                comando.Parameters.AddWithValue("@pr_precio", this.txtprecioventa.Text);
                comando.ExecuteNonQuery();
                MessageBox.Show("REGISTRO EXITOSO", "GUARDADO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                
                txtcodigo.Clear();
                txtnombre.Clear();
                txtprecioventa.Clear();
                txtcodigo.Enabled = true;
                txtnombre.Enabled = true; ;
                txtprecioventa.Enabled = false;
                txtcodigo.Focus();


            }
            conexion.Close();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if(existe == 1)
            {
                objconexion = new Clases.conexion();
                conexion = new SqlConnection(objconexion.conn());

                conexion.Open();
                string query = "Delete Productos where pr_clave=@pr_clave";

                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@pr_clave", txtcodigo.Text);

                if (MessageBox.Show("Seguro que quiere eliminar este producto??", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Se elimino con exito", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtcodigo.Focus();
                    txtcodigo.Clear();
                    txtnombre.Clear();
                    txtprecioventa.Clear();
                    txtprecioventa.Enabled = false;
                    


                }
                conexion.Close();
                
            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            objconexion = new Clases.conexion();
            conexion = new SqlConnection(objconexion.conn());
            conexion.Open();
            string query = "select * from Productos where pr_clave=@pr_clave";
            SqlCommand comando = new SqlCommand(query, conexion);
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@pr_clave", txtcodigo.Text);
            comando.Parameters.AddWithValue("@pr_nombre", txtnombre.Text);
            comando.Parameters.AddWithValue("@pr_precio", txtprecioventa.Text);
            SqlDataReader leer = comando.ExecuteReader();

            if (leer.Read())
            {
                existe = 1;
                txtcodigo.Text = leer["pr_clave"].ToString();
                txtcodigo.Text = leer["pr_clave"].ToString();
                txtnombre.Text = leer["pr_nombre"].ToString();
                txtprecioventa.Text = leer["pr_precio"].ToString();


                btneliminar.Enabled = true;
                btnactualizar.Enabled = true;
                txtcodigo.Enabled = true;
                txtnombre.Enabled = true;
                txtprecioventa.Enabled = false;
                btnguaradar.Enabled = true;

                



            }
            else
            {
                if (MessageBox.Show("Producto no registrado, deseas agregar?", "Atencion!!", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
                {

                    txtcodigo.Enabled = false;
                    txtnombre.Enabled = true;
                    txtprecioventa.Enabled = true;
                    btnguaradar.Enabled = true;
                    txtcodigo.Enabled = false;
                    txtnombre.Enabled = true;
                    txtcodigo.Focus();
                    

                }
            }
            conexion.Close();
        }

        private void btndeshacer_Click(object sender, EventArgs e)
        {
            txtcodigo.Clear();
            txtnombre.Clear();
            txtexistencia.Clear();
            txtprecioventa.Clear();
            txtcodigo.Enabled = true;
            txtcodigo.Focus();
            btnguaradar.Enabled = false;
        }
    }
}
