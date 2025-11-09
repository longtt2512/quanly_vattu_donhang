using System;
using System.Windows.Forms;

namespace QLTVT.SubForm
{
    public partial class FormThemChiTietPhieuNhap : Form
    {
        public string MaVatTu { get; set; }
        public int SoLuong { get; set; }
        public decimal DonGia { get; set; }
        public string MaDonDatHangPhieuNhap { get; set; } // Mã đơn hàng của phiếu nhập hiện tại

        public FormThemChiTietPhieuNhap()
        {
            InitializeComponent();
        }

        private void FormThemChiTietPhieuNhap_Load(object sender, EventArgs e)
        {
            numSoLuong.Value = 1;
            numDonGia.Value = 1000;
            
            // Set mã đơn hàng để FormChonChiTietDonHang có thể validate
            if (!string.IsNullOrEmpty(MaDonDatHangPhieuNhap))
            {
                Program.maDonDatHangDuocChon = MaDonDatHangPhieuNhap.Trim();
            }
        }

        private void btnChonChiTietDonHang_Click(object sender, EventArgs e)
        {
            FormChonChiTietDonHang f = new FormChonChiTietDonHang();
            f.StartPosition = FormStartPosition.CenterParent;
            DialogResult result = f.ShowDialog(this);
            
            if (result == DialogResult.OK)
            {
                this.txtMaVatTu.Text = Program.maVatTuDuocChon;
                this.MaVatTu = Program.maVatTuDuocChon;
                
                // Tự động điền số lượng và đơn giá từ chi tiết đơn hàng
                if (Program.soLuongVatTu > 0)
                {
                    numSoLuong.Value = Program.soLuongVatTu;
                    this.SoLuong = Program.soLuongVatTu;
                }
                
                if (Program.donGia > 0)
                {
                    numDonGia.Value = Program.donGia;
                    this.DonGia = Program.donGia;
                }
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            // Validate
            if (string.IsNullOrWhiteSpace(txtMaVatTu.Text))
            {
                MessageBox.Show("Vui lòng chọn chi tiết đơn hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnChonChiTietDonHang.Focus();
                return;
            }

            if (numSoLuong.Value < 1)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numSoLuong.Focus();
                return;
            }

            if (numDonGia.Value < 1)
            {
                MessageBox.Show("Đơn giá phải lớn hơn 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numDonGia.Focus();
                return;
            }

            // Lưu giá trị
            this.MaVatTu = txtMaVatTu.Text.Trim();
            this.SoLuong = (int)numSoLuong.Value;
            this.DonGia = numDonGia.Value;

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
