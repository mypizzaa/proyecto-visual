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

        public List<Pizza> listarPizzas()
        {
            List<Pizza> listaPizzas = new List<Pizza>();
         
            using (WebClient wc = new WebClient())
            {
                String json = wc.DownloadString("http://localhost:8080/ServicioMyPizza/servicios/WSProducto/pizzas");
                
                Encoding utf8 = Encoding.UTF8;
                listaPizzas = JsonConvert.DeserializeObject<List<Pizza>>(json);
               
                foreach (Pizza p in listaPizzas)
                {
                    Console.WriteLine(p.toString());
                }

            }
            return listaPizzas;
        }

        
        public List<Ingrediente> listarIngredientes()
        {
            List<Ingrediente> listaIngredientes = new List<Ingrediente>();
     
            using(WebClient wc = new WebClient())
            {
                String json = wc.DownloadString("http://localhost:8080/ServicioMyPizza/servicios/WSProducto/ingredientes");
                listaIngredientes = JsonConvert.DeserializeObject<List<Ingrediente>>(json);

            }
            return listaIngredientes;
        }


        public List<Refresco> listarRefrescos()
        {
            List<Refresco> listaBebidas = new List<Refresco>();

            using (WebClient wc = new WebClient())
            {
                String json = wc.DownloadString("http://localhost:8080/ServicioMyPizza/servicios/WSProducto/bebidas");
                listaBebidas = JsonConvert.DeserializeObject<List<Refresco>>(json);

            }
            return listaBebidas;
        }


        public Pizza listarUnaPizza(String nombrePizza)
        {
            List<Pizza> listaPizzas;

            Pizza pizza = null;

            using (WebClient wc = new WebClient())
            {
                String json = wc.DownloadString("http://localhost:8080/ServicioMyPizza/servicios/WSProducto/pizzas");
                listaPizzas = JsonConvert.DeserializeObject<List<Pizza>>(json);

                foreach (Pizza p in listaPizzas)
                {
                   if( p.getNombre() == nombrePizza) pizza = p;
                    
                }

            }
            return pizza;
        }


    }
}
