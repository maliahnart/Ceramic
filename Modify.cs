using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Cera
{
     class Modify
    {
       public Modify() { }
        SqlCommand sqlCommand;
        SqlDataReader dataReader;
       public List<Account> Accounts(string query)
        {
            List<Account> accounts = new List<Account>();
            using (SqlConnection conn = Connection.GetSqlConnection())
            {
                conn.Open();
                sqlCommand = new SqlCommand(query, conn);
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    accounts.Add(new Account(dataReader.GetString(0), dataReader.GetString(1)));
                }
                conn.Close();

            }
                return accounts;
        }
        public void Command(string query) { 
            using (SqlConnection conn = Connection.GetSqlConnection())
            {
                conn.Open();
                sqlCommand = new SqlCommand(query, conn);
                sqlCommand.ExecuteNonQuery();
                conn.Close();
            }
        }
    }
}
