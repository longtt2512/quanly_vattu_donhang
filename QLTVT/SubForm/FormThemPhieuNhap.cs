using System;
using System.Windows.Forms;
using QLTVT;

namespace QLTVT.SubForm
{
    public partial class FormThemPhieuNhap : Form
    {
        public string MaPhieuNhap { get; set; }
        public string MaDonDatHang { get; set; }

        public FormThemPhieuNhap()
        {
            InitializeComponent();
        }

        private void FormThemPhieuNhap_Load(object sender, EventArgs e)
        {
            txtMaPhieuNhap.Focus();
        }

        private void btnChonDonDatHang_Click(object sender, EventArgs e)
        {
            FormChonDonDatHang f = new FormChonDonDatHang();
            f.StartPosition = FormStartPosition.CenterParent;
            DialogResult result = f.ShowDialog(this);
            
            if (result == DialogResult.OK)
            {
                this.txtMaDonDatHang.Text = Program.maDonDatHangDuocChon;
                this.MaDonDatHang = Program.maDonDatHangDuocChon;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            // Validate
            if (string.IsNullOrWhiteSpace(txtMaPhieuNhap.Text))
            {
                MessageBox.Show("Vui lòng nhập mã phiếu nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaPhieuNhap.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtMaDonDatHang.Text))
            {
                MessageBox.Show("Vui lòng chọn đơn đặt hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnChonDonDatHang.Focus();
                return;
            }

            // Lưu giá trị
            this.MaPhieuNhap = txtMaPhieuNhap.Text.Trim();
            this.MaDonDatHang = txtMaDonDatHang.Text.Trim();

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
