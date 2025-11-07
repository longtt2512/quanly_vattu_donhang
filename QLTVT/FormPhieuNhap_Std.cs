using QLTVT.SubForm;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace QLTVT
{
    public partial class FormPhieuNhap_Std : Form
    {
        int viTri = 0;
        bool dangThemMoi = false;
        string maChiNhanh = "";
        Stack undoList = new Stack();

        // Ngữ cảnh đang làm việc (giữ nguyên ý tưởng gốc)
        BindingSource bds = null;
        Control gc = null; // dùng để bật/tắt khu vực lưới khi thêm/sửa
        string cheDoHienTai = "Phiếu Nhập"; // hoặc "Chi Tiết Phiếu Nhập"

        public FormPhieuNhap_Std()
        {
            InitializeComponent();
        }

        private void FormPhieuNhap_Std_Load(object sender, EventArgs e)
        {
            dataSet.EnforceConstraints = false;

            this.chiTietPhieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
            this.chiTietPhieuNhapTableAdapter.Fill(this.dataSet.CTPN);

            this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuNhapTableAdapter.Fill(this.dataSet.PhieuNhap);

            // Combobox chi nhánh
            cmbCHINHANH.DataSource = Program.bindingSource;
            cmbCHINHANH.DisplayMember = "TENCN";
            cmbCHINHANH.ValueMember = "TENSERVER";
            cmbCHINHANH.SelectedIndex = Program.brand;

            // Mặc định chọn chế độ Phiếu Nhập
            btnCheDoPhieuNhap_Click(this, EventArgs.Empty);
        }

        private void cmbCHINHANH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCHINHANH.SelectedValue == null) return;
            if (cmbCHINHANH.SelectedValue.ToString() == "System.Data.DataRowView") return;

            Program.serverName = cmbCHINHANH.SelectedValue.ToString();

            if (cmbCHINHANH.SelectedIndex != Program.brand)
            {
                Program.loginName = Program.remoteLogin;
                Program.loginPassword = Program.remotePassword;
            }
            else
            {
                Program.loginName = Program.currentLogin;
                Program.loginPassword = Program.currentPassword;
            }

            if (Program.KetNoi() == 0)
            {
                MessageBox.Show("Xảy ra lỗi kết nối với chi nhánh hiện tại", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                this.chiTietPhieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
                this.chiTietPhieuNhapTableAdapter.Fill(this.dataSet.CTPN);

                this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
                this.phieuNhapTableAdapter.Fill(this.dataSet.PhieuNhap);
            }
        }

        private void btnTHOAT_Click(object sender, EventArgs e) => this.Close();

        private void btnCheDoPhieuNhap_Click(object sender, EventArgs e)
        {
            cheDoHienTai = "Phiếu Nhập";
            bds = bdsPhieuNhap;
            gc = dgvPhieuNhap;

            // Bật/tắt controls
            txtMaPhieuNhap.Enabled = false;
            dteNgay.Enabled = false;

            txtMaDonDatHang.Enabled = false;
            btnChonDonHang.Enabled = false;

            txtMaNhanVien.Enabled = false;
            txtMaKho.Enabled = false;

            btnChonChiTietDonHang.Enabled = false;

            txtMaVatChiTietPhieuNhap.Enabled = false;
            txtSoLuongChiTietPhieuNhap.Enabled = false;
            txtDonGiaChiTietPhieuNhap.Enabled = false;

            dgvPhieuNhap.Enabled = true;
            dgvCTPN.Enabled = true;

            if (Program.role == "CONGTY")
            {
                cmbCHINHANH.Enabled = true;
                btnTHEM.Enabled = false; btnXOA.Enabled = false; btnGHI.Enabled = false;
                btnHOANTAC.Enabled = false; btnLAMMOI.Enabled = true; btnTHOAT.Enabled = true;
            }
            else
            {
                cmbCHINHANH.Enabled = false;
                btnTHEM.Enabled = true;
                btnXOA.Enabled = bdsPhieuNhap.Count > 0;
                btnGHI.Enabled = true;
                btnHOANTAC.Enabled = false;
                btnLAMMOI.Enabled = true;
                btnTHOAT.Enabled = true;
            }

            lblCheDo.Text = "Chế độ: Phiếu Nhập";
        }

        private void btnCheDoChiTietPhieuNhap_Click(object sender, EventArgs e)
        {
            cheDoHienTai = "Chi Tiết Phiếu Nhập";
            bds = bdsChiTietPhieuNhap;
            gc = dgvCTPN;

            txtMaPhieuNhap.Enabled = false;
            dteNgay.Enabled = false;

            txtMaDonDatHang.Enabled = false;
            btnChonDonHang.Enabled = false;

            txtMaNhanVien.Enabled = false;
            txtMaKho.Enabled = false;

            txtMaVatTu.Enabled = false;

            btnChonChiTietDonHang.Enabled = false;

            dgvPhieuNhap.Enabled = true;
            dgvCTPN.Enabled = true;

            if (Program.role == "CONGTY")
            {
                cmbCHINHANH.Enabled = true;
                btnTHEM.Enabled = false; btnXOA.Enabled = false; btnGHI.Enabled = false;
                btnHOANTAC.Enabled = false; btnLAMMOI.Enabled = true; btnTHOAT.Enabled = true;
            }
            else
            {
                cmbCHINHANH.Enabled = false;
                btnTHEM.Enabled = true;
                btnXOA.Enabled = false;
                btnGHI.Enabled = true;
                btnHOANTAC.Enabled = false;
                btnLAMMOI.Enabled = true;
                btnTHOAT.Enabled = true;
            }

            lblCheDo.Text = "Chế độ: Chi Tiết Phiếu Nhập";
        }

        private void btnLAMMOI_Click(object sender, EventArgs e)
        {
            try
            {
                this.phieuNhapTableAdapter.Fill(this.dataSet.PhieuNhap);
                this.chiTietPhieuNhapTableAdapter.Fill(this.dataSet.CTPN);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi làm mới dữ liệu\\n\\n" + ex.Message, "Thông Báo", MessageBoxButtons.OK);
            }
        }

        private void btnChonDonHang_Click(object sender, EventArgs e)
        {
            FormChonDonDatHang form = new FormChonDonDatHang();
            form.ShowDialog();
            this.txtMaDonDatHang.Text = Program.maDonDatHangDuocChon;
            this.txtMaKho.Text = Program.maKhoDuocChon;
        }

        private void btnChonChiTietDonHang_Click(object sender, EventArgs e)
        {
            Program.maDonDatHangDuocChon = ((DataRowView)(bdsPhieuNhap.Current))["MasoDDH"].ToString().Trim();

            FormChonChiTietDonHang form = new FormChonChiTietDonHang();
            form.ShowDialog();

            this.txtMaVatChiTietPhieuNhap.Text = Program.maVatTuDuocChon;
            this.txtSoLuongChiTietPhieuNhap.Value = Program.soLuongVatTu;
            this.txtDonGiaChiTietPhieuNhap.Value = (decimal)Program.donGia;
        }

        private void btnTHEM_Click(object sender, EventArgs e)
        {
            viTri = bds.Position;
            dangThemMoi = true;

            bds.AddNew();
            if (cheDoHienTai == "Phiếu Nhập")
            {
                txtMaPhieuNhap.Enabled = true;

                dteNgay.Value = DateTime.Now; dteNgay.Enabled = false;

                txtMaDonDatHang.Enabled = false;
                btnChonDonHang.Enabled = true;

                txtMaNhanVien.Text = Program.userName;
                txtMaKho.Text = Program.maKhoDuocChon;

                ((DataRowView)(bdsPhieuNhap.Current))["NGAY"] = DateTime.Now;
                ((DataRowView)(bdsPhieuNhap.Current))["MasoDDH"] = Program.maDonDatHangDuocChon;
                ((DataRowView)(bdsPhieuNhap.Current))["MANV"] = Program.userName;
                ((DataRowView)(bdsPhieuNhap.Current))["MAKHO"] = Program.maKhoDuocChon;
            }

            if (cheDoHienTai == "Chi Tiết Phiếu Nhập")
            {
                DataRowView drv = ((DataRowView)bdsPhieuNhap[bdsPhieuNhap.Position]);
                String maNhanVien = drv["MANV"].ToString();
                if (Program.userName != maNhanVien)
                {
                    MessageBox.Show("Bạn không thêm chi tiết trên phiếu không phải do mình tạo", "Thông báo", MessageBoxButtons.OK);
                    bdsChiTietPhieuNhap.RemoveCurrent();
                    return;
                }

                ((DataRowView)(bdsChiTietPhieuNhap.Current))["MAPN"] = ((DataRowView)(bdsPhieuNhap.Current))["MAPN"];
                ((DataRowView)(bdsChiTietPhieuNhap.Current))["MAVT"] = Program.maVatTuDuocChon;
                ((DataRowView)(bdsChiTietPhieuNhap.Current))["SOLUONG"] = Program.soLuongVatTu;
                ((DataRowView)(bdsChiTietPhieuNhap.Current))["DONGIA"] = Program.donGia;

                txtMaVatTu.Enabled = false;
                btnChonChiTietDonHang.Enabled = true;

                txtSoLuong.Enabled = true;
                txtSoLuong.Value = 1;

                txtDonGia.Enabled = true;
                txtDonGia.Value = 1;

                txtSoLuongChiTietPhieuNhap.Enabled = true;
                txtDonGiaChiTietPhieuNhap.Enabled = true;
            }

            btnTHEM.Enabled = false;
            btnXOA.Enabled = false;
            btnGHI.Enabled = true;
            btnHOANTAC.Enabled = true;
            btnLAMMOI.Enabled = false;
            btnTHOAT.Enabled = false;

            dgvPhieuNhap.Enabled = false;
            dgvCTPN.Enabled = false;
        }

        private void btnHOANTAC_Click(object sender, EventArgs e)
        {
            if (dangThemMoi == true && btnTHEM.Enabled == false)
            {
                dangThemMoi = false;

                if (cheDoHienTai == "Phiếu Nhập")
                {
                    txtMaDonDatHang.Enabled = false; dteNgay.Enabled = false;
                    txtMaDonDatHang.Enabled = false; txtMaKho.Enabled = false;
                    btnChonDonHang.Enabled = false; txtMaDonDatHang.Enabled = false;
                }
                if (cheDoHienTai == "Chi Tiết Phiếu Nhập")
                {
                    btnChonChiTietDonHang.Enabled = false;
                    txtMaVatChiTietPhieuNhap.Enabled = false;
                    txtSoLuongChiTietPhieuNhap.Enabled = false;
                    txtDonGiaChiTietPhieuNhap.Enabled = false;
                    btnXOA.Enabled = false;
                }

                btnTHEM.Enabled = true; btnXOA.Enabled = true; btnGHI.Enabled = true;
                btnLAMMOI.Enabled = true; btnTHOAT.Enabled = true;

                dgvPhieuNhap.Enabled = true; dgvCTPN.Enabled = true;

                bds.CancelEdit();
                bds.RemoveCurrent();
                bds.Position = viTri;
                return;
            }

            if (undoList.Count == 0)
            {
                MessageBox.Show("Không còn thao tác nào để khôi phục", "Thông báo", MessageBoxButtons.OK);
                btnHOANTAC.Enabled = false;
                return;
            }

            bds.CancelEdit();
            String cauTruyVanHoanTac = undoList.Pop().ToString();
            int n = Program.ExecSqlNonQuery(cauTruyVanHoanTac);

            this.phieuNhapTableAdapter.Fill(this.dataSet.PhieuNhap);
            this.chiTietPhieuNhapTableAdapter.Fill(this.dataSet.CTPN);
            bdsPhieuNhap.Position = viTri;
        }

        private void capNhatSoLuongVatTu(string maVatTu, int soLuong)
        {
            string cauTruyVan = "EXEC sp_CapNhatSoLuongVatTu 'IMPORT','" + maVatTu + "', " + soLuong;
            int n = Program.ExecSqlNonQuery(cauTruyVan);
        }

        private string taoCauTruyVanHoanTac(string cheDo)
        {
            string cauTruyVan = "";
            DataRowView drv;

            if (cheDo == "Chi Tiết Phiếu Nhập" && dangThemMoi == false)
            {
                drv = ((DataRowView)(bdsChiTietPhieuNhap.Current));
                int soLuong = int.Parse(drv["SOLUONG"].ToString().Trim());
                float donGia = float.Parse(drv["DONGIA"].ToString().Trim());
                String maPhieuNhap = drv["MAPN"].ToString().Trim();
                String maVatTu = drv["MAVT"].ToString().Trim();

                cauTruyVan = "UPDATE DBO.CTPN " +
                    "SET SOLUONG = " + soLuong + ", DONGIA = " + donGia + " " +
                    "WHERE MAPN = '" + maPhieuNhap + "' AND MAVT = '" + maVatTu + "' ";
            }
            return cauTruyVan;
        }

        private bool kiemTraDuLieuDauVao(string cheDo)
        {
            if (cheDo == "Phiếu Nhập")
            {
                if (txtMaPhieuNhap.Text.Trim() == "") { MessageBox.Show("Không bỏ trống mã phiếu nhập!", "Thông báo"); txtMaPhieuNhap.Focus(); return false; }
                if (txtMaNhanVien.Text.Trim() == "") { MessageBox.Show("Không bỏ trống mã nhân viên!", "Thông báo"); return false; }
                if (txtMaKho.Text.Trim() == "") { MessageBox.Show("Không bỏ trống mã kho!", "Thông báo"); return false; }
                if (txtMaDonDatHang.Text.Trim() == "") { MessageBox.Show("Không bỏ trống mã đơn đặt hàng!", "Thông báo"); return false; }
            }
            if (cheDo == "Chi Tiết Phiếu Nhập")
            {
                if (txtMaVatChiTietPhieuNhap.Text.Trim() == "") { MessageBox.Show("Không bỏ trống mã vật tư!", "Thông báo"); return false; }
                if (txtSoLuongChiTietPhieuNhap.Value < 0 || txtSoLuongChiTietPhieuNhap.Value > Program.soLuongVatTu)
                {
                    MessageBox.Show("Số lượng vật tư không thể lớn hơn số lượng trong chi tiết đơn hàng!", "Thông báo"); 
                    txtSoLuongChiTietPhieuNhap.Focus(); return false;
                }
                if (txtDonGiaChiTietPhieuNhap.Value < 1)
                {
                    MessageBox.Show("Đơn giá không thể nhỏ hơn 1 VND", "Thông báo"); 
                    txtDonGiaChiTietPhieuNhap.Focus(); return false;
                }
            }
            return true;
        }

        private void btnGHI_Click(object sender, EventArgs e)
        {
            string cheDo = cheDoHienTai;
            bool ok = kiemTraDuLieuDauVao(cheDo);
            if (!ok) return;

            string cauTruyVanHoanTac = taoCauTruyVanHoanTac(cheDo);

            string maPhieuNhap = txtMaPhieuNhap.Text.Trim();
            string cauTruyVan =
                    "DECLARE @result int " +
                    "EXEC @result = sp_KiemTraMaPhieuNhap '" + maPhieuNhap + "' " +
                    "SELECT 'Value' = @result";
            try
            {
                Program.myReader = Program.ExecSqlDataReader(cauTruyVan);
                if (Program.myReader == null) return;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thực thi database thất bại!\\n\\n" + ex.Message, "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Program.myReader.Read();
            int result = int.Parse(Program.myReader.GetValue(0).ToString());
            Program.myReader.Close();

            int viTriConTro = bdsPhieuNhap.Position;
            int viTriMaPhieuNhap = bdsPhieuNhap.Find("MAPN", maPhieuNhap);

            if (result == 1 && cheDo == "Phiếu Nhập" && viTriMaPhieuNhap != viTriConTro)
            {
                MessageBox.Show("Mã phiếu nhập đã được sử dụng!", "Thông báo", MessageBoxButtons.OK);
                txtMaPhieuNhap.Focus();
                return;
            }
            else
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc muốn ghi dữ liệu vào cơ sở dữ liệu ?", "Thông báo",
                         MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    try
                    {
                        if (cheDo == "Phiếu Nhập" && dangThemMoi == true)
                        {
                            cauTruyVanHoanTac =
                                "DELETE FROM DBO.PHIEUNHAP WHERE MAPN = '" + maPhieuNhap + "'";
                        }
                        if (cheDo == "Chi Tiết Phiếu Nhập" && dangThemMoi == true)
                        {
                            cauTruyVanHoanTac =
                                "DELETE FROM DBO.CTPN WHERE MAPN = '" + maPhieuNhap + "' AND MAVT = '" + Program.maVatTuDuocChon + "'";

                            string maVatTu = txtMaVatChiTietPhieuNhap.Text.Trim();
                            int soLuong = (int)txtSoLuongChiTietPhieuNhap.Value;
                            capNhatSoLuongVatTu(maVatTu, soLuong);
                        }

                        undoList.Push(cauTruyVanHoanTac);

                        this.bdsPhieuNhap.EndEdit();
                        this.bdsChiTietPhieuNhap.EndEdit();
                        this.phieuNhapTableAdapter.Update(this.dataSet.PhieuNhap);
                        this.chiTietPhieuNhapTableAdapter.Update(this.dataSet.CTPN);

                        btnTHEM.Enabled = true; btnXOA.Enabled = true; btnGHI.Enabled = true;
                        btnHOANTAC.Enabled = true; btnLAMMOI.Enabled = true; btnTHOAT.Enabled = true;

                        dgvPhieuNhap.Enabled = true; dgvCTPN.Enabled = true;

                        dangThemMoi = false;
                        MessageBox.Show("Ghi thành công", "Thông báo");
                    }
                    catch (Exception ex)
                    {
                        bds.RemoveCurrent();
                        MessageBox.Show("Thất bại. Vui lòng kiểm tra lại!\\n" + ex.Message, "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}