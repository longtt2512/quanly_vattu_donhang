namespace QLTVT
{
    partial class FormDangNhap_Std
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.cmbCHINHANH = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTAIKHOAN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMATKHAU = new System.Windows.Forms.TextBox();
            this.btnDANGNHAP = new System.Windows.Forms.Button();
            this.btnTHOAT = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbCHINHANH
            // 
            this.cmbCHINHANH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCHINHANH.FormattingEnabled = true;
            this.cmbCHINHANH.Location = new System.Drawing.Point(149, 68);
            this.cmbCHINHANH.Name = "cmbCHINHANH";
            this.cmbCHINHANH.Size = new System.Drawing.Size(256, 22);
            this.cmbCHINHANH.TabIndex = 0;
            this.cmbCHINHANH.SelectedIndexChanged += new System.EventHandler(this.cmbCHINHANH_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 7.8F);
            this.label1.Location = new System.Drawing.Point(39, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "CHI NHÁNH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "TÀI KHOẢN";
            // 
            // txtTAIKHOAN
            // 
            this.txtTAIKHOAN.Location = new System.Drawing.Point(149, 111);
            this.txtTAIKHOAN.Name = "txtTAIKHOAN";
            this.txtTAIKHOAN.Size = new System.Drawing.Size(256, 22);
            this.txtTAIKHOAN.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 14);
            this.label3.TabIndex = 5;
            this.label3.Text = "MẬT KHẨU";
            // 
            // txtMATKHAU
            // 
            this.txtMATKHAU.Location = new System.Drawing.Point(149, 159);
            this.txtMATKHAU.Name = "txtMATKHAU";
            this.txtMATKHAU.PasswordChar = '•';
            this.txtMATKHAU.Size = new System.Drawing.Size(256, 22);
            this.txtMATKHAU.TabIndex = 4;
            // 
            // btnDANGNHAP
            // 
            this.btnDANGNHAP.BackColor = System.Drawing.Color.SteelBlue;
            this.btnDANGNHAP.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnDANGNHAP.ForeColor = System.Drawing.Color.White;
            this.btnDANGNHAP.Location = new System.Drawing.Point(12, 246);
            this.btnDANGNHAP.Name = "btnDANGNHAP";
            this.btnDANGNHAP.Size = new System.Drawing.Size(195, 40);
            this.btnDANGNHAP.TabIndex = 6;
            this.btnDANGNHAP.Text = "ĐĂNG NHẬP";
            this.btnDANGNHAP.UseVisualStyleBackColor = false;
            this.btnDANGNHAP.Click += new System.EventHandler(this.btnDANGNHAP_Click);
            // 
            // btnTHOAT
            // 
            this.btnTHOAT.BackColor = System.Drawing.Color.Firebrick;
            this.btnTHOAT.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnTHOAT.ForeColor = System.Drawing.Color.White;
            this.btnTHOAT.Location = new System.Drawing.Point(229, 246);
            this.btnTHOAT.Name = "btnTHOAT";
            this.btnTHOAT.Size = new System.Drawing.Size(195, 40);
            this.btnTHOAT.TabIndex = 7;
            this.btnTHOAT.Text = "THOÁT";
            this.btnTHOAT.UseVisualStyleBackColor = false;
            this.btnTHOAT.Click += new System.EventHandler(this.btnTHOAT_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(104, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 26);
            this.label4.TabIndex = 8;
            this.label4.Text = "QUẢN LÝ VẬT TƯ";
            // 
            // FormDangNhap_Std
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 350);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnTHOAT);
            this.Controls.Add(this.btnDANGNHAP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMATKHAU);
            this.Controls.Add(this.txtTAIKHOAN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbCHINHANH);
            this.Font = new System.Drawing.Font("Tahoma", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDangNhap_Std";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            this.Load += new System.EventHandler(this.FormDangNhap_Std_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.ComboBox cmbCHINHANH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTAIKHOAN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMATKHAU;
        private System.Windows.Forms.Button btnDANGNHAP;
        private System.Windows.Forms.Button btnTHOAT;
        private System.Windows.Forms.Label label4;
    }
}