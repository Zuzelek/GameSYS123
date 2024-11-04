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
    public partial class frmAddGame : Form
    {
        frmAddGame parent;
        public frmAddGame()
        {
            InitializeComponent();
        }
        public frmAddGame(frmAddGame Parent)
        {
            InitializeComponent();
            parent = Parent;
        }


        private void frmAddGameType_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            //ASSIGN A GAME ID
            txtGameID.Text = Game.getNextGameID().ToString("000");

            //Retrieve Category Details from Categories File
            DataSet ds = Category.getCategories();
            
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                cboGameCategory.Items.Add(ds.Tables[0].Rows[i][0] + " - " + ds.Tables[0].Rows[i][1]);
            }
            //Retrieve Genre Details from Genre File

            DataSet dsg = Genre.getGenres();

            for(int i = 0; i < dsg.Tables[0].Rows.Count; i++)
            {
                cboGameGenre.Items.Add(dsg.Tables[0].Rows[i][0] + " - " + dsg.Tables[0].Rows[i][1]);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtGameName_TextChanged(object sender, EventArgs e)
        {
            if (txtGameTitle.Text.Length > 0)
            {
                string firstLetter = txtGameTitle.Text.Substring(0, 1).ToUpper();
                string restLetters = txtGameTitle.Text.Substring(1).ToLower();
                txtGameTitle.Text = firstLetter + restLetters;
                txtGameTitle.SelectionStart = txtGameTitle.Text.Length;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btmAddGame_Click(object sender, EventArgs e)
        {
            //Validate all fields
            if (txtGameTitle.Text.Equals(""))
            {
                MessageBox.Show("Please input a title!", "Game title is Empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtGameTitle.Focus();
                return;
            }

            if (cboGameCategory.SelectedIndex == -1)
            {
                MessageBox.Show("Please pick a Game Category!", "Game Category not picked", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboGameCategory.Focus();
                return;
            }
            if (cboGameGenre.SelectedIndex == -1)
            {
                MessageBox.Show("Please pick a game Genre!", " Game Genre not picked", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboGameGenre.Focus();
                return;
            }
            if (dtpReleaseYear.Value.Date == DateTime.Today) 
            {
                MessageBox.Show("Please pick a release date for the game!", "Release Date not picked",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }



            //CREATE AN INSTANCE OF A GAME AND INSTANTIATE WITH VALUES
            Game aGame = new Game(Convert.ToInt32(txtGameID.Text), cboGameCategory.Text.Substring(0,1), cboGameGenre.Text.Substring(0, 1), txtGameTitle.Text, dtpReleaseYear.Value.ToString("dd-MMM-yyyy"), 'A');


            //Invoke the method to add the data to the Games table
            aGame.addGame();
            
            //Display Confirmation Message
            MessageBox.Show("Game has been added to the system", "Game Added", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Reset UI
            txtGameID.Text = Game.getNextGameID().ToString("000");
            txtGameTitle.Clear();
            cboGameCategory.SelectedIndex = -1;
            cboGameGenre.SelectedIndex = -1;
            dtpReleaseYear.Value = DateTime.Today;

        }

        private void labelGameCategory_Click(object sender, EventArgs e)
        {

        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Go back to main menu
            frmMainMenu goBackMainMenu = new frmMainMenu();
            this.Hide();
            goBackMainMenu.Show();
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Go back to main Menu
            frmMainMenu goBackMainMenu = new frmMainMenu();
            this.Hide();
            goBackMainMenu.Show();
        }


        private void listBoxGames_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
