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
	public partial class frmReturnGame : Form
	{
		Rental aRental = new Rental();
		public frmReturnGame()
		{
			InitializeComponent();
		}

        private void frmReturnGame_Load(object sender, EventArgs e)
        {
			CenterToScreen();


		}

        private void cboGameTitle_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void btnReturnGame_Click(object sender, EventArgs e)
        {
			
				int ID = Convert.ToInt32(grdMembers.Rows[grdMembers.CurrentCell.RowIndex].Cells[0].Value.ToString());

				aRental.returnGame(ID);
            
			

			//Display a confirmation Message
			MessageBox.Show("Game has been returned successfully", "Return Accepted", MessageBoxButtons.OK, MessageBoxIcon.Information);

			//ResetUI
			txtTitle.Clear();
        }
        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
			this.Hide();
			frmMainMenu mainMenu = new frmMainMenu();
			mainMenu.Show();
        }

        private void cboGameTitle_MouseLeave(object sender, EventArgs e)
        {


		}

        private void button1_Click(object sender, EventArgs e)
        {
			if (txtTitle.Text.Equals(""))
			{
				MessageBox.Show("Please input a game Title", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
				txtTitle.Focus();
				return;
			}
			float priceValue;
			if (float.TryParse(txtTitle.Text, out priceValue))
			{
				MessageBox.Show("Game Title cannot be numeric", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txtTitle.Focus();
				return;
			}
			grdMembers.DataSource = Game.findRentedGames(txtTitle.Text).Tables["game"];

			if (grdMembers.Rows.Count == 1)
			{
				MessageBox.Show("Game has not been found");
				txtTitle.Focus();
				return;
			}
		}

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {
			if (txtTitle.Text.Length > 0)
			{
				string firstLetter = txtTitle.Text.Substring(0, 1).ToUpper();
				string restLetters = txtTitle.Text.Substring(1).ToLower();
				txtTitle.Text = firstLetter + restLetters;
				txtTitle.SelectionStart = txtTitle.Text.Length;
			}
		}
    }
}
