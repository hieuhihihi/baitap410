using System;
using System.Collections.Generic;
using quanlysv.Data.DAL;
using quanlysv.Entity;

namespace quanlysv.BUL
{
    public class LopBUL
    {
        private LopHocDAO dal = new LopHocDAO();

        public List<LopHoc> LayDanhSach()
        {
            try
            {
                return dal.LayDanhSach();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi tầng Business khi lấy danh sách lớp học: " + ex.Message, ex);
            }
        }

        public void Them(LopHoc lop)
        {
            try
            {
                if (lop == null)
                    throw new ArgumentNullException(nameof(lop), "Thông tin lớp học không được để trống!");

                if (lop.Id <= 0)
                    throw new ArgumentException("Mã lớp (Id) phải lớn hơn 0!");

                if (string.IsNullOrWhiteSpace(lop.TenLop))
                    throw new ArgumentException("Tên lớp không được để trống!");

                LopHoc? existing = dal.Tim(lop.Id);
                if (existing != null)
                {
                    throw new InvalidOperationException($"Lớp học có mã Id '{lop.Id}' đã tồn tại!");
                }

                dal.Them(lop);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi tầng Business khi thêm lớp học: " + ex.Message, ex);
            }
        }
    }
}