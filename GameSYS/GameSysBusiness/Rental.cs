using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameSYS.Database_Connection;
using Oracle.ManagedDataAccess.Client;

namespace GameSYS
{
    class Rental
    {
        private int rentalID;
        private int memberID;
        private String rentalDate;
        private String returnDate;
        private double price;

        public Rental()
        {
            this.rentalID = 0;
            this.memberID = 0;
            this.rentalDate = "";
            this.returnDate = "";
            this.price = 0;
        }
        public Rental(int RentalID, int MemberID, String RentalDate, String ReturnDate, double Price)
        {
            this.rentalID = RentalID;
            this.memberID = MemberID;
            this.rentalDate = RentalDate;
            this.returnDate = ReturnDate;
            this.price = Price;
        }
        public void setRentalID(int RentalID)
        {
            this.rentalID = RentalID;
        }
        public void setMemberID(int MemberID)
        {
            this.memberID = MemberID;
        }
        public void setRentalDate(String RentalDate)
        {
            this.rentalDate = RentalDate;
        }
        public void setReturnDate(String ReturnDate)
        {
            this.returnDate = ReturnDate;
        }
        public void setPrice(double Price)
        {
            this.price = Price;
        }
        public int getRentalID()
        {
            return rentalID;
        }
        public int getMemberID()
        {
            return memberID;
        }
        public String getRentalDate()
        {
            return rentalDate;
        }
        public String getReturnDate()
        {
            return returnDate;
        }
        public static int getNextRentalID()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            
            String sqlQuery = "SELECT MAX(RentalID) FROM Rentals";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            conn.Open();
            OracleDataReader dr = cmd.ExecuteReader();

            int nextRentID;
            dr.Read();

            if (dr.IsDBNull(0))
                nextRentID = 1;
            else
            {
                nextRentID = dr.GetInt32(0) + 1;
            }

            conn.Close();

            return nextRentID;
        }
        public void rentAGame()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "INSERT INTO Rentals Values (" +
                this.rentalID + "," +
                this.memberID + ",'" +
                this.rentalDate + "','" +
                this.returnDate + "'," +
                this.price + ")";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            conn.Open();

            cmd.ExecuteNonQuery();

            conn.Close();
                
        }
        
        
        public void returnGame(int Id)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "UPDATE Games SET Status = 'A' WHERE GameID = " + Id;

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            conn.Open();

            cmd.ExecuteNonQuery();

            conn.Close();
        }
        public static DataSet revenueAnalysis()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "SELECT to_Char(RentalDate,'MM') AS MONTH, SUM (Price) AS TOTAL FROM Rentals WHERE RentalDate LIKE '%23' GROUP BY to_Char(RentalDate, 'MM') ORDER BY MONTH";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();

            da.Fill(ds, "Rev");

            conn.Close();

            return ds;
        }
    }
}
