using System;
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
    public partial class LocalizadorEnvios : Form
    {
        public LocalizadorEnvios()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String direccion = tbDireccion.Text;

            StringBuilder sb = new StringBuilder();
            sb.Append("http://maps.google.com/maps?q=");
            sb.Append(direccion);

            webBrowser1.Navigate(sb.ToString());

        }
    }
}
