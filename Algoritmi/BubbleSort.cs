using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Algoritmi_Sortiranja
{
    internal class BubbleSort : SortEngine
    {
        private int[] niz;
        private Graphics g;
        private int maxVal;
        private int brojPristupa = 0;
        private int brojPoredjenja = 0;
        Brush BojaPravougaonika = new System.Drawing.SolidBrush(Boja.Primarna);
        Brush BojaPozadine = new System.Drawing.SolidBrush(Color.FromArgb(240,240,240));

        public BubbleSort(int[] niz_temp, Graphics g_temp, int maxVal_temp)
        {
            this.niz = niz_temp;
            this.g = g_temp;
            this.maxVal = maxVal_temp;
        }

        public void Sljedeci()
        {
            for (int i = 0; i < niz.Count() - 1; i++)
                if (niz[i] > niz[i + 1])
                {
                    brojPristupa += 2;
                    brojPoredjenja ++;
                    Zamijeni(i, i + 1);
                }
        }

        private void Zamijeni(int i, int v)
        {
            int temp = niz[i];
            niz[i] = niz[i + 1];
            niz[i+1] = temp;

            Iscrtaj(i, niz[i]);
            Iscrtaj(v, niz[v]);
        }

        private void Iscrtaj(int p, int visina)
        {
            g.FillRectangle(BojaPozadine, p, 0, 1, maxVal);
            g.FillRectangle(BojaPravougaonika, p, maxVal - niz[p], 1, maxVal);
        }

        public bool Sortirana()
        {
            for (int i = 0; i < niz.Count() - 1; i++)
            {
                if (niz[i] > niz[i + 1])
                {
                    brojPoredjenja++;
                    return false;
                } 
            }
            return true;
        }

        public void Ispisi()
        {
            for (int i = 0; i < niz.Count() - 1; i++)
            {
                g.FillRectangle(BojaPravougaonika, i, maxVal - niz[i], 1, maxVal);
            }
        }

        public void OcitajLog(Label lblPristup, Label lblPoredjenja)
        {
            lblPoredjenja.Text = "Puta poredjeni elementi: " + brojPoredjenja;
            lblPristup.Text = "Puta pristupljeno nizu: " + brojPristupa;
        }

        public void Haha()
        {

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
