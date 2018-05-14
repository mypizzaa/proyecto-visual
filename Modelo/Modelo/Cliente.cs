using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Cliente : Usuario
    {
        private long id_cliente;
        private String primeraDireccion;
        private String segundaDireccion;

        public Cliente(long id_usuario, string dni, string nombre, string apellidos, string password, string imagen, string tipo_Usuario, string correo,long id_cliente,string primeraDireccion, string segundaDireccion) : base(id_usuario, dni, nombre, apellidos, password, imagen, tipo_Usuario, correo)
        {
            this.id_cliente = id_cliente;
            this.primeraDireccion = primeraDireccion;
            this.segundaDireccion = segundaDireccion; 
        }

        //getters
        public long getIdCliente()
        {
            return this.id_cliente;
        }

        public String getPrimeraDireccion()
        {
            return this.primeraDireccion;
        }

        public String getSegundaDireccion()
        {
            return this.segundaDireccion;
        }

        //setters
        public void setIdCliente(long idcliente)
        {
            this.id_cliente = idcliente;
        }

        public void setPrimeraDireccion(String direccion)
        {
            this.primeraDireccion = direccion;
        }

        public void setSegundaDireccion(String direccion)
        {
            this.segundaDireccion = direccion;
        }

        //toString
        public String toString()
        {
            return "";
        }


    }
}
