
namespace GameSYS
{
	partial class frmReturnGame
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
            this.grpReturnGame = new System.Windows.Forms.GroupBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.grdMembers = new System.Windows.Forms.DataGridView();
            this.btnReturnGame = new System.Windows.Forms.Button();
            this.labelRent = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.mainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpReturnGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMembers)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpReturnGame
            // 
            this.grpReturnGame.Controls.Add(this.labelTitle);
            this.grpReturnGame.Controls.Add(this.btnSearch);
            this.grpReturnGame.Controls.Add(this.txtTitle);
            this.grpReturnGame.Controls.Add(this.grdMembers);
            this.grpReturnGame.Controls.Add(this.btnReturnGame);
            this.grpReturnGame.Controls.Add(this.labelRent);
            this.grpReturnGame.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F);
            this.grpReturnGame.Location = new System.Drawing.Point(12, 27);
            this.grpReturnGame.Name = "grpReturnGame";
            this.grpReturnGame.Size = new System.Drawing.Size(582, 488);
            this.grpReturnGame.TabIndex = 10;
            this.grpReturnGame.TabStop = false;
            this.grpReturnGame.Text = "Return Game";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(229, 59);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(39, 17);
            this.labelTitle.TabIndex = 19;
            this.labelTitle.Text = "Title";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnSearch.Location = new System.Drawing.Point(232, 85);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(136, 41);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(274, 59);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(100, 20);
            this.txtTitle.TabIndex = 1;
            this.txtTitle.TextChanged += new System.EventHandler(this.txtTitle_TextChanged);
            // 
            // grdMembers
            // 
            this.grdMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMembers.Location = new System.Drawing.Point(73, 180);
            this.grdMembers.Name = "grdMembers";
            this.grdMembers.Size = new System.Drawing.Size(447, 165);
            this.grdMembers.TabIndex = 4;
            // 
            // btnReturnGame
            // 
            this.btnReturnGame.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnGame.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnReturnGame.Location = new System.Drawing.Point(202, 424);
            this.btnReturnGame.Name = "btnReturnGame";
            this.btnReturnGame.Size = new System.Drawing.Size(187, 52);
            this.btnReturnGame.TabIndex = 5;
            this.btnReturnGame.Text = "Click to Return";
            this.btnReturnGame.UseVisualStyleBackColor = true;
            this.btnReturnGame.Click += new System.EventHandler(this.btnReturnGame_Click);
            // 
            // labelRent
            // 
            this.labelRent.AutoSize = true;
            this.labelRent.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRent.Location = new System.Drawing.Point(158, 16);
            this.labelRent.Name = "labelRent";
            this.labelRent.Size = new System.Drawing.Size(273, 21);
            this.labelRent.TabIndex = 10;
            this.labelRent.Text = "Search and select a game to return";
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.menuStrip.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenuToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(606, 25);
            this.menuStrip.TabIndex = 11;
            this.menuStrip.Text = "menuStrip1";
            // 
            // mainMenuToolStripMenuItem
            // 
            this.mainMenuToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mainMenuToolStripMenuItem.Name = "mainMenuToolStripMenuItem";
            this.mainMenuToolStripMenuItem.Size = new System.Drawing.Size(97, 21);
            this.mainMenuToolStripMenuItem.Text = "Main Menu";
            this.mainMenuToolStripMenuItem.Click += new System.EventHandler(this.mainMenuToolStripMenuItem_Click);
            // 
            // frmReturnGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 527);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.grpReturnGame);
            this.Name = "frmReturnGame";
            this.Text = "Return Game [Game SYS]";
            this.Load += new System.EventHandler(this.frmReturnGame_Load);
            this.grpReturnGame.ResumeLayout(false);
            this.grpReturnGame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMembers)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion

        private System.Windows.Forms.GroupBox grpReturnGame;
        private System.Windows.Forms.Button btnReturnGame;
        private System.Windows.Forms.Label labelRent;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem mainMenuToolStripMenuItem;
        private System.Windows.Forms.DataGridView grdMembers;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox txtTitle;
    }
}