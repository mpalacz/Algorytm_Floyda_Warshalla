using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algorytm_Floyda_Warshalla
{
    public partial class Algorytm_Floyda_Warshalla : Form
    {
        const int mpBrakDrogi = int.MaxValue; // brak droki między węzłami
        ushort mpLiczbaWierzcholkowGrafu;
        static int[,] mpMacierzWag; // macierz wag/sąsiedztwa
        static int[,] mpMacierzOdleglosci; // macierz najkrótszych ścieżek (tras) grafu
        static int[,] mpMacierzWezlowPosrednich; // macierz węzłów pośrednich dla ścieżek (tras) w grafie

        public Algorytm_Floyda_Warshalla()
        {
            InitializeComponent();
        }

        private void mpTXTLiczbaWierzcholkowGrafu_TextChanged(object sender, EventArgs e)
        {
            // uaktywnienie przycisku poleceń dla umieszczenia kontrolki DataGridView na formularzu
            mpBTNMacierzWag.Enabled = true;
        }
        private void mpBTNMacierzWag_Click(object sender, EventArgs e)
        {
            // zgaszenie kontrolki errorProvider
            mpErrorProvider1.Dispose();
            // pobranie liczby wierzchołków grafu
            if (!ushort.TryParse(mpTXTLiczbaWierzcholkowGrafu.Text, out mpLiczbaWierzcholkowGrafu))
            {
                mpErrorProvider1.SetError(mpTXTLiczbaWierzcholkowGrafu, "ERROR: w zapisie liczby wierchołów grafu wystąpił niedozwolony znak");
                return;
            }
            // wyświetlenie kontrolki mpLBLMacierzWag
            mpLBLMacierzWag.Visible = true;
            // sformatowanie mpDGVMacierzWag
            mpDGVMacierzWag.AutoResizeRows();
            mpDGVMacierzWag.ColumnCount = mpLiczbaWierzcholkowGrafu;
            mpDGVMacierzWag.ColumnHeadersVisible = true;
            mpDGVMacierzWag.ReadOnly = false;
            mpDGVMacierzWag.AllowUserToResizeRows = false;
            mpDGVMacierzWag.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            mpDGVMacierzWag.MultiSelect = false;
            // sformatowanie nagłówka kolumn
            DataGridViewCellStyle mpStylHeaderKolumn = new DataGridViewCellStyle();
            mpStylHeaderKolumn.Font = new Font("Arial", 10, FontStyle.Bold);
            mpStylHeaderKolumn.Alignment = DataGridViewContentAlignment.MiddleCenter;
            mpStylHeaderKolumn.Format = "    ";
            // przypisanie ustalonego formatu nagłówka kolumn do kontrolki DataGridView
            mpDGVMacierzWag.ColumnHeadersDefaultCellStyle = mpStylHeaderKolumn;
            DataGridViewCellStyle mpStylHeaderWierszy = new DataGridViewCellStyle();
            mpStylHeaderWierszy.Font = new Font("Arial", 10, FontStyle.Bold);
            mpStylHeaderWierszy.Alignment = DataGridViewContentAlignment.MiddleCenter;
            // przypisanie ustalonego formatu nagłówka wioerszy do kontrolki DataGridView
            mpDGVMacierzWag.RowHeadersDefaultCellStyle = mpStylHeaderWierszy;
            // wpisanie nazw w wierszu nagłówkowym kolumn
            for (ushort mpI = 0; mpI < mpLiczbaWierzcholkowGrafu; mpI++)
                mpDGVMacierzWag.Columns[mpI].HeaderText = "(" + mpI + ")";
            // dodanie wierszy do kontrolki DataGridView
            for (ushort mpI = 0; mpI < mpLiczbaWierzcholkowGrafu; mpI++)
            {
                mpDGVMacierzWag.Rows.Add();
                mpDGVMacierzWag.AutoResizeRow(mpI);
            }
            // wpisanie "numerów" wierszy kontrolki DataGridView
            for (ushort mpI = 0; mpI < mpLiczbaWierzcholkowGrafu; mpI++)
                mpDGVMacierzWag.Rows[mpI].HeaderCell.Value = $"({mpI})";
            // ustwienie trybu Auto... dla kotrolki mpDGVMacierzWag
            mpDGVMacierzWag.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
            mpDGVMacierzWag.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            // wyczyszczenie komórek w kontrolce DataGridView
            for (ushort mpI = 0; mpI < mpLiczbaWierzcholkowGrafu; mpI++)
                for (ushort mpJ = 0; mpJ < mpLiczbaWierzcholkowGrafu; mpJ++)
                    mpDGVMacierzWag.Rows[mpI].Cells[mpJ].Value = "";
            // ustawienie stanu braku aktywności dla obsługiwanego przycisku
            mpBTNMacierzWag.Enabled = false;
            // ustawienie stanu braku aktywności dla kontrolki mpTXTLiczbaWierzcholkowGrafu
            mpTXTLiczbaWierzcholkowGrafu.Enabled = false;
            // ustawienie stanu aktywnosci dla dwóch następnych przecisków poleceń
            mpBTNPrzykladowaMacierzWag.Enabled = true;
            mpBTNAkceptacjaMacierzyWag.Enabled = true;
        }
        private void mpBTNPrzykladowaMacierzWag_Click(object sender, EventArgs e)
        {
            int[,] mpPrzykladowyGraf ={
                { mpBrakDrogi,mpBrakDrogi,mpBrakDrogi,3,mpBrakDrogi},
                { 3,mpBrakDrogi,4,1,mpBrakDrogi},
                {mpBrakDrogi,-1,mpBrakDrogi,2,mpBrakDrogi },
                {-2,5,mpBrakDrogi,mpBrakDrogi,2 },
                { mpBrakDrogi,mpBrakDrogi,1,mpBrakDrogi,mpBrakDrogi}
            };
            // sprawdzenie, czy liczba wierzchołków grafu jest równa 5
            if (mpLiczbaWierzcholkowGrafu != 5)
            {
                mpErrorProvider1.SetError(mpBTNPrzykladowaMacierzWag, "ERROR: przykładowa " +
                    "macierz wag może być wpisana do kontrolki DataGridView tylko dla grafu " +
                    "o 5 węzłach");
                // ustawienie stanu aktywności dla mpTXTLiczbaWierzcholkowGrafu
                mpTXTLiczbaWierzcholkowGrafu.Enabled = true;
                // ustawienie stanu aktywności dla mpBTNMacierzWag
                mpBTNMacierzWag.Enabled = true;
                // ustawienie stanu braku aktywnosci dla mpBTNPrzykladowaMacierzWag i mpBTNAkceptacjaMacierzyWag
                mpBTNPrzykladowaMacierzWag.Enabled = false;
                mpBTNAkceptacjaMacierzyWag.Enabled = false;
                return;
            }
            // zgaszenie kotrolki mpErrorProvider1
            mpErrorProvider1.Dispose();
            // wpisanie macierzy wag do kontrolki mpDVGMacierWag, która jest już umieszczona w formularzu
            for (ushort mpI = 0; mpI < mpDGVMacierzWag.Rows.Count; mpI++)
                for (ushort mpJ = 0; mpJ < mpDGVMacierzWag.Columns.Count; mpJ++)
                    if (mpPrzykladowyGraf[mpI, mpJ] == mpBrakDrogi)
                        mpDGVMacierzWag.Rows[mpI].Cells[mpJ].Value = "";
                    else
                        mpDGVMacierzWag.Rows[mpI].Cells[mpJ].Value = mpPrzykladowyGraf[mpI, mpJ];
        }
        private void mpBTNAkceptacjaMacierzy_Click(object sender, EventArgs e)
        {
            mpErrorProvider1.Dispose(); // zgaszenie kontrolki mpErrorProvider1
            // ustawić tryb ReadOnly dla kontrolki mpDGVMacierzWag
            mpDGVMacierzWag.ReadOnly = true;
            // zmiana aktywności dla przycisków 
            mpBTNAkceptacjaMacierzyWag.Enabled = false;
            mpBTNPrzykladowaMacierzWag.Enabled = false;
            mpBTNWyznaczSciezkiWGrafie.Enabled = true;

        }
        private void mpBTNWyznaczSciezkiWGrafie_Click(object sender, EventArgs e)
        {
            mpMacierzWag = new int[mpLiczbaWierzcholkowGrafu, mpLiczbaWierzcholkowGrafu];
            // pobranie macierzy wag z kontrolki mpDGVMacierzWag, która została umieszczona na formularzu
            for (ushort mpI = 0; mpI < mpLiczbaWierzcholkowGrafu; mpI++)
                for (ushort mpJ = 0; mpJ < mpLiczbaWierzcholkowGrafu; mpJ++)
                    if (string.IsNullOrEmpty((string)mpDGVMacierzWag.Rows[mpI].Cells[mpJ].Value))
                        mpMacierzWag[mpI, mpJ] = mpBrakDrogi;
                    else if (!int.TryParse((string)mpDGVMacierzWag.Rows[mpI].Cells[mpJ].Value, out mpMacierzWag[mpI, mpJ]))
                    {
                        mpErrorProvider1.SetError(mpDGVMacierzWag, $"ERROR: w zapisie elementu kontrolki " +
                            $"DataGridView o indexie [{mpI}, {mpJ}] wystąpił niedozowlony znak");
                        return;
                    }
            // utworzenie egzemplarza klasy Graf_MacierzWag
            Graf_MacierzWag mpGraf = new Graf_MacierzWag((int[,])mpMacierzWag.Clone());
            // wyznaczenie najkrótszych ścieżek w grafie algorytmem Floyda-Warshalla
            mpGraf.mpAlgorytm_Floyda_Warshalla(out mpMacierzOdleglosci, out mpMacierzWezlowPosrednich);

            // wypisanie macierzy mpMacierzOdlegloscido do kontrolki DataGridView
            for (ushort mpI = 0; mpI < mpDGVMacierzOdleglosci.Rows.Count; mpI++)
                for (ushort mpJ = 0; mpJ < mpDGVMacierzOdleglosci.Columns.Count; mpJ++)
                    mpDGVMacierzOdleglosci.Rows[mpI].Cells[mpJ].Value = mpMacierzOdleglosci[mpI, mpJ];
            // ustawienie trybu ReadOnly dla kontrolki 
            mpDGVMacierzOdleglosci.ReadOnly = true;
            // wypisanie macierzy mpMacierzWezlowPosrednich do kontrolki DataGridView
            for (ushort mpI = 0; mpI < mpDGVMacierzWezlowPosrednich.Rows.Count; mpI++)
                for (ushort mpJ = 0; mpJ < mpDGVMacierzWezlowPosrednich.Columns.Count; mpJ++)
                    mpDGVMacierzWezlowPosrednich.Rows[mpI].Cells[mpJ].Value = mpDGVMacierzWezlowPosrednich[mpI, mpJ];
            // ustawienie trybu ReadOnly dla kontrolki 
            mpDGVMacierzWezlowPosrednich.ReadOnly = true;
            // ustawienie stanu braku aktywności dla przycisku poleceń
            mpBTNWyznaczSciezkiWGrafie.Enabled = false;
            // ustawienie stanu aktywności dla przycisku poleceń
            mpBTNWypiszTrasy.Enabled = true;
        }

        private void mpBTNWypiszTrasy_Click(object sender, EventArgs e)
        {
            mpBTNWypiszTrasy.Enabled = false; // zablokowanie przycisku
            // wyświetlenie kontrolek
            mpRTBTrasa.Visible = true; 
            mpLBLTrasa.Visible = true;
            string mpNapis = ""; // napis który zostanie wyświetlony w mpRTBTrasa

            for(ushort mpJ=0;mpJ<mpMacierzOdleglosci.GetLength(0);mpJ++)
                for(ushort mpI = 0; mpI < mpMacierzOdleglosci.GetLength(1); mpJ++)
                {
                    if (mpMacierzOdleglosci[mpJ, mpI] == mpBrakDrogi)
                        mpNapis += $"{mpJ,3} --> {mpI,3} : między tymi węzłami nie ma trasy przejścia\n";
                    else if (mpJ != mpI)
                        mpNapis += $"{mpJ,3} --> {mpI,3}: długość (waga) drogi = {mpMacierzOdleglosci[mpJ,mpI]}" +
                            $" -> poprzez węzły\n";
                }
            mpRTBTrasa.Text= mpNapis;
        }

        private void Algorytm_Floyda_Warshalla_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); // zamknięcie aplikacji przy zamknięciu okna
        }
    }
}
