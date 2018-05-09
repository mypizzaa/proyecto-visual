using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class LoginDAO
    {

        private static DBConnection dataSource;
        
        public LoginDAO()
        {
            dataSource = DBConnection.getInstance();
        }

        /// <summary>
        /// Este metodo valida si el usuario introducido existe en la base de datos.
        /// </summary>
        /// <param name="correo">correo</param>
        /// <param name="password">password</param>
        /// <returns>Un usuario si existe si no develve null.</returns>
        public Usuario LoginUsuario(String correo, String password)
        {
            Usuario u = null;

            return u;
        }


        /// <summary>
        /// Este metodo añade un usuario en la base de datos
        /// </summary>
        /// <param name="u">Usuario</param>
        /// <returns>True si lo ha añadido o false si no.</returns>
        public Boolean addUsuario(Usuario u)
        {
            Boolean flag = false;


            return flag;
        }

        /// <summary>
        /// Este metodo modifica un usuario en la base de datos
        /// </summary>
        /// <param name="u">Usuario</param>
        /// <returns>True si lo ha eliminado o false si no.</returns>
        public Boolean modificarUsuario(Usuario u)
        {
            Boolean flag = false;

            return flag;    
        }


        /// <summary>
        /// Este metodo elimina el usuario de la base de datos
        /// </summary>
        /// <param name="u">Usuario</param>
        /// <returns>True si lo ha eliminado o false si no.</returns>
        public Boolean eliminarUsuario(Usuario u)
        {
            Boolean flag = false;



            return flag;
        }


    }
}
