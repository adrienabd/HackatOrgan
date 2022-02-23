
namespace HackatOrgan.Forms
{
    partial class AjouteEvenement
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
            this.btn_valider = new System.Windows.Forms.Button();
            this.btn_annuler = new System.Windows.Forms.Button();
            this.btn_precedent = new System.Windows.Forms.Button();
            this.lbl_nb_places = new System.Windows.Forms.Label();
            this.lbl_heure_fin = new System.Windows.Forms.Label();
            this.lbl_heure_debut = new System.Windows.Forms.Label();
            this.lbl_date_limite = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_hackathon = new System.Windows.Forms.Label();
            this.lbl_theme = new System.Windows.Forms.Label();
            this.txtbx_nb_places = new System.Windows.Forms.TextBox();
            this.txtbx_date_limite = new System.Windows.Forms.TextBox();
            this.txtbx_heure_fin = new System.Windows.Forms.TextBox();
            this.txtbx_heure_debut = new System.Windows.Forms.TextBox();
            this.txtbx_date_debut = new System.Windows.Forms.TextBox();
            this.txtbx_theme = new System.Windows.Forms.TextBox();
            this.combobox_hackathon = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_valider
            // 
            this.btn_valider.Location = new System.Drawing.Point(578, 394);
            this.btn_valider.Name = "btn_valider";
            this.btn_valider.Size = new System.Drawing.Size(149, 34);
            this.btn_valider.TabIndex = 51;
            this.btn_valider.Text = "Valider";
            this.btn_valider.UseVisualStyleBackColor = true;
            // 
            // btn_annuler
            // 
            this.btn_annuler.Location = new System.Drawing.Point(73, 394);
            this.btn_annuler.Name = "btn_annuler";
            this.btn_annuler.Size = new System.Drawing.Size(147, 34);
            this.btn_annuler.TabIndex = 50;
            this.btn_annuler.Text = "Annuler";
            this.btn_annuler.UseVisualStyleBackColor = true;
            // 
            // btn_precedent
            // 
            this.btn_precedent.Location = new System.Drawing.Point(12, 12);
            this.btn_precedent.Name = "btn_precedent";
            this.btn_precedent.Size = new System.Drawing.Size(91, 35);
            this.btn_precedent.TabIndex = 49;
            this.btn_precedent.Text = "Précedent";
            this.btn_precedent.UseVisualStyleBackColor = true;
            // 
            // lbl_nb_places
            // 
            this.lbl_nb_places.AutoSize = true;
            this.lbl_nb_places.Location = new System.Drawing.Point(408, 321);
            this.lbl_nb_places.Name = "lbl_nb_places";
            this.lbl_nb_places.Size = new System.Drawing.Size(162, 15);
            this.lbl_nb_places.TabIndex = 73;
            this.lbl_nb_places.Text = "Nombre de place disponible :";
            // 
            // lbl_heure_fin
            // 
            this.lbl_heure_fin.AutoSize = true;
            this.lbl_heure_fin.Location = new System.Drawing.Point(408, 224);
            this.lbl_heure_fin.Name = "lbl_heure_fin";
            this.lbl_heure_fin.Size = new System.Drawing.Size(78, 15);
            this.lbl_heure_fin.TabIndex = 72;
            this.lbl_heure_fin.Text = "Heure de fin :";
            // 
            // lbl_heure_debut
            // 
            this.lbl_heure_debut.AutoSize = true;
            this.lbl_heure_debut.Location = new System.Drawing.Point(408, 189);
            this.lbl_heure_debut.Name = "lbl_heure_debut";
            this.lbl_heure_debut.Size = new System.Drawing.Size(95, 15);
            this.lbl_heure_debut.TabIndex = 71;
            this.lbl_heure_debut.Text = "Heure de début :";
            // 
            // lbl_date_limite
            // 
            this.lbl_date_limite.AutoSize = true;
            this.lbl_date_limite.Location = new System.Drawing.Point(33, 321);
            this.lbl_date_limite.Name = "lbl_date_limite";
            this.lbl_date_limite.Size = new System.Drawing.Size(139, 15);
            this.lbl_date_limite.TabIndex = 69;
            this.lbl_date_limite.Text = "Date limite d\'inscription :";
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Location = new System.Drawing.Point(33, 189);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(80, 15);
            this.lbl_date.TabIndex = 67;
            this.lbl_date.Text = "Se déroule le :";
            this.lbl_date.Click += new System.EventHandler(this.lbl_date_debut_Click);
            // 
            // lbl_hackathon
            // 
            this.lbl_hackathon.AutoSize = true;
            this.lbl_hackathon.Location = new System.Drawing.Point(35, 107);
            this.lbl_hackathon.Name = "lbl_hackathon";
            this.lbl_hackathon.Size = new System.Drawing.Size(71, 15);
            this.lbl_hackathon.TabIndex = 65;
            this.lbl_hackathon.Text = "Hackathon :";
            this.lbl_hackathon.Click += new System.EventHandler(this.lbl_lieu_Click);
            // 
            // lbl_theme
            // 
            this.lbl_theme.AutoSize = true;
            this.lbl_theme.Location = new System.Drawing.Point(35, 78);
            this.lbl_theme.Name = "lbl_theme";
            this.lbl_theme.Size = new System.Drawing.Size(49, 15);
            this.lbl_theme.TabIndex = 63;
            this.lbl_theme.Text = "Theme :";
            // 
            // txtbx_nb_places
            // 
            this.txtbx_nb_places.Location = new System.Drawing.Point(604, 318);
            this.txtbx_nb_places.Name = "txtbx_nb_places";
            this.txtbx_nb_places.Size = new System.Drawing.Size(151, 23);
            this.txtbx_nb_places.TabIndex = 62;
            // 
            // txtbx_date_limite
            // 
            this.txtbx_date_limite.Location = new System.Drawing.Point(195, 318);
            this.txtbx_date_limite.Name = "txtbx_date_limite";
            this.txtbx_date_limite.Size = new System.Drawing.Size(151, 23);
            this.txtbx_date_limite.TabIndex = 61;
            // 
            // txtbx_heure_fin
            // 
            this.txtbx_heure_fin.Location = new System.Drawing.Point(522, 221);
            this.txtbx_heure_fin.Name = "txtbx_heure_fin";
            this.txtbx_heure_fin.Size = new System.Drawing.Size(233, 23);
            this.txtbx_heure_fin.TabIndex = 60;
            // 
            // txtbx_heure_debut
            // 
            this.txtbx_heure_debut.Location = new System.Drawing.Point(522, 189);
            this.txtbx_heure_debut.Name = "txtbx_heure_debut";
            this.txtbx_heure_debut.Size = new System.Drawing.Size(233, 23);
            this.txtbx_heure_debut.TabIndex = 58;
            // 
            // txtbx_date_debut
            // 
            this.txtbx_date_debut.Location = new System.Drawing.Point(142, 189);
            this.txtbx_date_debut.Name = "txtbx_date_debut";
            this.txtbx_date_debut.Size = new System.Drawing.Size(233, 23);
            this.txtbx_date_debut.TabIndex = 57;
            // 
            // txtbx_theme
            // 
            this.txtbx_theme.Location = new System.Drawing.Point(181, 70);
            this.txtbx_theme.Name = "txtbx_theme";
            this.txtbx_theme.Size = new System.Drawing.Size(411, 23);
            this.txtbx_theme.TabIndex = 55;
            // 
            // combobox_hackathon
            // 
            this.combobox_hackathon.FormattingEnabled = true;
            this.combobox_hackathon.Location = new System.Drawing.Point(181, 104);
            this.combobox_hackathon.Name = "combobox_hackathon";
            this.combobox_hackathon.Size = new System.Drawing.Size(411, 23);
            this.combobox_hackathon.TabIndex = 74;
            this.combobox_hackathon.SelectedIndexChanged += new System.EventHandler(this.combobox_hackathon_SelectedIndexChanged);
            // 
            // AjouteEvenement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.combobox_hackathon);
            this.Controls.Add(this.lbl_nb_places);
            this.Controls.Add(this.lbl_heure_fin);
            this.Controls.Add(this.lbl_heure_debut);
            this.Controls.Add(this.lbl_date_limite);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.lbl_hackathon);
            this.Controls.Add(this.lbl_theme);
            this.Controls.Add(this.txtbx_nb_places);
            this.Controls.Add(this.txtbx_date_limite);
            this.Controls.Add(this.txtbx_heure_fin);
            this.Controls.Add(this.txtbx_heure_debut);
            this.Controls.Add(this.txtbx_date_debut);
            this.Controls.Add(this.txtbx_theme);
            this.Controls.Add(this.btn_valider);
            this.Controls.Add(this.btn_annuler);
            this.Controls.Add(this.btn_precedent);
            this.Name = "AjouteEvenement";
            this.Text = "AjouteEvenement";
            this.Load += new System.EventHandler(this.AjouteEvenement_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_valider;
        private System.Windows.Forms.Button btn_annuler;
        private System.Windows.Forms.Button btn_precedent;
        private System.Windows.Forms.Label lbl_nb_places;
        private System.Windows.Forms.Label lbl_heure_fin;
        private System.Windows.Forms.Label lbl_heure_debut;
        private System.Windows.Forms.Label lbl_date_limite;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label lbl_hackathon;
        private System.Windows.Forms.Label lbl_theme;
        private System.Windows.Forms.TextBox txtbx_nb_places;
        private System.Windows.Forms.TextBox txtbx_date_limite;
        private System.Windows.Forms.TextBox txtbx_heure_fin;
        private System.Windows.Forms.TextBox txtbx_heure_debut;
        private System.Windows.Forms.TextBox txtbx_date_debut;
        private System.Windows.Forms.TextBox txtbx_theme;
        private System.Windows.Forms.ComboBox combobox_hackathon;
    }
}