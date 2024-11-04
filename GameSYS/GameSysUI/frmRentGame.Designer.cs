
namespace GameSYS
{
	partial class frmRentGame
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.mainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpRentGame = new System.Windows.Forms.GroupBox();
            this.btnRemoveFromListBox = new System.Windows.Forms.Button();
            this.lstGamesToRent = new System.Windows.Forms.ListBox();
            this.labelReturnDate = new System.Windows.Forms.Label();
            this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.grdRentGameList = new System.Windows.Forms.DataGridView();
            this.btnSearchGame = new System.Windows.Forms.Button();
            this.txtSearchGame = new System.Windows.Forms.TextBox();
            this.labelGameTitle = new System.Windows.Forms.Label();
            this.btnRentGame = new System.Windows.Forms.Button();
            this.labelRent = new System.Windows.Forms.Label();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.labelMemberID = new System.Windows.Forms.Label();
            this.txtRentalID = new System.Windows.Forms.TextBox();
            this.labelRentalID = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.grpRentGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdRentGameList)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.menuStrip.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenuToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(599, 25);
            this.menuStrip.TabIndex = 6;
            this.menuStrip.Text = "menuStrip1";
            this.menuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip_ItemClicked);
            // 
            // mainMenuToolStripMenuItem
            // 
            this.mainMenuToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mainMenuToolStripMenuItem.Name = "mainMenuToolStripMenuItem";
            this.mainMenuToolStripMenuItem.Size = new System.Drawing.Size(97, 21);
            this.mainMenuToolStripMenuItem.Text = "Main Menu";
            this.mainMenuToolStripMenuItem.Click += new System.EventHandler(this.mainMenuToolStripMenuItem_Click);
            // 
            // grpRentGame
            // 
            this.grpRentGame.Controls.Add(this.btnRemoveFromListBox);
            this.grpRentGame.Controls.Add(this.lstGamesToRent);
            this.grpRentGame.Controls.Add(this.labelReturnDate);
            this.grpRentGame.Controls.Add(this.dtpDueDate);
            this.grpRentGame.Controls.Add(this.grdRentGameList);
            this.grpRentGame.Controls.Add(this.btnSearchGame);
            this.grpRentGame.Controls.Add(this.txtSearchGame);
            this.grpRentGame.Controls.Add(this.labelGameTitle);
            this.grpRentGame.Controls.Add(this.btnRentGame);
            this.grpRentGame.Controls.Add(this.labelRent);
            this.grpRentGame.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F);
            this.grpRentGame.Location = new System.Drawing.Point(12, 27);
            this.grpRentGame.Name = "grpRentGame";
            this.grpRentGame.Size = new System.Drawing.Size(575, 500);
            this.grpRentGame.TabIndex = 9;
            this.grpRentGame.TabStop = false;
            this.grpRentGame.Text = "Rent Game";
            // 
            // btnRemoveFromListBox
            // 
            this.btnRemoveFromListBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveFromListBox.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnRemoveFromListBox.Location = new System.Drawing.Point(449, 271);
            this.btnRemoveFromListBox.Name = "btnRemoveFromListBox";
            this.btnRemoveFromListBox.Size = new System.Drawing.Size(112, 34);
            this.btnRemoveFromListBox.TabIndex = 27;
            this.btnRemoveFromListBox.Text = "Remove Game";
            this.btnRemoveFromListBox.UseVisualStyleBackColor = true;
            this.btnRemoveFromListBox.Click += new System.EventHandler(this.btnRemoveFromListBox_Click);
            // 
            // lstGamesToRent
            // 
            this.lstGamesToRent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstGamesToRent.FormattingEnabled = true;
            this.lstGamesToRent.ItemHeight = 18;
            this.lstGamesToRent.Location = new System.Drawing.Point(119, 249);
            this.lstGamesToRent.Name = "lstGamesToRent";
            this.lstGamesToRent.Size = new System.Drawing.Size(321, 76);
            this.lstGamesToRent.TabIndex = 26;
            // 
            // labelReturnDate
            // 
            this.labelReturnDate.AutoSize = true;
            this.labelReturnDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReturnDate.Location = new System.Drawing.Point(126, 375);
            this.labelReturnDate.Name = "labelReturnDate";
            this.labelReturnDate.Size = new System.Drawing.Size(94, 16);
            this.labelReturnDate.TabIndex = 23;
            this.labelReturnDate.Text = "Return Date:";
            // 
            // dtpDueDate
            // 
            this.dtpDueDate.Location = new System.Drawing.Point(232, 371);
            this.dtpDueDate.Name = "dtpDueDate";
            this.dtpDueDate.Size = new System.Drawing.Size(200, 20);
            this.dtpDueDate.TabIndex = 4;
            // 
            // grdRentGameList
            // 
            this.grdRentGameList.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grdRentGameList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdRentGameList.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.grdRentGameList.Location = new System.Drawing.Point(56, 91);
            this.grdRentGameList.Name = "grdRentGameList";
            this.grdRentGameList.Size = new System.Drawing.Size(441, 92);
            this.grdRentGameList.TabIndex = 19;
            this.grdRentGameList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdRentGameList_CellClick);
            this.grdRentGameList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdRentGameList_CellContentClick);
            this.grdRentGameList.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdRentGameList_CellEndEdit);
            this.grdRentGameList.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdRentGameList_CellLeave);
            this.grdRentGameList.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grdRentGameList_RowHeaderMouseClick);
            this.grdRentGameList.Click += new System.EventHandler(this.grdRentGameList_Click);
            // 
            // btnSearchGame
            // 
            this.btnSearchGame.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSearchGame.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchGame.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnSearchGame.Location = new System.Drawing.Point(332, 53);
            this.btnSearchGame.Name = "btnSearchGame";
            this.btnSearchGame.Size = new System.Drawing.Size(100, 36);
            this.btnSearchGame.TabIndex = 2;
            this.btnSearchGame.Text = "Search";
            this.btnSearchGame.UseVisualStyleBackColor = false;
            this.btnSearchGame.Click += new System.EventHandler(this.btnSearchGame_Click);
            // 
            // txtSearchGame
            // 
            this.txtSearchGame.Location = new System.Drawing.Point(226, 64);
            this.txtSearchGame.Name = "txtSearchGame";
            this.txtSearchGame.Size = new System.Drawing.Size(100, 20);
            this.txtSearchGame.TabIndex = 1;
            this.txtSearchGame.TextChanged += new System.EventHandler(this.txtSearchGame_TextChanged);
            // 
            // labelGameTitle
            // 
            this.labelGameTitle.AutoSize = true;
            this.labelGameTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGameTitle.Location = new System.Drawing.Point(177, 66);
            this.labelGameTitle.Name = "labelGameTitle";
            this.labelGameTitle.Size = new System.Drawing.Size(43, 16);
            this.labelGameTitle.TabIndex = 14;
            this.labelGameTitle.Text = "Title:";
            // 
            // btnRentGame
            // 
            this.btnRentGame.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRentGame.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnRentGame.Location = new System.Drawing.Point(200, 458);
            this.btnRentGame.Name = "btnRentGame";
            this.btnRentGame.Size = new System.Drawing.Size(187, 36);
            this.btnRentGame.TabIndex = 6;
            this.btnRentGame.Text = "Click to Rent";
            this.btnRentGame.UseVisualStyleBackColor = true;
            this.btnRentGame.Click += new System.EventHandler(this.btnRentGame_Click);
            // 
            // labelRent
            // 
            this.labelRent.AutoSize = true;
            this.labelRent.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRent.Location = new System.Drawing.Point(166, 16);
            this.labelRent.Name = "labelRent";
            this.labelRent.Size = new System.Drawing.Size(274, 21);
            this.labelRent.TabIndex = 10;
            this.labelRent.Text = "Search for a game you wish to rent";
            // 
            // txtMemberID
            // 
            this.txtMemberID.Location = new System.Drawing.Point(97, 4);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.Size = new System.Drawing.Size(45, 20);
            this.txtMemberID.TabIndex = 18;
            // 
            // labelMemberID
            // 
            this.labelMemberID.AutoSize = true;
            this.labelMemberID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.labelMemberID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMemberID.Location = new System.Drawing.Point(14, 6);
            this.labelMemberID.Name = "labelMemberID";
            this.labelMemberID.Size = new System.Drawing.Size(79, 16);
            this.labelMemberID.TabIndex = 22;
            this.labelMemberID.Text = "MemberID";
            // 
            // txtRentalID
            // 
            this.txtRentalID.Location = new System.Drawing.Point(238, 4);
            this.txtRentalID.Name = "txtRentalID";
            this.txtRentalID.ReadOnly = true;
            this.txtRentalID.Size = new System.Drawing.Size(45, 20);
            this.txtRentalID.TabIndex = 23;
            // 
            // labelRentalID
            // 
            this.labelRentalID.AutoSize = true;
            this.labelRentalID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.labelRentalID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRentalID.Location = new System.Drawing.Point(166, 6);
            this.labelRentalID.Name = "labelRentalID";
            this.labelRentalID.Size = new System.Drawing.Size(68, 16);
            this.labelRentalID.TabIndex = 24;
            this.labelRentalID.Text = "RentalID";
            // 
            // frmRentGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 539);
            this.Controls.Add(this.labelRentalID);
            this.Controls.Add(this.txtRentalID);
            this.Controls.Add(this.labelMemberID);
            this.Controls.Add(this.txtMemberID);
            this.Controls.Add(this.grpRentGame);
            this.Controls.Add(this.menuStrip);
            this.Name = "frmRentGame";
            this.Text = "Rent Game [Game SYS]";
            this.Load += new System.EventHandler(this.frmRentGame_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.grpRentGame.ResumeLayout(false);
            this.grpRentGame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdRentGameList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.ToolStripMenuItem mainMenuToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpRentGame;
        private System.Windows.Forms.Label labelGameTitle;
        private System.Windows.Forms.Button btnRentGame;
        private System.Windows.Forms.Label labelRent;
        private System.Windows.Forms.Button btnSearchGame;
        private System.Windows.Forms.TextBox txtSearchGame;
        private System.Windows.Forms.DateTimePicker dtpDueDate;
        private System.Windows.Forms.DataGridView grdRentGameList;
        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.Label labelMemberID;
        private System.Windows.Forms.TextBox txtRentalID;
        private System.Windows.Forms.Label labelRentalID;
        private System.Windows.Forms.Label labelReturnDate;
        private System.Windows.Forms.Button btnRemoveFromListBox;
        private System.Windows.Forms.ListBox lstGamesToRent;
    }
}