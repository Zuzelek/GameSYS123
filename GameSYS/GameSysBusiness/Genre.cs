using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using GameSYS.Database_Connection;
using Oracle.ManagedDataAccess.Client;
namespace GameSYS
{
    class Genre
    {
        int genreID;
        String genreName;

        public Genre(int GenreID, string GenreName)
            {
                this.genreID = GenreID;
                this.genreName = GenreName;
            }
    
        public static DataSet getGenres()
        {
            //OPEN A DB CONNECTION
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //DEFINE THE SQL QUERY
            String sqlQuery = "SELECT * FROM Genres ORDER BY GenreID";

            //EXECUTE THE SQL QUERY
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "genres");

            //CLOSE DB CONNECTION
            conn.Close();

            return ds;
        }
    }
}
