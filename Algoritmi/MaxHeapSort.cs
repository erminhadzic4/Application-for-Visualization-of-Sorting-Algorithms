using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algoritmi_Sortiranja
{
    internal class MaxHeapSort : SortEngine
    {
        private int[] niz;
        private Graphics g;
        private int maxVal;
        private int brojPristupa = 0;
        private int brojPoredjenja = 0;
        Brush BojaPravougaonika = new System.Drawing.SolidBrush(Boja.Primarna);
        Brush BojaPozadine = new System.Drawing.SolidBrush(Color.FromArgb(240, 240, 240));

        public MaxHeapSort(int[] niz_temp, Graphics g_temp, int maxVal_temp)
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
            heapSort(niz.Length);
        }

        public bool Sortirana()
        {
            for (int i = 0; i < niz.Count() - 1; i++)
            {
                if (niz[i] > niz[i + 1]) return false;
            }
            return true;
        }

        public void heapSort(int n)
        {
            for (int i = n / 2 - 1; i >= 0; i--)
            {
                System.Threading.Thread.Sleep(1);
                podjeli(n, i);
            }
            for (int i = n - 1; i >= 0; i--)
            {
                int priv = niz[0];
                niz[0] = niz[i];
                brojPristupa += 2;
                niz[i] = priv;
                brojPristupa++;
                g.FillRectangle(BojaPozadine, 0, 0, 1, maxVal);
                g.FillRectangle(BojaPravougaonika, 0, maxVal - niz[0], 1, maxVal);
                g.FillRectangle(BojaPozadine, i, 0, 1, maxVal);
                g.FillRectangle(BojaPravougaonika, i, maxVal - niz[i], 1, maxVal);
                System.Threading.Thread.Sleep(1);
                podjeli(i, 0);
            }
        }
        public void podjeli(int n, int i)
        {

            int najveci = i;
            int lijevo = 2 * i + 1;
            int desno = 2 * i + 2;
            if (lijevo < n && niz[lijevo] > niz[najveci])
                najveci = lijevo;
            if (desno < n && niz[desno] > niz[najveci])
                najveci = desno;

            brojPoredjenja += 2;
            brojPristupa += 4;

            if (najveci != i)
            {
                int priv = niz[i];
                niz[i] = niz[najveci];
                brojPristupa += 3;
                niz[najveci] = priv;
                brojPristupa++;
                g.FillRectangle(BojaPozadine, i, 0, 1, maxVal);
                g.FillRectangle(BojaPravougaonika, i, maxVal - niz[i], 1, maxVal);
                g.FillRectangle(BojaPozadine, najveci, 0, 1, maxVal);
                g.FillRectangle(BojaPravougaonika, najveci, maxVal - niz[najveci], 1, maxVal);
                podjeli(n, najveci);
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
