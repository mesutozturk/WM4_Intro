
namespace KafeAdisyon
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kurulumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menüToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.katMasaAyarlarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kafeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siparişEkranıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kurulumToolStripMenuItem,
            this.kafeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1251, 58);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kurulumToolStripMenuItem
            // 
            this.kurulumToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menüToolStripMenuItem,
            this.katMasaAyarlarıToolStripMenuItem});
            this.kurulumToolStripMenuItem.Name = "kurulumToolStripMenuItem";
            this.kurulumToolStripMenuItem.Size = new System.Drawing.Size(182, 54);
            this.kurulumToolStripMenuItem.Text = "Kurulum";
            // 
            // menüToolStripMenuItem
            // 
            this.menüToolStripMenuItem.Name = "menüToolStripMenuItem";
            this.menüToolStripMenuItem.Size = new System.Drawing.Size(415, 54);
            this.menüToolStripMenuItem.Text = "Menü";
            this.menüToolStripMenuItem.Click += new System.EventHandler(this.menüToolStripMenuItem_Click);
            // 
            // katMasaAyarlarıToolStripMenuItem
            // 
            this.katMasaAyarlarıToolStripMenuItem.Name = "katMasaAyarlarıToolStripMenuItem";
            this.katMasaAyarlarıToolStripMenuItem.Size = new System.Drawing.Size(415, 54);
            this.katMasaAyarlarıToolStripMenuItem.Text = "Kat/Masa Ayarları";
            this.katMasaAyarlarıToolStripMenuItem.Click += new System.EventHandler(this.katMasaAyarlarıToolStripMenuItem_Click);
            // 
            // kafeToolStripMenuItem
            // 
            this.kafeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.siparişEkranıToolStripMenuItem});
            this.kafeToolStripMenuItem.Name = "kafeToolStripMenuItem";
            this.kafeToolStripMenuItem.Size = new System.Drawing.Size(111, 54);
            this.kafeToolStripMenuItem.Text = "Kafe";
            // 
            // siparişEkranıToolStripMenuItem
            // 
            this.siparişEkranıToolStripMenuItem.Name = "siparişEkranıToolStripMenuItem";
            this.siparişEkranıToolStripMenuItem.Size = new System.Drawing.Size(342, 54);
            this.siparişEkranıToolStripMenuItem.Text = "Sipariş Ekranı";
            this.siparişEkranıToolStripMenuItem.Click += new System.EventHandler(this.siparişEkranıToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 648);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kurulumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menüToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem katMasaAyarlarıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kafeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siparişEkranıToolStripMenuItem;
    }
}

