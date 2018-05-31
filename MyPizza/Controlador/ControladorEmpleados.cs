using Modelo;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class ControladorEmpleados
    {
        private HttpRequest hreq;
        private List<String> listaParam = new List<String>();
        private List<String> listaValues = new List<String>();

        public ControladorEmpleados()
        {
            hreq = new HttpRequest();
        }

        /**
         * Clean the list of Strings that is passed by parameters to the post methods.
         */
        public void limpiarListas()
        {
            this.listaParam.Clear();
            this.listaValues.Clear();
        }

        /**
         * Pick up a json through a request to list all orders
         * transform the json into a new list of employees, if the company has employees with employees, otherwise it will be null
         */
        public List<Empleado> listarEmpleados()
        {
            List<Empleado> listaEmpleados;
            try
            {
                String json = hreq.sendRequest("/ServicioMyPizza/servicios/WSEmpleado/listall");
                listaEmpleados = JsonConvert.DeserializeObject<List<Empleado>>(json);
            }
            catch (System.Net.WebException swe)
            {
                listaEmpleados = null;
            }
            return listaEmpleados;

        }

        /**
         * Recibe como parametro un dni de un empleado
         * se limpian las listas de valores a pasar por metodo post y se le asignan los nuevos valores
         * a traves de la peticion recibimos un json que despues lo transformamos en un empleado
         * si el json no da error nos devuelve un empleado, si no nos devolvera un null
         */ 
        public async Task<Empleado> buscarEmpleado(String dni)
        {
            Empleado e = null;
            try
            {
                limpiarListas();
                this.listaParam.Add("dni");
                this.listaValues.Add(dni);

                var json = await hreq.sendRequestPOST("/ServicioMyPizza/servicios/WSEmpleado/search/", listaParam, listaValues);

                Console.WriteLine("+++++++++++++++++++++++++" + json);
                e = JsonConvert.DeserializeObject<Empleado>(json);
            }
            catch (System.Net.WebException swe)
            {
                e = null;
            }

            return e;

        }

        /**
         *
         */ 
        public async Task<Empleado> darAltaEmpleado(String dni)
        {
            Empleado e = null;
            try
            {
                e = await buscarEmpleado(dni);
                if (e == null)
                {
                    limpiarListas();
                    this.listaParam.Add("dni");
                    this.listaValues.Add(dni);

                    var json = await hreq.sendRequestPOST("/ServicioMyPizza/servicios/WSEmpleado/search/", listaParam, listaValues);

                    Console.WriteLine("+++++++++++++++++++++++++" + json);
                    e = JsonConvert.DeserializeObject<Empleado>(json);
                }

            }
            catch (System.Net.WebException swe)
            {
                e = null;
            }
            return e;
        }

        public void darBajaEmpleado()
        {

        }

        /**
         * 
         * 
         */ 
        public async Task<Boolean> modificarEmpleadoAsync(Empleado emp)
        {
            Boolean b = false;
            try
            {
                limpiarListas();
                this.listaParam.Add("id");    this.listaValues.Add(emp.getIdEmpleado().ToString());

                String horaEntrada = emp.getHoraEntrada().ToString();
                String[] substrings = horaEntrada.Split(' ');
                Console.WriteLine("Hora entrada: " + substrings[1]);

                this.listaParam.Add("in_hour");  this.listaValues.Add(substrings[1]);

                String horaSalida = emp.getHoraEntrada().ToString();
                String[] substrings2 = horaSalida.Split(' ');
                Console.WriteLine("Hora entrada: " + substrings2[1]);

                this.listaParam.Add("out_hour");  this.listaValues.Add(substrings2[1]);
                this.listaParam.Add("week_hours");  this.listaValues.Add(emp.getHorasSemanales().ToString());
                this.listaParam.Add("salary");  this.listaValues.Add(emp.getSalario().ToString());
                this.listaParam.Add("dni");  this.listaValues.Add(emp.getDni());
                this.listaParam.Add("name");  this.listaValues.Add(emp.getNombre());
                this.listaParam.Add("surname");   this.listaValues.Add(emp.getApellidos());
                this.listaParam.Add("password");  this.listaValues.Add(emp.getPassword());
                this.listaParam.Add("image");  this.listaValues.Add(emp.getImagen());
                this.listaParam.Add("type_user");   this.listaValues.Add(emp.getTipoUsuario());
                this.listaParam.Add("email");   this.listaValues.Add(emp.getCorreo());

                
               var json = await hreq.sendRequestPOST("/ServicioMyPizza/servicios/WSEmpleado/update/", this.listaParam, this.listaValues);
                Console.WriteLine("Json: "+json.ToString());
                b = true;
            }
            catch (System.Net.WebException swe)
            {
                b = false;
            }
            return b;
        }


    }
}
