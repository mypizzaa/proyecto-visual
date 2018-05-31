using Controlador;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
      
    public partial class SelectorPizzas : Form
    {
        
        private ControladorServicio cs;
        private ControladorProductos cp;
        private ControladorPedidos cPed;

        private List<Pizza> listaPizzas;
        private List<Object> listaPedido = new List<object>();   
        private List<PictureBox> listaPictureBoxPizzas = new List<PictureBox>();

        public SelectorPizzas()
        {

            cs = new ControladorServicio();
            cp = new ControladorProductos();
            cPed = new ControladorPedidos();
            InitializeComponent();
            
            Boolean connected = cs.getConnection();

            if (connected != false)
            {

                loadPizzas();
                loadIngredientes();
                loadBebidas();

            }else
            {
                ErrorServicio es = new ErrorServicio();
                es.ShowDialog();
            }
        }
        
        /// <summary>
        /// Este metodo carga las imagenes de las pizzas de forma dinamica y genera un picture box de cada una.
        /// La imagen la recoge de el servidor de provenapps.cat
        /// </summary>
        private void loadPizzas()
        {
            
            listaPizzas = cp.listarPizzas();
            
            int j = 0;
            int x = 0;
            int x1 = 0;
            int y = 0;

            int xLabel= 0;
            int yLabel =137;

            if (listaPizzas != null)
            {
                for (int i = 0; i < listaPizzas.Count; i++)
                {
                    String pathimg = listaPizzas[i].getImagen();

                    PictureBox pb = new PictureBox();
                    pb.Name = listaPizzas[i].getNombre();
                    pb.Width = 141;
                    pb.Height = 133;
                    pb.ImageLocation = "http://provenapps.cat/~dam1804/Images/pizzas/"+pathimg;
                    pb.BorderStyle = BorderStyle.FixedSingle;
                    pb.BackColor = Color.White;
                    pb.Click += new System.EventHandler(this.pressedPizza);

                    if (i % 5 == 0 && i != 0)
                    {
                        y += 169;
                        yLabel += 169;
                        j = 0;
                    }

                    x1 = x + (j * 170);


                    pb.Location = new Point(x1, y);
                    listaPictureBoxPizzas.Add(pb);

                    Label lb = new Label();
                    lb.Text = listaPizzas[i].getNombre();
                    lb.Location = new Point(x1,yLabel);

                    panelPizzas.Controls.Add(pb);
                    panelPizzas.Controls.Add(lb);

                    j++;
                    
                    }
            }else
            {
                MessageBox.Show("Se perdió la conexion con el servicio");
            }

        }
             
        /// <summary>
        /// Este metodo carga los ingredientes de la bbdd en el listviewingredientes
        /// </summary>
        private void loadIngredientes()
        {
            List<Ingrediente> listaIngredientes = cp.listarIngredientes();
            if(listaIngredientes != null)
            {
                foreach(Ingrediente i in listaIngredientes)
                {
                    listViewIngredientes.Items.Add(i.getNombre());
                }

            }else
            {
                MessageBox.Show("Se perdió la conexion con el servicio");
            }

        }

        private void loadBebidas()
        {
            List<Refresco> listaRefrescos = cp.listarRefrescos();

            int x = 40;           
            int y = 0;

            try
            {
                if (listaRefrescos != null)
                {
                    for (int i = 0; i < listaRefrescos.Count; i++)
                    {
                        String pathimg = listaRefrescos[i].getImagen();

                        PictureBox pb = new PictureBox();
                        pb.Name = listaRefrescos[i].getNombre();
                        pb.Width = 100;
                        pb.Height = 100;
                        pb.ImageLocation = "http://provenapps.cat/~dam1804/Images/bebidas/" + pathimg;

                        pb.BorderStyle = BorderStyle.None;
                        pb.BackColor = Color.White;
                        pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                        pb.Click += new System.EventHandler(this.pressedBebida);

                        if (i != 0)
                        {
                            y += 169;

                        }

                        pb.Location = new Point(x, y);
                        panelBebidas.Controls.Add(pb);

                    }
                }
            }
            catch (Exception ex)
            {
                
            }
        }


        //listview ingredeintes
        private async void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                String nodeSeleccionado = treeViewPedido.SelectedNode.Text; //pizza selected

                String seleccionado = ""; //ingredient selected

                ListView.SelectedListViewItemCollection listItems = this.listViewIngredientes.SelectedItems;

                foreach (ListViewItem item in listItems)
                {
                    seleccionado = item.Text;
                    treeViewPedido.Nodes[nodeSeleccionado].Nodes.Add(seleccionado);
                    Ingrediente i = await cp.buscarIngredientePorNombre(seleccionado);

                    cPed.sumarTotal(i.getPrecio());
                                        
                }
            }
            catch (System.NullReferenceException snf)
            {
                Alert("Porfavor seleccione una pizza", "Error");
            }

        }

        public void Alert(String mensaje, string titulo)
        {
            MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }




        /// <summary>
        /// Este metodo es al que acuden todos los botones de cada pizza
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void pressedPizza(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;

            String nombrepizza = pb.Name;
            Pizza p = await cp.buscarPizzaPorNombre(nombrepizza);

            addPizza(p);

        }

        private async void pressedBebida(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;

            Refresco r = await cp.buscarRefrescoPorNombre(pb.Name);

            addBebida(r);

        }


        /// <summary>
        /// this method add a pizza in the listview pedido
        /// </summary>
        /// <param name="nombre">name of pizza</param>
        /// <param name="listIng">lista de ingredientes</param>
        public void addPizza(Pizza p)
        {

            ImageList imagelist1 = new ImageList();                            
            imagelist1.Images.Add(Image.FromFile("..\\..\\Resources\\pizza.png"));
            
            string key = p.getNombre();
            double num = cPed.sumarTotal(p.getPrecio());
            actualizarTxtTotal(num);
            
            treeViewPedido.Nodes.Add(key, p.getNombre()); //parent

            List<Ingrediente> listaIng = cp.listarIngredientesPizza(p.getIdPizza().ToString());

            if (listaIng != null)
            {
                foreach (Ingrediente i in listaIng)
                {
                    treeViewPedido.Nodes[key].Nodes.Add(i.getNombre());   //childs             
                }
            }else
            {
                Alert("No se encuentran ingredientes.","Error servicio");
            }
            treeViewPedido.ImageList = imagelist1;
            treeViewPedido.ExpandAll();                      
                       
        }
        

        /// <summary>
        /// This method add a drink in the listview pedido
        /// </summary>
        /// <param name="bebida">drink</param>
        public void addBebida(Refresco bebida)
        {
            ImageList imagelist2 = new ImageList();
            imagelist2.Images.Add(Image.FromFile("..\\..\\Resources\\can.png"));

            String key = bebida.getNombre();
            treeViewPedido.Nodes.Add(key, bebida.getNombre());

            double num = cPed.sumarTotal(bebida.getPrecio());
            actualizarTxtTotal(num);

            treeViewPedido.ImageList = imagelist2;
        }


        //remove the node selected
        private async void bQuitar_Click(object sender, EventArgs e)
        {
            try
            {

                String nodeSeleccionado = treeViewPedido.SelectedNode.Text; //producto seleccionado

                Pizza p = await cp.buscarPizzaPorNombre(nodeSeleccionado);
                Refresco r = await cp.buscarRefrescoPorNombre(nodeSeleccionado);

                if (p != null)
                {
                    double num = cPed.restarTotal(p.getPrecio());
                    treeViewPedido.SelectedNode.Remove();
                    actualizarTxtTotal(num);
                }
                else if (r != null)
                {
                    double num = cPed.restarTotal(r.getPrecio());
                    treeViewPedido.SelectedNode.Remove();
                    actualizarTxtTotal(num);
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show("No hay ningun item seleccionado", "Error");
            }
        }

        //Abre el form de observaciones
        private void bObservaciones_Click(object sender, EventArgs e)
        {
            Observaciones obs = new Observaciones();
            obs.ShowDialog();
        }

        //menu localizar pedidos
        //open a new form
        private void lOCALIZARPEDIDOSToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            LocalizadorEnvios le = new LocalizadorEnvios();
            le.ShowDialog();
        }

        //menu close
        //close the application
        private void iconoCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
        private void bRealizarPedido_Click(object sender, EventArgs e)
        {

            DetallesPedido dp = new DetallesPedido();
            MessageBox.Show(dp.ToString());
            
        }

        private void buscarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscarCliente bc = new BuscarCliente();
            bc.ShowDialog();
        }



        public void actualizarTxtTotal(double num)
        {
            if (num <= 0)
            {
                txtTotal.Text = "";
            }else
            {
               
                txtTotal.Text = num.ToString();
            }
        }
    }
}
