
namespace QLTVT
{
    partial class FormKho
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
            System.Windows.Forms.Label mAKHOLabel;
            System.Windows.Forms.Label tENKHOLabel;
            System.Windows.Forms.Label dIACHILabel;
            System.Windows.Forms.Label mACNLabel;
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnTHEM = new System.Windows.Forms.ToolStripButton();
            this.btnXOA = new System.Windows.Forms.ToolStripButton();
            this.btnGHI = new System.Windows.Forms.ToolStripButton();
            this.btnHOANTAC = new System.Windows.Forms.ToolStripButton();
            this.btnLAMMOI = new System.Windows.Forms.ToolStripButton();
            this.btnTHOAT = new System.Windows.Forms.ToolStripButton();
            this.panelControl1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCHINHANH = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataSet = new QLTVT.DataSet();
            this.bdsKho = new System.Windows.Forms.BindingSource(this.components);
            this.khoTableAdapter = new QLTVT.DataSetTableAdapters.KhoTableAdapter();
            this.tableAdapterManager = new QLTVT.DataSetTableAdapters.TableAdapterManager();
            this.dgvKHO = new System.Windows.Forms.DataGridView();
            this.colMAKHO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTENKHO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDIACHI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMACN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelNhapLieu = new System.Windows.Forms.GroupBox();
            this.txtMACHINHANH = new System.Windows.Forms.TextBox();
            this.txtDIACHI = new System.Windows.Forms.TextBox();
            this.txtTENKHO = new System.Windows.Forms.TextBox();
            this.txtMAKHO = new System.Windows.Forms.TextBox();
            this.bdsPHIEUXUAT = new System.Windows.Forms.BindingSource(this.components);
            this.phieuXuatTableAdapter = new QLTVT.DataSetTableAdapters.PhieuXuatTableAdapter();
            this.bdsPHIEUNHAP = new System.Windows.Forms.BindingSource(this.components);
            this.phieuNhapTableAdapter = new QLTVT.DataSetTableAdapters.PhieuNhapTableAdapter();
            this.bdsDATHANG = new System.Windows.Forms.BindingSource(this.components);
            this.datHangTableAdapter = new QLTVT.DataSetTableAdapters.DatHangTableAdapter();
            mAKHOLabel = new System.Windows.Forms.Label();
            tENKHOLabel = new System.Windows.Forms.Label();
            dIACHILabel = new System.Windows.Forms.Label();
            mACNLabel = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKHO)).BeginInit();
            this.panelNhapLieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPHIEUXUAT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPHIEUNHAP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDATHANG)).BeginInit();
            this.SuspendLayout();
            // 
            // mAKHOLabel
            // 
            mAKHOLabel.AutoSize = true;
            mAKHOLabel.Location = new System.Drawing.Point(80, 139);
            mAKHOLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            mAKHOLabel.Name = "mAKHOLabel";
            mAKHOLabel.Size = new System.Drawing.Size(53, 17);
            mAKHOLabel.TabIndex = 0;
            mAKHOLabel.Text = "Mã Kho";
            // 
            // tENKHOLabel
            // 
            tENKHOLabel.AutoSize = true;
            tENKHOLabel.Location = new System.Drawing.Point(558, 129);
            tENKHOLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            tENKHOLabel.Name = "tENKHOLabel";
            tENKHOLabel.Size = new System.Drawing.Size(59, 17);
            tENKHOLabel.TabIndex = 2;
            tENKHOLabel.Text = "Tên Kho";
            // 
            // dIACHILabel
            // 
            dIACHILabel.AutoSize = true;
            dIACHILabel.Location = new System.Drawing.Point(83, 186);
            dIACHILabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            dIACHILabel.Name = "dIACHILabel";
            dIACHILabel.Size = new System.Drawing.Size(50, 17);
            dIACHILabel.TabIndex = 4;
            dIACHILabel.Text = "Địa Chỉ";
            // 
            // mACNLabel
            // 
            mACNLabel.AutoSize = true;
            mACNLabel.Location = new System.Drawing.Point(558, 186);
            mACNLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            mACNLabel.Name = "mACNLabel";
            mACNLabel.Size = new System.Drawing.Size(92, 17);
            mACNLabel.TabIndex = 6;
            mACNLabel.Text = "Mã Chi Nhánh";
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
            this.toolStrip1.Size = new System.Drawing.Size(1019, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnTHEM
            // 
            this.btnTHEM.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnTHEM.Name = "btnTHEM";
            this.btnTHEM.Size = new System.Drawing.Size(60, 22);
            this.btnTHEM.Text = "Thêm";
            this.btnTHEM.Click += new System.EventHandler(this.btnTHEM_Click);
            // 
            // btnXOA
            // 
            this.btnXOA.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnXOA.Name = "btnXOA";
            this.btnXOA.Size = new System.Drawing.Size(51, 22);
            this.btnXOA.Text = "Xoá";
            this.btnXOA.Click += new System.EventHandler(this.btnXOA_Click);
            // 
            // btnGHI
            // 
            this.btnGHI.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnGHI.Name = "btnGHI";
            this.btnGHI.Size = new System.Drawing.Size(48, 22);
            this.btnGHI.Text = "Ghi";
            this.btnGHI.Click += new System.EventHandler(this.btnGHI_Click);
            // 
            // btnHOANTAC
            // 
            this.btnHOANTAC.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnHOANTAC.Name = "btnHOANTAC";
            this.btnHOANTAC.Size = new System.Drawing.Size(79, 22);
            this.btnHOANTAC.Text = "Hoàn Tác";
            this.btnHOANTAC.Click += new System.EventHandler(this.btnHOANTAC_Click);
            // 
            // btnLAMMOI
            // 
            this.btnLAMMOI.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnLAMMOI.Name = "btnLAMMOI";
            this.btnLAMMOI.Size = new System.Drawing.Size(72, 22);
            this.btnLAMMOI.Text = "Làm Mới";
            this.btnLAMMOI.Click += new System.EventHandler(this.btnLAMMOI_Click);
            // 
            // btnTHOAT
            // 
            this.btnTHOAT.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnTHOAT.Name = "btnTHOAT";
            this.btnTHOAT.Size = new System.Drawing.Size(59, 22);
            this.btnTHOAT.Text = "Thoát";
            this.btnTHOAT.Click += new System.EventHandler(this.btnTHOAT_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.cmbCHINHANH);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 25);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(8);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1019, 80);
            this.panelControl1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(197, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Chi Nhánh";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cmbCHINHANH
            // 
            this.cmbCHINHANH.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCHINHANH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCHINHANH.Enabled = false;
            this.cmbCHINHANH.FormattingEnabled = true;
            this.cmbCHINHANH.Location = new System.Drawing.Point(354, 35);
            this.cmbCHINHANH.Margin = new System.Windows.Forms.Padding(8);
            this.cmbCHINHANH.Name = "cmbCHINHANH";
            this.cmbCHINHANH.Size = new System.Drawing.Size(640, 24);
            this.cmbCHINHANH.TabIndex = 1;
            this.cmbCHINHANH.SelectedIndexChanged += new System.EventHandler(this.cmbCHINHANH_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 45);
            this.label1.TabIndex = 2;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsKho
            // 
            this.bdsKho.DataMember = "Kho";
            this.bdsKho.DataSource = this.dataSet;
            // 
            // khoTableAdapter
            // 
            this.khoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.CTDDHTableAdapter = null;
            this.tableAdapterManager.CTPNTableAdapter = null;
            this.tableAdapterManager.CTPXTableAdapter = null;
            this.tableAdapterManager.DatHangTableAdapter = null;
            this.tableAdapterManager.KhoTableAdapter = this.khoTableAdapter;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhieuNhapTableAdapter = null;
            this.tableAdapterManager.PhieuXuatTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLTVT.DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = null;
            // 
            // dgvKHO
            // 
            this.dgvKHO.AllowUserToAddRows = false;
            this.dgvKHO.AllowUserToDeleteRows = false;
            this.dgvKHO.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvKHO.AutoGenerateColumns = false;
            this.dgvKHO.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKHO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKHO.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMAKHO,
            this.colTENKHO,
            this.colDIACHI,
            this.colMACN});
            this.dgvKHO.DataSource = this.bdsKho;
            this.dgvKHO.Location = new System.Drawing.Point(12, 115);
            this.dgvKHO.Margin = new System.Windows.Forms.Padding(8);
            this.dgvKHO.Name = "dgvKHO";
            this.dgvKHO.ReadOnly = true;
            this.dgvKHO.RowTemplate.Height = 24;
            this.dgvKHO.Size = new System.Drawing.Size(995, 220);
            this.dgvKHO.TabIndex = 6;
            // 
            // colMAKHO
            // 
            this.colMAKHO.DataPropertyName = "MAKHO";
            this.colMAKHO.FillWeight = 80F;
            this.colMAKHO.HeaderText = "Mã Kho";
            this.colMAKHO.Name = "colMAKHO";
            this.colMAKHO.ReadOnly = true;
            // 
            // colTENKHO
            // 
            this.colTENKHO.DataPropertyName = "TENKHO";
            this.colTENKHO.FillWeight = 120F;
            this.colTENKHO.HeaderText = "Tên Kho";
            this.colTENKHO.Name = "colTENKHO";
            this.colTENKHO.ReadOnly = true;
            // 
            // colDIACHI
            // 
            this.colDIACHI.DataPropertyName = "DIACHI";
            this.colDIACHI.FillWeight = 150F;
            this.colDIACHI.HeaderText = "Địa Chỉ";
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.ReadOnly = true;
            // 
            // colMACN
            // 
            this.colMACN.DataPropertyName = "MACN";
            this.colMACN.FillWeight = 80F;
            this.colMACN.HeaderText = "Mã Chi Nhánh";
            this.colMACN.Name = "colMACN";
            this.colMACN.ReadOnly = true;
            // 
            // panelNhapLieu
            // 
            this.panelNhapLieu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelNhapLieu.Controls.Add(mACNLabel);
            this.panelNhapLieu.Controls.Add(this.txtMACHINHANH);
            this.panelNhapLieu.Controls.Add(dIACHILabel);
            this.panelNhapLieu.Controls.Add(this.txtDIACHI);
            this.panelNhapLieu.Controls.Add(tENKHOLabel);
            this.panelNhapLieu.Controls.Add(this.txtTENKHO);
            this.panelNhapLieu.Controls.Add(mAKHOLabel);
            this.panelNhapLieu.Controls.Add(this.txtMAKHO);
            this.panelNhapLieu.Location = new System.Drawing.Point(12, 345);
            this.panelNhapLieu.Margin = new System.Windows.Forms.Padding(8);
            this.panelNhapLieu.Name = "panelNhapLieu";
            this.panelNhapLieu.Size = new System.Drawing.Size(995, 240);
            this.panelNhapLieu.TabIndex = 11;
            this.panelNhapLieu.TabStop = false;
            this.panelNhapLieu.Text = "Thông tin";
            // 
            // txtMACHINHANH
            // 
            this.txtMACHINHANH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsKho, "MACN", true));
            this.txtMACHINHANH.Enabled = false;
            this.txtMACHINHANH.Location = new System.Drawing.Point(673, 186);
            this.txtMACHINHANH.Margin = new System.Windows.Forms.Padding(8);
            this.txtMACHINHANH.Name = "txtMACHINHANH";
            this.txtMACHINHANH.Size = new System.Drawing.Size(157, 22);
            this.txtMACHINHANH.TabIndex = 7;
            // 
            // txtDIACHI
            // 
            this.txtDIACHI.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsKho, "DIACHI", true));
            this.txtDIACHI.Location = new System.Drawing.Point(293, 178);
            this.txtDIACHI.Margin = new System.Windows.Forms.Padding(8);
            this.txtDIACHI.Name = "txtDIACHI";
            this.txtDIACHI.Size = new System.Drawing.Size(214, 22);
            this.txtDIACHI.TabIndex = 5;
            // 
            // txtTENKHO
            // 
            this.txtTENKHO.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsKho, "TENKHO", true));
            this.txtTENKHO.Location = new System.Drawing.Point(673, 124);
            this.txtTENKHO.Margin = new System.Windows.Forms.Padding(8);
            this.txtTENKHO.Name = "txtTENKHO";
            this.txtTENKHO.Size = new System.Drawing.Size(157, 22);
            this.txtTENKHO.TabIndex = 3;
            // 
            // txtMAKHO
            // 
            this.txtMAKHO.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsKho, "MAKHO", true));
            this.txtMAKHO.Location = new System.Drawing.Point(290, 126);
            this.txtMAKHO.Margin = new System.Windows.Forms.Padding(8);
            this.txtMAKHO.Name = "txtMAKHO";
            this.txtMAKHO.Size = new System.Drawing.Size(112, 22);
            this.txtMAKHO.TabIndex = 1;
            // 
            // bdsPHIEUXUAT
            // 
            this.bdsPHIEUXUAT.DataMember = "FK_PhieuXuat_Kho";
            this.bdsPHIEUXUAT.DataSource = this.bdsKho;
            // 
            // phieuXuatTableAdapter
            // 
            this.phieuXuatTableAdapter.ClearBeforeFill = true;
            // 
            // bdsPHIEUNHAP
            // 
            this.bdsPHIEUNHAP.DataMember = "FK_PhieuNhap_Kho";
            this.bdsPHIEUNHAP.DataSource = this.bdsKho;
            // 
            // phieuNhapTableAdapter
            // 
            this.phieuNhapTableAdapter.ClearBeforeFill = true;
            // 
            // bdsDATHANG
            // 
            this.bdsDATHANG.DataMember = "FK_DatHang_Kho";
            this.bdsDATHANG.DataSource = this.bdsKho;
            // 
            // datHangTableAdapter
            // 
            this.datHangTableAdapter.ClearBeforeFill = true;
            // 
            // FormKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 603);
            this.Controls.Add(this.panelNhapLieu);
            this.Controls.Add(this.dgvKHO);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.toolStrip1);
            this.MinimumSize = new System.Drawing.Size(800, 550);
            this.Name = "FormKho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kho Hàng";
            this.Load += new System.EventHandler(this.FormKho_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKHO)).EndInit();
            this.panelNhapLieu.ResumeLayout(false);
            this.panelNhapLieu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPHIEUXUAT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPHIEUNHAP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDATHANG)).EndInit();
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
        private System.Windows.Forms.BindingSource bdsKho;
        private DataSet dataSet;
        private DataSetTableAdapters.KhoTableAdapter khoTableAdapter;
        private DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dgvKHO;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMAKHO;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTENKHO;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDIACHI;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMACN;
        private System.Windows.Forms.GroupBox panelNhapLieu;
        private System.Windows.Forms.TextBox txtMACHINHANH;
        private System.Windows.Forms.TextBox txtDIACHI;
        private System.Windows.Forms.TextBox txtTENKHO;
        private System.Windows.Forms.TextBox txtMAKHO;
        private System.Windows.Forms.BindingSource bdsPHIEUXUAT;
        private DataSetTableAdapters.PhieuXuatTableAdapter phieuXuatTableAdapter;
        private System.Windows.Forms.BindingSource bdsPHIEUNHAP;
        private DataSetTableAdapters.PhieuNhapTableAdapter phieuNhapTableAdapter;
        private System.Windows.Forms.BindingSource bdsDATHANG;
        private DataSetTableAdapters.DatHangTableAdapter datHangTableAdapter;
        private System.Windows.Forms.Label label2;
    }
}