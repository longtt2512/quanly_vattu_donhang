using QLTVT.ReportForm;
using System;
using System.Windows.Forms;

namespace QLTVT
{
    public partial class FormChinh_Std : Form
    {
        public FormChinh_Std()
        {
            InitializeComponent();
            this.MdiChildActivate += (s, e) =>
            {
                if (this.ActiveMdiChild != null)
                    this.ActiveMdiChild.WindowState = FormWindowState.Maximized;
            };
      

        }

  
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

 
        public void enableButtons()
        {
            btnDangNhap.Enabled = false;
            btnDangXuat.Enabled = true;

            menuNhapXuat.Visible = true;
            menuBaoCao.Visible = true;
            btnLapTaiKhoan.Enabled = true;

            if (Program.role == "USER")
            {
                btnLapTaiKhoan.Enabled = false;
            }
        }

        private void logout()
        {
            foreach (Form f in this.MdiChildren)
                f.Dispose();
        }

        private void FormChinh_Std_Load(object sender, EventArgs e)
        {
            using (var form = new FormDangNhap_Std())
            {
                var dr = form.ShowDialog(this);  // modal
                if (dr != DialogResult.OK) { this.Close(); return; } else
                {
                    FormNhanVien_Std formNhanVien_Std = new FormNhanVien_Std();
                    formNhanVien_Std.MdiParent = this;
                    formNhanVien_Std.Show();
                }
            }
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            logout();

            btnDangNhap.Enabled = true;
            btnDangXuat.Enabled = false;

            menuNhapXuat.Visible = false;
            menuBaoCao.Visible = false;

            Form f = this.CheckExists(typeof(FormDangNhap));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                FormDangNhap form = new FormDangNhap();
                form.Show();
            }

            Program.formChinh.MANHANVIEN.Text = "MÃ NHÂN VIÊN:";
            Program.formChinh.HOTEN.Text = "HỌ TÊN:";
            Program.formChinh.NHOM.Text = "VAI TRÒ:";
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            Form f = this.CheckExists(typeof(FormDangNhap_Std));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                FormDangNhap_Std form = new FormDangNhap_Std();
                form.Show();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            Form f = this.CheckExists(typeof(FormNhanVien_Std));
            if (f != null) f.Activate();
            else
            {
                FormNhanVien_Std form = new FormNhanVien_Std();
                form.MdiParent = this;
                form.Show();

            }
        }

        private void btnVatTu_Click(object sender, EventArgs e)
        {
            Form f = this.CheckExists(typeof(FormVatTu));
            if (f != null) f.Activate();
            else
            {
                FormVatTu form = new FormVatTu();
                form.MdiParent = this;
                form.Show();
            }
        }

        private void btnKho_Click(object sender, EventArgs e)
        {
            Form f = this.CheckExists(typeof(FormKho));
            if (f != null) f.Activate();
            else
            {
                FormKho form = new FormKho();
                form.MdiParent = this;
                form.Show();
            }
        }

        private void btnDonDatHang_Click(object sender, EventArgs e)
        {
            Form f = this.CheckExists(typeof(FormDonDatHang));
            if (f != null) f.Activate();
            else
            {
                FormDonDatHang form = new FormDonDatHang();
                form.MdiParent = this;
                form.Show();
            }
        }

        private void btnPhieuNhap_Click(object sender, EventArgs e)
        {
            Form f = this.CheckExists(typeof(FormPhieuNhap));
            if (f != null) f.Activate();
            else
            {
                FormPhieuNhap form = new FormPhieuNhap();
                form.MdiParent = this;
                form.Show();
            }
        }

        private void btnPhieuXuat_Click(object sender, EventArgs e)
        {
            Form f = this.CheckExists(typeof(FormPhieuXuat));
            if (f != null) f.Activate();
            else
            {
                FormPhieuXuat form = new FormPhieuXuat();
                form.MdiParent = this;
                form.Show();
            }
        }

        private void btnDanhSachNhanVien_Click(object sender, EventArgs e)
        {
            Form f = this.CheckExists(typeof(FormDanhSachNhanVien));
            if (f != null) f.Activate();
            else
            {
                FormDanhSachNhanVien form = new FormDanhSachNhanVien();
                form.Show();
            }
        }

        private void btnDanhSachVatTu_Click(object sender, EventArgs e)
        {
            Form f = this.CheckExists(typeof(FormDanhSachVatTu));
            if (f != null) f.Activate();
            else
            {
                FormDanhSachVatTu form = new FormDanhSachVatTu();
                form.Show();
            }
        }

        private void btnDonHangKhongPhieuNhap_Click(object sender, EventArgs e)
        {
            Form f = this.CheckExists(typeof(FormDonHangKhongPhieuNhap));
            if (f != null) f.Activate();
            else
            {
                FormDonHangKhongPhieuNhap form = new FormDonHangKhongPhieuNhap();
                form.Show();
            }
        }

        private void btnChiTietNhapXuat_Click(object sender, EventArgs e)
        {
            Form f = this.CheckExists(typeof(FormChiTietSoLuongTriGiaHangHoaNhapXuat));
            if (f != null) f.Activate();
            else
            {
                FormChiTietSoLuongTriGiaHangHoaNhapXuat form = new FormChiTietSoLuongTriGiaHangHoaNhapXuat();
                form.Show();
            }
        }

        private void btnHoatDongNhanVien_Click(object sender, EventArgs e)
        {
            Form f = this.CheckExists(typeof(FormHoatDongNhanVien));
            if (f != null) f.Activate();
            else
            {
                FormHoatDongNhanVien form = new FormHoatDongNhanVien();
                form.Show();
            }
        }

        private void btnTongHopNhapXuat_Click(object sender, EventArgs e)
        {
            Form f = this.CheckExists(typeof(FormTongHopNhapXuat));
            if (f != null) f.Activate();
            else
            {
                FormTongHopNhapXuat form = new FormTongHopNhapXuat();
                form.Show();
            }
        }

        private void btnLapTaiKhoan_Click(object sender, EventArgs e)
        {
            Form f = this.CheckExists(typeof(FormTaoTaiKhoan));
            if (f != null) f.Activate();
            else
            {
                FormTaoTaiKhoan form = new FormTaoTaiKhoan();
                form.Show();
            }
        }
    }
}