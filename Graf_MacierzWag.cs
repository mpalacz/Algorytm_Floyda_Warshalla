using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorytm_Floyda_Warshalla
{
    class Graf_MacierzWag
    {
        const int mpBrakDrogi = int.MaxValue;
        // deklaracje niezbędnych macierzy
        int[,] mpMacierzWag;
        int[,] mpMacierzOdleglosci;
        int[,] mpMacierzWezlowPosrednich;

        public Graf_MacierzWag(int[,] mpMacierzWag)
        {
            // skopiowanie mpMaceirzWag (parametr kontruktora) do zmiennej prywatnej
            this.mpMacierzWag = (int[,])mpMacierzWag.Clone();
            // utworzenie egzemplaży dwóch pozostałych macierzy
            mpMacierzOdleglosci = (int[,])mpMacierzWag.Clone();
            mpMacierzWezlowPosrednich= new int[mpMacierzWag.GetLength(0), mpMacierzWag.GetLength(1)];
            // ustawienie przekątnej jako mpBrakDrogi w mpMacierzOdleglosci
            for (ushort mpI = 0; mpI < mpMacierzWag.GetLength(0); mpI++)
                for (ushort mpJ = 0; mpJ < mpMacierzWag.GetLength(1); mpJ++)
                    if (mpI == mpJ)
                        mpMacierzOdleglosci[mpI, mpJ] = mpBrakDrogi;
            // wyzerowanie mpMacierzWezlowPosrednich
            for (ushort mpI = 0; mpI < mpMacierzWezlowPosrednich.GetLength(0); mpI++)
                for (ushort mpJ = 0; mpJ < mpMacierzWezlowPosrednich.GetLength(1); mpJ++)
                    mpMacierzWezlowPosrednich[mpI, mpJ] = 0;
        }
        // deklaracja metody dla algorytmu Floyda-Warshalla
        public void mpAlgorytm_Floyda_Warshalla(out int[,] mpMacierzOdleglosci, out int[,] mpMacierzWezlowPosrednich)
        {
            // zapis algorytmu Floyda-Warshalla
            for (ushort mpK = 0; mpK < mpMacierzWag.GetLength(0); mpK++)
                for (ushort mpJ = 0; mpJ < this.mpMacierzOdleglosci.GetLength(0); mpJ++)
                    for (ushort mpI = 0; mpI < this.mpMacierzOdleglosci.GetLength(1); mpI++)
                        if (this.mpMacierzOdleglosci[mpJ, mpK] + this.mpMacierzOdleglosci[mpK, mpI] < this.mpMacierzOdleglosci[mpJ, mpI])
                        {
                            this.mpMacierzOdleglosci[mpJ, mpI] = this.mpMacierzOdleglosci[mpJ, mpK] + this.mpMacierzOdleglosci[mpK, mpI];
                            // zapisanie numeru węzła pośredniego k
                            this.mpMacierzWezlowPosrednich[mpJ, mpI] = mpK;
                        }
            // przekazanie (przesłanie) wyników działania algorytmu Floyda - Warshalla
            mpMacierzOdleglosci = this.mpMacierzOdleglosci;
            mpMacierzWezlowPosrednich = this.mpMacierzWezlowPosrednich;
        }
    }
}
