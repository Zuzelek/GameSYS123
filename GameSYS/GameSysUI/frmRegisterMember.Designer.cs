
namespace GameSYS
{
    partial class frmRegisterMember
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
            this.components = new System.ComponentModel.Container();
            this.grpBoxRegisterMember = new System.Windows.Forms.GroupBox();
            this.cboCounties = new System.Windows.Forms.ComboBox();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.labelMemberID = new System.Windows.Forms.Label();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.labelEircode = new System.Windows.Forms.Label();
            this.txtEircode = new System.Windows.Forms.TextBox();
            this.txtTownCity = new System.Windows.Forms.TextBox();
            this.labelCounty = new System.Windows.Forms.Label();
            this.labelTownCity = new System.Windows.Forms.Label();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.labelAddress2 = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.btmRegister = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelDateOfBirth = new System.Windows.Forms.Label();
            this.labelPersonalInfo = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelRetypeEmail = new System.Windows.Forms.Label();
            this.txtRetypeEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtMobileNumber = new System.Windows.Forms.TextBox();
            this.labelMobileNumber = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.labelSurname = new System.Windows.Forms.Label();
            this.txtForename = new System.Windows.Forms.TextBox();
            this.labelForename = new System.Windows.Forms.Label();
            this.txtRetypePassword = new System.Windows.Forms.TextBox();
            this.labelRetypePassword = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.txtEmailAddress = new System.Windows.Forms.TextBox();
            this.labelNewAccount = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpBoxRegisterMember.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoxRegisterMember
            // 
            this.grpBoxRegisterMember.Controls.Add(this.cboCounties);
            this.grpBoxRegisterMember.Controls.Add(this.txtMemberID);
            this.grpBoxRegisterMember.Controls.Add(this.labelMemberID);
            this.grpBoxRegisterMember.Controls.Add(this.dtpDOB);
            this.grpBoxRegisterMember.Controls.Add(this.labelEircode);
            this.grpBoxRegisterMember.Controls.Add(this.txtEircode);
            this.grpBoxRegisterMember.Controls.Add(this.txtTownCity);
            this.grpBoxRegisterMember.Controls.Add(this.labelCounty);
            this.grpBoxRegisterMember.Controls.Add(this.labelTownCity);
            this.grpBoxRegisterMember.Controls.Add(this.txtStreet);
            this.grpBoxRegisterMember.Controls.Add(this.labelAddress2);
            this.grpBoxRegisterMember.Controls.Add(this.labelAddress);
            this.grpBoxRegisterMember.Controls.Add(this.btmRegister);
            this.grpBoxRegisterMember.Controls.Add(this.label1);
            this.grpBoxRegisterMember.Controls.Add(this.labelDateOfBirth);
            this.grpBoxRegisterMember.Controls.Add(this.labelPersonalInfo);
            this.grpBoxRegisterMember.Controls.Add(this.labelPassword);
            this.grpBoxRegisterMember.Controls.Add(this.labelRetypeEmail);
            this.grpBoxRegisterMember.Controls.Add(this.txtRetypeEmail);
            this.grpBoxRegisterMember.Controls.Add(this.txtPassword);
            this.grpBoxRegisterMember.Controls.Add(this.txtMobileNumber);
            this.grpBoxRegisterMember.Controls.Add(this.labelMobileNumber);
            this.grpBoxRegisterMember.Controls.Add(this.txtSurname);
            this.grpBoxRegisterMember.Controls.Add(this.labelSurname);
            this.grpBoxRegisterMember.Controls.Add(this.txtForename);
            this.grpBoxRegisterMember.Controls.Add(this.labelForename);
            this.grpBoxRegisterMember.Controls.Add(this.txtRetypePassword);
            this.grpBoxRegisterMember.Controls.Add(this.labelRetypePassword);
            this.grpBoxRegisterMember.Controls.Add(this.labelEmail);
            this.grpBoxRegisterMember.Controls.Add(this.txtEmailAddress);
            this.grpBoxRegisterMember.Controls.Add(this.labelNewAccount);
            this.grpBoxRegisterMember.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxRegisterMember.Location = new System.Drawing.Point(12, 25);
            this.grpBoxRegisterMember.Name = "grpBoxRegisterMember";
            this.grpBoxRegisterMember.Size = new System.Drawing.Size(513, 564);
            this.grpBoxRegisterMember.TabIndex = 0;
            this.grpBoxRegisterMember.TabStop = false;
            this.grpBoxRegisterMember.Text = "Create Account";
            this.grpBoxRegisterMember.Enter += new System.EventHandler(this.grpBoxRegisterMember_Enter);
            // 
            // cboCounties
            // 
            this.cboCounties.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCounties.FormattingEnabled = true;
            this.cboCounties.Location = new System.Drawing.Point(252, 411);
            this.cboCounties.Name = "cboCounties";
            this.cboCounties.Size = new System.Drawing.Size(166, 20);
            this.cboCounties.TabIndex = 13;
            this.cboCounties.SelectedIndexChanged += new System.EventHandler(this.cboCounties_SelectedIndexChanged);
            // 
            // txtMemberID
            // 
            this.txtMemberID.Location = new System.Drawing.Point(458, 21);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.ReadOnly = true;
            this.txtMemberID.Size = new System.Drawing.Size(49, 20);
            this.txtMemberID.TabIndex = 40;
            this.txtMemberID.TextChanged += new System.EventHandler(this.txtMemberID_TextChanged);
            // 
            // labelMemberID
            // 
            this.labelMemberID.AutoSize = true;
            this.labelMemberID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMemberID.Location = new System.Drawing.Point(380, 22);
            this.labelMemberID.Name = "labelMemberID";
            this.labelMemberID.Size = new System.Drawing.Size(78, 15);
            this.labelMemberID.TabIndex = 39;
            this.labelMemberID.Text = "Member ID";
            // 
            // dtpDOB
            // 
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDOB.Location = new System.Drawing.Point(48, 294);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(197, 20);
            this.dtpDOB.TabIndex = 8;
            this.dtpDOB.ValueChanged += new System.EventHandler(this.dtpDOB_ValueChanged);
            // 
            // labelEircode
            // 
            this.labelEircode.AutoSize = true;
            this.labelEircode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEircode.Location = new System.Drawing.Point(45, 392);
            this.labelEircode.Name = "labelEircode";
            this.labelEircode.Size = new System.Drawing.Size(66, 15);
            this.labelEircode.TabIndex = 36;
            this.labelEircode.Text = "Eircode *";
            // 
            // txtEircode
            // 
            this.txtEircode.Location = new System.Drawing.Point(48, 411);
            this.txtEircode.MaxLength = 7;
            this.txtEircode.Name = "txtEircode";
            this.txtEircode.Size = new System.Drawing.Size(166, 20);
            this.txtEircode.TabIndex = 12;
            this.txtEircode.TextChanged += new System.EventHandler(this.txtEircode_TextChanged);
            // 
            // txtTownCity
            // 
            this.txtTownCity.Location = new System.Drawing.Point(252, 363);
            this.txtTownCity.MaxLength = 20;
            this.txtTownCity.Name = "txtTownCity";
            this.txtTownCity.Size = new System.Drawing.Size(166, 20);
            this.txtTownCity.TabIndex = 11;
            // 
            // labelCounty
            // 
            this.labelCounty.AutoSize = true;
            this.labelCounty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCounty.Location = new System.Drawing.Point(249, 392);
            this.labelCounty.Name = "labelCounty";
            this.labelCounty.Size = new System.Drawing.Size(60, 15);
            this.labelCounty.TabIndex = 32;
            this.labelCounty.Text = "County *";
            // 
            // labelTownCity
            // 
            this.labelTownCity.AutoSize = true;
            this.labelTownCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTownCity.Location = new System.Drawing.Point(249, 345);
            this.labelTownCity.Name = "labelTownCity";
            this.labelTownCity.Size = new System.Drawing.Size(78, 15);
            this.labelTownCity.TabIndex = 30;
            this.labelTownCity.Text = "Town/City *";
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(48, 363);
            this.txtStreet.MaxLength = 20;
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(166, 20);
            this.txtStreet.TabIndex = 10;
            this.txtStreet.TextChanged += new System.EventHandler(this.txtStreet_TextChanged);
            // 
            // labelAddress2
            // 
            this.labelAddress2.AutoSize = true;
            this.labelAddress2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddress2.Location = new System.Drawing.Point(45, 345);
            this.labelAddress2.Name = "labelAddress2";
            this.labelAddress2.Size = new System.Drawing.Size(55, 15);
            this.labelAddress2.TabIndex = 28;
            this.labelAddress2.Text = "Street *";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddress.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.labelAddress.Location = new System.Drawing.Point(29, 326);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(96, 19);
            this.labelAddress.TabIndex = 25;
            this.labelAddress.Text = "Your Address";
            // 
            // btmRegister
            // 
            this.btmRegister.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmRegister.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btmRegister.Location = new System.Drawing.Point(164, 512);
            this.btmRegister.Name = "btmRegister";
            this.btmRegister.Size = new System.Drawing.Size(183, 38);
            this.btmRegister.TabIndex = 14;
            this.btmRegister.Text = "Register";
            this.btmRegister.UseVisualStyleBackColor = true;
            this.btmRegister.Click += new System.EventHandler(this.btmRegister_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Location = new System.Drawing.Point(30, 269);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "You must be at least 16 years of age to register";
            // 
            // labelDateOfBirth
            // 
            this.labelDateOfBirth.AutoSize = true;
            this.labelDateOfBirth.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateOfBirth.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.labelDateOfBirth.Location = new System.Drawing.Point(29, 250);
            this.labelDateOfBirth.Name = "labelDateOfBirth";
            this.labelDateOfBirth.Size = new System.Drawing.Size(128, 19);
            this.labelDateOfBirth.TabIndex = 16;
            this.labelDateOfBirth.Text = "Your Date of Birth";
            // 
            // labelPersonalInfo
            // 
            this.labelPersonalInfo.AutoSize = true;
            this.labelPersonalInfo.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPersonalInfo.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.labelPersonalInfo.Location = new System.Drawing.Point(29, 59);
            this.labelPersonalInfo.Name = "labelPersonalInfo";
            this.labelPersonalInfo.Size = new System.Drawing.Size(181, 19);
            this.labelPersonalInfo.TabIndex = 15;
            this.labelPersonalInfo.Text = "Your Personal Information";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(45, 121);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(79, 15);
            this.labelPassword.TabIndex = 14;
            this.labelPassword.Text = "Password *";
            // 
            // labelRetypeEmail
            // 
            this.labelRetypeEmail.AutoSize = true;
            this.labelRetypeEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRetypeEmail.Location = new System.Drawing.Point(249, 160);
            this.labelRetypeEmail.Name = "labelRetypeEmail";
            this.labelRetypeEmail.Size = new System.Drawing.Size(138, 15);
            this.labelRetypeEmail.TabIndex = 13;
            this.labelRetypeEmail.Text = "Confirm your email *";
            // 
            // txtRetypeEmail
            // 
            this.txtRetypeEmail.Location = new System.Drawing.Point(252, 178);
            this.txtRetypeEmail.MaxLength = 35;
            this.txtRetypeEmail.Name = "txtRetypeEmail";
            this.txtRetypeEmail.Size = new System.Drawing.Size(166, 20);
            this.txtRetypeEmail.TabIndex = 6;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(48, 137);
            this.txtPassword.MaxLength = 20;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(166, 20);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // txtMobileNumber
            // 
            this.txtMobileNumber.Location = new System.Drawing.Point(48, 217);
            this.txtMobileNumber.MaxLength = 10;
            this.txtMobileNumber.Name = "txtMobileNumber";
            this.txtMobileNumber.Size = new System.Drawing.Size(166, 20);
            this.txtMobileNumber.TabIndex = 7;
            this.txtMobileNumber.TextChanged += new System.EventHandler(this.txtHouseNumber_TextChanged);
            // 
            // labelMobileNumber
            // 
            this.labelMobileNumber.AutoSize = true;
            this.labelMobileNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMobileNumber.Location = new System.Drawing.Point(45, 199);
            this.labelMobileNumber.Name = "labelMobileNumber";
            this.labelMobileNumber.Size = new System.Drawing.Size(106, 15);
            this.labelMobileNumber.TabIndex = 9;
            this.labelMobileNumber.Text = "Mobile Phone *";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(252, 98);
            this.txtSurname.MaxLength = 20;
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(166, 20);
            this.txtSurname.TabIndex = 2;
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSurname.Location = new System.Drawing.Point(249, 80);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(75, 15);
            this.labelSurname.TabIndex = 7;
            this.labelSurname.Text = "Surname *";
            // 
            // txtForename
            // 
            this.txtForename.Location = new System.Drawing.Point(48, 100);
            this.txtForename.MaxLength = 20;
            this.txtForename.Name = "txtForename";
            this.txtForename.Size = new System.Drawing.Size(166, 20);
            this.txtForename.TabIndex = 1;
            this.txtForename.TextChanged += new System.EventHandler(this.txtForename_TextChanged);
            // 
            // labelForename
            // 
            this.labelForename.AutoSize = true;
            this.labelForename.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelForename.Location = new System.Drawing.Point(45, 82);
            this.labelForename.Name = "labelForename";
            this.labelForename.Size = new System.Drawing.Size(82, 15);
            this.labelForename.TabIndex = 5;
            this.labelForename.Text = "Forename *";
            // 
            // txtRetypePassword
            // 
            this.txtRetypePassword.Location = new System.Drawing.Point(252, 137);
            this.txtRetypePassword.MaxLength = 20;
            this.txtRetypePassword.Name = "txtRetypePassword";
            this.txtRetypePassword.PasswordChar = '*';
            this.txtRetypePassword.Size = new System.Drawing.Size(166, 20);
            this.txtRetypePassword.TabIndex = 4;
            // 
            // labelRetypePassword
            // 
            this.labelRetypePassword.AutoSize = true;
            this.labelRetypePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRetypePassword.Location = new System.Drawing.Point(249, 121);
            this.labelRetypePassword.Name = "labelRetypePassword";
            this.labelRetypePassword.Size = new System.Drawing.Size(163, 15);
            this.labelRetypePassword.TabIndex = 3;
            this.labelRetypePassword.Text = "Confirm your password *";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(45, 160);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(109, 15);
            this.labelEmail.TabIndex = 2;
            this.labelEmail.Text = "Email Address *";
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.Location = new System.Drawing.Point(48, 178);
            this.txtEmailAddress.MaxLength = 35;
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.Size = new System.Drawing.Size(166, 20);
            this.txtEmailAddress.TabIndex = 5;
            // 
            // labelNewAccount
            // 
            this.labelNewAccount.AutoSize = true;
            this.labelNewAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNewAccount.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.labelNewAccount.Location = new System.Drawing.Point(6, 26);
            this.labelNewAccount.Name = "labelNewAccount";
            this.labelNewAccount.Size = new System.Drawing.Size(135, 24);
            this.labelNewAccount.TabIndex = 0;
            this.labelNewAccount.Text = "New Account";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.menuStrip1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(540, 25);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(97, 21);
            this.backToolStripMenuItem.Text = "Main Menu";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // frmRegisterMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 588);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.grpBoxRegisterMember);
            this.Name = "frmRegisterMember";
            this.Text = "Main Menu [Game Sys]";
            this.Load += new System.EventHandler(this.frmRegisterMember_Load);
            this.grpBoxRegisterMember.ResumeLayout(false);
            this.grpBoxRegisterMember.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxRegisterMember;
        private System.Windows.Forms.Label labelNewAccount;
        private System.Windows.Forms.TextBox txtMobileNumber;
        private System.Windows.Forms.Label labelMobileNumber;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtForename;
        private System.Windows.Forms.Label labelForename;
        private System.Windows.Forms.TextBox txtRetypePassword;
        private System.Windows.Forms.Label labelRetypePassword;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox txtEmailAddress;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelRetypeEmail;
        private System.Windows.Forms.TextBox txtRetypeEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelDateOfBirth;
        private System.Windows.Forms.Label labelPersonalInfo;
        private System.Windows.Forms.Button btmRegister;
        private System.Windows.Forms.Label labelEircode;
        private System.Windows.Forms.TextBox txtEircode;
        private System.Windows.Forms.TextBox txtTownCity;
        private System.Windows.Forms.Label labelCounty;
        private System.Windows.Forms.Label labelTownCity;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.Label labelAddress2;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.ToolTip toolTip1;
        public System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.Label labelMemberID;
        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.ComboBox cboCounties;
    }
}