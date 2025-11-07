
namespace QLTVT
{
    partial class FormVatTu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label mAVTLabel;
            System.Windows.Forms.Label tENVTLabel;
            System.Windows.Forms.Label dVTLabel;
            System.Windows.Forms.Label sOLUONGTONLabel;
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnTHEM = new System.Windows.Forms.ToolStripButton();
            this.btnXOA = new System.Windows.Forms.ToolStripButton();
            this.btnGHI = new System.Windows.Forms.ToolStripButton();
            this.btnHOANTAC = new System.Windows.Forms.ToolStripButton();
            this.btnLAMMOI = new System.Windows.Forms.ToolStripButton();
            this.btnTHOAT = new System.Windows.Forms.ToolStripButton();
            this.panelControl1 = new System.Windows.Forms.Panel();
            this.cmbCHINHANH = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataSet = new QLTVT.DataSet();
            this.bdsVatTu = new System.Windows.Forms.BindingSource(this.components);
            this.vattuTableAdapter = new QLTVT.DataSetTableAdapters.VattuTableAdapter();
            this.tableAdapterManager = new QLTVT.DataSetTableAdapters.TableAdapterManager();
            this.ctpxTableAdapter = new QLTVT.DataSetTableAdapters.CTPXTableAdapter();
            this.dgvVATTU = new System.Windows.Forms.DataGridView();
            this.colMAVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTENVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSOLUONGTON = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelNhapLieu = new System.Windows.Forms.GroupBox();
            this.txtSOLUONGTON = new System.Windows.Forms.NumericUpDown();
            this.txtDONVIVATTU = new System.Windows.Forms.TextBox();
            this.txtTENVT = new System.Windows.Forms.TextBox();
            this.txtMAVT = new System.Windows.Forms.TextBox();
            this.bdsCTPX = new System.Windows.Forms.BindingSource(this.components);
            this.bdsCTPN = new System.Windows.Forms.BindingSource(this.components);
            this.ctpnTableAdapter = new QLTVT.DataSetTableAdapters.CTPNTableAdapter();
            this.bdsCTDDH = new System.Windows.Forms.BindingSource(this.components);
            this.ctddhTableAdapter = new QLTVT.DataSetTableAdapters.CTDDHTableAdapter();
            mAVTLabel = new System.Windows.Forms.Label();
            tENVTLabel = new System.Windows.Forms.Label();
            dVTLabel = new System.Windows.Forms.Label();
            sOLUONGTONLabel = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsVatTu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVATTU)).BeginInit();
            this.panelNhapLieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSOLUONGTON)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTPX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTPN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTDDH)).BeginInit();
            this.SuspendLayout();
            // 
            // mAVTLabel
            // 
            mAVTLabel.AutoSize = true;
            mAVTLabel.Location = new System.Drawing.Point(9, 49);
            mAVTLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            mAVTLabel.Name = "mAVTLabel";
            mAVTLabel.Size = new System.Drawing.Size(54, 13);
            mAVTLabel.TabIndex = 0;
            mAVTLabel.Text = "Mã vật tư";
            // 
            // tENVTLabel
            // 
            tENVTLabel.AutoSize = true;
            tENVTLabel.Location = new System.Drawing.Point(140, 49);
            tENVTLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            tENVTLabel.Name = "tENVTLabel";
            tENVTLabel.Size = new System.Drawing.Size(58, 13);
            tENVTLabel.TabIndex = 2;
            tENVTLabel.Text = "Tên vật tư";
            // 
            // dVTLabel
            // 
            dVTLabel.AutoSize = true;
            dVTLabel.Location = new System.Drawing.Point(383, 49);
            dVTLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            dVTLabel.Name = "dVTLabel";
            dVTLabel.Size = new System.Drawing.Size(59, 13);
            dVTLabel.TabIndex = 4;
            dVTLabel.Text = "Đơn vị tính";
            // 
            // sOLUONGTONLabel
            // 
            sOLUONGTONLabel.AutoSize = true;
            sOLUONGTONLabel.Location = new System.Drawing.Point(582, 46);
            sOLUONGTONLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            sOLUONGTONLabel.Name = "sOLUONGTONLabel";
            sOLUONGTONLabel.Size = new System.Drawing.Size(68, 13);
            sOLUONGTONLabel.TabIndex = 6;
            sOLUONGTONLabel.Text = "Số lượng tồn";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnTHEM,
            this.btnXOA,
            this.btnGHI,
            this.btnHOANTAC,
            this.btnLAMMOI,
            this.btnTHOAT});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(810, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnTHEM
            // 
            this.btnTHEM.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnTHEM.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTHEM.Name = "btnTHEM";
            this.btnTHEM.Size = new System.Drawing.Size(60, 22);
            this.btnTHEM.Text = "Thêm";
            this.btnTHEM.Click += new System.EventHandler(this.btnTHEM_Click);
            // 
            // btnXOA
            // 
            this.btnXOA.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnXOA.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXOA.Name = "btnXOA";
            this.btnXOA.Size = new System.Drawing.Size(51, 22);
            this.btnXOA.Text = "Xoá";
            this.btnXOA.Click += new System.EventHandler(this.btnXOA_Click);
            // 
            // btnGHI
            // 
            this.btnGHI.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnGHI.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGHI.Name = "btnGHI";
            this.btnGHI.Size = new System.Drawing.Size(48, 22);
            this.btnGHI.Text = "Ghi";
            this.btnGHI.Click += new System.EventHandler(this.btnGHI_Click);
            // 
            // btnHOANTAC
            // 
            this.btnHOANTAC.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnHOANTAC.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHOANTAC.Name = "btnHOANTAC";
            this.btnHOANTAC.Size = new System.Drawing.Size(79, 22);
            this.btnHOANTAC.Text = "Hoàn Tác";
            this.btnHOANTAC.Click += new System.EventHandler(this.btnHOANTAC_Click);
            // 
            // btnLAMMOI
            // 
            this.btnLAMMOI.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnLAMMOI.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLAMMOI.Name = "btnLAMMOI";
            this.btnLAMMOI.Size = new System.Drawing.Size(72, 22);
            this.btnLAMMOI.Text = "Làm Mới";
            this.btnLAMMOI.Click += new System.EventHandler(this.btnLAMMOI_Click);
            // 
            // btnTHOAT
            // 
            this.btnTHOAT.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnTHOAT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTHOAT.Name = "btnTHOAT";
            this.btnTHOAT.Size = new System.Drawing.Size(59, 22);
            this.btnTHOAT.Text = "Thoát";
            this.btnTHOAT.Click += new System.EventHandler(this.btnTHOAT_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.cmbCHINHANH);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 25);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(810, 75);
            this.panelControl1.TabIndex = 5;
            // 
            // cmbCHINHANH
            // 
            this.cmbCHINHANH.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCHINHANH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCHINHANH.Enabled = false;
            this.cmbCHINHANH.FormattingEnabled = true;
            this.cmbCHINHANH.Location = new System.Drawing.Point(239, 22);
            this.cmbCHINHANH.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCHINHANH.Name = "cmbCHINHANH";
            this.cmbCHINHANH.Size = new System.Drawing.Size(550, 21);
            this.cmbCHINHANH.TabIndex = 1;
            this.cmbCHINHANH.SelectedIndexChanged += new System.EventHandler(this.cmbCHINHANH_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(130, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chi Nhánh";
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsVatTu
            // 
            this.bdsVatTu.DataMember = "Vattu";
            this.bdsVatTu.DataSource = this.dataSet;
            // 
            // vattuTableAdapter
            // 
            this.vattuTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.CTDDHTableAdapter = null;
            this.tableAdapterManager.CTPNTableAdapter = null;
            this.tableAdapterManager.CTPXTableAdapter = this.ctpxTableAdapter;
            this.tableAdapterManager.DatHangTableAdapter = null;
            this.tableAdapterManager.KhoTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhieuNhapTableAdapter = null;
            this.tableAdapterManager.PhieuXuatTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLTVT.DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = this.vattuTableAdapter;
            // 
            // ctpxTableAdapter
            // 
            this.ctpxTableAdapter.ClearBeforeFill = true;
            // 
            // dgvVATTU
            // 
            this.dgvVATTU.AllowUserToAddRows = false;
            this.dgvVATTU.AllowUserToDeleteRows = false;
            this.dgvVATTU.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVATTU.AutoGenerateColumns = false;
            this.dgvVATTU.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVATTU.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVATTU.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMAVT,
            this.colTENVT,
            this.colDVT,
            this.colSOLUONGTON});
            this.dgvVATTU.DataSource = this.bdsVatTu;
            this.dgvVATTU.Location = new System.Drawing.Point(10, 110);
            this.dgvVATTU.Margin = new System.Windows.Forms.Padding(2);
            this.dgvVATTU.Name = "dgvVATTU";
            this.dgvVATTU.ReadOnly = true;
            this.dgvVATTU.RowTemplate.Height = 24;
            this.dgvVATTU.Size = new System.Drawing.Size(790, 230);
            this.dgvVATTU.TabIndex = 16;
            // 
            // colMAVT
            // 
            this.colMAVT.DataPropertyName = "MAVT";
            this.colMAVT.FillWeight = 80F;
            this.colMAVT.HeaderText = "Mã Vật Tư";
            this.colMAVT.Name = "colMAVT";
            this.colMAVT.ReadOnly = true;
            // 
            // colTENVT
            // 
            this.colTENVT.DataPropertyName = "TENVT";
            this.colTENVT.FillWeight = 150F;
            this.colTENVT.HeaderText = "Tên Vật Tư";
            this.colTENVT.Name = "colTENVT";
            this.colTENVT.ReadOnly = true;
            // 
            // colDVT
            // 
            this.colDVT.DataPropertyName = "DVT";
            this.colDVT.FillWeight = 100F;
            this.colDVT.HeaderText = "Đơn Vị Tính";
            this.colDVT.Name = "colDVT";
            this.colDVT.ReadOnly = true;
            // 
            // colSOLUONGTON
            // 
            this.colSOLUONGTON.DataPropertyName = "SOLUONGTON";
            this.colSOLUONGTON.FillWeight = 100F;
            this.colSOLUONGTON.HeaderText = "Số Lượng Tồn";
            this.colSOLUONGTON.Name = "colSOLUONGTON";
            this.colSOLUONGTON.ReadOnly = true;
            // 
            // panelNhapLieu
            // 
            this.panelNhapLieu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelNhapLieu.Controls.Add(sOLUONGTONLabel);
            this.panelNhapLieu.Controls.Add(this.txtSOLUONGTON);
            this.panelNhapLieu.Controls.Add(dVTLabel);
            this.panelNhapLieu.Controls.Add(this.txtDONVIVATTU);
            this.panelNhapLieu.Controls.Add(tENVTLabel);
            this.panelNhapLieu.Controls.Add(this.txtTENVT);
            this.panelNhapLieu.Controls.Add(mAVTLabel);
            this.panelNhapLieu.Controls.Add(this.txtMAVT);
            this.panelNhapLieu.Location = new System.Drawing.Point(10, 350);
            this.panelNhapLieu.Margin = new System.Windows.Forms.Padding(2);
            this.panelNhapLieu.Name = "panelNhapLieu";
            this.panelNhapLieu.Size = new System.Drawing.Size(790, 140);
            this.panelNhapLieu.TabIndex = 21;
            this.panelNhapLieu.TabStop = false;
            this.panelNhapLieu.Text = "Thông tin";
            this.panelNhapLieu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelNhapLieu_Paint);
            // 
            // txtSOLUONGTON
            // 
            this.txtSOLUONGTON.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bdsVatTu, "SOLUONGTON", true));
            this.txtSOLUONGTON.Location = new System.Drawing.Point(660, 45);
            this.txtSOLUONGTON.Margin = new System.Windows.Forms.Padding(2);
            this.txtSOLUONGTON.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.txtSOLUONGTON.Name = "txtSOLUONGTON";
            this.txtSOLUONGTON.Size = new System.Drawing.Size(94, 20);
            this.txtSOLUONGTON.TabIndex = 7;
            this.txtSOLUONGTON.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtDONVIVATTU
            // 
            this.txtDONVIVATTU.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsVatTu, "DVT", true));
            this.txtDONVIVATTU.Location = new System.Drawing.Point(453, 46);
            this.txtDONVIVATTU.Margin = new System.Windows.Forms.Padding(2);
            this.txtDONVIVATTU.Name = "txtDONVIVATTU";
            this.txtDONVIVATTU.Size = new System.Drawing.Size(94, 20);
            this.txtDONVIVATTU.TabIndex = 5;
            // 
            // txtTENVT
            // 
            this.txtTENVT.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsVatTu, "TENVT", true));
            this.txtTENVT.Location = new System.Drawing.Point(216, 46);
            this.txtTENVT.Margin = new System.Windows.Forms.Padding(2);
            this.txtTENVT.Name = "txtTENVT";
            this.txtTENVT.Size = new System.Drawing.Size(140, 20);
            this.txtTENVT.TabIndex = 3;
            // 
            // txtMAVT
            // 
            this.txtMAVT.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsVatTu, "MAVT", true));
            this.txtMAVT.Location = new System.Drawing.Point(70, 46);
            this.txtMAVT.Margin = new System.Windows.Forms.Padding(2);
            this.txtMAVT.Name = "txtMAVT";
            this.txtMAVT.Size = new System.Drawing.Size(40, 20);
            this.txtMAVT.TabIndex = 1;
            // 
            // bdsCTPX
            // 
            this.bdsCTPX.DataMember = "FK_CTPX_VatTu";
            this.bdsCTPX.DataSource = this.bdsVatTu;
            // 
            // bdsCTPN
            // 
            this.bdsCTPN.DataMember = "FK_CTPN_VatTu";
            this.bdsCTPN.DataSource = this.bdsVatTu;
            // 
            // ctpnTableAdapter
            // 
            this.ctpnTableAdapter.ClearBeforeFill = true;
            // 
            // bdsCTDDH
            // 
            this.bdsCTDDH.DataMember = "FK_CTDDH_VatTu";
            this.bdsCTDDH.DataSource = this.bdsVatTu;
            // 
            // ctddhTableAdapter
            // 
            this.ctddhTableAdapter.ClearBeforeFill = true;
            // 
            // FormVatTu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 502);
            this.Controls.Add(this.panelNhapLieu);
            this.Controls.Add(this.dgvVATTU);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(650, 450);
            this.Name = "FormVatTu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vật Tư";
            this.Load += new System.EventHandler(this.FormVatTu_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsVatTu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVATTU)).EndInit();
            this.panelNhapLieu.ResumeLayout(false);
            this.panelNhapLieu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSOLUONGTON)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTPX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTPN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTDDH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnTHEM;
        private System.Windows.Forms.ToolStripButton btnXOA;
        private System.Windows.Forms.ToolStripButton btnGHI;
        private System.Windows.Forms.ToolStripButton btnHOANTAC;
        private System.Windows.Forms.ToolStripButton btnLAMMOI;
        private System.Windows.Forms.ToolStripButton btnTHOAT;
        private System.Windows.Forms.Panel panelControl1;
        private System.Windows.Forms.ComboBox cmbCHINHANH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bdsVatTu;
        private DataSet dataSet;
        private DataSetTableAdapters.VattuTableAdapter vattuTableAdapter;
        private QLTVT.DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dgvVATTU;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMAVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTENVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSOLUONGTON;
        private System.Windows.Forms.GroupBox panelNhapLieu;
        private System.Windows.Forms.NumericUpDown txtSOLUONGTON;
        private System.Windows.Forms.TextBox txtDONVIVATTU;
        private System.Windows.Forms.TextBox txtTENVT;
        private System.Windows.Forms.TextBox txtMAVT;
        private System.Windows.Forms.BindingSource bdsCTPX;
        private DataSetTableAdapters.CTPXTableAdapter ctpxTableAdapter;
        private System.Windows.Forms.BindingSource bdsCTPN;
        private DataSetTableAdapters.CTPNTableAdapter ctpnTableAdapter;
        private System.Windows.Forms.BindingSource bdsCTDDH;
        private DataSetTableAdapters.CTDDHTableAdapter ctddhTableAdapter;
    }
}