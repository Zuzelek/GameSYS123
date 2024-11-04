using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameSYS
{
    public partial class frmRegisterMember : Form
    {
        frmMainMenu parent;
        //Member theMember = new Member();
        public frmRegisterMember()
        {
            InitializeComponent();
        }

        //CONSTRUCTOR 
        public frmRegisterMember(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
            txtMemberID.Text = Member.getNextMemberID().ToString("0000");
        }
        private void txtHouseNumber_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void btmRegister_Click(object sender, EventArgs e)
        {
            
            //Validation of Member details
            if(txtEmailAddress.Text.Trim() != txtRetypeEmail.Text.Trim())
            {
                MessageBox.Show("Email do not match, please try again","Invalid Email Address",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtEmailAddress.Focus();
                return;
            }
            //Validation of Member details
            if (txtPassword.Text.Trim() != txtPassword.Text.Trim())
            {
                MessageBox.Show("Passwords do not match, please try again", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmailAddress.Focus();
                return;
            }

            //Validating password 
            if (txtPassword.TextLength < 8 && txtPassword.TextLength > 15)
            {
                MessageBox.Show("Password must be between 8 and 15 characters", "Invalid password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Focus();
                return;
            }
            if (txtPassword.Text.Equals(""))
            {
                MessageBox.Show("Password cannot be empty, please try again.", "Password Not supplied");
                txtPassword.Focus();
                return;
            }
            if (txtPassword.Text.Trim() != txtRetypePassword.Text.Trim())
            {
                MessageBox.Show("Passwords do not match eachother, please try again", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRetypePassword.Focus();
                return;
            }
            //Validating Forename
            int nameValue;
            if(txtForename.Text.Equals(""))
            {
                MessageBox.Show("Forename must not be empty","Invalid Forename",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
                txtForename.Focus();
                return;

            }
            if(int.TryParse(txtForename.Text, out nameValue))
            {
                MessageBox.Show("Forename must not be numeric", "Invalid Forename", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                txtForename.Focus();
                return;
            }
            //Validating Surname
            if (txtSurname.Text.Equals(""))
            {
                MessageBox.Show("Surname must not be empty", "Invalid Surname", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                txtSurname.Focus();
                return;
            }
            if (int.TryParse(txtSurname.Text, out nameValue))
            {
                MessageBox.Show("Surname must not be numeric", "Invalid Surname", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                txtSurname.Focus();
                return;
            }
            //Validating Phone Number
            int phoneValue;
            if(!int.TryParse(txtMobileNumber.Text, out phoneValue))
            {
                MessageBox.Show("Phone number must be numeric", "Invalid Phone Number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMobileNumber.Focus();
                return;
            }

            int addressValue;
            //Validing street 
            if (txtStreet.Text.Equals(""))
            {
                MessageBox.Show("Street must not be empty", "Invalid Surname", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                txtStreet.Focus();
                return;
            }
            if (int.TryParse(txtStreet.Text, out addressValue))
            {
                MessageBox.Show("Street must not be numeric", "Invalid Street", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtStreet.Focus();
                return;
            }
            //Validing Town/City
            if (txtTownCity.Text.Equals(""))
            {
                MessageBox.Show("Town/City must not be empty", "Invalid Surname", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                txtTownCity.Focus();
                return;
            }
            if (int.TryParse(txtTownCity.Text, out addressValue))
            {
                MessageBox.Show("Town/City must not be numeric", "Invalid Town/City", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTownCity.Focus();
                return;
            }
            //Validating County
            if (cboCounties.SelectedIndex == -1)
            {
                MessageBox.Show("County must not be empty", "Invalid Surname", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                cboCounties.Focus();
                return;
            }
            if(txtEircode.Text.Length < 7)
            {
                MessageBox.Show("Eircode is too short, please enter eircode in proper format Ex. V92FY3A");
            }

            Member aMember = new Member(Convert.ToInt32(txtMemberID.Text), txtForename.Text, txtSurname.Text, txtEmailAddress.Text, txtPassword.Text,txtStreet.Text, txtTownCity.Text,
                                        cboCounties.Text.Substring(0, 2), txtEircode.Text, Convert.ToInt32(txtMobileNumber.Text),
                                        dtpDOB.Value.ToString("dd-MMM-yyyy"), DateTime.Today.ToString("dd-MMM-yyyy"), 'R');
            
            //Invoking the method to add Member to Members table
            aMember.registerMember();
            //Display a confirmation message
            MessageBox.Show("Account has been registered", "Register", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Reset UI
            txtMemberID.Text = Member.getNextMemberID().ToString("0000");
            txtEmailAddress.Clear();
            txtRetypeEmail.Clear();
            txtPassword.Clear();
            txtRetypePassword.Clear();
            txtForename.Clear();
            txtSurname.Clear();
            txtMobileNumber.Clear();
            txtStreet.Clear();
            txtTownCity.Clear();
            cboCounties.SelectedIndex = -1;
            txtEircode.Clear();
        }


        private void grpBoxRegisterMember_Enter(object sender, EventArgs e)
        {

        }

        private void frmRegisterMember_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            //ASSIGN A UNIQUE MemberID
            txtMemberID.Text = Member.getNextMemberID().ToString("0000");

            //Load Counties into ComboBox
            DataSet ds = County.getCounties();
            cboCounties.Items.Clear();

            for(int i=0; i < ds.Tables[0].Rows.Count; i++)
            {
                cboCounties.Items.Add(ds.Tables[0].Rows[i][0] + " - " + ds.Tables[0].Rows[i][1]);
            }


            //Set minimum DOB
            dtpDOB.MaxDate = DateTime.Today.AddYears(-16);
            dtpDOB.Value = DateTime.Today.AddYears(-16);
        }

        private void txtStreet_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMainMenu goBackMainMenu = new frmMainMenu();
            goBackMainMenu.Show();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dtpDOB_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtHouseNumber_TextChanged_1(object sender, EventArgs e)
        {

        }


        private void cboCounties_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtMemberID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEircode_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtForename_TextChanged(object sender, EventArgs e)
        {
            if (txtForename.Text.Length > 0)
            {
                string firstLetter = txtForename.Text.Substring(0, 1).ToUpper();
                string restLetters = txtForename.Text.Substring(1).ToLower();
                txtForename.Text = firstLetter + restLetters;
                txtForename.SelectionStart = txtForename.Text.Length;
            }
        }
    }
}
