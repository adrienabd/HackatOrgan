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
    public partial class ImprimerParticipant : Form
    {
        public ImprimerParticipant()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ImprimerParticipant_Load(object sender, EventArgs e)
        {
            hackathonContext cnx = new hackathonContext();
            comboBox_hackathon.DataSource = cnx.Hackathons.OrderBy(Ha => Ha.IdHackathon).ToList();
            comboBox_hackathon.DisplayMember = "Theme";
            comboBox_hackathon.ValueMember = "idHackathon";
        }

        private void comboBox_hackathon_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btn_precedent_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
