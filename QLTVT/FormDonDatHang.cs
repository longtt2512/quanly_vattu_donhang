using DevExpress.XtraGrid;
using QLTVT.SubForm;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTVT
{

    public partial class FormDonDatHang : Form
    {
        /* v? trí c?a con tr? trên grid view*/
        int viTri = 0;
        /********************************************
         * ðang thêm m?i -> true -> ðang dùng btnTHEM
         *              -> false -> có th? là btnGHI( ch?nh s?a) ho?c btnXOA
         *              
         * M?c ðích: dùng bi?n này ð? phân bi?t gi?a btnTHEM - thêm m?i hoàn toàn
         * và vi?c ch?nh s?a nhân viên( do m?nh ko dùng thêm btnXOA )
         * Tr?ng thái true or false s? ðý?c s? d?ng 
         * trong btnGHI - vi?c này ð? ph?c v? cho btnHOANTAC
         ********************************************/
        bool dangThemMoi = false;
        public string makho = "";   
        string maChiNhanh = "";
        /**********************************************************
         * undoList - ph?c v? cho btnHOANTAC -  ch?a các thông tin c?a ð?i tý?ng b? tác ð?ng 
         * 
         * nó là nõi lýu tr? các ð?i tý?ng c?n thi?t ð? hoàn tác các thao tác
         * 
         * n?u btnGHI s? ?ng v?i INSERT
         * n?u btnXOA s? ?ng v?i DELETE
         * n?u btnCHUYENCHINHANH s? ?ng v?i CHANGEBRAND
         **********************************************************/
        Stack undoList = new Stack();



        /********************************************************
         * ch?a nh?ng d? li?u hi?n t?i ðang làm vi?c
         * gc ch?a grid view ðang làm vi?c
         ********************************************************/
        BindingSource bds = null;
        GridControl gc = null;
        string type = "";



        /************************************************************
         * CheckExists:
         * Ð? tránh vi?c ngý?i dùng ?n vào 1 form ð?n 2 l?n chúng ta 
         * c?n s? d?ng hàm này ð? ki?m tra xem cái form hi?n t?i ð? 
         * có trong b? nh? chýa
         * N?u có tr? v? "f"
         * N?u không tr? v? "null"
         ************************************************************/
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }
        public FormDonDatHang()
        {
            InitializeComponent();
        }

        private void datHangBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsDonDatHang.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet);

        }

        private void FormDonDatHang_Load(object sender, EventArgs e)
        {
            
            /*Step 1*/
            dataSet.EnforceConstraints = false;

            this.chiTietDonDatHangTableAdapter.Connection.ConnectionString = Program.connstr;
            this.chiTietDonDatHangTableAdapter.Fill(this.dataSet.CTDDH);

            this.donDatHangTableAdapter.Connection.ConnectionString = Program.connstr;
            this.donDatHangTableAdapter.Fill(this.dataSet.DatHang);

            this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuNhapTableAdapter.Fill(this.dataSet.PhieuNhap);
            /*van con ton tai loi chua sua duoc*/
            //maChiNhanh = ((DataRowView)bdsVatTu[0])["MACN"].ToString();

            /*Step 2*/
            cmbCHINHANH.DataSource = Program.bindingSource;/*sao chep bingding source tu form dang nhap*/
            cmbCHINHANH.DisplayMember = "TENCN";
            cmbCHINHANH.ValueMember = "TENSERVER";
            cmbCHINHANH.SelectedIndex = Program.brand;

            
            bds = bdsDonDatHang;
            gc = gcDonDatHang;

            /*Step 3: B?t grid Chi Ti?t Ðõn Hàng ð? luôn hi?n th? danh sách chi ti?t*/
            gcChiTietDonDatHang.Enabled = true;

            /*Step 4: T? ð?ng kích ho?t ch? ð? "Ðõn Ð?t Hàng" khi form load*/
            btnCheDoDonDatHang_ItemClick(null, null);
            
        }

        private void sOLUONGSpinEdit_EditValueChanged(object sender, EventArgs e)
        {

        }



        /*********************************************************
         * Step 0: Hi?n ch? ð? làm vi?c
         * Step 1: c?p nh?t binding source và grid control
         * 
         * t?t các ch?c nãng liên quan t?i chi ti?t ðõn hàng
         *********************************************************/
        private void btnCheDoDonDatHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            /*Step 0 - B? qua vi?c c?p nh?t caption v? ð? ?n menu*/
            // btnMENU.Links[0].Caption = "Ðõn Ð?t Hàng";

            /*Step 1*/
            bds = bdsDonDatHang;
            gc = gcDonDatHang;
            //MessageBox.Show("Ch? Ð? Làm Vi?c Ðõn Ð?t Hàng", "Thông báo", MessageBoxButtons.OK);

            /*Step 2*/
            /*Bat chuc nang cua don dat hang*/
            txtMaDonDatHang.Enabled = false;
            dteNGAY.Enabled = false;

            txtNhaCungCap.Enabled = true;
            txtMaNhanVien.Enabled = false;

            txtMaKho.Enabled = false;
            btnChonKhoHang.Enabled = true;

            /*Tat chuc nang cua chi tiet don hang*/
            txtMaVatTu.Enabled = false;
            btnChonVatTu.Enabled = false;
            txtSoLuong.Enabled = false;
            txtDonGia.Enabled = false;

            /*Bat cac grid control len*/
            gcDonDatHang.Enabled = true;
            gcChiTietDonDatHang.Enabled = true;

            /*Làm n?i b?t grid Ðõn Ð?t Hàng - dùng ViewCaption Background*/
            gridView1.Appearance.ViewCaption.BackColor = System.Drawing.Color.DeepSkyBlue;
            gridView1.Appearance.ViewCaption.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            gvCTDDH.Appearance.ViewCaption.BackColor = System.Drawing.SystemColors.Control;
            gvCTDDH.Appearance.ViewCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular);

            /*Step 3*/
            /*CONG TY chi xem du lieu*/
            if (Program.role == "CONGTY")
            {
                cmbCHINHANH.Enabled = true;

                this.btnTHEM.Enabled = false;
                this.btnXOA.Enabled = false;
                this.btnGHI.Enabled = false;

                this.btnHOANTAC.Enabled = false;
                this.btnLAMMOI.Enabled = true;
                // this.btnMENU.Enabled = false; // Ð? ?n menu
                this.btnTHOAT.Enabled = true;

                this.groupBoxDonDatHang.Enabled = false;


            }

            /* CHI NHANH & USER co the xem - xoa - sua du lieu nhung khong the 
             chuyen sang chi nhanh khac*/
            if (Program.role == "CHINHANH" || Program.role == "USER")
            {
                cmbCHINHANH.Enabled = false;

                this.btnTHEM.Enabled = true;
                bool turnOn = (bdsDonDatHang.Count > 0) ? true : false;
                this.btnXOA.Enabled = turnOn;
                this.btnGHI.Enabled = true;

                this.btnHOANTAC.Enabled = false;
                this.btnLAMMOI.Enabled = true;
                // this.btnMENU.Enabled = true; // Ð? ?n menu
                this.btnTHOAT.Enabled = true;

                this.txtMaDonDatHang.Enabled = false;

            }
        }

        private void btnCheDoChiTietDonDatHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            /*Step 0 - B? qua vi?c c?p nh?t caption v? ð? ?n menu*/
            // btnMENU.Links[0].Caption = "Chi Ti?t Ðõn Ð?t Hàng";

            /*Step 1*/
            bds = bdsChiTietDonDatHang;
            gc = gcChiTietDonDatHang;
            //MessageBox.Show("Ch? Ð? Làm Vi?c Chi Ti?t Ðõn Ð?t Hàng", "Thông báo", MessageBoxButtons.OK);

            /*Step 2*/
            /*Tat chuc nang don dat hang*/
            txtMaDonDatHang.Enabled = false;
            dteNGAY.Enabled = false;

            txtNhaCungCap.Enabled = false;
            txtMaNhanVien.Enabled = false;

            txtMaKho.Enabled = false;
            btnChonKhoHang.Enabled = false;

            /*Bat chuc nang cua chi tiet don hang*/
            txtMaVatTu.Enabled = false;
            btnChonVatTu.Enabled = false;
            txtSoLuong.Enabled = true;
            txtDonGia.Enabled = true;


            /*Bat cac grid control len*/
            gcDonDatHang.Enabled = true;
            gcChiTietDonDatHang.Enabled = true;

            /*Làm n?i b?t grid Chi Ti?t Ðõn Ð?t Hàng - dùng ViewCaption Background*/
            gridView1.Appearance.ViewCaption.BackColor = System.Drawing.SystemColors.Control;
            gridView1.Appearance.ViewCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular);
            gvCTDDH.Appearance.ViewCaption.BackColor = System.Drawing.Color.DeepSkyBlue;
            gvCTDDH.Appearance.ViewCaption.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);

            /*Step 3*/
            /*CONG TY chi xem du lieu*/
            if (Program.role == "CONGTY")
            {
                cmbCHINHANH.Enabled = true;

                this.btnTHEM.Enabled = false;
                this.btnXOA.Enabled = false;
                this.btnGHI.Enabled = false;

                this.btnHOANTAC.Enabled = false;
                this.btnLAMMOI.Enabled = true;
                // this.btnMENU.Enabled = false; // Ð? ?n menu
                this.btnTHOAT.Enabled = true;

                this.groupBoxDonDatHang.Enabled = false;


            }

            /* CHI NHANH & USER co the xem - xoa - sua du lieu nhung khong the 
             chuyen sang chi nhanh khac*/
            if (Program.role == "CHINHANH" || Program.role == "USER")
            {
                cmbCHINHANH.Enabled = false;

                this.btnTHEM.Enabled = true;
                bool turnOn = (bdsChiTietDonDatHang.Count > 0) ? true : false;
                this.btnXOA.Enabled = turnOn;
                this.btnGHI.Enabled = false;

                this.btnHOANTAC.Enabled = false;
                this.btnLAMMOI.Enabled = true;
                // this.btnMENU.Enabled = true; // Ð? ?n menu
                this.btnTHOAT.Enabled = true;

                this.txtMaDonDatHang.Enabled = false;

            }
        }

        private void btnTHOAT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
        }

        private void btnTHEM_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            /*Step 1*/
            /*l?y v? trí hi?n t?i c?a con tr?*/
            viTri = bds.Position;
            dangThemMoi = true;

            /*Step 2 - Hi?n th? form popup tùy theo ch? ð?*/
            if (bds == bdsDonDatHang) // Ch? ð? Ðõn Ð?t Hàng
            {
                // Hi?n th? form popup ð? nh?p thông tin ðõn hàng
                using (FormThemDonDatHang formThem = new FormThemDonDatHang())
                {
                    formThem.StartPosition = FormStartPosition.CenterParent;
                    DialogResult result = formThem.ShowDialog(this);

                    if (result == DialogResult.OK)
                    {
                        // Thêm d?ng m?i vào binding source
                        bds.AddNew();
                        
                        // Gán giá tr? t? form popup
                        ((DataRowView)(bdsDonDatHang.Current))["MasoDDH"] = formThem.MaDonDatHang;
                        ((DataRowView)(bdsDonDatHang.Current))["MANV"] = Program.userName;
                        ((DataRowView)(bdsDonDatHang.Current))["NGAY"] = DateTime.Now;
                        ((DataRowView)(bdsDonDatHang.Current))["MAKHO"] = formThem.MaKho;
                        ((DataRowView)(bdsDonDatHang.Current))["NhaCC"] = formThem.NhaCungCap;

                        // Refresh các textbox trên form (ð? validation pass)
                        bds.EndEdit();
                        
                        // C?p nh?t tr?c ti?p các textbox (ð? ð?m b?o validation th?y ðý?c d? li?u)
                        this.txtMaDonDatHang.Text = formThem.MaDonDatHang;
                        this.txtNhaCungCap.Text = formThem.NhaCungCap;
                        this.txtMaKho.Text = formThem.MaKho;
                        this.txtMaNhanVien.Text = Program.userName;
                        this.dteNGAY.EditValue = DateTime.Now;

                        // B?t ch? ð? ghi
                        this.btnTHEM.Enabled = false;
                        this.btnXOA.Enabled = false;
                        this.btnGHI.Enabled = true;
                        this.btnHOANTAC.Enabled = true;
                        this.btnLAMMOI.Enabled = false;
                        this.btnTHOAT.Enabled = false;
                    }
                    else
                    {
                        // H?y b? thêm m?i
                        dangThemMoi = false;
                    }
                }
                return;
            }

            if (bds == bdsChiTietDonDatHang) // Ch? ð? Chi Ti?t Ðõn Ð?t Hàng
            {
                DataRowView drv = ((DataRowView)bdsDonDatHang[bdsDonDatHang.Position]);
                String maNhanVien = drv["MANV"].ToString();
                if (Program.userName != maNhanVien)
                {
                    MessageBox.Show("B?n không thêm chi ti?t ðõn hàng trên phi?u không ph?i do m?nh t?o", "Thông báo", MessageBoxButtons.OK);
                    return;
                }

                // Hi?n th? form popup ð? nh?p chi ti?t ðõn hàng
                using (FormThemChiTietDonHang formThem = new FormThemChiTietDonHang())
                {
                    formThem.StartPosition = FormStartPosition.CenterParent;
                    DialogResult result = formThem.ShowDialog(this);

                    if (result == DialogResult.OK)
                    {
                        // Thêm d?ng m?i vào binding source
                        bds.AddNew();
                        
                        // Gán giá tr? t? form popup
                        ((DataRowView)(bdsChiTietDonDatHang.Current))["MasoDDH"] = 
                            ((DataRowView)bdsDonDatHang[bdsDonDatHang.Position])["MasoDDH"];
                        ((DataRowView)(bdsChiTietDonDatHang.Current))["MAVT"] = formThem.MaVatTu;
                        ((DataRowView)(bdsChiTietDonDatHang.Current))["SOLUONG"] = formThem.SoLuong;
                        ((DataRowView)(bdsChiTietDonDatHang.Current))["DONGIA"] = formThem.DonGia;

                        // Refresh các textbox trên form (ð? validation pass)
                        bds.EndEdit();
                        
                        // C?p nh?t tr?c ti?p các textbox (ð? ð?m b?o validation th?y ðý?c d? li?u)
                        this.txtMaVatTu.Text = formThem.MaVatTu;
                        this.txtSoLuong.Value = formThem.SoLuong;
                        this.txtDonGia.Value = formThem.DonGia;

                        // B?t ch? ð? ghi
                        this.btnTHEM.Enabled = false;
                        this.btnXOA.Enabled = false;
                        this.btnGHI.Enabled = true;
                        this.btnHOANTAC.Enabled = true;
                        this.btnLAMMOI.Enabled = false;
                        this.btnTHOAT.Enabled = false;
                    }
                    else
                    {
                        // H?y b? thêm m?i
                        dangThemMoi = false;
                    }
                }
                return;
            }


            /*Step 3*/
            this.btnTHEM.Enabled = false;
            this.btnXOA.Enabled = false;
            this.btnGHI.Enabled = true;

            this.btnHOANTAC.Enabled = true;
            this.btnLAMMOI.Enabled = false;
            // this.btnMENU.Enabled = false; // Ð? ?n menu
            this.btnTHOAT.Enabled = false;            
        }


        /**************************************************
         * ham nay kiem tra du lieu dau vao
         * true là qua h?t
         * false là thi?u m?t d? li?u nào ðó
         **************************************************/
        private bool kiemTraDuLieuDauVao(String cheDo)
        {
            if (cheDo == "Ðõn Ð?t Hàng")
            {
                if( txtMaDonDatHang.Text == "")
                {
                    MessageBox.Show("Không th? b? tr?ng m? ðõn hàng","Thông báo",MessageBoxButtons.OK);
                    return false;
                }
                if (txtMaDonDatHang.Text.Length > 8)
                {
                    MessageBox.Show("M? ðõn ð?t hàng không quá 8 kí t?", "Thông báo", MessageBoxButtons.OK);
                    return false;
                }
                if ( txtMaNhanVien.Text == "")
                {
                    MessageBox.Show("Không th? b? tr?ng m? nhân viên", "Thông báo", MessageBoxButtons.OK);
                    return false;
                }
                if( txtNhaCungCap.Text == "")
                {
                    MessageBox.Show("Không th? b? tr?ng nhà cung c?p", "Thông báo", MessageBoxButtons.OK);
                    return false;
                }
                if (txtNhaCungCap.Text.Length > 100)
                {
                    MessageBox.Show("Tên nhà cung c?p không quá 100 kí t?", "Thông báo", MessageBoxButtons.OK);
                    return false;
                }
                if ( txtMaKho.Text == "")
                {
                    MessageBox.Show("Không th? b? tr?ng m? kho", "Thông báo", MessageBoxButtons.OK);
                    return false;
                }    
            }

            if (cheDo == "Chi Ti?t Ðõn Ð?t Hàng")
            {
                if( txtMaVatTu.Text == "")
                {
                    MessageBox.Show("Không th? b? tr?ng m? v?t tý", "Thông báo", MessageBoxButtons.OK);
                    return false;
                }
                if( txtSoLuong.Value < 0 || txtDonGia.Value < 0)
                {
                    MessageBox.Show("Không th? nh? hõn 1", "Thông báo", MessageBoxButtons.OK);
                    return false;
                }
                /*
                if( txtSoLuong.Value > Program.soLuongVatTu)
                {
                    MessageBox.Show("Sô lý?ng ð?t mua l?n hõn s? lý?ng v?t tý hi?n có", "Thông báo", MessageBoxButtons.OK);
                    return false;
                }*/
            }
            return true;
        }



        /**************************************************
         * tra ve 1 cau truy van de phuc hoi du lieu
         * 
         * ket qua tra ve dua theo che do dang su dung
         **************************************************/
        private String taoCauTruyVanHoanTac(String cheDo)
        {
            String cauTruyVan = "";
            DataRowView drv;


            /*Dang chinh sua don dat hang*/
            if ( cheDo == "Ðõn Ð?t Hàng" && dangThemMoi == false)
            {
                drv = ((DataRowView)bdsDonDatHang[bdsDonDatHang.Position]);
                /*Ngay can duoc xu ly dac biet hon*/
                DateTime ngay = ((DateTime)drv["NGAY"]);

                cauTruyVan = "UPDATE DBO.DATHANG " +
                    "SET " +
                    "NGAY = CAST('" + ngay.ToString("yyyy-MM-dd") + "' AS DATETIME), " +
                    "NhaCC = '" + drv["NhaCC"].ToString().Trim() + "', " +
                    "MANV = '" + drv["MANV"].ToString().Trim() + "', " +
                    "MAKHO = '" + drv["MAKHO"].ToString().Trim() + "' " +
                    "WHERE MasoDDH = '" + drv["MasoDDH"].ToString().Trim() + "'";
            }  
            /*Dang xoa don dat hang*/
            if ( cheDo == "Ðõn Ð?t Hàng" && dangThemMoi == true)
            {
                drv = ((DataRowView)bdsDonDatHang[bdsDonDatHang.Position]);
                DateTime ngay = ((DateTime)drv["NGAY"]);
                cauTruyVan = "INSERT INTO DBO.DATHANG(MasoDDH, NGAY, NhaCC, MaNV, MaKho) " +
                    "VALUES('" + drv["MasoDDH"] + "', '" +
                    ngay.ToString("yyyy-MM-dd") + "', '" +
                    drv["NhaCC"].ToString() + "', '" +
                    drv["MaNV"].ToString() + "', '" +
                    drv["MaKho"].ToString() + "' )";

            }

            /*Dang chinh sua chi tiet don dat hang*/
            if(cheDo == "Chi Ti?t Ðõn Ð?t Hàng" && dangThemMoi == false)
            {
                drv = ((DataRowView)bdsChiTietDonDatHang[bdsChiTietDonDatHang.Position]);

                cauTruyVan = "UPDATE DBO.CTDDH " +
                    "SET " +
                    "SOLUONG = " + drv["SOLUONG"].ToString() + " , "+
                    "DONGIA = " + drv["DONGIA"].ToString() + " " +
                    "WHERE MasoDDH = '" + drv["MasoDDH"].ToString().Trim() + "'" + 
                    " AND MAVT = '" + drv["MAVT"].ToString().Trim() +"'";

            }
            return cauTruyVan;
        }



        /**************************************************
         * Step 1: Kiem tra xem day co phai nguoi lap don hang hay không
         * Step 2: lay che do dang lam viec, kiem tra du lieu dau vao. Neu OK thi 
         * tiep tuc tao cau truy van hoan tac neu dangThemMoi = false
         * Step 3: kiem tra xem cai ma don hang nay da ton tai chua ?
         *          Neu co thi ket thuc luon
         *          Neu khong thi cho them moi
         **************************************************/
        private void btnGHI_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            viTri = bdsDonDatHang.Position;
            /*Step 1*/
            DataRowView drv = ((DataRowView)bdsDonDatHang[bdsDonDatHang.Position]);
            /*lay maNhanVien & maDonDatHang de phong truong hop them chi tiet don hang thi se co ngay*/
            String maNhanVien = drv["MANV"].ToString();
            String maDonDatHang = drv["MasoDDH"].ToString().Trim();

            if (Program.userName != maNhanVien && dangThemMoi == false)
            {
                MessageBox.Show("B?n không th? s?a phi?u do ngý?i khác l?p", "Thông báo", MessageBoxButtons.OK);
                return;
            }



            /*Step 2*/
            // Xác ð?nh ch? ð? d?a vào binding source hi?n t?i thay v? menu
            String cheDo = (bds == bdsDonDatHang) ? "Ðõn Ð?t Hàng" : "Chi Ti?t Ðõn Ð?t Hàng";

            bool ketQua = kiemTraDuLieuDauVao(cheDo);
            if (ketQua == false) return;

            String cauTruyVanHoanTac = taoCauTruyVanHoanTac(cheDo);
            //Console.WriteLine(cauTruyVanHoanTac);


            /*Step 3*/
            String maDonDatHangMoi = txtMaDonDatHang.Text;
            String cauTruyVan =
                    "DECLARE	@result int " +
                    "EXEC @result = sp_KiemTraMaDonDatHang '" +
                    maDonDatHangMoi + "' " +
                    "SELECT 'Value' = @result";
            SqlCommand sqlCommand = new SqlCommand(cauTruyVan, Program.conn);
            try
            {
                Program.myReader = Program.ExecSqlDataReader(cauTruyVan);
                /*khong co ket qua tra ve thi ket thuc luon*/
                if (Program.myReader == null)
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Th?c thi database th?t b?i!\n\n" + ex.Message, "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
                return;
            }
            Program.myReader.Read();
            int result = int.Parse(Program.myReader.GetValue(0).ToString());
            Program.myReader.Close();



            /*Step 4*/
            //Console.WriteLine(txtMaNhanVien.Text);
            int viTriHienTai = bds.Position;
            int viTriMaDonDatHang = bdsDonDatHang.Find("MasoDDH", txtMaDonDatHang.Text);
            /******************************************************************
             * truong hop them moi don dat hang moi quan tam xem no ton tai hay
             * chua ?
             ******************************************************************/
            if ( result == 1 && cheDo == "Ðõn Ð?t Hàng" && viTriHienTai != viTriMaDonDatHang)
            {
                MessageBox.Show("M? ðõn hàng này ð? ðý?c s? d?ng !\n\n", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            /*****************************************************************
             * tat ca cac truong hop khac ko can quan tam !!
             *****************************************************************/
            
            else
            {
                DialogResult dr = MessageBox.Show("B?n có ch?c mu?n ghi d? li?u vào cõ s? d? li?u ?", "Thông báo",
                         MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    try
                    {
                        //Console.WriteLine(txtMaNhanVien.Text);
                        /*TH1: them moi don dat hang*/
                        if (cheDo == "Ðõn Ð?t Hàng" && dangThemMoi == true)
                        {
                            cauTruyVanHoanTac =
                                "DELETE FROM DBO.DATHANG " +
                                "WHERE MasoDDH = '" + maDonDatHang + "'";
                        }

                        /*TH2: them moi chi tiet don hang*/
                        if (cheDo == "Chi Ti?t Ðõn Ð?t Hàng" && dangThemMoi == true)
                        {
                            /*Gan tu dong may truong du lieu nay*/
                            ((DataRowView)(bdsChiTietDonDatHang.Current))["MasoDDH"] = ((DataRowView)(bdsDonDatHang.Current))["MasoDDH"];
                            ((DataRowView)(bdsChiTietDonDatHang.Current))["MAVT"] = Program.maVatTuDuocChon;
                            ((DataRowView)(bdsChiTietDonDatHang.Current))["SOLUONG"] =
                                txtSoLuong.Value;
                            ((DataRowView)(bdsChiTietDonDatHang.Current))["DONGIA"] =
                                (int)txtDonGia.Value;

                            cauTruyVanHoanTac =
                                "DELETE FROM DBO.CTDDH " +
                                "WHERE MasoDDH = '" + maDonDatHang + "' " +
                                "AND MAVT = '" + txtMaVatTu.Text.Trim() + "'";
                        }

                        /*TH3: chinh sua don hang */
                        /*TH4: chinh sua chi tiet don hang - > thi chi can may dong lenh duoi la xong*/
                        undoList.Push(cauTruyVanHoanTac);
                        //Console.WriteLine("cau truy van hoan tac");
                        //Console.WriteLine(cauTruyVanHoanTac);
                        
                        this.bdsDonDatHang.EndEdit();
                        this.bdsChiTietDonDatHang.EndEdit();
                        this.donDatHangTableAdapter.Update(this.dataSet.DatHang);
                        this.chiTietDonDatHangTableAdapter.Update(this.dataSet.CTDDH);

                        this.btnTHEM.Enabled = true;
                        this.btnXOA.Enabled = true;
                        this.btnGHI.Enabled = true;

                        this.btnHOANTAC.Enabled = true;
                        this.btnLAMMOI.Enabled = true;
                        // this.btnMENU.Enabled = true; // Ð? ?n menu
                        this.btnTHOAT.Enabled = true;

                        //this.groupBoxDonDatHang.Enabled = false;

                        /*c?p nh?t l?i tr?ng thái thêm m?i cho ch?c*/
                        dangThemMoi = false;
                        MessageBox.Show("Ghi thành công", "Thông báo", MessageBoxButtons.OK);
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        bds.RemoveCurrent();
                        MessageBox.Show("Da xay ra loi !\n\n" + ex.Message, "L?i",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }    
            
        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        /**********************************************************************
         * moi lan nhan btnHOANTAC thi nen nhan them btnLAMMOI de 
         * tranh bi loi khi an btnTHEM lan nua
         * 
         * statement: chua cau y nghia chuc nang ngay truoc khi an btnHOANTAC.
         * Vi du: statement = INSERT | DELETE | CHANGEBRAND
         * 
         * bdsNhanVien.CancelEdit() - phuc hoi lai du lieu neu chua an btnGHI
         * Step 0: trý?ng h?p ð? ?n btnTHEM nhýng chýa ?n btnGHI
         * Step 1: ki?m tra undoList có trông hay không ?
         * Step 2: Neu undoList khong tr?ng th? l?y ra khôi ph?c
         *********************************************************************/
        private void btnHOANTAC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            /* Step 0 */
            if (dangThemMoi == true && this.btnTHEM.Enabled == false)
            {
                dangThemMoi = false;

                /*dang o che do Don Dat Hang*/
                if (bds == bdsDonDatHang)
                {
                    this.txtMaDonDatHang.Enabled = false;

                    //this.dteNGAY.EditValue = DateTime.Now;
                    this.dteNGAY.Enabled = false;
                    this.txtNhaCungCap.Enabled = true;
                    //this.txtMaNhanVien.Text = Program.userName;
                    this.btnChonKhoHang.Enabled = true;
                }
                /*dang o che do Chi Tiet Don Dat Hang*/
                if (bds == bdsChiTietDonDatHang)
                {
                    this.txtMaVatTu.Enabled = false;
                    this.btnChonVatTu.Enabled = true;

                    this.txtSoLuong.Enabled = true;
                    this.txtSoLuong.EditValue = 1;

                    this.txtDonGia.Enabled = true;
                    this.txtDonGia.EditValue = 1;
                }

                this.btnTHEM.Enabled = true;
                this.btnXOA.Enabled = true;
                this.btnGHI.Enabled = true;

                //this.btnHOANTAC.Enabled = false;
                this.btnLAMMOI.Enabled = true;
                // this.btnMENU.Enabled = true; // Ð? ?n menu
                this.btnTHOAT.Enabled = true;


                bds.CancelEdit();
                /*xoa dong hien tai*/
                bds.RemoveCurrent();
                /* tr? v? lúc ð?u con tr? ðang ð?ng*/
                bds.Position = viTri;
                return;
            }

            /*Step 1*/
            if (undoList.Count == 0)
            {
                MessageBox.Show("Không c?n thao tác nào ð? khôi ph?c", "Thông báo", MessageBoxButtons.OK);
                btnHOANTAC.Enabled = false;
                return;
            }

            /*Step 2*/
            bds.CancelEdit();
            String cauTruyVanHoanTac = undoList.Pop().ToString();

            Console.WriteLine(cauTruyVanHoanTac);
            int n = Program.ExecSqlNonQuery(cauTruyVanHoanTac);

            this.donDatHangTableAdapter.Fill(this.dataSet.DatHang);
            this.chiTietDonDatHangTableAdapter.Fill(this.dataSet.CTDDH);

            bdsDonDatHang.Position = viTri;
        }

        private void btnLAMMOI_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                // do du lieu moi tu dataSet vao gridControl NHANVIEN
                this.donDatHangTableAdapter.Fill(this.dataSet.DatHang);
                this.chiTietDonDatHangTableAdapter.Fill(this.dataSet.CTDDH);

                this.gcDonDatHang.Enabled = true;
                this.gcChiTietDonDatHang.Enabled = true;

                bdsDonDatHang.Position = viTri;
            }
            catch (Exception ex)
            {
                MessageBox.Show("L?i Làm m?i" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                return;
            }
        }

        /***************************************************************
         * ShowDialog is useful when you want to present info to a user, or let him change it, or get info from him before you do anything else.
         * 
         * Show is useful when you want to show information to the user but it is not important that you wait fro him to be finished.
         ***************************************************************/
        private void btnChonKhoHang_Click(object sender, EventArgs e)
        {
            FormChonKhoHang form = new FormChonKhoHang();
            form.ShowDialog(); 
                
            
            this.txtMaKho.Text = Program.maKhoDuocChon;
        }

        private void btnChonVatTu_Click(object sender, EventArgs e)
        {
            FormChonVatTu form = new FormChonVatTu();
            form.ShowDialog();
            this.txtMaVatTu.Text = Program.maVatTuDuocChon;
        }



        /**
         * Step 1: l?y ch? ð? ðang s? d?ng và ð?t dangThemMoi = true ð? ph?c v? ði?u ki?n t?o câu truy
         * v?n hoàn tác
         * Step 2: ki?m tra ði?u ki?n theo ch? ð? ðang s? d?ng
         * Step 3: n?p câu truy v?n hoàn tác vào undolist
         * Step 4: Th?c hi?n xóa n?u OK
         */
        private void btnXOA_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string cauTruyVan = "";
            string cheDo = (bds == bdsDonDatHang) ? "Ðõn Ð?t Hàng" : "Chi Ti?t Ðõn Ð?t Hàng";

            dangThemMoi = true;// bat cai nay len de ung voi dieu kien tao cau truy van

            if (cheDo == "Ðõn Ð?t Hàng")
            {
                /*Cái bdsChiTietDonHangHang là ð?i di?n cho binding source riêng bi?t c?a CTDDH
                 *C?n cTDDHBindingSource là l?y ngay t? trong data source DATHANG
                 */
                if(bdsChiTietDonDatHang.Count > 0)
                {
                    MessageBox.Show("Không th? xóa ðõn ð?t hàng này v? có chi ti?t ðõn ð?t hàng", "Thông báo", MessageBoxButtons.OK);
                    return;
                }

                if (bdsPhieuNhap.Count > 0)
                {
                    MessageBox.Show("Không th? xóa ðõn ð?t hàng này v? có phi?u nh?p", "Thông báo", MessageBoxButtons.OK);
                    return;
                }

                
            }
            if( cheDo == "Chi Ti?t Ðõn Ð?t Hàng")
            {
                DataRowView drv = ((DataRowView)bdsDonDatHang[bdsDonDatHang.Position]);
                String maNhanVien = drv["MANV"].ToString();
                if (Program.userName != maNhanVien)
                {
                    MessageBox.Show("B?n không xóa chi ti?t ðõn hàng trên phi?u không ph?i do m?nh t?o", "Thông báo", MessageBoxButtons.OK);
                    //bdsChiTietDonDatHang.RemoveCurrent();
                    return;
                }
            }

            cauTruyVan = taoCauTruyVanHoanTac(cheDo);
            //Console.WriteLine("Line 753");
            //Console.WriteLine(cauTruyVan);
            undoList.Push(cauTruyVan);

            /*Step 2*/
            if (MessageBox.Show("B?n có ch?c ch?n mu?n xóa không ?", "Thông báo",
                MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    /*Step 3*/
                    viTri = bds.Position;
                    if(cheDo == "Ðõn Ð?t Hàng" )
                    {
                        bdsDonDatHang.RemoveCurrent();
                    }
                    if(cheDo == "Chi Ti?t Ðõn Ð?t Hàng")
                    {
                        bdsChiTietDonDatHang.RemoveCurrent();
                    }
                    

                    this.donDatHangTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.donDatHangTableAdapter.Update(this.dataSet.DatHang);

                    this.chiTietDonDatHangTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.chiTietDonDatHangTableAdapter.Update(this.dataSet.CTDDH);

                    /*Cap nhat lai do ben tren can tao cau truy van nen da dat dangThemMoi = true*/
                    dangThemMoi = false;
                    MessageBox.Show("Xóa thành công ", "Thông báo", MessageBoxButtons.OK);
                    this.btnHOANTAC.Enabled = true;
                }
                catch (Exception ex)
                {
                    /*Step 4*/
                    MessageBox.Show("L?i xóa nhân viên. H?y th? l?i\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                    this.donDatHangTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.donDatHangTableAdapter.Update(this.dataSet.DatHang);

                    this.chiTietDonDatHangTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.chiTietDonDatHangTableAdapter.Update(this.dataSet.CTDDH);
                    // tro ve vi tri cua nhan vien dang bi loi
                    bds.Position = viTri;
                    //bdsNhanVien.Position = bdsNhanVien.Find("MANV", manv);
                    return;
                }
            }
            else
            {
                // xoa cau truy van hoan tac di
                undoList.Pop();
            }
        }

        private void cmbCHINHANH_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            /*Neu combobox khong co so lieu thi ket thuc luon*/
            if (cmbCHINHANH.SelectedValue.ToString() == "System.Data.DataRowView")
                return;

            Program.serverName = cmbCHINHANH.SelectedValue.ToString();

            /*Neu chon sang chi nhanh khac voi chi nhanh hien tai*/
            if (cmbCHINHANH.SelectedIndex != Program.brand)
            {
                Program.loginName = Program.remoteLogin;
                Program.loginPassword = Program.remotePassword;
            }
            /*Neu chon trung voi chi nhanh dang dang nhap o formDangNhap*/
            else
            {
                Program.loginName = Program.currentLogin;
                Program.loginPassword = Program.currentPassword;
            }

            if (Program.KetNoi() == 0)
            {
                MessageBox.Show("X?y ra l?i k?t n?i v?i chi nhánh hi?n t?i", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                this.chiTietDonDatHangTableAdapter.Connection.ConnectionString = Program.connstr;
                this.chiTietDonDatHangTableAdapter.Fill(this.dataSet.CTDDH);

                this.donDatHangTableAdapter.Connection.ConnectionString = Program.connstr;
                this.donDatHangTableAdapter.Fill(this.dataSet.DatHang);

                this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
                this.phieuNhapTableAdapter.Fill(this.dataSet.PhieuNhap);
            }
        }

        // T? ð?ng chuy?n sang ch? ð? "Ðõn Ð?t Hàng" khi click vào grid Ðõn Ð?t Hàng
        private void gcDonDatHang_Click(object sender, EventArgs e)
        {
            btnCheDoDonDatHang_ItemClick(null, null);
            
            // Làm n?i b?t grid ðang active
            gridView1.Appearance.ViewCaption.BackColor = System.Drawing.Color.DeepSkyBlue;
            gridView1.Appearance.ViewCaption.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            gvCTDDH.Appearance.ViewCaption.BackColor = System.Drawing.SystemColors.Control;
            gvCTDDH.Appearance.ViewCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular);
        }

        // T? ð?ng chuy?n sang ch? ð? "Ðõn Ð?t Hàng" khi click vào groupbox Ðõn Hàng
        private void groupBoxDonDatHang_Click(object sender, EventArgs e)
        {
            btnCheDoDonDatHang_ItemClick(null, null);
            
            // Làm n?i b?t grid ðang active
            gridView1.Appearance.ViewCaption.BackColor = System.Drawing.Color.DeepSkyBlue;
            gridView1.Appearance.ViewCaption.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            gvCTDDH.Appearance.ViewCaption.BackColor = System.Drawing.SystemColors.Control;
            gvCTDDH.Appearance.ViewCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular);
        }

        // T? ð?ng chuy?n sang ch? ð? "Chi Ti?t Ðõn Ð?t Hàng" khi click vào grid Chi Ti?t
        private void gcChiTietDonDatHang_Click(object sender, EventArgs e)
        {
            btnCheDoChiTietDonDatHang_ItemClick(null, null);
            
            // Làm n?i b?t grid ðang active
            gridView1.Appearance.ViewCaption.BackColor = System.Drawing.SystemColors.Control;
            gridView1.Appearance.ViewCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular);
            gvCTDDH.Appearance.ViewCaption.BackColor = System.Drawing.Color.DeepSkyBlue;
            gvCTDDH.Appearance.ViewCaption.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
        }

        // T? ð?ng chuy?n sang ch? ð? "Chi Ti?t Ðõn Ð?t Hàng" khi click vào groupbox Chi Ti?t
        private void groupBox1_Click(object sender, EventArgs e)
        {
            btnCheDoChiTietDonDatHang_ItemClick(null, null);
            
            // Làm n?i b?t grid ðang active
            gridView1.Appearance.ViewCaption.BackColor = System.Drawing.SystemColors.Control;
            gridView1.Appearance.ViewCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular);
            gvCTDDH.Appearance.ViewCaption.BackColor = System.Drawing.Color.DeepSkyBlue;
            gvCTDDH.Appearance.ViewCaption.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
        }

        // Khi click vào m?t d?ng trong gridView c?a Ðõn Ð?t Hàng
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (bds != bdsDonDatHang)
            {
                btnCheDoDonDatHang_ItemClick(null, null);
            }
            
            // Làm n?i b?t grid ðang active
            gridView1.Appearance.ViewCaption.BackColor = System.Drawing.Color.DeepSkyBlue;
            gridView1.Appearance.ViewCaption.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            gvCTDDH.Appearance.ViewCaption.BackColor = System.Drawing.SystemColors.Control;
            gvCTDDH.Appearance.ViewCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular);
        }

        // Khi click vào m?t d?ng trong gridView c?a Chi Ti?t Ðõn Ð?t Hàng
        private void gvCTDDH_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (bds != bdsChiTietDonDatHang)
            {
                btnCheDoChiTietDonDatHang_ItemClick(null, null);
            }
            
            // Làm n?i b?t grid ðang active
            gridView1.Appearance.ViewCaption.BackColor = System.Drawing.SystemColors.Control;
            gridView1.Appearance.ViewCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular);
            gvCTDDH.Appearance.ViewCaption.BackColor = System.Drawing.Color.DeepSkyBlue;
            gvCTDDH.Appearance.ViewCaption.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
        }
    }
}
