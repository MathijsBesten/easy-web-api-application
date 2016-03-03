using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace web_api_application.Helpers.data
{
    public class Log
    {
        public int Id { get; set; }
        public string titel { get; set; }
        public string auteur { get; set; }
        public DateTime gemaakt { get; set; }
        public string verhaal { get; set; }
        public bool verwijderd { get; set; }
    }
}
