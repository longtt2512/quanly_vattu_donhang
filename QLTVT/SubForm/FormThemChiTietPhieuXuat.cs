using System;
using System.Windows.Forms;

namespace QLTVT.SubForm
{
    public partial class FormThemChiTietPhieuXuat : Form
    {
        public string MaVatTu { get; set; }
        public int SoLuong { get; set; }
        public decimal DonGia { get; set; }
        private string maKho;

        public FormThemChiTietPhieuXuat(string maKho)
        {
            InitializeComponent();
            this.maKho = maKho;
        }

        private void FormThemChiTietPhieuXuat_Load(object sender, EventArgs e)
        {
            txtMaVatTu.Focus();
        }

        private void btnCHON_Click(object sender, EventArgs e)
        {
            // Validation
            if (string.IsNullOrWhiteSpace(txtMaVatTu.Text))
            {
                MessageBox.Show("Vui lòng chọn vật tư!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtSoLuong.Value <= 0)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoLuong.Focus();
                return;
            }

            if (txtDonGia.Value <= 0)
            {
                MessageBox.Show("Đơn giá phải lớn hơn 0!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDonGia.Focus();
                return;
            }

            // Lấy dữ liệu
            MaVatTu = txtMaVatTu.Text.Trim();
            SoLuong = (int)txtSoLuong.Value;
            DonGia = txtDonGia.Value;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnTHOAT_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnChonVatTu_Click(object sender, EventArgs e)
        {
            FormChonVatTu form = new FormChonVatTu();
            form.StartPosition = FormStartPosition.CenterParent;
            DialogResult result = form.ShowDialog(this);
            
            if (result == DialogResult.OK)
            {
                this.txtMaVatTu.Text = Program.maVatTuDuocChon;
                this.MaVatTu = Program.maVatTuDuocChon;
                
                // Tự động điền đơn giá nếu có
                if (Program.donGia > 0)
                {
                    txtDonGia.Value = Program.donGia;
                    this.DonGia = Program.donGia;
                }
            }
        }
    }
}
