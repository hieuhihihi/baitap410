using System;
using System.ComponentModel.DataAnnotations;

namespace quanlysv.Entity
{
    public class SinhVien
    {
        [Required(ErrorMessage = "Mã sinh viên không được để trống")]
        public string MaSV { get; set; }

        [Required(ErrorMessage = "Họ tên không được để trống")]
        public string HoTen { get; set; }

        public DateTime NgaySinh { get; set; }

        public string GioiTinh { get; set; }

        [EmailAddress(ErrorMessage = "Email không hợp lệ")]
        public string Email { get; set; }

        [Phone(ErrorMessage = "Số điện thoại không hợp lệ")]
        public string DienThoai { get; set; }

        [Range(0, 10, ErrorMessage = "Điểm phải từ 0 đến 10")]
        public double Diem { get; set; }

        public string TrangThai { get; set; }

        public LopHoc LopHoc { get; set; }
    }
}