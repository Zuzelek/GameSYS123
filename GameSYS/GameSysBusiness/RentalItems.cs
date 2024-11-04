using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameSYS.Database_Connection;

namespace GameSYS
{
    class RentalItems
    {
        private int rentalID;
        private int gameID;

        public RentalItems()
        {
            this.rentalID = 0;
            this.gameID = 0;
        }
        
        public RentalItems(int RentalID, int GameID)
        {
            this.rentalID = RentalID;
            this.gameID = GameID;
        }
        public void setRentalID(int RentalID)
        {
            this.rentalID = RentalID;
        }
        public void setGameID(int GameID)
        {
            this.gameID = GameID;
        }
        public int getRentalID()
        {
            return rentalID;
        }
        public int getGameID()
        {
            return gameID;
        }
        public void rentGames()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "INSERT INTO RentalItems VALUES(" +
                    this.rentalID + "," +
                    this.gameID + ")";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            conn.Open();

            cmd.ExecuteNonQuery();

            conn.Close();


        }
    }
}
