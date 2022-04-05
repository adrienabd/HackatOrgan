using HackatOrgan.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace HackatOrgan
{
    public partial class TableauDeBord : Form
    {
        public TableauDeBord()
        {
            InitializeComponent();
        }

        private void TableauDeBord_Load(object sender, EventArgs e)
        {
            hackathonContext cnx = new hackathonContext();
            cbx_hackathon.DataSource = cnx.Hackathons.OrderBy(Ha => Ha.IdHackathon).ToList();
            cbx_hackathon.DisplayMember = "Theme";
            cbx_hackathon.ValueMember = "IdHackathon";

        }
        private void cbx_hackathon_SelectedIndexChanged(object sender, EventArgs e)
        {
            Hackathon Hackath = (Hackathon)cbx_hackathon.SelectedItem;
            hackathonContext cnx = new hackathonContext();
            cbx_Evenement.DataSource = cnx.Evenements.OrderBy(Ha => Ha.IdHackathon).Where(Ha => Ha.IdHackathon == Hackath.IdHackathon).Where(Ha => Ha.IdTypeEvenement==2).ToList();
            cbx_Evenement.DisplayMember = "Theme";
            cbx_Evenement.ValueMember = "idEvenement";
            pictureBox2.Load(Hackath.Image);

            lbl_lieu.Text = Hackath.Lieu;
        }
        private void cbx_Evenement_SelectedIndexChanged(object sender, EventArgs e)
        {
            Evenement Evene = (Evenement)cbx_Evenement.SelectedItem;
            hackathonContext cnx = new hackathonContext();
            lbl_date.Text = Convert.ToString(Evene.Date);
            lbl_heure_debut.Text = Convert.ToString(Evene.HeureDebut);
            lbl_heure_fin.Text = Convert.ToString(Evene.HeureFin);
            lbl_nb_place.Text = Convert.ToString(Evene.NbPlaces);

            //Comptage du nb de participants de l'evenement
            int NbPlaces = Evene.NbPlaces;
            int compteur = 0;
            foreach (Participantevenement Pe in cnx.Participantevenements.ToList())
            {
                object Evenen = cbx_Evenement.SelectedValue;
                if (Pe.IdEvenement.Equals(Evenen))
                {
                    compteur += 1;
                }
            }
            lbl_inscrit.Text = Convert.ToString(compteur);
            //Attribution de la note de l'evenement en fonction des inscrits et des places dispo
            decimal note = ((Convert.ToDecimal(compteur) / Convert.ToDecimal(NbPlaces)) * 100);
            if (note == 0)
            {lbl_note.Text = "☆☆☆☆☆";}
            else if (note <= 20)
                {lbl_note.Text = "★☆☆☆☆";}
            else if (note <= 40)
                {lbl_note.Text = "★★☆☆☆";}
            else if (note <= 60)
                {lbl_note.Text = "★★★☆☆";}
            else if (note <= 80)
                {lbl_note.Text = "★★★★☆";}
            else if (note <= 100)
                {lbl_note.Text = "★★★★★";}
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void lbl_inscrit_Click(object sender, EventArgs e)
        {

        }

        private void lbl_note_Click(object sender, EventArgs e)
        {

        }

        private void lbl_lieu_Click(object sender, EventArgs e)
        {

        }
    }
}
