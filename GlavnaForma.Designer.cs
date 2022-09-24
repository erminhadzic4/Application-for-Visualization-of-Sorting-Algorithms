namespace Algoritmi_Sortiranja
{
    partial class GlavnaForma
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GlavnaForma));
            this.izabirAlgoritama = new System.Windows.Forms.Panel();
            this.btnPostavke = new System.Windows.Forms.Button();
            this.btnPoredi = new System.Windows.Forms.Button();
            this.btnShell = new System.Windows.Forms.Button();
            this.btnMaxHeap = new System.Windows.Forms.Button();
            this.btnRadix = new System.Windows.Forms.Button();
            this.btnSelection = new System.Windows.Forms.Button();
            this.btnInsertion = new System.Windows.Forms.Button();
            this.btnMerge = new System.Windows.Forms.Button();
            this.btnQuick = new System.Windows.Forms.Button();
            this.btnBubble = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.lblIme = new System.Windows.Forms.Label();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.btnPocetak = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.txtboxNaslov = new System.Windows.Forms.TextBox();
            this.rtxtBoxInfo = new System.Windows.Forms.RichTextBox();
            this.izabirAlgoritama.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitle.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // izabirAlgoritama
            // 
            this.izabirAlgoritama.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.izabirAlgoritama.Controls.Add(this.btnPostavke);
            this.izabirAlgoritama.Controls.Add(this.btnPoredi);
            this.izabirAlgoritama.Controls.Add(this.btnShell);
            this.izabirAlgoritama.Controls.Add(this.btnMaxHeap);
            this.izabirAlgoritama.Controls.Add(this.btnRadix);
            this.izabirAlgoritama.Controls.Add(this.btnSelection);
            this.izabirAlgoritama.Controls.Add(this.btnInsertion);
            this.izabirAlgoritama.Controls.Add(this.btnMerge);
            this.izabirAlgoritama.Controls.Add(this.btnQuick);
            this.izabirAlgoritama.Controls.Add(this.btnBubble);
            this.izabirAlgoritama.Controls.Add(this.panelLogo);
            this.izabirAlgoritama.Dock = System.Windows.Forms.DockStyle.Left;
            this.izabirAlgoritama.Location = new System.Drawing.Point(0, 0);
            this.izabirAlgoritama.Name = "izabirAlgoritama";
            this.izabirAlgoritama.Size = new System.Drawing.Size(200, 661);
            this.izabirAlgoritama.TabIndex = 0;
            // 
            // btnPostavke
            // 
            this.btnPostavke.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPostavke.FlatAppearance.BorderSize = 0;
            this.btnPostavke.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPostavke.Font = new System.Drawing.Font("Microsoft Yi Baiti", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPostavke.ForeColor = System.Drawing.Color.Red;
            this.btnPostavke.Location = new System.Drawing.Point(0, 608);
            this.btnPostavke.Name = "btnPostavke";
            this.btnPostavke.Size = new System.Drawing.Size(200, 50);
            this.btnPostavke.TabIndex = 10;
            this.btnPostavke.Text = "Postavke";
            this.btnPostavke.UseVisualStyleBackColor = true;
            this.btnPostavke.Click += new System.EventHandler(this.btnPostavke_Click_1);
            // 
            // btnPoredi
            // 
            this.btnPoredi.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPoredi.FlatAppearance.BorderSize = 0;
            this.btnPoredi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPoredi.Font = new System.Drawing.Font("Microsoft Yi Baiti", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPoredi.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnPoredi.Location = new System.Drawing.Point(0, 560);
            this.btnPoredi.Name = "btnPoredi";
            this.btnPoredi.Size = new System.Drawing.Size(200, 48);
            this.btnPoredi.TabIndex = 9;
            this.btnPoredi.Text = "Poredi algoritme";
            this.btnPoredi.UseVisualStyleBackColor = true;
            this.btnPoredi.Click += new System.EventHandler(this.btnPoredi_Click_1);
            // 
            // btnShell
            // 
            this.btnShell.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnShell.FlatAppearance.BorderSize = 0;
            this.btnShell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShell.Font = new System.Drawing.Font("Microsoft Yi Baiti", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShell.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnShell.Location = new System.Drawing.Point(0, 500);
            this.btnShell.Name = "btnShell";
            this.btnShell.Size = new System.Drawing.Size(200, 60);
            this.btnShell.TabIndex = 8;
            this.btnShell.Text = "Shell sort";
            this.btnShell.UseVisualStyleBackColor = true;
            this.btnShell.Click += new System.EventHandler(this.btnShell_Click);
            // 
            // btnMaxHeap
            // 
            this.btnMaxHeap.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMaxHeap.FlatAppearance.BorderSize = 0;
            this.btnMaxHeap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaxHeap.Font = new System.Drawing.Font("Microsoft Yi Baiti", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaxHeap.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMaxHeap.Location = new System.Drawing.Point(0, 440);
            this.btnMaxHeap.Name = "btnMaxHeap";
            this.btnMaxHeap.Size = new System.Drawing.Size(200, 60);
            this.btnMaxHeap.TabIndex = 7;
            this.btnMaxHeap.Text = "Max Heap sort";
            this.btnMaxHeap.UseVisualStyleBackColor = true;
            this.btnMaxHeap.Click += new System.EventHandler(this.btnMaxHeap_Click);
            // 
            // btnRadix
            // 
            this.btnRadix.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRadix.FlatAppearance.BorderSize = 0;
            this.btnRadix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRadix.Font = new System.Drawing.Font("Microsoft Yi Baiti", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRadix.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnRadix.Location = new System.Drawing.Point(0, 380);
            this.btnRadix.Name = "btnRadix";
            this.btnRadix.Size = new System.Drawing.Size(200, 60);
            this.btnRadix.TabIndex = 6;
            this.btnRadix.Text = "Radix sort";
            this.btnRadix.UseVisualStyleBackColor = true;
            this.btnRadix.Click += new System.EventHandler(this.btnRadix_Click);
            // 
            // btnSelection
            // 
            this.btnSelection.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSelection.FlatAppearance.BorderSize = 0;
            this.btnSelection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelection.Font = new System.Drawing.Font("Microsoft Yi Baiti", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelection.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSelection.Location = new System.Drawing.Point(0, 320);
            this.btnSelection.Name = "btnSelection";
            this.btnSelection.Size = new System.Drawing.Size(200, 60);
            this.btnSelection.TabIndex = 5;
            this.btnSelection.Text = "Selection sort";
            this.btnSelection.UseVisualStyleBackColor = true;
            this.btnSelection.Click += new System.EventHandler(this.btnSelection_Click);
            // 
            // btnInsertion
            // 
            this.btnInsertion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInsertion.FlatAppearance.BorderSize = 0;
            this.btnInsertion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsertion.Font = new System.Drawing.Font("Microsoft Yi Baiti", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertion.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnInsertion.Location = new System.Drawing.Point(0, 260);
            this.btnInsertion.Name = "btnInsertion";
            this.btnInsertion.Size = new System.Drawing.Size(200, 60);
            this.btnInsertion.TabIndex = 4;
            this.btnInsertion.Text = "Insertion sort";
            this.btnInsertion.UseVisualStyleBackColor = true;
            this.btnInsertion.Click += new System.EventHandler(this.btnInsertion_Click);
            // 
            // btnMerge
            // 
            this.btnMerge.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMerge.FlatAppearance.BorderSize = 0;
            this.btnMerge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMerge.Font = new System.Drawing.Font("Microsoft Yi Baiti", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMerge.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMerge.Location = new System.Drawing.Point(0, 200);
            this.btnMerge.Name = "btnMerge";
            this.btnMerge.Size = new System.Drawing.Size(200, 60);
            this.btnMerge.TabIndex = 3;
            this.btnMerge.Text = "Merge sort";
            this.btnMerge.UseVisualStyleBackColor = true;
            this.btnMerge.Click += new System.EventHandler(this.btnMerge_Click);
            // 
            // btnQuick
            // 
            this.btnQuick.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQuick.FlatAppearance.BorderSize = 0;
            this.btnQuick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuick.Font = new System.Drawing.Font("Microsoft Yi Baiti", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuick.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnQuick.Location = new System.Drawing.Point(0, 140);
            this.btnQuick.Name = "btnQuick";
            this.btnQuick.Size = new System.Drawing.Size(200, 60);
            this.btnQuick.TabIndex = 2;
            this.btnQuick.Text = "Quick sort";
            this.btnQuick.UseVisualStyleBackColor = true;
            this.btnQuick.Click += new System.EventHandler(this.btnQuick_Click);
            // 
            // btnBubble
            // 
            this.btnBubble.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBubble.FlatAppearance.BorderSize = 0;
            this.btnBubble.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBubble.Font = new System.Drawing.Font("Microsoft Yi Baiti", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBubble.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnBubble.Location = new System.Drawing.Point(0, 80);
            this.btnBubble.Name = "btnBubble";
            this.btnBubble.Size = new System.Drawing.Size(200, 60);
            this.btnBubble.TabIndex = 1;
            this.btnBubble.Text = "Bubble sort";
            this.btnBubble.UseVisualStyleBackColor = true;
            this.btnBubble.Click += new System.EventHandler(this.btnBubble_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.panelLogo.Controls.Add(this.lblIme);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(200, 80);
            this.panelLogo.TabIndex = 0;
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIme.ForeColor = System.Drawing.Color.White;
            this.lblIme.Location = new System.Drawing.Point(51, 29);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(97, 18);
            this.lblIme.TabIndex = 0;
            this.lblIme.Text = "Ermin Hadžić";
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.Teal;
            this.panelTitle.Controls.Add(this.btnMin);
            this.panelTitle.Controls.Add(this.btnMax);
            this.panelTitle.Controls.Add(this.btnZatvori);
            this.panelTitle.Controls.Add(this.btnPocetak);
            this.panelTitle.Controls.Add(this.lblTitle);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelTitle.Location = new System.Drawing.Point(200, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(784, 80);
            this.panelTitle.TabIndex = 1;
            this.panelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseDown);
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMin.ForeColor = System.Drawing.Color.White;
            this.btnMin.Location = new System.Drawing.Point(682, 0);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(30, 30);
            this.btnMin.TabIndex = 4;
            this.btnMin.Text = "O";
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnMax
            // 
            this.btnMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMax.ForeColor = System.Drawing.Color.White;
            this.btnMax.Location = new System.Drawing.Point(718, 0);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(30, 30);
            this.btnMax.TabIndex = 3;
            this.btnMax.Text = "O";
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnZatvori
            // 
            this.btnZatvori.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnZatvori.FlatAppearance.BorderSize = 0;
            this.btnZatvori.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZatvori.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZatvori.ForeColor = System.Drawing.Color.White;
            this.btnZatvori.Location = new System.Drawing.Point(754, 0);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(30, 30);
            this.btnZatvori.TabIndex = 2;
            this.btnZatvori.Text = "O";
            this.btnZatvori.UseVisualStyleBackColor = true;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // btnPocetak
            // 
            this.btnPocetak.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPocetak.FlatAppearance.BorderSize = 0;
            this.btnPocetak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPocetak.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPocetak.Image = ((System.Drawing.Image)(resources.GetObject("btnPocetak.Image")));
            this.btnPocetak.Location = new System.Drawing.Point(0, 0);
            this.btnPocetak.Name = "btnPocetak";
            this.btnPocetak.Size = new System.Drawing.Size(75, 80);
            this.btnPocetak.TabIndex = 1;
            this.btnPocetak.UseVisualStyleBackColor = true;
            this.btnPocetak.Click += new System.EventHandler(this.btnPocetak_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(273, 29);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(254, 24);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "ALGORITMI SORTIRANJA";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Controls.Add(this.txtboxNaslov);
            this.panel1.Controls.Add(this.rtxtBoxInfo);
            this.panel1.Location = new System.Drawing.Point(228, 86);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(744, 522);
            this.panel1.TabIndex = 2;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Yi Baiti", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.Firebrick;
            this.richTextBox1.Location = new System.Drawing.Point(8, 460);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(744, 31);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "Za sve sugestije, prijave bug-ova, komentare, kontaktirajte me putem mail-a: ehad" +
    "zic4@etf.unsa.ba";
            // 
            // txtboxNaslov
            // 
            this.txtboxNaslov.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtboxNaslov.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtboxNaslov.Enabled = false;
            this.txtboxNaslov.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxNaslov.ForeColor = System.Drawing.Color.Gray;
            this.txtboxNaslov.Location = new System.Drawing.Point(81, 8);
            this.txtboxNaslov.Name = "txtboxNaslov";
            this.txtboxNaslov.ReadOnly = true;
            this.txtboxNaslov.Size = new System.Drawing.Size(573, 32);
            this.txtboxNaslov.TabIndex = 1;
            this.txtboxNaslov.Text = "Aplikacija za vizualizaciju algoritama sortiranja";
            this.txtboxNaslov.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rtxtBoxInfo
            // 
            this.rtxtBoxInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.rtxtBoxInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtBoxInfo.Enabled = false;
            this.rtxtBoxInfo.Font = new System.Drawing.Font("Microsoft Yi Baiti", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtBoxInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rtxtBoxInfo.Location = new System.Drawing.Point(0, 54);
            this.rtxtBoxInfo.Name = "rtxtBoxInfo";
            this.rtxtBoxInfo.ReadOnly = true;
            this.rtxtBoxInfo.Size = new System.Drawing.Size(744, 468);
            this.rtxtBoxInfo.TabIndex = 0;
            this.rtxtBoxInfo.Text = resources.GetString("rtxtBoxInfo.Text");
            // 
            // GlavnaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.izabirAlgoritama);
            this.MinimumSize = new System.Drawing.Size(1000, 700);
            this.Name = "GlavnaForma";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.GlavnaForma_Load);
            this.izabirAlgoritama.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel izabirAlgoritama;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnSelection;
        private System.Windows.Forms.Button btnInsertion;
        private System.Windows.Forms.Button btnMerge;
        private System.Windows.Forms.Button btnQuick;
        private System.Windows.Forms.Button btnBubble;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnPocetak;
        private System.Windows.Forms.Button btnZatvori;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Button btnRadix;
        private System.Windows.Forms.TextBox txtboxNaslov;
        private System.Windows.Forms.Button btnPoredi;
        private System.Windows.Forms.Button btnShell;
        private System.Windows.Forms.Button btnMaxHeap;
        private System.Windows.Forms.Button btnPostavke;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox rtxtBoxInfo;
    }
}

