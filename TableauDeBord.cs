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
            cbx_Evenement.ValueMember = "idHackathon";
            pictureBox2.Load(Hackath.Image);
        }
        private void cbx_Evenement_SelectedIndexChanged(object sender, EventArgs e)
        {
            Evenement Evene = (Evenement)cbx_Evenement.SelectedItem;
            lbl_date.Text = Convert.ToString(Evene.Date);
            lbl_heure_debut.Text = Convert.ToString(Evene.HeureDebut);
            lbl_heure_fin.Text = Convert.ToString(Evene.HeureFin);
            lbl_nb_place.Text = Convert.ToString(Evene.NbPlaces);

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
