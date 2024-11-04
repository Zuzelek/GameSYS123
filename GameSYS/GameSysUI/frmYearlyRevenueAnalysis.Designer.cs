
namespace GameSYS
{
    partial class frmYearlyRevenueAnalysis
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpRevenueAnalysis = new System.Windows.Forms.GroupBox();
            this.chtData = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelRevenueYear = new System.Windows.Forms.Label();
            this.cboRevenueYear = new System.Windows.Forms.ComboBox();
            this.btnRevenue = new System.Windows.Forms.Button();
            this.labelYearlyAnaylsis = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.grpRevenueAnalysis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtData)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.menuStrip1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(935, 25);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // mainMenuToolStripMenuItem
            // 
            this.mainMenuToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mainMenuToolStripMenuItem.Name = "mainMenuToolStripMenuItem";
            this.mainMenuToolStripMenuItem.Size = new System.Drawing.Size(97, 21);
            this.mainMenuToolStripMenuItem.Text = "Main Menu";
            this.mainMenuToolStripMenuItem.Click += new System.EventHandler(this.mainMenuToolStripMenuItem_Click);
            // 
            // grpRevenueAnalysis
            // 
            this.grpRevenueAnalysis.Controls.Add(this.chtData);
            this.grpRevenueAnalysis.Controls.Add(this.labelRevenueYear);
            this.grpRevenueAnalysis.Controls.Add(this.cboRevenueYear);
            this.grpRevenueAnalysis.Controls.Add(this.btnRevenue);
            this.grpRevenueAnalysis.Controls.Add(this.labelYearlyAnaylsis);
            this.grpRevenueAnalysis.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpRevenueAnalysis.Location = new System.Drawing.Point(12, 27);
            this.grpRevenueAnalysis.Name = "grpRevenueAnalysis";
            this.grpRevenueAnalysis.Size = new System.Drawing.Size(911, 449);
            this.grpRevenueAnalysis.TabIndex = 7;
            this.grpRevenueAnalysis.TabStop = false;
            this.grpRevenueAnalysis.Text = "Yearly Revenue Analysis";
            // 
            // chtData
            // 
            chartArea1.Name = "ChartArea1";
            this.chtData.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chtData.Legends.Add(legend1);
            this.chtData.Location = new System.Drawing.Point(0, 100);
            this.chtData.Name = "chtData";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Revenue";
            this.chtData.Series.Add(series1);
            this.chtData.Size = new System.Drawing.Size(896, 296);
            this.chtData.TabIndex = 15;
            this.chtData.Text = "chart1";
            this.chtData.Click += new System.EventHandler(this.chart1_Click);
            // 
            // labelRevenueYear
            // 
            this.labelRevenueYear.AutoSize = true;
            this.labelRevenueYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRevenueYear.Location = new System.Drawing.Point(379, 68);
            this.labelRevenueYear.Name = "labelRevenueYear";
            this.labelRevenueYear.Size = new System.Drawing.Size(42, 18);
            this.labelRevenueYear.TabIndex = 14;
            this.labelRevenueYear.Text = "Year";
            // 
            // cboRevenueYear
            // 
            this.cboRevenueYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRevenueYear.FormattingEnabled = true;
            this.cboRevenueYear.Location = new System.Drawing.Point(427, 68);
            this.cboRevenueYear.Name = "cboRevenueYear";
            this.cboRevenueYear.Size = new System.Drawing.Size(105, 20);
            this.cboRevenueYear.TabIndex = 1;
            this.cboRevenueYear.SelectedIndexChanged += new System.EventHandler(this.cboRevenueYear_SelectedIndexChanged);
            // 
            // btnRevenue
            // 
            this.btnRevenue.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRevenue.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnRevenue.Location = new System.Drawing.Point(369, 402);
            this.btnRevenue.Name = "btnRevenue";
            this.btnRevenue.Size = new System.Drawing.Size(187, 41);
            this.btnRevenue.TabIndex = 2;
            this.btnRevenue.Text = "Click to see Revenue";
            this.btnRevenue.UseVisualStyleBackColor = true;
            this.btnRevenue.Click += new System.EventHandler(this.btnRevenue_Click);
            // 
            // labelYearlyAnaylsis
            // 
            this.labelYearlyAnaylsis.AutoSize = true;
            this.labelYearlyAnaylsis.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelYearlyAnaylsis.Location = new System.Drawing.Point(321, 34);
            this.labelYearlyAnaylsis.Name = "labelYearlyAnaylsis";
            this.labelYearlyAnaylsis.Size = new System.Drawing.Size(319, 21);
            this.labelYearlyAnaylsis.TabIndex = 10;
            this.labelYearlyAnaylsis.Text = "Select a year to see the monthly revenue";
            this.labelYearlyAnaylsis.Click += new System.EventHandler(this.labelDeRegisterMember_Click);
            // 
            // frmYearlyRevenueAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 488);
            this.Controls.Add(this.grpRevenueAnalysis);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmYearlyRevenueAnalysis";
            this.Text = "Yearly Revenue Analysis [Game SYS]";
            this.Load += new System.EventHandler(this.frmYearlyRevenueAnalysis_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpRevenueAnalysis.ResumeLayout(false);
            this.grpRevenueAnalysis.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mainMenuToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpRevenueAnalysis;
        private System.Windows.Forms.Button btnRevenue;
        private System.Windows.Forms.Label labelYearlyAnaylsis;
        private System.Windows.Forms.ComboBox cboRevenueYear;
        private System.Windows.Forms.Label labelRevenueYear;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtData;
    }
}