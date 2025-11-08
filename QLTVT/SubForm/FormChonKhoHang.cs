using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTVT.SubForm
{
    public partial class FormChonKhoHang : Form
    {
        public FormChonKhoHang()
        {
            InitializeComponent();
        }

        private void khoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsKhoHang.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet);

        }

        private void FormChonKhoHang_Load(object sender, EventArgs e)
        {
            /*không kiểm tra khóa ngoại nữa*/
            dataSet.EnforceConstraints = false;
            this.khoHangTableAdapter.Connection.ConnectionString = Program.connstr;
            this.khoHangTableAdapter.Fill(this.dataSet.Kho);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (bdsKhoHang.Current == null)
                {
                    MessageBox.Show("Vui lòng chọn một kho hàng từ danh sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DataRowView drv = (DataRowView)bdsKhoHang.Current;
                string maKhoHang = drv["MAKHO"].ToString();
                
                // Thử các tên cột có thể có
                string tenKhoHang = "";
                if (drv.Row.Table.Columns.Contains("TENKHO"))
                    tenKhoHang = drv["TENKHO"].ToString();
                else if (drv.Row.Table.Columns.Contains("TenKho"))
                    tenKhoHang = drv["TenKho"].ToString();
                else if (drv.Row.Table.Columns.Contains("DIACHI"))
                    tenKhoHang = drv["DIACHI"].ToString(); // Có thể dùng địa chỉ
                else
                {
                    // Debug: hiển thị tất cả tên cột
                    string cols = "";
                    foreach (DataColumn col in drv.Row.Table.Columns)
                        cols += col.ColumnName + ", ";
                    MessageBox.Show("Các cột có sẵn: " + cols, "Debug");
                    tenKhoHang = maKhoHang; // Fallback: dùng mã kho làm tên
                }

                Program.maKhoDuocChon = maKhoHang;
                Program.tenKhoDuocChon = tenKhoHang;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy thông tin kho: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
