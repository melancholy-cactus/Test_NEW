using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_NEW
{
    internal class Authorization
    {
        static SqlConnection sql_connection = null;
        static SqlCommand cmd_auth = null;

        static public string role, user;

        static public void auth(string login, string password)
        {
            try
            {
                SqlCommand cmd_auth = new SqlCommand(
                $"SELECT role FROM users WHERE login = '" + login + "' AND password = '" + password,
                sql_connection);
                object result = cmd_auth.ExecuteScalar();
                
                if(result != null )
                {
                    role = result.ToString();
                    user = login;
                }
                else
                {
                    role = null;
                }
            }
            catch 
            {

                role = user;
                login = null;
                MessageBox.Show("Ошибка при авторизации!");
            
            }
        }
    }
}
