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
using GameSYS.Database_Connection;

namespace GameSYS
{
	public partial class frmUpdateGameCategory : Form
	{
		Category theCategory = new Category();
		public frmUpdateGameCategory()
		{
			InitializeComponent();
		}

		private void frmUpdateGameCategory_Load(object sender, EventArgs e)
		{
			CenterToScreen();
			//Retrieve Category Details from Categories File
			DataSet ds = Category.getCategories();
			LoadCategories();
			txtCategoryPrice.Visible = false;
			txtCategoryName.Visible = false;
			labelGameCategory.Visible = false;
			labelPrice.Visible = false;

			
			
		}
		private void btnUpdateGameCategory_Click(object sender, EventArgs e)
		{
			float priceValue;
			//Validate Data

			if (txtCategoryName.Text.Equals(""))
			{
				MessageBox.Show("Category Name must not be empty", "Invalid Category", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
				txtCategoryName.Focus();
				return;
			}
			if (float.TryParse(txtCategoryName.Text, out priceValue))
			{
				MessageBox.Show("Category Name cannot be numeric", "Invalid Category", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txtCategoryName.Focus();
				return;
			}
			if (txtCategoryPrice.Text.Equals(""))
			{
				MessageBox.Show("Price must not be empty", "Invalid Price", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
				txtCategoryPrice.Focus();
				return;
			}
			if (!float.TryParse(txtCategoryPrice.Text, out priceValue))
			{
				MessageBox.Show("Price must be numeric", "Invalid Price", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txtCategoryPrice.Focus();
				return;
			}
			//If Data is correct update it in Categories File
			theCategory.setCategoryName(txtCategoryName.Text);
			theCategory.setPrice(float.Parse(txtCategoryPrice.Text));

			//Updating data in database
			theCategory.updateCategory();

			//Display a confirmation message
			MessageBox.Show("Game Category has been updated", "Category Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

			//Reset UI
			txtCategoryName.Clear();
			txtCategoryPrice.Clear();
		}
        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
			this.Hide();
			frmMainMenu mainMenu = new frmMainMenu();
			mainMenu.Show();
        }

        private void btnPick_Click(object sender, EventArgs e)
        {
        }

        private void grdCategories_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
			int ID = Convert.ToInt32(grdCategories.Rows[grdCategories.CurrentCell.RowIndex].Cells[0].Value.ToString());

			//INSTANTAITE aCategory
			theCategory.getCategory(ID);

			txtCategoryName.Text = theCategory.getCategoryName();
			txtCategoryPrice.Text = theCategory.getPrice().ToString("##0.00");

			txtCategoryName.Visible = true;
			txtCategoryPrice.Visible = true;
			labelPrice.Visible = true;
			labelGameCategory.Visible = true;

			
        }
        private void txtPickCategory_TextChanged(object sender, EventArgs e)
        {

        }
		public void LoadCategories()
		{
			// Set up connection to Oracle database
			OracleConnection conn = new OracleConnection(DBConnect.oradb);
			conn.Open();

			// Set up SQL query to retrieve data from Categories table
			string sql = "SELECT CategoryID, CategoryName, Price FROM Categories";

			// Set up OracleDataAdapter to execute the SQL query and fill a DataSet with the results
			OracleDataAdapter adapter = new OracleDataAdapter(sql, conn);
			DataSet ds = new DataSet();
			adapter.Fill(ds, "Categories");

			// Set up DataGridView to display the data in the DataSet
			grdCategories.DataSource = ds.Tables["Categories"];

			// Close connection to Oracle database
			conn.Close();
		}

        private void txtCategoryPrice_TextChanged(object sender, EventArgs e)
        {
			if (txtCategoryPrice.Text.Length >= 2)
			{
				txtCategoryPrice.Text = txtCategoryPrice.Text.Substring(0, 1) + "." + txtCategoryPrice.Text.Substring(2);
			}

		}
	}
}
