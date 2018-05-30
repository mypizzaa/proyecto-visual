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
        private ControladorLogin cl;        

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wsmg, int wparam, int lparam);

        public Login()
        {
            cl = new ControladorLogin();              
            InitializeComponent();           
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


        /// <summary>
        /// Button to exit application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //button to access
        private async void bAcceder_Click(object sender, EventArgs e)
        {

            String correo = txtCorreo.Text;
            String password = txtPassword.Text;

            if (correo != null && password != null)
            {
                try
                {
                    Token tk = await cl.login(correo, password);

                    if (tk != null)
                    {
                        String token = tk.getToken();
                        saberRolUsuario(tk.getUsuario());
                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña incorrectos.", "Error al iniciar sesion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                catch (System.Net.Http.HttpRequestException hre)
                {
                    ErrorServicio es = new ErrorServicio();
                    es.ShowDialog();
                }

            }
            else
            {
                MessageBox.Show("Inserte un usuario y una contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        /// <summary>
        /// This method opens a form depending on the type of user that is
        /// </summary>
        /// <param name="u"></param>
        public void saberRolUsuario(Usuario u)
        {
            String tipo = u.getTipoUsuario();
            switch (tipo)
            {
                case "admin":
                    PanelAdmin pa = new PanelAdmin();
                    pa.ShowDialog();
                    this.Close();

                    break;

                case "empleado":
                    SelectorPizzas sp = new SelectorPizzas();
                    sp.ShowDialog();
                    this.Close();

                    break;
                case "cliente":
                    break;
            }
        }



    }
}
