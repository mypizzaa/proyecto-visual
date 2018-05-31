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

        public void limpiarListas()
        {
            this.listaParam.Clear();
            this.listaValues.Clear();
        }

        /// <summary>
        /// This method add a new params to search at the webService
        /// is received a json about the sentence that we send, and this is converted in a new Client
        /// if user not exist return null, if exist return a Clien
        /// </summary>
        /// <param name="telefono"></param>
        /// <returns></returns>
        public async Task<Cliente> buscarCliente(String telefono)
        {
            Cliente c = null;
            try
            {
                limpiarListas();
                listaParam.Add("phone");
                listaValues.Add(telefono);

                String json = await hreq.sendRequestPOST("/ServicioMyPizza/servicios/WSCliente/searchphone", listaParam, listaValues);
                c = JsonConvert.DeserializeObject<Cliente>(json);

            }
            catch (System.Net.WebException swe)
            {
                c = null;
                Console.WriteLine(swe.Message);
            }
            return c;
        }

    }
}