using System;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using GameSYS.Database_Connection;
using System.Windows.Forms;

namespace GameSYS
{
    class Category
    {
        private int categoryID;
        private string categoryName;
        private double price;

        public Category()
        {
            this.categoryID = 0;
            this.categoryName = "";
            this.price = 0;
        }

        public Category(int categoryID, string categoryName, double price)
        {
            this.categoryID = categoryID;
            this.categoryName = categoryName;
            this.price = price;
        }

        public void setCategoryID(int categoryID) => this.categoryID = categoryID;
        public void setCategoryName(string categoryName) => this.categoryName = categoryName;
        public void setPrice(double price) => this.price = price;

        public int getCategoryID() => this.categoryID;
        public string getCategoryName() => this.categoryName;
        public double getPrice() => this.price;

        public static DataSet getCategories()
        {
            using (OracleConnection conn = new OracleConnection(DBConnect.oradb))
            {
                string sqlQuery = "SELECT * FROM CATEGORIES ORDER BY CategoryID";
                using (OracleCommand cmd = new OracleCommand(sqlQuery, conn))
                {
                    OracleDataAdapter da = new OracleDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "categories");
                    return ds;
                }
            }
        }

        public static DataSet findCategories(string categoryName)
        {
            using (OracleConnection conn = new OracleConnection(DBConnect.oradb))
            {
                string sqlQuery = "SELECT * FROM Categories WHERE CategoryName LIKE :categoryName ORDER BY CategoryID";
                using (OracleCommand cmd = new OracleCommand(sqlQuery, conn))
                {
                    cmd.Parameters.Add("categoryName", OracleDbType.Varchar2).Value = "%" + categoryName + "%";
                    OracleDataAdapter da = new OracleDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "cate");
                    return ds;
                }
            }
        }

        public static DataSet getAllCategories(string categoryCode)
        {
            using (OracleConnection conn = new OracleConnection(DBConnect.oradb))
            {
                string sqlQuery = "SELECT CategoryID, CategoryName, Price FROM Categories WHERE CategoryName = :categoryCode ORDER BY CategoryName";
                using (OracleCommand cmd = new OracleCommand(sqlQuery, conn))
                {
                    cmd.Parameters.Add("categoryCode", OracleDbType.Varchar2).Value = categoryCode;
                    OracleDataAdapter da = new OracleDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Cate");
                    return ds;
                }
            }
        }

        public void getCategory(int categoryCode)
        {
            using (OracleConnection conn = new OracleConnection(DBConnect.oradb))
            {
                using (OracleCommand cmd = new OracleCommand("GetAllCategories", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Input parameter for CategoryCode
                    cmd.Parameters.Add("p_CategoryCode", OracleDbType.Varchar2).Value = categoryCode;

                    // Output parameter for the cursor
                    OracleParameter cursorParam = new OracleParameter("p_Cursor", OracleDbType.RefCursor)
                    {
                        Direction = ParameterDirection.Output
                    };
                    cmd.Parameters.Add(cursorParam);

                    conn.Open();
                    cmd.ExecuteNonQuery();

                    using (OracleDataAdapter adapter = new OracleDataAdapter(cmd))
                    {
                        DataSet categoryData = new DataSet();
                        adapter.Fill(categoryData);

                        if (categoryData.Tables.Count > 0 && categoryData.Tables[0].Rows.Count > 0)
                        {
                            DataRow row = categoryData.Tables[0].Rows[0];
                            setCategoryID(row.Field<int>("CategoryID"));
                            setCategoryName(row.Field<string>("CategoryName"));
                            setPrice(row.Field<double>("Price"));
                        }
                        else
                        {
                            MessageBox.Show("No categories found for the specified code.");
                        }
                    }
                }
            }
        }

        public void updateCategory()
        {
            using (OracleConnection conn = new OracleConnection(DBConnect.oradb))
            {
                using (OracleCommand cmd = new OracleCommand("updateCategory", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("p_CategoryID", OracleDbType.Int32).Value = this.categoryID;
                    cmd.Parameters.Add("p_CategoryName", OracleDbType.Varchar2).Value = this.categoryName;
                    cmd.Parameters.Add("p_Price", OracleDbType.Double).Value = this.price;

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
