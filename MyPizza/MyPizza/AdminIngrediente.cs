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
    public partial class AdminIngrediente : Form
    {

        private ControladorProductos cp;
        private ControladorServicio cs;

        Boolean service;

        public AdminIngrediente()
        {
            cp = new ControladorProductos();
            cs = new ControladorServicio();

            InitializeComponent();

            service = cs.getConnection();

            if (service != false)
            {
                loadIngredientes();

            }
            else
            {
                ErrorServicio es = new ErrorServicio();
                es.ShowDialog();
            }
        }

        /// <summary>
        /// This method load all ingredients in listview 
        /// </summary>
        private void loadIngredientes()
        {
            List<Ingrediente> listaIngredientes = cp.listarIngredientes();

            foreach (Ingrediente i in listaIngredientes)
            {
                listViewIngredientes.Items.Add(i.getNombre());
            }
        }

        private void bModificar_Click(object sender, EventArgs e)
        {
            
        }

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

        private async void listViewIngredientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewIngredientes.SelectedItems.Count > 0)
            {
                ListViewItem listItem = listViewIngredientes.SelectedItems[0];
                String nombreIngrediente = listItem.Text;
                txtIngrediente.Text = nombreIngrediente;

                Producto p = await cp.listarUnProducto(nombreIngrediente);
                Ingrediente i = (Ingrediente) p;

                txtPrecio.Text = i.getPrecio().ToString();

                String pathImage = i.getImagen();
                pictureBox1.ImageLocation = "http://provenapps.cat/~dam1804/Images/bebidas/" + pathImage;

            }
        }
    }
}
