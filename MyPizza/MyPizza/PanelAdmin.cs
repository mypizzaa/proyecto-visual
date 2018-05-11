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
    public partial class PanelAdmin : Form
    {
        public PanelAdmin()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (menuVertical.Width == 250)
            {
                menuVertical.Width = 40;
            }else
            {
                menuVertical.Width = 250;
            }
        }

        private void iconoCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconoMaxi_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            iconoMaxi.Visible = false;
            iconoRestaurar.Visible = true;
            
        }

        private void iconoRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            iconoMaxi.Visible = true;
            iconoRestaurar.Visible = false;
        }

        private void iconoMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void AbrirPanel(object formhijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);

            Form fh = formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            AbrirPanel(new SelectorPizzas());
        }
    }
}
