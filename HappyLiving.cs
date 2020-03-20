using System;
using System.Collections.Generic;
using System.IO;
namespace LakoparkProjekt {
    public class HappyLiving {
        private List<Lakopark> lakoparkok;
        public List<Lakopark> Lakoparkok {get => lakoparkok;}
        public HappyLiving(string filenev) {
            var adatok = File.ReadAllLines(filenev);
            var lakoparkok_mind = String.Join("\n", adatok);
            var lakoparkok_adatai = lakoparkok_mind.Split(new string[] { "\n\n" }, StringSplitOptions.None);
            this.lakoparkok = new List<Lakopark>();
            foreach(var lakopark in lakoparkok_adatai) {
                var lakopark_info = lakopark;
                var lakopark_adatok = lakopark_info.Split('\n');
                var nev = lakopark_adatok[0];
                var utcakSzama = int.Parse(lakopark_adatok[1].Split(';')[0]);
                var maxHazSzam = int.Parse(lakopark_adatok[1].Split(';')[1]);
                var hazak = new int[utcakSzama,maxHazSzam];
                for (int i = 2; i < lakopark_adatok.Length; i++) {
                    if (lakopark_adatok[i]!=null && lakopark_adatok[i].Length > 0) {
                        var haz_adatok = lakopark_adatok[i].Split(';');
                        hazak[int.Parse(haz_adatok[0])-1, int.Parse(haz_adatok[1])-1] = int.Parse(haz_adatok[2]);
                    }
                }
                var lp = new Lakopark(nev, utcakSzama, maxHazSzam, hazak);
                this.lakoparkok.Add(lp);
            }
        }
        public bool Mentes(string filenev) {
            var adatok = new List<string>();
            foreach(var lakopark in this.lakoparkok) {
                adatok.Add(lakopark.Nev);
                adatok.Add(String.Format("{0};{1}", lakopark.UtcakSzama, lakopark.MaxHazszam));
                for(int i = 0; i < lakopark.UtcakSzama; i++) {
                    for(int j = 0; j < lakopark.MaxHazszam; j++) {
                        if (lakopark.Hazak[i, j] > 0) {
                            adatok.Add(String.Format("{0};{1};{2}", i + 1, j + 1, lakopark.Hazak[i, j]));
                        }
                    }
                }
                adatok.Add("");
            }
            try {
                File.WriteAllLines(filenev, adatok);
                return true;
            } catch(Exception e) {
                return true;
            }
        }
        public int LakoparkBeepitettUtcaval() {
            int er = -1;
            for(int l = 0; l < lakoparkok.Count; l++) {
                var lakopark = lakoparkok[l];
                for (int i = 0; i < lakopark.UtcakSzama; i++) {
                    int db = 0;
                    for (int j = 0; j < lakopark.MaxHazszam; j++) {
                        if (lakopark.Hazak[i, j] > 0) {
                            db++;
                        }
                    }
                    if (er < 0 && db == lakopark.MaxHazszam) {
                        er = l;
                        break;
                    }
                }
            }
            return er;
        }
        public int LakoparkLegjobbBeepites() {
            int eri = -1;
            double era = 0;
            for (int l = 0; l < lakoparkok.Count; l++) {
                var lakopark = lakoparkok[l];
                double max = lakopark.UtcakSzama * lakopark.MaxHazszam * 1.0;
                int db = 0;
                for (int i = 0; i < lakopark.UtcakSzama; i++) {
                    for (int j = 0; j < lakopark.MaxHazszam; j++) {
                        if (lakopark.Hazak[i, j] > 0) {
                            db++;
                        }
                    }
                }
                double a = db / max * 100.0;
                if (era < a) {
                    era = a;
                    eri = l;
                }
            }
            return eri;
        }
        public long Bevetel() {
            long o = 0;
            for (int l = 0; l < lakoparkok.Count; l++) {
                var lakopark = lakoparkok[l];
                for (int i = 0; i < lakopark.UtcakSzama; i++) {
                    for (int j = 0; j < lakopark.MaxHazszam; j++) {
                        switch(lakopark.Hazak[i, j]) {
                            case 1: o += 80; break;
                            case 2: o += 80+70; break;
                            case 3: o += 80+70+50; break;
                            default: break;
                        }
                    }
                }
            }
            return o*300000;
        }
    }
}
