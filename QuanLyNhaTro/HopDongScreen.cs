using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaTro
{
    public partial class HopDongScreen : Form
    {
        public HopDongScreen()
        {
            InitializeComponent();
        }
        DataTable dataHopDong = new DataTable();
        private void LoadHopDong()
        {
            string sql = "SELECT * FROM HopDong where DaXoa = 1";
            dataHopDong = BaseFunction.GetDataToTable(sql); //Đọc dữ liệu từ bảng
            dgv_Hopdong.DataSource = dataHopDong; //Nguồn dữ liệu            
            dgv_Hopdong.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            dgv_Hopdong.EditMode = DataGridViewEditMode.EditProgrammatically; //Không cho sửa dữ liệu trực tiếp
        }
        private void HopDongScreen_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyNhaTroDataSet.HopDong' table. You can move, or remove it, as needed.
            this.hopDongTableAdapter.Fill(this.quanLyNhaTroDataSet.HopDong);
            LoadHopDong();
        }

        private void dgv_Hopdong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem có phải click vào header row không
            if (e.RowIndex == -1) return;

            // Lấy hàng hiện tại được chọn
       
            DataGridViewRow row = dgv_Hopdong.Rows[e.RowIndex];
            if (row.Index == 0)
            {
                return;
            }
            // Chuyển thông tin lên form
            //txt.Text = row.Cells["MaPhong"].Value?.ToString() ?? "";
            txt_KhachThueID.Text = row.Cells[1].Value?.ToString().Trim() ?? "";
            txt_soHopDong.Text = row.Cells[0].Value?.ToString().Trim() ?? "";
            txt_soLuongNguoi.Text = row.Cells[8].Value?.ToString().Trim() ?? "";
            txt_SoPhong.Text = row.Cells[2].Value?.ToString().Trim() ?? "";
            txt_TienCoc.Text = row.Cells[9].Value?.ToString().Trim() ?? "";

            // Giả sử cột ngày bắt đầu hợp đồng là cột thứ 4 (index 3)
            string dateString = row.Cells[5].Value?.ToString().Trim();
            if (DateTime.TryParse(dateString, out DateTime selectedDate))
            {
                dtp_TuNgay.Value = selectedDate;
            }
            else
            {
                // Xử lý trường hợp không parse được ngày
                MessageBox.Show("Dữ liệu ngày không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                // dtp_TuNgay.Value = DateTime.Now; // Hoặc đặt một giá trị mặc định nếu bạn muốn
            }
             dateString = row.Cells[6].Value?.ToString().Trim();
            if (DateTime.TryParse(dateString, out DateTime denngay))
            {
                dtp_NgayTra.Value = denngay;
            }
            else
            {
                // Xử lý trường hợp không parse được ngày
                MessageBox.Show("Dữ liệu ngày không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                // dtp_TuNgay.Value = DateTime.Now; // Hoặc đặt một giá trị mặc định nếu bạn muốn
            }
        }
        private void themKhachThue(string khachThueID,string Soluong)
        {
            string sql = "SELECT COUNT(*) FROM KhachThue WHERE DaXoa =1 and KhachThueID  = " + khachThueID ;
            int sl = Convert.ToInt32(Soluong);
            // Kiểm tra số lượng bản ghi có KhachThueID này
            int count = BaseFunction.GetCount(sql);

            // Nếu không có bản ghi nào, thêm mới KhachThue
            if (count == 0)
            {
                // TODO: Thêm các thông tin khác của KhachThue bạn cần nhập
                sql = "INSERT INTO KhachThue(KhachThueID, SoLuong) VALUES (" + khachThueID + ", "+sl+")";
                // Thực thi câu lệnh SQL để thêm mới
                BaseFunction.RunSQL(sql);
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            string sql;
            if (txt_SoPhong.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn số phòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_SoPhong.Focus();
                return;
            }
            if (txt_KhachThueID.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn khách thuê id", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_KhachThueID.Focus();
                return;
            }
            if (txt_soLuongNguoi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số lượng người", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_soLuongNguoi.Focus();
                return;
            }
            if (txt_TienCoc.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số tiền cọc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_TienCoc.Focus();
                return;
            }
            if (txt_soHopDong.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số hợp đồng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_TienCoc.Focus();
                return;
            }
            sql = "SELECT SoHopDong FROM HopDong WHERE DaXoa =1 and SoHopDong=N'" + txt_soHopDong.Text.Trim() + "'";
            if (BaseFunction.CheckKey(sql))
            {
                MessageBox.Show("số hợp đồng này đã có, bạn phải nhập số khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_SoPhong.Focus();
                txt_SoPhong.Text = "";
                return;
            }
            //kiểm tra phòng còn trống không
            sql = "select * from Phong where DaXoa =1 and TrangThaiPhongID =1 and SoPhong = " + txt_SoPhong.Text.Trim();
            int sl = BaseFunction.GetCount(sql);
            if (sl > 0)
            {
                sql = "delete from HopDong where DaXoa =0 and SoHopDong = '" + txt_soHopDong.Text.Trim() + "'";
                if (BaseFunction.CheckKey(sql))
                {
                    BaseFunction.RunSqlDel(sql);
                }
                themKhachThue(txt_KhachThueID.Text.Trim(), txt_soLuongNguoi.Text.Trim());
                string NgayLap = DateTime.Now.ToString("yyyy-MM-dd");
                string tungay = dtp_TuNgay.Value.ToString("yyyy-MM-dd");
                string denngay = dtp_NgayTra.Value.ToString("yyyy-MM-dd");
                sql = "select GiaPhong from Phong where DaXoa =1 and SoPhong = " + txt_SoPhong.Text.Trim();
                string GiaThue = BaseFunction.GetFieldValues(sql);
                try
                {
                    sql = "INSERT INTO HopDong(SoHopDong, ChuNhaID, KhachThueID, SoPhong, SoLuongNguoi, NgayLap, TuNgay, NgayTraPhong, TrangThaiThue, TienCoc, GiaThue) " +
                        "VALUES (" + txt_soHopDong.Text.Trim() + ", 1, " + txt_KhachThueID.Text.Trim() + ", " + txt_SoPhong.Text.Trim() +
                        ", " + txt_soLuongNguoi.Text.Trim() + ", '" + NgayLap + "', '" + tungay + "', '" + denngay + "', 1, " + txt_TienCoc.Text.Trim() + ", " + GiaThue + ")";

                    BaseFunction.RunSQL(sql);
                    sql = "UPDATE Phong SET TrangThaiPhongID = 2 WHERE SoPhong = " + txt_SoPhong.Text.Trim();
                    BaseFunction.RunSQL(sql);
                    LoadHopDong();
                }
                catch (Exception)
                {
                    MessageBox.Show("Thêm không thành công", "Thông báo");
                }
            }
            else
            {
               
                MessageBox.Show("phòng không trống", "Thông báo");
                return;
            }

        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string sql;
            if (txt_SoPhong.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn số phòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_SoPhong.Focus();
                return;
            }
            if (txt_KhachThueID.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn khách thuê id", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_KhachThueID.Focus();
                return;
            }
            // Tiếp tục kiểm tra các điều kiện cần thiết khác...

            string NgayLap = DateTime.Now.ToString("yyyy-MM-dd");
            string tungay = dtp_TuNgay.Value.ToString("yyyy-MM-dd");
            string denngay = dtp_NgayTra.Value.ToString("yyyy-MM-dd");
            sql = "select GiaPhong from Phong where SoPhong = " + txt_SoPhong.Text.Trim();
            string GiaThue = BaseFunction.GetFieldValues(sql);

            try
            {
                // Cập nhật thông tin hợp đồng
                sql = "UPDATE HopDong SET ChuNhaID = 1, KhachThueID = " + txt_KhachThueID.Text.Trim() +
                      ", SoPhong = " + txt_SoPhong.Text.Trim() + ", SoLuongNguoi = " + txt_soLuongNguoi.Text.Trim() +
                      ", NgayLap = '" + NgayLap + "', TuNgay = '" + tungay + "', NgayTraPhong = '" + denngay +
                      "', TrangThaiThue = 1, TienCoc = " + txt_TienCoc.Text.Trim() + ", GiaThue = " + GiaThue +
                      " WHERE SoHopDong = " + txt_soHopDong.Text.Trim();

                BaseFunction.RunSQL(sql);

                // Cập nhật thông tin phòng nếu cần
                sql = "UPDATE Phong SET TrangThaiPhongID = 2 WHERE SoPhong = " + txt_SoPhong.Text.Trim();
                BaseFunction.RunSQL(sql);

                LoadHopDong(); // Tải lại thông tin hợp đồng
            }
            catch (Exception)
            {
                MessageBox.Show("Cập nhật không thành công", "Thông báo");
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string sql;

            if (txt_soHopDong.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số hợp đồng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_soHopDong.Focus();
                return;
            }
            try
            {
                string sohopdong = txt_soHopDong.Text.Trim();
                int SoHoaDon = BaseFunction.GetCount("Select Count(*) from HoaDon where DaXoa =1 and SoHopDong = '" + sohopdong + "'");
                if (SoHoaDon > 0)
                {
                    sql = "UPDATE HoaDon SET DaXoa =0 Where SoHopDong= '" + sohopdong + "'";
                    BaseFunction.RunSqlDel(sql);
                }
                sql = "UPDATE HopDong SET DaXoa =0 Where SoHopDong= '" + sohopdong + "'";
                BaseFunction.RunSqlDel(sql);
                LoadHopDong();
            }
            catch (Exception)
            {
                MessageBox.Show("Xoá không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btn_traPhong_Click(object sender, EventArgs e)
        {
            try
            {
                string sohopdong = txt_soHopDong.Text.Trim();
                string sql = "UPDATE HopDong SET TrangThaiThue = 0 WHERE SoHopDong = " + sohopdong;
                BaseFunction.RunSQL(sql);
                 sql = "UPDATE Phong SET TrangThaiPhongID = 2 WHERE SoPhong = " + txt_SoPhong.Text.Trim();
                BaseFunction.RunSQL(sql);
            }
            catch (Exception)
            {
                MessageBox.Show("Cập nhật không thành công", "Thông báo");
            }
           
        }
    }
}
