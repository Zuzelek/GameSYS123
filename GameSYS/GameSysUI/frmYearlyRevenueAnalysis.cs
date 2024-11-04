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
    public partial class frmYearlyRevenueAnalysis : Form
    {
        public frmYearlyRevenueAnalysis()
        {
            InitializeComponent();
        }

        private void labelDeRegisterMember_Click(object sender, EventArgs e)
        {

        }

        private void frmYearlyRevenueAnalysis_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            lastYears();
            
            
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
        private void btnRevenue_Click(object sender, EventArgs e)
        {
            //Validate if year was picked
            if (cboRevenueYear.SelectedIndex == -1)
            {
                MessageBox.Show("Please pick a year before proceeding!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboRevenueYear.Focus();
                return;
            }
            String sqlQuery = "SELECT to_Char(RentalDate,'MM') AS MONTH, SUM (Price) AS TOTAL FROM Rentals WHERE RentalDate LIKE '%" + cboRevenueYear.Text.ToString().Substring(2, 2) + "' GROUP BY to_Char(RentalDate, 'MM') ORDER BY MONTH";

            DataTable dt = new DataTable();

            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(dt);
            conn.Close();

            string[] Months = new string[12];
            decimal[] Amounts = new decimal[12];

            for (int i = 0; i < 12; i++)
            {
                Months[i] = getMonth(i + 1);
                Amounts[i] = 0;
            }

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Amounts[Convert.ToInt32(dt.Rows[i][0]) - 1] = Convert.ToDecimal(dt.Rows[i][1]);

            }

            chtData.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            chtData.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
            chtData.Series[0].LegendText = "Income in €";
            chtData.Series[0].Points.DataBindXY(Months, Amounts);
            chtData.ChartAreas["ChartArea1"].AxisX.LabelStyle.Format = "C";
            chtData.ChartAreas[0].AxisX.Interval = 1;
            chtData.Series[0].Label = "#VALY";
            chtData.Visible = true;

            //Reset UI
            cboRevenueYear.SelectedIndex = -1;
        }

        private void cboRevenueYear_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMainMenu mainMenu = new frmMainMenu();
            mainMenu.Show();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        public void lastYears()
        {
            int year = DateTime.Now.Year;

            for (int i = 0; i < 4; i++)
            {
                cboRevenueYear.Items.Add(year.ToString());
                year--;
            }
        }
    }
}
 
