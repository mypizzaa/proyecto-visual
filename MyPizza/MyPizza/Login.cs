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

namespace Vista
{
    public partial class Login : Form
    {
                
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wsmg, int wparam, int lparam);


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

        private void bAcceder_Click(object sender, EventArgs e)
        {
            PanelAdmin pa = new PanelAdmin();
            pa.ShowDialog();
            //SelectorPizzas sp = new SelectorPizzas();
            //sp.ShowDialog();
        }
    }
}
