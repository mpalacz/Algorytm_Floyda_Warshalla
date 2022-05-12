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
        Font mpFontOpisuKontrolek = new Font("Times New Roman", 12, FontStyle.Italic);
        // deklaracje zmiennych referencyjnych do kontrolek, które będą umieszczane na formularzu
        Label mpLBLMacierzWag;
        DataGridView mpDGVMacierzWag;

        public Algorytm_Floyda_Warshalla()
        {
            InitializeComponent();
        }

        private void mpTXTLiczbaWierzcholkowGrafu_TextChanged(object sender, EventArgs e)
        {
            // ustawienie stanu braku aktywności dla kontrolki mpTXTLiczbaWierzcholkowGrafu
            mpTXTLiczbaWierzcholkowGrafu.Enabled = false;
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
                // dla umożliwienia poprawienia wpisanejk liczby wierchołków grafu
                // uaktywaniamy kontrolkę mpTXTLiczbaWierzcholkowGrafu
                mpTXTLiczbaWierzcholkowGrafu.Enabled = true;
                return;
            }
            // umieszcznie na formularzu etykiety opisującej kontrolkę DataGridView dla wpisania macierzy wag
            mpLBLMacierzWag = new Label();
            // sformatowanie kontrolki mpLBLMacierzWag
            mpLBLMacierzWag.Font = mpFontOpisuKontrolek;
            mpLBLMacierzWag.Text = "Macierz wag (sąsiedztwa)";
            mpLBLMacierzWag.AutoSize = true;
            mpLBLMacierzWag.Location = new Point(mpLBLLiczbaWGrafu.Location.X + mpLBLLiczbaWGrafu.Width + mpMargines, mpLBLOpisGrafu.Top);
            mpLBLMacierzWag.Visible = true;
            // umieszczenie sformatowanej kontrolki mpLBLMacierzWag
            this.Controls.Add(mpLBLMacierzWag);
            // utworzenie egzemplarza kontrolki DataGridView i sformatowanie jej oraz umieszczenie jej na formularzu
            mpDGVMacierzWag = new DataGridView();
            mpDGVMacierzWag.Location = new Point(mpLBLMacierzWag.Left, mpLBLMacierzWag.Top + mpLBLMacierzWag.Height + mpMargines / 2);
            mpDGVMacierzWag.Size = new Size((mpLiczbaWierzcholkowGrafu + 1) * mpSzerokoscKolumny, (mpLiczbaWierzcholkowGrafu + 1) * mpWysokoscWiersza);
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
            // dodanie sformatowanej kontrolki mpDGVMacierzWag do kolekcji Controls
            Controls.Add(mpDGVMacierzWag);
            // suatwienie trybu Auto... dla kotrolki mpDGVMacierzWag
            mpDGVMacierzWag.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
            mpDGVMacierzWag.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            // wyzerowanie komórek w kontrolce DataGridView
            for (ushort mpI = 0; mpI < mpLiczbaWierzcholkowGrafu; mpI++)
                for (ushort mpJ = 0; mpJ < mpLiczbaWierzcholkowGrafu; mpJ++)
                    mpDGVMacierzWag.Rows[mpI].Cells[mpJ].Value = "";
            // ustawienie stanu braku aktywności dla obsługiwanego przycisku
            mpBTNMacierzWag.Enabled = false;
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
                    "macierz wag może być wpisana do kontrolki DataGridView tylko dla grefu " +
                    "o 5 węzłach");
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

        }
        private void mpBTNWyznaczSciezkiWGrafie_Click(object sender, EventArgs e)
        {
            // deklaracja i utworzenie macierzy wag dla rozpatrywanego grafu
            int mpWaga;
            mpMacierzWag = new int[mpLiczbaWierzcholkowGrafu, mpLiczbaWierzcholkowGrafu];
            // pobranie macierzy wag z kontrolki mpDGVMacierzWag, która została umieszczona na formularzu
            for (ushort mpI = 0; mpI < mpLiczbaWierzcholkowGrafu; mpI++)
                for (ushort mpJ = 0; mpJ < mpLiczbaWierzcholkowGrafu; mpJ++)
                    if (string.IsNullOrEmpty((string)mpDGVMacierzWag.Rows[mpI].Cells[mpJ].Value))
                        mpMaceirzWag[mpI, mpJ] = mpBrakDrogi;
                    else
                        if (!int.TryParse((string)mpDGVMacierzWag.Rows[mpI].Cells[mpJ].Value, out mpWaga))
                    {
                        mpErrorProvider1.SetError(mpDGVMacierzWag, $"ERROR: w zapisie elementu kontrolki " +
                            $"DataGridView o indexie [{mpI}, {mpJ}] wystąpił niedozowlony znak");
                        return;
                    }
            // macierz wag została pograna z formularza
            // utworzenie egzemplarza klasy Graf_MacierzWag
            Graf_MacierzWag mpGraf = new Graf_MacierzWag((int[,])mpMacierzWag.Clone);
            // wyznaczenie najkrótszych ścieżek w grafie algorytmem Floyda-Warshalla
            mpGraf.mpAlgorytm_Floyda_Warshalla(out mpMacierzOdleglosci, out mpMacierzWezlowPosrednich);

            // wypisanie macierzy mpMacierzOdlegloscido do kontrolki DataGridView
            for (ushort mpI = 0; mpI < mpDGVMacierzOdleglosci.Rows.Count; mpI++)
                for (ushort mpJ = 0; mpJ < mpDGVMacierzOdleglosci.Columns.Count; mpJ++)
                    mpDGVMacierzOdleglosci.Rows[mpI].Cell[mpJ].Value = mpMcierzOdleglosci[mpI,mpJ];
            // ustawienie trybu ReadOnly dla kontrolki 
            mpDGVMacierzOdleglosci.ReadOnly = true;
            // wypisanie macierzy mpMacierzWezlowPosrednich do kontrolki DataGridView
            for (ushort mpI = 0; mpI < mpDGVMacierzWezlowPosrednich.Rows.Count; mpI++)
                for (ushort mpJ = 0; mpJ < mpDGVMacierzWezlowPosrednich.Columns.Count; mpJ++)
                    mpDGVMacierzWezlowPosrednich.Rows[mpI].Cell[mpJ].Value = mpDGVMacierzWezlowPosrednich[mpI, mpJ];
            // ustawienie trybu ReadOnly dla kontrolki 
            mpDGVMacierzWezlowPosrednich.ReadOnly = true;
        }
    }
}
