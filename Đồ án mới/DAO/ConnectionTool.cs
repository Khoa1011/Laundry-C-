using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Đồ_án_mới.DAO
{
     class ConnectionTool
    {
        static string connectString = @"Data Source=DESKTOP-FJ21MLU\TESTDB;Initial Catalog=QLGS;Integrated Security=True";
        //static string connectString = @"Data Source=HUYLAPTOP;Initial Catalog=QLGS;Integrated Security=True";
        public static SqlConnection GetConnection()
        {
            SqlConnection con = new SqlConnection(connectString);
            return con;
        }
        
    }
}
