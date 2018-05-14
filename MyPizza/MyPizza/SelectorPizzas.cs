using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class SelectorPizzas : Form
    {
        private List<Object> listaPedido = new List<object>();

        public SelectorPizzas()
        {
            InitializeComponent();
        }

        //listview ingredeintes
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String item = listViewIngredientes.Items[0].ToString();
            MessageBox.Show(item);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            addBebida("Cerveza");
        }

        private void nuevoPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuevoPedido np = new NuevoPedido();
            np.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ingrediente i = new Ingrediente(01,"queso",20,"hola",01,01);

          
            List<Ingrediente> list = new List<Ingrediente>();
            list.Add(i);
            addPizza("Mediterranea",list);
        }

        /// <summary>
        /// Este metodo añade una pizza con sus ingredientes al treeview
        /// </summary>
        /// <param name="nombre">nombre de la pizza</param>
        /// <param name="listIng">lista de ingredientes</param>
        public void addPizza(String nombre, List<Ingrediente> listIng)
        {

            ImageList imagelist1 = new ImageList();
                            
            imagelist1.Images.Add(Image.FromFile("..\\..\\Resources\\pizza.png"));
            TreeNode[] ingredientes = null;          
            
            foreach(Ingrediente i in listIng)
            {
                TreeNode ingrediente = new TreeNode(i.getNombre());
                ingredientes = new TreeNode[] { ingrediente };
            }

            TreeNode pizza = new TreeNode(nombre,ingredientes);
            treeViewPedido.Nodes.Add(pizza);
            treeViewPedido.ImageList = imagelist1;
        }

        /// <summary>
        /// Este metodo añade una bebida la cual seleccionemos en el treeview
        /// </summary>
        /// <param name="bebida">nombre de la bebida</param>
        public void addBebida(String bebida)
        {
            ImageList imagelist2 = new ImageList();
            imagelist2.Images.Add(Image.FromFile("..\\..\\Resources\\can.png"));
            treeViewPedido.Nodes.Add(bebida);
            treeViewPedido.ImageList = imagelist2;
        }
        
        //Boton de quitar
        //Este boton quita el node seleccionado en el treeview
        private void button19_Click(object sender, EventArgs e)
        {
            try
            {
                treeViewPedido.SelectedNode.Remove();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No hay ningun item seleccionado");
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Observaciones obs = new Observaciones();
            obs.ShowDialog();
        }
    }
}
