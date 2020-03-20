using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
namespace LakoparkProjekt {
    public partial class felulet : Form {
        private int index = 0;
        private HappyLiving hl;
        private List<Lakopark> lp;
        public felulet() {
            InitializeComponent();
            elozo.BackgroundImage = Image.FromFile("./ikonok/balnyil.jpg");
            kovetkezo.BackgroundImage = Image.FromFile("./ikonok/jobbnyil.jpg");
            hl = new HappyLiving("lakoparkok.txt");
            lp = hl.Lakoparkok;
            loadLakopark(lp[0]);
            kovetkezo.Visible = (lp.Count > index + 1);
        }
        public void loadLakopark(Lakopark lakopark) {
            switch (lakopark.Nev) {
                case "Puskás Ferenc": lakoparkNev.Image = Image.FromFile("./ikonok/puskasferenc.jpg"); break;
                case "Van Gogh": lakoparkNev.Image = Image.FromFile("./ikonok/vangogh.jpg"); break;
                case "Vivaldi": lakoparkNev.Image = Image.FromFile("./ikonok/vivaldi.jpg"); break;
                default: lakoparkNev.Image = null; break;
            }
            this.Text = lakopark.Nev;
            hazak.Controls.Clear();
            for (int i = 0; i < lakopark.UtcakSzama; i++) {
                for (int j = 0; j < lakopark.MaxHazszam; j++) {
                    var pb = new PictureBox();
                    pb.Size = new Size(50, 50);
                    pb.Location = new Point(j * 50, i * 50);
                    pb.SizeMode = PictureBoxSizeMode.Zoom;
                    switch (lakopark.Hazak[i, j]) {
                        case 1: pb.Image = Image.FromFile("./ikonok/haz1.jpg"); break;
                        case 2: pb.Image = Image.FromFile("./ikonok/haz2.jpg"); break;
                        case 3: pb.Image = Image.FromFile("./ikonok/haz3.jpg"); break;
                        default: pb.Image = Image.FromFile("./ikonok/kereszt.jpg"); break;
                    }
                    var i2 = i;
                    var j2 = j;
                    pb.Click += (s, e) => {
                        int x = lakopark.Hazak[i2, j2];
                        x = x < 3 ? x + 1 : 0;
                        lakopark.Hazak[i2, j2] = x;
                        switch (lakopark.Hazak[i2, j2]) {
                            case 1: pb.Image = Image.FromFile("./ikonok/haz1.jpg"); break;
                            case 2: pb.Image = Image.FromFile("./ikonok/haz2.jpg"); break;
                            case 3: pb.Image = Image.FromFile("./ikonok/haz3.jpg"); break;
                            default: pb.Image = Image.FromFile("./ikonok/kereszt.jpg"); break;
                        }
                    };
                    hazak.Controls.Add(pb);
                }
            }
        }

        private void elozo_Click(object sender, EventArgs e) {
            index--;
            loadLakopark(lp[index]);
            kovetkezo.Visible = (lp.Count > index + 1);
            elozo.Visible = (index > 0);
        }
        private void kovetkezo_Click(object sender, EventArgs e) {
            index++;
            loadLakopark(lp[index]);
            kovetkezo.Visible = (lp.Count > index + 1);
            elozo.Visible = (index > 0);
        }
        private void mentes_Click(object sender, EventArgs e) {
            File.Copy("lakoparkok.txt", "lakoparkok_" + DateTime.Now.ToString("yyyyMMdd_HHmm") + ".txt");
            var eredmeny = hl.Mentes("lakoparkok.txt") ? "Mentve!" : "Hiba!";
            MessageBox.Show(eredmeny);
        }
        private void statisztika_Click(object sender, EventArgs e) {
            string[] stat = new string[3];
            int lbu = hl.LakoparkBeepitettUtcaval();
            stat[0] = (lbu<0) ? "Nincs" : lp[lbu].Nev;
            stat[1] = lp[hl.LakoparkLegjobbBeepites()].Nev;
            stat[2] = hl.Bevetel().ToString("n", new NumberFormatInfo{NumberGroupSeparator=" "}).Replace(".00","");
            try {
                File.WriteAllLines("statisztika_" + DateTime.Now.ToString("yyyyMMdd_HHmm") + ".txt", stat);
                MessageBox.Show("Mentve!");
            } catch (Exception ex) {
                MessageBox.Show("Hiba!");
            }
            var sw = new statisztika();
            sw.Valasz1 = stat[0] + " lakópark";
            sw.Valasz2 = stat[1] + " lakópark";
            sw.Valasz3 = stat[2] + " Ft";
            sw.Show();
        }
    }
}
