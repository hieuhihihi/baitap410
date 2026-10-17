namespace day3calculator;

partial class Form1
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
            components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        So_A = new Label();
        A = new TextBox();
        So_B = new Label();
        B = new TextBox();
        Ket_qua = new Label();
        KQ = new TextBox();
        Cong = new Button();
        Tru = new Button();
        Nhan = new Button();
        Chia = new Button();
        btnClose = new Button();
        SuspendLayout();

        // So_A
        So_A.AutoSize = true;
        So_A.Font = new Font("Segoe UI", 10F);
        So_A.Location = new Point(30, 30);
        So_A.Text = "Số A:";

        // A
        A.Font = new Font("Segoe UI", 10F);
        A.Location = new Point(100, 27);
        A.Size = new Size(180, 26);

        // So_B
        So_B.AutoSize = true;
        So_B.Font = new Font("Segoe UI", 10F);
        So_B.Location = new Point(30, 75);
        So_B.Text = "Số B:";

        // B
        B.Font = new Font("Segoe UI", 10F);
        B.Location = new Point(100, 72);
        B.Size = new Size(180, 26);

        // Ket_qua
        Ket_qua.AutoSize = true;
        Ket_qua.Font = new Font("Segoe UI", 10F);
        Ket_qua.Location = new Point(30, 120);
        Ket_qua.Text = "Kết quả:";

        // KQ
        KQ.Font = new Font("Segoe UI", 10F);
        KQ.Location = new Point(100, 117);
        KQ.Size = new Size(180, 26);
        KQ.ReadOnly = true;
        KQ.BackColor = Color.LightYellow;

        // Cong
        Cong.Font = new Font("Segoe UI", 10F);
        Cong.Location = new Point(30, 165);
        Cong.Size = new Size(60, 35);
        Cong.Text = "Cộng";
        Cong.Click += Cong_Click;

        // Tru
        Tru.Font = new Font("Segoe UI", 10F);
        Tru.Location = new Point(100, 165);
        Tru.Size = new Size(60, 35);
        Tru.Text = "Trừ";
        Tru.Click += Tru_Click;

        // Nhan
        Nhan.Font = new Font("Segoe UI", 10F);
        Nhan.Location = new Point(170, 165);
        Nhan.Size = new Size(60, 35);
        Nhan.Text = "Nhân";
        Nhan.Click += Nhan_Click;

        // Chia
        Chia.Font = new Font("Segoe UI", 10F);
        Chia.Location = new Point(240, 165);
        Chia.Size = new Size(60, 35);
        Chia.Text = "Chia";
        Chia.Click += Chia_Click;

        // btnClose
        btnClose.Font = new Font("Segoe UI", 10F);
        btnClose.Location = new Point(120, 215);
        btnClose.Size = new Size(80, 35);
        btnClose.Text = "Đóng";
        btnClose.BackColor = Color.Salmon;
        btnClose.Click += Close_Click;

        // Form1
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(330, 270);
        Controls.Add(So_A);
        Controls.Add(A);
        Controls.Add(So_B);
        Controls.Add(B);
        Controls.Add(Ket_qua);
        Controls.Add(KQ);
        Controls.Add(Cong);
        Controls.Add(Tru);
        Controls.Add(Nhan);
        Controls.Add(Chia);
        Controls.Add(btnClose);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Text = "Máy tính đơn giản";
        StartPosition = FormStartPosition.CenterScreen;
        FormClosing += Form1_FormClosing;

        ResumeLayout(false);
        PerformLayout();
    }

    private Label So_A;
    private TextBox A;
    private Label So_B;
    private TextBox B;
    private Label Ket_qua;
    private TextBox KQ;
    private Button Cong;
    private Button Tru;
    private Button Nhan;
    private Button Chia;
    private Button btnClose;
}
