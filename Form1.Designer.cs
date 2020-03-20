namespace LakoparkProjekt {
    partial class felulet {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.hazak = new System.Windows.Forms.Panel();
            this.kovetkezo = new System.Windows.Forms.Button();
            this.elozo = new System.Windows.Forms.Button();
            this.lakoparkNev = new System.Windows.Forms.PictureBox();
            this.mentes = new System.Windows.Forms.Button();
            this.statisztika = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lakoparkNev)).BeginInit();
            this.SuspendLayout();
            // 
            // hazak
            // 
            this.hazak.BackColor = System.Drawing.Color.White;
            this.hazak.Location = new System.Drawing.Point(132, 15);
            this.hazak.Name = "hazak";
            this.hazak.Size = new System.Drawing.Size(500, 250);
            this.hazak.TabIndex = 1;
            // 
            // kovetkezo
            // 
            this.kovetkezo.BackColor = System.Drawing.SystemColors.Control;
            this.kovetkezo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.kovetkezo.FlatAppearance.BorderSize = 0;
            this.kovetkezo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kovetkezo.Location = new System.Drawing.Point(410, 287);
            this.kovetkezo.Name = "kovetkezo";
            this.kovetkezo.Size = new System.Drawing.Size(59, 40);
            this.kovetkezo.TabIndex = 3;
            this.kovetkezo.UseVisualStyleBackColor = false;
            this.kovetkezo.Visible = false;
            this.kovetkezo.Click += new System.EventHandler(this.kovetkezo_Click);
            // 
            // elozo
            // 
            this.elozo.BackColor = System.Drawing.SystemColors.Control;
            this.elozo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.elozo.FlatAppearance.BorderSize = 0;
            this.elozo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.elozo.Location = new System.Drawing.Point(294, 287);
            this.elozo.Name = "elozo";
            this.elozo.Size = new System.Drawing.Size(58, 40);
            this.elozo.TabIndex = 2;
            this.elozo.UseVisualStyleBackColor = false;
            this.elozo.Visible = false;
            this.elozo.Click += new System.EventHandler(this.elozo_Click);
            // 
            // lakoparkNev
            // 
            this.lakoparkNev.Location = new System.Drawing.Point(15, 15);
            this.lakoparkNev.Name = "lakoparkNev";
            this.lakoparkNev.Size = new System.Drawing.Size(100, 132);
            this.lakoparkNev.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.lakoparkNev.TabIndex = 0;
            this.lakoparkNev.TabStop = false;
            // 
            // mentes
            // 
            this.mentes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.mentes.Location = new System.Drawing.Point(28, 213);
            this.mentes.Name = "mentes";
            this.mentes.Size = new System.Drawing.Size(75, 23);
            this.mentes.TabIndex = 4;
            this.mentes.Text = "Mentés";
            this.mentes.UseVisualStyleBackColor = true;
            this.mentes.Click += new System.EventHandler(this.mentes_Click);
            // 
            // statisztika
            // 
            this.statisztika.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.statisztika.Location = new System.Drawing.Point(28, 242);
            this.statisztika.Name = "statisztika";
            this.statisztika.Size = new System.Drawing.Size(75, 23);
            this.statisztika.TabIndex = 5;
            this.statisztika.Text = "Statisztika";
            this.statisztika.UseVisualStyleBackColor = true;
            this.statisztika.Click += new System.EventHandler(this.statisztika_Click);
            // 
            // felulet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(648, 339);
            this.Controls.Add(this.statisztika);
            this.Controls.Add(this.mentes);
            this.Controls.Add(this.kovetkezo);
            this.Controls.Add(this.elozo);
            this.Controls.Add(this.hazak);
            this.Controls.Add(this.lakoparkNev);
            this.Name = "felulet";
            this.Text = "Lakóparkok";
            ((System.ComponentModel.ISupportInitialize)(this.lakoparkNev)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox lakoparkNev;
        private System.Windows.Forms.Panel hazak;
        private System.Windows.Forms.Button elozo;
        private System.Windows.Forms.Button kovetkezo;
        private System.Windows.Forms.Button mentes;
        private System.Windows.Forms.Button statisztika;
    }
}

