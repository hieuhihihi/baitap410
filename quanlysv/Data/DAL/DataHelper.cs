using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace quanlysv.Data.DAL
{
    public class DataHelper
    {
        private SqlConnection con;
        private string connectionString;

        public DataHelper(string? connStr = null)
        {
            // Mặc định kết nối tới LocalDB QLSV (hoặc cấu hình lại khi cần)
            this.connectionString = connStr ?? @"Server=(localdb)\MSSQLLocalDB;Database=QLSV;Integrated Security=True;TrustServerCertificate=True;";
            con = new SqlConnection(connectionString);
        }

        public void OpenConnection()
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi mở kết nối CSDL: " + ex.Message, ex);
            }
        }

        public void CloseConnection()
        {
            try
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi đóng kết nối CSDL: " + ex.Message, ex);
            }
        }

        public void ExecuteNonQuery(string sql, SqlParameter[]? parameters = null)
        {
            try
            {
                OpenConnection();
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    if (parameters != null && parameters.Length > 0)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi thực thi lệnh ExecuteNonQuery: " + ex.Message, ex);
            }
            finally
            {
                CloseConnection();
            }
        }

        public SqlDataReader ExecuteReader(string sql, SqlParameter[]? parameters = null)
        {
            try
            {
                OpenConnection();
                SqlCommand cmd = new SqlCommand(sql, con);
                if (parameters != null && parameters.Length > 0)
                {
                    cmd.Parameters.AddRange(parameters);
                }
                return cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception ex)
            {
                CloseConnection();
                throw new Exception("Lỗi khi thực thi ExecuteReader: " + ex.Message, ex);
            }
        }

        // Tương thích với cách viết trong bài giảng
        public SqlDataReader ExcuteReader(string sql)
        {
            return ExecuteReader(sql);
        }

        public DataTable GetDataTable(string sql, SqlParameter[]? parameters = null)
        {
            try
            {
                OpenConnection();
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    if (parameters != null && parameters.Length > 0)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy dữ liệu DataTable: " + ex.Message, ex);
            }
            finally
            {
                CloseConnection();
            }
        }

        public SqlConnection GetConnection()
        {
            return con;
        }
    }
}
