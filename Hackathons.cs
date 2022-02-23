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
    public partial class Hackathons : Form
    {
        public Hackathons()
        {
            InitializeComponent();
        }

        private void grid_hackathon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void Hackathons_Load(object sender, EventArgs e)
        {
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

        }
    }
}
