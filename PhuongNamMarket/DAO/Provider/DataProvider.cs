using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace DAO
{
    public class DataProvider
    {
        private System.Data.SqlClient.SqlConnection connection = null;
        private string connectionString = "Data Source=.;Initial Catalog=QLMuaBanHangDienTu;Integrated Security=True";

        public DataProvider()
        {
            this.connection = new SqlConnection(connectionString);
        }

        public void CloseConnection()
        {
            if (connection != null)
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        public DataTable GetDataTable(string tableName)
        {
            try
            {
                this.connection.Open();
                var command = this.connection.CreateCommand();
                command.CommandText = @"SELECT * FROM """ + tableName +
                    @"""";
                DataTable dt = new DataTable();
                dt.Load(command.ExecuteReader());
                return dt;
            }
            catch (Exception err)
            {
                // ghi lại thông tin lỗi err?
                err.ToString();
                return null;
            }
            finally
            {
                this.CloseConnection();
            }
        }

    }
}
