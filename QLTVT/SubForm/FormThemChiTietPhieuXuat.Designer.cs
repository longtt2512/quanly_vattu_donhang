namespace QLTVT.SubForm
{
    partial class FormThemChiTietPhieuXuat
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtMaVatTu = new DevExpress.XtraEditors.TextEdit();
            this.txtSoLuong = new System.Windows.Forms.NumericUpDown();
            this.txtDonGia = new System.Windows.Forms.NumericUpDown();
            this.btnChonVatTu = new System.Windows.Forms.Button();
            this.btnCHON = new System.Windows.Forms.Button();
            this.btnTHOAT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaVatTu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonGia)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMaVatTu
            // 
            this.txtMaVatTu.Location = new System.Drawing.Point(270, 46);
            this.txtMaVatTu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaVatTu.Name = "txtMaVatTu";
            // 
            // 
            // 
            this.txtMaVatTu.Properties.ReadOnly = true;
            this.txtMaVatTu.Size = new System.Drawing.Size(225, 28);
            this.txtMaVatTu.TabIndex = 0;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(270, 108);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSoLuong.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(375, 26);
            this.txtSoLuong.TabIndex = 2;
            this.txtSoLuong.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // txtDonGia
            // 
            this.txtDonGia.Increment = new decimal(new int[] { 1000, 0, 0, 0 });
            this.txtDonGia.Location = new System.Drawing.Point(270, 169);
            this.txtDonGia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDonGia.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            this.txtDonGia.Minimum = new decimal(new int[] { 1000, 0, 0, 0 });
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(375, 26);
            this.txtDonGia.TabIndex = 3;
            this.txtDonGia.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            // 
            // btnChonVatTu
            // 
            this.btnChonVatTu.Location = new System.Drawing.Point(510, 43);
            this.btnChonVatTu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnChonVatTu.Name = "btnChonVatTu";
            this.btnChonVatTu.Size = new System.Drawing.Size(135, 37);
            this.btnChonVatTu.TabIndex = 1;
            this.btnChonVatTu.Text = "Chọn Vật Tư";
            this.btnChonVatTu.UseVisualStyleBackColor = true;
            this.btnChonVatTu.Click += new System.EventHandler(this.btnChonVatTu_Click);
            // 
            // btnCHON
            // 
            this.btnCHON.Location = new System.Drawing.Point(270, 246);
            this.btnCHON.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCHON.Name = "btnCHON";
            this.btnCHON.Size = new System.Drawing.Size(150, 54);
            this.btnCHON.TabIndex = 4;
            this.btnCHON.Text = "Chọn";
            this.btnCHON.UseVisualStyleBackColor = true;
            this.btnCHON.Click += new System.EventHandler(this.btnCHON_Click);
            // 
            // btnTHOAT
            // 
            this.btnTHOAT.Location = new System.Drawing.Point(495, 246);
            this.btnTHOAT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTHOAT.Name = "btnTHOAT";
            this.btnTHOAT.Size = new System.Drawing.Size(150, 54);
            this.btnTHOAT.TabIndex = 5;
            this.btnTHOAT.Text = "Thoát";
            this.btnTHOAT.UseVisualStyleBackColor = true;
            this.btnTHOAT.Click += new System.EventHandler(this.btnTHOAT_Click);
            // 
            // FormThemChiTietPhieuXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 340);
            this.Controls.Add(this.btnTHOAT);
            this.Controls.Add(this.btnCHON);
            this.Controls.Add(this.btnChonVatTu);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.txtMaVatTu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormThemChiTietPhieuXuat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm Chi Tiết Phiếu Xuất";
            this.Load += new System.EventHandler(this.FormThemChiTietPhieuXuat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtMaVatTu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonGia)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtMaVatTu;
        private System.Windows.Forms.NumericUpDown txtSoLuong;
        private System.Windows.Forms.NumericUpDown txtDonGia;
        private System.Windows.Forms.Button btnChonVatTu;
        private System.Windows.Forms.Button btnCHON;
        private System.Windows.Forms.Button btnTHOAT;
    }
}
