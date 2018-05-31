using Modelo;
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
    public partial class DetallesPedido : Form
    {
        public DetallesPedido(Cliente c)
        {
            InitializeComponent();
            cargarDatosCliente(c);
        }
                
        public void cargarDatosCliente(Cliente c)
        {
            txtNombre.Text = c.getNombre();
            txtApellidos.Text = c.getApellidos();
            txtDireccion1.Text = c.getPrimeraDireccion();
            txtDireccion2.Text = c.getSegundaDireccion();
            txtTelefono.Text = c.getTelefono();
            txtCodigoPostal.Text = c.getCodigoPostal();

            DateTime localDate = DateTime.Now;
            txtDiaHora.Text = localDate.ToString();
        
        }
            

        private void toolStripButton2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
