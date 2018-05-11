using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Cliente : Usuario
    {

        public Cliente(long id_usuario, string dni, string nombre, string apellidos, string password, string imagen, string tipo_Usuario, string correo) : base(id_usuario, dni, nombre, apellidos, password, imagen, tipo_Usuario, correo)
        {
            
        }
    }
}
