using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Algoritmi_Sortiranja.Forme
{
    public partial class PostavkeForma : Form
    {
        private string[] postavke;
        private bool[] nove_postavke = new bool[5];
        private string[] priv = new string[] { "ISKLJUCENO", "UKLJUCENO" };

        public PostavkeForma()
        {
            InitializeComponent();
        }

        private void PostavkeForma_Load(object sender, EventArgs e)
        {
            btnSpasi.BackColor = Boja.Primarna;
            postavke = File.ReadAllLines("../../Postavke/postavke.txt");
            if (postavke[0].Contains("UKLJUCENO")) lblPristup.Checked = true;
            if (postavke[1].Contains("UKLJUCENO")) lblPoredenje.Checked = true;
            if (postavke[2].Contains("UKLJUCENO")) lblOboje.Checked = true;
            if (postavke[3].Contains("UKLJUCENO")) lblVrijemeIzvr.Checked = true;
            if (postavke[4].Contains("UKLJUCENO")) lblSpasavanjeUFile.Checked = true;
        }

        private void lblPristup_CheckedChanged(object sender, EventArgs e)
        {
            if (lblPristup.Checked) nove_postavke[0] = true;
            else nove_postavke[0] = false;
        }

        private void lblPoredenje_CheckedChanged(object sender, EventArgs e)
        {
            if (lblPoredenje.Checked) nove_postavke[1] = true;
            else nove_postavke[1] = false;
        }

        private void lblOboje_CheckedChanged(object sender, EventArgs e)
        {
            if (lblOboje.Checked)
            {
                nove_postavke[0] = true;
                nove_postavke[1] = true;
                nove_postavke[2] = true;
                lblPoredenje.Checked = true;
                lblPristup.Checked = true;
            }
            else
            {
                nove_postavke[0] = false;
                nove_postavke[1] = false;
                nove_postavke[2] = false;
                lblPoredenje.Checked = false;
                lblPristup.Checked = false;
            }
        }

        private void lblVrijemeIzvr_CheckedChanged(object sender, EventArgs e)
        {
            if (lblVrijemeIzvr.Checked) nove_postavke[3] = true;
            else nove_postavke[3] = false;
        }

        private void lblSpasavanjeUFile_CheckedChanged(object sender, EventArgs e)
        {
            if (lblSpasavanjeUFile.Checked) nove_postavke[4] = true;
            else nove_postavke[4] = false;
        }

        private void btnSpasi_Click(object sender, EventArgs e)
        {
            string[] pocetne_postavke =
            {
            "Ispisivanje pristupa = " + priv[Convert.ToInt32(nove_postavke[0])],
            "Ispisivanje poredenja = " + priv[Convert.ToInt32(nove_postavke[1])],
            "Ispisivanje i pristupa i poredenja = " + priv[Convert.ToInt32(nove_postavke[2])],
            "Ispisivanje vremena izvrsavanja = " + priv[Convert.ToInt32(nove_postavke[3])],
            "Spasavanje informacija o poredenju u file = " + priv[Convert.ToInt32(nove_postavke[4])],
            };

            using (StreamWriter outputFile = new StreamWriter(Path.Combine("../../Postavke", "postavke.txt")))
            {
                foreach (string red in pocetne_postavke)
                    outputFile.WriteLine(red);
            }
        }
    }
}
