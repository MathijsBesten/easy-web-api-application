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

        private void dataVeranderenButton_Click(object sender, EventArgs e)
        {
            if (PutID.Text != "")/*Controleerd of id is ingevoerd*/
            {
                List<Log> log = new List<Log>(); /*nieuwe lijst wordt aangemaakt*/
                int id = int.Parse(PutID.Text); /*string PutID wordt naar int omgezet voor de add*/
                log.Add(new Log() {Id = id, auteur = PutAuteur.Text, titel = PutTitel.Text, verhaal = PutVerhaal.Text }); /*nieuw log wordt gemaakt*/
                bool changed = PutData.Put(log[0]); /*voert de put funtie uit en krijgt true of false terug*/
                if (changed == true) /*true wordt teruggeven als de data is veranderd in de web-api*/
                {
                    MessageBox.Show("De gegvens zijn bijgewerkt");

                    /*Text velden worden weer leeggemaakt voor volgende put*/
                    PutID.Text = "";
                    PutAuteur.Text = "";
                    PutTitel.Text = "";
                    PutVerhaal.Text = "";
                }
                else
                {
                    MessageBox.Show("Er is een fout opgetreden bij het wegschrijven van de gegevens");

                }
            }
            else
            {
                MessageBox.Show("U heeft sommige velden niet ingevuld, vul deze alsnog in");
            }
        }

        private void dataDeleteButton_Click(object sender, EventArgs e)
        {
            if (DeleteID.Text != "")/*Controleerd of id is ingevoerd*/
            {
                int id = int.Parse(DeleteID.Text); /*string deleteID wordt naar int omgezet voor de add*/
                bool changed = DeleteDatacs.Delete(id); /*voert de delete funtie uit en krijgt true of false terug*/
                if (changed == true) /*true wordt teruggeven als de data is veranderd in de web-api*/
                {
                    MessageBox.Show("De log is verwijderd");

                    /*Text velden worden weer leeggemaakt voor volgende put*/
                    DeleteID.Text = "";
                }
                else
                {
                    MessageBox.Show("Er is een fout opgetreden bij het wegschrijven van de gegevens");
                }
            }
            else
            {
                MessageBox.Show("U heeft sommige velden niet ingevuld, vul deze alsnog in");
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
    }
}
