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

        /// <summary>
        /// Lấy bảng dữ liệu
        /// </summary>
        /// <returns></returns>
        public DataTable GetTable(string query)
        {
            try
            {
                this.connection.Open();
                var command = this.connection.CreateCommand();
                command.CommandText = query;
                var adapter = new SqlDataAdapter(command);

                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
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

        /// <summary>
        /// Them, xoa, sua
        /// </summary>
        /// <returns></returns>
        public bool ExecuteUpdateQuery(string query) 
        {
            try
            {
                this.connection.Open();
                var cm = new SqlCommand(query, connection);
                cm.CommandType = CommandType.Text;
                cm.ExecuteNonQuery();
                return true;
            }
            catch (Exception err)
            {
                // ghi lại thông tin lỗi err?
                err.ToString();
                return false;
            }
            finally
            {
                this.CloseConnection();
            }
        }

    }
}
