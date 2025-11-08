namespace QLTVT
{
    partial class FormChinh_Std
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuNhapXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.btnVatTu = new System.Windows.Forms.ToolStripMenuItem();
            this.btnKho = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLapPhieu = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDonDatHang = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPhieuNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPhieuXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBaoCao = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDanhSachNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDanhSachVatTu = new System.Windows.Forms.ToolStripMenuItem();
            this.btnChiTietNhapXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDonHangKhongPhieuNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.btnHoatDongNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.btnTongHopNhapXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDangNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLapTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.btnThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.MANHANVIEN = new System.Windows.Forms.ToolStripStatusLabel();
            this.HOTEN = new System.Windows.Forms.ToolStripStatusLabel();
            this.NHOM = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNhapXuat,
            this.menuBaoCao,
            this.menuHeThong});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1166, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuNhapXuat
            // 
            this.menuNhapXuat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNhanVien,
            this.btnVatTu,
            this.btnKho,
            this.menuLapPhieu});
            this.menuNhapXuat.Name = "menuNhapXuat";
            this.menuNhapXuat.Size = new System.Drawing.Size(85, 20);
            this.menuNhapXuat.Text = "NHẬP XUẤT";
            this.menuNhapXuat.Visible = false;
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Size = new System.Drawing.Size(128, 22);
            this.btnNhanVien.Text = "Nhân viên";
            this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);
            // 
            // btnVatTu
            // 
            this.btnVatTu.Name = "btnVatTu";
            this.btnVatTu.Size = new System.Drawing.Size(128, 22);
            this.btnVatTu.Text = "Vật tư";
            this.btnVatTu.Click += new System.EventHandler(this.btnVatTu_Click);
            // 
            // btnKho
            // 
            this.btnKho.Name = "btnKho";
            this.btnKho.Size = new System.Drawing.Size(128, 22);
            this.btnKho.Text = "Kho hàng";
            this.btnKho.Click += new System.EventHandler(this.btnKho_Click);
            // 
            // menuLapPhieu
            // 
            this.menuLapPhieu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnDonDatHang,
            this.btnPhieuNhap,
            this.btnPhieuXuat});
            this.menuLapPhieu.Name = "menuLapPhieu";
            this.menuLapPhieu.Size = new System.Drawing.Size(128, 22);
            this.menuLapPhieu.Text = "Lập phiếu";
            // 
            // btnDonDatHang
            // 
            this.btnDonDatHang.Name = "btnDonDatHang";
            this.btnDonDatHang.Size = new System.Drawing.Size(146, 22);
            this.btnDonDatHang.Text = "Đơn đặt hàng";
            this.btnDonDatHang.Click += new System.EventHandler(this.btnDonDatHang_Click);
            // 
            // btnPhieuNhap
            // 
            this.btnPhieuNhap.Name = "btnPhieuNhap";
            this.btnPhieuNhap.Size = new System.Drawing.Size(146, 22);
            this.btnPhieuNhap.Text = "Phiếu nhập";
            this.btnPhieuNhap.Click += new System.EventHandler(this.btnPhieuNhap_Click);
            // 
            // btnPhieuXuat
            // 
            this.btnPhieuXuat.Name = "btnPhieuXuat";
            this.btnPhieuXuat.Size = new System.Drawing.Size(146, 22);
            this.btnPhieuXuat.Text = "Phiếu xuất";
            this.btnPhieuXuat.Click += new System.EventHandler(this.btnPhieuXuat_Click);
            // 
            // menuBaoCao
            // 
            this.menuBaoCao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnDanhSachNhanVien,
            this.btnDanhSachVatTu,
            this.btnChiTietNhapXuat,
            this.btnDonHangKhongPhieuNhap,
            this.btnHoatDongNhanVien,
            this.btnTongHopNhapXuat});
            this.menuBaoCao.Name = "menuBaoCao";
            this.menuBaoCao.Size = new System.Drawing.Size(71, 20);
            this.menuBaoCao.Text = "BÁO CÁO";
            this.menuBaoCao.Visible = false;
            // 
            // btnDanhSachNhanVien
            // 
            this.btnDanhSachNhanVien.Name = "btnDanhSachNhanVien";
            this.btnDanhSachNhanVien.Size = new System.Drawing.Size(226, 22);
            this.btnDanhSachNhanVien.Text = "Danh sách nhân viên";
            this.btnDanhSachNhanVien.Click += new System.EventHandler(this.btnDanhSachNhanVien_Click);
            // 
            // btnDanhSachVatTu
            // 
            this.btnDanhSachVatTu.Name = "btnDanhSachVatTu";
            this.btnDanhSachVatTu.Size = new System.Drawing.Size(226, 22);
            this.btnDanhSachVatTu.Text = "Danh sách vật tư";
            this.btnDanhSachVatTu.Click += new System.EventHandler(this.btnDanhSachVatTu_Click);
            // 
            // btnChiTietNhapXuat
            // 
            this.btnChiTietNhapXuat.Name = "btnChiTietNhapXuat";
            this.btnChiTietNhapXuat.Size = new System.Drawing.Size(226, 22);
            this.btnChiTietNhapXuat.Text = "Chi tiết nhập xuất";
            this.btnChiTietNhapXuat.Click += new System.EventHandler(this.btnChiTietNhapXuat_Click);
            // 
            // btnDonHangKhongPhieuNhap
            // 
            this.btnDonHangKhongPhieuNhap.Name = "btnDonHangKhongPhieuNhap";
            this.btnDonHangKhongPhieuNhap.Size = new System.Drawing.Size(226, 22);
            this.btnDonHangKhongPhieuNhap.Text = "Đơn hàng không phiếu nhập";
            this.btnDonHangKhongPhieuNhap.Click += new System.EventHandler(this.btnDonHangKhongPhieuNhap_Click);
            // 
            // btnHoatDongNhanVien
            // 
            this.btnHoatDongNhanVien.Name = "btnHoatDongNhanVien";
            this.btnHoatDongNhanVien.Size = new System.Drawing.Size(226, 22);
            this.btnHoatDongNhanVien.Text = "Hoạt động nhân viên";
            this.btnHoatDongNhanVien.Click += new System.EventHandler(this.btnHoatDongNhanVien_Click);
            // 
            // btnTongHopNhapXuat
            // 
            this.btnTongHopNhapXuat.Name = "btnTongHopNhapXuat";
            this.btnTongHopNhapXuat.Size = new System.Drawing.Size(226, 22);
            this.btnTongHopNhapXuat.Text = "Tổng hợp nhập xuất";
            this.btnTongHopNhapXuat.Click += new System.EventHandler(this.btnTongHopNhapXuat_Click);
            // 
            // menuHeThong
            // 
            this.menuHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnDangNhap,
            this.btnDangXuat,
            this.btnLapTaiKhoan,
            this.btnThoat});
            this.menuHeThong.Name = "menuHeThong";
            this.menuHeThong.Size = new System.Drawing.Size(79, 20);
            this.menuHeThong.Text = "HỆ THỐNG";
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(146, 22);
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Enabled = false;
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(146, 22);
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // btnLapTaiKhoan
            // 
            this.btnLapTaiKhoan.Enabled = false;
            this.btnLapTaiKhoan.Name = "btnLapTaiKhoan";
            this.btnLapTaiKhoan.Size = new System.Drawing.Size(146, 22);
            this.btnLapTaiKhoan.Text = "Tạo tài khoản";
            this.btnLapTaiKhoan.Click += new System.EventHandler(this.btnLapTaiKhoan_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(146, 22);
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MANHANVIEN,
            this.HOTEN,
            this.NHOM});
            this.statusStrip1.Location = new System.Drawing.Point(0, 670);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1166, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // MANHANVIEN
            // 
            this.MANHANVIEN.Name = "MANHANVIEN";
            this.MANHANVIEN.Size = new System.Drawing.Size(92, 17);
            this.MANHANVIEN.Text = "MÃ NHÂN VIÊN";
            // 
            // HOTEN
            // 
            this.HOTEN.Name = "HOTEN";
            this.HOTEN.Size = new System.Drawing.Size(50, 17);
            this.HOTEN.Text = "HỌ TÊN";
            // 
            // NHOM
            // 
            this.NHOM.Name = "NHOM";
            this.NHOM.Size = new System.Drawing.Size(50, 17);
            this.NHOM.Text = "VAI TRÒ";
            // 
            // FormChinh_Std
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 692);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormChinh_Std";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ VẬT TƯ (Phiên bản chuẩn)";
            this.Load += new System.EventHandler(this.FormChinh_Std_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuNhapXuat;
        private System.Windows.Forms.ToolStripMenuItem btnNhanVien;
        private System.Windows.Forms.ToolStripMenuItem btnVatTu;
        private System.Windows.Forms.ToolStripMenuItem btnKho;
        private System.Windows.Forms.ToolStripMenuItem menuLapPhieu;
        private System.Windows.Forms.ToolStripMenuItem btnDonDatHang;
        private System.Windows.Forms.ToolStripMenuItem btnPhieuNhap;
        private System.Windows.Forms.ToolStripMenuItem btnPhieuXuat;
        private System.Windows.Forms.ToolStripMenuItem menuBaoCao;
        private System.Windows.Forms.ToolStripMenuItem btnDanhSachNhanVien;
        private System.Windows.Forms.ToolStripMenuItem btnDanhSachVatTu;
        private System.Windows.Forms.ToolStripMenuItem btnChiTietNhapXuat;
        private System.Windows.Forms.ToolStripMenuItem btnDonHangKhongPhieuNhap;
        private System.Windows.Forms.ToolStripMenuItem btnHoatDongNhanVien;
        private System.Windows.Forms.ToolStripMenuItem btnTongHopNhapXuat;
        private System.Windows.Forms.ToolStripMenuItem menuHeThong;
        private System.Windows.Forms.ToolStripMenuItem btnDangNhap;
        private System.Windows.Forms.ToolStripMenuItem btnDangXuat;
        private System.Windows.Forms.ToolStripMenuItem btnLapTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem btnThoat;
        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel MANHANVIEN;
        public System.Windows.Forms.ToolStripStatusLabel HOTEN;
        public System.Windows.Forms.ToolStripStatusLabel NHOM;
    }
}