namespace CotacaoDolarHG
{
    partial class FrmCotacaoDolar
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
            this.label1 = new System.Windows.Forms.Label();
            this.Compra = new System.Windows.Forms.Label();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblBuy = new System.Windows.Forms.Label();
            this.lblSell = new System.Windows.Forms.Label();
            this.lblVar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(-1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(419, 61);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dolar\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Compra
            // 
            this.Compra.AutoSize = true;
            this.Compra.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Compra.Location = new System.Drawing.Point(41, 108);
            this.Compra.Name = "Compra";
            this.Compra.Size = new System.Drawing.Size(100, 25);
            this.Compra.TabIndex = 1;
            this.Compra.Text = "Compra:";
            // 
            // BtnSearch
            // 
            this.BtnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSearch.Location = new System.Drawing.Point(291, 310);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(110, 29);
            this.BtnSearch.TabIndex = 2;
            this.BtnSearch.Text = "Pesquisar";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Venda:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Variação:";
            // 
            // lblBuy
            // 
            this.lblBuy.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuy.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblBuy.Location = new System.Drawing.Point(161, 96);
            this.lblBuy.Name = "lblBuy";
            this.lblBuy.Size = new System.Drawing.Size(195, 37);
            this.lblBuy.TabIndex = 5;
            this.lblBuy.Text = "0,0\r\n";
            this.lblBuy.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblSell
            // 
            this.lblSell.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblSell.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSell.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblSell.Location = new System.Drawing.Point(161, 154);
            this.lblSell.Name = "lblSell";
            this.lblSell.Size = new System.Drawing.Size(195, 37);
            this.lblSell.TabIndex = 6;
            this.lblSell.Text = "0,0\r\n";
            this.lblSell.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblVar
            // 
            this.lblVar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblVar.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVar.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblVar.Location = new System.Drawing.Point(161, 210);
            this.lblVar.Name = "lblVar";
            this.lblVar.Size = new System.Drawing.Size(195, 37);
            this.lblVar.TabIndex = 7;
            this.lblVar.Text = "0,0\r\n";
            this.lblVar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // FrmCotacaoDolar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 351);
            this.Controls.Add(this.lblVar);
            this.Controls.Add(this.lblSell);
            this.Controls.Add(this.lblBuy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.Compra);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCotacaoDolar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cotação Dolar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Compra;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblBuy;
        private System.Windows.Forms.Label lblSell;
        private System.Windows.Forms.Label lblVar;
    }
}

