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
    public partial class AdminBebidas : Form
    {

        private ControladorProductos cp;
        private ControladorServicio cs;

        Boolean service;


        public AdminBebidas()
        {
            cp = new ControladorProductos();
            cs = new ControladorServicio();

            InitializeComponent();

            service = cs.getConnection();

            if (service != false)
            {
                cargarBebidas();

            }else
            {
                ErrorServicio es = new ErrorServicio();
                es.ShowDialog();
            }

        }

        /// <summary>
        /// This method load all drinks to the listViewBebidas
        /// </summary>
        public void cargarBebidas()
        {
            List<Refresco> listaBebidas = cp.listarRefrescos();

            foreach (Refresco r in listaBebidas)
            {
                listViewBebidas.Items.Add(r.getNombre());
            }
            
        }


        /// <summary>
        /// Este metodo abre un open file dialog para seleccionar una imagen y ponerla en le picture box
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
        /// This method save the select item from listview and put the name, image and price in the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void listViewBebidas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewBebidas.SelectedItems.Count > 0)
            {
                ListViewItem listItem = listViewBebidas.SelectedItems[0];
                String nombreBebida = listItem.Text;
                txtBebida.Text = nombreBebida;


                Producto p = await cp.listarUnProducto(nombreBebida);
                Refresco r = (Refresco)p;
                txtPrecio.Text = r.getPrecio().ToString();

                String pathImage = r.getImagen();
                pictureBox1.ImageLocation = "http://provenapps.cat/~dam1804/Images/bebidas/" + pathImage;

            }
        }



        private void bGuardar_Click(object sender, EventArgs e)
        {

        }


        private void bCancelar_Click(object sender, EventArgs e)
        {
            pictureBox1.Enabled = false;
            txtBebida.Enabled = false;
            txtPrecio.Enabled = false;
            bAñadirImagen.Visible = false;
        }

        /// <summary>
        /// This method put reset the form and put the button guardar visible and the buton nuevo not visible.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bNuevo_Click(object sender, EventArgs e)
        {
            bNuevo.Visible = false;
            bGuardar.Visible = true;

            txtBebida.Text = "";
            txtPrecio.Text = "";            
        }

        private void bModificar_Click(object sender, EventArgs e)
        {
            pictureBox1.Enabled = true;
            txtBebida.Enabled = true;
            txtPrecio.Enabled = true;
            bAñadirImagen.Visible = true;
        }
    }
    
}
