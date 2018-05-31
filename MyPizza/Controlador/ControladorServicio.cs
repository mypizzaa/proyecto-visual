using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class ControladorServicio
    {
        String servidor = "provenapps.cat";
        //private String servidor = "62.83.228.129";

        private Boolean connection;

        public ControladorServicio()
        {

        }
        
        /// <summary>
        /// this method send a ping to the server provenapps.cat to check the connection 
        /// </summary>
        /// <returns>true if the connection is ok or false if the conection fail</returns>
        public Boolean getConnection()
        {
            Boolean connection = false;

            Ping p = new Ping();
            String status = p.Send(this.servidor).Status.ToString();
            
            if(status != null)
            {
                connection = true;
            }

            return connection;
        }



    }
}
