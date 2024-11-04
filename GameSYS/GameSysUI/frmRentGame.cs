using Oracle.ManagedDataAccess.Client;
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
	public partial class frmRentGame : Form
	{
		Rental aRental = new Rental();
		RentalItems aRentalItem = new RentalItems();
		Category theCategory = new Category();
		Game aGame = new Game();
		public frmRentGame()
		{
			InitializeComponent();
		}

		private void frmRentGame_Load(object sender, EventArgs e)
		{
			CenterToScreen();
			//Assign RentalID
			txtRentalID.Text = Rental.getNextRentalID().ToString("0000");
			
			btnRentGame.Visible = false;
			dtpDueDate.Visible = false;
			labelReturnDate.Visible = false;

			//Set date calender
			dtpDueDate.MinDate = DateTime.Today;
			dtpDueDate.MaxDate = DateTime.Today.AddDays(14);
			dtpDueDate.Value = DateTime.Today.AddDays(3);
		}

		private void cboGameYear_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void btnRentGame_Click(object sender, EventArgs e)
        {

			if (txtMemberID.Text.Equals(""))
			{
				MessageBox.Show("Please enter a MemberID before proceeding.", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
				txtMemberID.Focus();
				return;
			}
			int result;
			if (!int.TryParse(txtMemberID.Text, out result))
			{
				MessageBox.Show("MemberID must be numeric", "Invalid MemberID", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
				txtMemberID.Focus();
				return;
			}
			if(lstGamesToRent.Items.Count == 0)
            {
				MessageBox.Show("Please pick a game to rent before proceeding.", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
				grdRentGameList.Focus();
				return;
			}



			DateTime startRentalDate = Convert.ToDateTime(DateTime.Now.ToString("dd-MMM-yyyy"));
			DateTime endRentalDate = Convert.ToDateTime(dtpDueDate.Value.ToString("dd-MMM-yyyy"));

			TimeSpan t = endRentalDate - startRentalDate;
			double numberOfDaysRented = t.TotalDays;

			/*
			for (int i = 0; i < gameid.Count; i++)
			{
				int ID = Convert.ToInt32(gameid[i]);
				aGame.updateGameStatus(ID);
				gameid.RemoveAt(i);
			}
			*/

			//Save Rental details in the Rentals File

			double totalToPay = 0;

			for (int i = 0; i < lstGamesToRent.Items.Count; i++)
			{
				String value = lstGamesToRent.Items[i].ToString();
				String price = value.Substring(0, 4);

				totalToPay += Convert.ToDouble(price) * numberOfDaysRented;
			}
			Rental aRental = new Rental(Convert.ToInt32(txtRentalID.Text), Convert.ToInt32(txtMemberID.Text), DateTime.Today.ToString("dd-MMM-yyyy"), dtpDueDate.Value.ToString("dd-MMM-yyyy"), Convert.ToDouble(totalToPay));
			aRental.rentAGame();

			for (int i = 0; i < lstGamesToRent.Items.Count; i++)
			{
				String value = lstGamesToRent.Items[i].ToString();

				String gameID = value.Substring(7, 2);

				RentalItems aRentalItem = new RentalItems(Convert.ToInt32(txtRentalID.Text), Convert.ToInt32(gameID));
				aRentalItem.rentGames();
			}
			


			//Display a confirmation message
			MessageBox.Show("Games have been succesfully rented, Total to pay: "+ totalToPay, "Game Rented", MessageBoxButtons.OK, MessageBoxIcon.Information);

			//Reset UI
			txtSearchGame.Clear();
			lstGamesToRent.Items.Clear();
			grdRentGameList.DataSource = null;
			txtMemberID.Clear();
			dtpDueDate.Value = DateTime.Today.AddDays(3);

			txtRentalID.Text = Rental.getNextRentalID().ToString("0000");
		}

		private void btnRentDetails_Click(object sender, EventArgs e)
		{

		}
		private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Hide();
			frmMainMenu mainMenu = new frmMainMenu();
			mainMenu.Show();
		}

		private void listBoxRentGame_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void btnSearchGame_Click(object sender, EventArgs e)
		{
			int gameName;
			//Validation
			if (txtSearchGame.Text.Equals(""))
			{
				MessageBox.Show("Please input a game title before proceeding.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txtSearchGame.Focus();
				return;
			}
			if (int.TryParse(txtSearchGame.Text, out gameName))
			{
				MessageBox.Show("Game Title cannot be numeric", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
				txtSearchGame.Focus();
				return;
			}

			grdRentGameList.DataSource = Game.findAvailableGames(txtSearchGame.Text).Tables["game"];

			if (grdRentGameList.Rows.Count == 1)
			{
				MessageBox.Show("No matching games have been found, please try again", "Error");
				txtSearchGame.Focus();
				return;
			}
			

		}

		private void grdRentGameList_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			btnRentGame.Visible = true;
			dtpDueDate.Visible = true;
			labelReturnDate.Visible = true;

		}

		private void grdRentGameList_CellLeave(object sender, DataGridViewCellEventArgs e)
		{
			
		}

        private void grdRentGameList_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
			var cell = grdRentGameList.Rows[e.RowIndex].Cells[e.ColumnIndex];

			if (cell.Value == null || string.IsNullOrWhiteSpace(cell.Value.ToString()))
			{
				MessageBox.Show("Please pick a game");
			}
			DateTime startRentalDate = Convert.ToDateTime(DateTime.Now.ToString("dd-MMM-yyyy"));
			DateTime endRentalDate = Convert.ToDateTime(dtpDueDate.Value.ToString("dd-MMM-yyyy"));

			TimeSpan t = endRentalDate - startRentalDate;
			double numberOfDaysRented = t.TotalDays;

			
			
		}

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void grdRentGameList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
			
		}

        private void grdRentGameList_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
			
		}

        private void grdRentGameList_Click(object sender, EventArgs e)
        {
			string gameInfo = grdRentGameList.Rows[0].Cells[3].Value + "   " + grdRentGameList.Rows[0].Cells[0].Value + "   " + grdRentGameList.Rows[0].Cells[1].Value;

			bool isDuplicate = false;

			foreach (object item in lstGamesToRent.Items)
			{
				if (item.ToString() == gameInfo)
				{
					isDuplicate = true;
					break;
				}
			}

			if (!isDuplicate)
			{
				lstGamesToRent.Items.Add(gameInfo);
			}
			else
			{
				MessageBox.Show("This game has already been selected.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
		}

        private void btnRemoveFromListBox_Click(object sender, EventArgs e)
        {
			if(lstGamesToRent.SelectedItems.Count != 0)
            {
				while(lstGamesToRent.SelectedIndex != -1)
                {
					lstGamesToRent.Items.RemoveAt(lstGamesToRent.SelectedIndex);
                }
            }
        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void txtSearchGame_TextChanged(object sender, EventArgs e)
        {
			if (txtSearchGame.Text.Length > 0)
			{
				string firstLetter = txtSearchGame.Text.Substring(0, 1).ToUpper();
				string restLetters = txtSearchGame.Text.Substring(1).ToLower();
				txtSearchGame.Text = firstLetter + restLetters;
				txtSearchGame.SelectionStart = txtSearchGame.Text.Length;
			}
		}
    }
}
