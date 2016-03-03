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
            int id = 1; /*start id*/
            int fout = 0; /*bij meer dan 1 fout zal while loop worden gestopt*/
            logs.Clear(); /*logs lijst wordt leeggemaakt, dit zodat de webpagina niet twee keer de resultaten laat zien*/

            while (id != 0) /*id wordt enkel op 0 gezet als twee keer achter elkaar geen goede response wordt verkregen */
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://169.254.43.18/"); /*de hostname of ip adres van de web-api */
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json")); /*instelling om json te verwachten*/

                    HttpResponseMessage response = client.GetAsync("api/logs/" + id).Result; /*request wordt verzonden naar de web-api*/
                    if (response.IsSuccessStatusCode == true) /*in de header staat of het result goed is - als de return code goed is zal hij het eerste gedeelte uitvoeren*/
                    {
                        Log log = response.Content.ReadAsAsync<Log>().Result; /*response van web-api wordt gelezen en in een 'Log' format gezey*/
                        id++; /*plus 1 voor id zodat hij het volgede id probeerd bij de volgende loop*/
                        fout = 0; /*alle voorgaande fouten worden weggehaalt en staat weer op 0*/
                        logs.Add(log); /*log wordt toegevoegd aan public list logs*/
                    }
                    else
                    {
                        if (fout <= 1) /*kijkt of er al een fout is in de voorgaande request*/
                        {
                            id++; /*while loop gaat door naar volgende id*/
                            fout++; /*er wordt 1 bij fout opgeteld, als deze op 2 staat zal de while loop eindigen bij de volgende loop*/
                        }
                        else
                        {
                            id = 0; /*fout staat op 2 en id wordt op 0 gezet zodat de loop eindigd */
                        }
                    }
                }
            }
        }
    }
}
