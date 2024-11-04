
namespace GameSYS
{
    partial class frmYearlyGameAnalysis
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
            this.grpGameAnalysis = new System.Windows.Forms.GroupBox();
            this.chtGameData = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelGameYear = new System.Windows.Forms.Label();
            this.cboGameYear = new System.Windows.Forms.ComboBox();
            this.btnGameAnalysis = new System.Windows.Forms.Button();
            this.labelGameAnalysis = new System.Windows.Forms.Label();
            this.mainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.grpGameAnalysis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtGameData)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpGameAnalysis
            // 
            this.grpGameAnalysis.Controls.Add(this.chtGameData);
            this.grpGameAnalysis.Controls.Add(this.labelGameYear);
            this.grpGameAnalysis.Controls.Add(this.cboGameYear);
            this.grpGameAnalysis.Controls.Add(this.btnGameAnalysis);
            this.grpGameAnalysis.Controls.Add(this.labelGameAnalysis);
            this.grpGameAnalysis.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpGameAnalysis.Location = new System.Drawing.Point(12, 27);
            this.grpGameAnalysis.Name = "grpGameAnalysis";
            this.grpGameAnalysis.Size = new System.Drawing.Size(800, 408);
            this.grpGameAnalysis.TabIndex = 8;
            this.grpGameAnalysis.TabStop = false;
            this.grpGameAnalysis.Text = "Yearly Game Analysis";
            // 
            // chtGameData
            // 
            chartArea1.Name = "ChartArea1";
            this.chtGameData.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chtGameData.Legends.Add(legend1);
            this.chtGameData.Location = new System.Drawing.Point(6, 87);
            this.chtGameData.Name = "chtGameData";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "GameAnalysis";
            this.chtGameData.Series.Add(series1);
            this.chtGameData.Size = new System.Drawing.Size(788, 272);
            this.chtGameData.TabIndex = 15;
            this.chtGameData.Text = "chart1";
            // 
            // labelGameYear
            // 
            this.labelGameYear.AutoSize = true;
            this.labelGameYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGameYear.Location = new System.Drawing.Point(312, 58);
            this.labelGameYear.Name = "labelGameYear";
            this.labelGameYear.Size = new System.Drawing.Size(47, 20);
            this.labelGameYear.TabIndex = 14;
            this.labelGameYear.Text = "Year";
            // 
            // cboGameYear
            // 
            this.cboGameYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGameYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboGameYear.FormattingEnabled = true;
            this.cboGameYear.Location = new System.Drawing.Point(370, 55);
            this.cboGameYear.Name = "cboGameYear";
            this.cboGameYear.Size = new System.Drawing.Size(100, 28);
            this.cboGameYear.TabIndex = 1;
            // 
            // btnGameAnalysis
            // 
            this.btnGameAnalysis.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGameAnalysis.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnGameAnalysis.Location = new System.Drawing.Point(304, 365);
            this.btnGameAnalysis.Name = "btnGameAnalysis";
            this.btnGameAnalysis.Size = new System.Drawing.Size(187, 40);
            this.btnGameAnalysis.TabIndex = 2;
            this.btnGameAnalysis.Text = "Click to see Revenue";
            this.btnGameAnalysis.UseVisualStyleBackColor = true;
            this.btnGameAnalysis.Click += new System.EventHandler(this.btnGameAnalysis_Click);
            // 
            // labelGameAnalysis
            // 
            this.labelGameAnalysis.AutoSize = true;
            this.labelGameAnalysis.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGameAnalysis.Location = new System.Drawing.Point(190, 16);
            this.labelGameAnalysis.Name = "labelGameAnalysis";
            this.labelGameAnalysis.Size = new System.Drawing.Size(476, 21);
            this.labelGameAnalysis.TabIndex = 10;
            this.labelGameAnalysis.Text = "Select a year to display the total games rented in each month";
            // 
            // mainMenuToolStripMenuItem
            // 
            this.mainMenuToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mainMenuToolStripMenuItem.Name = "mainMenuToolStripMenuItem";
            this.mainMenuToolStripMenuItem.Size = new System.Drawing.Size(97, 21);
            this.mainMenuToolStripMenuItem.Text = "Main Menu";
            this.mainMenuToolStripMenuItem.Click += new System.EventHandler(this.mainMenuToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.menuStrip1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(824, 25);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // frmYearlyGameAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 447);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.grpGameAnalysis);
            this.Name = "frmYearlyGameAnalysis";
            this.Text = "Yearly Game Analysis [Game SYS]";
            this.Load += new System.EventHandler(this.frmYearlyGameAnalysis_Load);
            this.grpGameAnalysis.ResumeLayout(false);
            this.grpGameAnalysis.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtGameData)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpGameAnalysis;
        private System.Windows.Forms.Label labelGameYear;
        private System.Windows.Forms.ComboBox cboGameYear;
        private System.Windows.Forms.Button btnGameAnalysis;
        private System.Windows.Forms.Label labelGameAnalysis;
        private System.Windows.Forms.ToolStripMenuItem mainMenuToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtGameData;
    }
}