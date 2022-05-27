using System;
using System.Windows.Forms;

namespace Algorytm_Floyda_Warshalla
{
    public partial class Pulpit : Form
    {
        // deklaracja zmiennych reprezentujące pozostałe formularze
        ProjektNr3_Palacz53262 mpProjektNr3_Palacz = new ProjektNr3_Palacz53262();
        Algorytm_Floyda_Warshalla mpAlgorytm_Floyda_Warshalla = new Algorytm_Floyda_Warshalla();
        public Pulpit()
        {
            InitializeComponent();
        }

        private void mpBTNLab_Click(object sender, EventArgs e)
        {
            Hide(); // ukrycie bierzącego formularza
            mpAlgorytm_Floyda_Warshalla.Show();
        }

        private void mpBTNProjekt_Click(object sender, EventArgs e)
        {
            Hide(); // ukrycie bierzącego formularza
            mpProjektNr3_Palacz.Show(); // wyświetlenie formularza
        }

        private void Pulpit_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
