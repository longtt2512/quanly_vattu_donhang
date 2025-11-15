using QLTVT.SubForm;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace QLTVT
{
    public partial class FormNhanVien_Std : Form
    {
        int viTri = 0;
        bool dangThemMoi = false;
        string maChiNhanh = "";
        string regexTiengViet =  "^[a-zA-ZÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚĂĐĨŨƠàáâãèéêìíòóôõùúăđĩũơƯĂÂÊÔƠƯẠẢẤẦẨẪẬẮẰẲẴẶẸẺẼỀỀỂưăâêôơưạảấầẩẫậắằẳẵặẹẻẽềềểếỄỆỈỊỌỎỐỒỔỖỘỚỜỞỠỢỤỦỨỪễệỉịọỏốồổỗộớờởỡợụủứừửữựỳỵỷỹÝýỶỸỴỳỷỹ ]+$";
        Stack undoList = new Stack();

        private static int CalculateAge(DateTime dateOfBirth)
        {
            int age = DateTime.Now.Year - dateOfBirth.Year;
            if (DateTime.Now.DayOfYear < dateOfBirth.DayOfYear) age--;
            return age;
        }

        public FormNhanVien_Std()
        {
            InitializeComponent();
        }

        private void FormNhanVien_Std_Load(object sender, EventArgs e)
        {
            dataSet.EnforceConstraints = false;

            this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
            this.nhanVienTableAdapter.Fill(this.dataSet.NhanVien);

            this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
            this.datHangTableAdapter.Fill(this.dataSet.DatHang);

            this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuNhapTableAdapter.Fill(this.dataSet.PhieuNhap);

            this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuXuatTableAdapter.Fill(this.dataSet.PhieuXuat);

            // Ensure relations exist (if the typed DataSet lacks them at runtime)
            if (!dataSet.Relations.Contains("FK_DatHang_NhanVien"))
                dataSet.Relations.Add("FK_DatHang_NhanVien",
                    dataSet.NhanVien.Columns["MANV"],
                    dataSet.DatHang.Columns["MANV"], false);

            if (!dataSet.Relations.Contains("FK_PhieuNhap_NhanVien"))
                dataSet.Relations.Add("FK_PhieuNhap_NhanVien",
                    dataSet.NhanVien.Columns["MANV"],
                    dataSet.PhieuNhap.Columns["MANV"], false);

            if (!dataSet.Relations.Contains("FK_PX_NhanVien"))
                dataSet.Relations.Add("FK_PX_NhanVien",
                    dataSet.NhanVien.Columns["MANV"],
                    dataSet.PhieuXuat.Columns["MANV"], false);

            if (bdsNhanVien.Count > 0)
            {
                maChiNhanh = ((DataRowView)bdsNhanVien[0])["MACN"].ToString();
            }

            cmbCHINHANH.DataSource = Program.bindingSource;
            cmbCHINHANH.DisplayMember = "TENCN";
            cmbCHINHANH.ValueMember = "TENSERVER";
            cmbCHINHANH.SelectedIndex = Program.brand;

            // Bind child grids to relations through BindingSource chain
            dgvDatHang.DataSource = bdsDatHang;       // DataMember FK_DatHang_NhanVien
            dgvPhieuNhap.DataSource = bdsPhieuNhap;   // DataMember FK_PhieuNhap_NhanVien
            dgvPhieuXuat.DataSource = bdsPhieuXuat;   // DataMember FK_PX_NhanVien

            if (Program.role == "CONGTY")
            {
                cmbCHINHANH.Enabled = true;

                btnTHEM.Enabled = false;
                btnXOA.Enabled = false;
                btnGHI.Enabled = false;

                btnHOANTAC.Enabled = false;
                btnLAMMOI.Enabled = true;
                btnCHUYENCHINHANH.Enabled = false;
                btnTHOAT.Enabled = true;

                panelNhapLieu.Enabled = false;
            }
            else // CHINHANH || USER
            {
                cmbCHINHANH.Enabled = false;

                btnTHEM.Enabled = true;
                btnXOA.Enabled = true;
                btnGHI.Enabled = true;

                btnHOANTAC.Enabled = false;
                btnLAMMOI.Enabled = true;
                btnCHUYENCHINHANH.Enabled = true;
                btnTHOAT.Enabled = true;

                panelNhapLieu.Enabled = true;
                txtMANV.Enabled = false;
            }
        }

        private void btnTHOAT_Click(object sender, EventArgs e) => this.Close();

        private void btnTHEM_Click(object sender, EventArgs e)
        {
            viTri = bdsNhanVien.Position;
            panelNhapLieu.Enabled = true;
            dangThemMoi = true;

            bdsNhanVien.AddNew();
            txtMACN.Text = maChiNhanh;
            dteNGAYSINH.Value = new DateTime(1990, 1, 1);
            txtLUONG.Value = 4000000;
            trangThaiXoaCheckBox.Checked = false;
            ((DataRowView)bdsNhanVien.Current)["TrangThaiXoa"] = false;
            ((DataRowView)bdsNhanVien.Current)["NGAYSINH"] = dteNGAYSINH.Value;
            ((DataRowView)bdsNhanVien.Current)["LUONG"] = txtLUONG.Value;
            txtMANV.Enabled = true;
            btnTHEM.Enabled = false;
            btnXOA.Enabled = false;
            btnGHI.Enabled = true;

            btnHOANTAC.Enabled = true;
            btnLAMMOI.Enabled = false;
            btnCHUYENCHINHANH.Enabled = false;
            btnTHOAT.Enabled = false;

            dgvNhanVien.Enabled = false;
            panelNhapLieu.Enabled = true;
        }

        private void btnHOANTAC_Click(object sender, EventArgs e)
        {
            if (dangThemMoi == true && btnTHEM.Enabled == false)
            {
                dangThemMoi = false;

                txtMANV.Enabled = false;
                btnTHEM.Enabled = true;
                btnXOA.Enabled = true;
                btnGHI.Enabled = true;

                btnHOANTAC.Enabled = false;
                btnLAMMOI.Enabled = true;
                btnCHUYENCHINHANH.Enabled = true;
                btnTHOAT.Enabled = true;
                trangThaiXoaCheckBox.Checked = false;

                dgvNhanVien.Enabled = true;
                panelNhapLieu.Enabled = true;

                bdsNhanVien.CancelEdit();
                bdsNhanVien.RemoveCurrent();
                bdsNhanVien.Position = viTri;
                return;
            }

            if (undoList.Count == 0)
            {
                MessageBox.Show("Không còn thao tác nào để khôi phục", "Thông báo", MessageBoxButtons.OK);
                btnHOANTAC.Enabled = false;
                return;
            }

            bdsNhanVien.CancelEdit();
            string cauTruyVanHoanTac = undoList.Pop().ToString();

            if (cauTruyVanHoanTac.Contains("sp_ChuyenChiNhanh"))
            {
                try
                {
                    string chiNhanhHienTai = Program.serverName;
                    string chiNhanhChuyenToi = Program.serverNameLeft;

                    Program.serverName = chiNhanhChuyenToi;
                    Program.loginName = Program.remoteLogin;
                    Program.loginPassword = Program.remotePassword;

                    if (Program.KetNoi() == 0) return;

                    int n = Program.ExecSqlNonQuery(cauTruyVanHoanTac);

                    MessageBox.Show("Chuyển nhân viên trở lại thành công", "Thông báo", MessageBoxButtons.OK);
                    Program.serverName = chiNhanhHienTai;
                    Program.loginName = Program.currentLogin;
                    Program.loginPassword = Program.currentPassword;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Chuyển nhân viên thất bại \n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                    return;
                }
            }
            else
            {
                if (Program.KetNoi() == 0) return;
                int n = Program.ExecSqlNonQuery(cauTruyVanHoanTac);
            }
            this.nhanVienTableAdapter.Fill(this.dataSet.NhanVien);
        }

        private void btnLAMMOI_Click(object sender, EventArgs e)
        {
            try
            {
                this.nhanVienTableAdapter.Fill(this.dataSet.NhanVien);
                dgvNhanVien.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Làm mới " + ex.Message, "Thông báo", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnXOA_Click(object sender, EventArgs e)
        {
            if (bdsNhanVien.Count == 0) { btnXOA.Enabled = false; return; }

            string tenNV = ((DataRowView)bdsNhanVien[bdsNhanVien.Position])["MANV"].ToString();

            if (tenNV == Program.userName)
            {
                MessageBox.Show("Không thể xóa chính tài khoản đang đăng nhập", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            if (bdsDatHang.Count > 0)
            {
                MessageBox.Show("Không thể xóa nhân viên này vì đã lập đơn đặt hàng", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if (bdsPhieuNhap.Count > 0)
            {
                MessageBox.Show("Không thể xóa nhân viên này vì đã lập phiếu nhập", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if (bdsPhieuXuat.Count > 0)
            {
                MessageBox.Show("Không thể xóa nhân viên này vì đã lập phiếu xuất", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            DateTime NGAYSINH = (DateTime)((DataRowView)bdsNhanVien[bdsNhanVien.Position])["NGAYSINH"];
            string cauTruyVanHoanTac =
                string.Format("INSERT INTO DBO.NHANVIEN( MANV,HO,TEN,DIACHI,NGAYSINH,LUONG,MACN)" +
                    "VALUES({0},'{1}','{2}','{3}',CAST('{4}' AS DATETIME), {5},'{6}')",
                    txtMANV.Text, txtHO.Text, txtTEN.Text, txtDIACHI.Text, NGAYSINH.ToString("yyyy-MM-dd"), (int)txtLUONG.Value, txtMACN.Text.Trim());
            undoList.Push(cauTruyVanHoanTac);

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này không ?", "Thông báo",
                MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    viTri = bdsNhanVien.Position;
                    bdsNhanVien.RemoveCurrent();

                    this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.nhanVienTableAdapter.Update(this.dataSet.NhanVien);

                    MessageBox.Show("Xóa thành công ", "Thông báo", MessageBoxButtons.OK);
                    btnHOANTAC.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa nhân viên. Hãy thử lại\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                    this.nhanVienTableAdapter.Fill(this.dataSet.NhanVien);
                    bdsNhanVien.Position = viTri;
                    return;
                }
            }
            else
            {
                undoList.Pop();
            }
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
                this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                this.nhanVienTableAdapter.Fill(this.dataSet.NhanVien);

                this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
                this.datHangTableAdapter.Fill(this.dataSet.DatHang);

                this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
                this.phieuNhapTableAdapter.Fill(this.dataSet.PhieuNhap);

                this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
                this.phieuXuatTableAdapter.Fill(this.dataSet.PhieuXuat);
            }
        }

        private void dteNGAYSINH_Validating(object sender, CancelEventArgs e)
        {
            // optional validation hook
        }

        private bool kiemTraDuLieuDauVao()
        {
            if (txtMANV.Text == "")
            {
                MessageBox.Show("Không bỏ trống mã nhân viên", "Thông báo", MessageBoxButtons.OK);
                txtMANV.Focus(); return false;
            }
            if (Regex.IsMatch(txtMANV.Text, @"^[0-9]+$") == false)
            {
                MessageBox.Show("Mã nhân viên chỉ chấp nhận số", "Thông báo", MessageBoxButtons.OK);
                txtMANV.Focus(); return false;
            }

            if (txtHO.Text == "")
            {
                MessageBox.Show("Không bỏ trống họ và tên", "Thông báo", MessageBoxButtons.OK);
                txtHO.Focus(); return false;
            }
            if (Regex.IsMatch(txtHO.Text, @regexTiengViet) == false)
            {
                MessageBox.Show("Họ của người chỉ có chữ cái và khoảng trắng", "Thông báo", MessageBoxButtons.OK);
                txtHO.Focus(); return false;
            }
            if (txtHO.Text.Length > 40)
            {
                MessageBox.Show("Họ không thể lớn hơn 40 kí tự", "Thông báo", MessageBoxButtons.OK);
                txtHO.Focus(); return false;
            }

            if (txtTEN.Text == "")
            {
                MessageBox.Show("Không bỏ trống họ và tên", "Thông báo", MessageBoxButtons.OK);
                txtTEN.Focus(); return false;
            }
            if (Regex.IsMatch(txtTEN.Text, @regexTiengViet) == false)
            {
                MessageBox.Show("Tên người chỉ có chữ cái và khoảng trắng", "Thông báo", MessageBoxButtons.OK);
                txtTEN.Focus(); return false;
            }
            if (txtTEN.Text.Length > 10)
            {
                MessageBox.Show("Tên không thể lớn hơn 10 kí tự", "Thông báo", MessageBoxButtons.OK);
                txtTEN.Focus(); return false;
            }

            if (txtDIACHI.Text == "")
            {
                MessageBox.Show("Không bỏ trống địa chỉ", "Thông báo", MessageBoxButtons.OK);
                txtDIACHI.Focus(); return false;
            }
            if (Regex.IsMatch(txtHO.Text, @regexTiengViet) == false)
            {
                MessageBox.Show("Địa chỉ chỉ chấp nhận chữ cái, số và khoảng trắng", "Thông báo", MessageBoxButtons.OK);
                txtDIACHI.Focus(); return false;
            }
            if (txtDIACHI.Text.Length > 100)
            {
                MessageBox.Show("Địa chỉ quá dài", "Thông báo", MessageBoxButtons.OK);
                txtDIACHI.Focus(); return false;
            }

            if (CalculateAge(dteNGAYSINH.Value) < 18)
            {
                MessageBox.Show("Nhân viên chưa đủ 18 tuổi", "Thông báo", MessageBoxButtons.OK);
                dteNGAYSINH.Focus(); return false;
            }

            if (txtLUONG.Value < 4000000 || txtLUONG.Value == 0)
            {
                MessageBox.Show("Mức lương không thể bỏ trống & tối thiểu 4.000.000 đồng", "Thông báo", MessageBoxButtons.OK);
                txtLUONG.Focus(); return false;
            }
            return true;
        }

        private void btnGHI_Click(object sender, EventArgs e)
        {
            bool ketQua = kiemTraDuLieuDauVao();
            if (!ketQua) return;
           // bdsNhanVien.EndEdit();              // commit binding của control hiện tại
          //  var cm = (CurrencyManager)bdsNhanVien.CurrencyManager;
          //  cm.EndCurrentEdit();
            string maNhanVien = txtMANV.Text.Trim();
            DataRowView drv = ((DataRowView)bdsNhanVien[bdsNhanVien.Position]);
            string ho = drv["HO"].ToString();
            string ten = drv["TEN"].ToString();
            string diaChi = drv["DIACHI"].ToString();
            DateTime ngaySinh = ((DateTime)drv["NGAYSINH"]);
            int luong = int.Parse(drv["LUONG"].ToString());
            int trangThai = (trangThaiXoaCheckBox.Checked == true) ? 1 : 0;

            string cauTruyVan =
                "DECLARE @result int " +
                "EXEC @result = [dbo].[sp_TraCuu_KiemTraMaNhanVien] '" + maNhanVien + "' " +
                "SELECT 'Value' = @result";

            try
            {
                Program.myReader = Program.ExecSqlDataReader(cauTruyVan);
                if (Program.myReader == null) return;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thực thi database thất bại!\n\n" + ex.Message, "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Program.myReader.Read();
            int result = int.Parse(Program.myReader.GetValue(0).ToString());
            Program.myReader.Close();

            int viTriConTro = bdsNhanVien.Position;
            int viTriMaNhanVien = bdsNhanVien.Find("MANV", txtMANV.Text);

            if (result == 1 && viTriConTro != viTriMaNhanVien)
            {
                MessageBox.Show("Mã nhân viên này đã được sử dụng !", "Thông báo", MessageBoxButtons.OK);
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
                        btnTHEM.Enabled = true;
                        btnXOA.Enabled = true;
                        btnGHI.Enabled = true;
                        btnHOANTAC.Enabled = true;

                        btnLAMMOI.Enabled = true;
                        btnCHUYENCHINHANH.Enabled = true;
                        btnTHOAT.Enabled = true;

                        txtMANV.Enabled = false;
                        bdsNhanVien.EndEdit();
                        nhanVienTableAdapter.Update(this.dataSet.NhanVien);
                        dgvNhanVien.Enabled = true;

                        string cauTruyVanHoanTac = "";
                        if (dangThemMoi == true)
                        {
                            cauTruyVanHoanTac =
                                "DELETE DBO.NHANVIEN WHERE MANV = " + txtMANV.Text.Trim();
                        }
                        else
                        {
                            cauTruyVanHoanTac =
                                "UPDATE DBO.NhanVien SET " +
                                "HO = '" + ho + "'," +
                                "TEN = '" + ten + "'," +
                                "DIACHI = '" + diaChi + "'," +
                                "NGAYSINH = CAST('" + ngaySinh.ToString("yyyy-MM-dd") + "' AS DATETIME)," +
                                "LUONG = '" + luong + "'," +
                                "TrangThaiXoa = " + trangThai + " " +
                                "WHERE MANV = '" + maNhanVien + "'";
                        }
                        undoList.Push(cauTruyVanHoanTac);
                        dangThemMoi = false;
                        MessageBox.Show("Ghi thành công", "Thông báo", MessageBoxButtons.OK);
                    }
                    catch (Exception ex)
                    {
                        bdsNhanVien.RemoveCurrent();
                        MessageBox.Show("Thất bại. Vui lòng kiểm tra lại!\n" + ex.Message, "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        public void chuyenChiNhanh(string chiNhanh)
        {
            if (Program.serverName == chiNhanh)
            {
                MessageBox.Show("Hãy chọn chi nhánh khác chi nhánh bạn đang đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int viTriHienTai = bdsNhanVien.Position;
            string maNhanVien = ((DataRowView)bdsNhanVien[viTriHienTai])["MANV"].ToString();

            string maChiNhanhHienTai = chiNhanh.Contains("1") ? "CN2" : "CN1";
            string maChiNhanhMoi = chiNhanh.Contains("1") ? "CN1" : "CN2";

            string cauTruyVanHoanTac = "EXEC sp_ChuyenChiNhanh " + maNhanVien + ",'" + maChiNhanhHienTai + "'";
            undoList.Push(cauTruyVanHoanTac);
            Program.serverNameLeft = chiNhanh;

            string cauTruyVan = "EXEC sp_ChuyenChiNhanh " + maNhanVien + ",'" + maChiNhanhMoi + "'";
            try
            {
                Program.myReader = Program.ExecSqlDataReader(cauTruyVan);
                MessageBox.Show("Chuyển chi nhánh thành công", "thông báo", MessageBoxButtons.OK);
                if (Program.myReader == null) return;
            }
            catch (Exception ex)
            {
                MessageBox.Show("thực thi database thất bại!\n\n" + ex.Message, "thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.nhanVienTableAdapter.Update(this.dataSet.NhanVien);
        }

        private void btnCHUYENCHINHANH_Click(object sender, EventArgs e)
        {
            using (var dlg = new Form())
            {
                dlg.Text = "Chọn chi nhánh đích (demo)";
                dlg.StartPosition = FormStartPosition.CenterParent;
                var txt = new TextBox() { Dock = DockStyle.Top, Text = "SERVER2" };
                var ok = new Button() { Dock = DockStyle.Bottom, Text = "OK", DialogResult = DialogResult.OK };
                dlg.Controls.Add(txt); dlg.Controls.Add(ok);
                if (dlg.ShowDialog(this) == DialogResult.OK)
                {
                    chuyenChiNhanh(txt.Text);
                }
            }
        }
    }
}