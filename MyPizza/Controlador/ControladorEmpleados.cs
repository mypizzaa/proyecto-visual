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
        private String servidor;

        public ControladorEmpleados()
        {
            servidor = "http://localhost:8080";
        }

        public List<Empleado> listarEmpleados()
        {
            List<Empleado> listaEmpleados;

            using (WebClient wc = new WebClient())
            {
                wc.Encoding = System.Text.Encoding.UTF8;
                String json = wc.DownloadString(servidor+"/ServicioMyPizza/servicios/WSEmpleado/listall");

                listaEmpleados = JsonConvert.DeserializeObject<List<Empleado>>(json);

            }
            return listaEmpleados;

        }

        public Empleado buscarEmpleado(String dni)
        {
            Empleado e;

            using (WebClient wc = new WebClient())
            {
                wc.Encoding = System.Text.Encoding.UTF8;
                String json = wc.DownloadString(servidor + "/ServicioMyPizza/servicios/WSEmpleado/buscar/" +dni);

                e = JsonConvert.DeserializeObject<Empleado>(json);

            }
            return e;

        }




    }
}
