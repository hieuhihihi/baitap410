using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace quanlysv.Entity
{
    public class LopHoc
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Tên lớp không được để trống")]
        public string TenLop { get; set; }
        public override string ToString()
        {
            return TenLop;
        }
        public List<SinhVien> SinhViens { get; set; } = new List<SinhVien>();
    }
}