
namespace GameSYS
{
    partial class frmMainMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.membersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRegisterMember = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUpdateMember = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDeRegisterMember = new System.Windows.Forms.ToolStripMenuItem();
            this.gamesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddGame = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUpdateGameCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRemoveGame = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRentGame = new System.Windows.Forms.ToolStripMenuItem();
            this.rentGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReturnGame = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuYearlyRevAnalysis = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuYearlyGameAnalysis = new System.Windows.Forms.ToolStripMenuItem();
            this.grpMainMenu = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.grpMainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.menuStrip1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.membersToolStripMenuItem,
            this.gamesToolStripMenuItem,
            this.mnuRentGame,
            this.adminToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(540, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // membersToolStripMenuItem
            // 
            this.membersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRegisterMember,
            this.mnuUpdateMember,
            this.mnuDeRegisterMember});
            this.membersToolStripMenuItem.Name = "membersToolStripMenuItem";
            this.membersToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.membersToolStripMenuItem.Text = "Members";
            this.membersToolStripMenuItem.Click += new System.EventHandler(this.membersToolStripMenuItem_Click);
            // 
            // mnuRegisterMember
            // 
            this.mnuRegisterMember.Name = "mnuRegisterMember";
            this.mnuRegisterMember.Size = new System.Drawing.Size(206, 24);
            this.mnuRegisterMember.Text = "Register Member";
            this.mnuRegisterMember.Click += new System.EventHandler(this.mnuRegisterMember_Click);
            // 
            // mnuUpdateMember
            // 
            this.mnuUpdateMember.Name = "mnuUpdateMember";
            this.mnuUpdateMember.Size = new System.Drawing.Size(206, 24);
            this.mnuUpdateMember.Text = "Update Member Profile";
            this.mnuUpdateMember.Click += new System.EventHandler(this.mnuUpdateMember_Click);
            // 
            // mnuDeRegisterMember
            // 
            this.mnuDeRegisterMember.Name = "mnuDeRegisterMember";
            this.mnuDeRegisterMember.Size = new System.Drawing.Size(206, 24);
            this.mnuDeRegisterMember.Text = "De-Register Member";
            this.mnuDeRegisterMember.Click += new System.EventHandler(this.mnuDeRegisterMember_Click);
            // 
            // gamesToolStripMenuItem
            // 
            this.gamesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAddGame,
            this.mnuUpdateGameCategory,
            this.mnuRemoveGame});
            this.gamesToolStripMenuItem.Name = "gamesToolStripMenuItem";
            this.gamesToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.gamesToolStripMenuItem.Text = "Games";
            // 
            // mnuAddGame
            // 
            this.mnuAddGame.Name = "mnuAddGame";
            this.mnuAddGame.Size = new System.Drawing.Size(208, 24);
            this.mnuAddGame.Text = "Add Game";
            this.mnuAddGame.Click += new System.EventHandler(this.mnuAddGame_Click);
            // 
            // mnuUpdateGameCategory
            // 
            this.mnuUpdateGameCategory.Name = "mnuUpdateGameCategory";
            this.mnuUpdateGameCategory.Size = new System.Drawing.Size(208, 24);
            this.mnuUpdateGameCategory.Text = "Update Game Category";
            this.mnuUpdateGameCategory.Click += new System.EventHandler(this.mnuUpdateGameCategory_Click);
            // 
            // mnuRemoveGame
            // 
            this.mnuRemoveGame.Name = "mnuRemoveGame";
            this.mnuRemoveGame.Size = new System.Drawing.Size(208, 24);
            this.mnuRemoveGame.Text = "Remove Game";
            this.mnuRemoveGame.Click += new System.EventHandler(this.mnuRemoveGame_Click);
            // 
            // mnuRentGame
            // 
            this.mnuRentGame.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rentGameToolStripMenuItem,
            this.mnuReturnGame});
            this.mnuRentGame.Name = "mnuRentGame";
            this.mnuRentGame.Size = new System.Drawing.Size(63, 24);
            this.mnuRentGame.Text = "Rentals";
            // 
            // rentGameToolStripMenuItem
            // 
            this.rentGameToolStripMenuItem.Name = "rentGameToolStripMenuItem";
            this.rentGameToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this.rentGameToolStripMenuItem.Text = "Rent Game";
            this.rentGameToolStripMenuItem.Click += new System.EventHandler(this.rentGameToolStripMenuItem_Click);
            // 
            // mnuReturnGame
            // 
            this.mnuReturnGame.Name = "mnuReturnGame";
            this.mnuReturnGame.Size = new System.Drawing.Size(153, 24);
            this.mnuReturnGame.Text = "Return Game";
            this.mnuReturnGame.Click += new System.EventHandler(this.mnuReturnGame_Click);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuYearlyRevAnalysis,
            this.mnuYearlyGameAnalysis});
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // mnuYearlyRevAnalysis
            // 
            this.mnuYearlyRevAnalysis.Name = "mnuYearlyRevAnalysis";
            this.mnuYearlyRevAnalysis.Size = new System.Drawing.Size(210, 24);
            this.mnuYearlyRevAnalysis.Text = "Yearly Revenue Analysis";
            this.mnuYearlyRevAnalysis.Click += new System.EventHandler(this.mnuYearlyRevAnalysis_Click);
            // 
            // mnuYearlyGameAnalysis
            // 
            this.mnuYearlyGameAnalysis.Name = "mnuYearlyGameAnalysis";
            this.mnuYearlyGameAnalysis.Size = new System.Drawing.Size(210, 24);
            this.mnuYearlyGameAnalysis.Text = "Yearly Game Analysis";
            this.mnuYearlyGameAnalysis.Click += new System.EventHandler(this.mnuYearlyGameAnalysis_Click);
            // 
            // grpMainMenu
            // 
            this.grpMainMenu.Controls.Add(this.label2);
            this.grpMainMenu.Controls.Add(this.label1);
            this.grpMainMenu.Controls.Add(this.pictureBox1);
            this.grpMainMenu.Location = new System.Drawing.Point(12, 27);
            this.grpMainMenu.Name = "grpMainMenu";
            this.grpMainMenu.Size = new System.Drawing.Size(516, 458);
            this.grpMainMenu.TabIndex = 4;
            this.grpMainMenu.TabStop = false;
            this.grpMainMenu.Text = "Main Menu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(87, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(310, 28);
            this.label2.TabIndex = 8;
            this.label2.Text = "Choose an option to begin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(436, 33);
            this.label1.TabIndex = 7;
            this.label1.Text = "Welcome to the Game Rentals";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GameSYS.Properties.Resources.mainMenuPicture;
            this.pictureBox1.Location = new System.Drawing.Point(6, 91);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(504, 367);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 497);
            this.Controls.Add(this.grpMainMenu);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmMainMenu";
            this.Text = "Main Menu [Game SYS]";
            this.Load += new System.EventHandler(this.frmMainMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpMainMenu.ResumeLayout(false);
            this.grpMainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem membersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuRegisterMember;
        private System.Windows.Forms.ToolStripMenuItem mnuUpdateMember;
        private System.Windows.Forms.ToolStripMenuItem mnuDeRegisterMember;
        private System.Windows.Forms.ToolStripMenuItem gamesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuAddGame;
        private System.Windows.Forms.ToolStripMenuItem mnuUpdateGameCategory;
        private System.Windows.Forms.ToolStripMenuItem mnuRemoveGame;
        private System.Windows.Forms.ToolStripMenuItem mnuRentGame;
        private System.Windows.Forms.ToolStripMenuItem rentGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuReturnGame;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuYearlyRevAnalysis;
        private System.Windows.Forms.ToolStripMenuItem mnuYearlyGameAnalysis;
        private System.Windows.Forms.GroupBox grpMainMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}