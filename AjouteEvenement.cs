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

        private void label6_Click(object sender, EventArgs e)
        {

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
            txtbx_date.Clear();
            txtbx_heure_debut.Clear();
            txtbx_heure_fin.Clear();
        }
        private void btn_valider_Click(object sender, EventArgs e)
        {
            hackathonContext cnx = new hackathonContext();
            int TE = 0;
            if (chckbx_type_conference.Checked == true)
            {
                if (chckbx_type_atelier.Checked == false)
                {
                    TE = 1;
                }
            }
            if (chckbx_type_conference.Checked == false)
            {
                if (chckbx_type_atelier.Checked == true)
                {
                    TE = 2;
                }
            }
            int IdH = 0;
            foreach (Hackathon H in cnx.Hackathons.ToList())
            {
                object Ev = combobox_hackathon.SelectedValue;
                if (H.Theme.Equals(Ev))
                {
                    IdH = H.IdHackathon;
                }
            }
                    //Création d'un nouvel Evenement
                    Evenement newEvenement = new Evenement()
            {
                        Theme = txtbx_theme.Text,
                        Date = Convert.ToDateTime(txtbx_date.Text),
                        HeureDebut = TimeSpan.Parse(txtbx_heure_debut.Text),
                        HeureFin = TimeSpan.Parse(txtbx_heure_fin.Text),
                        IdHackathon = 2,
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
    }
}
