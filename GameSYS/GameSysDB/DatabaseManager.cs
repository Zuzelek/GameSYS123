using Oracle.ManagedDataAccess.Client;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Data;

namespace GameSYS.GameSysDB
{
    internal class DatabaseManager
    {
        private string connectionString;

        public DatabaseManager(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public OracleConnection GetConnection()
        {
            return new OracleConnection(this.connectionString);
        }

        public DataSet ExecuteQuery(string sql)
        {
            using (var conn = GetConnection())
            {
                OracleCommand cmd = new OracleCommand(sql, conn);
                OracleDataAdapter da = new OracleDataAdapter(cmd);

                DataSet ds = new DataSet();
                conn.Open();
                da.Fill(ds);

                return ds;
            }
        }

        public void ExecuteNonQuery(string sql)
        {
            using (var conn = GetConnection())
            {
                OracleCommand cmd = new OracleCommand(sql, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
