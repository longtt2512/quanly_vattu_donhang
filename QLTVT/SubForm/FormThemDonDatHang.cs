using System;
using System.Windows.Forms;

namespace QLTVT.SubForm
{
    public partial class FormThemDonDatHang : Form
    {
        public string MaDonDatHang { get; set; }
        public string MaKho { get; set; }
        public string NhaCungCap { get; set; }

        public FormThemDonDatHang()
        {
            InitializeComponent();
        }

        private void FormThemDonDatHang_Load(object sender, EventArgs e)
        {
            txtMaDonDatHang.Focus();
        }

        private void btnChonKho_Click(object sender, EventArgs e)
        {
            FormChonKhoHang f = new FormChonKhoHang();
            f.StartPosition = FormStartPosition.CenterParent;
            DialogResult result = f.ShowDialog(this);
            
            if (result == DialogResult.OK)
            {
                this.txtTenKho.Text = Program.tenKhoDuocChon; // Hiển thị tên kho
                this.txtMaKho.Text = Program.maKhoDuocChon;   // Hidden field lưu mã kho
                this.MaKho = Program.maKhoDuocChon;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            // Validate
            if (string.IsNullOrWhiteSpace(txtMaDonDatHang.Text))
            {
                MessageBox.Show("Vui lòng nhập mã đơn đặt hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaDonDatHang.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtTenKho.Text))
            {
                MessageBox.Show("Vui lòng chọn kho hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnChonKho.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNhaCungCap.Text))
            {
                MessageBox.Show("Vui lòng nhập nhà cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNhaCungCap.Focus();
                return;
            }

            // Lưu giá trị
            this.MaDonDatHang = txtMaDonDatHang.Text.Trim();
            this.MaKho = txtMaKho.Text.Trim();
            this.NhaCungCap = txtNhaCungCap.Text.Trim();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
