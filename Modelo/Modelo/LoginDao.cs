using MySql.Data.MySqlClient;
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
        /// <returns>Devuelve un usuario si existe y si no develve null.</returns>
        public Usuario LoginUsuario(Usuario usuario)
        {
            Usuario u = null;
            
            MySqlConnection connection = null;
            MySqlCommand mysqlCmd = null;
            MySqlDataReader mysqlReader = null;

            string sql = "SELECT tipo_usuario FROM tb_usuario where correo=@correo and password=@Pwd;";
            try
            {
                connection = dataSource.getConnection();
                connection.Open();

                mysqlCmd = new MySqlCommand(sql, connection);
                mysqlCmd.Parameters.Add(new MySqlParameter("@correo", usuario.getCorreo()));
                mysqlCmd.Parameters.Add(new MySqlParameter("@Pwd", usuario.getPassword()));


                mysqlReader = mysqlCmd.ExecuteReader();
                String tipo_usuario = null;
                while (mysqlReader.Read())
                {
                    tipo_usuario = mysqlReader.GetString("tipo_usuario");
                }
                u.setTipoUsiario(tipo_usuario);
            }
            catch (Exception e)
            {
                u = null;
            }
            finally
            {
                if (mysqlCmd != null) mysqlCmd.Dispose();
                if (mysqlReader != null) mysqlReader.Dispose();
                if (connection != null) connection.Close();
            }

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
