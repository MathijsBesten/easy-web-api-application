using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace web_api_application.Helpers.data
{
    class logReceive
    {
        public static Log getLog(int id)  /*Return null als er een fout is*/
        {

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://169.254.43.18/"); /*de hostname of ip adres van de web-api */
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json")); /*instelling om json te verwachten*/

                HttpResponseMessage response = client.GetAsync("api/logs/" + id).Result; /*request wordt verzonden naar de web-api*/
                if (response.IsSuccessStatusCode == true) /*in de header staat of het result goed is - als de return code goed is zal hij het eerste gedeelte uitvoeren*/
                {
                    Log log = response.Content.ReadAsAsync<Log>().Result; /*response van web-api wordt gelezen en in een 'Log' format gezet*/
                    return log; /*Log wordt teruggestuurd als uitkomst van getLog*/

                }
                else
                {
                    return null; /*Als log niet kan worden gevonden of er een ander probleemm ontstaat*/
                }
            }
        }
    }
}
