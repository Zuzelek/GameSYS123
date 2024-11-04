
namespace GameSYS
{
    partial class frmAddGameType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddGameType));
            this.labelGameTitle = new System.Windows.Forms.Label();
            this.txtGameTitle = new System.Windows.Forms.TextBox();
            this.btmAddGame = new System.Windows.Forms.Button();
            this.grpBoxAddGame = new System.Windows.Forms.GroupBox();
            this.txtReleaseYear = new System.Windows.Forms.TextBox();
            this.labelReleaseYear = new System.Windows.Forms.Label();
            this.cboGameCategory = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelGameCategory = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpBoxAddGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelGameTitle
            // 
            this.labelGameTitle.AutoSize = true;
            this.labelGameTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGameTitle.Location = new System.Drawing.Point(65, 76);
            this.labelGameTitle.Name = "labelGameTitle";
            this.labelGameTitle.Size = new System.Drawing.Size(88, 16);
            this.labelGameTitle.TabIndex = 0;
            this.labelGameTitle.Text = "Game Title:";
            // 
            // txtGameTitle
            // 
            this.txtGameTitle.Location = new System.Drawing.Point(191, 74);
            this.txtGameTitle.Name = "txtGameTitle";
            this.txtGameTitle.Size = new System.Drawing.Size(100, 20);
            this.txtGameTitle.TabIndex = 3;
            this.txtGameTitle.TextChanged += new System.EventHandler(this.txtGameName_TextChanged);
            // 
            // btmAddGame
            // 
            this.btmAddGame.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btmAddGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmAddGame.Location = new System.Drawing.Point(115, 231);
            this.btmAddGame.Name = "btmAddGame";
            this.btmAddGame.Size = new System.Drawing.Size(142, 43);
            this.btmAddGame.TabIndex = 4;
            this.btmAddGame.Text = "Add Game";
            this.btmAddGame.UseVisualStyleBackColor = false;
            this.btmAddGame.Click += new System.EventHandler(this.btmAddGame_Click);
            // 
            // grpBoxAddGame
            // 
            this.grpBoxAddGame.Controls.Add(this.txtReleaseYear);
            this.grpBoxAddGame.Controls.Add(this.labelReleaseYear);
            this.grpBoxAddGame.Controls.Add(this.cboGameCategory);
            this.grpBoxAddGame.Controls.Add(this.pictureBox1);
            this.grpBoxAddGame.Controls.Add(this.labelGameCategory);
            this.grpBoxAddGame.Controls.Add(this.txtGameTitle);
            this.grpBoxAddGame.Controls.Add(this.btmAddGame);
            this.grpBoxAddGame.Controls.Add(this.labelGameTitle);
            this.grpBoxAddGame.Location = new System.Drawing.Point(12, 27);
            this.grpBoxAddGame.Name = "grpBoxAddGame";
            this.grpBoxAddGame.Size = new System.Drawing.Size(371, 435);
            this.grpBoxAddGame.TabIndex = 5;
            this.grpBoxAddGame.TabStop = false;
            this.grpBoxAddGame.Text = "Add Game";
            this.grpBoxAddGame.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtReleaseYear
            // 
            this.txtReleaseYear.Location = new System.Drawing.Point(191, 100);
            this.txtReleaseYear.MaxLength = 4;
            this.txtReleaseYear.Name = "txtReleaseYear";
            this.txtReleaseYear.Size = new System.Drawing.Size(100, 20);
            this.txtReleaseYear.TabIndex = 10;
            // 
            // labelReleaseYear
            // 
            this.labelReleaseYear.AutoSize = true;
            this.labelReleaseYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReleaseYear.Location = new System.Drawing.Point(65, 104);
            this.labelReleaseYear.Name = "labelReleaseYear";
            this.labelReleaseYear.Size = new System.Drawing.Size(108, 16);
            this.labelReleaseYear.TabIndex = 9;
            this.labelReleaseYear.Text = "Release Year:";
            // 
            // cboGameCategory
            // 
            this.cboGameCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGameCategory.FormattingEnabled = true;
            this.cboGameCategory.Location = new System.Drawing.Point(191, 126);
            this.cboGameCategory.Name = "cboGameCategory";
            this.cboGameCategory.Size = new System.Drawing.Size(100, 21);
            this.cboGameCategory.TabIndex = 8;
            this.cboGameCategory.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 280);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(325, 164);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // labelGameCategory
            // 
            this.labelGameCategory.AutoSize = true;
            this.labelGameCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGameCategory.Location = new System.Drawing.Point(65, 129);
            this.labelGameCategory.Name = "labelGameCategory";
            this.labelGameCategory.Size = new System.Drawing.Size(120, 16);
            this.labelGameCategory.TabIndex = 5;
            this.labelGameCategory.Text = "Game Category:";
            this.labelGameCategory.Click += new System.EventHandler(this.labelGameCategory_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(395, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.adminToolStripMenuItem.Text = "Back";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // frmAddGameType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 474);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.grpBoxAddGame);
            this.Name = "frmAddGameType";
            this.Text = "Add Game Type [Game SYS]";
            this.Load += new System.EventHandler(this.frmAddGameType_Load);
            this.grpBoxAddGame.ResumeLayout(false);
            this.grpBoxAddGame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelGameTitle;
        private System.Windows.Forms.TextBox txtGameTitle;
        private System.Windows.Forms.Button btmAddGame;
        private System.Windows.Forms.GroupBox grpBoxAddGame;
        private System.Windows.Forms.Label labelGameCategory;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cboGameCategory;
        private System.Windows.Forms.Label labelReleaseYear;
        private System.Windows.Forms.TextBox txtReleaseYear;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
    }
}

