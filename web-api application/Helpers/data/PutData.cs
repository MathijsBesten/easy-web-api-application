using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace web_api_application.Helpers.data
{
    class PutData
    {
        public static bool Put(Log nieuweLog)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://169.254.43.18/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage oudelog = client.GetAsync("api/logs/" + nieuweLog.Id).Result; /*'oud, om te vervangen log' wordt opgehaald*/
                if (oudelog.IsSuccessStatusCode == true) /*als de oude log correct is opgehaalt wordt het eerst stuk if statement uitgevoerd*/
                {
                    var oudeLog = oudelog.Content.ReadAsAsync<Log>().Result; /*nieuwe list 'oudeLog wordt gevult'*/
                    var log = new Log() { }; /*'log' wordt het nieuwe log voor in de database*/
                    log.Id = oudeLog.Id; /*Oude Id wordt behouden*/
                    if (nieuweLog.titel != "") { log.titel = nieuweLog.titel; } else { log.titel = oudeLog.titel; } /*oude titel wordt gebruikt als er geen titel is ingevoerd in het form*/
                    if (nieuweLog.auteur != "") { log.auteur = nieuweLog.auteur; } else { log.auteur = oudeLog.auteur; } /*oude auteur wordt gebruikt als er geen auteur is ingevoerd in het form*/
                    if (nieuweLog.auteur != "" || nieuweLog.titel != "" || nieuweLog.verhaal != "") { log.gemaakt = DateTime.Now; } else { log.gemaakt = oudeLog.gemaakt; } /*Oude datum wordt gebruikt als er geen waardes zijn ingevoerd*/
                    if (nieuweLog.verhaal != "") { log.verhaal = nieuweLog.verhaal; } else { log.verhaal = oudeLog.verhaal; } /*oud verhaal wordt gebruikt als er geen verhaal is ingevoerd in het form*/
                    log.verwijderd = oudeLog.verwijderd; /*oude verwijder status wordt behouden*/

                    var response = client.PutAsJsonAsync("api/logs/" + oudeLog.Id, log).Result; /*put request wordt verstuurd met de nieuwe gegevens*/
                    if (response.IsSuccessStatusCode)
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
