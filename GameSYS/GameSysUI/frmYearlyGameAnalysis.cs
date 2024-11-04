using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameSYS.Database_Connection;

namespace GameSYS
{
    public partial class frmYearlyGameAnalysis : Form
    {
        public frmYearlyGameAnalysis()
        {
            InitializeComponent();
        }
        private void frmYearlyGameAnalysis_Load(object sender, EventArgs e)
        {
            lastYears();
            
            CenterToScreen();
        }

        private void btnGameAnalysis_Click(object sender, EventArgs e)
        {
            if (cboGameYear.SelectedIndex == -1)
            {
                MessageBox.Show("Please pick a year before proceeding!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboGameYear.Focus();
                return;
            }
            String sqlQuery = "SELECT to_char(Rentals.RentalDate, 'MM') as RentalMonth, COUNT(RentalItems.GameID) as TotalRented FROM RentalItems INNER JOIN Rentals ON RentalItems.RentalID = Rentals.RentalID WHERE Rentals.RentalDate LIKE '%" + cboGameYear.Text.ToString().Substring(2,2) +"' GROUP BY to_char(Rentals.RentalDate, 'MM') ORDER BY to_date(to_char(Rentals.RentalDate, 'MM'), 'MM') ASC";
            
            DataTable dt = new DataTable();

            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(dt);
            conn.Close();

            string[] Months = new string[12];
            decimal[] Games = new decimal[12];
            //initialize arrays
            for (int i = 0; i < 12; i++)
            {
                Months[i] = getMonth(i + 1);
                Games[i] = 0;
            }

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Games[Convert.ToInt32(dt.Rows[i][0]) - 1] = Convert.ToDecimal(dt.Rows[i][1]);
            }

            chtGameData.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            chtGameData.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
            chtGameData.Series[0].LegendText = "Total Games Rented in each month";
            chtGameData.Series[0].Points.DataBindXY(Months, Games);
            chtGameData.ChartAreas["ChartArea1"].AxisX.LabelStyle.Format = "C";
            chtGameData.ChartAreas[0].AxisX.Interval = 1;
            chtGameData.Series[0].Label = "#VALY";
            chtGameData.Visible = true;
        }

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMainMenu mainMenu = new frmMainMenu();
            mainMenu.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        public String getMonth(int month)
        {
            switch (month)
            {
                case 1:
                    {
                        return "JAN";
                    }
                case 2:
                    {
                        return "FEB";
                    }
                case 3:
                    {
                        return "MAR";
                    }
                case 4:
                    {
                        return "APR";
                    }
                case 5:
                    {
                        return "MAY";
                    }
                case 6:
                    {
                        return "JUN";
                    }
                case 7:
                    {
                        return "JUL";
                    }
                case 8:
                    {
                        return "AUG";
                    }
                case 9:
                    {
                        return "SEP";
                    }
                case 10:
                    {
                        return "OCT";
                    }
                case 11:
                    {
                        return "NOV";
                    }
                case 12:
                    {
                        return "DEC";
                    }
                default: return "OTH";
            }
        }
        public void lastYears()
        {
            int year = DateTime.Now.Year;

            for (int i = 0; i < 4; i++)
            {
                cboGameYear.Items.Add(year.ToString());
                year--;
            }
        }
    }
}
