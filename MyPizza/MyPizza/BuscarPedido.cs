﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class BuscarPedido : Form
    {
        public BuscarPedido()
        {
            InitializeComponent();
        }

        //cerrar form
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
