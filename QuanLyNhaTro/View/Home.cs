using QuanLyNhaTro.Mail;
using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLyNhaTro
{
    public partial class Home : Form
    {
        string chunhaID;
        string _TenDangNhap;
        public Home(string tenDangNhap)
        {
            _TenDangNhap = tenDangNhap;
            chunhaID = LayThongTinNguoiDangLogin(tenDangNhap);
            InitializeComponent();
        }

        private string LayThongTinNguoiDangLogin(string tenDagnNhap)
        {
            string sql = $"SELECT ChuNhaID FROM ChuNha WHERE DaXoa =1 and TenDangNhap = '{tenDagnNhap}'";
            string chunhaID = BaseFunction.GetFieldValues(sql);
            return chunhaID;
        }
        private void Home_Load(object sender, EventArgs e)
        {
            //// TODO: This line of code loads data into the 'quanLyNhaTroDataSet.KhachThue' table. You can move, or remove it, as needed.
            //this.khachThueTableAdapter.Fill(this.quanLyNhaTroDataSet.KhachThue);
            //// TODO: This line of code loads data into the 'hoaDon._HoaDon' table. You can move, or remove it, as needed.
           this.hoaDonTableAdapter2.Fill(this.hoaDon._HoaDon);
            //// TODO: This line of code loads data into the 'quanLyNhaTroDataSet1.HoaDon' table. You can move, or remove it, as needed.
            this.hoaDonTableAdapter1.Fill(this.quanLyNhaTroDataSet1.HoaDon);
            //// TODO: This line of code loads data into the 'quanLyNhaTroDataSet.HoaDon' table. You can move, or remove it, as needed.
            this.hoaDonTableAdapter.Fill(this.quanLyNhaTroDataSet.HoaDon);
            //// TODO: This line of code loads data into the 'quanLyNhaTroDataSet.HopDong' table. You can move, or remove it, as needed.
            //this.hopDongTableAdapter.Fill(this.quanLyNhaTroDataSet.HopDong);

            //// TODO: This line of code loads data into the 'quanLyNhaTroDataSet.Phong' table. You can move, or remove it, as needed.
            //this.phongTableAdapter.Fill(this.quanLyNhaTroDataSet.Phong);
            LoadPhong();
            LoadChuNha();
            LoadHopDong();
            LoadHoaDon();
            LoadKhachHang();
        }
        #region phòng dũng
        DataTable dataPhong = new DataTable();
        private void cbx_phong_Click(object sender, EventArgs e)
        {
            BaseFunction.FillCombo("SELECT ViTriPhongID FROM ViTriPhong where DaXoa =1", cbx_phong, "ViTriPhongID", "TenViTri");
        }

        private void btn_CTPhong_Click(object sender, EventArgs e)
        {
            PhongScreen phong = new PhongScreen(chunhaID);
            phong.Show();
        }
        private void LoadPhong()
        {
            string sql = "SELECT * FROM Phong where DaXoa =1 ";
            dataPhong = BaseFunction.GetDataToTable(sql); //Đọc dữ liệu từ bảng
            dgv_Phong.DataSource = dataPhong; //Nguồn dữ liệu            
            dgv_Phong.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            dgv_Phong.EditMode = DataGridViewEditMode.EditProgrammatically; //Không cho sửa dữ liệu trực tiếp

        }
        private void btn_hienThi_Click(object sender, EventArgs e)
        {
            if (cbx_phong.SelectedIndex == -1)
            {
                LoadPhong();
            }

            string vitri = cbx_phong.SelectedValue.ToString() ;
            string sql = $"SELECT * FROM Phong WHERE ViTriPhongID ={vitri} and DaXoa =1";
            dataPhong = BaseFunction.GetDataToTable(sql); //Đọc dữ liệu từ bảng
            dgv_Phong.DataSource = dataPhong; //Nguồn dữ liệu            
            dgv_Phong.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            dgv_Phong.EditMode = DataGridViewEditMode.EditProgrammatically; //Không cho sửa dữ liệu trực tiếp
        }



        #endregion dũng
        #region nhân viên băng

        DataTable dataChuNha = new DataTable();
        DataTable originalData = new DataTable();
        private void LoadChuNha()
        {
            string sql = "SELECT ChuNhaID, HoTen, NgaySinh, Email, SDT, TenDangNhap FROM ChuNha WHERE QuyenHanID = 2 and DaXoa =1";
            originalData = BaseFunction.GetDataToTable(sql);
            dgv_NV.DataSource = originalData;
            dgv_NV.AllowUserToAddRows = false;
            dgv_NV.EditMode = DataGridViewEditMode.EditProgrammatically;

            // Ẩn các cột không muốn hiển thị
            if (dgv_NV.Columns.Contains("QuyenHanID"))
            {
                dgv_NV.Columns["QuyenHanID"].Visible = false;
            }

            if (dgv_NV.Columns.Contains("MatKhau"))
            {
                dgv_NV.Columns["MatKhau"].Visible = false;
            }
        }
        #endregion

        private void btn_ChitietNV_Click(object sender, EventArgs e)
        {
            NhanVienScreen nhanvien = new NhanVienScreen(chunhaID);
            nhanvien.Show();

        }

        private void btnhienThiNV_Click(object sender, EventArgs e)
        {
            if (txtTimkiemNV.Text.Trim() == "")
            {
                LoadChuNha();
            }
            else
            {
                string searchText = txtTimkiemNV.Text.Trim();

                DataView dv = originalData.DefaultView;

                dv.RowFilter = $" HoTen LIKE '%{searchText}%' OR Email LIKE '%{searchText}%' OR TenDangNhap LIKE '%{searchText}%'";

                if (originalData.Columns["ChuNhaID"].DataType == typeof(string))
                {
                    dv.RowFilter += $" OR ChuNhaID LIKE '%{searchText}%'";
                }

                dgv_NV.DataSource = dv.ToTable();
            }
        }
        #region hưng hợp đồng
        DataTable dataHopDong = new DataTable();
        DataTable originalDataHopDong = new DataTable();
        private void LoadHopDong()
        {
            string sql = "SELECT * FROM HopDong where DaXoa =1";
            dataHopDong = BaseFunction.GetDataToTable(sql);
            dgv_HopDong.DataSource = dataHopDong;
            dgv_HopDong.AllowUserToAddRows = false;
            dgv_HopDong.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void btn_HopDongHienThi_Click(object sender, EventArgs e)
        {
            if (cbx_HopDong.SelectedIndex == -1)
            {
                LoadPhong();
            }
            string soPhong = cbx_HopDong.SelectedValue.ToString().Trim() ;
            string sql = "SELECT * FROM HopDong WHERE SoPhong = "+soPhong + " and DaXoa =1";
            dataHopDong = BaseFunction.GetDataToTable(sql); //Đọc dữ liệu từ bảng
            dgv_HopDong.DataSource = dataHopDong; //Nguồn dữ liệu            
            dgv_HopDong.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            dgv_HopDong.EditMode = DataGridViewEditMode.EditProgrammatically; //Không cho sửa dữ liệu trực tiếp
        }

        private void dgv_HopDong_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbx_HopDong_Click(object sender, EventArgs e)
        {
            BaseFunction.FillCombo("SELECT DISTINCT SoPhong FROM HopDong", cbx_phong, "SoPhong", "SoPhong");
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            HopDongScreen hopDong = new HopDongScreen();
            hopDong.Show();
        }
        #endregion hưng hợp đồng

        #region dũng hoá đơn
        DataTable dataHoaDon = new DataTable();
        private void btn_chiTietHoaDon_Click(object sender, EventArgs e)
        {
            HoaDonScreen hoaDon = new HoaDonScreen();
            hoaDon.Show();
            this.Hide();
        }
        private void LoadHoaDon()
        {
            string sql = "SELECT * FROM HoaDon where DaXoa =1";
            dataPhong = BaseFunction.GetDataToTable(sql); //Đọc dữ liệu từ bảng
            dgv_Phong.DataSource = dataPhong; //Nguồn dữ liệu            
            dgv_Phong.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            dgv_Phong.EditMode = DataGridViewEditMode.EditProgrammatically; //Không cho sửa dữ liệu trực tiếp
        }

        private void btn_timHoaDon_Click(object sender, EventArgs e)
        {
            if (cbx_phong.SelectedIndex == -1)
            {
                LoadPhong();
            }

            int thangLap =Convert.ToInt32( cbx_thang.SelectedValue.ToString() );
            int NamLap = Convert.ToInt32(cbx_nam.SelectedValue.ToString());
            string sql = "SELECT * FROM HoaDon WHERE ThangLap = "+thangLap+" and NamLap = "+NamLap+" and DaXoa =1";
            dataPhong = BaseFunction.GetDataToTable(sql); //Đọc dữ liệu từ bảng
            dtg_hoaDon.DataSource = dataHoaDon; //Nguồn dữ liệu            
            dtg_hoaDon.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            dtg_hoaDon.EditMode = DataGridViewEditMode.EditProgrammatically; //Không cho sửa dữ liệu trực tiếp

        }
        private void cbx_nam_Click(object sender, EventArgs e)
        {
            BaseFunction.FillCombo("SELECT distinct ThangLap FROM HoaDon where DaXoa =1", cbx_thang, "ThangLap", "ThangLap");

        }

        private void cbx_thang_Click(object sender, EventArgs e)
        {
            BaseFunction.FillCombo("SELECT  distinct NamLap FROM HoaDon where DaXoa =1", cbx_nam, "NamLap", "NamLap");

        }
        private void button2_Click(object sender, EventArgs e)
        {
            int thangLap = Convert.ToInt32(cbx_thang.SelectedValue.ToString().Trim());
            int NamLap = Convert.ToInt32(cbx_nam.SelectedValue.ToString().Trim());
            SendHoaDon.SendEmailsForAllBills(thangLap,NamLap);
            MessageBox.Show(Text = "Đã gửi hóa đơn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion dũng hoá đơn

        #region vũ khách hàng
        DataTable DataKhachHang = new DataTable();
        private void cbx_KH_Click(object sender, EventArgs e)
        {
            BaseFunction.FillCombo("SELECT KhachThueID FROM KhachThue where DaXoa =1", cbx_thang, "KhachThueID", "KhachThueID");

        }
        private void LoadKhachHang()
        {
            string sql = "SELECT * FROM KhachThue where DaXoa =1";
            DataKhachHang = BaseFunction.GetDataToTable(sql); //Đọc dữ liệu từ bảng
            dgv_KhachHang.DataSource = DataKhachHang; //Nguồn dữ liệu            
            dgv_KhachHang.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            dgv_KhachHang.EditMode = DataGridViewEditMode.EditProgrammatically; //Không cho sửa dữ liệu trực tiếp

        }
        private void btn_hienThiKhachhang_Click(object sender, EventArgs e)
        {
            if (cbx_phong.SelectedIndex == -1)
            {
                LoadPhong();
            }

            int thangLap = Convert.ToInt32(cbx_KH.SelectedValue.ToString());
            string sql = "SELECT * FROM KhachThue WHERE KhachThueID = " + thangLap + " and DaXoa =1";
            DataKhachHang = BaseFunction.GetDataToTable(sql); //Đọc dữ liệu từ bảng
            dgv_KhachHang.DataSource = DataKhachHang; //Nguồn dữ liệu            
            dgv_KhachHang.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            dgv_KhachHang.EditMode = DataGridViewEditMode.EditProgrammatically; //Không cho sửa dữ liệu trực tiếp
        }

        private void btn_ChiTietKH_Click(object sender, EventArgs e)
        {
            KhachHangScreen khachHangScreen = new KhachHangScreen();
            khachHangScreen.Show();
        }

        #endregion vũ khách hàng

        private void btn_ThongTin_Click(object sender, EventArgs e)
        {
            ThongTinBanThan thongTin = new ThongTinBanThan(_TenDangNhap);
            thongTin.Show();
        }

        private void cbx_HopDong_Click_1(object sender, EventArgs e)
        {
            BaseFunction.FillCombo("SELECT SoPhong FROM HopDong where DaXoa =1", cbx_HopDong, "SoPhong", "SoPhong");

        }
    }
}

