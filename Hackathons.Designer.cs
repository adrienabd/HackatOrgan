﻿
namespace HackatOrgan.Forms
{
    partial class Hackathons
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
            this.btn_ajouter_hackathon = new System.Windows.Forms.Button();
            this.btn_imprimer = new System.Windows.Forms.Button();
            this.btn_ajout_evenement = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_ajouter_hackathon
            // 
            this.btn_ajouter_hackathon.Location = new System.Drawing.Point(12, 12);
            this.btn_ajouter_hackathon.Name = "btn_ajouter_hackathon";
            this.btn_ajouter_hackathon.Size = new System.Drawing.Size(224, 57);
            this.btn_ajouter_hackathon.TabIndex = 0;
            this.btn_ajouter_hackathon.Text = "Ajouter un Hackathon";
            this.btn_ajouter_hackathon.UseVisualStyleBackColor = true;
            this.btn_ajouter_hackathon.Click += new System.EventHandler(this.btn_ajouter_hackathon_Click);
            // 
            // btn_imprimer
            // 
            this.btn_imprimer.Location = new System.Drawing.Point(12, 75);
            this.btn_imprimer.Name = "btn_imprimer";
            this.btn_imprimer.Size = new System.Drawing.Size(224, 37);
            this.btn_imprimer.TabIndex = 5;
            this.btn_imprimer.Text = "Imprimer la liste des participants";
            this.btn_imprimer.UseVisualStyleBackColor = true;
            this.btn_imprimer.Click += new System.EventHandler(this.btn_imprimer_Click);
            // 
            // btn_ajout_evenement
            // 
            this.btn_ajout_evenement.Location = new System.Drawing.Point(12, 118);
            this.btn_ajout_evenement.Name = "btn_ajout_evenement";
            this.btn_ajout_evenement.Size = new System.Drawing.Size(224, 52);
            this.btn_ajout_evenement.TabIndex = 6;
            this.btn_ajout_evenement.Text = "Ajouter un Evenement";
            this.btn_ajout_evenement.UseVisualStyleBackColor = true;
            this.btn_ajout_evenement.Click += new System.EventHandler(this.btn_ajout_evenement_Click);
            // 
            // Hackathons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 180);
            this.Controls.Add(this.btn_ajout_evenement);
            this.Controls.Add(this.btn_imprimer);
            this.Controls.Add(this.btn_ajouter_hackathon);
            this.Name = "Hackathons";
            this.Text = "Hackathons";
            this.Load += new System.EventHandler(this.Hackathons_Load_1);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ajouter_hackathon;
        private System.Windows.Forms.Button btn_imprimer;
        private System.Windows.Forms.Button btn_ajout_evenement;
    }
}