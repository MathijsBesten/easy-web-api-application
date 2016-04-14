using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using web_api_application.Helpers.data;

namespace web_api_application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static List<Log> Logs = new List<Log>();

        private void dataOphalenButton_Click(object sender, EventArgs e)
        {
            ComboGet.Items.Clear();
            GetData.receiveData();
            foreach (var log in GetData.logs)
            {
                if (log.verwijderd == false)
                {
                    Logs.Add(log);
                    ComboGet.Items.Add(log.Id);
                }
            }
        }

        private void dataOpslaanButton_Click(object sender, EventArgs e)
        {
            if (PostAuteur.Text != "" && PostTitel.Text != "" && PostVerhaal.Text != "")
            {
                List<Log> log = new List<Log>();
                log.Add(new Log() { auteur = PostAuteur.Text, titel = PostTitel.Text, verhaal = PostVerhaal.Text });
                var posted = PostData.postData(log[0]);
                if (posted == true)
                {
                    MessageBox.Show("De gegvens staan in de database");
                    PostAuteur.Text = "";
                    PostTitel.Text = "";
                    PostVerhaal.Text = "";
                }
                else
                {
                    MessageBox.Show("Er is een fout opgetreden bij het wegschrijven van de gegevens");
                }
            }
            else
            {
                MessageBox.Show("U heeft niet alle gegevens ingevult");
            }
        }

        private void CombGet_SelectedIndexChanged(object sender, EventArgs e)
        {
            int nummer = ComboGet.SelectedIndex;
            GetID.Text = Logs[nummer].Id.ToString();
            GetTitel.Text = Logs[nummer].titel;
            GetAuteur.Text = Logs[nummer].auteur;
            GetDate.Text = Logs[nummer].gemaakt.ToString();
            GetVerhaal.Text = Logs[nummer].verhaal;
            GetVerwijderd.Text = Logs[nummer].verwijderd.ToString();
        }

        private void verwijderLogButton_Click(object sender, EventArgs e) 
        {           
            if (GetID.Text != null) // functie werkt alleen als er een log is gekozen
            {
                DialogResult dr = MessageBox.Show("Weet u zeker dat u log "+ GetID.Text+ " wilt verwijderen","test",MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information); // gebruiker wordt gevraagt om bevestiging
                if (dr == DialogResult.Yes) // log wordt verwijderd als de gebruiker op 'Yes' heeft geklikt
                {
                    var actie = DeleteDatacs.Delete(int.Parse(GetID.Text)); // log wordt verwijderd via de delete helper
                }
                else // als de gebruiker de negatief op de messagebox heeft gereageerd 
                {
                    MessageBox.Show("U heeft de actie geannuleerd "); // mbox om de gebruiker te laten dat de het log niet wordt verwijderd
                }
            }
            else // GetID is leeg
            {
                MessageBox.Show("ID veld is leeg, Selecteer een log"); // de gebruiker laten weten dat id veld leeg is
            }
        }

        private void LogAanpassenButton_Click(object sender, EventArgs e)
        {
            if (GetID.Text != "" && GetTitel.Text != "" && GetAuteur.Text != "" && GetVerhaal.Text != "") // functie werkt alleen als alle velden zijn ingevult
            {
                Log log = new Log { Id = int.Parse(GetID.Text), titel = GetTitel.Text, auteur = GetAuteur.Text, gemaakt = DateTime.Parse(GetDate.Text), verhaal = GetVerhaal.Text, verwijderd = Convert.ToBoolean(GetVerwijderd.Text) };
                var actie = PutData.Put(log); //de data wordt veranderd doormiddel van put helper 
                if (actie == true)
                {
                    MessageBox.Show("log is gewijzigd"); // gebruiker weet nu dat het gewijzigd is
                }
                else
                {
                    MessageBox.Show("er is een fout opgetreden bij het veranderen van het log");
                }
            }
            else
            {
                MessageBox.Show("Niet alle waarden zijn ingevult"); // alle waarden moeten ingevult zijn
            }
        }

        private void OpenMapButton_Click(object sender, EventArgs e)
        {
            var test = new FolderBrowserDialog();
        }
    }
}
