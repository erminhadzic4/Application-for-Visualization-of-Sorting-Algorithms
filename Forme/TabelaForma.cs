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
    public partial class TabelaForma : Form
    {
        public TabelaForma()
        {
            InitializeComponent();
            dataGridView1.GridColor = Boja.Primarna;
        }

        private void TabelaForma_Load(object sender, EventArgs e)
        {
            this.dataGridView1.Font = new Font("Mongolian Baiti", 12); 
            DataTable tabela = new DataTable();
            dataGridView1.EnableHeadersVisualStyles = false;
            tabela.Columns.Add("Algoritam", typeof(string));
            tabela.Columns.Add("Izvrsavanje", typeof(string));
            tabela.Columns.Add("Broj pristupa", typeof(int));
            tabela.Columns.Add("Broj poredjenja", typeof(int));

            string[] informacije = File.ReadAllLines("../../Postavke/algoritmi_tabela.txt");
            for (int i = 0; i < informacije.Length; i++)
            {
                string[] red = informacije[i].ToString().Split('|');
                string[] novi = new string[red.Length];

                for (int j = 0; j < red.Length; j++)
                {
                    novi[j] = red[j].Trim();
                }
                tabela.Rows.Add(novi);
            }

            dataGridView1.DataSource = tabela;
        }


    }
}
