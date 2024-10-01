using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Cera
{
     class Connection
    {
        private static string stringConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\Test\Cera\Cera.mdf;Integrated Security=True";
        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(stringConnection);
        }
    }
}
