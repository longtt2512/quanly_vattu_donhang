using System.ComponentModel;

namespace QLTVT.SubForm
{
    partial class FormThemPhieuNhap
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
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaPhieuNhap = new System.Windows.Forms.TextBox();
            this.txtMaDonDatHang = new System.Windows.Forms.TextBox();
            this.btnChonDonDatHang = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Đơn đặt hàng *";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã phiếu nhập *";
            // 
            // txtMaPhieuNhap
            // 
            this.txtMaPhieuNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtMaPhieuNhap.Location = new System.Drawing.Point(196, 96);
            this.txtMaPhieuNhap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaPhieuNhap.MaxLength = 50;
            this.txtMaPhieuNhap.Name = "txtMaPhieuNhap";
            this.txtMaPhieuNhap.Size = new System.Drawing.Size(314, 28);
            this.txtMaPhieuNhap.TabIndex = 1;
            // 
            // txtMaDonDatHang
            // 
            this.txtMaDonDatHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtMaDonDatHang.Location = new System.Drawing.Point(196, 140);
            this.txtMaDonDatHang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaDonDatHang.Name = "txtMaDonDatHang";
            this.txtMaDonDatHang.ReadOnly = true;
            this.txtMaDonDatHang.Size = new System.Drawing.Size(168, 28);
            this.txtMaDonDatHang.TabIndex = 3;
            // 
            // btnChonDonDatHang
            // 
            this.btnChonDonDatHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnChonDonDatHang.Location = new System.Drawing.Point(376, 138);
            this.btnChonDonDatHang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnChonDonDatHang.Name = "btnChonDonDatHang";
            this.btnChonDonDatHang.Size = new System.Drawing.Size(135, 35);
            this.btnChonDonDatHang.TabIndex = 5;
            this.btnChonDonDatHang.Text = "Chọn DDH...";
            this.btnChonDonDatHang.UseVisualStyleBackColor = true;
            this.btnChonDonDatHang.Click += new System.EventHandler(this.btnChonDonDatHang_Click);
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnOK.ForeColor = System.Drawing.Color.White;
            this.btnOK.Location = new System.Drawing.Point(264, 215);
            this.btnOK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(112, 44);
            this.btnOK.TabIndex = 7;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnHuy.Location = new System.Drawing.Point(399, 215);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(112, 44);
            this.btnHuy.TabIndex = 8;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(548, 60);
            this.panel1.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(140, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(276, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "Thêm Phiếu Nhập";
            // 
            // FormThemPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 280);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnChonDonDatHang);
            this.Controls.Add(this.txtMaDonDatHang);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMaPhieuNhap);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormThemPhieuNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm Phiếu Nhập";
            this.Load += new System.EventHandler(this.FormThemPhieuNhap_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaPhieuNhap;
        private System.Windows.Forms.TextBox txtMaDonDatHang;
        private System.Windows.Forms.Button btnChonDonDatHang;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
    }
}
