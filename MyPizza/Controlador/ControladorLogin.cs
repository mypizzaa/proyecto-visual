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


        public String[] loginUser(string nusername, string password)
        {

            Usuario result = modelo.obtenirUsuari(new User(nusername, password));
            String[] msg = new String[2];
            if (result == null)
            {
                msg[0] = "1";
                msg[1] = "Atention!!!Error with the database!";

            }
            else
            {
                String rol = result.Rol;
                if (rol != null && rol.Length > 0)
                {

                    if (rol.Equals("administrador") || rol.Equals("direccio"))
                    {
                        msg[0] = "2";
                        msg[1] = "Welcome " + result.Usr + "\n\nSECTION TO DO.";

                    }
                    else if (rol.Equals("personalsanitari") || rol.Equals("administratiu"))
                    {
                        msg[0] = "3";
                        msg[1] = rol;
                    }


                }
                else
                {
                    msg[0] = "4";
                    msg[1] = "User or password are incorrects.\n Try again!";

                }
            }
            return msg;
        }


    }
}
