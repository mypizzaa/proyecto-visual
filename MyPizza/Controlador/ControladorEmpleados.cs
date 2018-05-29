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
        public ControladorEmpleados()
        {

        }

        public List<Empleado> listarEmpleados()
        {
            List<Empleado> listaEmpleados;

            using (WebClient wc = new WebClient())
            {
                wc.Encoding = System.Text.Encoding.UTF8;
                String json = wc.DownloadString("http://localhost:8080/ServicioMyPizza/servicios/WSEmpleado/listall");

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
                String json = wc.DownloadString("http://localhost:8080/ServicioMyPizza/servicios/WSEmpleado/buscar/"+dni);

                e = JsonConvert.DeserializeObject<Empleado>(json);

            }
            return e;

        }




    }
}
