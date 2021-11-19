
namespace KafeAdisyon.Forms
{
    partial class KatAyarForm
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
            this.txtSira = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKatAdi = new System.Windows.Forms.TextBox();
            this.txtKod = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnKatKaydet = new System.Windows.Forms.Button();
            this.lstKatlar = new System.Windows.Forms.ListBox();
            this.txtMasaAdeti = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSira
            // 
            this.txtSira.Location = new System.Drawing.Point(117, 42);
            this.txtSira.Name = "txtSira";
            this.txtSira.Size = new System.Drawing.Size(170, 27);
            this.txtSira.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kat Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sıra";
            // 
            // txtKatAdi
            // 
            this.txtKatAdi.Location = new System.Drawing.Point(117, 9);
            this.txtKatAdi.Name = "txtKatAdi";
            this.txtKatAdi.Size = new System.Drawing.Size(170, 27);
            this.txtKatAdi.TabIndex = 0;
            // 
            // txtKod
            // 
            this.txtKod.Location = new System.Drawing.Point(117, 75);
            this.txtKod.Name = "txtKod";
            this.txtKod.Size = new System.Drawing.Size(170, 27);
            this.txtKod.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Kod";
            // 
            // btnKatKaydet
            // 
            this.btnKatKaydet.Location = new System.Drawing.Point(117, 141);
            this.btnKatKaydet.Name = "btnKatKaydet";
            this.btnKatKaydet.Size = new System.Drawing.Size(170, 97);
            this.btnKatKaydet.TabIndex = 2;
            this.btnKatKaydet.Text = "Kaydet";
            this.btnKatKaydet.UseVisualStyleBackColor = true;
            this.btnKatKaydet.Click += new System.EventHandler(this.btnKatKaydet_Click);
            // 
            // lstKatlar
            // 
            this.lstKatlar.FormattingEnabled = true;
            this.lstKatlar.ItemHeight = 20;
            this.lstKatlar.Location = new System.Drawing.Point(293, 12);
            this.lstKatlar.Name = "lstKatlar";
            this.lstKatlar.Size = new System.Drawing.Size(263, 524);
            this.lstKatlar.TabIndex = 3;
            // 
            // txtMasaAdeti
            // 
            this.txtMasaAdeti.Location = new System.Drawing.Point(117, 108);
            this.txtMasaAdeti.Name = "txtMasaAdeti";
            this.txtMasaAdeti.Size = new System.Drawing.Size(170, 27);
            this.txtMasaAdeti.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Adet";
            // 
            // KatAyarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 612);
            this.Controls.Add(this.lstKatlar);
            this.Controls.Add(this.btnKatKaydet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKatAdi);
            this.Controls.Add(this.txtKod);
            this.Controls.Add(this.txtMasaAdeti);
            this.Controls.Add(this.txtSira);
            this.Name = "KatAyarForm";
            this.Text = "KatAyarForm";
            this.Load += new System.EventHandler(this.KatAyarForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSira;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKatAdi;
        private System.Windows.Forms.TextBox txtKod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnKatKaydet;
        private System.Windows.Forms.ListBox lstKatlar;
        private System.Windows.Forms.TextBox txtMasaAdeti;
        private System.Windows.Forms.Label label4;
    }
}