using Modelo;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace Controlador
{
    public class ControladorPedidos
    {

        public ControladorPedidos()
        {
            
        } 

        public List<PedidoInfo> listarPedidos()
        {
            List<PedidoInfo> listaPedidosInfo = new List<PedidoInfo>();

            using (WebClient wc = new WebClient())
            {
                wc.Encoding = System.Text.Encoding.UTF8;
                String json = wc.DownloadString("http://localhost:8080/ServicioMyPizza/servicios/WSPedido/listall");
                listaPedidosInfo = JsonConvert.DeserializeObject<List<PedidoInfo>>(json);
                Console.WriteLine(json);
                foreach (PedidoInfo p in listaPedidosInfo)
                {
                    Console.WriteLine(p.toString());
                }
            }
            return listaPedidosInfo;

        }

        //public List<PedidoInfo> buscarPedido(String id)
        //{

        //    //PedidoInfo pi;

        //    //using (WebClient wc = new WebClient())
        //    //{
        //    //    wc.Encoding = System.Text.Encoding.UTF8;
        //    //    String json = wc.DownloadString("http://localhost:8080/ServicioMyPizza/servicios/WSPedido/buscar/"+id);
        //    //    pi = JsonConvert.DeserializeObject<PedidoInfo>(json);
                               
        //    //}

        //    //return pi;
        //}




    }
}
