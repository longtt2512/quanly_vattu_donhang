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

            menuQuanLyNhanVien.Visible = true;
            menuQuanLyVatTu.Visible = true;
            menuQuanLyKho.Visible = true;
            menuQuanLyDonHang.Visible = true;
            menuQuanLyPhieu.Visible = true;
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

            menuQuanLyNhanVien.Visible = false;
            menuQuanLyVatTu.Visible = false;
            menuQuanLyKho.Visible = false;
            menuQuanLyDonHang.Visible = false;
            menuQuanLyPhieu.Visible = false;
            menuBaoCao.Visible = false;

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
            
            ResetAllMenuFont();
            SetActiveMenuFont(btnNhanVien);
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
            
            ResetAllMenuFont();
            SetActiveMenuFont(btnVatTu);
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
            
            ResetAllMenuFont();
            SetActiveMenuFont(btnKho);
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
            
            ResetAllMenuFont();
            SetActiveMenuFont(btnDonDatHang);
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
            
            ResetAllMenuFont();
            SetActiveMenuFont(btnPhieuNhap);
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
            
            ResetAllMenuFont();
            SetActiveMenuFont(btnPhieuXuat);
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
            
            ResetAllMenuFont();
            SetActiveMenuFont(btnDanhSachNhanVien);
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
            
            ResetAllMenuFont();
            SetActiveMenuFont(btnDanhSachVatTu);
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
            
            ResetAllMenuFont();
            SetActiveMenuFont(btnDonHangKhongPhieuNhap);
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
            
            ResetAllMenuFont();
            SetActiveMenuFont(btnChiTietNhapXuat);
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
            
            ResetAllMenuFont();
            SetActiveMenuFont(btnHoatDongNhanVien);
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
            
            ResetAllMenuFont();
            SetActiveMenuFont(btnTongHopNhapXuat);
        }

        private void btnLapTaiKhoan_Click(object sender, EventArgs e)
        {
            Form f = this.CheckExists(typeof(FormTaoTaiKhoan_Std));
            if (f != null) f.Activate();
            else
            {
                FormTaoTaiKhoan_Std form = new FormTaoTaiKhoan_Std();
                form.Show();
            }
            
            ResetAllMenuFont();
            SetActiveMenuFont(btnLapTaiKhoan);
        }

        // Reset tất cả menu items về font bình thường
        private void ResetAllMenuFont()
        {
            System.Drawing.Font normalFont = new System.Drawing.Font(menuStrip1.Font.FontFamily, 9F, System.Drawing.FontStyle.Regular);
            
            // Reset parent menus
            menuQuanLyNhanVien.Font = normalFont;
            menuQuanLyVatTu.Font = normalFont;
            menuQuanLyKho.Font = normalFont;
            menuQuanLyDonHang.Font = normalFont;
            menuQuanLyPhieu.Font = normalFont;
            menuBaoCao.Font = normalFont;
            menuHeThong.Font = normalFont;
            
            // Reset child menu items
            btnNhanVien.Font = normalFont;
            btnVatTu.Font = normalFont;
            btnKho.Font = normalFont;
            btnDonDatHang.Font = normalFont;
            btnPhieuNhap.Font = normalFont;
            btnPhieuXuat.Font = normalFont;
            btnDanhSachNhanVien.Font = normalFont;
            btnDanhSachVatTu.Font = normalFont;
            btnChiTietNhapXuat.Font = normalFont;
            btnDonHangKhongPhieuNhap.Font = normalFont;
            btnHoatDongNhanVien.Font = normalFont;
            btnTongHopNhapXuat.Font = normalFont;
            btnLapTaiKhoan.Font = normalFont;
        }

        // Đặt font đậm cho menu item được chọn và parent menu
        private void SetActiveMenuFont(ToolStripMenuItem menuItem)
        {
            System.Drawing.Font boldFont = new System.Drawing.Font(menuStrip1.Font.FontFamily, 9F, System.Drawing.FontStyle.Bold);
            menuItem.Font = boldFont;
            
            // Cũng bôi đậm parent menu nếu có
            if (menuItem.OwnerItem is ToolStripMenuItem parentMenu)
            {
                parentMenu.Font = boldFont;
            }
        }
    }
}