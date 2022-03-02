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
    public partial class AjouteHackathon : Form
    {
        public AjouteHackathon()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void AjouteHackathon_Load(object sender, EventArgs e)
        {

        }

        private void btn_precedent_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_annuler_Click(object sender, EventArgs e)
        {
            txtbx_theme.Clear();
            txtbx_lieu.Clear();
            txtbx_rue.Clear();
            txtbx_code_postal.Clear();
            txtbx__ville.Clear();
            txtbx_date_debut.Clear();
            txtbx_date_fin.Clear();
            txtbx_heure_debut.Clear();
            txtbx_heure_fin.Clear();
            txtbx_date_limite.Clear();
            txtbx_nb_places.Clear();
        }

        private void btn_valider_Click(object sender, EventArgs e)
        {
            hackathonContext cnx = new hackathonContext();
            Hackathon newHackathon = new Hackathon()

            {
                Theme = txtbx_theme.Text,
                Lieu = txtbx_lieu.Text,
                Rue = txtbx_rue.Text,
                Ville = txtbx__ville.Text,
                CodePostal = txtbx_code_postal.Text,
                DateDebut = Convert.ToDateTime(txtbx_date_debut.Text),
                DateFin = Convert.ToDateTime(txtbx_date_fin.Text),
                HeureDebut = TimeSpan.Parse(txtbx_heure_debut.Text),
                HeureFin = TimeSpan.Parse(txtbx_heure_fin.Text),
                NbPlaces = Convert.ToInt32(txtbx_nb_places.Text),
                DateLimite = Convert.ToDateTime(txtbx_date_limite.Text),
                Image = txtbx_image.Text
            };

            //Ajout de l'objet au dataContext
            cnx.Hackathons.Add(newHackathon);

            //Enregistrement dans la BD
            cnx.SaveChanges();
            MessageBox.Show("Enregistrement Effectué");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
