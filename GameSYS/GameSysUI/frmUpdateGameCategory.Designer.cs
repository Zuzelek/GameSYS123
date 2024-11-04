
namespace GameSYS
{
	partial class frmUpdateGameCategory
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
            this.labelGameCategory = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.txtCategoryPrice = new System.Windows.Forms.TextBox();
            this.btnUpdateGameCategory = new System.Windows.Forms.Button();
            this.grpUpdateGameCategory = new System.Windows.Forms.GroupBox();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.grdCategories = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.grpUpdateGameCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCategories)).BeginInit();
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
            this.menuStrip.Size = new System.Drawing.Size(442, 25);
            this.menuStrip.TabIndex = 6;
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
            // labelGameCategory
            // 
            this.labelGameCategory.AutoSize = true;
            this.labelGameCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGameCategory.Location = new System.Drawing.Point(124, 208);
            this.labelGameCategory.Name = "labelGameCategory";
            this.labelGameCategory.Size = new System.Drawing.Size(75, 16);
            this.labelGameCategory.TabIndex = 10;
            this.labelGameCategory.Text = "Category:";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.Location = new System.Drawing.Point(145, 266);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(48, 16);
            this.labelPrice.TabIndex = 11;
            this.labelPrice.Text = "Price:";
            // 
            // txtCategoryPrice
            // 
            this.txtCategoryPrice.Location = new System.Drawing.Point(205, 264);
            this.txtCategoryPrice.MaxLength = 4;
            this.txtCategoryPrice.Name = "txtCategoryPrice";
            this.txtCategoryPrice.Size = new System.Drawing.Size(100, 20);
            this.txtCategoryPrice.TabIndex = 2;
            this.txtCategoryPrice.TextChanged += new System.EventHandler(this.txtCategoryPrice_TextChanged);
            // 
            // btnUpdateGameCategory
            // 
            this.btnUpdateGameCategory.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateGameCategory.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnUpdateGameCategory.Location = new System.Drawing.Point(125, 345);
            this.btnUpdateGameCategory.Name = "btnUpdateGameCategory";
            this.btnUpdateGameCategory.Size = new System.Drawing.Size(180, 46);
            this.btnUpdateGameCategory.TabIndex = 3;
            this.btnUpdateGameCategory.Text = "Update Category";
            this.btnUpdateGameCategory.UseVisualStyleBackColor = true;
            this.btnUpdateGameCategory.Click += new System.EventHandler(this.btnUpdateGameCategory_Click);
            // 
            // grpUpdateGameCategory
            // 
            this.grpUpdateGameCategory.Controls.Add(this.label1);
            this.grpUpdateGameCategory.Controls.Add(this.txtCategoryName);
            this.grpUpdateGameCategory.Controls.Add(this.grdCategories);
            this.grpUpdateGameCategory.Controls.Add(this.btnUpdateGameCategory);
            this.grpUpdateGameCategory.Controls.Add(this.labelGameCategory);
            this.grpUpdateGameCategory.Controls.Add(this.labelPrice);
            this.grpUpdateGameCategory.Controls.Add(this.txtCategoryPrice);
            this.grpUpdateGameCategory.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpUpdateGameCategory.Location = new System.Drawing.Point(12, 27);
            this.grpUpdateGameCategory.Name = "grpUpdateGameCategory";
            this.grpUpdateGameCategory.Size = new System.Drawing.Size(418, 428);
            this.grpUpdateGameCategory.TabIndex = 14;
            this.grpUpdateGameCategory.TabStop = false;
            this.grpUpdateGameCategory.Text = "Update Category";
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Location = new System.Drawing.Point(205, 208);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(100, 20);
            this.txtCategoryName.TabIndex = 1;
            // 
            // grdCategories
            // 
            this.grdCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCategories.Location = new System.Drawing.Point(7, 56);
            this.grdCategories.Name = "grdCategories";
            this.grdCategories.Size = new System.Drawing.Size(405, 135);
            this.grdCategories.TabIndex = 14;
            this.grdCategories.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCategories_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(114, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Pick a category to proceed";
            // 
            // frmUpdateGameCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 461);
            this.Controls.Add(this.grpUpdateGameCategory);
            this.Controls.Add(this.menuStrip);
            this.Name = "frmUpdateGameCategory";
            this.Text = "Update Game Category [GameSYS]";
            this.Load += new System.EventHandler(this.frmUpdateGameCategory_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.grpUpdateGameCategory.ResumeLayout(false);
            this.grpUpdateGameCategory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCategories)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.ToolStripMenuItem mainMenuToolStripMenuItem;
		private System.Windows.Forms.Label labelGameCategory;
		private System.Windows.Forms.Label labelPrice;
		private System.Windows.Forms.TextBox txtCategoryPrice;
		private System.Windows.Forms.Button btnUpdateGameCategory;
		private System.Windows.Forms.GroupBox grpUpdateGameCategory;
        private System.Windows.Forms.DataGridView grdCategories;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.Label label1;
    }
}