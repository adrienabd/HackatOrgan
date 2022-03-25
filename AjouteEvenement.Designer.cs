
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AjouteEvenement));
            this.btn_valider = new System.Windows.Forms.Button();
            this.btn_annuler = new System.Windows.Forms.Button();
            this.btn_precedent = new System.Windows.Forms.Button();
            this.lbl_heure_fin = new System.Windows.Forms.Label();
            this.lbl_heure_debut = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_hackathon = new System.Windows.Forms.Label();
            this.lbl_theme = new System.Windows.Forms.Label();
            this.txtbx_theme = new System.Windows.Forms.TextBox();
            this.combobox_hackathon = new System.Windows.Forms.ComboBox();
            this.lbl_type = new System.Windows.Forms.Label();
            this.datepck_date = new System.Windows.Forms.DateTimePicker();
            this.btnradio_conference = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnradio_atelier = new System.Windows.Forms.RadioButton();
            this.datepck_fin = new System.Windows.Forms.DateTimePicker();
            this.datepck_debut = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_valider
            // 
            this.btn_valider.BackColor = System.Drawing.Color.Yellow;
            this.btn_valider.Location = new System.Drawing.Point(380, 261);
            this.btn_valider.Name = "btn_valider";
            this.btn_valider.Size = new System.Drawing.Size(149, 34);
            this.btn_valider.TabIndex = 51;
            this.btn_valider.Text = "Valider";
            this.btn_valider.UseVisualStyleBackColor = false;
            this.btn_valider.Click += new System.EventHandler(this.btn_valider_Click);
            // 
            // btn_annuler
            // 
            this.btn_annuler.BackColor = System.Drawing.Color.Yellow;
            this.btn_annuler.Location = new System.Drawing.Point(15, 261);
            this.btn_annuler.Name = "btn_annuler";
            this.btn_annuler.Size = new System.Drawing.Size(147, 34);
            this.btn_annuler.TabIndex = 50;
            this.btn_annuler.Text = "Annuler";
            this.btn_annuler.UseVisualStyleBackColor = false;
            this.btn_annuler.Click += new System.EventHandler(this.btn_annuler_Click);
            // 
            // btn_precedent
            // 
            this.btn_precedent.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_precedent.Location = new System.Drawing.Point(15, 12);
            this.btn_precedent.Name = "btn_precedent";
            this.btn_precedent.Size = new System.Drawing.Size(147, 35);
            this.btn_precedent.TabIndex = 49;
            this.btn_precedent.Text = "Précedent";
            this.btn_precedent.UseVisualStyleBackColor = false;
            this.btn_precedent.Click += new System.EventHandler(this.btn_precedent_Click);
            // 
            // lbl_heure_fin
            // 
            this.lbl_heure_fin.AutoSize = true;
            this.lbl_heure_fin.Location = new System.Drawing.Point(307, 227);
            this.lbl_heure_fin.Name = "lbl_heure_fin";
            this.lbl_heure_fin.Size = new System.Drawing.Size(78, 15);
            this.lbl_heure_fin.TabIndex = 72;
            this.lbl_heure_fin.Text = "Heure de fin :";
            // 
            // lbl_heure_debut
            // 
            this.lbl_heure_debut.AutoSize = true;
            this.lbl_heure_debut.Location = new System.Drawing.Point(15, 227);
            this.lbl_heure_debut.Name = "lbl_heure_debut";
            this.lbl_heure_debut.Size = new System.Drawing.Size(95, 15);
            this.lbl_heure_debut.TabIndex = 71;
            this.lbl_heure_debut.Text = "Heure de début :";
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Location = new System.Drawing.Point(15, 188);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(80, 15);
            this.lbl_date.TabIndex = 67;
            this.lbl_date.Text = "Se déroule le :";
            this.lbl_date.Click += new System.EventHandler(this.lbl_date_debut_Click);
            // 
            // lbl_hackathon
            // 
            this.lbl_hackathon.AutoSize = true;
            this.lbl_hackathon.Location = new System.Drawing.Point(15, 104);
            this.lbl_hackathon.Name = "lbl_hackathon";
            this.lbl_hackathon.Size = new System.Drawing.Size(71, 15);
            this.lbl_hackathon.TabIndex = 65;
            this.lbl_hackathon.Text = "Hackathon :";
            this.lbl_hackathon.Click += new System.EventHandler(this.lbl_lieu_Click);
            // 
            // lbl_theme
            // 
            this.lbl_theme.AutoSize = true;
            this.lbl_theme.Location = new System.Drawing.Point(12, 70);
            this.lbl_theme.Name = "lbl_theme";
            this.lbl_theme.Size = new System.Drawing.Size(49, 15);
            this.lbl_theme.TabIndex = 63;
            this.lbl_theme.Text = "Theme :";
            // 
            // txtbx_theme
            // 
            this.txtbx_theme.Location = new System.Drawing.Point(118, 67);
            this.txtbx_theme.Name = "txtbx_theme";
            this.txtbx_theme.Size = new System.Drawing.Size(411, 23);
            this.txtbx_theme.TabIndex = 55;
            // 
            // combobox_hackathon
            // 
            this.combobox_hackathon.FormattingEnabled = true;
            this.combobox_hackathon.Location = new System.Drawing.Point(118, 101);
            this.combobox_hackathon.Name = "combobox_hackathon";
            this.combobox_hackathon.Size = new System.Drawing.Size(411, 23);
            this.combobox_hackathon.TabIndex = 74;
            this.combobox_hackathon.SelectedIndexChanged += new System.EventHandler(this.combobox_hackathon_SelectedIndexChanged);
            // 
            // lbl_type
            // 
            this.lbl_type.AutoSize = true;
            this.lbl_type.Location = new System.Drawing.Point(15, 142);
            this.lbl_type.Name = "lbl_type";
            this.lbl_type.Size = new System.Drawing.Size(40, 15);
            this.lbl_type.TabIndex = 75;
            this.lbl_type.Text = "Type  :";
            // 
            // datepck_date
            // 
            this.datepck_date.Location = new System.Drawing.Point(118, 182);
            this.datepck_date.Name = "datepck_date";
            this.datepck_date.Size = new System.Drawing.Size(173, 23);
            this.datepck_date.TabIndex = 78;
            // 
            // btnradio_conference
            // 
            this.btnradio_conference.AutoSize = true;
            this.btnradio_conference.Location = new System.Drawing.Point(12, 12);
            this.btnradio_conference.Name = "btnradio_conference";
            this.btnradio_conference.Size = new System.Drawing.Size(86, 19);
            this.btnradio_conference.TabIndex = 79;
            this.btnradio_conference.TabStop = true;
            this.btnradio_conference.Text = "Conférence";
            this.btnradio_conference.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnradio_atelier);
            this.groupBox1.Controls.Add(this.btnradio_conference);
            this.groupBox1.Location = new System.Drawing.Point(118, 130);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 42);
            this.groupBox1.TabIndex = 80;
            this.groupBox1.TabStop = false;
            // 
            // btnradio_atelier
            // 
            this.btnradio_atelier.AutoSize = true;
            this.btnradio_atelier.Location = new System.Drawing.Point(159, 12);
            this.btnradio_atelier.Name = "btnradio_atelier";
            this.btnradio_atelier.Size = new System.Drawing.Size(119, 19);
            this.btnradio_atelier.TabIndex = 80;
            this.btnradio_atelier.TabStop = true;
            this.btnradio_atelier.Text = "Atelier d\'Initiation";
            this.btnradio_atelier.UseVisualStyleBackColor = true;
            this.btnradio_atelier.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // datepck_fin
            // 
            this.datepck_fin.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.datepck_fin.Location = new System.Drawing.Point(413, 219);
            this.datepck_fin.Name = "datepck_fin";
            this.datepck_fin.Size = new System.Drawing.Size(116, 23);
            this.datepck_fin.TabIndex = 82;
            // 
            // datepck_debut
            // 
            this.datepck_debut.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.datepck_debut.Location = new System.Drawing.Point(118, 221);
            this.datepck_debut.Name = "datepck_debut";
            this.datepck_debut.Size = new System.Drawing.Size(173, 23);
            this.datepck_debut.TabIndex = 83;
            // 
            // AjouteEvenement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 307);
            this.Controls.Add(this.datepck_debut);
            this.Controls.Add(this.datepck_fin);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.datepck_date);
            this.Controls.Add(this.lbl_type);
            this.Controls.Add(this.combobox_hackathon);
            this.Controls.Add(this.lbl_heure_fin);
            this.Controls.Add(this.lbl_heure_debut);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.lbl_hackathon);
            this.Controls.Add(this.lbl_theme);
            this.Controls.Add(this.txtbx_theme);
            this.Controls.Add(this.btn_valider);
            this.Controls.Add(this.btn_annuler);
            this.Controls.Add(this.btn_precedent);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AjouteEvenement";
            this.Text = "AjouteEvenement";
            this.Load += new System.EventHandler(this.AjouteEvenement_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_valider;
        private System.Windows.Forms.Button btn_annuler;
        private System.Windows.Forms.Button btn_precedent;
        private System.Windows.Forms.Label lbl_heure_fin;
        private System.Windows.Forms.Label lbl_heure_debut;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label lbl_hackathon;
        private System.Windows.Forms.Label lbl_theme;
        private System.Windows.Forms.TextBox txtbx_heure_fin;
        private System.Windows.Forms.TextBox txtbx_heure_debut;
        private System.Windows.Forms.TextBox txtbx_theme;
        private System.Windows.Forms.ComboBox combobox_hackathon;
        private System.Windows.Forms.Label lbl_type;
        private System.Windows.Forms.DateTimePicker datepck_date;
        private System.Windows.Forms.RadioButton btnradio_conference;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton btnradio_atelier;
        private System.Windows.Forms.DateTimePicker datepck_fin;
        private System.Windows.Forms.DateTimePicker datepck_debut;
    }
}