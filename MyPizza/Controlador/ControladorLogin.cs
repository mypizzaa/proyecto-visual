using Modelo;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;


namespace Controlador
{
    public class ControladorLogin
    {
        private String servidor;

       
        public ControladorLogin()
        {
            servidor = "http://localhost:8080";
        }

        public async Task<Usuario> login(String correo, String password)
        {
            Usuario u = null;
            
                using (HttpClient client = new HttpClient())
                {
                    var values = new Dictionary<String, String>
                    {
                        {"correo",correo },
                        {"password",password}
                    };

                    var content = new FormUrlEncodedContent(values);

                    var response = await client.PostAsync(servidor+"/ServicioMyPizza/servicios/WSLogin/login", content);

                    var json = await response.Content.ReadAsStringAsync();
                    Console.WriteLine(json);
                    if (json != null)
                    {
                        u = JsonConvert.DeserializeObject<Usuario>(json);
                        Console.Write(u.toString());
                    }
                }
       
            return u;
        }






    }
}
