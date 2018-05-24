using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{

    public class Ingrediente : Producto
    {
        public long id_ingrediente;
    
        //constructor
        public Ingrediente(long id_prod, string nombre, double precio, string img, long id_tip, long id_ingrediente) : base(id_prod, nombre, precio, img, id_tip)
        {
            this.id_ingrediente = id_ingrediente;
        }

        //Getters
        public long getIdIngrediente()
        {
            return this.id_ingrediente;
        }

        //Setter
        public void setIdIngrediente(long idIngrediente)
        {
            this.id_ingrediente = idIngrediente;
        }

       //toString
       public String toString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("id_ingrediente = " + id_ingrediente);
            sb.Append(base.toString());

            return sb.ToString();
        }


    }
}
