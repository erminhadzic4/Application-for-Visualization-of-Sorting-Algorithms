using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algoritmi_Sortiranja
{
    public partial class GlavnaForma : Form
    {
        private string[] postavke;
        private Button trenutnoDugme;
        private Random random;
        private int privIndeks;
        private Form trenutnaForma;
        private string[] pocetne_postavke =
        {
            "Ispisivanje pristupa = ISKLJUCENO",
            "Ispisivanje poredenja = ISKLJUCENO",
            "Ispisivanje i pristupa i poredenja = ISKLJUCENO",
            "Ispisivanje vremena izvrsavanja = ISKLJUCENO",
            "Spasavanje informacija o poredenju u file = ISKLJUCENO",
        };

        public GlavnaForma()
        {
            InitializeComponent();
            random = new Random();
            btnPocetak.Visible = false;
            this.Text = String.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private Color IzabirBoje()
        {
            int indeks = random.Next(Boja.Boje.Count);
            while (privIndeks == indeks)
            {
                indeks = random.Next(Boja.Boje.Count);
            }
            privIndeks = indeks;
            string boja = Boja.Boje[indeks];
            return ColorTranslator.FromHtml(boja);
        }

        private void AktivirajDugme(object sender)
        {
            if (sender != null)
            {
                if (trenutnoDugme != (Button)sender)
                {
                    DeaktivirajDugme();
                    Color boja = IzabirBoje();
                    trenutnoDugme = (Button)sender;
                    trenutnoDugme.BackColor = boja;
                    trenutnoDugme.ForeColor = Color.White;
                    trenutnoDugme.Font = new System.Drawing.Font("Microsoft Yi Baiti", 22.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelTitle.BackColor = boja;
                    panelLogo.BackColor = Boja.JacinaBoje(boja, -0.5f);
                    Boja.Primarna = boja;
                    Boja.Sekundarna = Boja.JacinaBoje(boja, -0.5f);
                    btnPocetak.Visible = true;
                }
            }
        }
        
        private void DeaktivirajDugme()
        {
            foreach(Control prethodnoDugme in izabirAlgoritama.Controls)
            {
                if(prethodnoDugme.GetType() == typeof(Button))
                {
                    prethodnoDugme.BackColor = Color.FromArgb(61, 61, 61);
                    prethodnoDugme.Font = new System.Drawing.Font("Microsoft Yi Baiti", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    if (prethodnoDugme.Name != "btnPostavke")
                    {
                    prethodnoDugme.ForeColor = Color.Gainsboro;
                    
                    }
                }
            }
        }

        private void OtvoriFormu(Form forma, object sender)
        {
            if (trenutnaForma != null)
            {
                trenutnaForma.Close();
            }
            AktivirajDugme(sender);
            trenutnaForma = forma;
            forma.TopLevel = false;
            forma.FormBorderStyle = FormBorderStyle.None;
            forma.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(forma);
            this.panel1.Tag = forma;
            forma.BringToFront();
            forma.Show();
            switch (forma.Text)
            {
                case "BubbleForma":
                    lblTitle.Text = "       BUBBLE SORT";
                    break;
                case "QuickForma":
                    lblTitle.Text = "       QUICK SORT";
                    break;
                case "MergeForma":
                    lblTitle.Text = "       MERGE SORT";
                    break;
                case "InsertionForma":
                    lblTitle.Text = "     INSERTION SORT";
                    break;
                case "SelectionForma":
                    lblTitle.Text = "     SELECTION SORT";
                    break;
                case "RadixForma":
                    lblTitle.Text = "       RADIX SORT";
                    break;
                case "MaxHeapForma":
                    lblTitle.Text = "      MAX HEAP SORT";
                    break;
                case "ShellForma":
                    lblTitle.Text = "       SHELL SORT";
                    break;
                case "UporediForma":
                    lblTitle.Text = "    UPOREDI ALGORITME";
                    break;
                default:
                    break;
            }

        }

        private void btnBubble_Click(object sender, EventArgs e)
        {
            txtboxNaslov.Visible = false;
            rtxtBoxInfo.Visible = false;
            OtvoriFormu(new Forme.BubbleForma(), sender);
        }

        private void btnQuick_Click(object sender, EventArgs e)
        {
            txtboxNaslov.Visible = false;
            rtxtBoxInfo.Visible = false;
            OtvoriFormu(new Forme.QuickForma(), sender);
        }

        private void btnMerge_Click(object sender, EventArgs e)
        {
            txtboxNaslov.Visible = false;
            rtxtBoxInfo.Visible = false;
            OtvoriFormu(new Forme.MergeForma(), sender);
        }

        private void btnInsertion_Click(object sender, EventArgs e)
        {
            txtboxNaslov.Visible = false;
            rtxtBoxInfo.Visible = false;
            OtvoriFormu(new Forme.InsertionForma(), sender);
        }

        private void btnSelection_Click(object sender, EventArgs e)
        {
            txtboxNaslov.Visible = false;
            rtxtBoxInfo.Visible = false;
            OtvoriFormu(new Forme.SelectionForma(), sender);
        }

        private void btnRadix_Click(object sender, EventArgs e)
        {
            txtboxNaslov.Visible = false;
            rtxtBoxInfo.Visible = false;
            OtvoriFormu(new Forme.RadixForma(), sender);
        }

        private void btnMaxHeap_Click(object sender, EventArgs e)
        {
            txtboxNaslov.Visible = false;
            rtxtBoxInfo.Visible = false;
            OtvoriFormu(new Forme.MaxHeapForma(), sender);
        }


        private void btnPocetak_Click(object sender, EventArgs e)
        {
            if (trenutnaForma != null)
            {
                trenutnaForma.Close();
                DeaktivirajDugme();
                lblTitle.Text = "ALGORITMI SORTIRANJA";
                panelTitle.BackColor = Color.Teal;
                panelLogo.BackColor = Color.FromArgb(31,31,31);
                trenutnoDugme = null;
                btnPocetak.Visible = false;
                txtboxNaslov.Visible = true;
                rtxtBoxInfo.Visible = true;
            }
        }

        private void panelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            postavke = File.ReadAllLines("../../Postavke/postavke.txt");
            if (postavke[4].Contains("ISKLJUCENO")) File.Delete("../../Postavke/algoritmi_tabela.txt");
            Application.Exit();
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnPoredi_Click(object sender, EventArgs e)
        {
            txtboxNaslov.Visible = false;
            rtxtBoxInfo.Visible = false;
            OtvoriFormu(new Forme.UporediForma(), sender);
        }

        private void btnShell_Click(object sender, EventArgs e)
        {
            txtboxNaslov.Visible = false;
            rtxtBoxInfo.Visible = false;
            OtvoriFormu(new Forme.ShellForma(), sender);
        }

        private void btnPostavke_Click_1(object sender, EventArgs e)
        {
            txtboxNaslov.Visible = false;
            rtxtBoxInfo.Visible = false;
            OtvoriFormu(new Forme.PostavkeForma(), sender);
        }

        private void btnPoredi_Click_1(object sender, EventArgs e)
        {
            txtboxNaslov.Visible = false;
            rtxtBoxInfo.Visible = false;
            OtvoriFormu(new Forme.UporediForma(), sender);
        }

        private void GlavnaForma_Load(object sender, EventArgs e)
        {
            using (StreamWriter outputFile = new StreamWriter(Path.Combine("../../Postavke", "postavke.txt")))
            {
                foreach (string red in pocetne_postavke)
                    outputFile.WriteLine(red);
            }
        }
    }
}
