using HackatOrgan.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            txtbx_theme.Clear();
            txtbx_heure_debut.Clear();
            txtbx_heure_fin.Clear();
        }
        private void btn_valider_Click(object sender, EventArgs e)
        {
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
            };

            //Ajout de l'objet au dataContext
            cnx.Evenements.Add(newEvenement);

            //Enregistrement dans la BD
            cnx.SaveChanges();
            MessageBox.Show("Enregistrement Effectué");
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
