using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Net;

using System.ServiceModel;
using Modelo;
using Newtonsoft.Json;
using System.Net.Http;
using Controlador;

namespace Vista
{
    public partial class Login : Form
    {
                
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wsmg, int wparam, int lparam);

        private Controlador.ControladorProductos controllerProd;

        public Login()
        {
             InitializeComponent();
           
        }
                

        private void button1_Click(object sender, EventArgs e)
        {
            PanelAdmin ap = new PanelAdmin();
            ap.ShowDialog();

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
                
        private void txtCorreo_Enter(object sender, EventArgs e)
        {
            if(txtCorreo.Text == "Usuario")
            {
                txtCorreo.Text = "";
            }
        }

        private void txtCorreo_Leave(object sender, EventArgs e)
        {
            if (txtCorreo.Text == "")
            {
                txtCorreo.Text = "Usuario";
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if(txtPassword.Text == "Contraseña"){
                txtPassword.Text = "";
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Contraseña";
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //Boton para salir de la aplicación
        private void bSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Boton para logearse
        private async void bAcceder_Click(object sender, EventArgs e)
        {
            String correo = txtCorreo.Text;
            String password = txtPassword.Text;

            if (correo != null && password != null)
            {

                ControladorLogin cl = new ControladorLogin();
                Usuario u = await cl.login(correo, password);

                if(u != null)
                {
                    saberRolUsuario(u);
                }else
                {
                    MessageBox.Show("Error, usuario incorrecto");
                }

            }

        }

        
        public void saberRolUsuario(Usuario u)
        {
            String tipo = u.getTipoUsuario();
            switch (tipo)
            {
                case "admin":
                    PanelAdmin pa = new PanelAdmin();
                    pa.ShowDialog();

                    break;

                case "empleado":
                    SelectorPizzas sp = new SelectorPizzas();
                    sp.ShowDialog();

                    break;
                case "cliente":
                    break;
            }
        }



    }
}
