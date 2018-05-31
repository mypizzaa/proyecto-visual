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
    public partial class EstadoPedidos : Form
    {

        private List<PedidoInfo> listaPedidos;

        private ControladorPedidos cp;

        public EstadoPedidos()
        {
            cp = new ControladorPedidos();
            InitializeComponent();
            cargarPedidos();
        }

        private void cargarPedidos()
        {
            listaPedidos = cp.listarPedidos();

            foreach (PedidoInfo p in listaPedidos)
            {
                
                listViewPedidos.Items.Add(p.getId_pedido_info().ToString());
                
                
            }
        }

        //Buscar pedido
        private void buscarPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            BuscarPedido bp = new BuscarPedido();
            bp.Show();

        }

        //close
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
