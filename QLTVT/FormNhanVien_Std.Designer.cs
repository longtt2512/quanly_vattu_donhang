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
            this.mANVLabel = new System.Windows.Forms.Label();
            this.hOLabel = new System.Windows.Forms.Label();
            this.tENLabel = new System.Windows.Forms.Label();
            this.mACNLabel = new System.Windows.Forms.Label();
            this.dIACHILabel = new System.Windows.Forms.Label();
            this.lUONGLabel = new System.Windows.Forms.Label();
            this.trangThaiXoaLabel = new System.Windows.Forms.Label();
            this.nGAYSINHLabel = new System.Windows.Forms.Label();
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
            this.bdsNhanVien = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new QLTVT.DataSet();
            this.tabDetails = new System.Windows.Forms.TabControl();
            this.tabDatHang = new System.Windows.Forms.TabPage();
            this.dgvDatHang = new System.Windows.Forms.DataGridView();
            this.masoDDHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nGAYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhaCCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mANVDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mAKHODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdsDatHang = new System.Windows.Forms.BindingSource(this.components);
            this.tabPhieuNhap = new System.Windows.Forms.TabPage();
            this.dgvPhieuNhap = new System.Windows.Forms.DataGridView();
            this.mAPNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nGAYDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.masoDDHDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mANVDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mAKHODataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdsPhieuNhap = new System.Windows.Forms.BindingSource(this.components);
            this.tabPhieuXuat = new System.Windows.Forms.TabPage();
            this.dgvPhieuXuat = new System.Windows.Forms.DataGridView();
            this.mAPXDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nGAYDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hOTENKHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mANVDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mAKHODataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdsPhieuXuat = new System.Windows.Forms.BindingSource(this.components);
            this.panelNhapLieu = new System.Windows.Forms.Panel();
            this.dteNGAYSINH = new System.Windows.Forms.DateTimePicker();
            this.trangThaiXoaCheckBox = new System.Windows.Forms.CheckBox();
            this.txtLUONG = new System.Windows.Forms.NumericUpDown();
            this.txtDIACHI = new System.Windows.Forms.TextBox();
            this.txtMACN = new System.Windows.Forms.TextBox();
            this.txtTEN = new System.Windows.Forms.TextBox();
            this.txtHO = new System.Windows.Forms.TextBox();
            this.txtMANV = new System.Windows.Forms.TextBox();
            this.nhanVienTableAdapter = new QLTVT.DataSetTableAdapters.NhanVienTableAdapter();
            this.tableAdapterManager = new QLTVT.DataSetTableAdapters.TableAdapterManager();
            this.datHangTableAdapter = new QLTVT.DataSetTableAdapters.DatHangTableAdapter();
            this.phieuNhapTableAdapter = new QLTVT.DataSetTableAdapters.PhieuNhapTableAdapter();
            this.phieuXuatTableAdapter = new QLTVT.DataSetTableAdapters.PhieuXuatTableAdapter();
            this.mANVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tENDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dIACHIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nGAYSINHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lUONGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mACNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangThaiXoaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            this.tabDetails.SuspendLayout();
            this.tabDatHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDatHang)).BeginInit();
            this.tabPhieuNhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPhieuNhap)).BeginInit();
            this.tabPhieuXuat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuXuat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPhieuXuat)).BeginInit();
            this.panelNhapLieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtLUONG)).BeginInit();
            this.SuspendLayout();
            // 
            // mANVLabel
            // 
            this.mANVLabel.AutoSize = true;
            this.mANVLabel.Location = new System.Drawing.Point(30, 16);
            this.mANVLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mANVLabel.Name = "mANVLabel";
            this.mANVLabel.Size = new System.Drawing.Size(41, 13);
            this.mANVLabel.TabIndex = 14;
            this.mANVLabel.Text = "MANV:";
            // 
            // hOLabel
            // 
            this.hOLabel.AutoSize = true;
            this.hOLabel.Location = new System.Drawing.Point(195, 16);
            this.hOLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.hOLabel.Name = "hOLabel";
            this.hOLabel.Size = new System.Drawing.Size(26, 13);
            this.hOLabel.TabIndex = 12;
            this.hOLabel.Text = "HO:";
            // 
            // tENLabel
            // 
            this.tENLabel.AutoSize = true;
            this.tENLabel.Location = new System.Drawing.Point(390, 16);
            this.tENLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tENLabel.Name = "tENLabel";
            this.tENLabel.Size = new System.Drawing.Size(32, 13);
            this.tENLabel.TabIndex = 10;
            this.tENLabel.Text = "TEN:";
            // 
            // mACNLabel
            // 
            this.mACNLabel.AutoSize = true;
            this.mACNLabel.Location = new System.Drawing.Point(540, 16);
            this.mACNLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mACNLabel.Name = "mACNLabel";
            this.mACNLabel.Size = new System.Drawing.Size(41, 13);
            this.mACNLabel.TabIndex = 8;
            this.mACNLabel.Text = "MACN:";
            // 
            // dIACHILabel
            // 
            this.dIACHILabel.AutoSize = true;
            this.dIACHILabel.Location = new System.Drawing.Point(30, 73);
            this.dIACHILabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dIACHILabel.Name = "dIACHILabel";
            this.dIACHILabel.Size = new System.Drawing.Size(46, 13);
            this.dIACHILabel.TabIndex = 6;
            this.dIACHILabel.Text = "DIACHI:";
            // 
            // lUONGLabel
            // 
            this.lUONGLabel.AutoSize = true;
            this.lUONGLabel.Location = new System.Drawing.Point(390, 73);
            this.lUONGLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lUONGLabel.Name = "lUONGLabel";
            this.lUONGLabel.Size = new System.Drawing.Size(48, 13);
            this.lUONGLabel.TabIndex = 4;
            this.lUONGLabel.Text = "LUONG:";
            // 
            // trangThaiXoaLabel
            // 
            this.trangThaiXoaLabel.AutoSize = true;
            this.trangThaiXoaLabel.Location = new System.Drawing.Point(540, 75);
            this.trangThaiXoaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.trangThaiXoaLabel.Name = "trangThaiXoaLabel";
            this.trangThaiXoaLabel.Size = new System.Drawing.Size(84, 13);
            this.trangThaiXoaLabel.TabIndex = 2;
            this.trangThaiXoaLabel.Text = "Trang Thai Xoa:";
            // 
            // nGAYSINHLabel
            // 
            this.nGAYSINHLabel.AutoSize = true;
            this.nGAYSINHLabel.Location = new System.Drawing.Point(195, 73);
            this.nGAYSINHLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nGAYSINHLabel.Name = "nGAYSINHLabel";
            this.nGAYSINHLabel.Size = new System.Drawing.Size(66, 13);
            this.nGAYSINHLabel.TabIndex = 0;
            this.nGAYSINHLabel.Text = "NGAYSINH:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowMerge = false;
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(825, 24);
            this.menuStrip1.TabIndex = 0;
            // 
            // btnTHEM
            // 
            this.btnTHEM.Name = "btnTHEM";
            this.btnTHEM.Size = new System.Drawing.Size(50, 20);
            this.btnTHEM.Text = "Thêm";
            this.btnTHEM.Click += new System.EventHandler(this.btnTHEM_Click);
            // 
            // btnXOA
            // 
            this.btnXOA.Name = "btnXOA";
            this.btnXOA.Size = new System.Drawing.Size(39, 20);
            this.btnXOA.Text = "Xóa";
            this.btnXOA.Click += new System.EventHandler(this.btnXOA_Click);
            // 
            // btnGHI
            // 
            this.btnGHI.Name = "btnGHI";
            this.btnGHI.Size = new System.Drawing.Size(37, 20);
            this.btnGHI.Text = "Ghi";
            this.btnGHI.Click += new System.EventHandler(this.btnGHI_Click);
            // 
            // btnHOANTAC
            // 
            this.btnHOANTAC.Name = "btnHOANTAC";
            this.btnHOANTAC.Size = new System.Drawing.Size(67, 20);
            this.btnHOANTAC.Text = "Hoàn tác";
            this.btnHOANTAC.Click += new System.EventHandler(this.btnHOANTAC_Click);
            // 
            // btnLAMMOI
            // 
            this.btnLAMMOI.Name = "btnLAMMOI";
            this.btnLAMMOI.Size = new System.Drawing.Size(66, 20);
            this.btnLAMMOI.Text = "Làm mới";
            this.btnLAMMOI.Click += new System.EventHandler(this.btnLAMMOI_Click);
            // 
            // btnCHUYENCHINHANH
            // 
            this.btnCHUYENCHINHANH.Name = "btnCHUYENCHINHANH";
            this.btnCHUYENCHINHANH.Size = new System.Drawing.Size(116, 20);
            this.btnCHUYENCHINHANH.Text = "Chuyển chi nhánh";
            this.btnCHUYENCHINHANH.Click += new System.EventHandler(this.btnCHUYENCHINHANH_Click);
            // 
            // btnTHOAT
            // 
            this.btnTHOAT.Name = "btnTHOAT";
            this.btnTHOAT.Size = new System.Drawing.Size(50, 20);
            this.btnTHOAT.Text = "Thoát";
            this.btnTHOAT.Click += new System.EventHandler(this.btnTHOAT_Click);
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.cmbCHINHANH);
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 24);
            this.panelTop.Margin = new System.Windows.Forms.Padding(2);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(825, 39);
            this.panelTop.TabIndex = 2;
            // 
            // cmbCHINHANH
            // 
            this.cmbCHINHANH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCHINHANH.Enabled = false;
            this.cmbCHINHANH.FormattingEnabled = true;
            this.cmbCHINHANH.Location = new System.Drawing.Point(63, 10);
            this.cmbCHINHANH.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCHINHANH.Name = "cmbCHINHANH";
            this.cmbCHINHANH.Size = new System.Drawing.Size(226, 21);
            this.cmbCHINHANH.TabIndex = 0;
            this.cmbCHINHANH.SelectedIndexChanged += new System.EventHandler(this.cmbCHINHANH_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chi Nhánh";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitContainer1.Location = new System.Drawing.Point(0, 63);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
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
            this.splitContainer1.Size = new System.Drawing.Size(825, 292);
            this.splitContainer1.SplitterDistance = 170;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 1;
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.AutoGenerateColumns = false;
            this.dgvNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mANVDataGridViewTextBoxColumn,
            this.hODataGridViewTextBoxColumn,
            this.tENDataGridViewTextBoxColumn,
            this.dIACHIDataGridViewTextBoxColumn,
            this.nGAYSINHDataGridViewTextBoxColumn,
            this.lUONGDataGridViewTextBoxColumn,
            this.mACNDataGridViewTextBoxColumn,
            this.trangThaiXoaDataGridViewTextBoxColumn});
            this.dgvNhanVien.DataSource = this.bdsNhanVien;
            this.dgvNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNhanVien.Location = new System.Drawing.Point(0, 0);
            this.dgvNhanVien.Margin = new System.Windows.Forms.Padding(2);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.Size = new System.Drawing.Size(825, 170);
            this.dgvNhanVien.TabIndex = 0;
            // 
            // bdsNhanVien
            // 
            this.bdsNhanVien.DataMember = "NhanVien";
            this.bdsNhanVien.DataSource = this.dataSet;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabDetails
            // 
            this.tabDetails.Controls.Add(this.tabDatHang);
            this.tabDetails.Controls.Add(this.tabPhieuNhap);
            this.tabDetails.Controls.Add(this.tabPhieuXuat);
            this.tabDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabDetails.Location = new System.Drawing.Point(0, 0);
            this.tabDetails.Margin = new System.Windows.Forms.Padding(2);
            this.tabDetails.Name = "tabDetails";
            this.tabDetails.SelectedIndex = 0;
            this.tabDetails.Size = new System.Drawing.Size(825, 119);
            this.tabDetails.TabIndex = 0;
            // 
            // tabDatHang
            // 
            this.tabDatHang.Controls.Add(this.dgvDatHang);
            this.tabDatHang.Location = new System.Drawing.Point(4, 22);
            this.tabDatHang.Margin = new System.Windows.Forms.Padding(2);
            this.tabDatHang.Name = "tabDatHang";
            this.tabDatHang.Padding = new System.Windows.Forms.Padding(2);
            this.tabDatHang.Size = new System.Drawing.Size(817, 93);
            this.tabDatHang.TabIndex = 0;
            this.tabDatHang.Text = "Đặt hàng";
            this.tabDatHang.UseVisualStyleBackColor = true;
            // 
            // dgvDatHang
            // 
            this.dgvDatHang.AutoGenerateColumns = false;
            this.dgvDatHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.masoDDHDataGridViewTextBoxColumn,
            this.nGAYDataGridViewTextBoxColumn,
            this.nhaCCDataGridViewTextBoxColumn,
            this.mANVDataGridViewTextBoxColumn1,
            this.mAKHODataGridViewTextBoxColumn});
            this.dgvDatHang.DataSource = this.bdsDatHang;
            this.dgvDatHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDatHang.Location = new System.Drawing.Point(2, 2);
            this.dgvDatHang.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDatHang.Name = "dgvDatHang";
            this.dgvDatHang.Size = new System.Drawing.Size(813, 89);
            this.dgvDatHang.TabIndex = 0;
            // 
            // masoDDHDataGridViewTextBoxColumn
            // 
            this.masoDDHDataGridViewTextBoxColumn.DataPropertyName = "MasoDDH";
            this.masoDDHDataGridViewTextBoxColumn.HeaderText = "MasoDDH";
            this.masoDDHDataGridViewTextBoxColumn.Name = "masoDDHDataGridViewTextBoxColumn";
            // 
            // nGAYDataGridViewTextBoxColumn
            // 
            this.nGAYDataGridViewTextBoxColumn.DataPropertyName = "NGAY";
            this.nGAYDataGridViewTextBoxColumn.HeaderText = "NGAY";
            this.nGAYDataGridViewTextBoxColumn.Name = "nGAYDataGridViewTextBoxColumn";
            // 
            // nhaCCDataGridViewTextBoxColumn
            // 
            this.nhaCCDataGridViewTextBoxColumn.DataPropertyName = "NhaCC";
            this.nhaCCDataGridViewTextBoxColumn.HeaderText = "NhaCC";
            this.nhaCCDataGridViewTextBoxColumn.Name = "nhaCCDataGridViewTextBoxColumn";
            // 
            // mANVDataGridViewTextBoxColumn1
            // 
            this.mANVDataGridViewTextBoxColumn1.DataPropertyName = "MANV";
            this.mANVDataGridViewTextBoxColumn1.HeaderText = "MANV";
            this.mANVDataGridViewTextBoxColumn1.Name = "mANVDataGridViewTextBoxColumn1";
            // 
            // mAKHODataGridViewTextBoxColumn
            // 
            this.mAKHODataGridViewTextBoxColumn.DataPropertyName = "MAKHO";
            this.mAKHODataGridViewTextBoxColumn.HeaderText = "MAKHO";
            this.mAKHODataGridViewTextBoxColumn.Name = "mAKHODataGridViewTextBoxColumn";
            // 
            // bdsDatHang
            // 
            this.bdsDatHang.DataMember = "FK_DatHang_NhanVien";
            this.bdsDatHang.DataSource = this.bdsNhanVien;
            // 
            // tabPhieuNhap
            // 
            this.tabPhieuNhap.Controls.Add(this.dgvPhieuNhap);
            this.tabPhieuNhap.Location = new System.Drawing.Point(4, 22);
            this.tabPhieuNhap.Margin = new System.Windows.Forms.Padding(2);
            this.tabPhieuNhap.Name = "tabPhieuNhap";
            this.tabPhieuNhap.Padding = new System.Windows.Forms.Padding(2);
            this.tabPhieuNhap.Size = new System.Drawing.Size(817, 93);
            this.tabPhieuNhap.TabIndex = 1;
            this.tabPhieuNhap.Text = "Phiếu nhập";
            this.tabPhieuNhap.UseVisualStyleBackColor = true;
            // 
            // dgvPhieuNhap
            // 
            this.dgvPhieuNhap.AutoGenerateColumns = false;
            this.dgvPhieuNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mAPNDataGridViewTextBoxColumn,
            this.nGAYDataGridViewTextBoxColumn1,
            this.masoDDHDataGridViewTextBoxColumn1,
            this.mANVDataGridViewTextBoxColumn2,
            this.mAKHODataGridViewTextBoxColumn1});
            this.dgvPhieuNhap.DataSource = this.bdsPhieuNhap;
            this.dgvPhieuNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPhieuNhap.Location = new System.Drawing.Point(2, 2);
            this.dgvPhieuNhap.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPhieuNhap.Name = "dgvPhieuNhap";
            this.dgvPhieuNhap.Size = new System.Drawing.Size(813, 89);
            this.dgvPhieuNhap.TabIndex = 0;
            // 
            // mAPNDataGridViewTextBoxColumn
            // 
            this.mAPNDataGridViewTextBoxColumn.DataPropertyName = "MAPN";
            this.mAPNDataGridViewTextBoxColumn.HeaderText = "MAPN";
            this.mAPNDataGridViewTextBoxColumn.Name = "mAPNDataGridViewTextBoxColumn";
            // 
            // nGAYDataGridViewTextBoxColumn1
            // 
            this.nGAYDataGridViewTextBoxColumn1.DataPropertyName = "NGAY";
            this.nGAYDataGridViewTextBoxColumn1.HeaderText = "NGAY";
            this.nGAYDataGridViewTextBoxColumn1.Name = "nGAYDataGridViewTextBoxColumn1";
            // 
            // masoDDHDataGridViewTextBoxColumn1
            // 
            this.masoDDHDataGridViewTextBoxColumn1.DataPropertyName = "MasoDDH";
            this.masoDDHDataGridViewTextBoxColumn1.HeaderText = "MasoDDH";
            this.masoDDHDataGridViewTextBoxColumn1.Name = "masoDDHDataGridViewTextBoxColumn1";
            // 
            // mANVDataGridViewTextBoxColumn2
            // 
            this.mANVDataGridViewTextBoxColumn2.DataPropertyName = "MANV";
            this.mANVDataGridViewTextBoxColumn2.HeaderText = "MANV";
            this.mANVDataGridViewTextBoxColumn2.Name = "mANVDataGridViewTextBoxColumn2";
            // 
            // mAKHODataGridViewTextBoxColumn1
            // 
            this.mAKHODataGridViewTextBoxColumn1.DataPropertyName = "MAKHO";
            this.mAKHODataGridViewTextBoxColumn1.HeaderText = "MAKHO";
            this.mAKHODataGridViewTextBoxColumn1.Name = "mAKHODataGridViewTextBoxColumn1";
            // 
            // bdsPhieuNhap
            // 
            this.bdsPhieuNhap.DataMember = "FK_PhieuNhap_NhanVien";
            this.bdsPhieuNhap.DataSource = this.bdsNhanVien;
            // 
            // tabPhieuXuat
            // 
            this.tabPhieuXuat.Controls.Add(this.dgvPhieuXuat);
            this.tabPhieuXuat.Location = new System.Drawing.Point(4, 22);
            this.tabPhieuXuat.Margin = new System.Windows.Forms.Padding(2);
            this.tabPhieuXuat.Name = "tabPhieuXuat";
            this.tabPhieuXuat.Padding = new System.Windows.Forms.Padding(2);
            this.tabPhieuXuat.Size = new System.Drawing.Size(817, 93);
            this.tabPhieuXuat.TabIndex = 2;
            this.tabPhieuXuat.Text = "Phiếu xuất";
            this.tabPhieuXuat.UseVisualStyleBackColor = true;
            // 
            // dgvPhieuXuat
            // 
            this.dgvPhieuXuat.AutoGenerateColumns = false;
            this.dgvPhieuXuat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mAPXDataGridViewTextBoxColumn,
            this.nGAYDataGridViewTextBoxColumn2,
            this.hOTENKHDataGridViewTextBoxColumn,
            this.mANVDataGridViewTextBoxColumn3,
            this.mAKHODataGridViewTextBoxColumn2});
            this.dgvPhieuXuat.DataSource = this.bdsPhieuXuat;
            this.dgvPhieuXuat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPhieuXuat.Location = new System.Drawing.Point(2, 2);
            this.dgvPhieuXuat.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPhieuXuat.Name = "dgvPhieuXuat";
            this.dgvPhieuXuat.Size = new System.Drawing.Size(813, 89);
            this.dgvPhieuXuat.TabIndex = 0;
            // 
            // mAPXDataGridViewTextBoxColumn
            // 
            this.mAPXDataGridViewTextBoxColumn.DataPropertyName = "MAPX";
            this.mAPXDataGridViewTextBoxColumn.HeaderText = "MAPX";
            this.mAPXDataGridViewTextBoxColumn.Name = "mAPXDataGridViewTextBoxColumn";
            // 
            // nGAYDataGridViewTextBoxColumn2
            // 
            this.nGAYDataGridViewTextBoxColumn2.DataPropertyName = "NGAY";
            this.nGAYDataGridViewTextBoxColumn2.HeaderText = "NGAY";
            this.nGAYDataGridViewTextBoxColumn2.Name = "nGAYDataGridViewTextBoxColumn2";
            // 
            // hOTENKHDataGridViewTextBoxColumn
            // 
            this.hOTENKHDataGridViewTextBoxColumn.DataPropertyName = "HOTENKH";
            this.hOTENKHDataGridViewTextBoxColumn.HeaderText = "HOTENKH";
            this.hOTENKHDataGridViewTextBoxColumn.Name = "hOTENKHDataGridViewTextBoxColumn";
            // 
            // mANVDataGridViewTextBoxColumn3
            // 
            this.mANVDataGridViewTextBoxColumn3.DataPropertyName = "MANV";
            this.mANVDataGridViewTextBoxColumn3.HeaderText = "MANV";
            this.mANVDataGridViewTextBoxColumn3.Name = "mANVDataGridViewTextBoxColumn3";
            // 
            // mAKHODataGridViewTextBoxColumn2
            // 
            this.mAKHODataGridViewTextBoxColumn2.DataPropertyName = "MAKHO";
            this.mAKHODataGridViewTextBoxColumn2.HeaderText = "MAKHO";
            this.mAKHODataGridViewTextBoxColumn2.Name = "mAKHODataGridViewTextBoxColumn2";
            // 
            // bdsPhieuXuat
            // 
            this.bdsPhieuXuat.DataMember = "FK_PX_NhanVien";
            this.bdsPhieuXuat.DataSource = this.bdsNhanVien;
            // 
            // panelNhapLieu
            // 
            this.panelNhapLieu.Controls.Add(this.nGAYSINHLabel);
            this.panelNhapLieu.Controls.Add(this.dteNGAYSINH);
            this.panelNhapLieu.Controls.Add(this.trangThaiXoaLabel);
            this.panelNhapLieu.Controls.Add(this.trangThaiXoaCheckBox);
            this.panelNhapLieu.Controls.Add(this.lUONGLabel);
            this.panelNhapLieu.Controls.Add(this.txtLUONG);
            this.panelNhapLieu.Controls.Add(this.dIACHILabel);
            this.panelNhapLieu.Controls.Add(this.txtDIACHI);
            this.panelNhapLieu.Controls.Add(this.mACNLabel);
            this.panelNhapLieu.Controls.Add(this.txtMACN);
            this.panelNhapLieu.Controls.Add(this.tENLabel);
            this.panelNhapLieu.Controls.Add(this.txtTEN);
            this.panelNhapLieu.Controls.Add(this.hOLabel);
            this.panelNhapLieu.Controls.Add(this.txtHO);
            this.panelNhapLieu.Controls.Add(this.mANVLabel);
            this.panelNhapLieu.Controls.Add(this.txtMANV);
            this.panelNhapLieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNhapLieu.Location = new System.Drawing.Point(0, 355);
            this.panelNhapLieu.Margin = new System.Windows.Forms.Padding(2);
            this.panelNhapLieu.Name = "panelNhapLieu";
            this.panelNhapLieu.Size = new System.Drawing.Size(825, 108);
            this.panelNhapLieu.TabIndex = 0;
            // 
            // dteNGAYSINH
            // 
            this.dteNGAYSINH.CustomFormat = "MM/dd/yyyy";
            this.dteNGAYSINH.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bdsNhanVien, "NGAYSINH", true));
            this.dteNGAYSINH.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dteNGAYSINH.Location = new System.Drawing.Point(264, 71);
            this.dteNGAYSINH.Margin = new System.Windows.Forms.Padding(2);
            this.dteNGAYSINH.Name = "dteNGAYSINH";
            this.dteNGAYSINH.Size = new System.Drawing.Size(114, 20);
            this.dteNGAYSINH.TabIndex = 1;
            this.dteNGAYSINH.Validating += new System.ComponentModel.CancelEventHandler(this.dteNGAYSINH_Validating);
            // 
            // trangThaiXoaCheckBox
            // 
            this.trangThaiXoaCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bdsNhanVien, "TrangThaiXoa", true));
            this.trangThaiXoaCheckBox.Location = new System.Drawing.Point(624, 75);
            this.trangThaiXoaCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.trangThaiXoaCheckBox.Name = "trangThaiXoaCheckBox";
            this.trangThaiXoaCheckBox.Size = new System.Drawing.Size(14, 14);
            this.trangThaiXoaCheckBox.TabIndex = 3;
            // 
            // txtLUONG
            // 
            this.txtLUONG.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bdsNhanVien, "LUONG", true));
            this.txtLUONG.Increment = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txtLUONG.Location = new System.Drawing.Point(441, 71);
            this.txtLUONG.Margin = new System.Windows.Forms.Padding(2);
            this.txtLUONG.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.txtLUONG.Name = "txtLUONG";
            this.txtLUONG.Size = new System.Drawing.Size(90, 20);
            this.txtLUONG.TabIndex = 5;
            // 
            // txtDIACHI
            // 
            this.txtDIACHI.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsNhanVien, "DIACHI", true));
            this.txtDIACHI.Location = new System.Drawing.Point(75, 71);
            this.txtDIACHI.Margin = new System.Windows.Forms.Padding(2);
            this.txtDIACHI.Name = "txtDIACHI";
            this.txtDIACHI.Size = new System.Drawing.Size(106, 20);
            this.txtDIACHI.TabIndex = 7;
            // 
            // txtMACN
            // 
            this.txtMACN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsNhanVien, "MACN", true));
            this.txtMACN.Enabled = false;
            this.txtMACN.Location = new System.Drawing.Point(578, 14);
            this.txtMACN.Margin = new System.Windows.Forms.Padding(2);
            this.txtMACN.Name = "txtMACN";
            this.txtMACN.Size = new System.Drawing.Size(61, 20);
            this.txtMACN.TabIndex = 9;
            // 
            // txtTEN
            // 
            this.txtTEN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsNhanVien, "TEN", true));
            this.txtTEN.Location = new System.Drawing.Point(420, 14);
            this.txtTEN.Margin = new System.Windows.Forms.Padding(2);
            this.txtTEN.Name = "txtTEN";
            this.txtTEN.Size = new System.Drawing.Size(91, 20);
            this.txtTEN.TabIndex = 11;
            // 
            // txtHO
            // 
            this.txtHO.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsNhanVien, "HO", true));
            this.txtHO.Location = new System.Drawing.Point(225, 14);
            this.txtHO.Margin = new System.Windows.Forms.Padding(2);
            this.txtHO.Name = "txtHO";
            this.txtHO.Size = new System.Drawing.Size(91, 20);
            this.txtHO.TabIndex = 13;
            // 
            // txtMANV
            // 
            this.txtMANV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsNhanVien, "MANV", true));
            this.txtMANV.Location = new System.Drawing.Point(75, 14);
            this.txtMANV.Margin = new System.Windows.Forms.Padding(2);
            this.txtMANV.Name = "txtMANV";
            this.txtMANV.Size = new System.Drawing.Size(91, 20);
            this.txtMANV.TabIndex = 15;
            // 
            // nhanVienTableAdapter
            // 
            this.nhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.CTDDHTableAdapter = null;
            this.tableAdapterManager.CTPNTableAdapter = null;
            this.tableAdapterManager.CTPXTableAdapter = null;
            this.tableAdapterManager.DatHangTableAdapter = null;
            this.tableAdapterManager.KhoTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = this.nhanVienTableAdapter;
            this.tableAdapterManager.PhieuNhapTableAdapter = null;
            this.tableAdapterManager.PhieuXuatTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLTVT.DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = null;
            // 
            // datHangTableAdapter
            // 
            this.datHangTableAdapter.ClearBeforeFill = true;
            // 
            // phieuNhapTableAdapter
            // 
            this.phieuNhapTableAdapter.ClearBeforeFill = true;
            // 
            // phieuXuatTableAdapter
            // 
            this.phieuXuatTableAdapter.ClearBeforeFill = true;
            // 
            // mANVDataGridViewTextBoxColumn
            // 
            this.mANVDataGridViewTextBoxColumn.DataPropertyName = "MANV";
            this.mANVDataGridViewTextBoxColumn.HeaderText = "MANV";
            this.mANVDataGridViewTextBoxColumn.Name = "mANVDataGridViewTextBoxColumn";
            // 
            // hODataGridViewTextBoxColumn
            // 
            this.hODataGridViewTextBoxColumn.DataPropertyName = "HO";
            this.hODataGridViewTextBoxColumn.HeaderText = "HO";
            this.hODataGridViewTextBoxColumn.Name = "hODataGridViewTextBoxColumn";
            // 
            // tENDataGridViewTextBoxColumn
            // 
            this.tENDataGridViewTextBoxColumn.DataPropertyName = "TEN";
            this.tENDataGridViewTextBoxColumn.HeaderText = "TEN";
            this.tENDataGridViewTextBoxColumn.Name = "tENDataGridViewTextBoxColumn";
            // 
            // dIACHIDataGridViewTextBoxColumn
            // 
            this.dIACHIDataGridViewTextBoxColumn.DataPropertyName = "DIACHI";
            this.dIACHIDataGridViewTextBoxColumn.HeaderText = "DIACHI";
            this.dIACHIDataGridViewTextBoxColumn.Name = "dIACHIDataGridViewTextBoxColumn";
            // 
            // nGAYSINHDataGridViewTextBoxColumn
            // 
            this.nGAYSINHDataGridViewTextBoxColumn.DataPropertyName = "NGAYSINH";
            this.nGAYSINHDataGridViewTextBoxColumn.HeaderText = "NGAYSINH";
            this.nGAYSINHDataGridViewTextBoxColumn.Name = "nGAYSINHDataGridViewTextBoxColumn";
            // 
            // lUONGDataGridViewTextBoxColumn
            // 
            this.lUONGDataGridViewTextBoxColumn.DataPropertyName = "LUONG";
            this.lUONGDataGridViewTextBoxColumn.HeaderText = "LUONG";
            this.lUONGDataGridViewTextBoxColumn.Name = "lUONGDataGridViewTextBoxColumn";
            // 
            // mACNDataGridViewTextBoxColumn
            // 
            this.mACNDataGridViewTextBoxColumn.DataPropertyName = "MACN";
            this.mACNDataGridViewTextBoxColumn.HeaderText = "MACN";
            this.mACNDataGridViewTextBoxColumn.Name = "mACNDataGridViewTextBoxColumn";
            // 
            // trangThaiXoaDataGridViewTextBoxColumn
            // 
            this.trangThaiXoaDataGridViewTextBoxColumn.DataPropertyName = "TrangThaiXoa";
            this.trangThaiXoaDataGridViewTextBoxColumn.HeaderText = "TrangThaiXoa";
            this.trangThaiXoaDataGridViewTextBoxColumn.Name = "trangThaiXoaDataGridViewTextBoxColumn";
            this.trangThaiXoaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.trangThaiXoaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // FormNhanVien_Std
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 463);
            this.Controls.Add(this.panelNhapLieu);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormNhanVien_Std";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhân Viên";
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
            ((System.ComponentModel.ISupportInitialize)(this.bdsNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            this.tabDetails.ResumeLayout(false);
            this.tabDatHang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDatHang)).EndInit();
            this.tabPhieuNhap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPhieuNhap)).EndInit();
            this.tabPhieuXuat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuXuat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPhieuXuat)).EndInit();
            this.panelNhapLieu.ResumeLayout(false);
            this.panelNhapLieu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtLUONG)).EndInit();
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
        private System.Windows.Forms.Label mANVLabel;
        private System.Windows.Forms.Label hOLabel;
        private System.Windows.Forms.Label tENLabel;
        private System.Windows.Forms.Label mACNLabel;
        private System.Windows.Forms.Label dIACHILabel;
        private System.Windows.Forms.Label lUONGLabel;
        private System.Windows.Forms.Label trangThaiXoaLabel;
        private System.Windows.Forms.Label nGAYSINHLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn masoDDHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nGAYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nhaCCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mANVDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAKHODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAPNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nGAYDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn masoDDHDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mANVDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAKHODataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAPXDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nGAYDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn hOTENKHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mANVDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAKHODataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn mANVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tENDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIACHIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nGAYSINHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lUONGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mACNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn trangThaiXoaDataGridViewTextBoxColumn;
    }
}