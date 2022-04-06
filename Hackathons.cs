using HackatOrgan.Models;
using System;
using System.Data;
using System.Windows.Forms;


namespace HackatOrgan.Forms
{
    public partial class Hackathons : Form
    {
        public Hackathons()
        {
            InitializeComponent();
        }

        private void btn_ajouter_hackathon_Click(object sender, EventArgs e)
        {
            AjouteHackathon addH = new AjouteHackathon();

            addH.Show();
        }

        private void btn_ajout_evenement_Click(object sender, EventArgs e)
        {
            AjouteEvenement addE = new AjouteEvenement();
            addE.Show();
           
        }

        private void btn_imprimer_Click(object sender, EventArgs e)
        {
            ImprimerParticipant imprim = new ImprimerParticipant();

            imprim.Show();
        }

        private void Hackathons_Load_1(object sender, EventArgs e)
        {
/*                hackathonContext cnx = new hackathonContext();

            dataGridView1.DataSource = cnx.Evenements;*/
           
        }

        private void btn_tableau_Click(object sender, EventArgs e)
        {
            TableauDeBord tableau = new TableauDeBord();

            tableau.Show();
        }
    }
}
