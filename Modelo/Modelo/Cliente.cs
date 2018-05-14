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
        private String telefono;

        public Cliente(long id_usuario, string dni, string nombre, string apellidos, string password, string imagen, string tipo_Usuario, string correo,long id_cliente,string primeraDireccion, string segundaDireccion,String telefono) : base(id_usuario, dni, nombre, apellidos, password, imagen, tipo_Usuario, correo)
        {
            this.id_cliente = id_cliente;
            this.primeraDireccion = primeraDireccion;
            this.segundaDireccion = segundaDireccion;
            this.telefono = telefono; 
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
        public String getTelefono()
        {
            return this.telefono;
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

        public void setTelefono(String telefono)
        {
            this.telefono = telefono;
        }

        //toString
        public String toString()
        {
            return "";
        }


    }
}
