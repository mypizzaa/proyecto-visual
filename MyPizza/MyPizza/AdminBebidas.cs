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


        public AdminBebidas()
        {
            cp = new ControladorProductos();
            InitializeComponent();
            cargarBebidas();
        }


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

        private void listViewBebidas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewBebidas.SelectedItems.Count > 0)
            {
                ListViewItem listItem = listViewBebidas.SelectedItems[0];
                String nombreBebida = listItem.Text;
                txtBebida.Text = nombreBebida;

                Refresco r = cp.listarUnRefresco(nombreBebida);
                txtPrecio.Text = r.getPrecio().ToString();

                String pathImage = r.getImagen();
                pictureBox1.ImageLocation = "http://provenapps.cat/~dam1804/Images/bebidas/" + pathImage;


            }
        }
    }
    
}
