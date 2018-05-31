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
            foreach (Empleado e in lista)
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

        private async void listViewEmpleados_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listViewEmpleados.SelectedItems.Count > 0)
            {

                ListViewItem listItem = listViewEmpleados.SelectedItems[0];
                String dni = listItem.Text;
                txtDni.Text = dni;
                Empleado empleado = await ce.buscarEmpleado(dni);
                if (empleado != null)
                {
                    rellenarFomrularioEmpleado(empleado);
                }



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

        private void bModificar_Click(object sender, EventArgs e)
        {
            bModificar.Visible = false;
            bAdd.Visible = false;
            bBaja.Visible = false;
            txtNombre.Enabled = true;
            txtApellidos.Enabled = true;
            txtDni.Enabled = true;
            txtCorreo.Enabled = true;
            txtHorasSemanales.Enabled = true;
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            objetosporDefecto();
            
        }

        private async void bGuardar_ClickAsync(object sender, EventArgs e)
        {
            try { 
                Empleado emp = await ce.buscarEmpleado(txtDni.Text);
                Console.WriteLine(emp.toString());
                emp.setNombre(txtNombre.Text);
                emp.setApellidos(txtApellidos.Text);
                emp.setDni(txtDni.Text);
                emp.setCorreo(txtCorreo.Text);            
                emp.setHorasSemanales(Convert.ToInt16(txtHorasSemanales.Text));

                Boolean b= await ce.modificarEmpleadoAsync(emp);
                if (b)
                {
                    MessageBox.Show("Datos actualizados correctamente!");
                }
                else
                {
                    MessageBox.Show("No se han podido actualizar los datos!");
                }
            }catch(FormatException ex)
            {
                MessageBox.Show("Datos mal introducidos!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }catch(NullReferenceException ex)
            {
                MessageBox.Show("Ningun empleado seleccionado!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            objetosporDefecto();
            
        }

            private void bAdd_Click(object sender, EventArgs e)
        {

        }
        private void objetosporDefecto()
        {
            bModificar.Visible = true;
            bAdd.Visible = true;
            bBaja.Visible = true;
            txtNombre.Enabled = false;
            txtApellidos.Enabled = false;
            txtDni.Enabled = false;
            txtCorreo.Enabled = false;
            txtHorasSemanales.Enabled = false;
        }
    }
}
