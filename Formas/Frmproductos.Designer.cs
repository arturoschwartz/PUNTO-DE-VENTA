namespace punto_de_venta.Formas
{
    partial class Frmproductos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmproductos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btncerrar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.txtprecioventa = new System.Windows.Forms.TextBox();
            this.txtexistencia = new System.Windows.Forms.TextBox();
            this.lblprecioventa = new System.Windows.Forms.Label();
            this.lblexistencia = new System.Windows.Forms.Label();
            this.btnguaradar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnmenuproductos = new System.Windows.Forms.Button();
            this.btnventasproductos = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.lblnombre1 = new System.Windows.Forms.Label();
            this.lblcodigo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.existencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnactualizar = new System.Windows.Forms.Button();
            this.btndeshacer = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btncerrar
            // 
            this.btncerrar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btncerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncerrar.Image = ((System.Drawing.Image)(resources.GetObject("btncerrar.Image")));
            this.btncerrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btncerrar.Location = new System.Drawing.Point(1279, 608);
            this.btncerrar.Margin = new System.Windows.Forms.Padding(4);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(122, 93);
            this.btncerrar.TabIndex = 87;
            this.btncerrar.Text = "Salir";
            this.btncerrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btncerrar.UseVisualStyleBackColor = true;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btneliminar.Enabled = false;
            this.btneliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminar.Image = ((System.Drawing.Image)(resources.GetObject("btneliminar.Image")));
            this.btneliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btneliminar.Location = new System.Drawing.Point(992, 608);
            this.btneliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(122, 93);
            this.btneliminar.TabIndex = 86;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnbuscar
            // 
            this.btnbuscar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnbuscar.Image")));
            this.btnbuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnbuscar.Location = new System.Drawing.Point(1136, 608);
            this.btnbuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(122, 93);
            this.btnbuscar.TabIndex = 83;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // txtprecioventa
            // 
            this.txtprecioventa.Enabled = false;
            this.txtprecioventa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprecioventa.Location = new System.Drawing.Point(159, 244);
            this.txtprecioventa.Margin = new System.Windows.Forms.Padding(4);
            this.txtprecioventa.Name = "txtprecioventa";
            this.txtprecioventa.Size = new System.Drawing.Size(150, 30);
            this.txtprecioventa.TabIndex = 82;
            // 
            // txtexistencia
            // 
            this.txtexistencia.Enabled = false;
            this.txtexistencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtexistencia.Location = new System.Drawing.Point(124, 179);
            this.txtexistencia.Margin = new System.Windows.Forms.Padding(4);
            this.txtexistencia.Name = "txtexistencia";
            this.txtexistencia.Size = new System.Drawing.Size(216, 30);
            this.txtexistencia.TabIndex = 81;
            // 
            // lblprecioventa
            // 
            this.lblprecioventa.AutoSize = true;
            this.lblprecioventa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprecioventa.Location = new System.Drawing.Point(1, 249);
            this.lblprecioventa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblprecioventa.Name = "lblprecioventa";
            this.lblprecioventa.Size = new System.Drawing.Size(141, 25);
            this.lblprecioventa.TabIndex = 78;
            this.lblprecioventa.Text = "Precio venta  $";
            // 
            // lblexistencia
            // 
            this.lblexistencia.AutoSize = true;
            this.lblexistencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblexistencia.Location = new System.Drawing.Point(9, 182);
            this.lblexistencia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblexistencia.Name = "lblexistencia";
            this.lblexistencia.Size = new System.Drawing.Size(107, 25);
            this.lblexistencia.TabIndex = 77;
            this.lblexistencia.Text = "Existencia:";
            // 
            // btnguaradar
            // 
            this.btnguaradar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnguaradar.Enabled = false;
            this.btnguaradar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguaradar.Image = ((System.Drawing.Image)(resources.GetObject("btnguaradar.Image")));
            this.btnguaradar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnguaradar.Location = new System.Drawing.Point(848, 608);
            this.btnguaradar.Name = "btnguaradar";
            this.btnguaradar.Size = new System.Drawing.Size(122, 93);
            this.btnguaradar.TabIndex = 88;
            this.btnguaradar.Text = "Guardar";
            this.btnguaradar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnguaradar.UseVisualStyleBackColor = true;
            this.btnguaradar.Click += new System.EventHandler(this.btnguaradar_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(445, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(659, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "REGISTRO DE PRODUCTOS";
            // 
            // btnmenuproductos
            // 
            this.btnmenuproductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmenuproductos.Image = ((System.Drawing.Image)(resources.GetObject("btnmenuproductos.Image")));
            this.btnmenuproductos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnmenuproductos.Location = new System.Drawing.Point(12, 356);
            this.btnmenuproductos.Name = "btnmenuproductos";
            this.btnmenuproductos.Size = new System.Drawing.Size(111, 115);
            this.btnmenuproductos.TabIndex = 93;
            this.btnmenuproductos.Text = "Menu";
            this.btnmenuproductos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnmenuproductos.UseVisualStyleBackColor = true;
            this.btnmenuproductos.Click += new System.EventHandler(this.btnmenuproductos_Click);
            // 
            // btnventasproductos
            // 
            this.btnventasproductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnventasproductos.Image = ((System.Drawing.Image)(resources.GetObject("btnventasproductos.Image")));
            this.btnventasproductos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnventasproductos.Location = new System.Drawing.Point(12, 220);
            this.btnventasproductos.Name = "btnventasproductos";
            this.btnventasproductos.Size = new System.Drawing.Size(111, 115);
            this.btnventasproductos.TabIndex = 92;
            this.btnventasproductos.Text = "Venta";
            this.btnventasproductos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnventasproductos.UseVisualStyleBackColor = true;
            this.btnventasproductos.Click += new System.EventHandler(this.btnventasproductos_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.txtnombre);
            this.groupBox1.Controls.Add(this.txtcodigo);
            this.groupBox1.Controls.Add(this.lblnombre1);
            this.groupBox1.Controls.Add(this.lblcodigo);
            this.groupBox1.Controls.Add(this.txtexistencia);
            this.groupBox1.Controls.Add(this.lblexistencia);
            this.groupBox1.Controls.Add(this.lblprecioventa);
            this.groupBox1.Controls.Add(this.txtprecioventa);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(155, 181);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(366, 345);
            this.groupBox1.TabIndex = 93;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de Consulta";
            // 
            // txtnombre
            // 
            this.txtnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombre.Location = new System.Drawing.Point(102, 106);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(238, 30);
            this.txtnombre.TabIndex = 3;
            // 
            // txtcodigo
            // 
            this.txtcodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodigo.Location = new System.Drawing.Point(102, 44);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(163, 30);
            this.txtcodigo.TabIndex = 2;
            this.txtcodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcodigo_KeyPress);
            // 
            // lblnombre1
            // 
            this.lblnombre1.AutoSize = true;
            this.lblnombre1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombre1.Location = new System.Drawing.Point(9, 106);
            this.lblnombre1.Name = "lblnombre1";
            this.lblnombre1.Size = new System.Drawing.Size(87, 25);
            this.lblnombre1.TabIndex = 1;
            this.lblnombre1.Text = "Nombre:";
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcodigo.Location = new System.Drawing.Point(15, 47);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(81, 25);
            this.lblcodigo.TabIndex = 0;
            this.lblcodigo.Text = "Codigo:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1413, 100);
            this.panel1.TabIndex = 94;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.Controls.Add(this.btnventasproductos);
            this.panel2.Controls.Add(this.btnmenuproductos);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(149, 707);
            this.panel2.TabIndex = 95;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.nombre,
            this.existencia,
            this.precio});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(527, 181);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(874, 345);
            this.dataGridView1.TabIndex = 96;
            // 
            // codigo
            // 
            this.codigo.FillWeight = 60F;
            this.codigo.HeaderText = "Codigo";
            this.codigo.MinimumWidth = 6;
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.FillWeight = 150F;
            this.nombre.HeaderText = "Nombre";
            this.nombre.MinimumWidth = 6;
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // existencia
            // 
            this.existencia.HeaderText = "Existencia";
            this.existencia.MinimumWidth = 6;
            this.existencia.Name = "existencia";
            this.existencia.ReadOnly = true;
            // 
            // precio
            // 
            this.precio.HeaderText = "Precio venta";
            this.precio.MinimumWidth = 6;
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            // 
            // btnactualizar
            // 
            this.btnactualizar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnactualizar.Enabled = false;
            this.btnactualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnactualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnactualizar.Image")));
            this.btnactualizar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnactualizar.Location = new System.Drawing.Point(699, 608);
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Size = new System.Drawing.Size(122, 93);
            this.btnactualizar.TabIndex = 97;
            this.btnactualizar.Text = "Actualizar";
            this.btnactualizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnactualizar.UseVisualStyleBackColor = true;
            this.btnactualizar.Click += new System.EventHandler(this.btnactualizar_Click);
            // 
            // btndeshacer
            // 
            this.btndeshacer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btndeshacer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndeshacer.Image = ((System.Drawing.Image)(resources.GetObject("btndeshacer.Image")));
            this.btndeshacer.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btndeshacer.Location = new System.Drawing.Point(550, 608);
            this.btndeshacer.Name = "btndeshacer";
            this.btndeshacer.Size = new System.Drawing.Size(122, 93);
            this.btndeshacer.TabIndex = 98;
            this.btndeshacer.Text = "Deshacer";
            this.btndeshacer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btndeshacer.UseVisualStyleBackColor = true;
            this.btndeshacer.Click += new System.EventHandler(this.btndeshacer_Click);
            // 
            // Frmproductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1413, 807);
            this.Controls.Add(this.btndeshacer);
            this.Controls.Add(this.btnactualizar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnguaradar);
            this.Controls.Add(this.btncerrar);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnbuscar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frmproductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Productos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btncerrar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.TextBox txtprecioventa;
        private System.Windows.Forms.TextBox txtexistencia;
        private System.Windows.Forms.Label lblprecioventa;
        private System.Windows.Forms.Label lblexistencia;
        private System.Windows.Forms.Button btnguaradar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnventasproductos;
        private System.Windows.Forms.Button btnmenuproductos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label lblnombre1;
        private System.Windows.Forms.Label lblcodigo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnactualizar;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn existencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.Button btndeshacer;
    }
}