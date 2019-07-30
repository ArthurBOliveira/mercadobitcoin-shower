namespace BitCoin
{
    partial class Main
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.txtTrades = new System.Windows.Forms.RichTextBox();
            this.lblLast = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblDiff = new System.Windows.Forms.Label();
            this.lblCounts = new System.Windows.Forms.Label();
            this.lblBCount = new System.Windows.Forms.Label();
            this.lblHigh = new System.Windows.Forms.Label();
            this.lblLastSell = new System.Windows.Forms.Label();
            this.lblBAmount = new System.Windows.Forms.Label();
            this.lblSAmount = new System.Windows.Forms.Label();
            this.lblSCount = new System.Windows.Forms.Label();
            this.lblLow = new System.Windows.Forms.Label();
            this.lblRLast = new System.Windows.Forms.Label();
            this.lblRLastSell = new System.Windows.Forms.Label();
            this.lblRBCount = new System.Windows.Forms.Label();
            this.lblRSCount = new System.Windows.Forms.Label();
            this.lblRBAmo = new System.Windows.Forms.Label();
            this.lblRSAmo = new System.Windows.Forms.Label();
            this.lblRHigh = new System.Windows.Forms.Label();
            this.lblRLow = new System.Windows.Forms.Label();
            this.charBuySell = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.charBuySell)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTrades
            // 
            this.txtTrades.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrades.Location = new System.Drawing.Point(13, 51);
            this.txtTrades.Name = "txtTrades";
            this.txtTrades.Size = new System.Drawing.Size(288, 334);
            this.txtTrades.TabIndex = 0;
            this.txtTrades.Text = "Loading...";
            // 
            // lblLast
            // 
            this.lblLast.AutoSize = true;
            this.lblLast.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLast.Location = new System.Drawing.Point(11, 388);
            this.lblLast.Name = "lblLast";
            this.lblLast.Size = new System.Drawing.Size(102, 36);
            this.lblLast.TabIndex = 3;
            this.lblLast.Text = "lblLast";
            this.lblLast.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(563, 12);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(79, 33);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // lblDiff
            // 
            this.lblDiff.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDiff.AutoSize = true;
            this.lblDiff.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiff.Location = new System.Drawing.Point(11, 12);
            this.lblDiff.Name = "lblDiff";
            this.lblDiff.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblDiff.Size = new System.Drawing.Size(35, 36);
            this.lblDiff.TabIndex = 5;
            this.lblDiff.Text = "--";
            this.lblDiff.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCounts
            // 
            this.lblCounts.AutoSize = true;
            this.lblCounts.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCounts.Location = new System.Drawing.Point(11, 676);
            this.lblCounts.Name = "lblCounts";
            this.lblCounts.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblCounts.Size = new System.Drawing.Size(136, 36);
            this.lblCounts.TabIndex = 6;
            this.lblCounts.Text = "lblCounts";
            this.lblCounts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBCount
            // 
            this.lblBCount.AutoSize = true;
            this.lblBCount.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBCount.Location = new System.Drawing.Point(12, 460);
            this.lblBCount.Name = "lblBCount";
            this.lblBCount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblBCount.Size = new System.Drawing.Size(146, 36);
            this.lblBCount.TabIndex = 7;
            this.lblBCount.Text = "lblBCount";
            this.lblBCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHigh
            // 
            this.lblHigh.AutoSize = true;
            this.lblHigh.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHigh.Location = new System.Drawing.Point(11, 604);
            this.lblHigh.Name = "lblHigh";
            this.lblHigh.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblHigh.Size = new System.Drawing.Size(111, 36);
            this.lblHigh.TabIndex = 8;
            this.lblHigh.Text = "lblHigh";
            this.lblHigh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLastSell
            // 
            this.lblLastSell.AutoSize = true;
            this.lblLastSell.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastSell.Location = new System.Drawing.Point(11, 424);
            this.lblLastSell.Name = "lblLastSell";
            this.lblLastSell.Size = new System.Drawing.Size(152, 36);
            this.lblLastSell.TabIndex = 9;
            this.lblLastSell.Text = "lblLastSell";
            this.lblLastSell.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBAmount
            // 
            this.lblBAmount.AutoSize = true;
            this.lblBAmount.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBAmount.Location = new System.Drawing.Point(12, 532);
            this.lblBAmount.Name = "lblBAmount";
            this.lblBAmount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblBAmount.Size = new System.Drawing.Size(170, 36);
            this.lblBAmount.TabIndex = 10;
            this.lblBAmount.Text = "lblBAmount";
            this.lblBAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSAmount
            // 
            this.lblSAmount.AutoSize = true;
            this.lblSAmount.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSAmount.Location = new System.Drawing.Point(11, 568);
            this.lblSAmount.Name = "lblSAmount";
            this.lblSAmount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblSAmount.Size = new System.Drawing.Size(167, 36);
            this.lblSAmount.TabIndex = 11;
            this.lblSAmount.Text = "lblSAmount";
            this.lblSAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSCount
            // 
            this.lblSCount.AutoSize = true;
            this.lblSCount.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSCount.Location = new System.Drawing.Point(12, 496);
            this.lblSCount.Name = "lblSCount";
            this.lblSCount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblSCount.Size = new System.Drawing.Size(143, 36);
            this.lblSCount.TabIndex = 12;
            this.lblSCount.Text = "lblSCount";
            this.lblSCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLow
            // 
            this.lblLow.AutoSize = true;
            this.lblLow.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLow.Location = new System.Drawing.Point(11, 640);
            this.lblLow.Name = "lblLow";
            this.lblLow.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblLow.Size = new System.Drawing.Size(107, 36);
            this.lblLow.TabIndex = 13;
            this.lblLow.Text = "lblLow";
            this.lblLow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRLast
            // 
            this.lblRLast.AutoSize = true;
            this.lblRLast.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRLast.Location = new System.Drawing.Point(343, 388);
            this.lblRLast.Name = "lblRLast";
            this.lblRLast.Size = new System.Drawing.Size(123, 36);
            this.lblRLast.TabIndex = 14;
            this.lblRLast.Text = "lblRLast";
            this.lblRLast.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRLastSell
            // 
            this.lblRLastSell.AutoSize = true;
            this.lblRLastSell.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRLastSell.Location = new System.Drawing.Point(343, 424);
            this.lblRLastSell.Name = "lblRLastSell";
            this.lblRLastSell.Size = new System.Drawing.Size(173, 36);
            this.lblRLastSell.TabIndex = 15;
            this.lblRLastSell.Text = "lblRLastSell";
            this.lblRLastSell.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRBCount
            // 
            this.lblRBCount.AutoSize = true;
            this.lblRBCount.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRBCount.Location = new System.Drawing.Point(343, 460);
            this.lblRBCount.Name = "lblRBCount";
            this.lblRBCount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblRBCount.Size = new System.Drawing.Size(167, 36);
            this.lblRBCount.TabIndex = 16;
            this.lblRBCount.Text = "lblRBCount";
            this.lblRBCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRSCount
            // 
            this.lblRSCount.AutoSize = true;
            this.lblRSCount.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRSCount.Location = new System.Drawing.Point(343, 496);
            this.lblRSCount.Name = "lblRSCount";
            this.lblRSCount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblRSCount.Size = new System.Drawing.Size(164, 36);
            this.lblRSCount.TabIndex = 17;
            this.lblRSCount.Text = "lblRSCount";
            this.lblRSCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRBAmo
            // 
            this.lblRBAmo.AutoSize = true;
            this.lblRBAmo.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRBAmo.Location = new System.Drawing.Point(343, 532);
            this.lblRBAmo.Name = "lblRBAmo";
            this.lblRBAmo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblRBAmo.Size = new System.Drawing.Size(152, 36);
            this.lblRBAmo.TabIndex = 18;
            this.lblRBAmo.Text = "lblRBAmo";
            this.lblRBAmo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRSAmo
            // 
            this.lblRSAmo.AutoSize = true;
            this.lblRSAmo.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRSAmo.Location = new System.Drawing.Point(343, 568);
            this.lblRSAmo.Name = "lblRSAmo";
            this.lblRSAmo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblRSAmo.Size = new System.Drawing.Size(149, 36);
            this.lblRSAmo.TabIndex = 19;
            this.lblRSAmo.Text = "lblRSAmo";
            this.lblRSAmo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRHigh
            // 
            this.lblRHigh.AutoSize = true;
            this.lblRHigh.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRHigh.Location = new System.Drawing.Point(343, 604);
            this.lblRHigh.Name = "lblRHigh";
            this.lblRHigh.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblRHigh.Size = new System.Drawing.Size(132, 36);
            this.lblRHigh.TabIndex = 20;
            this.lblRHigh.Text = "lblRHigh";
            this.lblRHigh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRLow
            // 
            this.lblRLow.AutoSize = true;
            this.lblRLow.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRLow.Location = new System.Drawing.Point(343, 640);
            this.lblRLow.Name = "lblRLow";
            this.lblRLow.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblRLow.Size = new System.Drawing.Size(128, 36);
            this.lblRLow.TabIndex = 21;
            this.lblRLow.Text = "lblRLow";
            this.lblRLow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // charBuySell
            // 
            chartArea1.Name = "ChartArea1";
            this.charBuySell.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.charBuySell.Legends.Add(legend1);
            this.charBuySell.Location = new System.Drawing.Point(307, 51);
            this.charBuySell.Name = "charBuySell";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.charBuySell.Series.Add(series1);
            this.charBuySell.Size = new System.Drawing.Size(335, 334);
            this.charBuySell.TabIndex = 22;
            this.charBuySell.Text = "chart1";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(654, 714);
            this.Controls.Add(this.charBuySell);
            this.Controls.Add(this.lblRLow);
            this.Controls.Add(this.lblRHigh);
            this.Controls.Add(this.lblRSAmo);
            this.Controls.Add(this.lblRBAmo);
            this.Controls.Add(this.lblRSCount);
            this.Controls.Add(this.lblRBCount);
            this.Controls.Add(this.lblRLastSell);
            this.Controls.Add(this.lblRLast);
            this.Controls.Add(this.lblLow);
            this.Controls.Add(this.lblSCount);
            this.Controls.Add(this.lblSAmount);
            this.Controls.Add(this.lblBAmount);
            this.Controls.Add(this.lblLastSell);
            this.Controls.Add(this.lblHigh);
            this.Controls.Add(this.lblBCount);
            this.Controls.Add(this.lblCounts);
            this.Controls.Add(this.lblDiff);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblLast);
            this.Controls.Add(this.txtTrades);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bitcoin";
            ((System.ComponentModel.ISupportInitialize)(this.charBuySell)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtTrades;
        private System.Windows.Forms.Label lblLast;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblDiff;
        private System.Windows.Forms.Label lblCounts;
        private System.Windows.Forms.Label lblBCount;
        private System.Windows.Forms.Label lblHigh;
        private System.Windows.Forms.Label lblLastSell;
        private System.Windows.Forms.Label lblBAmount;
        private System.Windows.Forms.Label lblSAmount;
        private System.Windows.Forms.Label lblSCount;
        private System.Windows.Forms.Label lblLow;
        private System.Windows.Forms.Label lblRLast;
        private System.Windows.Forms.Label lblRLastSell;
        private System.Windows.Forms.Label lblRBCount;
        private System.Windows.Forms.Label lblRSCount;
        private System.Windows.Forms.Label lblRBAmo;
        private System.Windows.Forms.Label lblRSAmo;
        private System.Windows.Forms.Label lblRHigh;
        private System.Windows.Forms.Label lblRLow;
        private System.Windows.Forms.DataVisualization.Charting.Chart charBuySell;
    }
}

