using log4net.Core;
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
            eliminar_celdas();
            menu();
        }

        private void btnmenuproductos_Click(object sender, EventArgs e)
        {
            Formas.Frmmenu x = new Formas.Frmmenu();
            AddOwnedForm(x);
            x.txtnivel11.Text = this.txtnivel12.Text;
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

        private void btnventasproductos_Click(object sender, EventArgs e)
        {
            Formas.Frmventa x = new Formas.Frmventa();
            AddOwnedForm(x);
            x.txtnivel15.Text = this.txtnivel12.Text;
            x.btnproductos2.Enabled= true;
            this.Hide();
            x.ShowDialog();
            this.Close();

        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
        

        private void txtcodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (string.IsNullOrEmpty(txtcodigo.Text))
                {
                    MessageBox.Show("ERROR: Nose se permiten nulos!!", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                objconexion = new Clases.conexion();
                conexion = new SqlConnection(objconexion.conn());
                conexion.Open();
                SqlCommand comando = new SqlCommand("select pto_clave, pto_nombre, pto_precio, pto_stock, pto_costo from Productos where pto_clave=" + txtcodigo.Text, conexion);
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@pto_clave", (txtcodigo.Text));
                comando.Parameters.AddWithValue("@pto_nombre", txtnombre.Text);
                comando.Parameters.AddWithValue("@pto_precio", txtprecioventa.Text);
                comando.Parameters.AddWithValue("@pto_stock", txtexistencia.Text);

                //comando.Parameters.AddWithValue("@pto_estatus", cboxestatus.SelectedIndex);

                SqlDataReader leer = comando.ExecuteReader();
                if (leer.Read())
                {
                    existe = 1;
                    txtcodigo.Text = leer["pto_clave"].ToString();
                    txtnombre.Text = leer["pto_nombre"].ToString();
                    txtprecioventa.Text = leer["pto_precio"].ToString();
                    txtexistencia.Text = leer["pto_stock"].ToString();
                    txtcosto.Text = leer["pto_costo"].ToString();
                    //estatus =  leer["pto_estatus"].ToString();
                    
                   





                    dgvproductos.Rows.Add(txtcodigo.Text, txtnombre.Text, txtexistencia.Text, txtprecioventa.Text, txtcosto.Text);
                    btneliminar.Enabled = true;
                    btnactualizar.Enabled = true;
                    txtcodigo.Enabled = true;
                    txtnombre.Enabled = true;
                    txtprecioventa.Enabled = true;
                    btnguaradar.Enabled = true;
                    txtprecioventa.Enabled = true;
                    txtexistencia.Enabled = true;
                    txtcosto.Enabled = true;
                    txtcodigo.Focus();
                    txtcodigo.SelectAll();
                    


                }
                else
                {
                    if (MessageBox.Show("Producto no registrado, deseas agregar?", "Atencion!!", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
                    {
                        existe = 0;
                        txtcodigo.Enabled = false;
                        txtnombre.Enabled = true;
                        txtprecioventa.Enabled = true;
                        btnguaradar.Enabled = true;
                        txtcodigo.Enabled = false;
                        txtnombre.Enabled = true;
                        txtexistencia.Enabled = true;
                        txtcosto.Enabled = true;

                        
                        txtexistencia.Clear();
                        txtcosto.Clear();
                        txtnombre.Clear();
                        txtprecioventa.Clear();
                        txtcodigo.SelectAll();
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
                string query = "update Productos set pto_nombre=@pto_nombre, pto_precio=@pto_precio, pto_stock=@pto_stock, pto_costo=@pto_costo where pto_clave=@pto_clave";
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@pto_clave", this.txtcodigo.Text);
                comando.Parameters.AddWithValue("@pto_nombre", this.txtnombre.Text);
                comando.Parameters.AddWithValue("@pto_precio", this.txtprecioventa.Text);
                comando.Parameters.AddWithValue("@pto_stock", this.txtexistencia.Text);
                comando.Parameters.AddWithValue("@pto_costo", this.txtcosto.Text);
                comando.ExecuteNonQuery();
                dgvproductos.Rows.Add(txtcodigo.Text, txtnombre.Text, txtprecioventa.Text, txtcosto.Text, txtprecioventa.Text);
                MessageBox.Show("ACTUALIZACION EXITOSA", "GUARDADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtcodigo.Focus();
            }
        }



        private void btnguaradar_Click(object sender, EventArgs e)
        {
            if (existe == 0)
            {
                objconexion = new Clases.conexion();
                conexion = new SqlConnection(objconexion.conn());
                conexion.Open();
                string query = "insert into Productos values (@pto_clave, @pto_nombre, @pto_precio, @pto_stock, @pto_costo)";
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@pto_clave", txtcodigo.Text);
                comando.Parameters.AddWithValue("@pto_nombre", txtnombre.Text);
                comando.Parameters.AddWithValue("@pto_precio", txtprecioventa.Text);
                comando.Parameters.AddWithValue("@pto_stock", txtexistencia.Text);
                comando.Parameters.AddWithValue("@pto_costo", txtcosto.Text);
                comando.ExecuteNonQuery();
                dgvproductos.Rows.Add(txtcodigo.Text, txtnombre.Text, txtprecioventa.Text, txtexistencia.Text, txtcosto.Text);
                MessageBox.Show("REGISTRO EXITOSO", "GUARDADO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtcosto.Clear();
                txtexistencia.Clear();
                txtcodigo.Clear();
                txtnombre.Clear();
                txtprecioventa.Clear();
                txtcodigo.Enabled = true;
                txtnombre.Enabled = true; ;
                txtprecioventa.Enabled = false;
                txtcosto.Enabled = false;
                txtexistencia.Enabled = false;
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
                string query = "Delete Productos where pto_clave=@pto_clave";

                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@pto_clave", txtcodigo.Text);
                comando.ExecuteNonQuery();
                if (MessageBox.Show("Seguro que quiere eliminar este producto??", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    MessageBox.Show("Se elimino con exito", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtcodigo.Focus();
                    txtcodigo.Clear();
                    txtnombre.Clear();
                    txtprecioventa.Clear();
                    txtcosto.Clear();
                    txtexistencia.Clear();
                    txtprecioventa.Enabled = false;
                    txtcosto.Enabled = false;
                    txtexistencia.Enabled = false;
                    

                }
                conexion.Close();

            }
            
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            objconexion = new Clases.conexion();
            conexion = new SqlConnection(objconexion.conn());
            conexion.Open();
            string query = "select * from Productos where pto_clave=@pto_clave";
            SqlCommand comando = new SqlCommand(query, conexion);
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@pto_clave", txtcodigo.Text);
            comando.Parameters.AddWithValue("@pto_nombre", txtnombre.Text);
            comando.Parameters.AddWithValue("@pto_precio", txtprecioventa.Text);
            SqlDataReader leer = comando.ExecuteReader();

            if (leer.Read())
            {
                existe = 1;
                txtcodigo.Text = leer["pto_clave"].ToString();
                txtcodigo.Text = leer["pto_clave"].ToString();
                txtnombre.Text = leer["pto_nombre"].ToString();
                txtprecioventa.Text = leer["pto_precio"].ToString();


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
                    txtcosto.Enabled = true;
                    txtnombre.Clear();
                    txtprecioventa.Clear();
                    txtnombre.Focus();
                    txtcodigo.Clear();


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
            txtprecioventa.Enabled = false;
            txtexistencia.Enabled = false;
            txtcosto.Enabled=false;
            this.dgvproductos.Rows.Clear();
            txtcosto.Clear();
            this.dgvproductos.Rows.Clear();
        }

        private void eliminar_celdas()
        {
            dgvproductos.AllowUserToAddRows = false;
            
        }
    }
}
