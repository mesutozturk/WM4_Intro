
namespace MyCoin
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
            this.components = new System.ComponentModel.Container();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.lstExchangeInfo = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblSymbol = new System.Windows.Forms.Label();
            this.lblFiyat = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(12, 12);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(267, 27);
            this.txtAra.TabIndex = 0;
            this.txtAra.TextChanged += new System.EventHandler(this.txtAra_TextChanged);
            // 
            // lstExchangeInfo
            // 
            this.lstExchangeInfo.FormattingEnabled = true;
            this.lstExchangeInfo.ItemHeight = 20;
            this.lstExchangeInfo.Location = new System.Drawing.Point(12, 45);
            this.lstExchangeInfo.Name = "lstExchangeInfo";
            this.lstExchangeInfo.Size = new System.Drawing.Size(267, 584);
            this.lstExchangeInfo.TabIndex = 1;
            this.lstExchangeInfo.SelectedIndexChanged += new System.EventHandler(this.lstExchangeInfo_SelectedIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblSymbol
            // 
            this.lblSymbol.AutoSize = true;
            this.lblSymbol.Font = new System.Drawing.Font("Dank Mono", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSymbol.Location = new System.Drawing.Point(286, 45);
            this.lblSymbol.Name = "lblSymbol";
            this.lblSymbol.Size = new System.Drawing.Size(132, 39);
            this.lblSymbol.TabIndex = 2;
            this.lblSymbol.Text = "symbol";
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.Font = new System.Drawing.Font("Dank Mono", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFiyat.Location = new System.Drawing.Point(627, 45);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(112, 39);
            this.lblFiyat.TabIndex = 3;
            this.lblFiyat.Text = "Fiyat";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Dank Mono", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblInfo.Location = new System.Drawing.Point(286, 201);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(76, 33);
            this.lblInfo.TabIndex = 4;
            this.lblInfo.Text = "info";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 640);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblFiyat);
            this.Controls.Add(this.lblSymbol);
            this.Controls.Add(this.lstExchangeInfo);
            this.Controls.Add(this.txtAra);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.ListBox lstExchangeInfo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblSymbol;
        private System.Windows.Forms.Label lblFiyat;
        private System.Windows.Forms.Label lblInfo;
    }
}

