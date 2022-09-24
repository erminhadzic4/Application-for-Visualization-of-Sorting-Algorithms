using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Algoritmi_Sortiranja.Forme
{
    public partial class BubbleForma : Form
    {
        private string[] postavke;
        private Brush BojaPravougaonika = new System.Drawing.SolidBrush(Boja.Primarna);
        private Brush BojaPozadine = new System.Drawing.SolidBrush(Color.FromArgb(240, 240, 240));
        private Graphics g;
        private int[] niz;
        private BackgroundWorker w = null;

        public BubbleForma()
        {
            InitializeComponent();
            postavke = File.ReadAllLines("../../Postavke/postavke.txt");
            if (postavke[0].Contains("UKLJUCENO")) lblPristupljeno.Visible = true;
            else lblPristupljeno.Visible = false;
            if (postavke[1].Contains("UKLJUCENO")) lblPoredjeno.Visible = true;
            else lblPoredjeno.Visible = false;
            if (postavke[2].Contains("UKLJUCENO"))
            {
                lblPoredjeno.Visible = true;
                lblPristupljeno.Visible = true;
            }
        }

        private void UcitajBoju()
        {
            foreach (Control dugme in this.Controls)
            {
                if (dugme.GetType() == typeof(MojeCustomDugme))
                {
                    MojeCustomDugme btn = (MojeCustomDugme)dugme;
                    btn.BackgroundColor = Boja.Primarna;
                }
                if (dugme.GetType() == typeof(Button))
                {
                    Button btn = (Button)dugme;
                    btn.BackColor = Boja.Primarna;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = Boja.Sekundarna;
                }

            }
        }

        private void BubbleForma_Load(object sender, EventArgs e)
        {
            UcitajBoju();
        }
        public void w_IzvrsiWorkera(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker w = sender as BackgroundWorker;
            string ImeAlgoritma = (string)e.Argument;
            Type tip = Type.GetType("Algoritmi_Sortiranja." + ImeAlgoritma);
            var kons = tip.GetConstructors();
            try
            {
                SortEngine engine = new BubbleSort(niz, g, panel1.Height);
                while (!engine.Sortirana() && (!w.CancellationPending))
                {
                    engine.Sljedeci();
                }
                engine.OcitajLog(lblPristupljeno, lblPoredjeno);
            }
            catch (Exception izuzetak)
            {
                _ = izuzetak.Message;
            }
        }

        private void btnGenerisi_Click(object sender, EventArgs e)
        {
            if (w != null && w.IsBusy) return;
            lblPoredjeno.Text = "Puta poredjeni elementi: 0";
            lblPristupljeno.Text = "Puta pristupljeno nizu: 0";
            int numEntries = panel1.Width;
            int maxVal = panel1.Height;
            g = panel1.CreateGraphics();
            g.FillRectangle(new System.Drawing.SolidBrush(panel1.BackColor), 0, 0, numEntries, maxVal);
            niz = new int[numEntries];
            Random rand = new Random();
            for (int i = 0; i < numEntries; i++)
            {
                niz[i] = rand.Next(0, maxVal);
                g.FillRectangle(new System.Drawing.SolidBrush(Boja.Primarna), i, maxVal - niz[i], 1, maxVal);
            }
        }

        private void btnSortiraj_Click(object sender, EventArgs e)
        {
            if (w != null && w.IsBusy) return;
            if (niz == null)
            {
                MessageBox.Show("Prvo generisite niz za sortiranje");
                return;
            }
            w = new BackgroundWorker();
            w.WorkerSupportsCancellation = true;
            w.DoWork += new DoWorkEventHandler(w_IzvrsiWorkera);
            w.RunWorkerAsync(argument: "BubbleSort");
        }
    }
}
