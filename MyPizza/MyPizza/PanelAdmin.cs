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

        //Menu burger
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

        //Icono de cerrar ventana
        private void iconoCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Icono de maximizar ventana
        private void iconoMaxi_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            iconoMaxi.Visible = false;
            iconoRestaurar.Visible = true;
            
        }

        //Icono de restaurar ventana
        private void iconoRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            iconoMaxi.Visible = true;
            iconoRestaurar.Visible = false;
        }

        //Icono de minimizar
        private void iconoMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        /// <summary>
        /// Este metodo recibe como parametro un objeto que sera el formulario que se 
        /// quiere cargar en el panel contenedor.
        /// </summary>
        /// <param name="formhijo">formulario</param>
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

        //Menu vertical - PIZZA
        private void button1_Click(object sender, EventArgs e)
        {
            AbrirPanel(new AdminPizza());
        }

        //Menu vertical - BEBIDAS
        private void button4_Click(object sender, EventArgs e)
        {
            AbrirPanel(new AdminBebidas());
        }

        //Menu vertical - EMPLEADOS
        private void button2_Click(object sender, EventArgs e)
        {
            AbrirPanel(new AdminEmpleados());
        }

        //Menu Vertical - STOCK
        private void button3_Click(object sender, EventArgs e)
        {
            AbrirPanel(new AdminStock());
        }

        //Menu Vertical - VENTAS
        private void button5_Click(object sender, EventArgs e)
        {
            AbrirPanel(new AdminVentas());
        }
    }
}
