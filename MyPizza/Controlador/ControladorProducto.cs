
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Controlador
{
    public class ControladorProducto
    {
        
        public ControladorProducto()
        {
           
           
        }

        public String listarpizzas()
        {
            ServiceProducto.WSProductoClient sprod = new ServiceProducto.WSProductoClient();
            string pizzas = sprod.pizzas();
                        
           
            return pizzas;
        }





    }




}
