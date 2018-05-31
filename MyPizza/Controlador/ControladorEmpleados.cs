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
         * Receive as a parameter an ID of an employee
         * the list of values ​​to be passed through the post method is cleaned and the new values ​​are assigned
         * Through the request we received a json that we later transformed into an employee
         * If the json does not give an error, it will return an employee, if it does not return a null
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

                    e = JsonConvert.DeserializeObject<Empleado>(json);
                }

            }
            catch (System.Net.WebException swe)
            {
                e = null;
            }
            return e;
        }

        /**
         * This method drops an employee
         */
        public void darBajaEmpleado()
        {
            //TO DO
        }

        /**
        * Receive an employee and assign the parameters for the post method with your requests
        * if it returns a 2, it is that the changes have gone well, if it is different that the pet is not well
         */
        public async Task<Boolean> modificarEmpleadoAsync(Empleado emp)
        {
            Boolean b = false;
            try
            {
                limpiarListas();
                this.listaParam.Add("id"); this.listaValues.Add(emp.getIdEmpleado().ToString());

                String horaEntrada = emp.getHoraEntrada().ToString();
                String[] substrings = horaEntrada.Split(' ');

                this.listaParam.Add("in_hour"); this.listaValues.Add(substrings[1]);

                String horaSalida = emp.getHoraEntrada().ToString();
                String[] substrings2 = horaSalida.Split(' ');


                this.listaParam.Add("out_hour"); this.listaValues.Add(substrings2[1]);
                this.listaParam.Add("week_hours"); this.listaValues.Add(emp.getHorasSemanales().ToString());
                this.listaParam.Add("salary"); this.listaValues.Add(emp.getSalario().ToString());
                this.listaParam.Add("dni"); this.listaValues.Add(emp.getDni());
                this.listaParam.Add("name"); this.listaValues.Add(emp.getNombre());
                this.listaParam.Add("surname"); this.listaValues.Add(emp.getApellidos());
                this.listaParam.Add("password"); this.listaValues.Add(emp.getPassword());
                this.listaParam.Add("image"); this.listaValues.Add(emp.getImagen());
                this.listaParam.Add("type_user"); this.listaValues.Add(emp.getTipoUsuario());
                this.listaParam.Add("email"); this.listaValues.Add(emp.getCorreo());


                var json = await hreq.sendRequestPOST("/ServicioMyPizza/servicios/WSEmpleado/update/", this.listaParam, this.listaValues);
                if (json.ToString().Equals("2"))
                {
                    b = true;
                }
            }
            catch (System.Net.WebException swe)
            {
                b = false;
            }
            return b;
        }


    }
}