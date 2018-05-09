﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    class Pizza : Producto
    {
        private long id_pizza;

        //Constructor
        public Pizza(long id_prod, string nombre, double precio, string img, long id_tip, long id_pizza) : base(id_prod, nombre, precio, img, id_tip)
        {
            this.id_pizza = id_pizza;
        }

        //Getters
        public long getIdPizza()
        {
            return this.id_pizza;
        }
        
        //Setters
        public void setIdPizza(long idPizza)
        {
            this.id_pizza = idPizza;
        }

        //ToString
        public String toString()
        {
            //todo
            return "";
        }


    }
}
