using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace web_api_application.Helpers.data
{
    class DeleteDatacs
    {
        public static bool Delete(int logID)
        {
            //***********
            //Deze functie verwijderd het de log niet, maar zet de waarde van 'verwijderd' op true.
            //***********

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://169.254.43.18/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage oudelog = client.GetAsync("api/logs/" + logID).Result; /*Oude, te verwijderen log wordt opgehaalt via de web-api*/
                if (oudelog.IsSuccessStatusCode == true)
                {
                    var log = oudelog.Content.ReadAsAsync<Log>().Result; /*public list oudeLog wordt gevult met de waarde van oudelog*/
                    log.verwijderd = true; /*verwijderd waarde wordt op true gezet*/
                    var response = client.PutAsJsonAsync("api/logs/" + logID, log).Result; /*de nieuwe log wordt opgestuurd naar de web-api*/
                    if (response.IsSuccessStatusCode) /*if wordt uitgevoerd als de web-api de data heeft ontvangen*/
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
