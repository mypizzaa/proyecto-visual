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
    public partial class AdminEmpleados : Form
    {


        private ControladorEmpleados ce;
        

        public AdminEmpleados()
        {
            ce = new ControladorEmpleados();
            InitializeComponent();
            cargarListViewEmpleados();
        }

        private void cargarListViewEmpleados()
        {
            List<Empleado> lista = ce.listarEmpleados();
            foreach(Empleado e in lista)
            {
                listViewEmpleados.Items.Add(e.getDni());
            }

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

        private void listViewEmpleados_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listViewEmpleados.SelectedItems.Count > 0)
            {

                ListViewItem listItem = listViewEmpleados.SelectedItems[0];
                String dni = listItem.Text;

                Empleado empleado = ce.buscarEmpleado(dni);
                rellenarFomrularioEmpleado(empleado);
        
            }

        }

        public void rellenarFomrularioEmpleado(Empleado empleado)
        {
            txtNombre.Text = empleado.getNombre();
            txtApellidos.Text = empleado.getApellidos();
            txtDni.Text = empleado.getDni();
            txtCorreo.Text = empleado.getCorreo();
            txtHorasSemanales.Text = empleado.getHorasSemanales().ToString();
        }


    }
}
