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
        private void lbl_date_debut_Click(object sender, EventArgs e)
        {

        }

        private void lbl_lieu_Click(object sender, EventArgs e)
        {

        }

        private void AjouteEvenement_Load(object sender, EventArgs e)
        {
            hackathonContext cnx = new hackathonContext();
            combobox_hackathon.DataSource = cnx.Hackathons.OrderBy(Ha => Ha.IdHackathon).ToList();
            combobox_hackathon.DisplayMember = "Theme";
            combobox_hackathon.ValueMember = "idHackathon";
            lbl_nb_places.Enabled = false;
            num_places.Enabled = false;
        }

        private void combobox_hackathon_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btn_precedent_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_valider_Click(object sender, EventArgs e)
        {
            int places = 0;
            hackathonContext cnx = new hackathonContext();
            int TE = 0;
            if (btnradio_conference.Checked == true)
            {
                if (btnradio_atelier.Checked == false)
                {
                    TE = 1;
                }
            }
            if (btnradio_conference.Checked == false)
            {
                if (btnradio_atelier.Checked == true)
                {
                    TE = 2;
                    places = Decimal.ToInt32(num_places.Value);
                }
            }
            if (btnradio_conference.Checked == false)
            {
                if (btnradio_atelier.Checked == false)
                {
                    MessageBox.Show("Veuillez choisir un type d'évenement"); ;
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
                IdTypeEvenement = TE,
                NbPlaces = places,
            };

            //Ajout de l'objet au dataContext
            cnx.Evenements.Add(newEvenement);

            //Enregistrement dans la BD
            cnx.SaveChanges();
            MessageBox.Show("Enregistrement Effectué");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            lbl_nb_places.Enabled = true;
            num_places.Enabled = true;
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnradio_conference_CheckedChanged(object sender, EventArgs e)
        {
            lbl_nb_places.Enabled = false;
            num_places.Enabled = false;
        }
    }
}