namespace LakoparkProjekt {
    partial class statisztika {
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
            this.kerdes1 = new System.Windows.Forms.Label();
            this.kerdes2 = new System.Windows.Forms.Label();
            this.kerdes3 = new System.Windows.Forms.Label();
            this.valasz1 = new System.Windows.Forms.Label();
            this.valasz2 = new System.Windows.Forms.Label();
            this.valasz3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // kerdes1
            // 
            this.kerdes1.AutoSize = true;
            this.kerdes1.BackColor = System.Drawing.SystemColors.Control;
            this.kerdes1.Location = new System.Drawing.Point(13, 13);
            this.kerdes1.Name = "kerdes1";
            this.kerdes1.Size = new System.Drawing.Size(285, 13);
            this.kerdes1.TabIndex = 0;
            this.kerdes1.Text = "Van olyan lakópark, amelyben van teljesen beépített utca?";
            // 
            // kerdes2
            // 
            this.kerdes2.AutoSize = true;
            this.kerdes2.BackColor = System.Drawing.SystemColors.Control;
            this.kerdes2.Location = new System.Drawing.Point(13, 57);
            this.kerdes2.Name = "kerdes2";
            this.kerdes2.Size = new System.Drawing.Size(246, 13);
            this.kerdes2.TabIndex = 2;
            this.kerdes2.Text = "Arányaiban melyik a legjobban beépített lakópark?";
            // 
            // kerdes3
            // 
            this.kerdes3.AutoSize = true;
            this.kerdes3.BackColor = System.Drawing.SystemColors.Control;
            this.kerdes3.Location = new System.Drawing.Point(13, 101);
            this.kerdes3.Name = "kerdes3";
            this.kerdes3.Size = new System.Drawing.Size(159, 13);
            this.kerdes3.TabIndex = 3;
            this.kerdes3.Text = "Mennyi bevétele volt a cégnek?";
            // 
            // valasz1
            // 
            this.valasz1.AutoSize = true;
            this.valasz1.BackColor = System.Drawing.SystemColors.Control;
            this.valasz1.Location = new System.Drawing.Point(13, 35);
            this.valasz1.Name = "valasz1";
            this.valasz1.Size = new System.Drawing.Size(55, 13);
            this.valasz1.TabIndex = 4;
            this.valasz1.Text = "Ismeretlen";
            // 
            // valasz2
            // 
            this.valasz2.AutoSize = true;
            this.valasz2.BackColor = System.Drawing.SystemColors.Control;
            this.valasz2.Location = new System.Drawing.Point(13, 79);
            this.valasz2.Name = "valasz2";
            this.valasz2.Size = new System.Drawing.Size(55, 13);
            this.valasz2.TabIndex = 5;
            this.valasz2.Text = "Ismeretlen";
            // 
            // valasz3
            // 
            this.valasz3.AutoSize = true;
            this.valasz3.BackColor = System.Drawing.SystemColors.Control;
            this.valasz3.Location = new System.Drawing.Point(13, 123);
            this.valasz3.Name = "valasz3";
            this.valasz3.Size = new System.Drawing.Size(55, 13);
            this.valasz3.TabIndex = 6;
            this.valasz3.Text = "Ismeretlen";
            // 
            // statisztika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 153);
            this.Controls.Add(this.valasz3);
            this.Controls.Add(this.valasz2);
            this.Controls.Add(this.valasz1);
            this.Controls.Add(this.kerdes3);
            this.Controls.Add(this.kerdes2);
            this.Controls.Add(this.kerdes1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "statisztika";
            this.Text = "HappyLiving Statisztika";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label kerdes1;
        private System.Windows.Forms.Label kerdes2;
        private System.Windows.Forms.Label kerdes3;
        private System.Windows.Forms.Label valasz1;
        private System.Windows.Forms.Label valasz2;
        private System.Windows.Forms.Label valasz3;
    }
}