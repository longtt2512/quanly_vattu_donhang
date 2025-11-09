namespace QLTVT.SubForm
{
    partial class FormChonNhanVien_Std
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
            this.components = new System.ComponentModel.Container();
            this.dataSet = new QLTVT.DataSet();
            this.bdsNhanVien = new System.Windows.Forms.BindingSource(this.components);
            this.nhanVienTableAdapter = new QLTVT.DataSetTableAdapters.NhanVienTableAdapter();
            this.tableAdapterManager = new QLTVT.DataSetTableAdapters.TableAdapterManager();
            this.panelTop = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCHINHANH = new System.Windows.Forms.ComboBox();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.colMANV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDIACHI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNGAYSINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLUONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMACN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThaiXoa = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnCHON = new System.Windows.Forms.Button();
            this.btnTHOAT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNhanVien)).BeginInit();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsNhanVien
            // 
            this.bdsNhanVien.DataMember = "NhanVien";
            this.bdsNhanVien.DataSource = this.dataSet;
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
            // panelTop
            // 
            this.panelTop.Controls.Add(this.label2);
            this.panelTop.Controls.Add(this.cmbCHINHANH);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(874, 60);
            this.panelTop.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label2.Location = new System.Drawing.Point(20, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chi nhánh";
            // 
            // cmbCHINHANH
            // 
            this.cmbCHINHANH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCHINHANH.Enabled = false;
            this.cmbCHINHANH.FormattingEnabled = true;
            this.cmbCHINHANH.Location = new System.Drawing.Point(140, 18);
            this.cmbCHINHANH.Name = "cmbCHINHANH";
            this.cmbCHINHANH.Size = new System.Drawing.Size(420, 24);
            this.cmbCHINHANH.TabIndex = 0;
            this.cmbCHINHANH.SelectedIndexChanged += new System.EventHandler(this.cmbCHINHANH_SelectedIndexChanged);
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.AllowUserToAddRows = false;
            this.dgvNhanVien.AllowUserToDeleteRows = false;
            this.dgvNhanVien.AutoGenerateColumns = false;
            this.dgvNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhanVien.DataSource = this.bdsNhanVien;
            this.dgvNhanVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvNhanVien.Location = new System.Drawing.Point(0, 60);
            this.dgvNhanVien.MultiSelect = false;
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.ReadOnly = true;
            this.dgvNhanVien.RowHeadersVisible = false;
            this.dgvNhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNhanVien.Size = new System.Drawing.Size(874, 420);
            this.dgvNhanVien.TabIndex = 1;
            // 
            // Columns
            // 
            this.colMANV.DataPropertyName = "MANV";
            this.colMANV.HeaderText = "Mã NV";
            this.colHO.DataPropertyName = "HO";
            this.colHO.HeaderText = "Họ";
            this.colTEN.DataPropertyName = "TEN";
            this.colTEN.HeaderText = "Tên";
            this.colDIACHI.DataPropertyName = "DIACHI";
            this.colDIACHI.HeaderText = "Địa chỉ";
            this.colNGAYSINH.DataPropertyName = "NGAYSINH";
            this.colNGAYSINH.HeaderText = "Ngày sinh";
            this.colLUONG.DataPropertyName = "LUONG";
            this.colLUONG.HeaderText = "Lương";
            this.colMACN.DataPropertyName = "MACN";
            this.colMACN.HeaderText = "Mã CN";
            this.colTrangThaiXoa.DataPropertyName = "TrangThaiXoa";
            this.colTrangThaiXoa.HeaderText = "Xóa?";
            this.dgvNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colMANV, this.colHO, this.colTEN, this.colDIACHI, this.colNGAYSINH,
                this.colLUONG, this.colMACN, this.colTrangThaiXoa
            });
            // 
            // btnCHON
            // 
            this.btnCHON.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCHON.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCHON.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnCHON.ForeColor = System.Drawing.Color.White;
            this.btnCHON.Location = new System.Drawing.Point(230, 500);
            this.btnCHON.Name = "btnCHON";
            this.btnCHON.Size = new System.Drawing.Size(150, 35);
            this.btnCHON.TabIndex = 2;
            this.btnCHON.Text = "CHỌN";
            this.btnCHON.UseVisualStyleBackColor = false;
            this.btnCHON.Click += new System.EventHandler(this.btnCHON_Click);
            // 
            // btnTHOAT
            // 
            this.btnTHOAT.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnTHOAT.BackColor = System.Drawing.Color.Firebrick;
            this.btnTHOAT.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnTHOAT.ForeColor = System.Drawing.Color.White;
            this.btnTHOAT.Location = new System.Drawing.Point(480, 500);
            this.btnTHOAT.Name = "btnTHOAT";
            this.btnTHOAT.Size = new System.Drawing.Size(150, 35);
            this.btnTHOAT.TabIndex = 3;
            this.btnTHOAT.Text = "THOÁT";
            this.btnTHOAT.UseVisualStyleBackColor = false;
            this.btnTHOAT.Click += new System.EventHandler(this.btnTHOAT_Click);
            // 
            // FormChonNhanVien_Std
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 560);
            this.Controls.Add(this.btnTHOAT);
            this.Controls.Add(this.btnCHON);
            this.Controls.Add(this.dgvNhanVien);
            this.Controls.Add(this.panelTop);
            this.Name = "FormChonNhanVien_Std";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chọn Nhân Viên";
            this.Load += new System.EventHandler(this.FormChonNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNhanVien)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.ResumeLayout(false);
        }
        #endregion

        private QLTVT.DataSet dataSet;
        private System.Windows.Forms.BindingSource bdsNhanVien;
        private QLTVT.DataSetTableAdapters.NhanVienTableAdapter nhanVienTableAdapter;
        private QLTVT.DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbCHINHANH;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMANV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHO;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDIACHI;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNGAYSINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLUONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMACN;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colTrangThaiXoa;
        private System.Windows.Forms.Button btnCHON;
        private System.Windows.Forms.Button btnTHOAT;
    }
}