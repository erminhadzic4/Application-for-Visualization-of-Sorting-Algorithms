using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algoritmi_Sortiranja.Forme
{
    public partial class UporediForma : Form
    {
        private string[] postavke;
        private Brush BojaPravougaonika = new System.Drawing.SolidBrush(Boja.Primarna);
        private int puta_pozvano = 0;
        private Brush BojaPozadine = new System.Drawing.SolidBrush(Color.FromArgb(240, 240, 240));
        private Graphics g1,g2,g3,g4,g5,g6,g7,g8;
        private bool aktivan = false;
        private int vrijemeMS = 0, vrijemeS = 0, vrijemeM = 0;
        private Label trenutniLabel;
        private int[] nizPoredjenja = new int[8];
        private int[] nizPristupa = new int [8];
        private string[] nizVremenaIzvrsavanja = new string[8];
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (aktivan)
            {
                vrijemeMS++;
                if (vrijemeMS >= 100)
                {
                    vrijemeS++;
                    vrijemeMS = 0;
                    if (vrijemeS >= 60)
                    {
                        vrijemeM++;
                        vrijemeS = 0;
                    }
                }

                Obnovi();
            }
        }

        private void Obnovi()
        {
            trenutniLabel.Text = "(" + (vrijemeMS + vrijemeS * 1000) + ") " + vrijemeM + "m " + vrijemeS + "s " + vrijemeMS + "ms";
        }

        private void mbtnOtvoriTab_Click(object sender, EventArgs e)
        {
            foreach (Control dugme in this.Controls)
            {
                if (dugme.GetType() == typeof(Label))
                {
                    Label btn = (Label)dugme;
                    btn.Visible = false;
                }
            }
            if (w1 != null && w1.IsBusy) return;
            panelTabela.Visible = true;
            Form forma = new TabelaForma();
            forma.TopLevel = false;
            forma.FormBorderStyle = FormBorderStyle.None;
            forma.Dock = DockStyle.Fill;
            this.panelTabela.Controls.Add(forma);
            this.panelTabela.Tag = forma;
            forma.BringToFront();
            forma.Show();
        }

        private int[] niz1, niz2, niz3, niz4, niz5, niz6, niz7, niz8;

        private void UporediForma_Load(object sender, EventArgs e)
        {
            UcitajBoju();
            postavke = File.ReadAllLines("../../Postavke/postavke.txt");
            if (postavke[3].Contains("ISKLJUCENO"))
            {
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
            }
        }

        private BackgroundWorker w1 = null, w2 = null, w3 = null, w4 = null, w5 = null, w6 = null, w7 = null, w8 = null;

        public UporediForma()
        {

            InitializeComponent();
            UcitajBoju();
        }

        private void mbtnPocni_Click(object sender, EventArgs e)
        {
            if (w1 != null && w1.IsBusy) return;
            int numEntries = mpanel1.Width;
            int maxVal = mpanel1.Height;
            if (puta_pozvano > 0)
            {
                g1.FillRectangle(new System.Drawing.SolidBrush(mpanel4.BackColor), 0, 0, numEntries, maxVal);
                g2.FillRectangle(new System.Drawing.SolidBrush(mpanel4.BackColor), 0, 0, numEntries, maxVal);
                g3.FillRectangle(new System.Drawing.SolidBrush(mpanel4.BackColor), 0, 0, numEntries, maxVal);
                g4.FillRectangle(new System.Drawing.SolidBrush(mpanel4.BackColor), 0, 0, numEntries, maxVal);
                g5.FillRectangle(new System.Drawing.SolidBrush(mpanel4.BackColor), 0, 0, numEntries, maxVal);
                g6.FillRectangle(new System.Drawing.SolidBrush(mpanel4.BackColor), 0, 0, numEntries, maxVal);
                g7.FillRectangle(new System.Drawing.SolidBrush(mpanel4.BackColor), 0, 0, numEntries, maxVal);
                g8.FillRectangle(new System.Drawing.SolidBrush(mpanel4.BackColor), 0, 0, numEntries, maxVal);
            }
            g1 = mpanel1.CreateGraphics();
            g2 = mpanel2.CreateGraphics();
            g3 = mpanel3.CreateGraphics();
            g4 = mpanel4.CreateGraphics();
            g5 = mpanel5.CreateGraphics();
            g6 = mpanel6.CreateGraphics();
            g7 = mpanel7.CreateGraphics();
            g8 = mpanel8.CreateGraphics();
            niz1 = new int[numEntries];
            niz2 = new int[numEntries];
            niz3 = new int[numEntries];
            niz4 = new int[numEntries];
            niz5 = new int[numEntries];
            niz6 = new int[numEntries];
            niz7 = new int[numEntries];
            niz8 = new int[numEntries];
            Random rand = new Random();
            for (int i = 0; i < numEntries; i++)
            {
                int br = rand.Next(0, maxVal);
                niz1[i] = br;
                niz2[i] = br;
                niz3[i] = br;
                niz4[i] = br;
                niz5[i] = br;
                niz6[i] = br;
                niz7[i] = br;
                niz8[i] = br;
                g1.FillRectangle(new System.Drawing.SolidBrush(Boja.Primarna), i, maxVal - niz1[i], 1, maxVal);
                g2.FillRectangle(new System.Drawing.SolidBrush(Boja.Primarna), i, maxVal - niz1[i], 1, maxVal);
                g3.FillRectangle(new System.Drawing.SolidBrush(Boja.Primarna), i, maxVal - niz1[i], 1, maxVal);
                g4.FillRectangle(new System.Drawing.SolidBrush(Boja.Primarna), i, maxVal - niz1[i], 1, maxVal);
                g5.FillRectangle(new System.Drawing.SolidBrush(Boja.Primarna), i, maxVal - niz1[i], 1, maxVal);
                g6.FillRectangle(new System.Drawing.SolidBrush(Boja.Primarna), i, maxVal - niz1[i], 1, maxVal);
                g7.FillRectangle(new System.Drawing.SolidBrush(Boja.Primarna), i, maxVal - niz1[i], 1, maxVal);
                g8.FillRectangle(new System.Drawing.SolidBrush(Boja.Primarna), i, maxVal - niz1[i], 1, maxVal);
            }

            w1 = new BackgroundWorker();
            w1.WorkerSupportsCancellation = true;
            w1.DoWork += new DoWorkEventHandler(w_IzvrsiWorkera);
            w1.RunWorkerAsync(argument: "SelectionSort");

            

            w2 = new BackgroundWorker();
            w2.WorkerSupportsCancellation = true;
            w2.DoWork += new DoWorkEventHandler(w_IzvrsiWorkera);
            w2.RunWorkerAsync(argument: "InsertionSort");

            w3 = new BackgroundWorker();
            w3.WorkerSupportsCancellation = true;
            w3.DoWork += new DoWorkEventHandler(w_IzvrsiWorkera);
            w3.RunWorkerAsync(argument: "QuickSort");

            w4 = new BackgroundWorker();
            w4.WorkerSupportsCancellation = true;
            w4.DoWork += new DoWorkEventHandler(w_IzvrsiWorkera);
            w4.RunWorkerAsync(argument: "MergeSort");

            w5 = new BackgroundWorker();
            w5.WorkerSupportsCancellation = true;
            w5.DoWork += new DoWorkEventHandler(w_IzvrsiWorkera);
            w5.RunWorkerAsync(argument: "BubbleSort");

            w6 = new BackgroundWorker();
            w6.WorkerSupportsCancellation = true;
            w6.DoWork += new DoWorkEventHandler(w_IzvrsiWorkera);
            w6.RunWorkerAsync(argument: "RadixSort");

            w7 = new BackgroundWorker();
            w7.WorkerSupportsCancellation = true;
            w7.DoWork += new DoWorkEventHandler(w_IzvrsiWorkera);
            w7.RunWorkerAsync(argument: "MaxHeapSort");

            w8 = new BackgroundWorker();
            w8.WorkerSupportsCancellation = true;
            w8.DoWork += new DoWorkEventHandler(w_IzvrsiWorkera);
            w8.RunWorkerAsync(argument: "MaxHeapSort");

            puta_pozvano++;
        }

        private void ResetujVrijeme()
        {
            vrijemeM = 0;
            vrijemeMS = 0;
            vrijemeS = 0;
        }

        private void UcitajBoju()
        {
            foreach (Control labele in this.Controls)
            {
                if (labele.GetType() == typeof(Label))
                {
                    Label lbl = (Label)labele;
                    lbl.Text = "";
                }
            }
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
                    if (((Button)dugme).Name == "btnPauziraj" || ((Button)dugme).Name == "btnSkrati")
                    {
                        float red = (float)Boja.Primarna.R;
                        float green = (float)Boja.Primarna.G;
                        float blue = (float)Boja.Primarna.B;

                        red *= 0.6f;
                        green *= 0.6f;
                        blue *= 0.6f;

                        btn.BackColor = Color.FromArgb(Boja.Primarna.A, (int)red, (int)green, (int)blue);
                        btn.ForeColor = Color.White;
                    }
                }
            }
        }

        public void w_IzvrsiWorkera(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker w = sender as BackgroundWorker;
            string ImeAlgoritma = (string)e.Argument;
            Type tip = Type.GetType("Algoritmi_Sortiranja." + ImeAlgoritma);
            var kons = tip.GetConstructors();
            try
            {
                trenutniLabel = label1;
                aktivan = true;
                SortEngine engine1 = new BubbleSort(niz1, g1, mpanel4.Height);
                while (!engine1.Sortirana() && (!w.CancellationPending))
                {
                    engine1.Sljedeci();
                }

                nizPoredjenja[0] = engine1.DajBrPoredjenja();
                nizPristupa[0] = engine1.DajBrPristupa();
                nizVremenaIzvrsavanja[0] = label1.Text;

                ResetujVrijeme();
                trenutniLabel = label2;

                SortEngine engine2 = new InsertionSort(niz2, g2, mpanel8.Height);
                while (!engine2.Sortirana() && (!w.CancellationPending))
                {
                    engine2.Sljedeci();
                }

                nizPoredjenja[1] = engine2.DajBrPoredjenja();
                nizPristupa[1] = engine2.DajBrPristupa();
                nizVremenaIzvrsavanja[1] = label2.Text;

                ResetujVrijeme();
                trenutniLabel = label3;

                SortEngine engine3 = new MaxHeapSort(niz3, g3, mpanel7.Height);
                while (!engine3.Sortirana() && (!w.CancellationPending))
                {
                    engine3.Sljedeci();
                }

                nizPoredjenja[2] = engine3.DajBrPoredjenja();
                nizPristupa[2] = engine3.DajBrPristupa();
                nizVremenaIzvrsavanja[2] = label3.Text;

                ResetujVrijeme();
                trenutniLabel = label4;

                SortEngine engine4 = new MergeSort(niz4, g4, mpanel5.Height);
                while (!engine4.Sortirana() && (!w.CancellationPending))
                {
                    engine4.Sljedeci();
                }

                nizPoredjenja[3] = engine4.DajBrPoredjenja();
                nizPristupa[3] = engine4.DajBrPristupa();
                nizVremenaIzvrsavanja[3] = label4.Text;

                ResetujVrijeme();
                trenutniLabel = label5;

                SortEngine engine5 = new QuickSort(niz5, g5, mpanel6.Height);
                while (!engine5.Sortirana() && (!w.CancellationPending))
                {
                    engine5.Sljedeci();
                }

                nizPoredjenja[4] = engine5.DajBrPoredjenja();
                nizPristupa[4] = engine5.DajBrPristupa();
                nizVremenaIzvrsavanja[4] = label5.Text;

                ResetujVrijeme();
                trenutniLabel = label6;

                SortEngine engine6 = new RadixSort(niz6, g6, mpanel3.Height);
                while (!engine6.Sortirana() && (!w.CancellationPending))
                {
                    engine6.Sljedeci();
                }

                nizPoredjenja[5] = engine6.DajBrPoredjenja();
                nizPristupa[5] = engine6.DajBrPristupa();
                nizVremenaIzvrsavanja[5] = label6.Text;

                ResetujVrijeme();
                trenutniLabel = label7;

                SortEngine engine7 = new SelectionSort(niz7, g7, mpanel1.Height);
                while (!engine7.Sortirana() && (!w.CancellationPending))
                {
                    engine7.Sljedeci();
                }

                nizPoredjenja[6] = engine7.DajBrPoredjenja();
                nizPristupa[6] = engine7.DajBrPristupa();
                nizVremenaIzvrsavanja[6] = label7.Text;

                ResetujVrijeme();
                trenutniLabel = label8;

                SortEngine engine8 = new ShellSort(niz8, g8, mpanel2.Height);
                while (!engine8.Sortirana() && (!w.CancellationPending))
                {
                    engine8.Sljedeci();
                }

                nizPoredjenja[7] = engine8.DajBrPoredjenja();
                nizPristupa[7] = engine8.DajBrPristupa();
                nizVremenaIzvrsavanja[7] = label8.Text;

                ResetujVrijeme();
                aktivan = false;


                File.WriteAllText("../../Postavke/algoritmi_tabela.txt", "Bubble Sort | " + nizVremenaIzvrsavanja[0] + " | " + nizPristupa[0] + " | " + nizPoredjenja[0] + "\n" +
                                                    "Insertion Sort | " + nizVremenaIzvrsavanja[1] + " | " + nizPristupa[1] + " | " + nizPoredjenja[1] + "\n" +
                                                    "Max Heap Sort | " + nizVremenaIzvrsavanja[2] + " | " + nizPristupa[2] + " | " + nizPoredjenja[2] + "\n" +
                                                    "Merge Sort | " + nizVremenaIzvrsavanja[3] + " | " + nizPristupa[3] + " | " + nizPoredjenja[3] + "\n" +
                                                    "Quick Sort | " + nizVremenaIzvrsavanja[4] + " | " + nizPristupa[4] + " | " + nizPoredjenja[4] + "\n" +
                                                    "Radix Sort | " + nizVremenaIzvrsavanja[5] + " | " + nizPristupa[5] + " | " + nizPoredjenja[5] + "\n" +
                                                    "Selection Sort | " + nizVremenaIzvrsavanja[6] + " | " + nizPristupa[6] + " | " + nizPoredjenja[6] + "\n" +
                                                    "Shell Sort | " + nizVremenaIzvrsavanja[7] + " | " + nizPristupa[7] + " | " + nizPoredjenja[7] + "\n"
                 );

                foreach (var item in niz1)
                {
                    Console.WriteLine(item + " ");
                }
            }
            catch (Exception izuzetak)
            {
                _ = izuzetak.Message;
            }
        }
    }
}
