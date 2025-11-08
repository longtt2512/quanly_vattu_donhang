using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace QLTVT
{
    public partial class FormDangNhap_Std : Form
    {
        private SqlConnection connPublisher = new SqlConnection();

        public FormDangNhap_Std()
        {
            InitializeComponent();
            // UX chuẩn WinForms
            this.AcceptButton = btnDANGNHAP; // Enter để đăng nhập
            this.CancelButton = btnTHOAT;    // Esc để thoát
            txtMATKHAU.UseSystemPasswordChar = true;
        }

        private int KetNoiDatabaseGoc()
        {
            if (connPublisher != null && connPublisher.State == ConnectionState.Open)
                connPublisher.Close();
            try
            {
                connPublisher.ConnectionString = Program.connstrPublisher;
                connPublisher.Open();
                return 1;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu.\n" + e.Message, "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        private void layDanhSachPhanManh(String cmd)
        {
            if (connPublisher.State == ConnectionState.Closed) connPublisher.Open();
            DataTable dt = new DataTable();
            using (SqlDataAdapter da = new SqlDataAdapter(cmd, connPublisher))
            {
                da.Fill(dt);
            }
            connPublisher.Close();

            Program.bindingSource.DataSource = dt;
            cmbCHINHANH.DataSource = Program.bindingSource;
            cmbCHINHANH.DisplayMember = "TENCN";
            cmbCHINHANH.ValueMember = "TENSERVER";
        }

        private void FormDangNhap_Std_Load(object sender, EventArgs e)
        {
            // (Tuỳ chọn) Điền mặc định để test nhanh
            txtTAIKHOAN.Text = "TT";
            txtMATKHAU.Text = "123456";

            if (KetNoiDatabaseGoc() == 0) return;
            layDanhSachPhanManh("SELECT TOP 2 * FROM view_DanhSachPhanManh");
            if (cmbCHINHANH.Items.Count > 0)
            {
                cmbCHINHANH.SelectedIndex = 0;
                if (cmbCHINHANH.Items.Count > 1)
                {
                    cmbCHINHANH.SelectedIndex = 0;
                    Program.serverName = cmbCHINHANH.SelectedValue.ToString();
                }
            }
        }

        private void cmbCHINHANH_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbCHINHANH.SelectedValue != null)
                    Program.serverName = cmbCHINHANH.SelectedValue.ToString();
            }
            catch
            {
                // ignore binding race
            }
        }

        private void btnDANGNHAP_Click(object sender, EventArgs e)
        {
            if (txtTAIKHOAN.Text.Trim() == "" || txtMATKHAU.Text.Trim() == "")
            {
                MessageBox.Show("Tài khoản & mật khẩu không thể bỏ trống", "Thông Báo", MessageBoxButtons.OK);
                return;
            }

            Program.loginName = txtTAIKHOAN.Text.Trim();
            Program.loginPassword = txtMATKHAU.Text.Trim();
            if (Program.KetNoi() == 0) return;

            Program.brand = cmbCHINHANH.SelectedIndex;
            Program.currentLogin = Program.loginName;
            Program.currentPassword = Program.loginPassword;

            string statement = "EXEC sp_DangNhap '" + Program.loginName + "'";
            Program.myReader = Program.ExecSqlDataReader(statement);
            if (Program.myReader == null) return;

            Program.myReader.Read();
            Program.userName = Program.myReader.GetString(0);
            if (Convert.IsDBNull(Program.userName))
            {
                MessageBox.Show("Tài khoản này không có quyền truy cập.\nHãy thử tài khoản khác.",
                    "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Program.myReader.Close();
                return;
            }

            Program.staff = Program.myReader.GetString(1);
            Program.role = Program.myReader.GetString(2);
            Program.myReader.Close();
            Program.conn.Close();

            // Cập nhật status tại Form chính
            if (Program.formChinh != null)
            {
                Program.formChinh.MANHANVIEN.Text = "MÃ NHÂN VIÊN: " + Program.userName;
                Program.formChinh.HOTEN.Text = "HỌ TÊN: " + Program.staff;
                Program.formChinh.NHOM.Text = "VAI TRÒ: " + Program.role;
                Program.formChinh.enableButtons();
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnTHOAT_Click(object sender, EventArgs e)
        {
            this.Close();
            if (Program.formChinh != null) Program.formChinh.Close();
        }
    }
}