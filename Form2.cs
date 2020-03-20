using System.Windows.Forms;

namespace LakoparkProjekt {
    public partial class statisztika : Form {
        public statisztika() {
            InitializeComponent();
        }
        public string Valasz1 {set => this.valasz1.Text = value;}
        public string Valasz2 { set => this.valasz2.Text = value; }
        public string Valasz3 { set => this.valasz3.Text = value; }
    }
}
