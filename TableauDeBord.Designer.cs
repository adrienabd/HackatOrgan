
namespace HackatOrgan
{
    partial class TableauDeBord
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TableauDeBord));
            this.label1 = new System.Windows.Forms.Label();
            this.cbx_Evenement = new System.Windows.Forms.ComboBox();
            this.cbx_hackathon = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label_date = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_heure_fin = new System.Windows.Forms.Label();
            this.lbl_heure_debut = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl_nb_place = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lbl_inscrit = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_note = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_lieu = new System.Windows.Forms.Label();
            this.lbl_lieux = new System.Windows.Forms.Label();
            this.btn_mail = new System.Windows.Forms.Button();
            this.btn_precedent = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hackathon";
            // 
            // cbx_Evenement
            // 
            this.cbx_Evenement.FormattingEnabled = true;
            this.cbx_Evenement.Location = new System.Drawing.Point(150, 111);
            this.cbx_Evenement.Name = "cbx_Evenement";
            this.cbx_Evenement.Size = new System.Drawing.Size(209, 23);
            this.cbx_Evenement.TabIndex = 1;
            this.cbx_Evenement.SelectedIndexChanged += new System.EventHandler(this.cbx_Evenement_SelectedIndexChanged);
            // 
            // cbx_hackathon
            // 
            this.cbx_hackathon.FormattingEnabled = true;
            this.cbx_hackathon.Location = new System.Drawing.Point(150, 82);
            this.cbx_hackathon.Name = "cbx_hackathon";
            this.cbx_hackathon.Size = new System.Drawing.Size(209, 23);
            this.cbx_hackathon.TabIndex = 2;
            this.cbx_hackathon.SelectedIndexChanged += new System.EventHandler(this.cbx_hackathon_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Evenement";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(388, 82);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(294, 172);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // label_date
            // 
            this.label_date.AutoSize = true;
            this.label_date.Location = new System.Drawing.Point(31, 181);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(37, 15);
            this.label_date.TabIndex = 7;
            this.label_date.Text = "Date :";
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Location = new System.Drawing.Point(200, 181);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(87, 15);
            this.lbl_date.TabIndex = 9;
            this.lbl_date.Text = "----------------";
            // 
            // lbl_heure_fin
            // 
            this.lbl_heure_fin.AutoSize = true;
            this.lbl_heure_fin.Location = new System.Drawing.Point(200, 239);
            this.lbl_heure_fin.Name = "lbl_heure_fin";
            this.lbl_heure_fin.Size = new System.Drawing.Size(87, 15);
            this.lbl_heure_fin.TabIndex = 13;
            this.lbl_heure_fin.Text = "----------------";
            // 
            // lbl_heure_debut
            // 
            this.lbl_heure_debut.AutoSize = true;
            this.lbl_heure_debut.Location = new System.Drawing.Point(200, 210);
            this.lbl_heure_debut.Name = "lbl_heure_debut";
            this.lbl_heure_debut.Size = new System.Drawing.Size(87, 15);
            this.lbl_heure_debut.TabIndex = 12;
            this.lbl_heure_debut.Text = "----------------";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 239);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 15);
            this.label9.TabIndex = 11;
            this.label9.Text = "Heure de fin :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(31, 210);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 15);
            this.label10.TabIndex = 10;
            this.label10.Text = "Heure de début :";
            // 
            // lbl_nb_place
            // 
            this.lbl_nb_place.AutoSize = true;
            this.lbl_nb_place.Location = new System.Drawing.Point(200, 266);
            this.lbl_nb_place.Name = "lbl_nb_place";
            this.lbl_nb_place.Size = new System.Drawing.Size(87, 15);
            this.lbl_nb_place.TabIndex = 16;
            this.lbl_nb_place.Text = "----------------";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(31, 266);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(109, 15);
            this.label14.TabIndex = 14;
            this.label14.Text = "Nombre de places :";
            // 
            // lbl_inscrit
            // 
            this.lbl_inscrit.AutoSize = true;
            this.lbl_inscrit.Location = new System.Drawing.Point(200, 293);
            this.lbl_inscrit.Name = "lbl_inscrit";
            this.lbl_inscrit.Size = new System.Drawing.Size(87, 15);
            this.lbl_inscrit.TabIndex = 18;
            this.lbl_inscrit.Text = "----------------";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 15);
            this.label4.TabIndex = 17;
            this.label4.Text = "Nombre d\'inscrits :";
            // 
            // lbl_note
            // 
            this.lbl_note.AutoSize = true;
            this.lbl_note.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_note.Location = new System.Drawing.Point(542, 283);
            this.lbl_note.Name = "lbl_note";
            this.lbl_note.Size = new System.Drawing.Size(140, 28);
            this.lbl_note.TabIndex = 19;
            this.lbl_note.Text = "----------------";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(373, 293);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 15);
            this.label5.TabIndex = 20;
            this.label5.Text = "Note :";
            // 
            // lbl_lieu
            // 
            this.lbl_lieu.AutoSize = true;
            this.lbl_lieu.Location = new System.Drawing.Point(200, 153);
            this.lbl_lieu.Name = "lbl_lieu";
            this.lbl_lieu.Size = new System.Drawing.Size(87, 15);
            this.lbl_lieu.TabIndex = 22;
            this.lbl_lieu.Text = "----------------";
            // 
            // lbl_lieux
            // 
            this.lbl_lieux.AutoSize = true;
            this.lbl_lieux.Location = new System.Drawing.Point(31, 153);
            this.lbl_lieux.Name = "lbl_lieux";
            this.lbl_lieux.Size = new System.Drawing.Size(35, 15);
            this.lbl_lieux.TabIndex = 21;
            this.lbl_lieux.Text = "Lieu :";
            // 
            // btn_mail
            // 
            this.btn_mail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(190)))), ((int)(((byte)(201)))));
            this.btn_mail.FlatAppearance.BorderSize = 0;
            this.btn_mail.Location = new System.Drawing.Point(428, 12);
            this.btn_mail.Margin = new System.Windows.Forms.Padding(0);
            this.btn_mail.Name = "btn_mail";
            this.btn_mail.Size = new System.Drawing.Size(254, 34);
            this.btn_mail.TabIndex = 23;
            this.btn_mail.Text = "Envoie du mail de Rappel";
            this.btn_mail.UseVisualStyleBackColor = false;
            this.btn_mail.Click += new System.EventHandler(this.btn_mail_Click);
            // 
            // btn_precedent
            // 
            this.btn_precedent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(190)))), ((int)(((byte)(201)))));
            this.btn_precedent.Location = new System.Drawing.Point(30, 12);
            this.btn_precedent.Name = "btn_precedent";
            this.btn_precedent.Size = new System.Drawing.Size(255, 34);
            this.btn_precedent.TabIndex = 51;
            this.btn_precedent.Text = "Précedent";
            this.btn_precedent.UseVisualStyleBackColor = false;
            this.btn_precedent.Click += new System.EventHandler(this.btn_precedent_Click);
            // 
            // TableauDeBord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(239)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(709, 348);
            this.Controls.Add(this.btn_precedent);
            this.Controls.Add(this.btn_mail);
            this.Controls.Add(this.lbl_lieu);
            this.Controls.Add(this.lbl_lieux);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_note);
            this.Controls.Add(this.lbl_inscrit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_nb_place);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lbl_heure_fin);
            this.Controls.Add(this.lbl_heure_debut);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.label_date);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbx_hackathon);
            this.Controls.Add(this.cbx_Evenement);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TableauDeBord";
            this.Text = "TableauDeBord";
            this.Load += new System.EventHandler(this.TableauDeBord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbx_Evenement;
        private System.Windows.Forms.ComboBox cbx_hackathon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label_date;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label lbl_heure_fin;
        private System.Windows.Forms.Label lbl_heure_debut;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbl_nb_place;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lbl_inscrit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_note;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_lieu;
        private System.Windows.Forms.Label lbl_lieux;
        private System.Windows.Forms.Button btn_mail;

        private System.Windows.Forms.Button btn_precedent;

    }
}