using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algoritmi_Sortiranja
{
    internal class SelectionSort : SortEngine
    {
        private int[] niz;
        private Graphics g;
        private int maxVal;
        private int brojPristupa = 0;
        private int brojPoredjenja = 0;
        Brush BojaPravougaonika = new System.Drawing.SolidBrush(Boja.Primarna);
        Brush BojaPozadine = new System.Drawing.SolidBrush(Color.FromArgb(240, 240, 240));

        public SelectionSort(int[] niz_temp, Graphics g_temp, int maxVal_temp)
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
            Selectionsort();
        }

        public bool Sortirana()
        {
            for (int i = 0; i < niz.Count() - 1; i++)
            {
                if (niz[i] > niz[i + 1]) return false;
            }
            return true;
        }

        public void Selectionsort()
        {
                int n = niz.Length;

                for (int i = 0; i < n - 1; i++)
                {
                    int najmanjiInd = i;
                    for (int j = i + 1; j < n; j++)
                        if (niz[j] < niz[najmanjiInd])
                        {
                            najmanjiInd = j;
                            brojPristupa += 2;
                            brojPoredjenja+=2;
                        }
                            
                    int priv = niz[najmanjiInd];
                    niz[najmanjiInd] = niz[i];
                    niz[i] = priv;
                    brojPristupa+=4;
                    g.FillRectangle(BojaPozadine, najmanjiInd, 0, 1, maxVal);
                    g.FillRectangle(BojaPravougaonika, najmanjiInd, maxVal - niz[najmanjiInd], 1, maxVal);
                    g.FillRectangle(BojaPozadine, i, 0, 1, maxVal);
                    g.FillRectangle(BojaPravougaonika, i, maxVal - niz[i], 1, maxVal);
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
