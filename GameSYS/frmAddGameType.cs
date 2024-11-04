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
    public partial class frmAddGameType : Form
    {
        public frmAddGameType()
        {
            InitializeComponent();
        }

        private void frmAddGameType_Load(object sender, EventArgs e)
        {
            cboGameCategory.Items.Add("Sandbox");
            cboGameCategory.Items.Add("Multiplayer");
            cboGameCategory.Items.Add("RPG, ARPG");
            cboGameCategory.Items.Add("Simulation");
            cboGameCategory.Items.Add("Puzzlers");
            cboGameCategory.Items.Add("Action-adventure");
            cboGameCategory.Items.Add("Horror");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtGameName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btmAddGame_Click(object sender, EventArgs e)
        {
            if (txtGameTitle.Text.Equals(""))
            {
                MessageBox.Show("Game Name field can not be empty!", "Game Name is Empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtGameTitle.Focus();
                return;
            }

            if (cboGameCategory.SelectedIndex == -1)
            {
                MessageBox.Show("You need to pick a game category!", "Game Category not picked", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboGameCategory.Focus();
                return;
            }
            txtGameTitle.Clear();
            cboGameCategory.SelectedIndex = -1;       
        }

        private void labelGameCategory_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegisterMember goBack = new frmRegisterMember();
            this.Close();
            goBack.Show();
        }
    }
}
