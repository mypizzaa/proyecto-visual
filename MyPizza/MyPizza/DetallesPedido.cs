using Controlador;
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
        private ControladorPago cp;
        private List<MetodoPago> mpList = null;
        private Cliente c;

        public DetallesPedido() { }

        public DetallesPedido(Cliente c)
        {
            cp = new ControladorPago();
            InitializeComponent();
            loadPayMethods();
            txtDetalles.Enabled = false;
            this.c = c;
        }

        private void loadPayMethods()
        {
            mpList = cp.listarMetodos();
            foreach(MetodoPago mp in mpList)
            {
                cbPago.Items.Add(mp.getNombre());
            }

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

        private void DetallesPedido_Load(object sender, EventArgs e)
        {

        }

        private void cbPago_SelectedIndexChanged(object sender, EventArgs e)
        {

                txtDetalles.Text = mpList[cbPago.SelectedIndex].getDetalles();
                MessageBox.Show(mpList[cbPago.SelectedIndex].getDetalles());

        }

        private void bAceptar_Click(object sender, EventArgs e)
        {

        }
    }
}
