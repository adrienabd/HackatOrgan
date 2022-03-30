
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hackathons));
            this.btn_ajouter_hackathon = new System.Windows.Forms.Button();
            this.btn_imprimer = new System.Windows.Forms.Button();
            this.btn_ajout_evenement = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ajouter_hackathon
            // 
            this.btn_ajouter_hackathon.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_ajouter_hackathon.Location = new System.Drawing.Point(12, 12);
            this.btn_ajouter_hackathon.Name = "btn_ajouter_hackathon";
            this.btn_ajouter_hackathon.Size = new System.Drawing.Size(224, 37);
            this.btn_ajouter_hackathon.TabIndex = 0;
            this.btn_ajouter_hackathon.Text = "Ajouter un Hackathon";
            this.btn_ajouter_hackathon.UseVisualStyleBackColor = false;
            this.btn_ajouter_hackathon.Click += new System.EventHandler(this.btn_ajouter_hackathon_Click);
            // 
            // btn_imprimer
            // 
            this.btn_imprimer.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_imprimer.Location = new System.Drawing.Point(348, 12);
            this.btn_imprimer.Name = "btn_imprimer";
            this.btn_imprimer.Size = new System.Drawing.Size(224, 37);
            this.btn_imprimer.TabIndex = 5;
            this.btn_imprimer.Text = "Imprimer la liste des participants";
            this.btn_imprimer.UseVisualStyleBackColor = false;
            this.btn_imprimer.Click += new System.EventHandler(this.btn_imprimer_Click);
            // 
            // btn_ajout_evenement
            // 
            this.btn_ajout_evenement.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_ajout_evenement.Location = new System.Drawing.Point(700, 12);
            this.btn_ajout_evenement.Name = "btn_ajout_evenement";
            this.btn_ajout_evenement.Size = new System.Drawing.Size(224, 37);
            this.btn_ajout_evenement.TabIndex = 6;
            this.btn_ajout_evenement.Text = "Ajouter un Evenement";
            this.btn_ajout_evenement.UseVisualStyleBackColor = false;
            this.btn_ajout_evenement.Click += new System.EventHandler(this.btn_ajout_evenement_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(912, 353);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Hackathons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(936, 420);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_ajout_evenement);
            this.Controls.Add(this.btn_imprimer);
            this.Controls.Add(this.btn_ajouter_hackathon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Hackathons";
            this.Text = "Hackathons";
            this.Load += new System.EventHandler(this.Hackathons_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ajouter_hackathon;
        private System.Windows.Forms.Button btn_imprimer;
        private System.Windows.Forms.Button btn_ajout_evenement;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}