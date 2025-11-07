namespace QLTVT
{
    partial class FormPhieuNhap_Std
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
            this.mAPNLabel = new System.Windows.Forms.Label();
            this.nGAYLabel = new System.Windows.Forms.Label();
            this.masoDDHLabel = new System.Windows.Forms.Label();
            this.mAKHOLabel = new System.Windows.Forms.Label();
            this.mANVLabel = new System.Windows.Forms.Label();
            this.mAVTLabel1 = new System.Windows.Forms.Label();
            this.sOLUONGLabel1 = new System.Windows.Forms.Label();
            this.dONGIALabel1 = new System.Windows.Forms.Label();
            this.mAVTLabel = new System.Windows.Forms.Label();
            this.sOLUONGLabel = new System.Windows.Forms.Label();
            this.dONGIALabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnTHEM = new System.Windows.Forms.ToolStripMenuItem();
            this.btnXOA = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGHI = new System.Windows.Forms.ToolStripMenuItem();
            this.btnHOANTAC = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLAMMOI = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMENU = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCheDoPhieuNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCheDoChiTietPhieuNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.btnTHOAT = new System.Windows.Forms.ToolStripMenuItem();
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblCheDo = new System.Windows.Forms.Label();
            this.cmbCHINHANH = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgvPhieuNhap = new System.Windows.Forms.DataGridView();
            this.bdsPhieuNhap = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new QLTVT.DataSet();
            this.panelRight = new System.Windows.Forms.Panel();
            this.dgvCTPN = new System.Windows.Forms.DataGridView();
            this.bdsChiTietPhieuNhap = new System.Windows.Forms.BindingSource(this.components);
            this.groupBoxPhieuNhap = new System.Windows.Forms.GroupBox();
            this.btnChonChiTietDonHang = new System.Windows.Forms.Button();
            this.txtMaKho = new System.Windows.Forms.TextBox();
            this.txtMaNhanVien = new System.Windows.Forms.TextBox();
            this.txtDonGiaChiTietPhieuNhap = new System.Windows.Forms.NumericUpDown();
            this.txtSoLuongChiTietPhieuNhap = new System.Windows.Forms.NumericUpDown();
            this.txtMaVatChiTietPhieuNhap = new System.Windows.Forms.TextBox();
            this.btnChonDonHang = new System.Windows.Forms.Button();
            this.txtMaDonDatHang = new System.Windows.Forms.TextBox();
            this.dteNgay = new System.Windows.Forms.DateTimePicker();
            this.txtMaPhieuNhap = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.NumericUpDown();
            this.txtSoLuong = new System.Windows.Forms.NumericUpDown();
            this.btnChonVatTu = new System.Windows.Forms.Button();
            this.txtMaVatTu = new System.Windows.Forms.TextBox();
            this.phieuNhapTableAdapter = new QLTVT.DataSetTableAdapters.PhieuNhapTableAdapter();
            this.tableAdapterManager = new QLTVT.DataSetTableAdapters.TableAdapterManager();
            this.chiTietPhieuNhapTableAdapter = new QLTVT.DataSetTableAdapters.CTPNTableAdapter();
            this.mAPNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nGAYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.masoDDHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mANVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mAKHODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mAPNDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mAVTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sOLUONGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dONGIADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPhieuNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            this.panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTPN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsChiTietPhieuNhap)).BeginInit();
            this.groupBoxPhieuNhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonGiaChiTietPhieuNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuongChiTietPhieuNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // mAPNLabel
            // 
            this.mAPNLabel.AutoSize = true;
            this.mAPNLabel.Location = new System.Drawing.Point(15, 28);
            this.mAPNLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mAPNLabel.Name = "mAPNLabel";
            this.mAPNLabel.Size = new System.Drawing.Size(81, 13);
            this.mAPNLabel.TabIndex = 14;
            this.mAPNLabel.Text = "Mã Phiếu Nhập";
            // 
            // nGAYLabel
            // 
            this.nGAYLabel.AutoSize = true;
            this.nGAYLabel.Location = new System.Drawing.Point(240, 28);
            this.nGAYLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nGAYLabel.Name = "nGAYLabel";
            this.nGAYLabel.Size = new System.Drawing.Size(32, 13);
            this.nGAYLabel.TabIndex = 15;
            this.nGAYLabel.Text = "Ngày";
            // 
            // masoDDHLabel
            // 
            this.masoDDHLabel.AutoSize = true;
            this.masoDDHLabel.Location = new System.Drawing.Point(15, 109);
            this.masoDDHLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.masoDDHLabel.Name = "masoDDHLabel";
            this.masoDDHLabel.Size = new System.Drawing.Size(94, 13);
            this.masoDDHLabel.TabIndex = 16;
            this.masoDDHLabel.Text = "Mã Đơn Đặt Hàng";
            // 
            // mAKHOLabel
            // 
            this.mAKHOLabel.AutoSize = true;
            this.mAKHOLabel.Location = new System.Drawing.Point(15, 84);
            this.mAKHOLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mAKHOLabel.Name = "mAKHOLabel";
            this.mAKHOLabel.Size = new System.Drawing.Size(44, 13);
            this.mAKHOLabel.TabIndex = 17;
            this.mAKHOLabel.Text = "Mã Kho";
            // 
            // mANVLabel
            // 
            this.mANVLabel.AutoSize = true;
            this.mANVLabel.Location = new System.Drawing.Point(15, 60);
            this.mANVLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mANVLabel.Name = "mANVLabel";
            this.mANVLabel.Size = new System.Drawing.Size(75, 13);
            this.mANVLabel.TabIndex = 18;
            this.mANVLabel.Text = "Mã Nhân Viên";
            // 
            // mAVTLabel1
            // 
            this.mAVTLabel1.AutoSize = true;
            this.mAVTLabel1.Location = new System.Drawing.Point(15, 150);
            this.mAVTLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mAVTLabel1.Name = "mAVTLabel1";
            this.mAVTLabel1.Size = new System.Drawing.Size(80, 13);
            this.mAVTLabel1.TabIndex = 19;
            this.mAVTLabel1.Text = "Mã Vật Tư (CT)";
            // 
            // sOLUONGLabel1
            // 
            this.sOLUONGLabel1.AutoSize = true;
            this.sOLUONGLabel1.Location = new System.Drawing.Point(15, 174);
            this.sOLUONGLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sOLUONGLabel1.Name = "sOLUONGLabel1";
            this.sOLUONGLabel1.Size = new System.Drawing.Size(76, 13);
            this.sOLUONGLabel1.TabIndex = 20;
            this.sOLUONGLabel1.Text = "Số Lượng (CT)";
            // 
            // dONGIALabel1
            // 
            this.dONGIALabel1.AutoSize = true;
            this.dONGIALabel1.Location = new System.Drawing.Point(15, 198);
            this.dONGIALabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dONGIALabel1.Name = "dONGIALabel1";
            this.dONGIALabel1.Size = new System.Drawing.Size(69, 13);
            this.dONGIALabel1.TabIndex = 21;
            this.dONGIALabel1.Text = "Đơn Giá (CT)";
            // 
            // mAVTLabel
            // 
            this.mAVTLabel.AutoSize = true;
            this.mAVTLabel.Location = new System.Drawing.Point(15, 247);
            this.mAVTLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mAVTLabel.Name = "mAVTLabel";
            this.mAVTLabel.Size = new System.Drawing.Size(57, 13);
            this.mAVTLabel.TabIndex = 22;
            this.mAVTLabel.Text = "Mã Vật Tư";
            // 
            // sOLUONGLabel
            // 
            this.sOLUONGLabel.AutoSize = true;
            this.sOLUONGLabel.Location = new System.Drawing.Point(15, 271);
            this.sOLUONGLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sOLUONGLabel.Name = "sOLUONGLabel";
            this.sOLUONGLabel.Size = new System.Drawing.Size(53, 13);
            this.sOLUONGLabel.TabIndex = 23;
            this.sOLUONGLabel.Text = "Số Lượng";
            // 
            // dONGIALabel
            // 
            this.dONGIALabel.AutoSize = true;
            this.dONGIALabel.Location = new System.Drawing.Point(15, 296);
            this.dONGIALabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dONGIALabel.Name = "dONGIALabel";
            this.dONGIALabel.Size = new System.Drawing.Size(46, 13);
            this.dONGIALabel.TabIndex = 24;
            this.dONGIALabel.Text = "Đơn Giá";
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
            this.btnMENU,
            this.btnTHOAT});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1656, 24);
            this.menuStrip1.TabIndex = 2;
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
            // btnMENU
            // 
            this.btnMENU.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCheDoPhieuNhap,
            this.btnCheDoChiTietPhieuNhap});
            this.btnMENU.Name = "btnMENU";
            this.btnMENU.Size = new System.Drawing.Size(87, 20);
            this.btnMENU.Text = "Chọn chế độ";
            // 
            // btnCheDoPhieuNhap
            // 
            this.btnCheDoPhieuNhap.Name = "btnCheDoPhieuNhap";
            this.btnCheDoPhieuNhap.Size = new System.Drawing.Size(180, 22);
            this.btnCheDoPhieuNhap.Text = "Phiếu Nhập";
            this.btnCheDoPhieuNhap.Click += new System.EventHandler(this.btnCheDoPhieuNhap_Click);
            // 
            // btnCheDoChiTietPhieuNhap
            // 
            this.btnCheDoChiTietPhieuNhap.Name = "btnCheDoChiTietPhieuNhap";
            this.btnCheDoChiTietPhieuNhap.Size = new System.Drawing.Size(180, 22);
            this.btnCheDoChiTietPhieuNhap.Text = "Chi Tiết Phiếu Nhập";
            this.btnCheDoChiTietPhieuNhap.Click += new System.EventHandler(this.btnCheDoChiTietPhieuNhap_Click);
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
            this.panelTop.Controls.Add(this.lblCheDo);
            this.panelTop.Controls.Add(this.cmbCHINHANH);
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 24);
            this.panelTop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1656, 39);
            this.panelTop.TabIndex = 1;
            // 
            // lblCheDo
            // 
            this.lblCheDo.AutoSize = true;
            this.lblCheDo.Location = new System.Drawing.Point(285, 13);
            this.lblCheDo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCheDo.Name = "lblCheDo";
            this.lblCheDo.Size = new System.Drawing.Size(45, 13);
            this.lblCheDo.TabIndex = 0;
            this.lblCheDo.Text = "Chế độ:";
            // 
            // cmbCHINHANH
            // 
            this.cmbCHINHANH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCHINHANH.Location = new System.Drawing.Point(75, 10);
            this.cmbCHINHANH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbCHINHANH.Name = "cmbCHINHANH";
            this.cmbCHINHANH.Size = new System.Drawing.Size(188, 21);
            this.cmbCHINHANH.TabIndex = 1;
            this.cmbCHINHANH.SelectedIndexChanged += new System.EventHandler(this.cmbCHINHANH_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(15, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chi Nhánh";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 63);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgvPhieuNhap);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panelRight);
            this.splitContainer1.Panel2.Controls.Add(this.groupBoxPhieuNhap);
            this.splitContainer1.Size = new System.Drawing.Size(1656, 704);
            this.splitContainer1.SplitterDistance = 269;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 0;
            // 
            // dgvPhieuNhap
            // 
            this.dgvPhieuNhap.AutoGenerateColumns = false;
            this.dgvPhieuNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mAPNDataGridViewTextBoxColumn,
            this.nGAYDataGridViewTextBoxColumn,
            this.masoDDHDataGridViewTextBoxColumn,
            this.mANVDataGridViewTextBoxColumn,
            this.mAKHODataGridViewTextBoxColumn});
            this.dgvPhieuNhap.DataSource = this.bdsPhieuNhap;
            this.dgvPhieuNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPhieuNhap.Location = new System.Drawing.Point(0, 0);
            this.dgvPhieuNhap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvPhieuNhap.Name = "dgvPhieuNhap";
            this.dgvPhieuNhap.Size = new System.Drawing.Size(1656, 269);
            this.dgvPhieuNhap.TabIndex = 0;
            // 
            // bdsPhieuNhap
            // 
            this.bdsPhieuNhap.DataMember = "PhieuNhap";
            this.bdsPhieuNhap.DataSource = this.dataSet;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panelRight
            // 
            this.panelRight.Controls.Add(this.dgvCTPN);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(420, 0);
            this.panelRight.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(1236, 432);
            this.panelRight.TabIndex = 0;
            // 
            // dgvCTPN
            // 
            this.dgvCTPN.AutoGenerateColumns = false;
            this.dgvCTPN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mAPNDataGridViewTextBoxColumn1,
            this.mAVTDataGridViewTextBoxColumn,
            this.sOLUONGDataGridViewTextBoxColumn,
            this.dONGIADataGridViewTextBoxColumn});
            this.dgvCTPN.DataSource = this.bdsChiTietPhieuNhap;
            this.dgvCTPN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCTPN.Location = new System.Drawing.Point(0, 0);
            this.dgvCTPN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvCTPN.Name = "dgvCTPN";
            this.dgvCTPN.Size = new System.Drawing.Size(1236, 432);
            this.dgvCTPN.TabIndex = 0;
            // 
            // bdsChiTietPhieuNhap
            // 
            this.bdsChiTietPhieuNhap.DataMember = "FK_CTPN_PhieuNhap";
            this.bdsChiTietPhieuNhap.DataSource = this.bdsPhieuNhap;
            // 
            // groupBoxPhieuNhap
            // 
            this.groupBoxPhieuNhap.Controls.Add(this.btnChonChiTietDonHang);
            this.groupBoxPhieuNhap.Controls.Add(this.txtMaKho);
            this.groupBoxPhieuNhap.Controls.Add(this.txtMaNhanVien);
            this.groupBoxPhieuNhap.Controls.Add(this.txtDonGiaChiTietPhieuNhap);
            this.groupBoxPhieuNhap.Controls.Add(this.txtSoLuongChiTietPhieuNhap);
            this.groupBoxPhieuNhap.Controls.Add(this.txtMaVatChiTietPhieuNhap);
            this.groupBoxPhieuNhap.Controls.Add(this.btnChonDonHang);
            this.groupBoxPhieuNhap.Controls.Add(this.txtMaDonDatHang);
            this.groupBoxPhieuNhap.Controls.Add(this.dteNgay);
            this.groupBoxPhieuNhap.Controls.Add(this.txtMaPhieuNhap);
            this.groupBoxPhieuNhap.Controls.Add(this.txtDonGia);
            this.groupBoxPhieuNhap.Controls.Add(this.txtSoLuong);
            this.groupBoxPhieuNhap.Controls.Add(this.btnChonVatTu);
            this.groupBoxPhieuNhap.Controls.Add(this.txtMaVatTu);
            this.groupBoxPhieuNhap.Controls.Add(this.mAPNLabel);
            this.groupBoxPhieuNhap.Controls.Add(this.nGAYLabel);
            this.groupBoxPhieuNhap.Controls.Add(this.masoDDHLabel);
            this.groupBoxPhieuNhap.Controls.Add(this.mAKHOLabel);
            this.groupBoxPhieuNhap.Controls.Add(this.mANVLabel);
            this.groupBoxPhieuNhap.Controls.Add(this.mAVTLabel1);
            this.groupBoxPhieuNhap.Controls.Add(this.sOLUONGLabel1);
            this.groupBoxPhieuNhap.Controls.Add(this.dONGIALabel1);
            this.groupBoxPhieuNhap.Controls.Add(this.mAVTLabel);
            this.groupBoxPhieuNhap.Controls.Add(this.sOLUONGLabel);
            this.groupBoxPhieuNhap.Controls.Add(this.dONGIALabel);
            this.groupBoxPhieuNhap.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxPhieuNhap.Location = new System.Drawing.Point(0, 0);
            this.groupBoxPhieuNhap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxPhieuNhap.Name = "groupBoxPhieuNhap";
            this.groupBoxPhieuNhap.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxPhieuNhap.Size = new System.Drawing.Size(420, 432);
            this.groupBoxPhieuNhap.TabIndex = 1;
            this.groupBoxPhieuNhap.TabStop = false;
            this.groupBoxPhieuNhap.Text = "Thông Tin";
            // 
            // btnChonChiTietDonHang
            // 
            this.btnChonChiTietDonHang.Enabled = false;
            this.btnChonChiTietDonHang.Location = new System.Drawing.Point(120, 167);
            this.btnChonChiTietDonHang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnChonChiTietDonHang.Name = "btnChonChiTietDonHang";
            this.btnChonChiTietDonHang.Size = new System.Drawing.Size(135, 24);
            this.btnChonChiTietDonHang.TabIndex = 0;
            this.btnChonChiTietDonHang.Text = "Chọn Chi Tiết ĐH";
            this.btnChonChiTietDonHang.Click += new System.EventHandler(this.btnChonChiTietDonHang_Click);
            // 
            // txtMaKho
            // 
            this.txtMaKho.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsPhieuNhap, "MAKHO", true));
            this.txtMaKho.Enabled = false;
            this.txtMaKho.Location = new System.Drawing.Point(120, 81);
            this.txtMaKho.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMaKho.Name = "txtMaKho";
            this.txtMaKho.Size = new System.Drawing.Size(98, 20);
            this.txtMaKho.TabIndex = 1;
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsPhieuNhap, "MANV", true));
            this.txtMaNhanVien.Enabled = false;
            this.txtMaNhanVien.Location = new System.Drawing.Point(120, 57);
            this.txtMaNhanVien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.Size = new System.Drawing.Size(98, 20);
            this.txtMaNhanVien.TabIndex = 2;
            // 
            // txtDonGiaChiTietPhieuNhap
            // 
            this.txtDonGiaChiTietPhieuNhap.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bdsChiTietPhieuNhap, "DONGIA", true));
            this.txtDonGiaChiTietPhieuNhap.Enabled = false;
            this.txtDonGiaChiTietPhieuNhap.Location = new System.Drawing.Point(120, 195);
            this.txtDonGiaChiTietPhieuNhap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDonGiaChiTietPhieuNhap.Maximum = new decimal(new int[] {
            1874919423,
            0,
            0,
            0});
            this.txtDonGiaChiTietPhieuNhap.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtDonGiaChiTietPhieuNhap.Name = "txtDonGiaChiTietPhieuNhap";
            this.txtDonGiaChiTietPhieuNhap.Size = new System.Drawing.Size(90, 20);
            this.txtDonGiaChiTietPhieuNhap.TabIndex = 3;
            this.txtDonGiaChiTietPhieuNhap.ThousandsSeparator = true;
            this.txtDonGiaChiTietPhieuNhap.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtSoLuongChiTietPhieuNhap
            // 
            this.txtSoLuongChiTietPhieuNhap.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bdsChiTietPhieuNhap, "SOLUONG", true));
            this.txtSoLuongChiTietPhieuNhap.Enabled = false;
            this.txtSoLuongChiTietPhieuNhap.Location = new System.Drawing.Point(120, 171);
            this.txtSoLuongChiTietPhieuNhap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSoLuongChiTietPhieuNhap.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txtSoLuongChiTietPhieuNhap.Name = "txtSoLuongChiTietPhieuNhap";
            this.txtSoLuongChiTietPhieuNhap.Size = new System.Drawing.Size(90, 20);
            this.txtSoLuongChiTietPhieuNhap.TabIndex = 4;
            // 
            // txtMaVatChiTietPhieuNhap
            // 
            this.txtMaVatChiTietPhieuNhap.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsChiTietPhieuNhap, "MAVT", true));
            this.txtMaVatChiTietPhieuNhap.Location = new System.Drawing.Point(120, 146);
            this.txtMaVatChiTietPhieuNhap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMaVatChiTietPhieuNhap.Name = "txtMaVatChiTietPhieuNhap";
            this.txtMaVatChiTietPhieuNhap.Size = new System.Drawing.Size(76, 20);
            this.txtMaVatChiTietPhieuNhap.TabIndex = 5;
            // 
            // btnChonDonHang
            // 
            this.btnChonDonHang.Enabled = false;
            this.btnChonDonHang.Location = new System.Drawing.Point(120, 104);
            this.btnChonDonHang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnChonDonHang.Name = "btnChonDonHang";
            this.btnChonDonHang.Size = new System.Drawing.Size(105, 21);
            this.btnChonDonHang.TabIndex = 6;
            this.btnChonDonHang.Text = "Chọn Đơn Hàng";
            this.btnChonDonHang.Click += new System.EventHandler(this.btnChonDonHang_Click);
            // 
            // txtMaDonDatHang
            // 
            this.txtMaDonDatHang.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsPhieuNhap, "MasoDDH", true));
            this.txtMaDonDatHang.Location = new System.Drawing.Point(120, 106);
            this.txtMaDonDatHang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMaDonDatHang.Name = "txtMaDonDatHang";
            this.txtMaDonDatHang.Size = new System.Drawing.Size(76, 20);
            this.txtMaDonDatHang.TabIndex = 7;
            // 
            // dteNgay
            // 
            this.dteNgay.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bdsPhieuNhap, "NGAY", true));
            this.dteNgay.Enabled = false;
            this.dteNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dteNgay.Location = new System.Drawing.Point(120, 24);
            this.dteNgay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dteNgay.Name = "dteNgay";
            this.dteNgay.Size = new System.Drawing.Size(151, 20);
            this.dteNgay.TabIndex = 8;
            // 
            // txtMaPhieuNhap
            // 
            this.txtMaPhieuNhap.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsPhieuNhap, "MAPN", true));
            this.txtMaPhieuNhap.Location = new System.Drawing.Point(120, 24);
            this.txtMaPhieuNhap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMaPhieuNhap.Name = "txtMaPhieuNhap";
            this.txtMaPhieuNhap.Size = new System.Drawing.Size(76, 20);
            this.txtMaPhieuNhap.TabIndex = 9;
            // 
            // txtDonGia
            // 
            this.txtDonGia.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bdsChiTietPhieuNhap, "DONGIA", true));
            this.txtDonGia.Enabled = false;
            this.txtDonGia.Location = new System.Drawing.Point(120, 292);
            this.txtDonGia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDonGia.Maximum = new decimal(new int[] {
            1874919423,
            0,
            0,
            0});
            this.txtDonGia.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(90, 20);
            this.txtDonGia.TabIndex = 10;
            this.txtDonGia.ThousandsSeparator = true;
            this.txtDonGia.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bdsChiTietPhieuNhap, "SOLUONG", true));
            this.txtSoLuong.Enabled = false;
            this.txtSoLuong.Location = new System.Drawing.Point(120, 268);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSoLuong.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(90, 20);
            this.txtSoLuong.TabIndex = 11;
            // 
            // btnChonVatTu
            // 
            this.btnChonVatTu.Enabled = false;
            this.btnChonVatTu.Location = new System.Drawing.Point(120, 242);
            this.btnChonVatTu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnChonVatTu.Name = "btnChonVatTu";
            this.btnChonVatTu.Size = new System.Drawing.Size(105, 21);
            this.btnChonVatTu.TabIndex = 12;
            this.btnChonVatTu.Text = "Chọn Vật Tư";
            // 
            // txtMaVatTu
            // 
            this.txtMaVatTu.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsChiTietPhieuNhap, "MAVT", true));
            this.txtMaVatTu.Location = new System.Drawing.Point(120, 244);
            this.txtMaVatTu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMaVatTu.Name = "txtMaVatTu";
            this.txtMaVatTu.Size = new System.Drawing.Size(76, 20);
            this.txtMaVatTu.TabIndex = 13;
            // 
            // phieuNhapTableAdapter
            // 
            this.phieuNhapTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhieuNhapTableAdapter = this.phieuNhapTableAdapter;
            this.tableAdapterManager.PhieuXuatTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLTVT.DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = null;
            // 
            // chiTietPhieuNhapTableAdapter
            // 
            this.chiTietPhieuNhapTableAdapter.ClearBeforeFill = true;
            // 
            // mAPNDataGridViewTextBoxColumn
            // 
            this.mAPNDataGridViewTextBoxColumn.DataPropertyName = "MAPN";
            this.mAPNDataGridViewTextBoxColumn.HeaderText = "MAPN";
            this.mAPNDataGridViewTextBoxColumn.Name = "mAPNDataGridViewTextBoxColumn";
            // 
            // nGAYDataGridViewTextBoxColumn
            // 
            this.nGAYDataGridViewTextBoxColumn.DataPropertyName = "NGAY";
            this.nGAYDataGridViewTextBoxColumn.HeaderText = "NGAY";
            this.nGAYDataGridViewTextBoxColumn.Name = "nGAYDataGridViewTextBoxColumn";
            // 
            // masoDDHDataGridViewTextBoxColumn
            // 
            this.masoDDHDataGridViewTextBoxColumn.DataPropertyName = "MasoDDH";
            this.masoDDHDataGridViewTextBoxColumn.HeaderText = "MasoDDH";
            this.masoDDHDataGridViewTextBoxColumn.Name = "masoDDHDataGridViewTextBoxColumn";
            // 
            // mANVDataGridViewTextBoxColumn
            // 
            this.mANVDataGridViewTextBoxColumn.DataPropertyName = "MANV";
            this.mANVDataGridViewTextBoxColumn.HeaderText = "MANV";
            this.mANVDataGridViewTextBoxColumn.Name = "mANVDataGridViewTextBoxColumn";
            // 
            // mAKHODataGridViewTextBoxColumn
            // 
            this.mAKHODataGridViewTextBoxColumn.DataPropertyName = "MAKHO";
            this.mAKHODataGridViewTextBoxColumn.HeaderText = "MAKHO";
            this.mAKHODataGridViewTextBoxColumn.Name = "mAKHODataGridViewTextBoxColumn";
            // 
            // mAPNDataGridViewTextBoxColumn1
            // 
            this.mAPNDataGridViewTextBoxColumn1.DataPropertyName = "MAPN";
            this.mAPNDataGridViewTextBoxColumn1.HeaderText = "MAPN";
            this.mAPNDataGridViewTextBoxColumn1.Name = "mAPNDataGridViewTextBoxColumn1";
            // 
            // mAVTDataGridViewTextBoxColumn
            // 
            this.mAVTDataGridViewTextBoxColumn.DataPropertyName = "MAVT";
            this.mAVTDataGridViewTextBoxColumn.HeaderText = "MAVT";
            this.mAVTDataGridViewTextBoxColumn.Name = "mAVTDataGridViewTextBoxColumn";
            // 
            // sOLUONGDataGridViewTextBoxColumn
            // 
            this.sOLUONGDataGridViewTextBoxColumn.DataPropertyName = "SOLUONG";
            this.sOLUONGDataGridViewTextBoxColumn.HeaderText = "SOLUONG";
            this.sOLUONGDataGridViewTextBoxColumn.Name = "sOLUONGDataGridViewTextBoxColumn";
            // 
            // dONGIADataGridViewTextBoxColumn
            // 
            this.dONGIADataGridViewTextBoxColumn.DataPropertyName = "DONGIA";
            this.dONGIADataGridViewTextBoxColumn.HeaderText = "DONGIA";
            this.dONGIADataGridViewTextBoxColumn.Name = "dONGIADataGridViewTextBoxColumn";
            // 
            // FormPhieuNhap_Std
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1656, 767);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormPhieuNhap_Std";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phiếu Nhập (chuẩn WinForms)";
            this.Load += new System.EventHandler(this.FormPhieuNhap_Std_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPhieuNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            this.panelRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTPN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsChiTietPhieuNhap)).EndInit();
            this.groupBoxPhieuNhap.ResumeLayout(false);
            this.groupBoxPhieuNhap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonGiaChiTietPhieuNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuongChiTietPhieuNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem btnMENU;
        private System.Windows.Forms.ToolStripMenuItem btnCheDoPhieuNhap;
        private System.Windows.Forms.ToolStripMenuItem btnCheDoChiTietPhieuNhap;
        private System.Windows.Forms.ToolStripMenuItem btnTHOAT;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.ComboBox cmbCHINHANH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCheDo;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvPhieuNhap;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.DataGridView dgvCTPN;
        private System.Windows.Forms.GroupBox groupBoxPhieuNhap;
        private System.Windows.Forms.Button btnChonChiTietDonHang;
        private System.Windows.Forms.TextBox txtMaKho;
        private System.Windows.Forms.TextBox txtMaNhanVien;
        private System.Windows.Forms.NumericUpDown txtDonGiaChiTietPhieuNhap;
        private System.Windows.Forms.NumericUpDown txtSoLuongChiTietPhieuNhap;
        private System.Windows.Forms.TextBox txtMaVatChiTietPhieuNhap;
        private System.Windows.Forms.Button btnChonDonHang;
        private System.Windows.Forms.TextBox txtMaDonDatHang;
        private System.Windows.Forms.DateTimePicker dteNgay;
        private System.Windows.Forms.TextBox txtMaPhieuNhap;
        private System.Windows.Forms.NumericUpDown txtDonGia;
        private System.Windows.Forms.NumericUpDown txtSoLuong;
        private System.Windows.Forms.Button btnChonVatTu;
        private System.Windows.Forms.TextBox txtMaVatTu;
        private QLTVT.DataSet dataSet;
        private System.Windows.Forms.BindingSource bdsPhieuNhap;
        private QLTVT.DataSetTableAdapters.PhieuNhapTableAdapter phieuNhapTableAdapter;
        private QLTVT.DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private QLTVT.DataSetTableAdapters.CTPNTableAdapter chiTietPhieuNhapTableAdapter;
        private System.Windows.Forms.BindingSource bdsChiTietPhieuNhap;
        private System.Windows.Forms.Label mAPNLabel;
        private System.Windows.Forms.Label nGAYLabel;
        private System.Windows.Forms.Label masoDDHLabel;
        private System.Windows.Forms.Label mAKHOLabel;
        private System.Windows.Forms.Label mANVLabel;
        private System.Windows.Forms.Label mAVTLabel1;
        private System.Windows.Forms.Label sOLUONGLabel1;
        private System.Windows.Forms.Label dONGIALabel1;
        private System.Windows.Forms.Label mAVTLabel;
        private System.Windows.Forms.Label sOLUONGLabel;
        private System.Windows.Forms.Label dONGIALabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAPNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nGAYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn masoDDHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mANVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAKHODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAPNDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAVTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sOLUONGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dONGIADataGridViewTextBoxColumn;
    }
}