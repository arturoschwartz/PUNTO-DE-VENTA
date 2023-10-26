using CrystalDecisions.Shared;
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
    public partial class Frmventa : Form
    {
        Clases.conexion objconexion;
        SqlConnection conexion;
        int existe;
        public Frmventa()
        {
            InitializeComponent();
            suma();
            cargar_cboxproducto();
            cargar_cboxcliente();
            
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
            if (e.KeyChar == 13)
            {
                if (string.IsNullOrEmpty(txtcodigo.Text))
                {
                    MessageBox.Show("ERROR: Nose se permiten nulos!!", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                objconexion = new Clases.conexion();
                conexion = new SqlConnection(objconexion.conn());
                conexion.Open();
                string query = "select * from Productos where pr_clave=@pr_clave";
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@pr_clave", txtcodigo.Text);
                comando.Parameters.AddWithValue("@pr_nombre", txtnombre2.Text);
                comando.Parameters.AddWithValue("@pr_precio", txtpreciounit.Text);

                SqlDataReader leer = comando.ExecuteReader();
                if (leer.Read())
                {
                    existe = 1;
                    txtcodigo.Text = leer["pr_clave"].ToString();
                    txtnombre2.Text = leer["pr_nombre"].ToString();
                    txtpreciounit.Text = leer["pr_precio"].ToString();
                    dgvventas.Rows.Add(txtcodigo.Text, txtnombre2.Text, txtpreciounit.Text);
                    txtcodigo.Clear();
                    suma();
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

        }
        

        private void suma()
        {
            double total = 0;
            foreach (DataGridViewRow row in dgvventas.Rows)
            {
                total += Convert.ToDouble(row.Cells["precio"].Value);
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
            catch
            {

            }
        }

        public void cargar_cboxproducto()
        {
            objconexion = new Clases.conexion();
            conexion = new SqlConnection(objconexion.conn());
            conexion.Open();
            SqlCommand command = new SqlCommand("SELECT pr_nombre from Productos", conexion);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            conexion.Close();

            DataRow fila = dataTable.NewRow();
            fila["pr_nombre"] = "Seleccione un Producto";
            dataTable.Rows.InsertAt(fila, 0);

            cboxproducto.ValueMember = "pr_nombre";
            cboxproducto.DisplayMember = "pr_nombre";
            cboxproducto.DataSource = dataTable;
        }

        public void cargar_cboxcliente()
        {
            objconexion = new Clases.conexion();
            conexion = new SqlConnection(objconexion.conn());
            conexion.Open();
            SqlCommand command = new SqlCommand("SELECT cl_nombre from Clientes", conexion);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            conexion.Close();

            DataRow fila = dataTable.NewRow();
            fila["cl_nombre"] = "Seleccione un Cliente";
            dataTable.Rows.InsertAt(fila, 0);

            cboxcliente.ValueMember = "cl_nombre";
            cboxcliente.DisplayMember = "cl_nombre";
            cboxcliente.DataSource = dataTable;
        }

        private void txtpago_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                try
                {
                    txtcambio.Text = (float.Parse(txtpago.Text) - float.Parse(txttotal.Text)).ToString();
                }
                catch
                {

                }
            }
        }
    }
}
