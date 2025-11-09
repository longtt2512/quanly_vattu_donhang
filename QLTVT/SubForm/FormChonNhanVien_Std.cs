using System;
using System.Data;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Linq;
using System.Data.SqlClient;

namespace QLTVT.SubForm
{
    // WinForms chuẩn: không dùng DevExpress
    public partial class FormChonNhanVien_Std : Form
    {
        public FormChonNhanVien_Std()
        {
            InitializeComponent();
            // UX
            this.AcceptButton = btnCHON;
            this.CancelButton = btnTHOAT;
        }

        private void FormChonNhanVien_Load(object sender, EventArgs e)
        {
            dataSet.EnforceConstraints = false;
            this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
            this.nhanVienTableAdapter.Fill(this.dataSet.NhanVien);

            // sao chép binding source từ form đăng nhập
            cmbCHINHANH.DataSource = Program.bindingSource;
            cmbCHINHANH.DisplayMember = "TENCN";
            cmbCHINHANH.ValueMember = "TENSERVER";
            cmbCHINHANH.SelectedIndex = Program.brand;

            if (Program.role == "CONGTY")
                cmbCHINHANH.Enabled = true;
            else
                cmbCHINHANH.Enabled = false;
        }

        private void cmbCHINHANH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCHINHANH.SelectedValue == null) return;
            if (cmbCHINHANH.SelectedValue.ToString() == "System.Data.DataRowView") return;

            Program.serverName = cmbCHINHANH.SelectedValue.ToString();

            // nếu chọn sang chi nhánh khác
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
            }
        }

        private void btnCHON_Click(object sender, EventArgs e)
        {
            if (bdsNhanVien.Current == null)
            {
                MessageBox.Show("Chưa chọn nhân viên.", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            DataRowView drv = (DataRowView)bdsNhanVien.Current;
            string maNhanVien = drv["MANV"].ToString().Trim();
            string ho = drv["HO"].ToString().Trim();
            string ten = drv["TEN"].ToString().Trim();
            string hoTen = (ho + " " + ten).Trim();
            string diaChi = drv["DIACHI"].ToString().Trim();

            string ngaySinh = "";
            if (drv["NGAYSINH"] != DBNull.Value)
            {
                try
                {
                    ngaySinh = Convert.ToDateTime(drv["NGAYSINH"]).ToString("dd-MM-yyyy");
                }
                catch
                {
                    ngaySinh = drv["NGAYSINH"].ToString();
                }
            }

            Program.maNhanVienDuocChon = maNhanVien;


            Program.taiKhoan = GenerateUsernameVN(ho+" "+ten);
            string uniqueUser = EnsureUnique(Program.taiKhoan, u => ServerLoginExistsByProc(u));

            Program.taiKhoan = uniqueUser;


            Program.hoTen = hoTen;
            Program.ngaySinh = ngaySinh;
            Program.diaChi = diaChi;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnTHOAT_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        // Bỏ dấu tiếng Việt (kể cả Đ/đ)
        public static string RemoveVietnameseDiacritics(string input)
        {
            if (string.IsNullOrWhiteSpace(input)) return string.Empty;
            input = input.Replace('Đ', 'D').Replace('đ', 'd');
            var norm = input.Normalize(NormalizationForm.FormD);
            var sb = new StringBuilder();

            foreach (var ch in norm)
            {
                var uc = System.Globalization.CharUnicodeInfo.GetUnicodeCategory(ch);
                if (uc != System.Globalization.UnicodeCategory.NonSpacingMark)
                    sb.Append(ch);
            }
            return sb.ToString().Normalize(NormalizationForm.FormC);
        }

        public static string GenerateUsernameVN(string fullName)
        {
            if (string.IsNullOrWhiteSpace(fullName)) return string.Empty;

            var cleaned = Regex.Replace(fullName.Trim(), @"\s+", " ");
            var parts = cleaned.Split(' ');
            if (parts.Length == 1)
            {
                return RemoveVietnameseDiacritics(parts[0]).ToLowerInvariant();
            }

            var last = parts[parts.Length - 1];  // tên cuối
            var first = parts[0];                // họ
            var middles = parts.Skip(1).Take(parts.Length - 2); // tên đệm (nếu có)

            var lastAscii = RemoveVietnameseDiacritics(last).ToLowerInvariant();
            var firstInitial = RemoveVietnameseDiacritics(first)[0].ToString().ToLowerInvariant();
            var middleInitials = string.Concat(middles
                .Where(s => !string.IsNullOrWhiteSpace(s))
                .Select(s => RemoveVietnameseDiacritics(s)[0]))
                .ToLowerInvariant();

            var user = Regex.Replace(lastAscii + firstInitial + middleInitials, @"[^a-z0-9]", "");
            return user;
        }

        public static string EnsureUnique(string baseUser, Func<string, bool> exists)
        {
            if (!exists(baseUser)) return baseUser;
            int i = 1;
            while (exists(baseUser + i)) i++;
            return baseUser + i;  // ví dụ dodt1, dodt2,...
        }
        private bool ServerLoginExistsByProc(string loginName)
        {


            string cauTruyVan =
              "DECLARE @result int " +
              "EXEC @result = [dbo].[sp_TraCuu_KiemTraLoginTonTai] '" + loginName + "' " +
              "SELECT 'Value' = @result";

            try
            {
                Program.myReader = Program.ExecSqlDataReader(cauTruyVan);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kiểm tra Login!\n\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            Program.myReader.Read();
            int result = int.Parse(Program.myReader.GetValue(0).ToString());
            Program.myReader.Close();
            bool tonTai = false;
            tonTai = (result == 1);         
                return tonTai;      
        }
    }
}