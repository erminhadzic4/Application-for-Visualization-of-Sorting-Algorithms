using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Algoritmi_Sortiranja
{
    internal class QuickSort : SortEngine
    {
        private int[] niz;
        private Graphics g;
        private int maxVal;
        private int brojPristupa = 0;
        private int brojPoredjenja = 0;
        Brush BojaPravougaonika = new System.Drawing.SolidBrush(Boja.Primarna);
        Brush BojaPozadine = new System.Drawing.SolidBrush(Color.FromArgb(240, 240, 240));

        public QuickSort(int[] niz_temp, Graphics g_temp, int maxVal_temp)
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
            Sortiraj(0, niz.Count() - 1);
        }

        public bool Sortirana()
        {
            for (int i = 0; i < niz.Count() - 1; i++)
            {
                if (niz[i] > niz[i + 1]) return false;
            }
            return true;
        }

        public int[] Sortiraj(int lijevInd, int desniInd)
        {
            var i = lijevInd;
            var j = desniInd;
            var pivot = niz[lijevInd];
            brojPristupa++;
            while (i <= j)
            {
                brojPoredjenja++;
                while (niz[i] < pivot)
                {
                    i++;
                    brojPristupa++;
                    brojPoredjenja++;
                }

                while (niz[j] > pivot)
                {
                    j--;
                    brojPristupa++;
                    brojPoredjenja++;
                }
                if (i <= j)
                {
                    brojPoredjenja++;
                    int priv = niz[i];
                    niz[i] = niz[j];
                    niz[j] = priv;
                    brojPristupa+=4;
                    g.FillRectangle(BojaPozadine, i, 0, 1, maxVal);
                    g.FillRectangle(BojaPravougaonika, i, maxVal - niz[i], 1, maxVal);
                    System.Threading.Thread.Sleep(5);
                    g.FillRectangle(BojaPozadine, j, 0, 1, maxVal);
                    g.FillRectangle(BojaPravougaonika, j, maxVal - niz[j], 1, maxVal);
                    i++;
                    j--;
                }
            }

            if (lijevInd < j)
            {
                Sortiraj(lijevInd, j);
                brojPoredjenja++;
            }
            if (i < desniInd)
            {
                Sortiraj(i, desniInd);
                brojPoredjenja++;
            }
            return niz;
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
