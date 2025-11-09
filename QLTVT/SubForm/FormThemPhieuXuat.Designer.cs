namespace QLTVT.SubForm
{
    partial class FormThemPhieuXuat
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
            this.txtMaPhieuXuat = new DevExpress.XtraEditors.TextEdit();
            this.txtMaKho = new DevExpress.XtraEditors.TextEdit();
            this.txtTenKhachHang = new DevExpress.XtraEditors.TextEdit();
            this.dteNgay = new DevExpress.XtraEditors.DateEdit();
            this.btnChonKhoHang = new System.Windows.Forms.Button();
            this.btnCHON = new System.Windows.Forms.Button();
            this.btnTHOAT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaPhieuXuat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKho.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenKhachHang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNgay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNgay.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMaPhieuXuat
            // 
            this.txtMaPhieuXuat.Location = new System.Drawing.Point(180, 30);
            this.txtMaPhieuXuat.Name = "txtMaPhieuXuat";
            this.txtMaPhieuXuat.Size = new System.Drawing.Size(250, 20);
            this.txtMaPhieuXuat.TabIndex = 0;
            // 
            // txtMaKho
            // 
            this.txtMaKho.Location = new System.Drawing.Point(180, 70);
            this.txtMaKho.Name = "txtMaKho";
            this.txtMaKho.Properties.ReadOnly = true;
            this.txtMaKho.Size = new System.Drawing.Size(150, 20);
            this.txtMaKho.TabIndex = 1;
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.Location = new System.Drawing.Point(180, 110);
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.Size = new System.Drawing.Size(250, 20);
            this.txtTenKhachHang.TabIndex = 3;
            // 
            // dteNgay
            // 
            this.dteNgay.EditValue = null;
            this.dteNgay.Location = new System.Drawing.Point(180, 150);
            this.dteNgay.Name = "dteNgay";
            this.dteNgay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteNgay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteNgay.Size = new System.Drawing.Size(250, 20);
            this.dteNgay.TabIndex = 4;
            // 
            // btnChonKhoHang
            // 
            this.btnChonKhoHang.Location = new System.Drawing.Point(340, 68);
            this.btnChonKhoHang.Name = "btnChonKhoHang";
            this.btnChonKhoHang.Size = new System.Drawing.Size(90, 24);
            this.btnChonKhoHang.TabIndex = 2;
            this.btnChonKhoHang.Text = "Chọn Kho";
            this.btnChonKhoHang.UseVisualStyleBackColor = true;
            this.btnChonKhoHang.Click += new System.EventHandler(this.btnChonKhoHang_Click);
            // 
            // btnCHON
            // 
            this.btnCHON.Location = new System.Drawing.Point(180, 200);
            this.btnCHON.Name = "btnCHON";
            this.btnCHON.Size = new System.Drawing.Size(100, 35);
            this.btnCHON.TabIndex = 5;
            this.btnCHON.Text = "Chọn";
            this.btnCHON.UseVisualStyleBackColor = true;
            this.btnCHON.Click += new System.EventHandler(this.btnCHON_Click);
            // 
            // btnTHOAT
            // 
            this.btnTHOAT.Location = new System.Drawing.Point(330, 200);
            this.btnTHOAT.Name = "btnTHOAT";
            this.btnTHOAT.Size = new System.Drawing.Size(100, 35);
            this.btnTHOAT.TabIndex = 6;
            this.btnTHOAT.Text = "Thoát";
            this.btnTHOAT.UseVisualStyleBackColor = true;
            this.btnTHOAT.Click += new System.EventHandler(this.btnTHOAT_Click);
            // 
            // FormThemPhieuXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.btnTHOAT);
            this.Controls.Add(this.btnCHON);
            this.Controls.Add(this.btnChonKhoHang);
            this.Controls.Add(this.dteNgay);
            this.Controls.Add(this.txtTenKhachHang);
            this.Controls.Add(this.txtMaKho);
            this.Controls.Add(this.txtMaPhieuXuat);
            this.Controls.Add(new System.Windows.Forms.Label() { Text = "Mã Phiếu Xuất:", Location = new System.Drawing.Point(30, 33), AutoSize = true });
            this.Controls.Add(new System.Windows.Forms.Label() { Text = "Mã Kho:", Location = new System.Drawing.Point(30, 73), AutoSize = true });
            this.Controls.Add(new System.Windows.Forms.Label() { Text = "Tên Khách Hàng:", Location = new System.Drawing.Point(30, 113), AutoSize = true });
            this.Controls.Add(new System.Windows.Forms.Label() { Text = "Ngày Xuất:", Location = new System.Drawing.Point(30, 153), AutoSize = true });
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormThemPhieuXuat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm Phiếu Xuất";
            this.Load += new System.EventHandler(this.FormThemPhieuXuat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtMaPhieuXuat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKho.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenKhachHang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNgay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNgay.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtMaPhieuXuat;
        private DevExpress.XtraEditors.TextEdit txtMaKho;
        private DevExpress.XtraEditors.TextEdit txtTenKhachHang;
        private DevExpress.XtraEditors.DateEdit dteNgay;
        private System.Windows.Forms.Button btnChonKhoHang;
        private System.Windows.Forms.Button btnCHON;
        private System.Windows.Forms.Button btnTHOAT;
    }
}
