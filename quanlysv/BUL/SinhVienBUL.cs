using System;
using System.Collections.Generic;
using quanlysv.Data.DAL;
using quanlysv.Entity;

namespace quanlysv.BUL
{
    public class SinhVienBUL
    {
        private SinhVienDAO dal = new SinhVienDAO();

        public List<SinhVien> LayDanhSach()
        {
            try
            {
                return dal.LayDanhSach();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi tầng Business khi lấy danh sách sinh viên: " + ex.Message, ex);
            }
        }

        public void Them(SinhVien sv)
        {
            try
            {
                if (sv == null)
                    throw new ArgumentNullException(nameof(sv), "Thông tin sinh viên không được để trống!");

                if (string.IsNullOrWhiteSpace(sv.MaSV))
                    throw new ArgumentException("Mã sinh viên không được để trống!");

                if (string.IsNullOrWhiteSpace(sv.HoTen))
                    throw new ArgumentException("Họ tên sinh viên không được để trống!");

                if (sv.Diem < 0 || sv.Diem > 10)
                    throw new ArgumentException("Điểm sinh viên phải từ 0 đến 10!");

                if (sv.LopHoc == null || sv.LopHoc.Id <= 0)
                    throw new ArgumentException("Vui lòng chọn lớp học hợp lệ cho sinh viên!");

                // Kiểm tra trùng mã sinh viên
                SinhVien? existing = dal.Tim(sv.MaSV.Trim());
                if (existing != null)
                {
                    throw new InvalidOperationException($"Mã sinh viên '{sv.MaSV}' đã tồn tại trong hệ thống!");
                }

                dal.Them(sv);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi tầng Business khi thêm sinh viên: " + ex.Message, ex);
            }
        }

        public void Sua(SinhVien sv)
        {
            try
            {
                if (sv == null)
                    throw new ArgumentNullException(nameof(sv), "Thông tin sinh viên không được để trống!");

                if (string.IsNullOrWhiteSpace(sv.MaSV))
                    throw new ArgumentException("Mã sinh viên không được để trống!");

                if (string.IsNullOrWhiteSpace(sv.HoTen))
                    throw new ArgumentException("Họ tên sinh viên không được để trống!");

                if (sv.Diem < 0 || sv.Diem > 10)
                    throw new ArgumentException("Điểm sinh viên phải từ 0 đến 10!");

                if (sv.LopHoc == null || sv.LopHoc.Id <= 0)
                    throw new ArgumentException("Vui lòng chọn lớp học hợp lệ cho sinh viên!");

                // Kiểm tra xem sinh viên có tồn tại không trước khi cập nhật
                SinhVien? existing = dal.Tim(sv.MaSV.Trim());
                if (existing == null)
                {
                    throw new InvalidOperationException($"Không tìm thấy sinh viên có mã '{sv.MaSV}' để chỉnh sửa!");
                }

                dal.Sua(sv);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi tầng Business khi sửa sinh viên: " + ex.Message, ex);
            }
        }

        public void Xoa(string maSV)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(maSV))
                    throw new ArgumentException("Mã sinh viên cần xóa không được để trống!");

                SinhVien? existing = dal.Tim(maSV.Trim());
                if (existing == null)
                {
                    throw new InvalidOperationException($"Không tìm thấy sinh viên có mã '{maSV}' để xóa!");
                }

                dal.Xoa(maSV.Trim());
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi tầng Business khi xóa sinh viên: " + ex.Message, ex);
            }
        }

        public SinhVien? Tim(string maSV)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(maSV))
                    return null;

                return dal.Tim(maSV.Trim());
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi tầng Business khi tìm kiếm sinh viên: " + ex.Message, ex);
            }
        }

        public List<SinhVien> GetSinhVienTheoLop(int idLop)
        {
            try
            {
                return dal.GetSinhVienTheoLop(idLop);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi tầng Business khi lọc danh sách theo lớp: " + ex.Message, ex);
            }
        }
    }
}