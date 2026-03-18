using System;
using System.Windows.Forms;

namespace lab3
{
    public partial class Dodaj : Form
    {
        public string Imie { get; private set; }
        public string Nazwisko { get; private set; }
        public int Wiek { get; private set; }
        public string Stanowisko { get; private set; }

        public Dodaj()
        {
            InitializeComponent();
            cmbStanowisko.SelectedIndex = 0;
        }

        private void btnZatwierdz_Click(object sender, EventArgs e)
        {
            Imie = txtImie.Text;
            Nazwisko = txtNazwisko.Text;
            Wiek = (int)numWiek.Value;
            Stanowisko = cmbStanowisko.Text;
        }
    }
}