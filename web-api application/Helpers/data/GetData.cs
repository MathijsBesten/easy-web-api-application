using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

using web_api_application.Properties;

namespace web_api_application.Helpers.data
{
    public class GetData
    {
        public static List<Log> logs = new List<Log>();

        public static void receiveData()
        {
            logs.Clear(); /*logs lijst wordt leeggemaakt, dit zodat de webpagina niet twee keer de resultaten laat zien*/
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://169.254.43.18/"); /*de hostname of ip adres van de web-api */
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json")); /*instelling om json te verwachten*/

                HttpResponseMessage request = client.GetAsync("api/logs").Result; /*request wordt verzonden naar de web-api*/
                var uitslag = request.Content.ReadAsStringAsync();
                List<Log> logLijst = JsonConvert.DeserializeObject<List<Log>>(uitslag.Result);
                foreach (var item in logLijst)
                {
                    logs.Add(item);
                }
            }
        }
    }
}
