﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Usuario
    {
        private long id_usuario;
        private String dni;
        private String nombre;
        private String apellidos;
        private String password;
        private String imagen;
        private String tipo_Usuario;
        private String correo;

        //Constructor
        public Usuario(long id_usuario, String dni, String nombre, String apellidos, String password, String imagen, String tipo_Usuario, String correo)
        {
            this.id_usuario = id_usuario;
            this.dni = dni;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.password = password;
            this.imagen = imagen;
            this.tipo_Usuario = tipo_Usuario;
            this.correo = correo;
        }

        public Usuario(string correo, string password)
        {
            this.correo = correo;
            this.password = password;
        }

        public Usuario() { }

        //Getters
        public long getIdUsuario()
        {
            return this.id_usuario;
        }

        public String getDni()
        {
            return this.dni;
        }

        public String getNombre()
        {
            return this.nombre;
        }

        public String getApellidos()
        {
            return this.apellidos;
        }

        public String getPassword()
        {
            return this.password;
        }

        public String getImagen()
        {
            return this.imagen;
        }

        public String getTipoUsuario()
        {
            return this.tipo_Usuario;
        }

        public String getCorreo()
        {
            return this.correo;
        }


        //Setters
        public void setIdUsuario(long idUsuario)
        {
            this.id_usuario = idUsuario;
        }

        public void setDni(String dni)
        {
            this.dni = dni;
        }

        public void setNombre(String nombre)
        {
            this.nombre = nombre;
        }

        public  void setApellidos(String apellidos)
        {
            this.apellidos = apellidos;
        }

        public void setPassword(String password)
        {
            this.password = password;
        }

        public void setImagen(String imagen)
        {
            this.imagen = imagen;
        }

        public void setTipoUsiario(String tipo)
        {
            this.tipo_Usuario = tipo;
        }

        public void setCorreo(String correo)
        {
            this.correo = correo;
        }

        //toString
        public String toString()
        {

            StringBuilder sb = new StringBuilder();
            sb.Append("Usuario [");
            sb.Append(" id_usuario = " + id_usuario);
            sb.Append(", dni = " + dni);
            sb.Append(", nombre = " + nombre);
            sb.Append(", apellidos = " + apellidos);
            sb.Append(", password = " + password);
            sb.Append(", imagen = " + imagen);
            sb.Append(", tipo_Usuario = " + tipo_Usuario);
            sb.Append(", correo = " + correo);
            sb.Append(" ]");
            
            return sb.ToString();
        }


    }
}
