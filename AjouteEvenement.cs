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

        }

        private void combobox_hackathon_SelectedIndexChanged(object sender, EventArgs e)
        {
            hackathonContext cnx = new hackathonContext();
            combobox_hackathon.DataSource = cnx.Hackathons.OrderBy(Ha => Ha.IdHackathon).ToList();
            combobox_hackathon.DisplayMember = "Theme";
            combobox_hackathon.ValueMember = "idHackathon";
        }

        private void btn_precedent_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
