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
        private String poblacion;
        private String codigoPostal;

        public Cliente(long id_usuario, string dni, string nombre, string apellidos, string password, string imagen, string tipo_Usuario, string correo,long id_cliente,string primeraDireccion, string segundaDireccion,String telefono,String poblacion, String codigoPostal) : base(id_usuario, dni, nombre, apellidos, password, imagen, tipo_Usuario, correo)
        {
            this.id_cliente = id_cliente;
            this.primeraDireccion = primeraDireccion;
            this.segundaDireccion = segundaDireccion;
            this.telefono = telefono;
            this.poblacion = poblacion;
            this.codigoPostal = codigoPostal;
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

        public String getPoblacion()
        {
            return this.poblacion;
        }

        public String getCodigoPostal()
        {
            return this.codigoPostal;
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

        public void setPoblacion(String poblacion)
        {
            this.poblacion = poblacion;
        }

        public void setCodigoPostal(String codigop)
        {
            this.codigoPostal = codigop;
        }


        //toString
        public String toString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("id_cliente = " + id_cliente);
            sb.Append(" ,primeraDireccion =  " + primeraDireccion);
            sb.Append(" ,segundaDireccion = " + segundaDireccion);
            sb.Append(" ,telefono = " + telefono);
            sb.Append(" ,poblacion = " + poblacion);
            sb.Append(" ,codigo postal = "+codigoPostal);
            sb.Append(base.ToString());

            return sb.ToString();
        }


    }
}
