using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DataLayer.Connection
{
    public static class DBCommon
    {
        private static string Conn = ConfigurationManager.ConnectionStrings["DALBanorteBD"].ConnectionString;

        public static IDbConnection Connection() {
            return new SqlConnection(Conn);
        }

        public static IDbCommand GetCommand(string pCommand, IDbConnection pConnection) {
            return new SqlCommand(pCommand, pConnection as SqlConnection);
        }
    }
}
