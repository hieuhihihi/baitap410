namespace quanlysv
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            groupBox6 = new GroupBox();
            label13 = new Label();
            txtDienThoai = new TextBox();
            txtEmail = new TextBox();
            txtHoTen = new TextBox();
            txtMaSV = new TextBox();
            btnLamMoi = new Button();
            cboLop = new ComboBox();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            label8 = new Label();
            nudDiem = new NumericUpDown();
            label7 = new Label();
            radKhac = new RadioButton();
            radNu = new RadioButton();
            radNam = new RadioButton();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            dtpNgaySinh = new DateTimePicker();
            label2 = new Label();
            label1 = new Label();
            groupBox7 = new GroupBox();
            textBox3 = new TextBox();
            cboTimLop = new ComboBox();
            button5 = new Button();
            button4 = new Button();
            label11 = new Label();
            textBox2 = new TextBox();
            label10 = new Label();
            label9 = new Label();
            groupBox8 = new GroupBox();
            label12 = new Label();
            dgvSinhVien = new DataGridView();
            colMaSV = new DataGridViewTextBoxColumn();
            colHoTen = new DataGridViewTextBoxColumn();
            colNgaySinh = new DataGridViewTextBoxColumn();
            colGioiTinh = new DataGridViewTextBoxColumn();
            colEmail = new DataGridViewTextBoxColumn();
            colDienThoai = new DataGridViewTextBoxColumn();
            ColDiem = new DataGridViewTextBoxColumn();
            colLop = new DataGridViewTextBoxColumn();
            colTrangThai = new DataGridViewTextBoxColumn();
            label14 = new Label();
            groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudDiem).BeginInit();
            groupBox7.SuspendLayout();
            groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSinhVien).BeginInit();
            SuspendLayout();
            // 
            // groupBox6
            // 
            groupBox6.BackColor = Color.White;
            groupBox6.Controls.Add(label13);
            groupBox6.Controls.Add(txtDienThoai);
            groupBox6.Controls.Add(txtEmail);
            groupBox6.Controls.Add(txtHoTen);
            groupBox6.Controls.Add(txtMaSV);
            groupBox6.Controls.Add(btnLamMoi);
            groupBox6.Controls.Add(cboLop);
            groupBox6.Controls.Add(btnXoa);
            groupBox6.Controls.Add(btnSua);
            groupBox6.Controls.Add(btnThem);
            groupBox6.Controls.Add(label8);
            groupBox6.Controls.Add(nudDiem);
            groupBox6.Controls.Add(label7);
            groupBox6.Controls.Add(radKhac);
            groupBox6.Controls.Add(radNu);
            groupBox6.Controls.Add(radNam);
            groupBox6.Controls.Add(label6);
            groupBox6.Controls.Add(label5);
            groupBox6.Controls.Add(label4);
            groupBox6.Controls.Add(label3);
            groupBox6.Controls.Add(dtpNgaySinh);
            groupBox6.Controls.Add(label2);
            groupBox6.Controls.Add(label1);
            groupBox6.Location = new Point(12, 45);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(1297, 236);
            groupBox6.TabIndex = 18;
            groupBox6.TabStop = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = SystemColors.HotTrack;
            label13.Location = new Point(6, 14);
            label13.Name = "label13";
            label13.Size = new Size(270, 38);
            label13.TabIndex = 46;
            label13.Text = "Thông tin sinh viên";
            label13.Click += label13_Click;
            // 
            // txtDienThoai
            // 
            txtDienThoai.Location = new Point(112, 183);
            txtDienThoai.Name = "txtDienThoai";
            txtDienThoai.Size = new Size(239, 27);
            txtDienThoai.TabIndex = 45;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(112, 136);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(239, 27);
            txtEmail.TabIndex = 44;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(483, 56);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(198, 27);
            txtHoTen.TabIndex = 43;
            // 
            // txtMaSV
            // 
            txtMaSV.Location = new Point(101, 52);
            txtMaSV.Name = "txtMaSV";
            txtMaSV.Size = new Size(250, 27);
            txtMaSV.TabIndex = 42;
            txtMaSV.TextChanged += txtMaSV_TextChanged;
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.DarkGray;
            btnLamMoi.Location = new Point(1157, 182);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(94, 29);
            btnLamMoi.TabIndex = 41;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // cboLop
            // 
            cboLop.FormattingEnabled = true;
            cboLop.Location = new Point(862, 52);
            cboLop.Name = "cboLop";
            cboLop.Size = new Size(167, 28);
            cboLop.TabIndex = 40;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.Red;
            btnXoa.Location = new Point(1053, 181);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 39;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.Turquoise;
            btnSua.Location = new Point(948, 181);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 38;
            btnSua.Text = "Chỉnh sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.LimeGreen;
            btnThem.ForeColor = Color.Black;
            btnThem.Location = new Point(843, 180);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 37;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Navy;
            label8.Location = new Point(805, 96);
            label8.Name = "label8";
            label8.Size = new Size(46, 20);
            label8.TabIndex = 36;
            label8.Text = "Điểm";
            // 
            // nudDiem
            // 
            nudDiem.DecimalPlaces = 1;
            nudDiem.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            nudDiem.Location = new Point(862, 90);
            nudDiem.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nudDiem.Name = "nudDiem";
            nudDiem.Size = new Size(167, 27);
            nudDiem.TabIndex = 35;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Navy;
            label7.Location = new Point(805, 56);
            label7.Name = "label7";
            label7.Size = new Size(35, 20);
            label7.TabIndex = 33;
            label7.Text = "Lớp";
            // 
            // radKhac
            // 
            radKhac.AutoSize = true;
            radKhac.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radKhac.ForeColor = Color.Navy;
            radKhac.Location = new Point(607, 97);
            radKhac.Name = "radKhac";
            radKhac.Size = new Size(64, 24);
            radKhac.TabIndex = 32;
            radKhac.TabStop = true;
            radKhac.Text = "Khác";
            radKhac.UseVisualStyleBackColor = true;
            // 
            // radNu
            // 
            radNu.AutoSize = true;
            radNu.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radNu.ForeColor = Color.Navy;
            radNu.Location = new Point(551, 97);
            radNu.Name = "radNu";
            radNu.Size = new Size(52, 24);
            radNu.TabIndex = 31;
            radNu.TabStop = true;
            radNu.Text = "Nữ";
            radNu.UseVisualStyleBackColor = true;
            // 
            // radNam
            // 
            radNam.AutoSize = true;
            radNam.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radNam.ForeColor = Color.Navy;
            radNam.Location = new Point(483, 97);
            radNam.Name = "radNam";
            radNam.Size = new Size(64, 24);
            radNam.TabIndex = 30;
            radNam.TabStop = true;
            radNam.Text = "Nam";
            radNam.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Navy;
            label6.Location = new Point(412, 99);
            label6.Name = "label6";
            label6.Size = new Size(69, 20);
            label6.TabIndex = 29;
            label6.Text = "Giới tính";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Navy;
            label5.Location = new Point(32, 181);
            label5.Name = "label5";
            label5.Size = new Size(47, 20);
            label5.TabIndex = 27;
            label5.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Navy;
            label4.Location = new Point(28, 136);
            label4.Name = "label4";
            label4.Size = new Size(81, 20);
            label4.TabIndex = 26;
            label4.Text = "Điện thoại";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(404, 56);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 25;
            label3.Text = "Họ và tên";
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Location = new Point(101, 92);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(250, 27);
            dtpNgaySinh.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Navy;
            label2.Location = new Point(21, 96);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 20;
            label2.Text = "Ngày sinh";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(37, 56);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 18;
            label1.Text = "Mã SV";
            // 
            // groupBox7
            // 
            groupBox7.BackColor = Color.White;
            groupBox7.Controls.Add(textBox3);
            groupBox7.Controls.Add(cboTimLop);
            groupBox7.Controls.Add(button5);
            groupBox7.Controls.Add(button4);
            groupBox7.Controls.Add(label11);
            groupBox7.Controls.Add(textBox2);
            groupBox7.Controls.Add(label10);
            groupBox7.Controls.Add(label9);
            groupBox7.Location = new Point(13, 295);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(1296, 68);
            groupBox7.TabIndex = 19;
            groupBox7.TabStop = false;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(737, 23);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 8;
            // 
            // cboTimLop
            // 
            cboTimLop.FormattingEnabled = true;
            cboTimLop.Location = new Point(497, 22);
            cboTimLop.Name = "cboTimLop";
            cboTimLop.Size = new Size(151, 28);
            cboTimLop.TabIndex = 7;
            cboTimLop.SelectedIndexChanged += cboTimLop_SelectedIndexChanged;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ActiveBorder;
            button5.Location = new Point(1125, 24);
            button5.Name = "button5";
            button5.Size = new Size(125, 29);
            button5.TabIndex = 6;
            button5.Text = "Hiển thị tất cả";
            button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.DodgerBlue;
            button4.Location = new Point(967, 25);
            button4.Name = "button4";
            button4.Size = new Size(128, 27);
            button4.TabIndex = 5;
            button4.Text = "Tìm kiếm";
            button4.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Navy;
            label11.Location = new Point(668, 23);
            label11.Name = "label11";
            label11.Size = new Size(66, 20);
            label11.TabIndex = 4;
            label11.Text = "Điểm từ";
            label11.TextAlign = ContentAlignment.TopCenter;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.Window;
            textBox2.Location = new Point(73, 22);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(306, 27);
            textBox2.TabIndex = 2;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Navy;
            label10.Location = new Point(429, 23);
            label10.Name = "label10";
            label10.Size = new Size(64, 20);
            label10.TabIndex = 1;
            label10.Text = "Lớp học";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Navy;
            label9.Location = new Point(5, 23);
            label9.Name = "label9";
            label9.Size = new Size(66, 20);
            label9.TabIndex = 0;
            label9.Text = "Từ khoá";
            // 
            // groupBox8
            // 
            groupBox8.BackColor = Color.White;
            groupBox8.Controls.Add(label12);
            groupBox8.Controls.Add(dgvSinhVien);
            groupBox8.Location = new Point(17, 369);
            groupBox8.Name = "groupBox8";
            groupBox8.Size = new Size(1292, 308);
            groupBox8.TabIndex = 20;
            groupBox8.TabStop = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = SystemColors.HotTrack;
            label12.Location = new Point(6, 15);
            label12.Name = "label12";
            label12.Size = new Size(281, 38);
            label12.TabIndex = 1;
            label12.Text = "Danh Sách sinh viên";
            // 
            // dgvSinhVien
            // 
            dgvSinhVien.AllowUserToAddRows = false;
            dgvSinhVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSinhVien.BackgroundColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvSinhVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvSinhVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSinhVien.Columns.AddRange(new DataGridViewColumn[] { colMaSV, colHoTen, colNgaySinh, colGioiTinh, colEmail, colDienThoai, ColDiem, colLop, colTrangThai });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvSinhVien.DefaultCellStyle = dataGridViewCellStyle2;
            dgvSinhVien.GridColor = SystemColors.ControlText;
            dgvSinhVien.Location = new Point(1, 57);
            dgvSinhVien.Name = "dgvSinhVien";
            dgvSinhVien.RowHeadersVisible = false;
            dgvSinhVien.RowHeadersWidth = 51;
            dgvSinhVien.Size = new Size(1280, 239);
            dgvSinhVien.TabIndex = 0;
            dgvSinhVien.CellContentClick += dgvSinhVien_CellContentClick;
            // 
            // colMaSV
            // 
            colMaSV.DataPropertyName = "MaSV";
            colMaSV.HeaderText = "Mã SV";
            colMaSV.MinimumWidth = 6;
            colMaSV.Name = "colMaSV";
            // 
            // colHoTen
            // 
            colHoTen.DataPropertyName = "HoTen";
            colHoTen.HeaderText = "Họ và tên";
            colHoTen.MinimumWidth = 6;
            colHoTen.Name = "colHoTen";
            // 
            // colNgaySinh
            // 
            colNgaySinh.DataPropertyName = "NgaySinh";
            colNgaySinh.HeaderText = "Ngày sinh";
            colNgaySinh.MinimumWidth = 6;
            colNgaySinh.Name = "colNgaySinh";
            // 
            // colGioiTinh
            // 
            colGioiTinh.DataPropertyName = "GioiTinh";
            colGioiTinh.HeaderText = "Giới tính";
            colGioiTinh.MinimumWidth = 6;
            colGioiTinh.Name = "colGioiTinh";
            // 
            // colEmail
            // 
            colEmail.DataPropertyName = "Email";
            colEmail.HeaderText = "Email";
            colEmail.MinimumWidth = 6;
            colEmail.Name = "colEmail";
            // 
            // colDienThoai
            // 
            colDienThoai.DataPropertyName = "DienThoai";
            colDienThoai.HeaderText = "Điện thoại";
            colDienThoai.MinimumWidth = 6;
            colDienThoai.Name = "colDienThoai";
            // 
            // ColDiem
            // 
            ColDiem.DataPropertyName = "Diem";
            ColDiem.HeaderText = "Điểm";
            ColDiem.MinimumWidth = 6;
            ColDiem.Name = "ColDiem";
            // 
            // colLop
            // 
            colLop.DataPropertyName = "LopHoc";
            colLop.HeaderText = "Lớp";
            colLop.MinimumWidth = 6;
            colLop.Name = "colLop";
            // 
            // colTrangThai
            // 
            colTrangThai.DataPropertyName = "TrangThai";
            colTrangThai.HeaderText = "Trạng thái";
            colTrangThai.MinimumWidth = 6;
            colTrangThai.Name = "colTrangThai";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = SystemColors.InactiveBorder;
            label14.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = SystemColors.HotTrack;
            label14.Location = new Point(12, 9);
            label14.Name = "label14";
            label14.Size = new Size(287, 38);
            label14.TabIndex = 21;
            label14.Text = "QUẢN LÝ SINH VIÊN";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1343, 701);
            Controls.Add(label14);
            Controls.Add(groupBox8);
            Controls.Add(groupBox7);
            Controls.Add(groupBox6);
            Name = "Form1";
            Text = "Quản Lý Sinh Viên                     ";
            Load += Form1_Load;
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudDiem).EndInit();
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            groupBox8.ResumeLayout(false);
            groupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSinhVien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox6;
        private Label label8;
        private NumericUpDown nudDiem;
        private Label label7;
        private RadioButton radKhac;
        private RadioButton radNu;
        private RadioButton radNam;
        private Label label6;
        private GroupBox groupBox4;
        private Label label5;
        private GroupBox groupBox3;
        private Label label4;
        private GroupBox groupBox1;
        private Label label3;
        private DateTimePicker dtpNgaySinh;
        private Label label2;
        private Label label1;
        private Button btnSua;
        private Button btnThem;
        private Button btnXoa;
        private GroupBox groupBox7;
        private Label label9;
        private TextBox textBox2;
        private Label label10;
        private Button button4;
        private Label label11;
        private GroupBox groupBox8;
        private Button button5;
        private DataGridView dgvSinhVien;
        private Label label12;
        private ComboBox cboTimLop;
        private ComboBox cboLop;
        private DataGridViewTextBoxColumn colMaSV;
        private DataGridViewTextBoxColumn colHoTen;
        private DataGridViewTextBoxColumn colNgaySinh;
        private DataGridViewTextBoxColumn colGioiTinh;
        private DataGridViewTextBoxColumn colEmail;
        private DataGridViewTextBoxColumn colDienThoai;
        private DataGridViewTextBoxColumn ColDiem;
        private DataGridViewTextBoxColumn colLop;
        private DataGridViewTextBoxColumn colTrangThai;
        private Button btnLamMoi;
        private TextBox txtMaSV;
        private TextBox txtDienThoai;
        private TextBox txtEmail;
        private TextBox txtHoTen;
        private TextBox textBox3;
        private Label label13;
        private Label label14;
    }
}
