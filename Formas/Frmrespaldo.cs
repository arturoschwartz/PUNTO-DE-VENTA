﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace punto_de_venta.Formas
{
    public partial class Frmrespaldo : Form
    {
        public Frmrespaldo()
        {
            InitializeComponent();
        }

        private void btnmenurespaldo_Click(object sender, EventArgs e)
        {
            Formas.Frmmenu x = new Formas.Frmmenu();
            x.Show();
            this.Hide();
        }

        private void btnsalirrespaldo_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}