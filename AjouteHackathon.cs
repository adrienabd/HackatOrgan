using HackatOrgan.Models;
using System;
using System.Windows.Forms;

namespace HackatOrgan.Forms
{
    public partial class AjouteHackathon : Form
    {
        public AjouteHackathon()
        {
            InitializeComponent();
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
            txtbx_lieu.Clear();
            txtbx_rue.Clear();
            txtbx__ville.Clear();
        }
        private void btn_valider_Click(object sender, EventArgs e)
        {
            hackathonContext cnx = new hackathonContext();

            //Ajout les éléments à un nouvel objet Hackathon
            Hackathon newHackathon = new Hackathon()
            {
                Theme = txtbx_theme.Text,
                Lieu = txtbx_lieu.Text,
                Rue = txtbx_rue.Text,
                Ville = txtbx__ville.Text,
                CodePostal = Convert.ToString(num_cp.Value),
                DateDebut = datepck_debut.Value,
                DateFin = datepck_limite.Value,
                HeureDebut = TimeSpan.Parse((Convert.ToString(datepck_heuredebut.Value)).Substring(11)),
                HeureFin = TimeSpan.Parse((Convert.ToString(datepck_heurefin.Value)).Substring(11)),
                DateLimite = datepck_fin.Value,
                Image = txtbx_image.Text,
                NbPlaces = Decimal.ToInt32(num_places.Value),
            };

            //Ajout de l'objet au dataContext
            cnx.Hackathons.Add(newHackathon);

            //Enregistrement dans la BD
            cnx.SaveChanges();
            MessageBox.Show("Enregistrement Effectué");
        }
    }
}
