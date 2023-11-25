using CrystalDecisions.Shared;
using log4net.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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
        string nivel;
        
        
        
        public Frmventa()
        {
            InitializeComponent();
            suma();
            elimar_seldas();
            dgvinventario();
            
            
        }

        private void btnmenuventa_Click(object sender, EventArgs e)
        {
            Formas.Frmmenu x = new Formas.Frmmenu();
            AddOwnedForm(x);
            x.txtnivel11.Text = this.txtnivel15.Text;
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
        private void cambio()
        {
            
        }

        private void btnproductos_Click(object sender, EventArgs e)
        {
            Formas.Frmproductos x = new Formas.Frmproductos();
            AddOwnedForm(x);
            x.txtnivel12.Text = this.txtnivel15.Text;
            this.Hide();
            x.ShowDialog();
            this.Close();
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
                lblfecha.Enabled = true;
                lblfolio.Enabled = true;
                txtfolio.Enabled = true;
                cboxfecha.Enabled = true;
                
                
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
            lblfolio.Enabled = false;
            txtfolio.Enabled= false;
            lblfecha.Enabled= false;
            cboxfecha.Enabled = false;
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
                    dgvventas.Rows.Insert(0, txtcodigo.Text, txtnombre2.Text, txtpreciounit.Text, txtcantidad.Text = "1", txtimporte.Text = txtpreciounit.Text);
                    dgvventas.CurrentCell = dgvventas.Rows[0].Cells[0];
                    suma();
                    txtcodigo.Focus();
                    txtcodigo.SelectAll();
                    txtcantidad.Clear();
                    btnguardar.Enabled = true;
                    btntotalizar.Enabled = true;
                    btndeshacer.Enabled = true;
                    
                }
                else
                {
                    existe = 0;
                    MessageBox.Show("Error: articulo no encontrado", "ERROR!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtcodigo.Clear();
                    txtcodigo.Focus();
                }
                conexion.Close();
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
            btnguardar.Enabled = false;
            btntotalizar.Enabled = false;
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

        

        private void txtcantidad_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == 13)
            {
                //convierto los textos a double y despues el resultado a texto con tostring
                //el complemento "N2 se determina que reconozca los decimales en el resultado"
                dgvventas.Rows.RemoveAt(dgvventas.CurrentRow.Index);
                txtimporte.Text = (Convert.ToDouble(txtpreciounit.Text) * Convert.ToDouble(txtcantidad.Text)).ToString("N2");
                dgvventas.Rows.Insert(0, txtcodigo.Text, txtnombre2.Text, txtpreciounit.Text, txtcantidad.Text, txtimporte.Text);
                dgvventas.CurrentCell = dgvventas.Rows[0].Cells[0];
                suma();
                txtcantidad.Clear();
                txtcodigo.Focus();
                

            }
            else
            {

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

        
        

        private void btnguardar_Click(object sender, EventArgs e)
        {
            objconexion = new Clases.conexion();
            conexion = new SqlConnection(objconexion.conn());
            conexion.Open();
            String query = "insert into Detalleventa values (@id_producto, @precio_venta, @cantidad, @importe)";
            SqlCommand comando = new SqlCommand(query, conexion);

            foreach (DataGridViewRow row in dgvventas.Rows)
            {
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@id_producto", Convert.ToString(row.Cells["codigo"].Value));
                comando.Parameters.AddWithValue("@precio_venta", Convert.ToString(row.Cells["precio"].Value));
                comando.Parameters.AddWithValue("@cantidad", Convert.ToString(row.Cells["cantidad"].Value));
                comando.Parameters.AddWithValue("@importe", Convert.ToString(row.Cells["importe"].Value));
                comando.ExecuteNonQuery();
                dgvinventario();
                
            }
            if (rdbtncredito.Checked == true)
            {
                objconexion = new Clases.conexion();
                conexion = new SqlConnection(objconexion.conn());
                conexion.Open();
                String insert = "insert into Credito values (@ct_id_cliente, @ct_nombre_cliente, @ct_nombre_producto, @ct_cantidad, @ct_importe)";
                SqlCommand insertar = new SqlCommand(insert, conexion);

                foreach (DataGridViewRow row in dgvventas.Rows)
                {
                    insertar.Parameters.Clear();
                    insertar.Parameters.AddWithValue("@ct_id_cliente", this.txtcliente.Text);
                    insertar.Parameters.AddWithValue("@ct_nombre_cliente", this.txtnombre.Text);
                    insertar.Parameters.AddWithValue("@ct_nombre_producto", Convert.ToString(row.Cells["nombre"].Value));
                    insertar.Parameters.AddWithValue("@ct_cantidad", Convert.ToString(row.Cells["cantidad"].Value));
                    insertar.Parameters.AddWithValue("@ct_importe", Convert.ToString(row.Cells["importe"].Value));
                    insertar.ExecuteNonQuery();

                }
            }
            if (existe ==1)
            {
                MessageBox.Show("VENTA EXITOSA", "GUARDADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnguardar.Enabled = false;
                btntotalizar.Enabled = false;
                txtcodigo.Clear();
                txtnombre2.Clear();
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
                txtcliente.Clear();
                txtnombre.Clear();
                txtlocalidad.Clear();
                txttelefono.Clear();
                rdbtncontado.Focus();
            }
            conexion.Close();
        }
        private void elimar_seldas()
        {
            dgvventas.AllowUserToAddRows = false;
            
            
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void dgvinventario()
        {
            Formas.Frminventario x = new Formas.Frminventario();
            AddOwnedForm(x);
            x.dgvinventario.Rows.Add(txtcodigo.Text, txtnombre2.Text, txtpreciounit.Text, txtcantidad.Text, txtimporte.Text);
            
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            //convierto los textos a double y despues el resultado a texto con tostring
            //el complemento "N2 se determina que reconozca los decimales en el resultado"
            dgvventas.Rows.RemoveAt(dgvventas.CurrentRow.Index);
            txtimporte.Text = (Convert.ToDouble(txtpreciounit.Text) * Convert.ToDouble(txtcantidad.Text)).ToString("N2");
            dgvventas.Rows.Insert(0, txtcodigo.Text, txtnombre2.Text, txtpreciounit.Text, txtcantidad.Text, txtimporte.Text);
            suma();
            txtcantidad.Clear();
            dgvventas.ClearSelection();
            txtcodigo.Focus();
        }
    }
}
