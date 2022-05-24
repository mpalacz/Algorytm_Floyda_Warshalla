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
    public partial class ProjektNr3_Palacz53262 : Form
    {
        const int mpBrakDrogi = int.MaxValue; // brak droki między węzłami
        const ushort mpWielkoscGrafu = 5; // wielkość grafu
        static int[,] mpMacierzWag = 
        {
                { mpBrakDrogi, mpBrakDrogi, mpBrakDrogi, 3, mpBrakDrogi},
                { 3, mpBrakDrogi, 4, 1, mpBrakDrogi},
                { mpBrakDrogi, -1, mpBrakDrogi, 2, mpBrakDrogi },
                { -2, 5, mpBrakDrogi, mpBrakDrogi, 2 },
                { mpBrakDrogi, mpBrakDrogi, 1, mpBrakDrogi, mpBrakDrogi }
        }; // macierz wag/sąsiedztwa (opierająca się na przykładowym grafie z laboratoriów)
        static int[,] mpMacierzOdleglosci; // macierz najkrótszych ścieżek (tras) grafu
        static int[,] mpMacierzWezlowPosrednich; // macierz węzłów pośrednich dla ścieżek (tras) w grafie
        public ProjektNr3_Palacz53262()
        {
            InitializeComponent();
        }

        private void ProjektNr3_Palacz53262_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void mpBTNPrzykladowaMacierzWag_Click(object sender, EventArgs e)
        {
            // sformatowanie kontrolek DataGridView
            mpDGVMacierzWag.ColumnCount = mpWielkoscGrafu;
            mpDGVMacierzOdleglosci.ColumnCount = mpWielkoscGrafu;
            mpDGVMacierzWezlowPosrednich.ColumnCount = mpWielkoscGrafu;
            // dodanie wierszy do kontrolek DataGridView
            for (ushort mpI = 0; mpI < mpWielkoscGrafu; mpI++)
            {
                mpDGVMacierzWag.Rows.Add();
                mpDGVMacierzOdleglosci.Rows.Add();
                mpDGVMacierzWezlowPosrednich.Rows.Add();
            }

            // wypełnienie kontrolki mpDGVMacierzWag
            for (ushort mpI = 0; mpI < mpWielkoscGrafu; mpI++)
                for (ushort mpJ = 0; mpJ < mpWielkoscGrafu; mpJ++)
                    mpDGVMacierzWag.Rows[mpI].Cells[mpJ].Value = mpMacierzWag[mpI, mpJ];

            mpDGVMacierzWag.Visible = true; // wyświetlenie kontrolki mpDGVMacierzWag
            mpBTNPrzykladowaMacierzWag.Enabled = false; // zabokowanie przycisku mpBTNPrzykladowaMacierzWag
            mpBTNWyznaczSciezkiWGrafie.Enabled = true; // odblokowanie przycisku 
        }

        private void mpBTNWyznaczSciezkiWGrafie_Click(object sender, EventArgs e)
        {
            // zablokowanie przycisku mpBTNWyznaczSciezkiWGrafie
            mpBTNWyznaczSciezkiWGrafie.Enabled = false;
            // wyświetlenie kontrolek DataGridView
            mpDGVMacierzOdleglosci.Visible = true;
            mpDGVMacierzWezlowPosrednich.Visible = true;

            // utworzenie egzemplaża klasy 
            Graf_MacierzWag mpGrafMacierzWag = new Graf_MacierzWag(mpMacierzWag);

            // wywołanie metody 
            mpGrafMacierzWag.mpAlgorytmDijkstry(out mpMacierzOdleglosci, out mpMacierzWezlowPosrednich);

            // wypisanie zawartości macierrzy do kontrolek DataGridView
            for(ushort mpI=0;mpI<mpWielkoscGrafu;mpI++)
                for(ushort mpJ = 0; mpJ < mpWielkoscGrafu; mpJ++)
                {
                    mpDGVMacierzOdleglosci.Rows[mpI].Cells[mpJ].Value = mpMacierzOdleglosci[mpI,mpJ].ToString();
                    mpDGVMacierzWezlowPosrednich.Rows[mpI].Cells[mpJ].Value=mpDGVMacierzWezlowPosrednich[mpI,mpJ].ToString();
                }
        }
    }
}
