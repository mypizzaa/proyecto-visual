using Modelo;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Controlador
{
    public class ControladorLogin
    {
        private String servidor;


        public ControladorLogin()
        {
            servidor = "http://provenapps.cat:8080";
        }

        public async Task<Token> login(String correo, String password)
        {
            Token token = null;            

            using (HttpClient client = new HttpClient())
            {
                var values = new Dictionary<String, String>
                {
                    {"correo",correo },
                    {"password",password}
                };

                var content = new FormUrlEncodedContent(values);

                var response = await client.PostAsync(servidor+ "/ServicioMyPizza/servicios/WSLogin/login", content);

                var json = await response.Content.ReadAsStringAsync();
                Console.WriteLine("----------------"+json.ToString());

                if (json != null)
                {
                    token = JsonConvert.DeserializeObject<Token>(json);
                    
                                                    
                }
            }

            return token;
        }
    }
}
