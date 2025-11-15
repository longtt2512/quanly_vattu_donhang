using QLTVT.SubForm;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLTVT
{
    public partial class FormTaoTaiKhoan_Std : Form
    {
        private string taiKhoan = "";
        private string matKhau = "";
        private string maNhanVien = "";
        private string vaiTro = "";

        public FormTaoTaiKhoan_Std()
        {
            InitializeComponent();

            this.AcceptButton = btnXacNhan; 
            this.CancelButton = btnThoat;   
            txtMatKhau.UseSystemPasswordChar = TrueIfAvailable(txtMatKhau);
            txtXacNhanMatKhau.UseSystemPasswordChar = TrueIfAvailable(txtXacNhanMatKhau);
        }

        private bool TrueIfAvailable(TextBox tb)
        {
            try { return true; } catch { return true; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnChonNhanVien_Click(object sender, EventArgs e)
        {
            using (var form = new FormChonNhanVien_Std())
            {
                form.ShowDialog();
            }
            txtMaNhanVien.Text = Program.maNhanVienDuocChon;
            txtTaiKhoan.Text = Program.taiKhoan;
        }

        private bool kiemTraDuLieuDauVao()
        {
            if (txtMaNhanVien.Text.Trim() == "")
            {
                MessageBox.Show("Thiếu mã nhân viên", "Thông báo", MessageBoxButtons.OK);
                return false;
            }

            if (txtMatKhau.Text.Trim() == "")
            {
                MessageBox.Show("Thiếu mật khẩu", "Thông báo", MessageBoxButtons.OK);
                return false;
            }

            if (txtXacNhanMatKhau.Text.Trim() == "")
            {
                MessageBox.Show("Thiếu mật khẩu xác nhận", "Thông báo", MessageBoxButtons.OK);
                return false;
            }

            if (txtMatKhau.Text != txtXacNhanMatKhau.Text)
            {
                MessageBox.Show("Mật khẩu không khớp với mật khẩu xác nhận", "Thông báo", MessageBoxButtons.OK);
                return false;
            }

            return true;
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            bool ketQua = kiemTraDuLieuDauVao();
            if (ketQua == false) return;

            taiKhoan = Program.taiKhoan; 
            matKhau = txtMatKhau.Text;
            maNhanVien = Program.maNhanVienDuocChon;
            if (rdChiNhanh.Enabled) { 
            vaiTro = (rdChiNhanh.Checked == true) ? "CHINHANH" : "USER";
            }
            string cauTruyVan =
                "EXEC sp_TaoTaiKhoan '" + taiKhoan + "' , '" + matKhau + "', '" + maNhanVien + "', '" + vaiTro + "'";

            try
            {
                Program.myReader = Program.ExecSqlDataReader(cauTruyVan);
                if (Program.myReader == null) return;

                MessageBox.Show(
                    "Đăng kí tài khoản thành công" +
                    "\n\nTài khoản: " + taiKhoan +
                    "\nMật khẩu: " + matKhau +
                    "\nMã Nhân Viên: " + maNhanVien +
                    "\nVai Trò: " + vaiTro,
                    "Thông Báo", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thực thi database thất bại!\n\n" + ex.Message, "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void FormTaoTaiKhoan_Load(object sender, EventArgs e)
        {
            if (Program.role == "CONGTY")
            {
                vaiTro = "CONGTY";
                rdChiNhanh.Enabled = false;
                rdUser.Enabled = false;
            }
            else
            {
                rdChiNhanh.Enabled = true;
                rdUser.Enabled = true;
            }
        }
    }
}
