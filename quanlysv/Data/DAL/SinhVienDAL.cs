using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using quanlysv.Entity;

namespace quanlysv.Data.DAL
{
    public class SinhVienDAO
    {
        private DataHelper dataHelper = new DataHelper();

        private SinhVien MapRowToSinhVien(DataRow dr)
        {
            SinhVien sv = new SinhVien();
            sv.MaSV = dr["MaSV"] != DBNull.Value ? dr["MaSV"].ToString()! : "";
            sv.HoTen = dr["HoTen"] != DBNull.Value ? dr["HoTen"].ToString()! : "";
            sv.NgaySinh = dr["NgaySinh"] != DBNull.Value ? Convert.ToDateTime(dr["NgaySinh"]) : DateTime.MinValue;
            sv.GioiTinh = dr["GioiTinh"] != DBNull.Value ? dr["GioiTinh"].ToString()! : "";
            sv.Email = dr["Email"] != DBNull.Value ? dr["Email"].ToString()! : "";
            
            // Xử lý cột DienThoai hoặc SoDienThoai
            if (dr.Table.Columns.Contains("DienThoai") && dr["DienThoai"] != DBNull.Value)
            {
                sv.DienThoai = dr["DienThoai"].ToString()!;
            }
            else if (dr.Table.Columns.Contains("SoDienThoai") && dr["SoDienThoai"] != DBNull.Value)
            {
                sv.DienThoai = dr["SoDienThoai"].ToString()!;
            }
            else
            {
                sv.DienThoai = "";
            }

            sv.Diem = dr["Diem"] != DBNull.Value ? Convert.ToDouble(dr["Diem"]) : 0.0;
            sv.TrangThai = dr.Table.Columns.Contains("TrangThai") && dr["TrangThai"] != DBNull.Value 
                           ? dr["TrangThai"].ToString()! 
                           : "Đang học";

            int maLop = 0;
            if (dr.Table.Columns.Contains("MaLop") && dr["MaLop"] != DBNull.Value)
            {
                maLop = Convert.ToInt32(dr["MaLop"]);
            }
            string tenLop = dr.Table.Columns.Contains("TenLop") && dr["TenLop"] != DBNull.Value 
                            ? dr["TenLop"].ToString()! 
                            : "";

            sv.LopHoc = new LopHoc
            {
                Id = maLop,
                TenLop = tenLop
            };

            return sv;
        }

        public List<SinhVien> LayDanhSach()
        {
            try
            {
                List<SinhVien> list = new List<SinhVien>();
                string sql = @"SELECT sv.MaSV, sv.HoTen, sv.NgaySinh, sv.GioiTinh, sv.Email, 
                                      COALESCE(sv.DienThoai, sv.SoDienThoai) AS DienThoai, 
                                      sv.Diem, sv.TrangThai, sv.MaLop, 
                                      l.TenLop 
                               FROM SinhVien sv 
                               LEFT JOIN LopHoc l ON sv.MaLop = l.Id 
                               ORDER BY sv.MaSV";
                DataTable dt = dataHelper.GetDataTable(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    list.Add(MapRowToSinhVien(dr));
                }
                return list;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi DataAccess khi lấy danh sách sinh viên: " + ex.Message, ex);
            }
        }

        public List<SinhVien> GetAllSinhVien()
        {
            return LayDanhSach();
        }

        public void Them(SinhVien sv)
        {
            try
            {
                string sql = @"INSERT INTO SinhVien (MaSV, HoTen, NgaySinh, GioiTinh, Email, DienThoai, SoDienThoai, Diem, TrangThai, MaLop) 
                               VALUES (@MaSV, @HoTen, @NgaySinh, @GioiTinh, @Email, @DienThoai, @SoDienThoai, @Diem, @TrangThai, @MaLop)";
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@MaSV", sv.MaSV ?? ""),
                    new SqlParameter("@HoTen", sv.HoTen ?? ""),
                    new SqlParameter("@NgaySinh", sv.NgaySinh),
                    new SqlParameter("@GioiTinh", (object?)sv.GioiTinh ?? DBNull.Value),
                    new SqlParameter("@Email", (object?)sv.Email ?? DBNull.Value),
                    new SqlParameter("@DienThoai", (object?)sv.DienThoai ?? DBNull.Value),
                    new SqlParameter("@SoDienThoai", (object?)sv.DienThoai ?? DBNull.Value),
                    new SqlParameter("@Diem", sv.Diem),
                    new SqlParameter("@TrangThai", (object?)sv.TrangThai ?? "Đang học"),
                    new SqlParameter("@MaLop", sv.LopHoc != null ? sv.LopHoc.Id : DBNull.Value)
                };
                dataHelper.ExecuteNonQuery(sql, parameters);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi DataAccess khi thêm sinh viên: " + ex.Message, ex);
            }
        }

        public void AddSinhVien(SinhVien sv)
        {
            Them(sv);
        }

        public void Sua(SinhVien sv)
        {
            try
            {
                string sql = @"UPDATE SinhVien 
                               SET HoTen = @HoTen, NgaySinh = @NgaySinh, GioiTinh = @GioiTinh, 
                                   Email = @Email, DienThoai = @DienThoai, SoDienThoai = @SoDienThoai, 
                                   Diem = @Diem, TrangThai = @TrangThai, MaLop = @MaLop 
                               WHERE MaSV = @MaSV";
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@MaSV", sv.MaSV ?? ""),
                    new SqlParameter("@HoTen", sv.HoTen ?? ""),
                    new SqlParameter("@NgaySinh", sv.NgaySinh),
                    new SqlParameter("@GioiTinh", (object?)sv.GioiTinh ?? DBNull.Value),
                    new SqlParameter("@Email", (object?)sv.Email ?? DBNull.Value),
                    new SqlParameter("@DienThoai", (object?)sv.DienThoai ?? DBNull.Value),
                    new SqlParameter("@SoDienThoai", (object?)sv.DienThoai ?? DBNull.Value),
                    new SqlParameter("@Diem", sv.Diem),
                    new SqlParameter("@TrangThai", (object?)sv.TrangThai ?? "Đang học"),
                    new SqlParameter("@MaLop", sv.LopHoc != null ? sv.LopHoc.Id : DBNull.Value)
                };
                dataHelper.ExecuteNonQuery(sql, parameters);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi DataAccess khi sửa sinh viên: " + ex.Message, ex);
            }
        }

        public void UpdateSinhVien(SinhVien sv)
        {
            Sua(sv);
        }

        public void Xoa(string maSV)
        {
            try
            {
                string sql = "DELETE FROM SinhVien WHERE MaSV = @MaSV";
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@MaSV", maSV)
                };
                dataHelper.ExecuteNonQuery(sql, parameters);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi DataAccess khi xóa sinh viên: " + ex.Message, ex);
            }
        }

        public void DeleteSinhVien(string maSV)
        {
            Xoa(maSV);
        }

        public SinhVien? Tim(string maSV)
        {
            try
            {
                string sql = @"SELECT sv.MaSV, sv.HoTen, sv.NgaySinh, sv.GioiTinh, sv.Email, 
                                      COALESCE(sv.DienThoai, sv.SoDienThoai) AS DienThoai, 
                                      sv.Diem, sv.TrangThai, sv.MaLop, 
                                      l.TenLop 
                               FROM SinhVien sv 
                               LEFT JOIN LopHoc l ON sv.MaLop = l.Id 
                               WHERE sv.MaSV = @MaSV";
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@MaSV", maSV)
                };
                DataTable dt = dataHelper.GetDataTable(sql, parameters);
                if (dt.Rows.Count > 0)
                {
                    return MapRowToSinhVien(dt.Rows[0]);
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi DataAccess khi tìm sinh viên: " + ex.Message, ex);
            }
        }

        public SinhVien? GetSinhVienById(string maSV)
        {
            return Tim(maSV);
        }

        public SinhVien? GetSinhVienByMaSV(string maSV)
        {
            return Tim(maSV);
        }

        public List<SinhVien> GetSinhVienTheoLop(int idLop)
        {
            try
            {
                List<SinhVien> list = new List<SinhVien>();
                string sql = @"SELECT sv.MaSV, sv.HoTen, sv.NgaySinh, sv.GioiTinh, sv.Email, 
                                      COALESCE(sv.DienThoai, sv.SoDienThoai) AS DienThoai, 
                                      sv.Diem, sv.TrangThai, sv.MaLop, 
                                      l.TenLop 
                               FROM SinhVien sv 
                               LEFT JOIN LopHoc l ON sv.MaLop = l.Id 
                               WHERE sv.MaLop = @MaLop 
                               ORDER BY sv.MaSV";
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@MaLop", idLop)
                };
                DataTable dt = dataHelper.GetDataTable(sql, parameters);
                foreach (DataRow dr in dt.Rows)
                {
                    list.Add(MapRowToSinhVien(dr));
                }
                return list;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi DataAccess khi lọc sinh viên theo lớp: " + ex.Message, ex);
            }
        }

        public List<SinhVien> GetSinhViensByMaLop(string maLop)
        {
            if (int.TryParse(maLop, out int idLop))
            {
                return GetSinhVienTheoLop(idLop);
            }
            return new List<SinhVien>();
        }
    }

    // Lớp SinhVienDAL kế thừa SinhVienDAO để tương thích ngược
    public class SinhVienDAL : SinhVienDAO
    {
    }
}