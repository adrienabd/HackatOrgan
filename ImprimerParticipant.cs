using HackatOrgan.Models;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Data;
using System.IO;
using System.Linq;
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
            hackathonContext cnx = new hackathonContext();
            //Création d'un document
            string name = Convert.ToString(comboBox_hackathon.SelectedValue);
            Document unDocument = new Document();
            PdfWriter.GetInstance(unDocument, new FileStream("C:\\Users\\" + System.Environment.UserName+ "\\Desktop\\Participants." + name +".pdf", FileMode.Create));
            unDocument.Open();

            //Paragraphe centré avec une police de 14 et du gras
            iTextSharp.text.Font myFont = FontFactory.GetFont("Arial", 14, iTextSharp.text.Font.BOLD);
            Paragraph titre = new Paragraph("Liste des Participants pour l'hackathon : "+ name, myFont);
            titre.Alignment = Element.ALIGN_CENTER;
            titre.SpacingAfter = 12;
            unDocument.Add(titre);

            //Création d'un tableau
            PdfPTable tableau = new PdfPTable(3);
            tableau.AddCell("Nom");
            tableau.AddCell("Prenom");
            tableau.AddCell("Date d'inscription");

            //Remplissage avec la liste des participants
            foreach (Hackathon H in cnx.Hackathons.ToList())
            {
                //récupération de l'id de l'hackathon selectionné
                object Hackat = comboBox_hackathon.SelectedValue;
                if (H.Theme.Equals(Hackat))
                {
                    //boucle sur participation
                    foreach (Participation Ption in cnx.Participations.ToList())
                    {
                        //récupération des participation de l'hackathon selectionné
                        if (H.IdHackathon == Ption.IdHackathon)
                        {
                            //boucle sur les participants
                            foreach (Participant P in cnx.Participants.ToList())
                            {
                                //récupération du participant de la participation selectionnée
                                if (P.IdParticipant == Ption.IdParticipant)
                                {
                                    tableau.AddCell(P.Nom);
                                    tableau.AddCell(P.Prenom);
                                    tableau.AddCell((Ption.DateInscription).ToString("dd/MM/yyyy"));
                                }
                            }
                        }
                    }
                }
            }
            //ajout du tableau dans le document
            unDocument.Add(tableau);

            //Enregistrement du fichier
            unDocument.Close();
            MessageBox.Show("Document généré");
        }

        private void ImprimerParticipant_Load(object sender, EventArgs e)
        {
            //incrémente la combobox avec les Hackathons de la base de données
            hackathonContext cnx = new hackathonContext();
            comboBox_hackathon.DataSource = cnx.Hackathons.OrderBy(Ha => Ha.IdHackathon).ToList();
            comboBox_hackathon.DisplayMember = "Theme";
            comboBox_hackathon.ValueMember = "Theme";
        }

        private void btn_precedent_Click(object sender, EventArgs e)
        {
            //ferme la fenêtre
            this.Close();
        }

    }
}
