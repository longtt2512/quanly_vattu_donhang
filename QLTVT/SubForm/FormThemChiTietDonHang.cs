using System;
using System.Windows.Forms;

namespace QLTVT.SubForm
{
    public partial class FormThemChiTietDonHang : Form
    {
        public string MaVatTu { get; set; }
        public int SoLuong { get; set; }
        public decimal DonGia { get; set; }

        public FormThemChiTietDonHang()
        {
            InitializeComponent();
        }

        private void FormThemChiTietDonHang_Load(object sender, EventArgs e)
        {
            numSoLuong.Value = 1;
            numDonGia.Value = 1;
        }

        private void btnChonVatTu_Click(object sender, EventArgs e)
        {
            FormChonVatTu f = new FormChonVatTu();
            f.StartPosition = FormStartPosition.CenterParent;
            DialogResult result = f.ShowDialog(this);
            
            if (result == DialogResult.OK)
            {
                this.txtMaVatTu.Text = Program.maVatTuDuocChon;
                this.MaVatTu = Program.maVatTuDuocChon;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            // Validate
            if (string.IsNullOrWhiteSpace(txtMaVatTu.Text))
            {
                MessageBox.Show("Vui lòng chọn vật tư", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnChonVatTu.Focus();
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
