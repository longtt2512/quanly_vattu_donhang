using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base;
using QLTVT.SubForm;

namespace QLTVT
{

    public partial class FormDonDatHang : Form
    {
        /* v? tr� c?a con tr? tr�n grid view*/
        int viTri = 0;
        /********************************************
         * �ang th�m m?i -> true -> �ang d�ng btnTHEM
         *              -> false -> c� th? l� btnGHI( ch?nh s?a) ho?c btnXOA
         *              
         * M?c ��ch: d�ng bi?n n�y �? ph�n bi?t gi?a btnTHEM - th�m m?i ho�n to�n
         * v� vi?c ch?nh s?a nh�n vi�n( do m?nh ko d�ng th�m btnXOA )
         * Tr?ng th�i true or false s? ��?c s? d?ng 
         * trong btnGHI - vi?c n�y �? ph?c v? cho btnHOANTAC
         ********************************************/
        bool dangThemMoi = false;
        public string makho = "";   
        string maChiNhanh = "";
        /**********************************************************
         * undoList - ph?c v? cho btnHOANTAC -  ch?a c�c th�ng tin c?a �?i t�?ng b? t�c �?ng 
         * 
         * n� l� n�i l�u tr? c�c �?i t�?ng c?n thi?t �? ho�n t�c c�c thao t�c
         * 
         * n?u btnGHI s? ?ng v?i INSERT
         * n?u btnXOA s? ?ng v?i DELETE
         * n?u btnCHUYENCHINHANH s? ?ng v?i CHANGEBRAND
         **********************************************************/
        Stack undoList = new Stack();



        /********************************************************
         * ch?a nh?ng d? li?u hi?n t?i �ang l�m vi?c
         * gc ch?a grid view �ang l�m vi?c
         ********************************************************/
        BindingSource bds = null;
        GridControl gc = null;
        string type = "";



        /************************************************************
         * CheckExists:
         * �? tr�nh vi?c ng�?i d�ng ?n v�o 1 form �?n 2 l?n ch�ng ta 
         * c?n s? d?ng h�m n�y �? ki?m tra xem c�i form hi?n t?i �? 
         * c� trong b? nh? ch�a
         * N?u c� tr? v? "f"
         * N?u kh�ng tr? v? "null"
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

            /*Step 3: B?t grid Chi Ti?t ��n H�ng �? lu�n hi?n th? danh s�ch chi ti?t*/
            gcChiTietDonDatHang.Enabled = true;

            /*Step 4: T? �?ng k�ch ho?t ch? �? "Đơn Đặt Hàng" khi form load*/
            btnCheDoDonDatHang_ItemClick(null, null);
            
        }

        private void sOLUONGSpinEdit_EditValueChanged(object sender, EventArgs e)
        {

        }



        /*********************************************************
         * Step 0: Hi?n ch? �? l�m vi?c
         * Step 1: c?p nh?t binding source v� grid control
         * 
         * t?t c�c ch?c n�ng li�n quan t?i chi ti?t ��n h�ng
         *********************************************************/
        private void btnCheDoDonDatHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            /*Step 0 - B? qua vi?c c?p nh?t caption v? �? ?n menu*/
            // btnMENU.Links[0].Caption = "Đơn Đặt Hàng";

            /*Step 1*/
            bds = bdsDonDatHang;
            gc = gcDonDatHang;
            //MessageBox.Show("Ch? �? L�m Vi?c Đơn Đặt Hàng", "Th�ng b�o", MessageBoxButtons.OK);

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

            /*L�m n?i b?t grid Đơn Đặt Hàng - d�ng ViewCaption Background*/
            gridView1.Appearance.ViewCaption.BackColor = Color.DeepSkyBlue;
            gridView1.Appearance.ViewCaption.Font = new Font("Tahoma", 10F, FontStyle.Bold);
            gvCTDDH.Appearance.ViewCaption.BackColor = SystemColors.Control;
            gvCTDDH.Appearance.ViewCaption.Font = new Font("Tahoma", 8.25F, FontStyle.Regular);

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
                // this.btnMENU.Enabled = false; // �? ?n menu
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
                // this.btnMENU.Enabled = true; // �? ?n menu
                this.btnTHOAT.Enabled = true;

                this.txtMaDonDatHang.Enabled = false;

            }
        }

        private void btnCheDoChiTietDonDatHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            /*Step 0 - B? qua vi?c c?p nh?t caption v? �? ?n menu*/
            // btnMENU.Links[0].Caption = "Chi Tiết Đơn Đặt Hàng";

            /*Step 1*/
            bds = bdsChiTietDonDatHang;
            gc = gcChiTietDonDatHang;
            //MessageBox.Show("Ch? �? L�m Vi?c Chi Tiết Đơn Đặt Hàng", "Th�ng b�o", MessageBoxButtons.OK);

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

            /*L�m n?i b?t grid Chi Tiết Đơn Đặt Hàng - d�ng ViewCaption Background*/
            gridView1.Appearance.ViewCaption.BackColor = SystemColors.Control;
            gridView1.Appearance.ViewCaption.Font = new Font("Tahoma", 8.25F, FontStyle.Regular);
            gvCTDDH.Appearance.ViewCaption.BackColor = Color.DeepSkyBlue;
            gvCTDDH.Appearance.ViewCaption.Font = new Font("Tahoma", 10F, FontStyle.Bold);

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
                // this.btnMENU.Enabled = false; // �? ?n menu
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
                // this.btnMENU.Enabled = true; // �? ?n menu
                this.btnTHOAT.Enabled = true;

                this.txtMaDonDatHang.Enabled = false;

            }
        }

        private void btnTHOAT_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Dispose();
        }

        private void btnTHEM_ItemClick(object sender, ItemClickEventArgs e)
        {
            /*Step 1*/
            /*l?y v? tr� hi?n t?i c?a con tr?*/
            viTri = bds.Position;
            dangThemMoi = true;

            /*Step 2 - Hi?n th? form popup t�y theo ch? �?*/
            if (bds == bdsDonDatHang) // Ch? �? Đơn Đặt Hàng
            {
                // Hi?n th? form popup �? nh?p th�ng tin ��n h�ng
                using (FormThemDonDatHang formThem = new FormThemDonDatHang())
                {
                    formThem.StartPosition = FormStartPosition.CenterParent;
                    DialogResult result = formThem.ShowDialog(this);

                    if (result == DialogResult.OK)
                    {
                        // Th�m d?ng m?i v�o binding source
                        bds.AddNew();
                        
                        // G�n gi� tr? t? form popup
                        ((DataRowView)(bdsDonDatHang.Current))["MasoDDH"] = formThem.MaDonDatHang;
                        ((DataRowView)(bdsDonDatHang.Current))["MANV"] = Program.userName;
                        ((DataRowView)(bdsDonDatHang.Current))["NGAY"] = DateTime.Now;
                        ((DataRowView)(bdsDonDatHang.Current))["MAKHO"] = formThem.MaKho;
                        ((DataRowView)(bdsDonDatHang.Current))["NhaCC"] = formThem.NhaCungCap;

                        // Refresh c�c textbox tr�n form (�? validation pass)
                        bds.EndEdit();
                        
                        // C?p nh?t tr?c ti?p c�c textbox (�? �?m b?o validation th?y ��?c d? li?u)
                        this.txtMaDonDatHang.Text = formThem.MaDonDatHang;
                        this.txtNhaCungCap.Text = formThem.NhaCungCap;
                        this.txtMaKho.Text = formThem.MaKho;
                        this.txtMaNhanVien.Text = Program.userName;
                        this.dteNGAY.EditValue = DateTime.Now;

                        // B?t ch? �? ghi
                        this.btnTHEM.Enabled = false;
                        this.btnXOA.Enabled = false;
                        this.btnGHI.Enabled = true;
                        this.btnHOANTAC.Enabled = true;
                        this.btnLAMMOI.Enabled = false;
                        this.btnTHOAT.Enabled = false;
                    }
                    else
                    {
                        // H?y b? th�m m?i
                        dangThemMoi = false;
                    }
                }
                return;
            }

            if (bds == bdsChiTietDonDatHang) // Ch? �? Chi Tiết Đơn Đặt Hàng
            {
                DataRowView drv = ((DataRowView)bdsDonDatHang[bdsDonDatHang.Position]);
                String maNhanVien = drv["MANV"].ToString();
                if (Program.userName != maNhanVien)
                {
                    MessageBox.Show("Bạn không thêm chi tiết đơn hàng trên phiếu không phải do mình tạo", "Thông báo", MessageBoxButtons.OK);
                    return;
                }

                // Hi?n th? form popup �? nh?p chi ti?t ��n h�ng
                using (FormThemChiTietDonHang formThem = new FormThemChiTietDonHang())
                {
                    formThem.StartPosition = FormStartPosition.CenterParent;
                    DialogResult result = formThem.ShowDialog(this);

                    if (result == DialogResult.OK)
                    {
                        // Th�m d?ng m?i v�o binding source
                        bds.AddNew();
                        
                        // G�n gi� tr? t? form popup
                        ((DataRowView)(bdsChiTietDonDatHang.Current))["MasoDDH"] = 
                            ((DataRowView)bdsDonDatHang[bdsDonDatHang.Position])["MasoDDH"];
                        ((DataRowView)(bdsChiTietDonDatHang.Current))["MAVT"] = formThem.MaVatTu;
                        ((DataRowView)(bdsChiTietDonDatHang.Current))["SOLUONG"] = formThem.SoLuong;
                        ((DataRowView)(bdsChiTietDonDatHang.Current))["DONGIA"] = formThem.DonGia;

                        // Refresh c�c textbox tr�n form (�? validation pass)
                        bds.EndEdit();
                        
                        // C?p nh?t tr?c ti?p c�c textbox (�? �?m b?o validation th?y ��?c d? li?u)
                        this.txtMaVatTu.Text = formThem.MaVatTu;
                        this.txtSoLuong.Value = formThem.SoLuong;
                        this.txtDonGia.Value = formThem.DonGia;

                        // B?t ch? �? ghi
                        this.btnTHEM.Enabled = false;
                        this.btnXOA.Enabled = false;
                        this.btnGHI.Enabled = true;
                        this.btnHOANTAC.Enabled = true;
                        this.btnLAMMOI.Enabled = false;
                        this.btnTHOAT.Enabled = false;
                    }
                    else
                    {
                        // H?y b? th�m m?i
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
            // this.btnMENU.Enabled = false; // �? ?n menu
            this.btnTHOAT.Enabled = false;            
        }


        /**************************************************
         * ham nay kiem tra du lieu dau vao
         * true l� qua h?t
         * false l� thi?u m?t d? li?u n�o ��
         **************************************************/
        private bool kiemTraDuLieuDauVao(String cheDo)
        {
            if (cheDo == "Đơn Đặt Hàng")
            {
                if( txtMaDonDatHang.Text == "")
                {
                    MessageBox.Show("Không thể bỏ trống mã đơn hàng","Thông báo",MessageBoxButtons.OK);
                    return false;
                }
                if (txtMaDonDatHang.Text.Length > 8)
                {
                    MessageBox.Show("Mã đơn đặt hàng không quá 8 kí tự", "Thông báo", MessageBoxButtons.OK);
                    return false;
                }
                if ( txtMaNhanVien.Text == "")
                {
                    MessageBox.Show("Không thể bỏ trống mã nhân viên", "Thông báo", MessageBoxButtons.OK);
                    return false;
                }
                if( txtNhaCungCap.Text == "")
                {
                    MessageBox.Show("Không thể bỏ trống nhà cung cấp", "Thông báo", MessageBoxButtons.OK);
                    return false;
                }
                if (txtNhaCungCap.Text.Length > 100)
                {
                    MessageBox.Show("Tên nhà cung cấp không quá 100 kí tự", "Thông báo", MessageBoxButtons.OK);
                    return false;
                }
                if ( txtMaKho.Text == "")
                {
                    MessageBox.Show("Không thể bỏ trống mã kho", "Thông báo", MessageBoxButtons.OK);
                    return false;
                }    
            }

            if (cheDo == "Chi Tiết Đơn Đặt Hàng")
            {
                if( txtMaVatTu.Text == "")
                {
                    MessageBox.Show("Không thể bỏ trống mã vật tư", "Thông báo", MessageBoxButtons.OK);
                    return false;
                }
                if( txtSoLuong.Value < 0 || txtDonGia.Value < 0)
                {
                    MessageBox.Show("Không thể nhỏ hơn 1", "Thông báo", MessageBoxButtons.OK);
                    return false;
                }
                /*
                if( txtSoLuong.Value > Program.soLuongVatTu)
                {
                    MessageBox.Show("Sô lượng đặt mua lớn hơn số lượng vật tư hiện có", "Thông báo", MessageBoxButtons.OK);
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
            if ( cheDo == "Đơn Đặt Hàng" && dangThemMoi == false)
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
            if ( cheDo == "Đơn Đặt Hàng" && dangThemMoi == true)
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
            if(cheDo == "Chi Tiết Đơn Đặt Hàng" && dangThemMoi == false)
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
         * Step 1: Kiem tra xem day co phai nguoi lap don hang hay kh�ng
         * Step 2: lay che do dang lam viec, kiem tra du lieu dau vao. Neu OK thi 
         * tiep tuc tao cau truy van hoan tac neu dangThemMoi = false
         * Step 3: kiem tra xem cai ma don hang nay da ton tai chua ?
         *          Neu co thi ket thuc luon
         *          Neu khong thi cho them moi
         **************************************************/
        private void btnGHI_ItemClick(object sender, ItemClickEventArgs e)
        {
            viTri = bdsDonDatHang.Position;
            /*Step 1*/
            DataRowView drv = ((DataRowView)bdsDonDatHang[bdsDonDatHang.Position]);
            /*lay maNhanVien & maDonDatHang de phong truong hop them chi tiet don hang thi se co ngay*/
            String maNhanVien = drv["MANV"].ToString();
            String maDonDatHang = drv["MasoDDH"].ToString().Trim();

            if (Program.userName != maNhanVien && dangThemMoi == false)
            {
                MessageBox.Show("Bạn không thể sửa phiếu do người khác lập", "Thông báo", MessageBoxButtons.OK);
                return;
            }



            /*Step 2*/
            // X�c �?nh ch? �? d?a v�o binding source hi?n t?i thay v? menu
            String cheDo = (bds == bdsDonDatHang) ? "Đơn Đặt Hàng" : "Chi Tiết Đơn Đặt Hàng";

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
                MessageBox.Show("Th?c thi database th?t b?i!\n\n" + ex.Message, "Th�ng b�o",
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
            if ( result == 1 && cheDo == "Đơn Đặt Hàng" && viTriHienTai != viTriMaDonDatHang)
            {
                MessageBox.Show("Mã đơn hàng này đã được sử dụng !\n\n", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            /*****************************************************************
             * tat ca cac truong hop khac ko can quan tam !!
             *****************************************************************/
            
            else
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc muốn ghi dữ liệu vào cơ sở dữ liệu ?", "Thông báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    try
                    {
                        //Console.WriteLine(txtMaNhanVien.Text);
                        /*TH1: them moi don dat hang*/
                        if (cheDo == "Đơn Đặt Hàng" && dangThemMoi == true)
                        {
                            cauTruyVanHoanTac =
                                "DELETE FROM DBO.DATHANG " +
                                "WHERE MasoDDH = '" + maDonDatHang + "'";
                        }

                        /*TH2: them moi chi tiet don hang*/
                        if (cheDo == "Chi Tiết Đơn Đặt Hàng" && dangThemMoi == true)
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
                        // this.btnMENU.Enabled = true; // �? ?n menu
                        this.btnTHOAT.Enabled = true;

                        //this.groupBoxDonDatHang.Enabled = false;

                        /*c?p nh?t l?i tr?ng th�i th�m m?i cho ch?c*/
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
         * Step 0: tr�?ng h?p �? ?n btnTHEM nh�ng ch�a ?n btnGHI
         * Step 1: ki?m tra undoList c� tr�ng hay kh�ng ?
         * Step 2: Neu undoList khong tr?ng th? l?y ra kh�i ph?c
         *********************************************************************/
        private void btnHOANTAC_ItemClick(object sender, ItemClickEventArgs e)
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
                // this.btnMENU.Enabled = true; // �? ?n menu
                this.btnTHOAT.Enabled = true;


                bds.CancelEdit();
                /*xoa dong hien tai*/
                bds.RemoveCurrent();
                /* tr? v? l�c �?u con tr? �ang �?ng*/
                bds.Position = viTri;
                return;
            }

            /*Step 1*/
            if (undoList.Count == 0)
            {
                MessageBox.Show("Không còn thao tác nào để khôi phục", "Thông báo", MessageBoxButtons.OK);
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

        private void btnLAMMOI_ItemClick(object sender, ItemClickEventArgs e)
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
                MessageBox.Show("Lỗi Làm mới" + ex.Message, "Thông báo", MessageBoxButtons.OK);
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
         * Step 1: l?y ch? �? �ang s? d?ng v� �?t dangThemMoi = true �? ph?c v? �i?u ki?n t?o c�u truy
         * v?n ho�n t�c
         * Step 2: ki?m tra �i?u ki?n theo ch? �? �ang s? d?ng
         * Step 3: n?p c�u truy v?n ho�n t�c v�o undolist
         * Step 4: Th?c hi?n x�a n?u OK
         */
        private void btnXOA_ItemClick(object sender, ItemClickEventArgs e)
        {
            string cauTruyVan = "";
            string cheDo = (bds == bdsDonDatHang) ? "Đơn Đặt Hàng" : "Chi Tiết Đơn Đặt Hàng";

            dangThemMoi = true;// bat cai nay len de ung voi dieu kien tao cau truy van

            if (cheDo == "Đơn Đặt Hàng")
            {
                /*C�i bdsChiTietDonHangHang l� �?i di?n cho binding source ri�ng bi?t c?a CTDDH
                 *C?n cTDDHBindingSource l� l?y ngay t? trong data source DATHANG
                 */
                if(bdsChiTietDonDatHang.Count > 0)
                {
                    MessageBox.Show("Không thể xóa đơn đặt hàng này vì có chi tiết đơn đặt hàng", "Thông báo", MessageBoxButtons.OK);
                    return;
                }

                if (bdsPhieuNhap.Count > 0)
                {
                    MessageBox.Show("Không thể xóa đơn đặt hàng này vì có phiếu nhập", "Thông báo", MessageBoxButtons.OK);
                    return;
                }

                
            }
            if( cheDo == "Chi Tiết Đơn Đặt Hàng")
            {
                DataRowView drv = ((DataRowView)bdsDonDatHang[bdsDonDatHang.Position]);
                String maNhanVien = drv["MANV"].ToString();
                if (Program.userName != maNhanVien)
                {
                    MessageBox.Show("Bạn không xóa chi tiết đơn hàng trên phiếu không phải do mình tạo", "Thông báo", MessageBoxButtons.OK);
                    //bdsChiTietDonDatHang.RemoveCurrent();
                    return;
                }
            }

            cauTruyVan = taoCauTruyVanHoanTac(cheDo);
            //Console.WriteLine("Line 753");
            //Console.WriteLine(cauTruyVan);
            undoList.Push(cauTruyVan);

            /*Step 2*/
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "Thông báo",
                    MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    /*Step 3*/
                    viTri = bds.Position;
                    if(cheDo == "Đơn Đặt Hàng" )
                    {
                        bdsDonDatHang.RemoveCurrent();
                    }
                    if(cheDo == "Chi Tiết Đơn Đặt Hàng")
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
                    MessageBox.Show("Lỗi xóa nhân viên. Hãy thử lại\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
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
                MessageBox.Show("Xảy ra lỗi kết nối với chi nhánh hiện tại", "Thông báo", MessageBoxButtons.OK);
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

        // T? �?ng chuy?n sang ch? �? "Đơn Đặt Hàng" khi click v�o grid Đơn Đặt Hàng
        private void gcDonDatHang_Click(object sender, EventArgs e)
        {
            btnCheDoDonDatHang_ItemClick(null, null);
            
            // L�m n?i b?t grid �ang active
            gridView1.Appearance.ViewCaption.BackColor = Color.DeepSkyBlue;
            gridView1.Appearance.ViewCaption.Font = new Font("Tahoma", 10F, FontStyle.Bold);
            gvCTDDH.Appearance.ViewCaption.BackColor = SystemColors.Control;
            gvCTDDH.Appearance.ViewCaption.Font = new Font("Tahoma", 8.25F, FontStyle.Regular);
        }

        // T? �?ng chuy?n sang ch? �? "Đơn Đặt Hàng" khi click v�o groupbox ��n H�ng
        private void groupBoxDonDatHang_Click(object sender, EventArgs e)
        {
            btnCheDoDonDatHang_ItemClick(null, null);
            
            // L�m n?i b?t grid �ang active
            gridView1.Appearance.ViewCaption.BackColor = Color.DeepSkyBlue;
            gridView1.Appearance.ViewCaption.Font = new Font("Tahoma", 10F, FontStyle.Bold);
            gvCTDDH.Appearance.ViewCaption.BackColor = SystemColors.Control;
            gvCTDDH.Appearance.ViewCaption.Font = new Font("Tahoma", 8.25F, FontStyle.Regular);
        }

        // T? �?ng chuy?n sang ch? �? "Chi Tiết Đơn Đặt Hàng" khi click v�o grid Chi Ti?t
        private void gcChiTietDonDatHang_Click(object sender, EventArgs e)
        {
            btnCheDoChiTietDonDatHang_ItemClick(null, null);
            
            // L�m n?i b?t grid �ang active
            gridView1.Appearance.ViewCaption.BackColor = SystemColors.Control;
            gridView1.Appearance.ViewCaption.Font = new Font("Tahoma", 8.25F, FontStyle.Regular);
            gvCTDDH.Appearance.ViewCaption.BackColor = Color.DeepSkyBlue;
            gvCTDDH.Appearance.ViewCaption.Font = new Font("Tahoma", 10F, FontStyle.Bold);
        }

        // T? �?ng chuy?n sang ch? �? "Chi Tiết Đơn Đặt Hàng" khi click v�o groupbox Chi Ti?t
        private void groupBox1_Click(object sender, EventArgs e)
        {
            btnCheDoChiTietDonDatHang_ItemClick(null, null);
            
            // L�m n?i b?t grid �ang active
            gridView1.Appearance.ViewCaption.BackColor = SystemColors.Control;
            gridView1.Appearance.ViewCaption.Font = new Font("Tahoma", 8.25F, FontStyle.Regular);
            gvCTDDH.Appearance.ViewCaption.BackColor = Color.DeepSkyBlue;
            gvCTDDH.Appearance.ViewCaption.Font = new Font("Tahoma", 10F, FontStyle.Bold);
        }

        // Khi click v�o m?t d?ng trong gridView c?a Đơn Đặt Hàng
        private void gridView1_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            if (bds != bdsDonDatHang)
            {
                btnCheDoDonDatHang_ItemClick(null, null);
            }
            
            // L�m n?i b?t grid �ang active
            gridView1.Appearance.ViewCaption.BackColor = Color.DeepSkyBlue;
            gridView1.Appearance.ViewCaption.Font = new Font("Tahoma", 10F, FontStyle.Bold);
            gvCTDDH.Appearance.ViewCaption.BackColor = SystemColors.Control;
            gvCTDDH.Appearance.ViewCaption.Font = new Font("Tahoma", 8.25F, FontStyle.Regular);
        }

        // Khi click v�o m?t d?ng trong gridView c?a Chi Tiết Đơn Đặt Hàng
        private void gvCTDDH_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            if (bds != bdsChiTietDonDatHang)
            {
                btnCheDoChiTietDonDatHang_ItemClick(null, null);
            }
            
            // L�m n?i b?t grid �ang active
            gridView1.Appearance.ViewCaption.BackColor = SystemColors.Control;
            gridView1.Appearance.ViewCaption.Font = new Font("Tahoma", 8.25F, FontStyle.Regular);
            gvCTDDH.Appearance.ViewCaption.BackColor = Color.DeepSkyBlue;
            gvCTDDH.Appearance.ViewCaption.Font = new Font("Tahoma", 10F, FontStyle.Bold);
        }
    }
}
