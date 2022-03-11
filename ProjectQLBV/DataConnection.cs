using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace ProjectQLBV
{
    class DataConnection
    {
        string conStr;
        public DataConnection()
        {
            conStr = @"Data Source=DESKTOP-9R41ERD\SQLEXPRESS;Initial Catalog=PhòngKhám;Integrated Security=True";
        }
        public SqlConnection getConnect()
        {
            return new SqlConnection(conStr);
        }
    }
}
