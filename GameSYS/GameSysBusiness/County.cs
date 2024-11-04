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
    class County
    {
        private String countyID;
        private String countyName;

        public County(string CountyID, string CountyName)
        {
            this.countyID = CountyID;
            this.countyName = CountyName;
        }
        public static DataSet getCounties()
        {
            //OPEN A DB CONNECTION
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //DEFINE the SQL QUERY TO BE EXECUTED
            String sqlQuery = "SELECT * FROM Counties ORDER BY CountyID";

            //Execute the SQL QUERY
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "Counties");

            //CLOSE DB CONNECTION
            conn.Close();

            return ds;

        }
    }
}
