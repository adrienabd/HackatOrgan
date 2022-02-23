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
    }
}
