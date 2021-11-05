namespace Cs.App
{
    partial class Form1
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
            this.gbFirlatilan = new System.Windows.Forms.GroupBox();
            this.btnFırlat = new System.Windows.Forms.Button();
            this.gbYakinSaldiri = new System.Windows.Forms.GroupBox();
            this.btnSaldir = new System.Windows.Forms.Button();
            this.gb_AtesliSilah = new System.Windows.Forms.GroupBox();
            this.lblDurum = new System.Windows.Forms.Label();
            this.btnAtesEt = new System.Windows.Forms.Button();
            this.btnYenidenDoldur = new System.Windows.Forms.Button();
            this.lblDetay = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSilahlar = new System.Windows.Forms.ComboBox();
            this.panelSilah = new System.Windows.Forms.Panel();
            this.gbFirlatilan.SuspendLayout();
            this.gbYakinSaldiri.SuspendLayout();
            this.gb_AtesliSilah.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbFirlatilan
            // 
            this.gbFirlatilan.Controls.Add(this.btnFırlat);
            this.gbFirlatilan.Location = new System.Drawing.Point(406, 284);
            this.gbFirlatilan.Margin = new System.Windows.Forms.Padding(4);
            this.gbFirlatilan.Name = "gbFirlatilan";
            this.gbFirlatilan.Padding = new System.Windows.Forms.Padding(4);
            this.gbFirlatilan.Size = new System.Drawing.Size(379, 116);
            this.gbFirlatilan.TabIndex = 14;
            this.gbFirlatilan.TabStop = false;
            this.gbFirlatilan.Text = "Firlatılan Silah Kontrol";
            this.gbFirlatilan.Visible = false;
            // 
            // btnFırlat
            // 
            this.btnFırlat.Location = new System.Drawing.Point(8, 23);
            this.btnFırlat.Margin = new System.Windows.Forms.Padding(4);
            this.btnFırlat.Name = "btnFırlat";
            this.btnFırlat.Size = new System.Drawing.Size(98, 86);
            this.btnFırlat.TabIndex = 0;
            this.btnFırlat.Text = "Fırlat";
            this.btnFırlat.UseVisualStyleBackColor = true;
            this.btnFırlat.Click += new System.EventHandler(this.btnFırlat_Click);
            // 
            // gbYakinSaldiri
            // 
            this.gbYakinSaldiri.Controls.Add(this.btnSaldir);
            this.gbYakinSaldiri.Location = new System.Drawing.Point(20, 284);
            this.gbYakinSaldiri.Margin = new System.Windows.Forms.Padding(4);
            this.gbYakinSaldiri.Name = "gbYakinSaldiri";
            this.gbYakinSaldiri.Padding = new System.Windows.Forms.Padding(4);
            this.gbYakinSaldiri.Size = new System.Drawing.Size(379, 116);
            this.gbYakinSaldiri.TabIndex = 15;
            this.gbYakinSaldiri.TabStop = false;
            this.gbYakinSaldiri.Text = "Yakın Saldırı Kontrol";
            this.gbYakinSaldiri.Visible = false;
            // 
            // btnSaldir
            // 
            this.btnSaldir.Location = new System.Drawing.Point(8, 23);
            this.btnSaldir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaldir.Name = "btnSaldir";
            this.btnSaldir.Size = new System.Drawing.Size(98, 86);
            this.btnSaldir.TabIndex = 0;
            this.btnSaldir.Text = "Saldır";
            this.btnSaldir.UseVisualStyleBackColor = true;
            this.btnSaldir.Click += new System.EventHandler(this.btnSaldir_Click);
            // 
            // gb_AtesliSilah
            // 
            this.gb_AtesliSilah.Controls.Add(this.lblDurum);
            this.gb_AtesliSilah.Controls.Add(this.btnAtesEt);
            this.gb_AtesliSilah.Controls.Add(this.btnYenidenDoldur);
            this.gb_AtesliSilah.Location = new System.Drawing.Point(20, 150);
            this.gb_AtesliSilah.Margin = new System.Windows.Forms.Padding(4);
            this.gb_AtesliSilah.Name = "gb_AtesliSilah";
            this.gb_AtesliSilah.Padding = new System.Windows.Forms.Padding(4);
            this.gb_AtesliSilah.Size = new System.Drawing.Size(379, 116);
            this.gb_AtesliSilah.TabIndex = 13;
            this.gb_AtesliSilah.TabStop = false;
            this.gb_AtesliSilah.Text = "Silah Kontrol";
            this.gb_AtesliSilah.Visible = false;
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDurum.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblDurum.Location = new System.Drawing.Point(217, 45);
            this.lblDurum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(110, 31);
            this.lblDurum.TabIndex = 5;
            this.lblDurum.Text = "label2";
            // 
            // btnAtesEt
            // 
            this.btnAtesEt.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAtesEt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAtesEt.Location = new System.Drawing.Point(7, 22);
            this.btnAtesEt.Margin = new System.Windows.Forms.Padding(4);
            this.btnAtesEt.Name = "btnAtesEt";
            this.btnAtesEt.Size = new System.Drawing.Size(98, 86);
            this.btnAtesEt.TabIndex = 6;
            this.btnAtesEt.Text = "Ateş Et";
            this.btnAtesEt.UseVisualStyleBackColor = true;
            this.btnAtesEt.Click += new System.EventHandler(this.btnAtesEt_Click);
            this.btnAtesEt.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnAtesEt_MouseDown);
            this.btnAtesEt.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnAtesEt_MouseUp);
            // 
            // btnYenidenDoldur
            // 
            this.btnYenidenDoldur.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnYenidenDoldur.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnYenidenDoldur.Location = new System.Drawing.Point(112, 22);
            this.btnYenidenDoldur.Margin = new System.Windows.Forms.Padding(4);
            this.btnYenidenDoldur.Name = "btnYenidenDoldur";
            this.btnYenidenDoldur.Size = new System.Drawing.Size(98, 86);
            this.btnYenidenDoldur.TabIndex = 6;
            this.btnYenidenDoldur.Text = "Doldur";
            this.btnYenidenDoldur.UseVisualStyleBackColor = true;
            this.btnYenidenDoldur.Click += new System.EventHandler(this.btnYenidenDoldur_Click);
            // 
            // lblDetay
            // 
            this.lblDetay.AutoSize = true;
            this.lblDetay.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDetay.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblDetay.Location = new System.Drawing.Point(14, 79);
            this.lblDetay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDetay.Name = "lblDetay";
            this.lblDetay.Size = new System.Drawing.Size(64, 25);
            this.lblDetay.TabIndex = 12;
            this.lblDetay.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Silah Seçiniz";
            // 
            // cmbSilahlar
            // 
            this.cmbSilahlar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSilahlar.FormattingEnabled = true;
            this.cmbSilahlar.Location = new System.Drawing.Point(99, 7);
            this.cmbSilahlar.Margin = new System.Windows.Forms.Padding(4);
            this.cmbSilahlar.Name = "cmbSilahlar";
            this.cmbSilahlar.Size = new System.Drawing.Size(253, 23);
            this.cmbSilahlar.TabIndex = 10;
            this.cmbSilahlar.SelectedIndexChanged += new System.EventHandler(this.cmbSilahlar_SelectedIndexChanged);
            // 
            // panelSilah
            // 
            this.panelSilah.Location = new System.Drawing.Point(515, 10);
            this.panelSilah.Margin = new System.Windows.Forms.Padding(4);
            this.panelSilah.Name = "panelSilah";
            this.panelSilah.Size = new System.Drawing.Size(344, 255);
            this.panelSilah.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 449);
            this.Controls.Add(this.gbFirlatilan);
            this.Controls.Add(this.gbYakinSaldiri);
            this.Controls.Add(this.gb_AtesliSilah);
            this.Controls.Add(this.lblDetay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbSilahlar);
            this.Controls.Add(this.panelSilah);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbFirlatilan.ResumeLayout(false);
            this.gbYakinSaldiri.ResumeLayout(false);
            this.gb_AtesliSilah.ResumeLayout(false);
            this.gb_AtesliSilah.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFirlatilan;
        private System.Windows.Forms.Button btnFırlat;
        private System.Windows.Forms.GroupBox gbYakinSaldiri;
        private System.Windows.Forms.Button btnSaldir;
        private System.Windows.Forms.GroupBox gb_AtesliSilah;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.Button btnAtesEt;
        private System.Windows.Forms.Button btnYenidenDoldur;
        private System.Windows.Forms.Label lblDetay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSilahlar;
        private System.Windows.Forms.Panel panelSilah;
    }
}

