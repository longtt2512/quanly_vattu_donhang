using System;
using System.Windows.Forms;

namespace QLTVT.SubForm
{
    public partial class FormThemPhieuXuat : Form
    {
        public string MaPhieuXuat { get; set; }
        public string MaKho { get; set; }
        public DateTime NgayXuat { get; set; }
        public string TenKhachHang { get; set; }

        public FormThemPhieuXuat()
        {
            InitializeComponent();
        }

        private void FormThemPhieuXuat_Load(object sender, EventArgs e)
        {
            txtMaPhieuXuat.Focus();
            dteNgay.DateTime = DateTime.Now;
        }

        private void btnCHON_Click(object sender, EventArgs e)
        {
            // Validation
            if (string.IsNullOrWhiteSpace(txtMaPhieuXuat.Text))
            {
                MessageBox.Show("Vui lòng nhập mã phiếu xuất!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaPhieuXuat.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtMaKho.Text))
            {
                MessageBox.Show("Vui lòng chọn kho hàng!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtTenKhachHang.Text))
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenKhachHang.Focus();
                return;
            }

            // Lấy dữ liệu
            MaPhieuXuat = txtMaPhieuXuat.Text.Trim();
            MaKho = txtMaKho.Text.Trim();
            NgayXuat = dteNgay.DateTime;
            TenKhachHang = txtTenKhachHang.Text.Trim();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnTHOAT_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnChonKhoHang_Click(object sender, EventArgs e)
        {
            FormChonKhoHang form = new FormChonKhoHang();
            form.StartPosition = FormStartPosition.CenterParent;
            DialogResult result = form.ShowDialog(this);
            
            if (result == DialogResult.OK)
            {
                this.txtMaKho.Text = Program.maKhoDuocChon;
                this.MaKho = Program.maKhoDuocChon;
            }
        }
    }
}
