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

namespace Vista
{
    public partial class AdminPizza : Form
    {

        private ControladorProductos cp;

        public AdminPizza()
        {
            cp = new ControladorProductos();
            InitializeComponent();
            cargarListViewPizzas();
            cargarCheckBoxesIngredientes();
        }

        private void cargarListViewPizzas()
        {

            

           

        }

        private void cargarCheckBoxesIngredientes()
        {
            List<Ingrediente> listaIngredientes = cp.listarIngredientes();

            foreach (Ingrediente i in listaIngredientes)
            {
                //groupBoxIngredientes.Crea
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



    }
}
