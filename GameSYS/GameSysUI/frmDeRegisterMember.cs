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
    public partial class frmDeRegisterMember : Form
    {
        Member aMember = new Member();
        public frmDeRegisterMember()
        {
            InitializeComponent();
        }

        private void frmDeRegisterMember_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            grdDeRegisterMember.Hide();
        }
        private void btnDeRegisterMember_Click(object sender, EventArgs e)
        {
            if (grdDeRegisterMember.SelectedCells.Count > 0)
            {
                // Get the selected cell's value

                int ID = Convert.ToInt32(grdDeRegisterMember.Rows[grdDeRegisterMember.CurrentCell.RowIndex].Cells[0].Value.ToString());
                aMember.deregisterMember(ID);
            }
            else
            {
                // No cell is currently selected
                MessageBox.Show("Please search and pick a member before proceeding.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }



            //Validate if Member has games rented, if a member does have a game rented Display and error Message and terminate function
            //Setting member status to deregistered
            

            //Confirmation message
            MessageBox.Show("Member has been de-registered succesfully", "De-register");




        }
        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMainMenu mainMenu = new frmMainMenu();
            mainMenu.Show();
        }

        private void grpDeRegisterMember_Enter(object sender, EventArgs e)
        {

        }

        private void btnSearchMem_Click(object sender, EventArgs e)
        {

            if(txtSearch.Text.Equals(""))
            {
                MessageBox.Show("Please input a forename.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSearch.Focus();
                return;
            }

            grdDeRegisterMember.DataSource = Member.findRegisteredMembers(txtSearch.Text).Tables["memr"];

            if (grdDeRegisterMember.Rows.Count == 1)
            {
                MessageBox.Show("No matching member was found");
                txtSearch.Focus();
                return;
            }

            grdDeRegisterMember.Visible = true;
        }

        private void grdDeRegisterMember_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void grdDeRegisterMember_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int ID = Convert.ToInt32(grdDeRegisterMember.Rows[grdDeRegisterMember.CurrentCell.RowIndex].Cells[0].Value.ToString());

            aMember.getMember(ID);
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
    }
}
