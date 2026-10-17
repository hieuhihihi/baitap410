namespace day3calculator;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private bool LayGiaTri(out double a, out double b)
    {
        a = 0; b = 0;
        if (!double.TryParse(A.Text, out a))
        {
            MessageBox.Show("Số A không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            A.Focus();
            return false;
        }
        if (!double.TryParse(B.Text, out b))
        {
            MessageBox.Show("Số B không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            B.Focus();
            return false;
        }
        return true;
    }

    private void Cong_Click(object sender, EventArgs e)
    {
        if (!LayGiaTri(out double a, out double b)) return;
        KQ.Text = (a + b).ToString();
    }

    private void Tru_Click(object sender, EventArgs e)
    {
        if (!LayGiaTri(out double a, out double b)) return;
        KQ.Text = (a - b).ToString();
    }

    private void Nhan_Click(object sender, EventArgs e)
    {
        if (!LayGiaTri(out double a, out double b)) return;
        KQ.Text = (a * b).ToString();
    }

    private void Chia_Click(object sender, EventArgs e)
    {
        if (!LayGiaTri(out double a, out double b)) return;
        if (b == 0)
        {
            MessageBox.Show("Không thể chia cho 0!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            B.Focus();
            return;
        }
        KQ.Text = (a / b).ToString();
    }

    private void Close_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
    {
        var result = MessageBox.Show("Bạn có chắc muốn thoát?", "Xác nhận",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (result == DialogResult.No)
            e.Cancel = true;
    }
}
