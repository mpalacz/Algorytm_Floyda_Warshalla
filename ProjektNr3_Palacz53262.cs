using System;
using System.Windows.Forms;

namespace Algorytm_Floyda_Warshalla
{
    public partial class ProjektNr3_Palacz53262 : Form
    {
        const ushort mpIloscWierzcholkow = 5; // ilość wierzchołków
        // lista sąsiedztwa z wagami opierająca się na przykładowym grafie z laboratoriów
        static int[,] mpListaSasiedztwa =
        {
                {0, 3, 3},
                {1, 0, 3},
                {1, 2, 4},
                {1, 3, 1},
                {2, 1, 1},
                {2, 3, 2},
                {3, 0, 3},
                {3, 1, 5},
                {3, 4, 2},
                {4, 2, 1}
        };
        static int[] mpKosztyPrzejscia = new int[mpIloscWierzcholkow]; // tablica kosztów przejścia między wierzchołkami
        static int[] mpPoprzednieWierzcholki = new int[mpIloscWierzcholkow]; // tablica poprzednich wierzchołków przez które "przechodził" algorytm
        static bool[] mpCzyPrzeliczoneWierzcholki = new bool[mpIloscWierzcholkow]; // tablica przechowuje informacje które wierzchołki zostały przeliczone

        public ProjektNr3_Palacz53262()
        {
            InitializeComponent();
        }

        // obsługa zamkcięcia aplikacji przy zamknięciu okna
        private void ProjektNr3_Palacz53262_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        // obsługa porzycisku wyświetlającego przykładową macierz wag
        private void mpBTNPrzykladowaListaSasiedztwa_Click(object sender, EventArgs e)
        {
            // sformatowanie kontrolek DataGridView
            mpDGVListaSasiedztwa.ColumnCount = mpIloscWierzcholkow;
            // dodanie wierszy do mpDGVListaSasiedztwa
            for (ushort mpI = 0; mpI < mpListaSasiedztwa.GetLength(0); mpI++)
                mpDGVListaSasiedztwa.Rows.Add();

            // wypełnienie kontrolki mpDGVListaSasiedztwa
            for (ushort mpI = 0; mpI < mpListaSasiedztwa.GetLength(0); mpI++)
                for (ushort mpJ = 0; mpJ < mpListaSasiedztwa.GetLength(1); mpJ++)
                    mpDGVListaSasiedztwa.Rows[mpI].Cells[mpJ].Value = mpListaSasiedztwa[mpI, mpJ];

            mpDGVListaSasiedztwa.Visible = true; // wyświetlenie kontrolki mpDGVMacierzWag
            mpBTNPrzykladowaListaSasiedztwa.Enabled = false; // zabokowanie przycisku mpBTNPrzykladowaMacierzWag
            mpBTNWyznaczSciezkiWGrafie.Enabled = true; // odblokowanie przycisku 
        }

        // obsługa przycisku wyznacząjącego najkrósze ścieżki w grafie za pomocą Algorytmu Dijkstry
        private void mpBTNWyznaczSciezkiWGrafie_Click(object sender, EventArgs e)
        {
            // wstawienie wartośc początkowych do tablic 
            for (ushort mpI = 0; mpI < mpIloscWierzcholkow; mpI++)
            {
                mpKosztyPrzejscia[mpI] = int.MaxValue;
                mpPoprzednieWierzcholki[mpI] = -1;
                mpCzyPrzeliczoneWierzcholki[mpI] = false;
            }
            mpKosztyPrzejscia[0] = 0;

            // algorytm Dijkstry
            ushort mpJ, mpL; // zmienne pomocnicze
            // iterowanie tyle razy ile jest wierzchołków w grafie
            for (ushort mpI = 0; mpI < mpIloscWierzcholkow; mpI++)
            {
                // szukanie wierzchołka o najniższym koszcie
                for (mpJ = 0; mpCzyPrzeliczoneWierzcholki[mpJ]; mpJ++) ;
                for (mpL = mpJ++; mpJ < mpIloscWierzcholkow; mpJ++)
                    if (!mpCzyPrzeliczoneWierzcholki[mpJ] && mpKosztyPrzejscia[mpJ] < mpKosztyPrzejscia[mpL])
                        mpL = mpJ;

                // zapisanie że z znalezionego wierzchołka został (a właściwie zostanie) wykonany przeskok
                mpCzyPrzeliczoneWierzcholki[mpL] = true;

                // zapisanie danych przeskoku
                for (mpJ = 0; mpJ < mpListaSasiedztwa.GetLength(0); mpJ++)
                    if (!mpCzyPrzeliczoneWierzcholki[mpListaSasiedztwa[mpJ, 1]] 
                        && mpKosztyPrzejscia[mpListaSasiedztwa[mpJ, 1]] > mpKosztyPrzejscia[mpL] + mpListaSasiedztwa[mpJ, 2]
                        && mpListaSasiedztwa[mpJ, 0] == mpL)
                    {
                        mpKosztyPrzejscia[mpListaSasiedztwa[mpJ, 1]] = mpKosztyPrzejscia[mpL] + mpListaSasiedztwa[mpJ, 2];
                        mpPoprzednieWierzcholki[mpListaSasiedztwa[mpJ, 1]] = mpL;
                    }
            }

            // wyświetlenie wyników
            // dodanie wierszy do 
            for (ushort mpI = 0; mpI < mpIloscWierzcholkow; mpI++)
                mpDGVWynikTablica.Rows.Add();

            // wpisanie wyników
            for (ushort mpI = 0; mpI < mpIloscWierzcholkow; mpI++)
            {
                mpDGVWynikTablica.Rows[mpI].HeaderCell.Value = $"{mpI}";
                mpDGVWynikTablica.Rows[mpI].Cells[0].Value = mpKosztyPrzejscia[mpI];
                mpDGVWynikTablica.Rows[mpI].Cells[1].Value = mpPoprzednieWierzcholki[mpI];
            }

            // wizualizacja ścierzek
            mpL = 0; // zmienna pomocnicza
            // iterowanie tyle razy ile jest wierzchołków w grafie - 1
            for (ushort mpI = 0; mpI < mpIloscWierzcholkow - 1; mpI++)
            {
                mpJ = 0; // zmienna pomocnicza
                // szukanie elementu do kt
                while (mpL != mpPoprzednieWierzcholki[mpJ])
                    mpJ++;
                // wpisanie tekstu do kontrolki 
                mpRTBWizualizacjaScierzki.Text += $"{mpL} --> {mpJ} (waga - {mpKosztyPrzejscia[mpJ]})\n";
                mpL = mpJ;
            }

            // obliczenie i wyświetlenie kosztu czasowego i pamięciowego
            mpTXTKosztCzasowy.Text = Convert.ToString(mpListaSasiedztwa.GetLength(0) * Math.Log10(mpIloscWierzcholkow));
            mpTXTKosztPamieciowy.Text = Convert.ToString(mpIloscWierzcholkow);

            // pokazanie kontrolek
            mpLBLWynikTablica.Visible = true;
            mpDGVWynikTablica.Visible = true;
            mpLBLKosztCzasowy.Visible = true;
            mpLBLKosztPamieciowy.Visible = true;
            mpTXTKosztPamieciowy.Visible = true;
            mpTXTKosztCzasowy.Visible = true;
            mpLBLWizualizacjaScierzki.Visible = true;
            mpRTBWizualizacjaScierzki.Visible = true;
            // zablokowanie przycisku 
            mpBTNWyznaczSciezkiWGrafie.Enabled = false;
        }
    }
}
