using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Data;
using GameSYS.Database_Connection;

namespace GameSYS
{
    class Game
    {
        private int gameID;
        private String categoryID;
        private String genreID;
        private String title;
        private String year;
        private char status;


        public Game()
        {
            this.gameID = 0;
            this.categoryID = "";
            this.genreID = "";
            this.title = "";
            this.year = "";
            this.status = 'A';
        }

        public Game(int gameID, string categoryID, string GenreID, string title, string year, char status)
        {
            this.gameID = gameID;
            this.categoryID = categoryID;
            this.genreID = GenreID;
            this.title = title;
            this.year = year;
            this.status = status;
        }

        //getters
        public int getGameID() { return this.gameID; }

        public String getCategoryID()
        {
            return this.categoryID;
        }
        public String getTitle() { return this.title; }
        public String getYear() { return this.year; }
        public char getStatus() { return this.status; }
        public String getGenreID()
        {
            return this.genreID;
        }
        //setters
        public void setGameID(int GameID) { gameID = GameID; }
        public void setCategoryID(String CategoryID){ this.categoryID = CategoryID; }
        public void setGenreID(String GenreID) { this.genreID = GenreID; }
        public void setTitle(String Title) { this.title = Title; }
        public void setYear(String Year) { this.year = Year; }
        public void setStatus(String Status) { this.status = Status[0]; }
        public void addGame()
        {
            using (OracleConnection conn = new OracleConnection(DBConnect.oradb))
            {
                OracleCommand cmd = new OracleCommand("AddGame", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("p_gameID", OracleDbType.Int32).Value = this.gameID;
                cmd.Parameters.Add("p_categoryID", OracleDbType.Varchar2).Value = this.categoryID;
                cmd.Parameters.Add("p_genreID", OracleDbType.Varchar2).Value = this.genreID;
                cmd.Parameters.Add("p_title", OracleDbType.Varchar2).Value = this.title;
                cmd.Parameters.Add("p_year", OracleDbType.Varchar2).Value = this.year;
                cmd.Parameters.Add("p_status", OracleDbType.Char).Value = this.status;

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public static int getNextGameID()
        {
            //OPEN A DB CONNECTION
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            int nextId = 1; // Default to 1

            try
            {
                //DEFINE THE SQL QUERY
                String sqlQuery = "SELECT MAX(GameID) FROM Games";

                OracleCommand cmd = new OracleCommand(sqlQuery, conn);
                conn.Open();

                OracleDataReader dr = cmd.ExecuteReader();

                // Check if there is a result
                if (dr.Read())
                {
                    if (!dr.IsDBNull(0))
                    {
                        nextId = dr.GetInt32(0) + 1;
                    }
                }
            }
            catch (Exception ex)
            {
                // Log or handle exception
                Console.WriteLine(ex.Message);
            }
            finally
            {
                //CLOSE DB CONNECTION
                conn.Close();
            }

            return nextId;
        }
        public static DataSet findAvailableGames(string gameName)
        {
            DataSet ds = new DataSet();
            using (OracleConnection conn = new OracleConnection(DBConnect.oradb))
            {
                OracleCommand cmd = new OracleCommand("FindAvailableGames", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("p_gameName", OracleDbType.Varchar2).Value = gameName;

                OracleParameter outputParam = new OracleParameter("p_result", OracleDbType.RefCursor);
                outputParam.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(outputParam);

                conn.Open();

                cmd.ExecuteNonQuery();

                using (OracleDataAdapter da = new OracleDataAdapter(cmd))
                {
                    da.Fill(ds, "game");
                }
            }
            return ds;
        }
        public static DataSet findRentedGames(string gameTitle)
        {
            DataSet ds = new DataSet();
            using (OracleConnection conn = new OracleConnection(DBConnect.oradb))
            {
                OracleCommand cmd = new OracleCommand("FindRentedGames", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("p_gameTitle", OracleDbType.Varchar2).Value = gameTitle;

                OracleParameter outputParam = new OracleParameter("p_result", OracleDbType.RefCursor);
                outputParam.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(outputParam);

                conn.Open();
                cmd.ExecuteNonQuery();

                using (OracleDataAdapter da = new OracleDataAdapter(cmd))
                {
                    da.Fill(ds, "game");
                }
            }
            return ds;
        }
        public void updateGameStatus(int id)
        {
            using (OracleConnection conn = new OracleConnection(DBConnect.oradb))
            {
                OracleCommand cmd = new OracleCommand("UpdateGameStatus", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("p_gameID", OracleDbType.Int32).Value = id;
                cmd.Parameters.Add("p_newStatus", OracleDbType.Char).Value = 'U';

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void getGame(int id)
        {
            using (OracleConnection conn = new OracleConnection(DBConnect.oradb))
            {
                OracleCommand cmd = new OracleCommand("GetGame", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("p_gameID", OracleDbType.Int32).Value = id;

                // Define output parameters
                cmd.Parameters.Add("p_title", OracleDbType.Varchar2, 100).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("p_year", OracleDbType.Varchar2, 4).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("p_status", OracleDbType.Char).Direction = ParameterDirection.Output;

                conn.Open();
                cmd.ExecuteNonQuery();

                setTitle(cmd.Parameters["p_title"].Value.ToString());
                setYear(cmd.Parameters["p_year"].Value.ToString());

                // Make sure to handle the case where "p_status" might be null or empty
                if (cmd.Parameters["p_status"].Value != DBNull.Value)
                {
                    setStatus(cmd.Parameters["p_status"].Value.ToString());
                }
                else
                {
                    // Optionally handle the case for status
                    throw new InvalidOperationException("Game status is not defined in the database.");
                }
            }
        }


    }
}
