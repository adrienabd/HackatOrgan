using HackatOrgan.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
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
            cbx_Evenement.ValueMember = "idEvenement";
            pictureBox2.Load(Hackath.Image);

            lbl_lieu.Text = Hackath.Lieu;
        }
        private void cbx_Evenement_SelectedIndexChanged(object sender, EventArgs e)
        {
            Evenement Evene = (Evenement)cbx_Evenement.SelectedItem;
            hackathonContext cnx = new hackathonContext();
            lbl_date.Text = Convert.ToString(Evene.Date);
            lbl_heure_debut.Text = Convert.ToString(Evene.HeureDebut);
            lbl_heure_fin.Text = Convert.ToString(Evene.HeureFin);
            lbl_nb_place.Text = Convert.ToString(Evene.NbPlaces);

            //Comptage du nb de participants de l'evenement
            int NbPlaces = Evene.NbPlaces;
            int compteur = 0;
            foreach (Participantevenement Pe in cnx.Participantevenements.ToList())
            {
                object Evenen = cbx_Evenement.SelectedValue;
                if (Pe.IdEvenement.Equals(Evenen))
                {
                    compteur += 1;
                }
            }
            lbl_inscrit.Text = Convert.ToString(compteur);
            //Attribution de la note de l'evenement en fonction des inscrits et des places dispo
            decimal note = ((Convert.ToDecimal(compteur) / Convert.ToDecimal(NbPlaces)) * 100);
            if (note == 0)
            {lbl_note.Text = "☆☆☆☆☆";}
            else if (note <= 20)
                {lbl_note.Text = "★☆☆☆☆";}
            else if (note <= 40)
                {lbl_note.Text = "★★☆☆☆";}
            else if (note <= 60)
                {lbl_note.Text = "★★★☆☆";}
            else if (note <= 80)
                {lbl_note.Text = "★★★★☆";}
            else if (note <= 100)
                {lbl_note.Text = "★★★★★";}
        }
        private void btn_mail_Click(object sender, EventArgs e)
        {
            hackathonContext cnx = new hackathonContext();
            SmtpClient client = new SmtpClient()
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential()
                {
                    UserName = "noreply.hackatOrga@gmail.com",
                    Password = "NAJP@ssw0rd"
                }
            };
            foreach (Participantevenement Pe in cnx.Participantevenements.ToList())
            {
                Evenement Evene = (Evenement)cbx_Evenement.SelectedItem;
                object Evenen = cbx_Evenement.SelectedValue;
                if (Pe.IdEvenement.Equals(Evenen))
                {
                    MailAddress FromEmail = new MailAddress("noreply.hackatOrga@gmail.com");
                    MailAddress ToEmail = new MailAddress(Pe.Mail);
                    MailMessage Message = new MailMessage()
                    {
                        From = FromEmail,
                        Subject = "Rappel Evenement : " + Evene.Theme,
                        Body = "Salut " + Pe.Nom + " " + Pe.Prenom + " ! \r\n" +
                        " N'oubliez pas que vous avez l'évenement " + Evene.Theme + " le " + Evene.Date + " De " + Evene.HeureDebut + " à " + Evene.HeureFin + "\r\n" +
                        " Cordialement, l'équipe d'Hackat'Orga! ",
                    };
                    Message.To.Add(ToEmail);

                    try
                    {
                        client.Send(Message);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Quelque chose ne marche pas \n" + ex.InnerException.Message, "Erreur");
                    }
                }
            }
            MessageBox.Show("Bien envoyé");
        }
        private void btn_precedent_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void lbl_inscrit_Click(object sender, EventArgs e)
        {

        }

        private void lbl_note_Click(object sender, EventArgs e)
        {

        }

        private void lbl_lieu_Click(object sender, EventArgs e)
        {

        }
    }
}
