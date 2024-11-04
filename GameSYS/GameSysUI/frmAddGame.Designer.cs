
namespace GameSYS
{
    partial class frmAddGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddGame));
            this.labelGameTitle = new System.Windows.Forms.Label();
            this.txtGameTitle = new System.Windows.Forms.TextBox();
            this.btmAddGame = new System.Windows.Forms.Button();
            this.grpBoxAddGame = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGameID = new System.Windows.Forms.TextBox();
            this.dtpReleaseYear = new System.Windows.Forms.DateTimePicker();
            this.cboGameGenre = new System.Windows.Forms.ComboBox();
            this.labelGameGenre = new System.Windows.Forms.Label();
            this.labelReleaseYear = new System.Windows.Forms.Label();
            this.cboGameCategory = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelGameCategory = new System.Windows.Forms.Label();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.mainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpBoxAddGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelGameTitle
            // 
            this.labelGameTitle.AutoSize = true;
            this.labelGameTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGameTitle.Location = new System.Drawing.Point(65, 76);
            this.labelGameTitle.Name = "labelGameTitle";
            this.labelGameTitle.Size = new System.Drawing.Size(43, 16);
            this.labelGameTitle.TabIndex = 0;
            this.labelGameTitle.Text = "Title:";
            // 
            // txtGameTitle
            // 
            this.txtGameTitle.Location = new System.Drawing.Point(191, 74);
            this.txtGameTitle.Name = "txtGameTitle";
            this.txtGameTitle.Size = new System.Drawing.Size(100, 20);
            this.txtGameTitle.TabIndex = 2;
            this.txtGameTitle.TextChanged += new System.EventHandler(this.txtGameName_TextChanged);
            // 
            // btmAddGame
            // 
            this.btmAddGame.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btmAddGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmAddGame.Location = new System.Drawing.Point(115, 231);
            this.btmAddGame.Name = "btmAddGame";
            this.btmAddGame.Size = new System.Drawing.Size(142, 43);
            this.btmAddGame.TabIndex = 5;
            this.btmAddGame.Text = "Add Game";
            this.btmAddGame.UseVisualStyleBackColor = false;
            this.btmAddGame.Click += new System.EventHandler(this.btmAddGame_Click);
            // 
            // grpBoxAddGame
            // 
            this.grpBoxAddGame.Controls.Add(this.label1);
            this.grpBoxAddGame.Controls.Add(this.txtGameID);
            this.grpBoxAddGame.Controls.Add(this.dtpReleaseYear);
            this.grpBoxAddGame.Controls.Add(this.cboGameGenre);
            this.grpBoxAddGame.Controls.Add(this.labelGameGenre);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(240, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 41;
            this.label1.Text = "GameID:";
            // 
            // txtGameID
            // 
            this.txtGameID.Location = new System.Drawing.Point(310, 10);
            this.txtGameID.Name = "txtGameID";
            this.txtGameID.ReadOnly = true;
            this.txtGameID.Size = new System.Drawing.Size(55, 20);
            this.txtGameID.TabIndex = 40;
            // 
            // dtpReleaseYear
            // 
            this.dtpReleaseYear.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpReleaseYear.Location = new System.Drawing.Point(191, 100);
            this.dtpReleaseYear.Name = "dtpReleaseYear";
            this.dtpReleaseYear.Size = new System.Drawing.Size(100, 20);
            this.dtpReleaseYear.TabIndex = 3;
            // 
            // cboGameGenre
            // 
            this.cboGameGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGameGenre.FormattingEnabled = true;
            this.cboGameGenre.Location = new System.Drawing.Point(191, 129);
            this.cboGameGenre.Name = "cboGameGenre";
            this.cboGameGenre.Size = new System.Drawing.Size(100, 21);
            this.cboGameGenre.TabIndex = 4;
            this.cboGameGenre.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // labelGameGenre
            // 
            this.labelGameGenre.AutoSize = true;
            this.labelGameGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGameGenre.Location = new System.Drawing.Point(65, 129);
            this.labelGameGenre.Name = "labelGameGenre";
            this.labelGameGenre.Size = new System.Drawing.Size(54, 16);
            this.labelGameGenre.TabIndex = 11;
            this.labelGameGenre.Text = "Genre:";
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
            this.cboGameCategory.Location = new System.Drawing.Point(191, 47);
            this.cboGameCategory.Name = "cboGameCategory";
            this.cboGameCategory.Size = new System.Drawing.Size(100, 21);
            this.cboGameCategory.TabIndex = 1;
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
            this.labelGameCategory.Location = new System.Drawing.Point(65, 48);
            this.labelGameCategory.Name = "labelGameCategory";
            this.labelGameCategory.Size = new System.Drawing.Size(75, 16);
            this.labelGameCategory.TabIndex = 5;
            this.labelGameCategory.Text = "Category:";
            this.labelGameCategory.Click += new System.EventHandler(this.labelGameCategory_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenuToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(395, 25);
            this.menuStrip2.TabIndex = 7;
            this.menuStrip2.Text = "menuStrip2";
            this.menuStrip2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip2_ItemClicked);
            // 
            // mainMenuToolStripMenuItem
            // 
            this.mainMenuToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mainMenuToolStripMenuItem.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenuToolStripMenuItem.Name = "mainMenuToolStripMenuItem";
            this.mainMenuToolStripMenuItem.Size = new System.Drawing.Size(97, 21);
            this.mainMenuToolStripMenuItem.Text = "Main Menu";
            this.mainMenuToolStripMenuItem.Click += new System.EventHandler(this.mainMenuToolStripMenuItem_Click);
            // 
            // frmAddGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 474);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.grpBoxAddGame);
            this.Name = "frmAddGame";
            this.Text = "Add Game Type [Game SYS]";
            this.Load += new System.EventHandler(this.frmAddGameType_Load);
            this.grpBoxAddGame.ResumeLayout(false);
            this.grpBoxAddGame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
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
        private System.Windows.Forms.ComboBox cboGameGenre;
        private System.Windows.Forms.Label labelGameGenre;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem mainMenuToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker dtpReleaseYear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGameID;
    }
}

