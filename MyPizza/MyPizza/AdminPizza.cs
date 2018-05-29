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

        private List<CheckBox> listCheckbox;

        private Pizza p;
        private long idPizza;




        public AdminPizza()
        {
            cp = new ControladorProductos();
            listCheckbox = new List<CheckBox>();

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
            int x = 14;
            int y = 34;
            int x1 = 0;
          

            for (int i = 0; i < listaIngredientes.Count; i++)            
            {
                     
                CheckBox cb = new CheckBox();
                cb.Text = (listaIngredientes[i].getNombre().ToString());
                cb.Height= 21;
                cb.Width = 130;

                if (i % 4 == 0 && i != 0)
                {
                    y += 27;
                    j = 0;
                }

                x1 = x+(135*j);
                
                cb.Location = new Point(x1,y);
                //MessageBox.Show(listaIngredientes[i].getNombre().ToString());
                listCheckbox.Add(cb);
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
                //seleccionamos el nombre de la pizza
                ListViewItem listItem = ListViewPizzas.SelectedItems[0];
                String nombrepizza = listItem.Text;
                txtNombrePizza.Text = nombrepizza;

                //cogemos el precio de la pizza y lo mostramos
                p = cp.listarUnaPizza(nombrepizza);
                txtPrecio.Text = p.getPrecio().ToString();

                //llamamos al metodo marcarIngredientes para seleccionar los ingredientes que lleva la pizza
                idPizza = p.getIdPizza();
                List<Ingrediente> listaIngredientes = cp.listarIngredientesPizza(idPizza.ToString());
                marcarIngredientesPizza(listaIngredientes);
                
                //ponemos la imagen de la pizza
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

        private void bNueva_Click(object sender, EventArgs e)
        {
            bNueva.Visible = false;
            bAdd.Visible = true;
            txtNombrePizza.Text = "";
            txtPrecio.Text = "";
            
        }

        private void bAdd_Click(object sender, EventArgs e)
        {

        }



        /// <summary>
        /// Este metodo marca los checkbox con los ingredientes que contiene la pizza seleccionada
        /// </summary>
        /// <param name="listaIngredientes">Lista de ingredientes que tiene la pizza</param>
        private void marcarIngredientesPizza(List<Ingrediente> listaIngredientes)
        {
            
            foreach (CheckBox cb in listCheckbox)
             {
                foreach (Ingrediente i in listaIngredientes)
                {
                    if (i.getNombre().Equals(cb.Text))
                    {
                        cb.Checked = true;
                        cb.ForeColor = Color.Red;
                        break;
                    }else
                    {
                        cb.ForeColor = Color.Black;
                        cb.Checked = false;
                    }
                }

            }


        }




    }
}
