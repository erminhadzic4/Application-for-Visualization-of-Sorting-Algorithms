using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algoritmi_Sortiranja
{
    internal class MergeSort : SortEngine
    {
        private int[] niz;
        private Graphics g;
        private int maxVal;
        private int brojPristupa = 0;
        private int brojPoredjenja = 0;
        Brush BojaPravougaonika = new System.Drawing.SolidBrush(Boja.Primarna);
        Brush BojaPozadine = new System.Drawing.SolidBrush(Color.FromArgb(240, 240, 240));

        public MergeSort(int[] niz_temp, Graphics g_temp, int maxVal_temp)
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

        public int[] Sortiraj(int lijevo, int desno)
        {
            if (lijevo < desno)
            {
                brojPoredjenja++;
                int sredina = lijevo + (desno - lijevo) / 2;
                Sortiraj(lijevo, sredina);
                Sortiraj(sredina + 1, desno);
                SpojiNizove(lijevo, sredina, desno);
            }
            return niz;
        }

        public void SpojiNizove(int lijevo, int sredina, int desno)
        {
            var lijeviNizVel = sredina - lijevo + 1;
            var desniNizVel = desno - sredina;
            var lijeviNizPriv = new int[lijeviNizVel];
            var desniNizPriv = new int[desniNizVel];
            int i, j;
            for (i = 0; i < lijeviNizVel; ++i)
            {
                lijeviNizPriv[i] = niz[lijevo + i];
                brojPristupa += 2;
                brojPoredjenja++;
            }
                
            for (j = 0; j < desniNizVel; ++j)
            {
                desniNizPriv[j] = niz[sredina + 1 + j];
                brojPristupa += 2;
                brojPoredjenja++;
            }
            i = 0;
            j = 0;
            int k = lijevo;
            while (i < lijeviNizVel && j < desniNizVel)
            {
                brojPoredjenja += 2;
                if (lijeviNizPriv[i] <= desniNizPriv[j])
                {
                    niz[k] = lijeviNizPriv[i];
                    brojPristupa += 5;
                    brojPoredjenja++;
                    g.FillRectangle(BojaPozadine, k, 0, 1, maxVal);
                    g.FillRectangle(BojaPravougaonika, k, maxVal - niz[k], 1, maxVal);
                    g.FillRectangle(BojaPozadine, i, 0, 1, maxVal);
                    g.FillRectangle(BojaPravougaonika, i, maxVal - niz[i], 1, maxVal);
                    k++;
                    i++;
                }
                else
                {
                    niz[k] = desniNizPriv[j];
                    brojPristupa += 2;
                    g.FillRectangle(BojaPozadine, k, 0, 1, maxVal);
                    g.FillRectangle(BojaPravougaonika, k, maxVal - niz[k], 1, maxVal);
                    g.FillRectangle(BojaPozadine, j, 0, 1, maxVal);
                    g.FillRectangle(BojaPravougaonika, j, maxVal - niz[j], 1, maxVal);
                    k++;
                    j++;
                }
                System.Threading.Thread.Sleep(1);
            }
            while (i < lijeviNizVel)
            {
                brojPoredjenja++;
                niz[k] = lijeviNizPriv[i];
                brojPristupa += 2;
                k++;
                i++;
            }
            while (j < desniNizVel)
            {
                brojPoredjenja++;
                niz[k] = desniNizPriv[j];
                brojPristupa += 2;
                k++;
                j++;
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
