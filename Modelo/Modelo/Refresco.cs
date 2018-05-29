using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Refresco : Producto
    {
        private long id_refresco;


        //Constructor
        public Refresco(long id_prod, string nombre, double precio, string img, long id_tip, long id_refresco) : base(id_prod, nombre, precio, img, id_tip)
        {
            this.id_refresco = id_refresco;
        }

        //Getters
        public long getIdRefresco()
        {
            return this.id_refresco;
        }

        //Setter
        public void setIdRefresco(long idRefresco)
        {
            this.id_refresco = idRefresco;
        }

        //ToString
        public String toString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("id_refresco = " +id_refresco);
            sb.Append(base.toString());

            return sb.ToString();
        }

        
    }
}
