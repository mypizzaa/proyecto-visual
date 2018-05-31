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

        private List<String> listaParam = new List<String>();
        private List<String> listaValues = new List<String>();


        public ControladorProductos()
        {
           hreq = new HttpRequest();
        }
                
        //this method clear the lists param and values 
        public void limpiarListas()
        {
            this.listaParam.Clear();
            this.listaValues.Clear();
        }

        // esto esta mal hay que quitar este metodo !!!!!!!!!!!!!!!!!!
        /// <summary>
        /// this method list a prodcut by name, sends by POST
        /// </summary>
        /// <param name="nombre">nombre producto</param>
        /// <returns></returns>
        public async Task<Producto> listarUnProducto(String nombre)
        {
            Producto p = null;

            try
            {
                this.listaParam.Add("name");
                this.listaValues.Add(nombre);

                var json = await hreq.sendRequestPOST("/ServicioMyPizza/servicios/WSProducto/buscar", listaParam, listaValues);
                              
                if(json != null)
                {
                    p = JsonConvert.DeserializeObject<Producto>(json.ToString());
                   
                }
               
            }
            catch (System.Net.WebException swe)
            {
                p = null;
            }
            
            return p;
        }



        //--- PIZZAS --------------------------------------------------------------------//

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
               
        public void agregarPizza(String nombre, List<Ingrediente> listaIngredientes)
        {

        }

        public void modificarPizza(Pizza p)
        {

        }

        public void eliminarPizza(Pizza p)
        {

        }

        public List<Ingrediente> listarIngredientesPizza(String idPizza)
        {
            List<Ingrediente> listaIngredientes;

            try
            {
                String json = hreq.sendRequest("/ServicioMyPizza/servicios/WSProducto/ingredientespizza/" + idPizza);
                listaIngredientes = JsonConvert.DeserializeObject<List<Ingrediente>>(json);

            }
            catch (System.Net.WebException swe)
            {
                listaIngredientes = null;
            }

            return listaIngredientes;
        }

        public async Task<Pizza> buscarPizzaPorNombre(String nombrePizza)
        {
            Pizza pizza = null;

            try
            {
                limpiarListas();
                listaParam.Add("name");
                listaValues.Add(nombrePizza);

                String json = await hreq.sendRequestPOST("/ServicioMyPizza/servicios/WSProducto/buscarpizza",listaParam,listaValues);
                pizza = JsonConvert.DeserializeObject<Pizza>(json);

            }
            catch (System.Net.WebException swe)
            {
                pizza = null;
            }
            return pizza;
        }


        //--- INGREDIENTES ----------------------------------------------------------------//

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
        
        public void agregarIngrediente(Ingrediente i)
        {

        }

        public void modificarIngrediente(Ingrediente i)
        {

        }

        public void eliminarIngrediente(Ingrediente i)
        {

        }

        public async Task<Ingrediente> buscarIngredientePorNombre(String nombre)
        {
            Ingrediente i = null;

            try
            {
                limpiarListas();
                listaParam.Add("name");
                listaValues.Add(nombre);

                String json = await hreq.sendRequestPOST("/ServicioMyPizza/servicios/WSProducto/buscaringrediente", listaParam, listaValues);
                i = JsonConvert.DeserializeObject<Ingrediente>(json);

            }
            catch (System.Net.WebException swe)
            {
                i = null;
            }
            return i;
        }


        //--- BEBIDAS --------------------------------------------------------------------//

        //Lista all drinks
        //return null if not found else return list of drinks
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
              
        public void agregarBebida(Refresco r)
        {

        }

        public void modificarBebida(Refresco r)
        {

        }

        public void eliminarBebida(Refresco r)
        {

        }

        public async Task<Refresco> buscarRefrescoPorNombre(String nombreRefresco)
        {
            Refresco r = null;

            try
            {
                limpiarListas();
                listaParam.Add("name");
                listaValues.Add(nombreRefresco);

                String json = await hreq.sendRequestPOST("/ServicioMyPizza/servicios/WSProducto/buscarbebida", listaParam, listaValues);
                r = JsonConvert.DeserializeObject<Refresco>(json);

            }
            catch (System.Net.WebException swe)
            {
                r = null;
            }
            return r;
        }


        //--------------------------------------------------------------------------------//


    }
}
