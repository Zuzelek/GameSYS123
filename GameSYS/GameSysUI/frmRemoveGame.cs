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
	public partial class frmRemoveGame : Form
	{
		Game aGame = new Game();
		public frmRemoveGame()
		{
			InitializeComponent();
		}

		private void frmRemoveGame_Load(object sender, EventArgs e)
		{
			CenterToScreen();
			//Retrieve GameID and Game Title from Games File
			
			
			//Validate if game is rented, game cannot be deleted


			//If game is not rented Set Game Status to Unavailable ‘U’

			//Update Game status in Games file

			//Display a confirmation message



			//ResetUI
			txtGameTitle.Clear();
		}
        private void btnRemoveGame_Click(object sender, EventArgs e)
        {
			//Validating that Manager picked a game to be removed
			int ID = Convert.ToInt32(grdRemoveGame.Rows[grdRemoveGame.CurrentCell.RowIndex].Cells[0].Value.ToString());

			aGame.updateGameStatus(ID);

			MessageBox.Show("Game has been removed");
			
		}
        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
			this.Hide();
			frmMainMenu mainMenu = new frmMainMenu();
			mainMenu.Show();
        }

        private void btnSearchGame_Click(object sender, EventArgs e)
        {
			if(txtGameTitle.Text.Equals(""))
            {
				MessageBox.Show("Please input a game title", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txtGameTitle.Focus();
				return;
            }

			grdRemoveGame.DataSource = Game.findAvailableGames(txtGameTitle.Text).Tables["game"];

			if(grdRemoveGame.Rows.Count == 1)
            {
				MessageBox.Show("No matching game found, please re-enter", "Error");
				txtGameTitle.Focus();
				return;
            }

        }
		
        private void grdRemoveGame_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
			
		}

		private void grdRemoveGame_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int ID = Convert.ToInt32(grdRemoveGame.Rows[grdRemoveGame.CurrentCell.RowIndex].Cells[0].Value.ToString());

			//aGame.get
			//INSTANTAITE aCategory
			aGame.getGame(ID);

        }

        private void txtGameTitle_TextChanged(object sender, EventArgs e)
        {
			if (txtGameTitle.Text.Length > 0)
			{
				string firstLetter = txtGameTitle.Text.Substring(0, 1).ToUpper();
				string restLetters = txtGameTitle.Text.Substring(1).ToLower();
				txtGameTitle.Text = firstLetter + restLetters;
				txtGameTitle.SelectionStart = txtGameTitle.Text.Length;
			}
		}
    }
}
