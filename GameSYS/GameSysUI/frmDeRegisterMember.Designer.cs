
namespace GameSYS
{
    partial class frmDeRegisterMember
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
            this.grpDeRegisterMember = new System.Windows.Forms.GroupBox();
            this.btnSearchMem = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.labelSearch = new System.Windows.Forms.Label();
            this.grdDeRegisterMember = new System.Windows.Forms.DataGridView();
            this.btnDeRegisterMember = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.grpDeRegisterMember.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDeRegisterMember)).BeginInit();
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
            this.menuStrip.Size = new System.Drawing.Size(435, 25);
            this.menuStrip.TabIndex = 5;
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
            // grpDeRegisterMember
            // 
            this.grpDeRegisterMember.Controls.Add(this.btnSearchMem);
            this.grpDeRegisterMember.Controls.Add(this.txtSearch);
            this.grpDeRegisterMember.Controls.Add(this.labelSearch);
            this.grpDeRegisterMember.Controls.Add(this.grdDeRegisterMember);
            this.grpDeRegisterMember.Controls.Add(this.btnDeRegisterMember);
            this.grpDeRegisterMember.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDeRegisterMember.Location = new System.Drawing.Point(13, 27);
            this.grpDeRegisterMember.Name = "grpDeRegisterMember";
            this.grpDeRegisterMember.Size = new System.Drawing.Size(410, 452);
            this.grpDeRegisterMember.TabIndex = 6;
            this.grpDeRegisterMember.TabStop = false;
            this.grpDeRegisterMember.Text = "De-Register Member";
            this.grpDeRegisterMember.Enter += new System.EventHandler(this.grpDeRegisterMember_Enter);
            // 
            // btnSearchMem
            // 
            this.btnSearchMem.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchMem.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnSearchMem.Location = new System.Drawing.Point(287, 19);
            this.btnSearchMem.Name = "btnSearchMem";
            this.btnSearchMem.Size = new System.Drawing.Size(117, 39);
            this.btnSearchMem.TabIndex = 2;
            this.btnSearchMem.Text = "Search";
            this.btnSearchMem.UseVisualStyleBackColor = true;
            this.btnSearchMem.Click += new System.EventHandler(this.btnSearchMem_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(172, 30);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(108, 20);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearch.Location = new System.Drawing.Point(16, 30);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(157, 18);
            this.labelSearch.TabIndex = 39;
            this.labelSearch.Text = "Member Forename";
            // 
            // grdDeRegisterMember
            // 
            this.grdDeRegisterMember.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grdDeRegisterMember.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grdDeRegisterMember.GridColor = System.Drawing.SystemColors.Info;
            this.grdDeRegisterMember.Location = new System.Drawing.Point(7, 92);
            this.grdDeRegisterMember.Name = "grdDeRegisterMember";
            this.grdDeRegisterMember.Size = new System.Drawing.Size(397, 155);
            this.grdDeRegisterMember.TabIndex = 13;
            this.grdDeRegisterMember.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDeRegisterMember_CellClick);
            this.grdDeRegisterMember.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDeRegisterMember_CellContentClick);
            // 
            // btnDeRegisterMember
            // 
            this.btnDeRegisterMember.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeRegisterMember.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnDeRegisterMember.Location = new System.Drawing.Point(63, 328);
            this.btnDeRegisterMember.Name = "btnDeRegisterMember";
            this.btnDeRegisterMember.Size = new System.Drawing.Size(290, 71);
            this.btnDeRegisterMember.TabIndex = 3;
            this.btnDeRegisterMember.Text = "De-Register Member";
            this.btnDeRegisterMember.UseVisualStyleBackColor = true;
            this.btnDeRegisterMember.Click += new System.EventHandler(this.btnDeRegisterMember_Click);
            // 
            // frmDeRegisterMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 491);
            this.Controls.Add(this.grpDeRegisterMember);
            this.Controls.Add(this.menuStrip);
            this.Name = "frmDeRegisterMember";
            this.Text = "De-Register Member [Game SYS]";
            this.Load += new System.EventHandler(this.frmDeRegisterMember_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.grpDeRegisterMember.ResumeLayout(false);
            this.grpDeRegisterMember.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDeRegisterMember)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem mainMenuToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpDeRegisterMember;
        private System.Windows.Forms.Button btnDeRegisterMember;
        private System.Windows.Forms.DataGridView grdDeRegisterMember;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.Button btnSearchMem;
    }
}