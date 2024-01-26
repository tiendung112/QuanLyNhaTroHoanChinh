using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaTro
{
    public partial class HoaDonScreen : Form
    {
        public HoaDonScreen()
        {
            InitializeComponent();
        }
        DataTable dataHoaDon = new DataTable();
        private Home home = new Home("abc");
        private void LoadHoaDon()
        {
            string sql = "SELECT * FROM HoaDon where DaXoa =1";
            dataHoaDon = BaseFunction.GetDataToTable(sql); //Đọc dữ liệu từ bảng
            dgv_HoaDon.DataSource = dataHoaDon; //Nguồn dữ liệu            
            dgv_HoaDon.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            dgv_HoaDon.EditMode = DataGridViewEditMode.EditProgrammatically; //Không cho sửa dữ liệu trực tiếp
        }
        private void HoaDonScreen_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hoaDon._HoaDon' table. You can move, or remove it, as needed.
            this.hoaDonTableAdapter.Fill(this.hoaDon._HoaDon);
            LoadHoaDon();
        }
       
        private void btn_them_Click(object sender, EventArgs e)
        {
            //thêm hoá đơn 
            if (txt_HoaDonID.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn số hoá đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_HoaDonID.Focus();
                return;
            }
            if(txt_SoPhong.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn số phòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_SoPhong.Focus();
                return;

            }
            if(txt_SoDienMoi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn số điện mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_SoDienMoi.Focus();
                return;
            }
            if(txt_SoNuoc.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn số nước", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_SoNuoc.Focus();
                return;
            }
            if(txt_GiaDien.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn giá điện", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_HoaDonID.Focus();
                return;
            }
            if(txt_GiaNuoc.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn giá nước", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_GiaNuoc.Focus();
                return;
            }
            if(txt_GiaKhac.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn giá khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_GiaKhac.Focus();
                return;
            }
            if(txt_ghiChu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn ghi chú", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_ghiChu.Focus();
                return;
            }
            string sql;
            try
            {
                string ngay = DateTime.Now.Day.ToString();
                string thang = DateTime.Now.Month.ToString();
                string nam = DateTime.Now.Year.ToString();
                sql = "select SoHopDong from HopDong where SoPhong = '" + txt_SoPhong.Text.Trim() + "' and DaXoa = 1";
                int SoHopDong =Convert.ToInt32( BaseFunction.GetFieldValues(sql));
                sql = "select top 1  SoDienMoi from HoaDon where SoHopDong = '" + SoHopDong + "' and DaXoa = 1 order by  SoDienMoi DESC";
                int SoDienCu = Convert.ToInt32(BaseFunction.GetFieldValues(sql));
                sql = "INSERT INTO HoaDon (HoaDonID, SoPhong, SoHopDong, SoDienCu, SoDienMoi, SoNuoc, GiaDien, GiaNuoc, GiaDichVuKhac, GhiChu, NgayLap, ThangLap, NamLap) " +
                     "VALUES ('" + txt_HoaDonID.Text.Trim() + "', '" + txt_SoPhong.Text.Trim() + "', " + SoHopDong + ", " + SoDienCu + ", " + txt_SoDienMoi.Text.Trim() + ", " +
                     txt_SoNuoc.Text.Trim() + ", " + txt_GiaDien.Text.Trim() + ", " + txt_GiaNuoc.Text.Trim() + ", " + txt_GiaKhac.Text.Trim() + ", '" + txt_ghiChu.Text.Trim() + "', " + ngay + ", " + thang + ", " + nam + ")";
                BaseFunction.RunSQL(sql);
                LoadHoaDon();
                
            }
            catch (Exception)
            {
                MessageBox.Show("Thêm không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {//thêm hoá đơn 
            if (txt_HoaDonID.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn số hoá đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_HoaDonID.Focus();
                return;
            }
            if (txt_SoPhong.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn số phòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_SoPhong.Focus();
                return;

            }
            if (txt_SoDienMoi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn số điện mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_SoDienMoi.Focus();
                return;
            }
            if (txt_SoNuoc.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn số nước", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_SoNuoc.Focus();
                return;
            }
            if (txt_GiaDien.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn giá điện", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_HoaDonID.Focus();
                return;
            }
            if (txt_GiaNuoc.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn giá nước", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_GiaNuoc.Focus();
                return;
            }
            if (txt_GiaKhac.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn giá khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_GiaKhac.Focus();
                return;
            }
            if (txt_ghiChu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn ghi chú", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_ghiChu.Focus();
                return;
            }
            string sql;
            try
            {
                // Lấy ngày tháng năm hiện tại
                string ngay = DateTime.Now.Day.ToString();
                string thang = DateTime.Now.Month.ToString();
                string nam = DateTime.Now.Year.ToString();
                sql = "select SoHopDong from HopDong where SoPhong = '" + txt_SoPhong.Text.Trim() + "' and DaXoa = 1";
                int SoHopDong = Convert.ToInt32(BaseFunction.GetFieldValues(sql));
                sql = "select top 1  SoDienMoi from HoaDon where SoHopDong = '" + SoHopDong + "' and DaXoa = 1 order by  SoDienMoi DESC";
                int SoDienCu = Convert.ToInt32(BaseFunction.GetFieldValues(sql));
                // Cập nhật thông tin hóa đơn
                sql = "UPDATE HoaDon SET SoPhong = '" + txt_SoPhong.Text.Trim() +
                      "', SoDienCu = " + SoDienCu + // Sử dụng SoDienCu đã lấy từ DB trước đó
                      ", SoDienMoi = " + txt_SoDienMoi.Text.Trim() +
                      ", SoNuoc = " + txt_SoNuoc.Text.Trim() +
                      ", GiaDien = " + txt_GiaDien.Text.Trim() +
                      ", GiaNuoc = " + txt_GiaNuoc.Text.Trim() +
                      ", GiaDichVuKhac = " + txt_GiaKhac.Text.Trim() +
                      ", GhiChu = '" + txt_ghiChu.Text.Trim() +
                      "', NgayLap = " + ngay +
                      ", ThangLap = " + thang +
                      ", NamLap = " + nam +
                      " WHERE HoaDonID = '" + txt_HoaDonID.Text.Trim() + "'";

                BaseFunction.RunSQL(sql);
                LoadHoaDon(); // Tải lại danh sách hóa đơn
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sửa không thành công. Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (txt_HoaDonID.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn số hoá đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_HoaDonID.Focus();
                return;
            }
            try
            {
                
                string sql  = "UPDATE HoaDon SET DaXoa =0 Where HoaDonID= '" + txt_HoaDonID.Text.Trim() + "'";
                BaseFunction.RunSqlDel(sql);
                LoadHoaDon();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void dgv_HoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            // Kiểm tra xem có phải click vào header row không
            if (e.RowIndex == -1) return;

            // Lấy hàng hiện tại được chọn
            //DataGridViewRow row = dgv_phong.Rows[e.RowIndex];
            DataGridViewRow row = dgv_HoaDon.Rows[e.RowIndex];
            if (row.Index == 0)
            {
                return;
            }
            // Chuyển thông tin lên form
            //txt.Text = row.Cells["MaPhong"].Value?.ToString() ?? "";
            txt_HoaDonID.Text = row.Cells[0].Value?.ToString().Trim() ?? "";
            txt_SoPhong.Text = row.Cells[2].Value?.ToString().Trim() ?? "";
            txt_SoDienMoi.Text = row.Cells[7].Value?.ToString().Trim() ?? "";
            txt_GiaDien.Text = row.Cells[8].Value?.ToString().Trim() ?? "";
            txt_ghiChu.Text = row.Cells[12].Value?.ToString().Trim() ?? "";
            txt_SoNuoc.Text = row.Cells[10].Value?.ToString().Trim() ?? "";
            txt_GiaNuoc.Text = row.Cells[9].Value?.ToString().Trim() ?? "";
            txt_GiaKhac.Text = row.Cells[11].Value?.ToString().Trim() ?? "";
        }

        private void HoaDonScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            home.Show();
        }
    }
}
