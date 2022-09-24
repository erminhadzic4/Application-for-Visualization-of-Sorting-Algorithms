using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Algoritmi_Sortiranja
{
    internal class InsertionSort : SortEngine
    {
        private int[] niz;
        private Graphics g;
        private int maxVal;
        private int brojPristupa = 0;
        private int brojPoredjenja = 0;
        Brush BojaPravougaonika = new System.Drawing.SolidBrush(Boja.Primarna);
        Brush BojaPozadine = new System.Drawing.SolidBrush(Color.FromArgb(240, 240, 240));

        public InsertionSort(int[] niz_temp, Graphics g_temp, int maxVal_temp)
        {
            this.niz = niz_temp;
            this.g = g_temp;
            this.maxVal = maxVal_temp;
        }

        public void Ispisi()
        {
            return;
        }

        public void Sljedeci()
        {
            Insertionsort();
        }

        public bool Sortirana()
        {
            for (int i = 0; i < niz.Count() - 1; i++)
            {
                if (niz[i] > niz[i + 1]) return false;
            }
            return true;
        }

        public void Insertionsort()
        {
            int n = niz.Length;
            for (int i = 1; i < n; ++i)
            {
                int kljuc = niz[i];
                brojPristupa++;
                int j = i - 1;

                while (j >= 0 && niz[j] > kljuc)
                {
                    niz[j + 1] = niz[j];
                    brojPristupa+=2;
                    brojPoredjenja++;
                    j = j - 1;
                    g.FillRectangle(BojaPozadine, j + 1, 0, 1, maxVal);
                    g.FillRectangle(BojaPravougaonika, j + 1, maxVal - niz[j + 1], 1, maxVal);
                }
                niz[j + 1] = kljuc;
                brojPristupa++;
                System.Threading.Thread.Sleep(20);
            }
        }


        public void OcitajLog(Label lblPristup, Label lblPoredjenja)
        {
            lblPoredjenja.Text = "Puta poredjeni elementi: " + brojPoredjenja;
            lblPristup.Text = "Puta pristupljeno nizu: " + brojPristupa;
        }

        public int DajBrPristupa()
        {
            return brojPristupa;
        }

        public int DajBrPoredjenja()
        {
            return brojPoredjenja;
        }
    }
}
