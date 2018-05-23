using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;
using Newtonsoft.Json;
using Controlador;
using System.Net;

namespace Vista
{
    public partial class AdminPizza : Form
    {

        private ControladorProductos cp;

        private int x = 14;
        private int y = 34;


        public AdminPizza()
        {
            cp = new ControladorProductos();
            InitializeComponent();
            cargarListViewPizzas();
            cargarCheckBoxesIngredientes();
        }

        private void cargarListViewPizzas()
        {

            List<Pizza> listaPizzas = cp.listarPizzas();

            foreach(Pizza p in listaPizzas)
            {
                ListViewPizzas.Items.Add(p.getNombre());
            }

        }

        /// <summary>
        /// Este metodo carga de la base de datos todos los ingredientes y genera dinamicamente 
        /// los checkbox correspondientes con su informacion.
        /// </summary>
        private void cargarCheckBoxesIngredientes()
        {
            
            List<Ingrediente> listaIngredientes = cp.listarIngredientes();
            int j = 0;

            for (int i = 0; i < listaIngredientes.Count; i++)            
            {
                             
                CheckBox cb = new CheckBox();
                cb.Text = (listaIngredientes[i].getNombre().ToString());
                cb.Height= 21;
                cb.Width = 120;

                if (i % 5 == 0 && i != 0)
                {
                    y += 27;
                    x = 14;
                    j = 0;
                }

                x += (135*j);
                
                cb.Location = new Point(x,y);
                //MessageBox.Show("x:"+x+", y:"+y);

                groupBoxIngredientes.Controls.Add(cb);
                j++;
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void AdminPizza_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Metodo que abre un open file dialog para seleccionar una imagen y ponerla en el picture box
        /// Por defecto abre el open file dialog en C:// y solamente deja seleccionar ficheros png o jpg
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bAñadirImagen_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "C:\\";
            openFileDialog1.Filter = "png(*.png)|*.png|jpg(*.jpg)|*.jpg";
            openFileDialog1.FileName = "";

            //Abre el openfile y comprueba que se ha cerrado.
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        /// <summary>
        /// Este metodo cuando se selecciona un item de la lista de pizzas pone el nombre
        /// en el text box correspondiente y el precio y todos los ingredientes que pertocan a cada pizza
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListViewPizzas_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (ListViewPizzas.SelectedItems.Count > 0)
            {
                ListViewItem listItem = ListViewPizzas.SelectedItems[0];
                String nombrepizza = listItem.Text;
                txtNombrePizza.Text = nombrepizza;

                Pizza p = cp.listarUnaPizza(nombrepizza);
                txtPrecio.Text = p.getPrecio().ToString();

                String pathImage = p.getImagen();
                pictureBox1.ImageLocation = "http://provenapps.cat/~dam1804/Images/pizzas/" + pathImage;
             
               
            }

        }

        //boton modificar
        private void bModificar_Click(object sender, EventArgs e)
        {
            txtNombrePizza.Enabled = true;
            txtPrecio.Enabled = true;
            bAñadirImagen.Enabled = true;
            bAñadirImagen.Visible = true;
            groupBoxIngredientes.Enabled = true;
        }
        
      

    }
}
