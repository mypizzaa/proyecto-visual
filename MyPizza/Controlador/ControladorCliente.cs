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

        public async Task<Cliente> buscarCliente(String telefono)
        {
            Cliente c = null;
            Console.WriteLine("hooooooooooooooooooooooooooooooola");   
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
                Console.WriteLine(swe.Message);
            }
        

            return c;
        }





    }
}
