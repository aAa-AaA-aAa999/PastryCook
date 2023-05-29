
namespace PastryCook
{
    partial class FormAI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAI));
            this.Nasadki = new System.Windows.Forms.Label();
            this.NasadkiPhoto = new System.Windows.Forms.PictureBox();
            this.Krasiteli = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NasadkiPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // Nasadki
            // 
            this.Nasadki.AutoSize = true;
            this.Nasadki.Font = new System.Drawing.Font("Times New Roman", 25F);
            this.Nasadki.ForeColor = System.Drawing.Color.Orchid;
            this.Nasadki.Location = new System.Drawing.Point(488, 9);
            this.Nasadki.Name = "Nasadki";
            this.Nasadki.Size = new System.Drawing.Size(169, 48);
            this.Nasadki.TabIndex = 0;
            this.Nasadki.Text = "Насадки";
            // 
            // NasadkiPhoto
            // 
            this.NasadkiPhoto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("NasadkiPhoto.BackgroundImage")));
            this.NasadkiPhoto.InitialImage = ((System.Drawing.Image)(resources.GetObject("NasadkiPhoto.InitialImage")));
            this.NasadkiPhoto.Location = new System.Drawing.Point(1, 70);
            this.NasadkiPhoto.Name = "NasadkiPhoto";
            this.NasadkiPhoto.Size = new System.Drawing.Size(1291, 1200);
            this.NasadkiPhoto.TabIndex = 1;
            this.NasadkiPhoto.TabStop = false;
            this.NasadkiPhoto.Click += new System.EventHandler(this.NasadkiPhoto_Click);
            // 
            // Krasiteli
            // 
            this.Krasiteli.AutoSize = true;
            this.Krasiteli.Font = new System.Drawing.Font("Times New Roman", 25F);
            this.Krasiteli.ForeColor = System.Drawing.Color.Orchid;
            this.Krasiteli.Location = new System.Drawing.Point(1861, 11);
            this.Krasiteli.Name = "Krasiteli";
            this.Krasiteli.Size = new System.Drawing.Size(207, 48);
            this.Krasiteli.TabIndex = 2;
            this.Krasiteli.Text = "Красители";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(1293, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1209, 1332);
            this.label1.TabIndex = 3;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FormAI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1382, 527);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Krasiteli);
            this.Controls.Add(this.Nasadki);
            this.Controls.Add(this.NasadkiPhoto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAI";
            this.Text = "Дополнительная информация";
            ((System.ComponentModel.ISupportInitialize)(this.NasadkiPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Nasadki;
        private System.Windows.Forms.PictureBox NasadkiPhoto;
        private System.Windows.Forms.Label Krasiteli;
        private System.Windows.Forms.Label label1;
    }
}