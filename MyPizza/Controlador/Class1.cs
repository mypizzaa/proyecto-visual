using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace Controlador
{
    public class ControladorLogin
    {

        LoginDAO modelo;
        List<Usuario> listaUsuarios = new List<Usuario>();

        public ControladorLogin()
        {
            this.modelo = new LoginDAO();
        }

       

    }
}
