using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algoritmi_Sortiranja
{
    internal class ShellSort : SortEngine
    {
        private int[] niz;
        private Graphics g;
        private int maxVal;
        private int brojPristupa = 0;
        private int brojPoredjenja = 0;
        Brush BojaPravougaonika = new System.Drawing.SolidBrush(Boja.Primarna);
        Brush BojaPozadine = new System.Drawing.SolidBrush(Color.FromArgb(240, 240, 240));

        public ShellSort(int[] niz_temp, Graphics g_temp, int maxVal_temp)
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
            Shellsort();
        }

        public bool Sortirana()
        {
            for (int i = 0; i < niz.Count() - 1; i++)
            {
                if (niz[i] > niz[i + 1]) return false;
            }
            return true;
        }

        private int Shellsort()
        {
            int n = niz.Length;

            for (int razmak = n / 2; razmak > 0; razmak /= 2)
            {
                brojPoredjenja++;
                for (int i = razmak; i < n; i += 1)
                {
                    int priv = niz[i];
                    brojPristupa++;
                    g.FillRectangle(BojaPozadine, priv, 0, 1, maxVal);
                    g.FillRectangle(BojaPravougaonika, priv, maxVal - niz[priv], 1, maxVal);
                    g.FillRectangle(BojaPozadine, i, 0, 1, maxVal);
                    g.FillRectangle(BojaPravougaonika, i, maxVal - niz[i], 1, maxVal);

                    int j;
                    for (j = i; j >= razmak && niz[j - razmak] > priv; j -= razmak)
                    {
                        brojPoredjenja += 2;
                        brojPristupa++;
                        System.Threading.Thread.Sleep(1);
                        niz[j] = niz[j - razmak];
                        brojPristupa += 2;
                        g.FillRectangle(BojaPozadine, j, 0, 1, maxVal);
                        g.FillRectangle(BojaPravougaonika, j, maxVal - niz[j], 1, maxVal);
                        g.FillRectangle(BojaPozadine, j - razmak, 0, 1, maxVal);
                        g.FillRectangle(BojaPravougaonika, j - razmak, maxVal - niz[j - razmak], 1, maxVal);
                    }

                    niz[j] = priv;
                    brojPristupa++;
                    g.FillRectangle(BojaPozadine, j, 0, 1, maxVal);
                    g.FillRectangle(BojaPravougaonika, j, maxVal - niz[j], 1, maxVal);
                    g.FillRectangle(BojaPozadine, priv, 0, 1, maxVal);
                    g.FillRectangle(BojaPravougaonika, priv, maxVal - niz[priv], 1, maxVal);
                }
            }
            return 0;
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
