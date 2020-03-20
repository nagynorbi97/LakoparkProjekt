namespace LakoparkProjekt {
    public class Lakopark {
        private int[,] hazak;
        private int maxHazSzam;
        private string nev;
        private int utcakSzama;
        public int[,] Hazak {get => hazak;}
        public int MaxHazszam {get => maxHazSzam;}
        public string Nev {get => nev;}
        public int UtcakSzama {get => utcakSzama;}
        public Lakopark(string nev, int utcakSzama, int maxHazSzam, int[,] hazak) {
            this.nev = nev;
            this.utcakSzama = utcakSzama;
            this.maxHazSzam = maxHazSzam;
            this.hazak = hazak;
        }
    }
}
