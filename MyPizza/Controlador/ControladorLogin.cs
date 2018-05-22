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

        public ControladorLogin()
        {

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

                var response = await client.PostAsync("http://localhost:8080/ServicioMyPizza/servicios/WSLogin/login", content);

                var json = await response.Content.ReadAsStringAsync();

                if (json != null)
                {
                          u = JsonConvert.DeserializeObject<Usuario>(json);
                   
                }

            }

            return u;
        }







    }
}
