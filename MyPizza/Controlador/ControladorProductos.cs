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

        private String servidor;

        public ControladorProductos()
        {
             servidor = "http://localhost:8080";
        }

        // Lista todas las pizzas 
        // return null si no hay o si falla el servicio sino devuelve una lista de pizzas
        public List<Pizza> listarPizzas()
        {
            List<Pizza> listaPizzas;

            try
            {
                using (WebClient wc = new WebClient())
                {
                    wc.Encoding = System.Text.Encoding.UTF8;
                    String json = wc.DownloadString(servidor+"/ServicioMyPizza/servicios/WSProducto/pizzas");
                    
                    listaPizzas = JsonConvert.DeserializeObject<List<Pizza>>(json);

                }
            }
            catch (System.Net.WebException swe)
            {
                listaPizzas = null;
            }
          

            return listaPizzas;
        }
         
        //Lista todos los ingredientes
        //return null si no hay o si falla el servicio sino devuelve una lista de ingredientes       
        public List<Ingrediente> listarIngredientes()
        {

            List<Ingrediente> listaIngredientes;

            try
            {

                using (WebClient wc = new WebClient())
                {
                    wc.Encoding = System.Text.Encoding.UTF8;
                    String json = wc.DownloadString("http://localhost:8080/ServicioMyPizza/servicios/WSProducto/ingredientes");

                    listaIngredientes = JsonConvert.DeserializeObject<List<Ingrediente>>(json);
                    Console.WriteLine(listaIngredientes.Count);
                }

            }
            catch (System.Net.WebException swe)
            {
                listaIngredientes = null;
            }
           
            return listaIngredientes;
        }
        
        //Lista todas las bebidas
        //return null si no hay o si falla el servicio sino devuelve una lista de refrescos
        public List<Refresco> listarRefrescos()
        {
            List<Refresco> listaBebidas;

            using (WebClient wc = new WebClient())
            {
                wc.Encoding = System.Text.Encoding.UTF8;
                String json = wc.DownloadString("http://localhost:8080/ServicioMyPizza/servicios/WSProducto/bebidas");
                listaBebidas = JsonConvert.DeserializeObject<List<Refresco>>(json);

            }
            return listaBebidas;
        }
        
        //Se envia por parametro el nombre de la pizza y nos muestra esa pizza
        //Si no existe devuelve null si existe devuelve la pizza
        public Pizza listarUnaPizza(String nombrePizza)
        {
            List<Pizza> listaPizzas;
            Pizza pizza = null;

            try
            {
                

                using (WebClient wc = new WebClient())
                {
                    wc.Encoding = System.Text.Encoding.UTF8;
                    String json = wc.DownloadString("http://localhost:8080/ServicioMyPizza/servicios/WSProducto/pizzas");
                    listaPizzas = JsonConvert.DeserializeObject<List<Pizza>>(json);

                    foreach (Pizza p in listaPizzas)
                    {
                        if (p.getNombre() == nombrePizza) pizza = p;

                    }

                }
            }
            catch (System.Net.WebException swe)
            {
                pizza = null;
            }
            return pizza;
        }

        public Refresco listarUnRefresco(String nombreRefresco)
        {
            Refresco r = null;
            List<Refresco> listaBebidas;

            using (WebClient wc = new WebClient())
            {
                wc.Encoding = System.Text.Encoding.UTF8;
                String json = wc.DownloadString("http://localhost:8080/ServicioMyPizza/servicios/WSProducto/bebidas");
                listaBebidas = JsonConvert.DeserializeObject<List<Refresco>>(json);

                foreach (Refresco refresco in listaBebidas)
                {
                    if (refresco.getNombre() == nombreRefresco) r = refresco;

                }

            }
            return r;
        }

        public List<Ingrediente> listarIngredientesPizza(String idPizza)
        {
            List<Ingrediente> listaIngredientes;

           
            using (WebClient wc = new WebClient())
            {
                wc.Encoding = System.Text.Encoding.UTF8;
                String json = wc.DownloadString("http://localhost:8080/ServicioMyPizza/servicios/WSProducto/ingredientespizza/"+idPizza);
                listaIngredientes = JsonConvert.DeserializeObject<List<Ingrediente>>(json);

            }

            return listaIngredientes;
        }

       

    }
}
