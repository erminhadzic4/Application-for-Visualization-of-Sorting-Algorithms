namespace Algoritmi_Sortiranja.Forme
{
    partial class InsertionForma
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSortiraj = new Algoritmi_Sortiranja.MojeCustomDugme();
            this.btnGenerisi = new Algoritmi_Sortiranja.MojeCustomDugme();
            this.lblPoredjeno = new System.Windows.Forms.Label();
            this.lblPristupljeno = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Location = new System.Drawing.Point(12, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(660, 359);
            this.panel1.TabIndex = 5;
            // 
            // btnSortiraj
            // 
            this.btnSortiraj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSortiraj.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSortiraj.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSortiraj.BorderColor = System.Drawing.Color.DarkMagenta;
            this.btnSortiraj.BorderColor1 = System.Drawing.Color.DarkMagenta;
            this.btnSortiraj.BorderColor2 = System.Drawing.Color.DarkMagenta;
            this.btnSortiraj.BorderRadius = 20;
            this.btnSortiraj.BorderRadius1 = 20;
            this.btnSortiraj.BorderRadius2 = 20;
            this.btnSortiraj.BorderSize = 0;
            this.btnSortiraj.BorderSize1 = 0;
            this.btnSortiraj.BorderSize2 = 0;
            this.btnSortiraj.FlatAppearance.BorderSize = 0;
            this.btnSortiraj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSortiraj.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortiraj.ForeColor = System.Drawing.Color.White;
            this.btnSortiraj.Location = new System.Drawing.Point(372, 8);
            this.btnSortiraj.Name = "btnSortiraj";
            this.btnSortiraj.Size = new System.Drawing.Size(158, 40);
            this.btnSortiraj.TabIndex = 18;
            this.btnSortiraj.Text = "Sortiraj";
            this.btnSortiraj.TextColor = System.Drawing.Color.White;
            this.btnSortiraj.UseVisualStyleBackColor = false;
            this.btnSortiraj.Click += new System.EventHandler(this.btnSortiraj_Click);
            // 
            // btnGenerisi
            // 
            this.btnGenerisi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGenerisi.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnGenerisi.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnGenerisi.BorderColor = System.Drawing.Color.DarkMagenta;
            this.btnGenerisi.BorderColor1 = System.Drawing.Color.DarkMagenta;
            this.btnGenerisi.BorderColor2 = System.Drawing.Color.DarkMagenta;
            this.btnGenerisi.BorderRadius = 20;
            this.btnGenerisi.BorderRadius1 = 20;
            this.btnGenerisi.BorderRadius2 = 20;
            this.btnGenerisi.BorderSize = 0;
            this.btnGenerisi.BorderSize1 = 0;
            this.btnGenerisi.BorderSize2 = 0;
            this.btnGenerisi.FlatAppearance.BorderSize = 0;
            this.btnGenerisi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerisi.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerisi.ForeColor = System.Drawing.Color.White;
            this.btnGenerisi.Location = new System.Drawing.Point(137, 8);
            this.btnGenerisi.Name = "btnGenerisi";
            this.btnGenerisi.Size = new System.Drawing.Size(158, 40);
            this.btnGenerisi.TabIndex = 17;
            this.btnGenerisi.Text = "Generisi";
            this.btnGenerisi.TextColor = System.Drawing.Color.White;
            this.btnGenerisi.UseVisualStyleBackColor = false;
            this.btnGenerisi.Click += new System.EventHandler(this.btnGenerisi_Click);
            // 
            // lblPoredjeno
            // 
            this.lblPoredjeno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPoredjeno.AutoSize = true;
            this.lblPoredjeno.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoredjeno.Location = new System.Drawing.Point(134, 51);
            this.lblPoredjeno.Name = "lblPoredjeno";
            this.lblPoredjeno.Size = new System.Drawing.Size(171, 16);
            this.lblPoredjeno.TabIndex = 16;
            this.lblPoredjeno.Text = "Puta poredjeni elementi: 0";
            // 
            // lblPristupljeno
            // 
            this.lblPristupljeno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPristupljeno.AutoSize = true;
            this.lblPristupljeno.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPristupljeno.Location = new System.Drawing.Point(371, 51);
            this.lblPristupljeno.Name = "lblPristupljeno";
            this.lblPristupljeno.Size = new System.Drawing.Size(160, 16);
            this.lblPristupljeno.TabIndex = 15;
            this.lblPristupljeno.Text = "Puta pristupljeno nizu: 0";
            this.lblPristupljeno.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // InsertionForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.btnSortiraj);
            this.Controls.Add(this.btnGenerisi);
            this.Controls.Add(this.lblPoredjeno);
            this.Controls.Add(this.lblPristupljeno);
            this.Controls.Add(this.panel1);
            this.Name = "InsertionForma";
            this.Text = "InsertionForma";
            this.Load += new System.EventHandler(this.InsertionForma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private MojeCustomDugme btnSortiraj;
        private MojeCustomDugme btnGenerisi;
        public System.Windows.Forms.Label lblPoredjeno;
        public System.Windows.Forms.Label lblPristupljeno;
    }
}