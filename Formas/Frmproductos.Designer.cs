﻿namespace punto_de_venta.Formas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btncerrar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.txtprecioventa = new System.Windows.Forms.TextBox();
            this.lblprecioventa = new System.Windows.Forms.Label();
            this.lblexistencia = new System.Windows.Forms.Label();
            this.btnguaradar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnmenuproductos = new System.Windows.Forms.Button();
            this.btnventasproductos = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtexistencia = new System.Windows.Forms.TextBox();
            this.txtcosto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.lblnombre1 = new System.Windows.Forms.Label();
            this.lblcodigo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtnivel12 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvproductos = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.existencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnactualizar = new System.Windows.Forms.Button();
            this.btndeshacer = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproductos)).BeginInit();
            this.SuspendLayout();
            // 
            // btncerrar
            // 
            this.btncerrar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btncerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncerrar.Image = ((System.Drawing.Image)(resources.GetObject("btncerrar.Image")));
            this.btncerrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btncerrar.Location = new System.Drawing.Point(1278, 580);
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
            this.btneliminar.Location = new System.Drawing.Point(991, 580);
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
            this.btnbuscar.Location = new System.Drawing.Point(1135, 580);
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
            this.txtprecioventa.Location = new System.Drawing.Point(158, 188);
            this.txtprecioventa.Margin = new System.Windows.Forms.Padding(4);
            this.txtprecioventa.Name = "txtprecioventa";
            this.txtprecioventa.Size = new System.Drawing.Size(165, 30);
            this.txtprecioventa.TabIndex = 82;
            // 
            // lblprecioventa
            // 
            this.lblprecioventa.AutoSize = true;
            this.lblprecioventa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprecioventa.Location = new System.Drawing.Point(5, 193);
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
            this.lblexistencia.Location = new System.Drawing.Point(5, 139);
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
            this.btnguaradar.Location = new System.Drawing.Point(847, 580);
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
            this.btnmenuproductos.Size = new System.Drawing.Size(124, 117);
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
            this.btnventasproductos.Size = new System.Drawing.Size(124, 112);
            this.btnventasproductos.TabIndex = 92;
            this.btnventasproductos.Text = "Venta";
            this.btnventasproductos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnventasproductos.UseVisualStyleBackColor = true;
            this.btnventasproductos.Click += new System.EventHandler(this.btnventasproductos_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.txtexistencia);
            this.groupBox1.Controls.Add(this.txtcosto);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtnombre);
            this.groupBox1.Controls.Add(this.txtcodigo);
            this.groupBox1.Controls.Add(this.lblnombre1);
            this.groupBox1.Controls.Add(this.lblcodigo);
            this.groupBox1.Controls.Add(this.lblexistencia);
            this.groupBox1.Controls.Add(this.lblprecioventa);
            this.groupBox1.Controls.Add(this.txtprecioventa);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(155, 181);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 332);
            this.groupBox1.TabIndex = 93;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de Consulta";
            // 
            // txtexistencia
            // 
            this.txtexistencia.Enabled = false;
            this.txtexistencia.Location = new System.Drawing.Point(119, 139);
            this.txtexistencia.Name = "txtexistencia";
            this.txtexistencia.Size = new System.Drawing.Size(199, 30);
            this.txtexistencia.TabIndex = 101;
            // 
            // txtcosto
            // 
            this.txtcosto.Enabled = false;
            this.txtcosto.Location = new System.Drawing.Point(158, 244);
            this.txtcosto.Name = "txtcosto";
            this.txtcosto.Size = new System.Drawing.Size(165, 30);
            this.txtcosto.TabIndex = 85;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 25);
            this.label2.TabIndex = 84;
            this.label2.Text = "Precio Costo $";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(99, 93);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(219, 30);
            this.txtnombre.TabIndex = 83;
            // 
            // txtcodigo
            // 
            this.txtcodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodigo.Location = new System.Drawing.Point(92, 44);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(226, 30);
            this.txtcodigo.TabIndex = 2;
            this.txtcodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcodigo_KeyPress);
            // 
            // lblnombre1
            // 
            this.lblnombre1.AutoSize = true;
            this.lblnombre1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombre1.Location = new System.Drawing.Point(6, 93);
            this.lblnombre1.Name = "lblnombre1";
            this.lblnombre1.Size = new System.Drawing.Size(87, 25);
            this.lblnombre1.TabIndex = 1;
            this.lblnombre1.Text = "Nombre:";
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcodigo.Location = new System.Drawing.Point(5, 47);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(81, 25);
            this.lblcodigo.TabIndex = 0;
            this.lblcodigo.Text = "Codigo:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1413, 100);
            this.panel1.TabIndex = 94;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel3.Controls.Add(this.txtnivel12);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(343, 100);
            this.panel3.TabIndex = 99;
            // 
            // txtnivel12
            // 
            this.txtnivel12.Enabled = false;
            this.txtnivel12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnivel12.Location = new System.Drawing.Point(183, 35);
            this.txtnivel12.Name = "txtnivel12";
            this.txtnivel12.Size = new System.Drawing.Size(142, 30);
            this.txtnivel12.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(17, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(160, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "Nivel de Usuario:";
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
            // dgvproductos
            // 
            this.dgvproductos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvproductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvproductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvproductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvproductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.nombre,
            this.existencia,
            this.precio,
            this.costo});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvproductos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvproductos.Location = new System.Drawing.Point(501, 181);
            this.dgvproductos.Name = "dgvproductos";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvproductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvproductos.RowHeadersWidth = 51;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Blue;
            this.dgvproductos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvproductos.RowTemplate.Height = 24;
            this.dgvproductos.Size = new System.Drawing.Size(900, 332);
            this.dgvproductos.TabIndex = 96;
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
            this.precio.HeaderText = "Precio Venta";
            this.precio.MinimumWidth = 6;
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            // 
            // costo
            // 
            this.costo.HeaderText = "Precio Costo";
            this.costo.MinimumWidth = 6;
            this.costo.Name = "costo";
            this.costo.ReadOnly = true;
            // 
            // btnactualizar
            // 
            this.btnactualizar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnactualizar.Enabled = false;
            this.btnactualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnactualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnactualizar.Image")));
            this.btnactualizar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnactualizar.Location = new System.Drawing.Point(698, 580);
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
            this.btndeshacer.Location = new System.Drawing.Point(549, 580);
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
            this.Controls.Add(this.dgvproductos);
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
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvproductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btncerrar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.TextBox txtprecioventa;
        private System.Windows.Forms.Label lblprecioventa;
        private System.Windows.Forms.Label lblexistencia;
        private System.Windows.Forms.Button btnguaradar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnventasproductos;
        private System.Windows.Forms.Button btnmenuproductos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label lblnombre1;
        private System.Windows.Forms.Label lblcodigo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvproductos;
        private System.Windows.Forms.Button btnactualizar;
        private System.Windows.Forms.Button btndeshacer;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtcosto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn existencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn costo;
        private System.Windows.Forms.TextBox txtexistencia;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.TextBox txtnivel12;
        private System.Windows.Forms.Label label8;
    }
}