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

        public DetallesPedido()
        {
            cp = new ControladorPago();
            InitializeComponent();
            loadPayMethods();
            txtDetalles.Enabled = false;
        }

        private void loadPayMethods()
        {
            mpList = cp.listarMetodos();
            foreach(MetodoPago mp in mpList)
            {
                cbPago.Items.Add(mp.getNombre());
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            
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
