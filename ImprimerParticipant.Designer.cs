﻿
namespace HackatOrgan
{
    partial class ImprimerParticipant
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
            this.comboBox_hackathon = new System.Windows.Forms.ComboBox();
            this.lbl_hackathon = new System.Windows.Forms.Label();
            this.btn_imprimer = new System.Windows.Forms.Button();
            this.btn_precedent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox_hackathon
            // 
            this.comboBox_hackathon.FormattingEnabled = true;
            this.comboBox_hackathon.Location = new System.Drawing.Point(140, 56);
            this.comboBox_hackathon.Name = "comboBox_hackathon";
            this.comboBox_hackathon.Size = new System.Drawing.Size(171, 23);
            this.comboBox_hackathon.TabIndex = 0;
            this.comboBox_hackathon.SelectedIndexChanged += new System.EventHandler(this.comboBox_hackathon_SelectedIndexChanged);
            // 
            // lbl_hackathon
            // 
            this.lbl_hackathon.AutoSize = true;
            this.lbl_hackathon.Location = new System.Drawing.Point(34, 59);
            this.lbl_hackathon.Name = "lbl_hackathon";
            this.lbl_hackathon.Size = new System.Drawing.Size(71, 15);
            this.lbl_hackathon.TabIndex = 2;
            this.lbl_hackathon.Text = "Hackathon :";
            // 
            // btn_imprimer
            // 
            this.btn_imprimer.Location = new System.Drawing.Point(171, 117);
            this.btn_imprimer.Name = "btn_imprimer";
            this.btn_imprimer.Size = new System.Drawing.Size(75, 23);
            this.btn_imprimer.TabIndex = 3;
            this.btn_imprimer.Text = "Imprimer";
            this.btn_imprimer.UseVisualStyleBackColor = true;
            this.btn_imprimer.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_precedent
            // 
            this.btn_precedent.Location = new System.Drawing.Point(12, 12);
            this.btn_precedent.Name = "btn_precedent";
            this.btn_precedent.Size = new System.Drawing.Size(91, 35);
            this.btn_precedent.TabIndex = 50;
            this.btn_precedent.Text = "Précedent";
            this.btn_precedent.UseVisualStyleBackColor = true;
            this.btn_precedent.Click += new System.EventHandler(this.btn_precedent_Click);
            // 
            // ImprimerParticipant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 156);
            this.Controls.Add(this.btn_precedent);
            this.Controls.Add(this.btn_imprimer);
            this.Controls.Add(this.lbl_hackathon);
            this.Controls.Add(this.comboBox_hackathon);
            this.Name = "ImprimerParticipant";
            this.Text = "ImprimerParticipant";
            this.Load += new System.EventHandler(this.ImprimerParticipant_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_hackathon;
        private System.Windows.Forms.Label lbl_hackathon;
        private System.Windows.Forms.Button btn_imprimer;
        private System.Windows.Forms.Button btn_precedent;
    }
}