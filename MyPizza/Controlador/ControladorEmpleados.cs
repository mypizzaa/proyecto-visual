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

        public ControladorEmpleados()
        {
            hreq = new HttpRequest();
        }

        public List<Empleado> listarEmpleados()
        {
            List<Empleado> listaEmpleados;

            try {

                String json = hreq.sendRequest("/ServicioMyPizza/servicios/WSEmpleado/listall");
                listaEmpleados = JsonConvert.DeserializeObject<List<Empleado>>(json);
            }
            catch (System.Net.WebException swe)
            {
                listaEmpleados = null;
            }
            return listaEmpleados;

        }

        public Empleado buscarEmpleado(String dni)
        {
            Empleado e;

            try
            {
                String json = hreq.sendRequest("/ServicioMyPizza/servicios/WSEmpleado/buscar/" + dni);
                e = JsonConvert.DeserializeObject<Empleado>(json);
            }
            catch (System.Net.WebException swe)
            {
                e = null;
            }
            
            return e;

        }

        public void darAltaEmpleado()
        {

        }

        public void darBajaEmpleado()
        {

        }

        public void modificarEmpleado()
        {

        }


    }
}
