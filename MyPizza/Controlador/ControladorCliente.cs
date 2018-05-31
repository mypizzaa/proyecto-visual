using Modelo;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class ControladorCliente
    {
        private List<String> listaParam = new List<String>();
        private List<String> listaValues = new List<String>();

        private HttpRequest hreq;

        public ControladorCliente()
        {
           hreq = new HttpRequest();
        }

        /*
         * clear the list param and list values
         */
        public void limpiarListas()
        {
            this.listaParam.Clear();
            this.listaValues.Clear();
        }

        /*
         * This method search a client by phone
         * @param telefono
         * return client if found or null if not
         */
        public async Task<Cliente> buscarCliente(String telefono)
        {
            Cliente c = null;
             
            try
            {
                limpiarListas();
                listaParam.Add("phone");
                listaValues.Add(telefono);
                
                String json = await hreq.sendRequestPOST("/ServicioMyPizza/servicios/WSCliente/searchphone", listaParam, listaValues);
                Console.WriteLine("+++++++++"+json);
                c = JsonConvert.DeserializeObject<Cliente>(json);

            }
            catch (System.Net.WebException swe)
            {
                c = null;
               
            }
        

            return c;
        }

    }
}
