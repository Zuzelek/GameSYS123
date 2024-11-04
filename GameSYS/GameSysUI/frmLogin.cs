using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameSYS.Database_Connection;
using Oracle.ManagedDataAccess.Client;

namespace GameSYS
{
    public partial class frmLogin : Form
    {
        OracleConnection conn = new OracleConnection(DBConnect.oradb);
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            
            CenterToScreen();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
                if (!Member.validLogin(txtUsername.Text, txtPassword.Text))
                {

                    MessageBox.Show("No matching users have been found.", "Error");
                    txtUsername.Focus();
                    return;
                }


                    MessageBox.Show("Welcome Back "+txtUsername.Text);

                    this.Hide();
                    frmMainMenu mainMenu = new frmMainMenu();
                    mainMenu.Show();
           
            
            
        }
    }
}
