using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algoritmi_Sortiranja
{
    internal class RadixSort : SortEngine
    {
        private int[] niz;
        private Graphics g;
        private int maxVal;
        private int brojPristupa = 0;
        private int brojPoredjenja = 0;
        Brush BojaPravougaonika = new System.Drawing.SolidBrush(Boja.Primarna);
        Brush BojaPozadine = new System.Drawing.SolidBrush(Color.FromArgb(240, 240, 240));

        public RadixSort(int[] niz_temp, Graphics g_temp, int maxVal_temp)
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
            int max = niz.Max();
            for (int exp = 1; max / exp > 0; exp *= 10)
            {
                brojPoredjenja++;
                Radixsort(exp);
            }
        }

        public bool Sortirana()
        {
            for (int i = 0; i < niz.Count() - 1; i++)
            {
                if (niz[i] > niz[i + 1]) return false;
            }
            return true;
        }

        public void Radixsort(int exp)
        {
            int[] izlaz = new int[niz.Length];
            int i;

            int[] brojac = new int[10];
            for (i = 0; i < 10; i++)
            {
                brojac[i] = 0;
                brojPristupa++;
            }
            for (i = 0; i < niz.Length; i++)
            {
                brojac[(niz[i] / exp) % 10]++;
                brojPristupa+=2;
            }

            for (i = 1; i < 10; i++)
            {
                brojac[i] += brojac[i - 1];
                brojPristupa += 2;
            }

            for (i = niz.Length - 1; i >= 0; i--)
            {
                izlaz[brojac[(niz[i] / exp) % 10] - 1] = niz[i];
                brojPristupa+=4;
                g.FillRectangle(BojaPozadine, brojac[(niz[i] / exp) % 10] - 1, 0, 1, maxVal);
                g.FillRectangle(BojaPravougaonika, brojac[(niz[i] / exp) % 10] - 1, maxVal - niz[brojac[(niz[i] / exp) % 10] - 1], 1, maxVal);
                g.FillRectangle(BojaPozadine, i, 0, 1, maxVal);
                g.FillRectangle(BojaPravougaonika, i, maxVal - niz[i], 1, maxVal);
                brojac[(niz[i] / exp) % 10]--;
                brojPoredjenja++;
                brojPristupa += 2;
            }

            for (i = 0; i < niz.Length; i++)
            {
                niz[i] = izlaz[i];
                brojPristupa += 2;
                g.FillRectangle(BojaPozadine, i, 0, 1, maxVal);
                g.FillRectangle(BojaPravougaonika, i, maxVal - niz[i], 1, maxVal);
                System.Threading.Thread.Sleep(5);
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
