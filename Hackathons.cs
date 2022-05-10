using System;
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
            //création d'un nouvel objet AjouteHackathon avec son lancement
            AjouteHackathon addH = new AjouteHackathon();
            addH.Show();
        }

        private void btn_ajout_evenement_Click(object sender, EventArgs e)
        {
            //création d'un nouvel objet AjouteEvenement avec son lancement
            AjouteEvenement addE = new AjouteEvenement();
            addE.Show();
        }

        private void btn_imprimer_Click(object sender, EventArgs e)
        {
            //création d'un nouvel objet ImprimerParticipant avec son lancement
            ImprimerParticipant imprim = new ImprimerParticipant();
            imprim.Show();
        }

        private void btn_tableau_Click(object sender, EventArgs e)
        {
            //création d'un nouvel objet TableauDeBord avec son lancement
            TableauDeBord tableau = new TableauDeBord();
            tableau.Show();
        }
    }
}
