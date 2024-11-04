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
    public partial class frmMainMenu : Form
    {
        
        frmAddGame parentGame;
        public frmMainMenu()
        {
            InitializeComponent();
        }
        public frmMainMenu(frmAddGame Parent)
        {
            InitializeComponent();
            parentGame = Parent;
        }

        private void btmShortcutRegisterMember_Click(object sender, EventArgs e)
        {
            
        }

        private void btmShortcutAddGame_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAddGame addGame = new frmAddGame();
            addGame.Show();
        }

        private void mnuRegisterMember_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRegisterMember registerMember = new frmRegisterMember();
            registerMember.Show();
        }

        private void mnuAddGame_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAddGame addGame = new frmAddGame();
            addGame.Show();
        }

        private void membersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mnuUpdateMember_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUpdateMember updateMember = new frmUpdateMember();
            updateMember.Show();
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }

        private void mnuDeRegisterMember_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDeRegisterMember deRegisterMember = new frmDeRegisterMember();
            deRegisterMember.Show();
        }

        private void mnuUpdateGameCategory_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUpdateGameCategory updateGameCategory = new frmUpdateGameCategory();
            updateGameCategory.Show();
        }

        private void mnuRemoveGame_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRemoveGame removeGame = new frmRemoveGame();
            removeGame.Show();
        }

        private void rentGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRentGame rentGame = new frmRentGame();
            rentGame.Show();
        }

        private void mnuReturnGame_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmReturnGame returnGame = new frmReturnGame();
            returnGame.Show();
        }

        private void mnuYearlyRevAnalysis_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmYearlyRevenueAnalysis yearlyRevenueAnalysis = new frmYearlyRevenueAnalysis();
            yearlyRevenueAnalysis.Show();
        }

        private void mnuYearlyGameAnalysis_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmYearlyGameAnalysis yearlyGameAnalysis = new frmYearlyGameAnalysis();
            yearlyGameAnalysis.Show();

        }
    }
}
