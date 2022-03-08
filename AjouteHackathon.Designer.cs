
namespace HackatOrgan.Forms
{
    partial class AjouteHackathon
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
            this.btn_precedent = new System.Windows.Forms.Button();
            this.btn_annuler = new System.Windows.Forms.Button();
            this.btn_valider = new System.Windows.Forms.Button();
            this.txtbx_rue = new System.Windows.Forms.TextBox();
            this.txtbx__ville = new System.Windows.Forms.TextBox();
            this.txtbx_theme = new System.Windows.Forms.TextBox();
            this.txtbx_lieu = new System.Windows.Forms.TextBox();
            this.lbl_theme = new System.Windows.Forms.Label();
            this.lbl_rue = new System.Windows.Forms.Label();
            this.lbl_lieu = new System.Windows.Forms.Label();
            this.lbl_cp = new System.Windows.Forms.Label();
            this.lbl_date_debut = new System.Windows.Forms.Label();
            this.lbl_date_fin = new System.Windows.Forms.Label();
            this.lbl_date_limite = new System.Windows.Forms.Label();
            this.lbl_nb_places = new System.Windows.Forms.Label();
            this.lbl_heure_fin = new System.Windows.Forms.Label();
            this.lbl_heure_debut = new System.Windows.Forms.Label();
            this.lbl_ville = new System.Windows.Forms.Label();
            this.txtbx_image = new System.Windows.Forms.TextBox();
            this.lbl_image = new System.Windows.Forms.Label();
            this.datepck_debut = new System.Windows.Forms.DateTimePicker();
            this.datepck_fin = new System.Windows.Forms.DateTimePicker();
            this.datepck_limite = new System.Windows.Forms.DateTimePicker();
            this.datepck_heuredebut = new System.Windows.Forms.DateTimePicker();
            this.datepck_heurefin = new System.Windows.Forms.DateTimePicker();
            this.num_places = new System.Windows.Forms.NumericUpDown();
            this.num_cp = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.num_places)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_cp)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_precedent
            // 
            this.btn_precedent.Location = new System.Drawing.Point(5, 8);
            this.btn_precedent.Name = "btn_precedent";
            this.btn_precedent.Size = new System.Drawing.Size(81, 28);
            this.btn_precedent.TabIndex = 0;
            this.btn_precedent.Text = "Précedent";
            this.btn_precedent.UseVisualStyleBackColor = true;
            this.btn_precedent.Click += new System.EventHandler(this.btn_precedent_Click);
            // 
            // btn_annuler
            // 
            this.btn_annuler.Location = new System.Drawing.Point(97, 394);
            this.btn_annuler.Name = "btn_annuler";
            this.btn_annuler.Size = new System.Drawing.Size(147, 34);
            this.btn_annuler.TabIndex = 1;
            this.btn_annuler.Text = "Annuler";
            this.btn_annuler.UseVisualStyleBackColor = true;
            this.btn_annuler.Click += new System.EventHandler(this.btn_annuler_Click);
            // 
            // btn_valider
            // 
            this.btn_valider.Location = new System.Drawing.Point(548, 394);
            this.btn_valider.Name = "btn_valider";
            this.btn_valider.Size = new System.Drawing.Size(149, 34);
            this.btn_valider.TabIndex = 2;
            this.btn_valider.Text = "Valider";
            this.btn_valider.UseVisualStyleBackColor = true;
            this.btn_valider.Click += new System.EventHandler(this.btn_valider_Click);
            // 
            // txtbx_rue
            // 
            this.txtbx_rue.Location = new System.Drawing.Point(128, 146);
            this.txtbx_rue.Name = "txtbx_rue";
            this.txtbx_rue.Size = new System.Drawing.Size(613, 23);
            this.txtbx_rue.TabIndex = 3;
            // 
            // txtbx__ville
            // 
            this.txtbx__ville.Location = new System.Drawing.Point(394, 186);
            this.txtbx__ville.Name = "txtbx__ville";
            this.txtbx__ville.Size = new System.Drawing.Size(347, 23);
            this.txtbx__ville.TabIndex = 5;
            // 
            // txtbx_theme
            // 
            this.txtbx_theme.Location = new System.Drawing.Point(128, 55);
            this.txtbx_theme.Name = "txtbx_theme";
            this.txtbx_theme.Size = new System.Drawing.Size(613, 23);
            this.txtbx_theme.TabIndex = 11;
            // 
            // txtbx_lieu
            // 
            this.txtbx_lieu.Location = new System.Drawing.Point(128, 84);
            this.txtbx_lieu.Name = "txtbx_lieu";
            this.txtbx_lieu.Size = new System.Drawing.Size(613, 23);
            this.txtbx_lieu.TabIndex = 12;
            // 
            // lbl_theme
            // 
            this.lbl_theme.AutoSize = true;
            this.lbl_theme.Location = new System.Drawing.Point(19, 63);
            this.lbl_theme.Name = "lbl_theme";
            this.lbl_theme.Size = new System.Drawing.Size(49, 15);
            this.lbl_theme.TabIndex = 19;
            this.lbl_theme.Text = "Theme :";
            // 
            // lbl_rue
            // 
            this.lbl_rue.AutoSize = true;
            this.lbl_rue.Location = new System.Drawing.Point(19, 154);
            this.lbl_rue.Name = "lbl_rue";
            this.lbl_rue.Size = new System.Drawing.Size(54, 15);
            this.lbl_rue.TabIndex = 20;
            this.lbl_rue.Text = "Adresse :";
            // 
            // lbl_lieu
            // 
            this.lbl_lieu.AutoSize = true;
            this.lbl_lieu.Location = new System.Drawing.Point(19, 92);
            this.lbl_lieu.Name = "lbl_lieu";
            this.lbl_lieu.Size = new System.Drawing.Size(35, 15);
            this.lbl_lieu.TabIndex = 21;
            this.lbl_lieu.Text = "Lieu :";
            this.lbl_lieu.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbl_cp
            // 
            this.lbl_cp.AutoSize = true;
            this.lbl_cp.Location = new System.Drawing.Point(19, 189);
            this.lbl_cp.Name = "lbl_cp";
            this.lbl_cp.Size = new System.Drawing.Size(76, 15);
            this.lbl_cp.TabIndex = 22;
            this.lbl_cp.Text = "Code Postal :";
            // 
            // lbl_date_debut
            // 
            this.lbl_date_debut.AutoSize = true;
            this.lbl_date_debut.Location = new System.Drawing.Point(19, 244);
            this.lbl_date_debut.Name = "lbl_date_debut";
            this.lbl_date_debut.Size = new System.Drawing.Size(87, 15);
            this.lbl_date_debut.TabIndex = 23;
            this.lbl_date_debut.Text = "Commence le :";
            // 
            // lbl_date_fin
            // 
            this.lbl_date_fin.AutoSize = true;
            this.lbl_date_fin.Location = new System.Drawing.Point(19, 279);
            this.lbl_date_fin.Name = "lbl_date_fin";
            this.lbl_date_fin.Size = new System.Drawing.Size(67, 15);
            this.lbl_date_fin.TabIndex = 24;
            this.lbl_date_fin.Text = "Termine le :";
            // 
            // lbl_date_limite
            // 
            this.lbl_date_limite.AutoSize = true;
            this.lbl_date_limite.Location = new System.Drawing.Point(19, 330);
            this.lbl_date_limite.Name = "lbl_date_limite";
            this.lbl_date_limite.Size = new System.Drawing.Size(139, 15);
            this.lbl_date_limite.TabIndex = 25;
            this.lbl_date_limite.Text = "Date limite d\'inscription :";
            // 
            // lbl_nb_places
            // 
            this.lbl_nb_places.AutoSize = true;
            this.lbl_nb_places.Location = new System.Drawing.Point(394, 330);
            this.lbl_nb_places.Name = "lbl_nb_places";
            this.lbl_nb_places.Size = new System.Drawing.Size(162, 15);
            this.lbl_nb_places.TabIndex = 29;
            this.lbl_nb_places.Text = "Nombre de place disponible :";
            // 
            // lbl_heure_fin
            // 
            this.lbl_heure_fin.AutoSize = true;
            this.lbl_heure_fin.Location = new System.Drawing.Point(461, 279);
            this.lbl_heure_fin.Name = "lbl_heure_fin";
            this.lbl_heure_fin.Size = new System.Drawing.Size(78, 15);
            this.lbl_heure_fin.TabIndex = 28;
            this.lbl_heure_fin.Text = "Heure de fin :";
            // 
            // lbl_heure_debut
            // 
            this.lbl_heure_debut.AutoSize = true;
            this.lbl_heure_debut.Location = new System.Drawing.Point(461, 244);
            this.lbl_heure_debut.Name = "lbl_heure_debut";
            this.lbl_heure_debut.Size = new System.Drawing.Size(95, 15);
            this.lbl_heure_debut.TabIndex = 27;
            this.lbl_heure_debut.Text = "Heure de début :";
            // 
            // lbl_ville
            // 
            this.lbl_ville.AutoSize = true;
            this.lbl_ville.Location = new System.Drawing.Point(353, 189);
            this.lbl_ville.Name = "lbl_ville";
            this.lbl_ville.Size = new System.Drawing.Size(35, 15);
            this.lbl_ville.TabIndex = 26;
            this.lbl_ville.Text = "Ville :";
            // 
            // txtbx_image
            // 
            this.txtbx_image.Location = new System.Drawing.Point(128, 365);
            this.txtbx_image.Name = "txtbx_image";
            this.txtbx_image.Size = new System.Drawing.Size(613, 23);
            this.txtbx_image.TabIndex = 30;
            this.txtbx_image.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbl_image
            // 
            this.lbl_image.AutoSize = true;
            this.lbl_image.Location = new System.Drawing.Point(19, 368);
            this.lbl_image.Name = "lbl_image";
            this.lbl_image.Size = new System.Drawing.Size(71, 15);
            this.lbl_image.TabIndex = 31;
            this.lbl_image.Text = "Lien Image :";
            this.lbl_image.Click += new System.EventHandler(this.label1_Click);
            // 
            // datepck_debut
            // 
            this.datepck_debut.Location = new System.Drawing.Point(137, 244);
            this.datepck_debut.Name = "datepck_debut";
            this.datepck_debut.Size = new System.Drawing.Size(233, 23);
            this.datepck_debut.TabIndex = 32;
            this.datepck_debut.ValueChanged += new System.EventHandler(this.datepck_debut_ValueChanged);
            // 
            // datepck_fin
            // 
            this.datepck_fin.Location = new System.Drawing.Point(137, 276);
            this.datepck_fin.Name = "datepck_fin";
            this.datepck_fin.Size = new System.Drawing.Size(233, 23);
            this.datepck_fin.TabIndex = 33;
            // 
            // datepck_limite
            // 
            this.datepck_limite.Location = new System.Drawing.Point(164, 327);
            this.datepck_limite.Name = "datepck_limite";
            this.datepck_limite.Size = new System.Drawing.Size(206, 23);
            this.datepck_limite.TabIndex = 34;
            // 
            // datepck_heuredebut
            // 
            this.datepck_heuredebut.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.datepck_heuredebut.Location = new System.Drawing.Point(625, 242);
            this.datepck_heuredebut.Name = "datepck_heuredebut";
            this.datepck_heuredebut.Size = new System.Drawing.Size(116, 23);
            this.datepck_heuredebut.TabIndex = 85;
            this.datepck_heuredebut.ValueChanged += new System.EventHandler(this.datepck_heuredebut_ValueChanged);
            // 
            // datepck_heurefin
            // 
            this.datepck_heurefin.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.datepck_heurefin.Location = new System.Drawing.Point(625, 276);
            this.datepck_heurefin.Name = "datepck_heurefin";
            this.datepck_heurefin.Size = new System.Drawing.Size(116, 23);
            this.datepck_heurefin.TabIndex = 84;
            // 
            // num_places
            // 
            this.num_places.Location = new System.Drawing.Point(621, 327);
            this.num_places.Name = "num_places";
            this.num_places.Size = new System.Drawing.Size(120, 23);
            this.num_places.TabIndex = 86;
            this.num_places.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // num_cp
            // 
            this.num_cp.Location = new System.Drawing.Point(128, 186);
            this.num_cp.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.num_cp.Name = "num_cp";
            this.num_cp.Size = new System.Drawing.Size(204, 23);
            this.num_cp.TabIndex = 87;
            // 
            // AjouteHackathon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.num_cp);
            this.Controls.Add(this.num_places);
            this.Controls.Add(this.datepck_heuredebut);
            this.Controls.Add(this.datepck_heurefin);
            this.Controls.Add(this.datepck_limite);
            this.Controls.Add(this.datepck_fin);
            this.Controls.Add(this.datepck_debut);
            this.Controls.Add(this.lbl_image);
            this.Controls.Add(this.txtbx_image);
            this.Controls.Add(this.lbl_nb_places);
            this.Controls.Add(this.lbl_heure_fin);
            this.Controls.Add(this.lbl_heure_debut);
            this.Controls.Add(this.lbl_ville);
            this.Controls.Add(this.lbl_date_limite);
            this.Controls.Add(this.lbl_date_fin);
            this.Controls.Add(this.lbl_date_debut);
            this.Controls.Add(this.lbl_cp);
            this.Controls.Add(this.lbl_lieu);
            this.Controls.Add(this.lbl_rue);
            this.Controls.Add(this.lbl_theme);
            this.Controls.Add(this.txtbx_lieu);
            this.Controls.Add(this.txtbx_theme);
            this.Controls.Add(this.txtbx__ville);
            this.Controls.Add(this.txtbx_rue);
            this.Controls.Add(this.btn_valider);
            this.Controls.Add(this.btn_annuler);
            this.Controls.Add(this.btn_precedent);
            this.Name = "AjouteHackathon";
            this.Text = "AjouteHackathon";
            this.Load += new System.EventHandler(this.AjouteHackathon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_places)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_cp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_precedent;
        private System.Windows.Forms.Button btn_annuler;
        private System.Windows.Forms.Button btn_valider;
        private System.Windows.Forms.TextBox txtbx_rue;
        private System.Windows.Forms.TextBox txtbx__ville;
        private System.Windows.Forms.TextBox txtbx_theme;
        private System.Windows.Forms.TextBox txtbx_lieu;
        private System.Windows.Forms.TextBox txtbx_heure_debut;
        private System.Windows.Forms.TextBox txtbx_heure_fin;
        private System.Windows.Forms.Label lbl_theme;
        private System.Windows.Forms.Label lbl_rue;
        private System.Windows.Forms.Label lbl_lieu;
        private System.Windows.Forms.Label lbl_cp;
        private System.Windows.Forms.Label lbl_date_debut;
        private System.Windows.Forms.Label lbl_date_fin;
        private System.Windows.Forms.Label lbl_date_limite;
        private System.Windows.Forms.Label lbl_nb_places;
        private System.Windows.Forms.Label lbl_heure_fin;
        private System.Windows.Forms.Label lbl_heure_debut;
        private System.Windows.Forms.Label lbl_ville;
        private System.Windows.Forms.TextBox txtbx_image;
        private System.Windows.Forms.Label lbl_image;
        private System.Windows.Forms.DateTimePicker datepck_debut;
        private System.Windows.Forms.DateTimePicker datepck_fin;
        private System.Windows.Forms.DateTimePicker datepck_limite;
        private System.Windows.Forms.DateTimePicker datepck_heuredebut;
        private System.Windows.Forms.DateTimePicker datepck_heurefin;
        private System.Windows.Forms.NumericUpDown num_places;
        private System.Windows.Forms.NumericUpDown num_cp;
    }
}