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
    public class ControladorProductos
    {
        

        public ControladorProductos()
        {
             
        }

        public String listarPizzas()
        {
            String pizzas = "";
            
            return pizzas;
        }

        public List<Ingrediente> listarIngredientes()
        {
            List<Ingrediente> listaIngredientes = new List<Ingrediente>();
            Ingrediente i = null;
            using(WebClient wc = new WebClient())
            {
                String json = wc.DownloadString("http://localhost:8080/ServicioMyPizza/servicios/WSProducto/ingredientes");
                i = JsonConvert.DeserializeObject<Ingrediente>(json);
                listaIngredientes.Add(i);
                Console.WriteLine(listaIngredientes.ToString());

            }
            return listaIngredientes;
        }


    }
}
