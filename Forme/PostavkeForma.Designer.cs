namespace Algoritmi_Sortiranja.Forme
{
    partial class PostavkeForma
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
            this.lblPristup = new System.Windows.Forms.CheckBox();
            this.lblPoredenje = new System.Windows.Forms.CheckBox();
            this.lblOboje = new System.Windows.Forms.CheckBox();
            this.lblVrijemeIzvr = new System.Windows.Forms.CheckBox();
            this.lblSpasavanjeUFile = new System.Windows.Forms.CheckBox();
            this.btnSpasi = new Algoritmi_Sortiranja.MojeCustomDugme();
            this.SuspendLayout();
            // 
            // lblPristup
            // 
            this.lblPristup.AutoSize = true;
            this.lblPristup.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPristup.Location = new System.Drawing.Point(250, 106);
            this.lblPristup.Name = "lblPristup";
            this.lblPristup.Size = new System.Drawing.Size(147, 20);
            this.lblPristup.TabIndex = 5;
            this.lblPristup.Text = "Ispisivanje pristupa";
            this.lblPristup.UseVisualStyleBackColor = true;
            this.lblPristup.CheckedChanged += new System.EventHandler(this.lblPristup_CheckedChanged);
            // 
            // lblPoredenje
            // 
            this.lblPoredenje.AutoSize = true;
            this.lblPoredenje.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoredenje.Location = new System.Drawing.Point(250, 136);
            this.lblPoredenje.Name = "lblPoredenje";
            this.lblPoredenje.Size = new System.Drawing.Size(159, 20);
            this.lblPoredenje.TabIndex = 6;
            this.lblPoredenje.Text = "Ispisivanje poredenja";
            this.lblPoredenje.UseVisualStyleBackColor = true;
            this.lblPoredenje.CheckedChanged += new System.EventHandler(this.lblPoredenje_CheckedChanged);
            // 
            // lblOboje
            // 
            this.lblOboje.AutoSize = true;
            this.lblOboje.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOboje.Location = new System.Drawing.Point(250, 166);
            this.lblOboje.Name = "lblOboje";
            this.lblOboje.Size = new System.Drawing.Size(229, 20);
            this.lblOboje.TabIndex = 7;
            this.lblOboje.Text = "Ispisivanje i poredenja i pristupa";
            this.lblOboje.UseVisualStyleBackColor = true;
            this.lblOboje.CheckedChanged += new System.EventHandler(this.lblOboje_CheckedChanged);
            // 
            // lblVrijemeIzvr
            // 
            this.lblVrijemeIzvr.AutoSize = true;
            this.lblVrijemeIzvr.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVrijemeIzvr.Location = new System.Drawing.Point(250, 198);
            this.lblVrijemeIzvr.Name = "lblVrijemeIzvr";
            this.lblVrijemeIzvr.Size = new System.Drawing.Size(226, 20);
            this.lblVrijemeIzvr.TabIndex = 8;
            this.lblVrijemeIzvr.Text = "Ispisivanje vremena izvrsavanja";
            this.lblVrijemeIzvr.UseVisualStyleBackColor = true;
            this.lblVrijemeIzvr.CheckedChanged += new System.EventHandler(this.lblVrijemeIzvr_CheckedChanged);
            // 
            // lblSpasavanjeUFile
            // 
            this.lblSpasavanjeUFile.AutoSize = true;
            this.lblSpasavanjeUFile.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpasavanjeUFile.Location = new System.Drawing.Point(250, 231);
            this.lblSpasavanjeUFile.Name = "lblSpasavanjeUFile";
            this.lblSpasavanjeUFile.Size = new System.Drawing.Size(287, 20);
            this.lblSpasavanjeUFile.TabIndex = 9;
            this.lblSpasavanjeUFile.Text = "Spasavanje informacija o poredenju u file";
            this.lblSpasavanjeUFile.UseVisualStyleBackColor = true;
            this.lblSpasavanjeUFile.CheckedChanged += new System.EventHandler(this.lblSpasavanjeUFile_CheckedChanged);
            // 
            // btnSpasi
            // 
            this.btnSpasi.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSpasi.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSpasi.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSpasi.BorderColor1 = System.Drawing.Color.PaleVioletRed;
            this.btnSpasi.BorderColor2 = System.Drawing.Color.PaleVioletRed;
            this.btnSpasi.BorderRadius = 20;
            this.btnSpasi.BorderRadius1 = 20;
            this.btnSpasi.BorderRadius2 = 20;
            this.btnSpasi.BorderSize = 0;
            this.btnSpasi.BorderSize1 = 0;
            this.btnSpasi.BorderSize2 = 0;
            this.btnSpasi.FlatAppearance.BorderSize = 0;
            this.btnSpasi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpasi.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpasi.ForeColor = System.Drawing.Color.White;
            this.btnSpasi.Location = new System.Drawing.Point(306, 269);
            this.btnSpasi.Name = "btnSpasi";
            this.btnSpasi.Size = new System.Drawing.Size(150, 40);
            this.btnSpasi.TabIndex = 10;
            this.btnSpasi.Text = "Spasi promjene";
            this.btnSpasi.TextColor = System.Drawing.Color.White;
            this.btnSpasi.UseVisualStyleBackColor = false;
            this.btnSpasi.Click += new System.EventHandler(this.btnSpasi_Click);
            // 
            // PostavkeForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSpasi);
            this.Controls.Add(this.lblSpasavanjeUFile);
            this.Controls.Add(this.lblVrijemeIzvr);
            this.Controls.Add(this.lblOboje);
            this.Controls.Add(this.lblPoredenje);
            this.Controls.Add(this.lblPristup);
            this.Name = "PostavkeForma";
            this.Text = "PostavkeForma";
            this.Load += new System.EventHandler(this.PostavkeForma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox lblPristup;
        private System.Windows.Forms.CheckBox lblPoredenje;
        private System.Windows.Forms.CheckBox lblOboje;
        private System.Windows.Forms.CheckBox lblVrijemeIzvr;
        private System.Windows.Forms.CheckBox lblSpasavanjeUFile;
        private MojeCustomDugme btnSpasi;
    }
}