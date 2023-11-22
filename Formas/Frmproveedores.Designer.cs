namespace punto_de_venta.Formas
{
    partial class Frmproveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmproveedores));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblconsulta = new System.Windows.Forms.Label();
            this.cboxconsulta = new System.Windows.Forms.ComboBox();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.lblemail = new System.Windows.Forms.Label();
            this.lbltelefono = new System.Windows.Forms.Label();
            this.lbllocalidad = new System.Windows.Forms.Label();
            this.lbldomicilio = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.txtclave = new System.Windows.Forms.TextBox();
            this.lblclave = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtnivel13 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnmenuproveedores = new System.Windows.Forms.Button();
            this.txtproducto = new System.Windows.Forms.TextBox();
            this.lbltipoproducto = new System.Windows.Forms.Label();
            this.btnactualizar = new System.Windows.Forms.Button();
            this.lblcodigo = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtdomicilio = new System.Windows.Forms.TextBox();
            this.txtlocalidad = new System.Windows.Forms.TextBox();
            this.btnbaja = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvproveedores = new System.Windows.Forms.DataGridView();
            this.clave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.domicilio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // lblconsulta
            // 
            this.lblconsulta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblconsulta.AutoSize = true;
            this.lblconsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblconsulta.Location = new System.Drawing.Point(805, 26);
            this.lblconsulta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblconsulta.Name = "lblconsulta";
            this.lblconsulta.Size = new System.Drawing.Size(212, 25);
            this.lblconsulta.TabIndex = 39;
            this.lblconsulta.Text = "Consultar Proveedores";
            this.lblconsulta.Visible = false;
            // 
            // cboxconsulta
            // 
            this.cboxconsulta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboxconsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxconsulta.FormattingEnabled = true;
            this.cboxconsulta.Location = new System.Drawing.Point(673, 57);
            this.cboxconsulta.Margin = new System.Windows.Forms.Padding(4);
            this.cboxconsulta.Name = "cboxconsulta";
            this.cboxconsulta.Size = new System.Drawing.Size(403, 33);
            this.cboxconsulta.TabIndex = 38;
            this.cboxconsulta.Visible = false;
            // 
            // btnsalir
            // 
            this.btnsalir.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnsalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.Image = ((System.Drawing.Image)(resources.GetObject("btnsalir.Image")));
            this.btnsalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnsalir.Location = new System.Drawing.Point(1117, 649);
            this.btnsalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(131, 93);
            this.btnsalir.TabIndex = 36;
            this.btnsalir.Text = "Salir";
            this.btnsalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btneliminar.Enabled = false;
            this.btneliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminar.Image = ((System.Drawing.Image)(resources.GetObject("btneliminar.Image")));
            this.btneliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btneliminar.Location = new System.Drawing.Point(810, 649);
            this.btneliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(131, 93);
            this.btneliminar.TabIndex = 35;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnguardar.Enabled = false;
            this.btnguardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardar.Image = ((System.Drawing.Image)(resources.GetObject("btnguardar.Image")));
            this.btnguardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnguardar.Location = new System.Drawing.Point(497, 649);
            this.btnguardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(131, 93);
            this.btnguardar.TabIndex = 34;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // txtemail
            // 
            this.txtemail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtemail.Enabled = false;
            this.txtemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.Location = new System.Drawing.Point(165, 317);
            this.txtemail.Margin = new System.Windows.Forms.Padding(4);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(267, 30);
            this.txtemail.TabIndex = 32;
            // 
            // txttelefono
            // 
            this.txttelefono.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txttelefono.Enabled = false;
            this.txttelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttelefono.Location = new System.Drawing.Point(165, 258);
            this.txttelefono.Margin = new System.Windows.Forms.Padding(4);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(171, 30);
            this.txttelefono.TabIndex = 31;
            // 
            // lblemail
            // 
            this.lblemail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblemail.AutoSize = true;
            this.lblemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.Location = new System.Drawing.Point(66, 322);
            this.lblemail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(77, 25);
            this.lblemail.TabIndex = 26;
            this.lblemail.Text = "E_mail:";
            // 
            // lbltelefono
            // 
            this.lbltelefono.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbltelefono.AutoSize = true;
            this.lbltelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltelefono.Location = new System.Drawing.Point(51, 261);
            this.lbltelefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltelefono.Name = "lbltelefono";
            this.lbltelefono.Size = new System.Drawing.Size(95, 25);
            this.lbltelefono.TabIndex = 25;
            this.lbltelefono.Text = "Telefono:";
            // 
            // lbllocalidad
            // 
            this.lbllocalidad.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbllocalidad.AutoSize = true;
            this.lbllocalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllocalidad.Location = new System.Drawing.Point(41, 210);
            this.lbllocalidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbllocalidad.Name = "lbllocalidad";
            this.lbllocalidad.Size = new System.Drawing.Size(102, 25);
            this.lbllocalidad.TabIndex = 24;
            this.lbllocalidad.Text = "Localidad:";
            // 
            // lbldomicilio
            // 
            this.lbldomicilio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbldomicilio.AutoSize = true;
            this.lbldomicilio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldomicilio.Location = new System.Drawing.Point(50, 151);
            this.lbldomicilio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldomicilio.Name = "lbldomicilio";
            this.lbldomicilio.Size = new System.Drawing.Size(96, 25);
            this.lbldomicilio.TabIndex = 23;
            this.lbldomicilio.Text = "Domicilio:";
            // 
            // lblnombre
            // 
            this.lblnombre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblnombre.AutoSize = true;
            this.lblnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombre.Location = new System.Drawing.Point(56, 93);
            this.lblnombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(87, 25);
            this.lblnombre.TabIndex = 22;
            this.lblnombre.Text = "Nombre:";
            // 
            // txtclave
            // 
            this.txtclave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtclave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtclave.Location = new System.Drawing.Point(420, 57);
            this.txtclave.Margin = new System.Windows.Forms.Padding(4);
            this.txtclave.Name = "txtclave";
            this.txtclave.Size = new System.Drawing.Size(65, 30);
            this.txtclave.TabIndex = 21;
            // 
            // lblclave
            // 
            this.lblclave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblclave.AutoSize = true;
            this.lblclave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblclave.Location = new System.Drawing.Point(361, 60);
            this.lblclave.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblclave.Name = "lblclave";
            this.lblclave.Size = new System.Drawing.Size(63, 25);
            this.lblclave.TabIndex = 20;
            this.lblclave.Text = "Clave";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(532, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 75);
            this.button1.TabIndex = 40;
            this.button1.Text = "BUSCAR";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1458, 100);
            this.panel1.TabIndex = 41;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel3.Controls.Add(this.txtnivel13);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(343, 101);
            this.panel3.TabIndex = 91;
            // 
            // txtnivel13
            // 
            this.txtnivel13.Enabled = false;
            this.txtnivel13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnivel13.Location = new System.Drawing.Point(183, 35);
            this.txtnivel13.Name = "txtnivel13";
            this.txtnivel13.Size = new System.Drawing.Size(142, 30);
            this.txtnivel13.TabIndex = 1;
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
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(440, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(720, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "REGISTRO DE PROVEEDORES";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.Controls.Add(this.btnmenuproveedores);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(140, 685);
            this.panel2.TabIndex = 42;
            // 
            // btnmenuproveedores
            // 
            this.btnmenuproveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmenuproveedores.Image = ((System.Drawing.Image)(resources.GetObject("btnmenuproveedores.Image")));
            this.btnmenuproveedores.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnmenuproveedores.Location = new System.Drawing.Point(12, 306);
            this.btnmenuproveedores.Name = "btnmenuproveedores";
            this.btnmenuproveedores.Size = new System.Drawing.Size(115, 117);
            this.btnmenuproveedores.TabIndex = 43;
            this.btnmenuproveedores.Text = "Menu";
            this.btnmenuproveedores.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnmenuproveedores.UseVisualStyleBackColor = true;
            this.btnmenuproveedores.Click += new System.EventHandler(this.btnmenuproveedores_Click);
            // 
            // txtproducto
            // 
            this.txtproducto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtproducto.Enabled = false;
            this.txtproducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtproducto.Location = new System.Drawing.Point(165, 377);
            this.txtproducto.Margin = new System.Windows.Forms.Padding(4);
            this.txtproducto.Name = "txtproducto";
            this.txtproducto.Size = new System.Drawing.Size(184, 30);
            this.txtproducto.TabIndex = 44;
            // 
            // lbltipoproducto
            // 
            this.lbltipoproducto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbltipoproducto.AutoSize = true;
            this.lbltipoproducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltipoproducto.Location = new System.Drawing.Point(3, 382);
            this.lbltipoproducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltipoproducto.Name = "lbltipoproducto";
            this.lbltipoproducto.Size = new System.Drawing.Size(140, 25);
            this.lbltipoproducto.TabIndex = 43;
            this.lbltipoproducto.Text = "Tipo Producto:";
            // 
            // btnactualizar
            // 
            this.btnactualizar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnactualizar.Enabled = false;
            this.btnactualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnactualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnactualizar.Image")));
            this.btnactualizar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnactualizar.Location = new System.Drawing.Point(654, 649);
            this.btnactualizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Size = new System.Drawing.Size(131, 93);
            this.btnactualizar.TabIndex = 45;
            this.btnactualizar.Text = "Actualizar";
            this.btnactualizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnactualizar.UseVisualStyleBackColor = true;
            // 
            // lblcodigo
            // 
            this.lblcodigo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcodigo.Location = new System.Drawing.Point(74, 38);
            this.lblcodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(69, 25);
            this.lblcodigo.TabIndex = 46;
            this.lblcodigo.Text = "Clave:";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtcodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodigo.Location = new System.Drawing.Point(165, 35);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(100, 30);
            this.txtcodigo.TabIndex = 47;
            this.txtcodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcodigo_KeyPress);
            // 
            // txtnombre
            // 
            this.txtnombre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtnombre.Enabled = false;
            this.txtnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombre.Location = new System.Drawing.Point(165, 88);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(273, 30);
            this.txtnombre.TabIndex = 48;
            // 
            // txtdomicilio
            // 
            this.txtdomicilio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtdomicilio.Enabled = false;
            this.txtdomicilio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdomicilio.Location = new System.Drawing.Point(165, 146);
            this.txtdomicilio.Name = "txtdomicilio";
            this.txtdomicilio.Size = new System.Drawing.Size(273, 30);
            this.txtdomicilio.TabIndex = 49;
            // 
            // txtlocalidad
            // 
            this.txtlocalidad.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtlocalidad.Enabled = false;
            this.txtlocalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlocalidad.Location = new System.Drawing.Point(165, 205);
            this.txtlocalidad.Name = "txtlocalidad";
            this.txtlocalidad.Size = new System.Drawing.Size(273, 30);
            this.txtlocalidad.TabIndex = 50;
            // 
            // btnbaja
            // 
            this.btnbaja.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnbaja.Enabled = false;
            this.btnbaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbaja.Image = ((System.Drawing.Image)(resources.GetObject("btnbaja.Image")));
            this.btnbaja.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnbaja.Location = new System.Drawing.Point(963, 649);
            this.btnbaja.Margin = new System.Windows.Forms.Padding(4);
            this.btnbaja.Name = "btnbaja";
            this.btnbaja.Size = new System.Drawing.Size(131, 93);
            this.btnbaja.TabIndex = 51;
            this.btnbaja.Text = "Baja";
            this.btnbaja.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnbaja.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.txtcodigo);
            this.groupBox1.Controls.Add(this.lblnombre);
            this.groupBox1.Controls.Add(this.txttelefono);
            this.groupBox1.Controls.Add(this.txtemail);
            this.groupBox1.Controls.Add(this.lbllocalidad);
            this.groupBox1.Controls.Add(this.lbldomicilio);
            this.groupBox1.Controls.Add(this.lblcodigo);
            this.groupBox1.Controls.Add(this.txtnombre);
            this.groupBox1.Controls.Add(this.txtlocalidad);
            this.groupBox1.Controls.Add(this.lblemail);
            this.groupBox1.Controls.Add(this.lbltipoproducto);
            this.groupBox1.Controls.Add(this.txtdomicilio);
            this.groupBox1.Controls.Add(this.txtproducto);
            this.groupBox1.Controls.Add(this.lbltelefono);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(146, 177);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(459, 443);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consulta";
            // 
            // dgvproveedores
            // 
            this.dgvproveedores.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvproveedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvproveedores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvproveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvproveedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clave,
            this.nombre,
            this.domicilio,
            this.localidad,
            this.telefono,
            this.email,
            this.producto});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvproveedores.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvproveedores.Location = new System.Drawing.Point(621, 177);
            this.dgvproveedores.Name = "dgvproveedores";
            this.dgvproveedores.RowHeadersWidth = 51;
            this.dgvproveedores.RowTemplate.Height = 24;
            this.dgvproveedores.Size = new System.Drawing.Size(825, 443);
            this.dgvproveedores.TabIndex = 54;
            // 
            // clave
            // 
            this.clave.HeaderText = "Clave";
            this.clave.MinimumWidth = 6;
            this.clave.Name = "clave";
            this.clave.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.MinimumWidth = 6;
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // domicilio
            // 
            this.domicilio.HeaderText = "Domicilio";
            this.domicilio.MinimumWidth = 6;
            this.domicilio.Name = "domicilio";
            this.domicilio.ReadOnly = true;
            // 
            // localidad
            // 
            this.localidad.HeaderText = "Localidad";
            this.localidad.MinimumWidth = 6;
            this.localidad.Name = "localidad";
            this.localidad.ReadOnly = true;
            // 
            // telefono
            // 
            this.telefono.HeaderText = "Telefono";
            this.telefono.MinimumWidth = 6;
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            // 
            // email
            // 
            this.email.HeaderText = "Email";
            this.email.MinimumWidth = 6;
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // producto
            // 
            this.producto.HeaderText = "Tipo Producto";
            this.producto.MinimumWidth = 6;
            this.producto.Name = "producto";
            this.producto.ReadOnly = true;
            // 
            // Frmproveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1458, 785);
            this.Controls.Add(this.dgvproveedores);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnbaja);
            this.Controls.Add(this.btnactualizar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblconsulta);
            this.Controls.Add(this.cboxconsulta);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.txtclave);
            this.Controls.Add(this.lblclave);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frmproveedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proveedores";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproveedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblconsulta;
        private System.Windows.Forms.ComboBox cboxconsulta;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lbltelefono;
        private System.Windows.Forms.Label lbllocalidad;
        private System.Windows.Forms.Label lbldomicilio;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.TextBox txtclave;
        private System.Windows.Forms.Label lblclave;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnmenuproveedores;
        private System.Windows.Forms.TextBox txtproducto;
        private System.Windows.Forms.Label lbltipoproducto;
        private System.Windows.Forms.Button btnactualizar;
        private System.Windows.Forms.Label lblcodigo;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtdomicilio;
        private System.Windows.Forms.TextBox txtlocalidad;
        private System.Windows.Forms.Button btnbaja;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvproveedores;
        private System.Windows.Forms.DataGridViewTextBoxColumn clave;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn domicilio;
        private System.Windows.Forms.DataGridViewTextBoxColumn localidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn producto;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.TextBox txtnivel13;
        private System.Windows.Forms.Label label8;
    }
}