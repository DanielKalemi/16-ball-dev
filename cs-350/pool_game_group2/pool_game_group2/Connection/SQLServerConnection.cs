using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using System.Data.SqlClient;
using System.Windows.Forms;

namespace pool_game_group2.Connection
{
    class SQLServerConnection
    {
        public static string stringConnection = "Data Source=DESKTOP-O3H1CKS\\SQLCS412_SOFIA;Initial Catalog = PoolGame;Integrated Security=True";

        public static DataTable executeSQL(string sql)
        {
            //SqlCommand command;
            SqlConnection connection = new SqlConnection();
            SqlDataAdapter adapter = default(SqlDataAdapter);
            DataTable dt = new DataTable();

            try
            {
                connection.ConnectionString = stringConnection;
                connection.Open();

                adapter = new SqlDataAdapter(sql, connection);
                adapter.Fill(dt);


                connection.Close();
                connection = null;
                return dt;

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("An error occured: " + ex.Message,
                    "SQL Server Connection Failed " + MessageBoxButtons.OK);
                dt = null;
            }
            return dt;
        }
    }
}
