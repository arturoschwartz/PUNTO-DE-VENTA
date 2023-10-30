using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace punto_de_venta.Formas
{
    public partial class Frmventa : Form
    {
        Clases.conexion objconexion;
        SqlConnection conexion;
        int existe;
        
        public Frmventa()
        {
            InitializeComponent();
            suma();
            
            
            
        }
        private void btnmenuventa_Click(object sender, EventArgs e)
        {
            Formas.Frmmenu x = new Formas.Frmmenu();
            x.Show();
            this.Hide();
        }

        private void btnproductos_Click(object sender, EventArgs e)
        {
            Formas.Frmproductos x = new Formas.Frmproductos();
            x.Show();
            this.Hide();
        }

        private void rdbtncredito_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtncredito.Checked)
            {
                lblcliente.Enabled = true;
                txtcliente.Enabled = true;
                txtcliente.Focus();
                btnbuscarcliente.Enabled = true;
                cboxcliente.Enabled = true;
                lblbuscar.Enabled = true;
                
                
            }
        }

        private void rdbtncontado_CheckedChanged(object sender, EventArgs e)
        {
            lblcliente.Enabled = false;
            txtcliente.Enabled = false;
            txtcliente.Clear();
            txtnombre.Clear();
            txtlocalidad.Clear();
            txttelefono.Clear();
            
            btnbuscarcliente.Enabled = false;
            cboxcliente.Enabled = false;
            lblbuscar.Enabled = false;
            
            
        }

        private void txtcliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                objconexion = new Clases.conexion();
                conexion = new SqlConnection(objconexion.conn());
                conexion.Open();
                string query = "select * from Clientes where cl_clave=@cl_clave";
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@cl_clave", txtcliente.Text);
                comando.Parameters.AddWithValue("@cl_nombre", txtnombre.Text);
                comando.Parameters.AddWithValue("@cl_localidad", txtlocalidad.Text);
                comando.Parameters.AddWithValue("@cl_telefono", txttelefono.Text);
                //comando.Parameters.AddWithValue("@cl_folio", txtfolio.Text);
                SqlDataReader leer = comando.ExecuteReader();
                if (leer.Read())
                {
                    existe = 1;
                    txtcliente.Text = leer["cl_clave"].ToString();
                    txtnombre.Text = leer["cl_nombre"].ToString();
                    txtlocalidad.Text = leer["cl_localidad"].ToString();
                    txttelefono.Text = leer["cl_telefono"].ToString();
                    //txtfolio.Text = leer["cl_folio"].ToString();
                }
                conexion.Close();

            }
        }

        private void txtcodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (string.IsNullOrEmpty(txtcodigo.Text))
                {
                    MessageBox.Show("ERROR: Nose se permiten nulos!!", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                objconexion = new Clases.conexion();
                conexion = new SqlConnection(objconexion.conn());
                conexion.Open();
                string query = "select * from Productos where pto_clave=@pto_clave";
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@pto_clave", txtcodigo.Text);
                comando.Parameters.AddWithValue("@pto_nombre", txtnombre2.Text);
                comando.Parameters.AddWithValue("@pto_precio", txtpreciounit.Text);
                SqlDataReader leer = comando.ExecuteReader();
                if (leer.Read())
                {
                    
                    existe = 1;
                    txtcodigo.Text = leer["pto_clave"].ToString();
                    txtnombre2.Text = leer["pto_nombre"].ToString();
                    txtpreciounit.Text = leer["pto_precio"].ToString();
                    txtcantidad.Text = "1";
                    txtcantidad.Focus();
                    txtimporte.Clear();
                }
                else
                {
                    existe = 0;
                    MessageBox.Show("Error: articulo no encontrado", "ERROR!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtcodigo.Clear();
                    txtcodigo.Focus();
                }
                
            }
        }
        private void btndeshacer_Click(object sender, EventArgs e)
        {
            txtcodigo.Clear();
            txtnombre2.Clear() ;
            txtpreciounit.Clear();
            txtcodigo.Focus();
            txtpago.Clear();
            txtcambio.Clear();
            this.dgvventas.Rows.Clear();
            txttotal.Clear();
            suma();
            txtpreciounit.Enabled = false;
            txtcantidad.Clear();
            txtimporte.Clear();
        }
        

        private void suma()
        {
            double total = 0;
            foreach (DataGridViewRow row in dgvventas.Rows)
            {
                total += Convert.ToDouble(row.Cells["importe"].Value);
                
            }
            txttotal.Text = total.ToString("N2");
        }

        private void producto_total()
        {
            
        }

        private void btnquitar_Click(object sender, EventArgs e)
        {
            if (dgvventas.RowCount > 1)
            {
                dgvventas.Rows.RemoveAt(dgvventas.CurrentRow.Index);
                suma();
                txtcodigo.Focus();
            }
            txtcodigo.Focus();
        }

        private void btntotalizar_Click(object sender, EventArgs e)
        {
            try
            {
                txtcambio.Text = (float.Parse(txtpago.Text) - float.Parse(txttotal.Text)).ToString();
            }
            catch (Exception)
            {
                return;
            }
        }

        private void txtpago_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                try
                {
                    txtcambio.Text = (float.Parse(txtpago.Text) - float.Parse(txttotal.Text)).ToString();
                      
                }
                catch (Exception)
                {
                    return;
                }
            }
        }

        private void btnbuscarproduc_Click(object sender, EventArgs e)
        {
            
        }

        private void txtcantidad_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter)
            {
                //convierto los textos a double y despues el resultado a texto con tostring
                //el complemento "N2 se determina que reconozca los decimales en el resultado"
                txtimporte.Text = (Convert.ToDouble(txtpreciounit.Text) * Convert.ToDouble(txtcantidad.Text)).ToString("N2");
                dgvventas.Rows.Add(txtcodigo.Text, txtnombre2.Text, txtpreciounit.Text, txtcantidad.Text, txtimporte.Text);
                suma();
                txtcantidad.Clear();
                txtcodigo.Clear();
                txtimporte.Clear();
                txtnombre2.Clear();
                txtpreciounit.Clear();
                txtcodigo.Focus();
                
            }
        }

        private void txtnombre2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                dgvventas.Rows.Add(txtcodigo.Text, txtnombre2.Text, txtpreciounit.Text, txtcantidad.Text, txtimporte.Text);
                txtcodigo.Focus();
                txtcodigo.Clear();
                txtnombre2.Clear();
                txtpreciounit.Clear();
                txtcantidad.Clear();
                txtimporte.Clear();
                
            }
        }

        private void txtproducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                objconexion = new Clases.conexion();
                conexion = new SqlConnection(objconexion.conn());
                conexion.Open();
                SqlCommand comando = new SqlCommand("select  from pto_clave, pto_nombre Productos where pto_nombre=" + txtproducto.Text, conexion);
                comando.Parameters.Clear();
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@pto_clave", txtcodigo.Text);
                comando.Parameters.AddWithValue("@pto_nombre", txtnombre2.Text);
               
                SqlDataReader leer = comando.ExecuteReader();
                if (leer.Read())
                {
                    existe = 1;
                    txtcodigo.Text = leer["pto_clave"].ToString();
                    txtnombre2.Text = leer["pto_nombre"].ToString();

                }
                conexion.Close();
            }
            
        }
    }
}
