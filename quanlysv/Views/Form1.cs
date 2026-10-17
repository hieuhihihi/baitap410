using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using quanlysv.BUL;
using quanlysv.Entity;

namespace quanlysv
{
    public partial class Form1 : Form
    {
        private LopBUL lopBUL = new LopBUL();
        private SinhVienBUL sinhVienBUL = new SinhVienBUL();

        public Form1()
        {
            InitializeComponent();
            dgvSinhVien.AutoGenerateColumns = false;
        }

        private void LoadDanhSachSinhVien()
        {
            dgvSinhVien.DataSource = null;
            dgvSinhVien.DataSource = sinhVienBUL.LayDanhSach();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                var dsLop = lopBUL.LayDanhSach();
                cboLop.DataSource = new List<LopHoc>(dsLop);
                cboLop.DisplayMember = "TenLop";
                cboLop.ValueMember = "Id";

                cboTimLop.DataSource = new List<LopHoc>(dsLop);
                cboTimLop.DisplayMember = "TenLop";
                cboTimLop.ValueMember = "Id";

                LoadDanhSachSinhVien();

                dgvSinhVien.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;
                dgvSinhVien.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu ban đầu: " + ex.Message, "Lỗi kết nối / dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtMaSV_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string maSV = txtMaSV.Text.Trim();
                if (string.IsNullOrEmpty(maSV))
                {
                    ResetThongTinNhap();
                    return;
                }

                SinhVien? sv = sinhVienBUL.Tim(maSV);

                if (sv != null)
                {
                    txtHoTen.Text = sv.HoTen;
                    dtpNgaySinh.Value = sv.NgaySinh > dtpNgaySinh.MinDate && sv.NgaySinh < dtpNgaySinh.MaxDate 
                                        ? sv.NgaySinh 
                                        : DateTime.Now;

                    radNam.Checked = sv.GioiTinh == "Nam";
                    radNu.Checked = sv.GioiTinh == "Nữ";
                    radKhac.Checked = sv.GioiTinh != "Nam" && sv.GioiTinh != "Nữ";

                    txtEmail.Text = sv.Email;
                    txtDienThoai.Text = sv.DienThoai;

                    nudDiem.Value = (decimal)Math.Clamp(sv.Diem, 0, 10);

                    if (sv.LopHoc != null)
                    {
                        cboLop.SelectedValue = sv.LopHoc.Id;
                    }

                    btnThem.Enabled = false;
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                }
                else
                {
                    ResetThongTinNhap();
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ tầng View khi tìm kiếm
                MessageBox.Show("Lỗi khi tìm kiếm sinh viên: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ResetThongTinNhap()
        {
            txtHoTen.Clear();
            txtEmail.Clear();
            txtDienThoai.Clear();

            dtpNgaySinh.Value = DateTime.Now;

            radNam.Checked = false;
            radNu.Checked = false;
            radKhac.Checked = false;

            nudDiem.Value = 0;

            if (cboLop.Items.Count > 0)
                cboLop.SelectedIndex = 0;

            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            try
            {
                txtMaSV.Clear();
                ResetThongTinNhap();
                LoadDanhSachSinhVien();
                txtMaSV.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi làm mới: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                SinhVien sv = new SinhVien();

                sv.MaSV = txtMaSV.Text.Trim();
                sv.HoTen = txtHoTen.Text.Trim();
                sv.NgaySinh = dtpNgaySinh.Value;

                if (radNam.Checked)
                    sv.GioiTinh = "Nam";
                else if (radNu.Checked)
                    sv.GioiTinh = "Nữ";
                else
                    sv.GioiTinh = "Khác";

                sv.Email = txtEmail.Text.Trim();
                sv.DienThoai = txtDienThoai.Text.Trim();
                sv.Diem = (double)nudDiem.Value;
                sv.TrangThai = "Đang học";
                sv.LopHoc = (LopHoc)cboLop.SelectedItem!;

                sinhVienBUL.Them(sv);

                LoadDanhSachSinhVien();
                MessageBox.Show("Thêm sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnLamMoi.PerformClick();
            }
            catch (Exception ex)
            {
                // Tầng View bắt và xử lý ngoại lệ từ Business/DAL
                MessageBox.Show("Thêm sinh viên thất bại: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string maSV = txtMaSV.Text.Trim();
                if (string.IsNullOrEmpty(maSV))
                {
                    MessageBox.Show("Vui lòng nhập hoặc chọn mã sinh viên cần xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult result = MessageBox.Show(
                    $"Bạn có chắc chắn muốn xóa sinh viên '{maSV}' không?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    sinhVienBUL.Xoa(maSV);
                    LoadDanhSachSinhVien();
                    btnLamMoi.PerformClick();
                    MessageBox.Show("Xóa sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // Tầng View bắt và xử lý ngoại lệ từ Business/DAL
                MessageBox.Show("Xóa sinh viên thất bại: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                SinhVien sv = new SinhVien();

                sv.MaSV = txtMaSV.Text.Trim();
                sv.HoTen = txtHoTen.Text.Trim();
                sv.NgaySinh = dtpNgaySinh.Value;

                if (radNam.Checked)
                    sv.GioiTinh = "Nam";
                else if (radNu.Checked)
                    sv.GioiTinh = "Nữ";
                else
                    sv.GioiTinh = "Khác";

                sv.Email = txtEmail.Text.Trim();
                sv.DienThoai = txtDienThoai.Text.Trim();
                sv.Diem = (double)nudDiem.Value;
                sv.TrangThai = "Đang học";
                sv.LopHoc = (LopHoc)cboLop.SelectedItem!;

                sinhVienBUL.Sua(sv);

                LoadDanhSachSinhVien();
                MessageBox.Show("Cập nhật sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Tầng View bắt và xử lý ngoại lệ từ Business/DAL
                MessageBox.Show("Cập nhật sinh viên thất bại: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvSinhVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvSinhVien.Rows[e.RowIndex].DataBoundItem is SinhVien sv)
            {
                txtMaSV.Text = sv.MaSV;
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {
        }

        private void cboTimLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboTimLop.SelectedItem == null)
                    return;

                LopHoc lop = (LopHoc)cboTimLop.SelectedItem;
                dgvSinhVien.DataSource = null;
                dgvSinhVien.DataSource = sinhVienBUL.GetSinhVienTheoLop(lop.Id);
            }
            catch (Exception ex)
            {
                // Tầng View bắt và xử lý ngoại lệ từ Business/DAL
                MessageBox.Show("Lỗi khi lọc sinh viên theo lớp: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}