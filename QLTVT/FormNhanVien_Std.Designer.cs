namespace QLTVT
{
    partial class FormNhanVien_Std
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label mANVLabel;
            System.Windows.Forms.Label hOLabel;
            System.Windows.Forms.Label tENLabel;
            System.Windows.Forms.Label mACNLabel;
            System.Windows.Forms.Label dIACHILabel;
            System.Windows.Forms.Label lUONGLabel;
            System.Windows.Forms.Label trangThaiXoaLabel;
            System.Windows.Forms.Label nGAYSINHLabel;
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnTHEM = new System.Windows.Forms.ToolStripMenuItem();
            this.btnXOA = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGHI = new System.Windows.Forms.ToolStripMenuItem();
            this.btnHOANTAC = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLAMMOI = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCHUYENCHINHANH = new System.Windows.Forms.ToolStripMenuItem();
            this.btnTHOAT = new System.Windows.Forms.ToolStripMenuItem();
            this.panelTop = new System.Windows.Forms.Panel();
            this.cmbCHINHANH = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.tabDetails = new System.Windows.Forms.TabControl();
            this.tabDatHang = new System.Windows.Forms.TabPage();
            this.dgvDatHang = new System.Windows.Forms.DataGridView();
            this.tabPhieuNhap = new System.Windows.Forms.TabPage();
            this.dgvPhieuNhap = new System.Windows.Forms.DataGridView();
            this.tabPhieuXuat = new System.Windows.Forms.TabPage();
            this.dgvPhieuXuat = new System.Windows.Forms.DataGridView();
            this.panelNhapLieu = new System.Windows.Forms.Panel();
            this.dteNGAYSINH = new System.Windows.Forms.DateTimePicker();
            this.trangThaiXoaCheckBox = new System.Windows.Forms.CheckBox();
            this.txtLUONG = new System.Windows.Forms.NumericUpDown();
            this.txtDIACHI = new System.Windows.Forms.TextBox();
            this.txtMACN = new System.Windows.Forms.TextBox();
            this.txtTEN = new System.Windows.Forms.TextBox();
            this.txtHO = new System.Windows.Forms.TextBox();
            this.txtMANV = new System.Windows.Forms.TextBox();
            this.dataSet = new QLTVT.DataSet();
            this.bdsNhanVien = new System.Windows.Forms.BindingSource(this.components);
            this.nhanVienTableAdapter = new QLTVT.DataSetTableAdapters.NhanVienTableAdapter();
            this.tableAdapterManager = new QLTVT.DataSetTableAdapters.TableAdapterManager();
            this.datHangTableAdapter = new QLTVT.DataSetTableAdapters.DatHangTableAdapter();
            this.phieuNhapTableAdapter = new QLTVT.DataSetTableAdapters.PhieuNhapTableAdapter();
            this.phieuXuatTableAdapter = new QLTVT.DataSetTableAdapters.PhieuXuatTableAdapter();
            this.bdsDatHang = new System.Windows.Forms.BindingSource(this.components);
            this.bdsPhieuNhap = new System.Windows.Forms.BindingSource(this.components);
            this.bdsPhieuXuat = new System.Windows.Forms.BindingSource(this.components);
            mANVLabel = new System.Windows.Forms.Label();
            hOLabel = new System.Windows.Forms.Label();
            tENLabel = new System.Windows.Forms.Label();
            mACNLabel = new System.Windows.Forms.Label();
            dIACHILabel = new System.Windows.Forms.Label();
            lUONGLabel = new System.Windows.Forms.Label();
            trangThaiXoaLabel = new System.Windows.Forms.Label();
            nGAYSINHLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.tabDetails.SuspendLayout();
            this.tabDatHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatHang)).BeginInit();
            this.tabPhieuNhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuNhap)).BeginInit();
            this.tabPhieuXuat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuXuat)).BeginInit();
            this.panelNhapLieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtLUONG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDatHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPhieuNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPhieuXuat)).BeginInit();
            this.SuspendLayout();
            // 
            // labels
            // 
            mANVLabel.AutoSize = true; mANVLabel.Location = new System.Drawing.Point(40, 20); mANVLabel.Text = "MANV:";
            hOLabel.AutoSize = true; hOLabel.Location = new System.Drawing.Point(260, 20); hOLabel.Text = "HO:";
            tENLabel.AutoSize = true; tENLabel.Location = new System.Drawing.Point(520, 20); tENLabel.Text = "TEN:";
            mACNLabel.AutoSize = true; mACNLabel.Location = new System.Drawing.Point(720, 20); mACNLabel.Text = "MACN:";
            dIACHILabel.AutoSize = true; dIACHILabel.Location = new System.Drawing.Point(40, 90); dIACHILabel.Text = "DIACHI:";
            nGAYSINHLabel.AutoSize = true; nGAYSINHLabel.Location = new System.Drawing.Point(260, 90); nGAYSINHLabel.Text = "NGAYSINH:";
            lUONGLabel.AutoSize = true; lUONGLabel.Location = new System.Drawing.Point(520, 90); lUONGLabel.Text = "LUONG:";
            trangThaiXoaLabel.AutoSize = true; trangThaiXoaLabel.Location = new System.Drawing.Point(720, 92); trangThaiXoaLabel.Text = "Trang Thai Xoa:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnTHEM,
            this.btnXOA,
            this.btnGHI,
            this.btnHOANTAC,
            this.btnLAMMOI,
            this.btnCHUYENCHINHANH,
            this.btnTHOAT});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1100, 28);
            this.menuStrip1.TabIndex = 0;
            // 
            // menu items
            // 
            this.btnTHEM.Name = "btnTHEM"; this.btnTHEM.Size = new System.Drawing.Size(61, 24); this.btnTHEM.Text = "Thêm"; this.btnTHEM.Click += new System.EventHandler(this.btnTHEM_Click);
            this.btnXOA.Name = "btnXOA"; this.btnXOA.Size = new System.Drawing.Size(47, 24); this.btnXOA.Text = "Xóa"; this.btnXOA.Click += new System.EventHandler(this.btnXOA_Click);
            this.btnGHI.Name = "btnGHI"; this.btnGHI.Size = new System.Drawing.Size(45, 24); this.btnGHI.Text = "Ghi"; this.btnGHI.Click += new System.EventHandler(this.btnGHI_Click);
            this.btnHOANTAC.Name = "btnHOANTAC"; this.btnHOANTAC.Size = new System.Drawing.Size(86, 24); this.btnHOANTAC.Text = "Hoàn tác"; this.btnHOANTAC.Click += new System.EventHandler(this.btnHOANTAC_Click);
            this.btnLAMMOI.Name = "btnLAMMOI"; this.btnLAMMOI.Size = new System.Drawing.Size(79, 24); this.btnLAMMOI.Text = "Làm mới"; this.btnLAMMOI.Click += new System.EventHandler(this.btnLAMMOI_Click);
            this.btnCHUYENCHINHANH.Name = "btnCHUYENCHINHANH"; this.btnCHUYENCHINHANH.Size = new System.Drawing.Size(147, 24); this.btnCHUYENCHINHANH.Text = "Chuyển chi nhánh"; this.btnCHUYENCHINHANH.Click += new System.EventHandler(this.btnCHUYENCHINHANH_Click);
            this.btnTHOAT.Name = "btnTHOAT"; this.btnTHOAT.Size = new System.Drawing.Size(58, 24); this.btnTHOAT.Text = "Thoát"; this.btnTHOAT.Click += new System.EventHandler(this.btnTHOAT_Click);
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.cmbCHINHANH);
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 28);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1100, 48);
            // 
            // cmbCHINHANH + label
            // 
            this.cmbCHINHANH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCHINHANH.Enabled = false;
            this.cmbCHINHANH.FormattingEnabled = true;
            this.cmbCHINHANH.Location = new System.Drawing.Point(220, 12);
            this.cmbCHINHANH.Name = "cmbCHINHANH";
            this.cmbCHINHANH.Size = new System.Drawing.Size(300, 24);
            this.cmbCHINHANH.SelectedIndexChanged += new System.EventHandler(this.cmbCHINHANH_SelectedIndexChanged);
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 15);
            this.label1.Text = "Chi Nhánh";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitContainer1.Location = new System.Drawing.Point(0, 76);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgvNhanVien);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabDetails);
            this.splitContainer1.Size = new System.Drawing.Size(1100, 360);
            this.splitContainer1.SplitterDistance = 210;
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.AutoGenerateColumns = true;
            this.dgvNhanVien.DataSource = this.bdsNhanVien;
            this.dgvNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNhanVien.Location = new System.Drawing.Point(0, 0);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.Size = new System.Drawing.Size(1100, 210);
            this.dgvNhanVien.TabIndex = 0;
            // 
            // tabDetails
            // 
            this.tabDetails.Controls.Add(this.tabDatHang);
            this.tabDetails.Controls.Add(this.tabPhieuNhap);
            this.tabDetails.Controls.Add(this.tabPhieuXuat);
            this.tabDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabDetails.Location = new System.Drawing.Point(0, 0);
            this.tabDetails.Name = "tabDetails";
            this.tabDetails.SelectedIndex = 0;
            this.tabDetails.Size = new System.Drawing.Size(1100, 146);
            // 
            // tabDatHang
            // 
            this.tabDatHang.Controls.Add(this.dgvDatHang);
            this.tabDatHang.Location = new System.Drawing.Point(4, 25);
            this.tabDatHang.Name = "tabDatHang";
            this.tabDatHang.Padding = new System.Windows.Forms.Padding(3);
            this.tabDatHang.Size = new System.Drawing.Size(1092, 117);
            this.tabDatHang.Text = "Đặt hàng";
            this.tabDatHang.UseVisualStyleBackColor = true;
            // 
            // dgvDatHang
            // 
            this.dgvDatHang.AutoGenerateColumns = true;
            this.dgvDatHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDatHang.Location = new System.Drawing.Point(3, 3);
            this.dgvDatHang.Name = "dgvDatHang";
            this.dgvDatHang.Size = new System.Drawing.Size(1086, 111);
            this.dgvDatHang.TabIndex = 0;
            // 
            // tabPhieuNhap
            // 
            this.tabPhieuNhap.Controls.Add(this.dgvPhieuNhap);
            this.tabPhieuNhap.Location = new System.Drawing.Point(4, 25);
            this.tabPhieuNhap.Name = "tabPhieuNhap";
            this.tabPhieuNhap.Padding = new System.Windows.Forms.Padding(3);
            this.tabPhieuNhap.Size = new System.Drawing.Size(1092, 117);
            this.tabPhieuNhap.Text = "Phiếu nhập";
            this.tabPhieuNhap.UseVisualStyleBackColor = true;
            // 
            // dgvPhieuNhap
            // 
            this.dgvPhieuNhap.AutoGenerateColumns = true;
            this.dgvPhieuNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPhieuNhap.Location = new System.Drawing.Point(3, 3);
            this.dgvPhieuNhap.Name = "dgvPhieuNhap";
            this.dgvPhieuNhap.Size = new System.Drawing.Size(1086, 111);
            this.dgvPhieuNhap.TabIndex = 0;
            // 
            // tabPhieuXuat
            // 
            this.tabPhieuXuat.Controls.Add(this.dgvPhieuXuat);
            this.tabPhieuXuat.Location = new System.Drawing.Point(4, 25);
            this.tabPhieuXuat.Name = "tabPhieuXuat";
            this.tabPhieuXuat.Padding = new System.Windows.Forms.Padding(3);
            this.tabPhieuXuat.Size = new System.Drawing.Size(1092, 117);
            this.tabPhieuXuat.Text = "Phiếu xuất";
            this.tabPhieuXuat.UseVisualStyleBackColor = true;
            // 
            // dgvPhieuXuat
            // 
            this.dgvPhieuXuat.AutoGenerateColumns = true;
            this.dgvPhieuXuat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPhieuXuat.Location = new System.Drawing.Point(3, 3);
            this.dgvPhieuXuat.Name = "dgvPhieuXuat";
            this.dgvPhieuXuat.Size = new System.Drawing.Size(1086, 111);
            this.dgvPhieuXuat.TabIndex = 0;
            // 
            // panelNhapLieu
            // 
            this.panelNhapLieu.Controls.Add(nGAYSINHLabel);
            this.panelNhapLieu.Controls.Add(this.dteNGAYSINH);
            this.panelNhapLieu.Controls.Add(trangThaiXoaLabel);
            this.panelNhapLieu.Controls.Add(this.trangThaiXoaCheckBox);
            this.panelNhapLieu.Controls.Add(lUONGLabel);
            this.panelNhapLieu.Controls.Add(this.txtLUONG);
            this.panelNhapLieu.Controls.Add(dIACHILabel);
            this.panelNhapLieu.Controls.Add(this.txtDIACHI);
            this.panelNhapLieu.Controls.Add(mACNLabel);
            this.panelNhapLieu.Controls.Add(this.txtMACN);
            this.panelNhapLieu.Controls.Add(tENLabel);
            this.panelNhapLieu.Controls.Add(this.txtTEN);
            this.panelNhapLieu.Controls.Add(hOLabel);
            this.panelNhapLieu.Controls.Add(this.txtHO);
            this.panelNhapLieu.Controls.Add(mANVLabel);
            this.panelNhapLieu.Controls.Add(this.txtMANV);
            this.panelNhapLieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNhapLieu.Location = new System.Drawing.Point(0, 436);
            this.panelNhapLieu.Name = "panelNhapLieu";
            this.panelNhapLieu.Size = new System.Drawing.Size(1100, 134);
            // 
            // editors
            // 
            this.dteNGAYSINH.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bdsNhanVien, "NGAYSINH", true));
            this.dteNGAYSINH.Location = new System.Drawing.Point(340, 87);
            this.dteNGAYSINH.Name = "dteNGAYSINH";
            this.dteNGAYSINH.Size = new System.Drawing.Size(150, 22);
            this.dteNGAYSINH.Validating += new System.ComponentModel.CancelEventHandler(this.dteNGAYSINH_Validating);
            this.trangThaiXoaCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bdsNhanVien, "TrangThaiXoa", true));
            this.trangThaiXoaCheckBox.Location = new System.Drawing.Point(830, 88);
            this.trangThaiXoaCheckBox.Size = new System.Drawing.Size(18, 17);
            this.txtLUONG.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bdsNhanVien, "LUONG", true));
            this.txtLUONG.Location = new System.Drawing.Point(580, 87);
            this.txtLUONG.Maximum = 100000000; this.txtLUONG.Increment = 1000000; this.txtLUONG.Minimum = 0;
            this.txtDIACHI.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsNhanVien, "DIACHI", true));
            this.txtDIACHI.Location = new System.Drawing.Point(100, 87);
            this.txtDIACHI.Size = new System.Drawing.Size(140, 22);
            this.txtMACN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsNhanVien, "MACN", true));
            this.txtMACN.Location = new System.Drawing.Point(770, 17);
            this.txtMACN.Size = new System.Drawing.Size(80, 22); this.txtMACN.Enabled = false;
            this.txtTEN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsNhanVien, "TEN", true));
            this.txtTEN.Location = new System.Drawing.Point(560, 17);
            this.txtTEN.Size = new System.Drawing.Size(120, 22);
            this.txtHO.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsNhanVien, "HO", true));
            this.txtHO.Location = new System.Drawing.Point(300, 17);
            this.txtHO.Size = new System.Drawing.Size(120, 22);
            this.txtMANV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsNhanVien, "MANV", true));
            this.txtMANV.Location = new System.Drawing.Point(100, 17);
            this.txtMANV.Size = new System.Drawing.Size(120, 22);
            // 
            // dataset/bindings
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            this.bdsNhanVien.DataMember = "NhanVien";
            this.bdsNhanVien.DataSource = this.dataSet;
            // Chain child binding sources to parent (master-detail)
            this.bdsDatHang.DataMember = "FK_DatHang_NhanVien";
            this.bdsDatHang.DataSource = this.bdsNhanVien;
            this.bdsPhieuNhap.DataMember = "FK_PhieuNhap_NhanVien";
            this.bdsPhieuNhap.DataSource = this.bdsNhanVien;
            this.bdsPhieuXuat.DataMember = "FK_PX_NhanVien";
            this.bdsPhieuXuat.DataSource = this.bdsNhanVien;
            // Hook data sources to child grids
            this.dgvDatHang.DataSource = this.bdsDatHang;
            this.dgvPhieuNhap.DataSource = this.bdsPhieuNhap;
            this.dgvPhieuXuat.DataSource = this.bdsPhieuXuat;
            // 
            // adapters
            // 
            this.nhanVienTableAdapter.ClearBeforeFill = true;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.NhanVienTableAdapter = this.nhanVienTableAdapter;
            this.tableAdapterManager.UpdateOrder = QLTVT.DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.datHangTableAdapter.ClearBeforeFill = true;
            this.phieuNhapTableAdapter.ClearBeforeFill = true;
            this.phieuXuatTableAdapter.ClearBeforeFill = true;
            // 
            // FormNhanVien_Std
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 570);
            this.Controls.Add(this.panelNhapLieu);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FormNhanVien_Std";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhân Viên (chuẩn)";
            this.Load += new System.EventHandler(this.FormNhanVien_Std_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.tabDetails.ResumeLayout(false);
            this.tabDatHang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatHang)).EndInit();
            this.tabPhieuNhap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuNhap)).EndInit();
            this.tabPhieuXuat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuXuat)).EndInit();
            this.panelNhapLieu.ResumeLayout(false);
            this.panelNhapLieu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtLUONG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDatHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPhieuNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPhieuXuat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnTHEM;
        private System.Windows.Forms.ToolStripMenuItem btnXOA;
        private System.Windows.Forms.ToolStripMenuItem btnGHI;
        private System.Windows.Forms.ToolStripMenuItem btnHOANTAC;
        private System.Windows.Forms.ToolStripMenuItem btnLAMMOI;
        private System.Windows.Forms.ToolStripMenuItem btnCHUYENCHINHANH;
        private System.Windows.Forms.ToolStripMenuItem btnTHOAT;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.ComboBox cmbCHINHANH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.TabControl tabDetails;
        private System.Windows.Forms.TabPage tabDatHang;
        private System.Windows.Forms.DataGridView dgvDatHang;
        private System.Windows.Forms.TabPage tabPhieuNhap;
        private System.Windows.Forms.DataGridView dgvPhieuNhap;
        private System.Windows.Forms.TabPage tabPhieuXuat;
        private System.Windows.Forms.DataGridView dgvPhieuXuat;
        private System.Windows.Forms.Panel panelNhapLieu;
        private System.Windows.Forms.DateTimePicker dteNGAYSINH;
        private System.Windows.Forms.CheckBox trangThaiXoaCheckBox;
        private System.Windows.Forms.NumericUpDown txtLUONG;
        private System.Windows.Forms.TextBox txtDIACHI;
        private System.Windows.Forms.TextBox txtMACN;
        private System.Windows.Forms.TextBox txtTEN;
        private System.Windows.Forms.TextBox txtHO;
        private System.Windows.Forms.TextBox txtMANV;
        private QLTVT.DataSet dataSet;
        private System.Windows.Forms.BindingSource bdsNhanVien;
        private QLTVT.DataSetTableAdapters.NhanVienTableAdapter nhanVienTableAdapter;
        private QLTVT.DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private QLTVT.DataSetTableAdapters.DatHangTableAdapter datHangTableAdapter;
        private QLTVT.DataSetTableAdapters.PhieuNhapTableAdapter phieuNhapTableAdapter;
        private QLTVT.DataSetTableAdapters.PhieuXuatTableAdapter phieuXuatTableAdapter;
        private System.Windows.Forms.BindingSource bdsDatHang;
        private System.Windows.Forms.BindingSource bdsPhieuNhap;
        private System.Windows.Forms.BindingSource bdsPhieuXuat;
    }
}