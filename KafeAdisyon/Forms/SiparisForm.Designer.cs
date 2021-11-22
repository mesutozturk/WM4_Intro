
namespace KafeAdisyon.Forms
{
    partial class SiparisForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.flpKategori = new System.Windows.Forms.FlowLayoutPanel();
            this.flpUrun = new System.Windows.Forms.FlowLayoutPanel();
            this.lstSiparis = new System.Windows.Forms.ListView();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lstSiparis, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1243, 641);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.flpKategori, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.flpUrun, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(864, 635);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // flpKategori
            // 
            this.flpKategori.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpKategori.Location = new System.Drawing.Point(3, 3);
            this.flpKategori.Name = "flpKategori";
            this.flpKategori.Size = new System.Drawing.Size(858, 184);
            this.flpKategori.TabIndex = 0;
            // 
            // flpUrun
            // 
            this.flpUrun.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpUrun.Location = new System.Drawing.Point(3, 193);
            this.flpUrun.Name = "flpUrun";
            this.flpUrun.Size = new System.Drawing.Size(858, 439);
            this.flpUrun.TabIndex = 1;
            // 
            // lstSiparis
            // 
            this.lstSiparis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstSiparis.HideSelection = false;
            this.lstSiparis.Location = new System.Drawing.Point(873, 3);
            this.lstSiparis.MultiSelect = false;
            this.lstSiparis.Name = "lstSiparis";
            this.lstSiparis.Size = new System.Drawing.Size(367, 635);
            this.lstSiparis.TabIndex = 1;
            this.lstSiparis.UseCompatibleStateImageBehavior = false;
            this.lstSiparis.View = System.Windows.Forms.View.List;
            // 
            // SiparisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 641);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "SiparisForm";
            this.Text = "SiparisForm";
            this.Load += new System.EventHandler(this.SiparisForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flpKategori;
        private System.Windows.Forms.FlowLayoutPanel flpUrun;
        private System.Windows.Forms.ListView lstSiparis;
    }
}