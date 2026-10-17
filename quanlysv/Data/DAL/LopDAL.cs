using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using quanlysv.Entity;

namespace quanlysv.Data.DAL
{
    public class LopHocDAO
    {
        private DataHelper dataHelper = new DataHelper();

        public List<LopHoc> LayDanhSach()
        {
            try
            {
                List<LopHoc> dsLop = new List<LopHoc>();
                string sql = "SELECT Id, TenLop FROM LopHoc ORDER BY Id";
                DataTable dt = dataHelper.GetDataTable(sql);

                foreach (DataRow dr in dt.Rows)
                {
                    LopHoc lop = new LopHoc
                    {
                        Id = Convert.ToInt32(dr["Id"]),
                        TenLop = dr["TenLop"] != DBNull.Value ? dr["TenLop"].ToString()! : ""
                    };
                    dsLop.Add(lop);
                }

                return dsLop;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi DataAccess khi lấy danh sách lớp học: " + ex.Message, ex);
            }
        }

        public void Them(LopHoc lop)
        {
            try
            {
                string sql = "INSERT INTO LopHoc (Id, TenLop) VALUES (@Id, @TenLop)";
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@Id", lop.Id),
                    new SqlParameter("@TenLop", lop.TenLop)
                };
                dataHelper.ExecuteNonQuery(sql, parameters);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi DataAccess khi thêm lớp học: " + ex.Message, ex);
            }
        }

        public void Sua(LopHoc lop)
        {
            try
            {
                string sql = "UPDATE LopHoc SET TenLop = @TenLop WHERE Id = @Id";
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@Id", lop.Id),
                    new SqlParameter("@TenLop", lop.TenLop)
                };
                dataHelper.ExecuteNonQuery(sql, parameters);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi DataAccess khi sửa lớp học: " + ex.Message, ex);
            }
        }

        public void Xoa(int id)
        {
            try
            {
                string sql = "DELETE FROM LopHoc WHERE Id = @Id";
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@Id", id)
                };
                dataHelper.ExecuteNonQuery(sql, parameters);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi DataAccess khi xóa lớp học: " + ex.Message, ex);
            }
        }

        public LopHoc? Tim(int id)
        {
            try
            {
                string sql = "SELECT Id, TenLop FROM LopHoc WHERE Id = @Id";
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@Id", id)
                };
                DataTable dt = dataHelper.GetDataTable(sql, parameters);
                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    return new LopHoc
                    {
                        Id = Convert.ToInt32(dr["Id"]),
                        TenLop = dr["TenLop"] != DBNull.Value ? dr["TenLop"].ToString()! : ""
                    };
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi DataAccess khi tìm lớp học: " + ex.Message, ex);
            }
        }
    }

    // Lớp LopDAL kế thừa LopHocDAO để giữ tương thích ngược với các lời gọi cũ
    public class LopDAL : LopHocDAO
    {
    }
}