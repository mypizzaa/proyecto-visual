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

        private HttpRequest hreq;

        public ControladorProductos()
        {
           hreq = new HttpRequest();
        }
         

        // this method call the service method listall and list all pizzas
        // return null if not found else return list of pizzas
        public List<Pizza> listarPizzas()
        {
            List<Pizza> listaPizzas = null;

                try
                {
                    var json = hreq.sendRequest("/ServicioMyPizza/servicios/WSProducto/pizzas");                         
                    listaPizzas = JsonConvert.DeserializeObject<List<Pizza>>(json);
                                        
                }
                catch (System.Net.WebException swe)
                {
                    listaPizzas = null;
                }
            
            return listaPizzas;
        }

        //this method call the service method listall and lista all ingredients
        //return null if not found else return list of ingredients      
        public List<Ingrediente> listarIngredientes()
        {

            List<Ingrediente> listaIngredientes;

            try
            {

                String json = hreq.sendRequest("/ServicioMyPizza/servicios/WSProducto/ingredientes");
                listaIngredientes = JsonConvert.DeserializeObject<List<Ingrediente>>(json);
         
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

            try
            {
                String json = hreq.sendRequest("/ServicioMyPizza/servicios/WSProducto/bebidas");
                listaBebidas = JsonConvert.DeserializeObject<List<Refresco>>(json);
            }
            catch (System.Net.WebException swe)
            {
                listaBebidas = null;
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
                
                
                    String json = hreq.sendRequest("/ServicioMyPizza/servicios/WSProducto/pizzas");
                    listaPizzas = JsonConvert.DeserializeObject<List<Pizza>>(json);

                    foreach (Pizza p in listaPizzas)
                    {
                        if (p.getNombre() == nombrePizza) pizza = p;

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

            try
            {
                String json = hreq.sendRequest("/ServicioMyPizza/servicios/WSProducto/bebidas");
                listaBebidas = JsonConvert.DeserializeObject<List<Refresco>>(json);

                foreach (Refresco refresco in listaBebidas)
                {
                    if (refresco.getNombre() == nombreRefresco) r = refresco;

                }
            }
            catch (System.Net.WebException swe)
            {
                r = null;
            }
            
            return r;
        }

        public List<Ingrediente> listarIngredientesPizza(String idPizza)
        {
            List<Ingrediente> listaIngredientes;

            try
            {
                String json = hreq.sendRequest("/ServicioMyPizza/servicios/WSProducto/ingredientespizza/"+idPizza);
                listaIngredientes = JsonConvert.DeserializeObject<List<Ingrediente>>(json);

            }
            catch (System.Net.WebException swe)
            {
                listaIngredientes = null;
            } 

            return listaIngredientes;
        }

       
        public Ingrediente listarUnIngrediente(String nombre)
        {
            Ingrediente i = null;

            List<String> listaParametros = new List<String>();
            List<String> listaValues = new List<String>();
            String url = "/ServicioMyPizza/servicios/WSProducto/buscar";

            try
            {
                listaParametros.Add("nombre");
                listaValues.Add(nombre);
                
                var json = hreq.sendRequestPOST(url,listaParametros,listaValues);
                i = JsonConvert.DeserializeObject<Ingrediente>(json.ToString());

                Console.WriteLine(i.toString());


            }
            catch (System.Net.WebException swe)
            {
                i = null;
            }

            return i;
        }

    }
}
