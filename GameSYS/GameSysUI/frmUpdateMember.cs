using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace GameSYS
{
    public partial class frmUpdateMember : Form
    {
        Member aMember = new Member();
        public frmUpdateMember()
        {
            InitializeComponent();
        }

        private void frmUpdateMember_Load(object sender, EventArgs e)
        {
            CenterToScreen();

            //Load Counties into ComboBox
            DataSet ds = County.getCounties();
            cboCounties.Items.Clear();

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                cboCounties.Items.Add(ds.Tables[0].Rows[i][0] + " - " + ds.Tables[0].Rows[i][1]);
            }
        }
        private void btmRegister_Click_1(object sender, EventArgs e)
        {
            //Validating email to be the same as retype email
            if (txtEmailAddress.Text.Trim() != txtRetypeEmail.Text.Trim())
            {
                MessageBox.Show("Retype email address must match your email address", "Invalid Email Address", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if(txtPassword.Text.Equals(""))
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
            if (txtForename.Text.Equals(""))
            {
                MessageBox.Show("Forename must not be empty", "Invalid Forename", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                txtForename.Focus();
                return;

            }
            if (int.TryParse(txtForename.Text, out nameValue))
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
            if (!int.TryParse(txtMobileNumber.Text, out phoneValue))
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
            if(cboCounties.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a county", "Invalid County");
                cboCounties.Focus();
                return;
            }


            //SET UpdDate = System Date
            aMember.setForename(txtForename.Text);
            aMember.setSurname(txtSurname.Text);
            aMember.setPassword(txtPassword.Text);
            aMember.setEmailAddress(txtEmailAddress.Text);
            aMember.setPhone(Convert.ToInt32(txtMobileNumber.Text));
            aMember.setStreet(txtStreet.Text);
            aMember.setCity(txtTownCity.Text);
            aMember.setCountyID(cboCounties.Text.Substring(0, 1));
            aMember.setEircode(txtEircode.Text);

            aMember.updateMember();

            //Display a confirmation message
            MessageBox.Show("Account has been succesfully updated", "Updated Succesfully", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Reset UI
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

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMainMenu mainMenu = new frmMainMenu();
            mainMenu.Show();
        }
        private void btnSearchMem_Click(object sender, EventArgs e)
        {

            if(txtSearch.Text.Equals(""))
            {
                MessageBox.Show("Please input Members name.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSearch.Focus();
                return;
            }

            grdMembers.DataSource = Member.findMembers(txtSearch.Text).Tables["memr"];

            if(grdMembers.Rows.Count == 1)
            {
                MessageBox.Show("No Member/s Found");
                txtSearch.Focus();
                return;
            }

            grdMembers.Visible = true;
        }

        private void grdMembers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int memId = Convert.ToInt32(grdMembers.Rows[grdMembers.CurrentCell.RowIndex].Cells[0].Value.ToString());

            //Instantiating a member

            aMember.getMember(memId);

            //Load data into textboxes
            txtForename.Text = aMember.getForename();
            txtSurname.Text = aMember.getSurname();
            txtEmailAddress.Text = aMember.getEmailAddress();
            txtPassword.Text = aMember.getPassword();
            txtRetypePassword.Text = aMember.getPassword();
            txtRetypeEmail.Text = aMember.getEmailAddress();
            txtStreet.Text = aMember.getStreet();
            txtTownCity.Text = aMember.getCity();
            cboCounties.SelectedIndex = Convert.ToInt32(aMember.getCountyID()) - 1;
            txtEircode.Text = aMember.getEircode();
            txtMobileNumber.Text = aMember.getPhone().ToString();


        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text.Length > 0)
            {
                string firstLetter = txtSearch.Text.Substring(0, 1).ToUpper();
                string restLetters = txtSearch.Text.Substring(1).ToLower();
                txtSearch.Text = firstLetter + restLetters;
                txtSearch.SelectionStart = txtSearch.Text.Length;
            }
        }

        private void txtForename_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
