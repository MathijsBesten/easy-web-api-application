using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace web_api_application.Helpers.data
{
    class PostData
    {
        public static bool postData(Log log)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://169.254.43.18/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                /*
                'model' is een waarde uit het ingevulde form

                bij een post wordt de post samengesteld met waarde uit het http form die is ingevult door de gebruiker en vaste waarde
                titel, auteur en verhaal worden uit het form gehaald.
                gemaakt wordt gevult met de huidige tijd en datum
                verwijderd staat standaard op false, dit wordt met elke post meegestuurd
                Id wordt niet meegegeven, deze wordt door de web-api's database zelf geregeld
                */

                Log newLog = new Log() { titel = log.titel, auteur = log.auteur, gemaakt = DateTime.Now, verhaal = log.verhaal, verwijderd = false };
                var response = client.PostAsJsonAsync("api/logs/", newLog).Result; /*Post wordt gedaan naar de web-api*/
                if (response.IsSuccessStatusCode == true) /*in de header staat of het result goed is - als de return code goed is zal hij het eerste gedeelte uitvoeren*/
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
