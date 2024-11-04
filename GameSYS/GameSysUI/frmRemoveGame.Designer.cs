
namespace GameSYS
{
	partial class frmRemoveGame
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
            this.grpRemoveGame = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSearchGame = new System.Windows.Forms.Button();
            this.grdRemoveGame = new System.Windows.Forms.DataGridView();
            this.labelGameTitle = new System.Windows.Forms.Label();
            this.txtGameTitle = new System.Windows.Forms.TextBox();
            this.btnRemoveGame = new System.Windows.Forms.Button();
            this.mainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.grpRemoveGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdRemoveGame)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpRemoveGame
            // 
            this.grpRemoveGame.Controls.Add(this.pictureBox1);
            this.grpRemoveGame.Controls.Add(this.btnSearchGame);
            this.grpRemoveGame.Controls.Add(this.grdRemoveGame);
            this.grpRemoveGame.Controls.Add(this.labelGameTitle);
            this.grpRemoveGame.Controls.Add(this.txtGameTitle);
            this.grpRemoveGame.Controls.Add(this.btnRemoveGame);
            this.grpRemoveGame.ForeColor = System.Drawing.SystemColors.MenuText;
            this.grpRemoveGame.Location = new System.Drawing.Point(12, 33);
            this.grpRemoveGame.Name = "grpRemoveGame";
            this.grpRemoveGame.Size = new System.Drawing.Size(413, 439);
            this.grpRemoveGame.TabIndex = 7;
            this.grpRemoveGame.TabStop = false;
            this.grpRemoveGame.Text = "Remove Game";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GameSYS.Properties.Resources.mainMenuBackground;
            this.pictureBox1.Location = new System.Drawing.Point(51, 247);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(307, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // btnSearchGame
            // 
            this.btnSearchGame.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchGame.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnSearchGame.Location = new System.Drawing.Point(272, 39);
            this.btnSearchGame.Name = "btnSearchGame";
            this.btnSearchGame.Size = new System.Drawing.Size(119, 35);
            this.btnSearchGame.TabIndex = 15;
            this.btnSearchGame.Text = "Search";
            this.btnSearchGame.UseVisualStyleBackColor = true;
            this.btnSearchGame.Click += new System.EventHandler(this.btnSearchGame_Click);
            // 
            // grdRemoveGame
            // 
            this.grdRemoveGame.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdRemoveGame.Location = new System.Drawing.Point(6, 77);
            this.grdRemoveGame.Name = "grdRemoveGame";
            this.grdRemoveGame.Size = new System.Drawing.Size(401, 164);
            this.grdRemoveGame.TabIndex = 14;
            this.grdRemoveGame.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdRemoveGame_CellClick);
            this.grdRemoveGame.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdRemoveGame_CellContentClick);
            // 
            // labelGameTitle
            // 
            this.labelGameTitle.AutoSize = true;
            this.labelGameTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGameTitle.Location = new System.Drawing.Point(64, 53);
            this.labelGameTitle.Name = "labelGameTitle";
            this.labelGameTitle.Size = new System.Drawing.Size(96, 16);
            this.labelGameTitle.TabIndex = 13;
            this.labelGameTitle.Text = "Search Title:";
            // 
            // txtGameTitle
            // 
            this.txtGameTitle.Location = new System.Drawing.Point(166, 51);
            this.txtGameTitle.Name = "txtGameTitle";
            this.txtGameTitle.Size = new System.Drawing.Size(100, 20);
            this.txtGameTitle.TabIndex = 12;
            this.txtGameTitle.TextChanged += new System.EventHandler(this.txtGameTitle_TextChanged);
            // 
            // btnRemoveGame
            // 
            this.btnRemoveGame.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveGame.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnRemoveGame.Location = new System.Drawing.Point(119, 386);
            this.btnRemoveGame.Name = "btnRemoveGame";
            this.btnRemoveGame.Size = new System.Drawing.Size(194, 47);
            this.btnRemoveGame.TabIndex = 11;
            this.btnRemoveGame.Text = "Remove Game";
            this.btnRemoveGame.UseVisualStyleBackColor = true;
            this.btnRemoveGame.Click += new System.EventHandler(this.btnRemoveGame_Click);
            // 
            // mainMenuToolStripMenuItem
            // 
            this.mainMenuToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mainMenuToolStripMenuItem.Name = "mainMenuToolStripMenuItem";
            this.mainMenuToolStripMenuItem.Size = new System.Drawing.Size(97, 21);
            this.mainMenuToolStripMenuItem.Text = "Main Menu";
            this.mainMenuToolStripMenuItem.Click += new System.EventHandler(this.mainMenuToolStripMenuItem_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.menuStrip.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenuToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(437, 25);
            this.menuStrip.TabIndex = 8;
            this.menuStrip.Text = "menuStrip1";
            // 
            // frmRemoveGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 484);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.grpRemoveGame);
            this.Name = "frmRemoveGame";
            this.Text = "Remove Game [Game SYS]";
            this.Load += new System.EventHandler(this.frmRemoveGame_Load);
            this.grpRemoveGame.ResumeLayout(false);
            this.grpRemoveGame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdRemoveGame)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox grpRemoveGame;
		private System.Windows.Forms.Button btnRemoveGame;
		private System.Windows.Forms.TextBox txtGameTitle;
		private System.Windows.Forms.Label labelGameTitle;
        private System.Windows.Forms.Button btnSearchGame;
        private System.Windows.Forms.DataGridView grdRemoveGame;
        private System.Windows.Forms.ToolStripMenuItem mainMenuToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}