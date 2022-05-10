using HackatOrgan.Models;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace HackatOrgan.Forms
{
    public partial class AjouteEvenement : Form
    {
        public AjouteEvenement()
        {
            InitializeComponent();
        }
        private void AjouteEvenement_Load(object sender, EventArgs e)
        {
            //incrémente la combobox avec les Hackathons de la base de données
            hackathonContext cnx = new hackathonContext();
            combobox_hackathon.DataSource = cnx.Hackathons.OrderBy(Ha => Ha.IdHackathon).ToList();
            combobox_hackathon.DisplayMember = "Theme";
            combobox_hackathon.ValueMember = "idHackathon";

            //Cache par defaut les champs concernants le nombre de place quand l'évènement est une conférence
            lbl_nb_places.Enabled = false;
            num_places.Enabled = false;
        }

        private void btn_precedent_Click(object sender, EventArgs e)
        {
            //ferme la fenêtre
            this.Close();
        }

        private void btn_annuler_Click(object sender, EventArgs e)
        {
            // réinitialise les champs 
            txtbx_theme.Clear();
            num_places.Value = 0;
            btnradio_atelier.Checked = false;
            btnradio_conference.Checked = false;
        }
        private void btn_valider_Click(object sender, EventArgs e)
        {
            hackathonContext cnx = new hackathonContext();

            int places = 0;
            int IdType = 0;

            //vérifie le type d'evenement
            if (btnradio_conference.Checked == true)
            {
                if (btnradio_atelier.Checked == false)
                {
                    IdType = 1;
                }
            }
            if (btnradio_conference.Checked == false)
            {
                if (btnradio_atelier.Checked == true)
                {
                    IdType = 2;
                    places = Decimal.ToInt32(num_places.Value);
                }
            }

            //vérifie si un évenement est selectionné
            if (btnradio_conference.Checked == false)
            {
                if (btnradio_atelier.Checked == false)
                {
                    MessageBox.Show("Veuillez choisir un type d'évenement");
                }
            }

            //Récupère l'Id de l'Hackathon selectionné
            int IdH = 0;
            foreach (Hackathon H in cnx.Hackathons.ToList())
            {
                if (H.Theme == combobox_hackathon.Text)
                {
                    IdH = H.IdHackathon;
                }
            }

            //Création d'un nouvel Evenement
            Evenement newEvenement = new Evenement()
            {
                Theme = txtbx_theme.Text,
                Date = datepck_date.Value,
                HeureDebut = TimeSpan.Parse((Convert.ToString(datepck_debut.Value)).Substring(11)),
                HeureFin = TimeSpan.Parse((Convert.ToString(datepck_fin.Value)).Substring(11)),
                IdHackathon = IdH,
                IdTypeEvenement = IdType,
                NbPlaces = places,
            };

            //Ajout de l'objet au dataContext
            cnx.Evenements.Add(newEvenement);

            //Enregistrement dans la BD
            cnx.SaveChanges();
            MessageBox.Show("Enregistrement Effectué");
        }

        private void btnradio_conference_CheckedChanged(object sender, EventArgs e)
        {
            //Cache les champs concernants le nombre de place quand l'évènement est une conférence
            lbl_nb_places.Enabled = false;
            num_places.Enabled = false;
        }

        private void btnradio_atelier_CheckedChanged(object sender, EventArgs e)
        {
            //Affiche les champs concernants le nombre de place quand l'évènement est un atelier
            lbl_nb_places.Enabled = true;
            num_places.Enabled = true;
        }
    }
}