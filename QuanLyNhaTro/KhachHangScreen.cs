using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLyNhaTro
{
    public partial class KhachHangScreen : Form
    {
        public KhachHangScreen()
        {
            InitializeComponent();
        }

        private void KhachHangScreen_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyNhaTroDataSet.ChiTietKhachThue' table. You can move, or remove it, as needed.
            this.chiTietKhachThueTableAdapter.Fill(this.quanLyNhaTroDataSet.ChiTietKhachThue);
            LoadKhachHang();
        }
        DataTable DataTableKhachThue = new DataTable();
        DataTable DataTableChiTietKhachThue = new DataTable();
        private void LoadKhachHang()
        {
            string sql = "SELECT * FROM ChiTietKhachThue where DaXoa =1";
            DataTableChiTietKhachThue = BaseFunction.GetDataToTable(sql); //Đọc dữ liệu từ bảng
            dgv_khachHang.DataSource = DataTableChiTietKhachThue; //Nguồn dữ liệu            
            dgv_khachHang.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            dgv_khachHang.EditMode = DataGridViewEditMode.EditProgrammatically; //Không cho sửa dữ liệu trực tiếp
        }

        private void btn_timKiem_Click(object sender, EventArgs e)
        {
            if (cbx_khachThue.SelectedIndex == -1)
            {
                LoadKhachHang();
            }

            int thangLap = Convert.ToInt32(cbx_khachThue.SelectedValue.ToString());
            string sql = "SELECT * FROM ChiTietKhachThue WHERE KhachThueID = " + thangLap + " and DaXoa =1";
            DataTableChiTietKhachThue = BaseFunction.GetDataToTable(sql); //Đọc dữ liệu từ bảng
            dgv_khachHang.DataSource = DataTableChiTietKhachThue; //Nguồn dữ liệu            
            dgv_khachHang.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            dgv_khachHang.EditMode = DataGridViewEditMode.EditProgrammatically; //Không cho sửa dữ liệu trực tiếp
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (txt_CCCD.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập vào CCCD", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_CCCD.Focus();
                return;
            }
            if (txt_HoTen.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập vào Họ Tên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_HoTen.Focus();
                return;
            }
            if (txt_SDT.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập vào Số Điện Thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_SDT.Focus();
                return;
            }
            if (txt_DiaChi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập vào Địa Chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_DiaChi.Focus();
                return;
            }
            if (txt_Email.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập vào Email", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_Email.Focus();
                return;
            }
            if (txt_GhiChu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập vào Ghi Chú", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_GhiChu.Focus();
                return;
            }
            string sql;
            try
            {
                string KhachThueId = int.Parse(cbx_khachThue.SelectedValue.ToString()).ToString();

                sql = "UPDATE ChiTietKhachThue SET " +
                      "CCCD = '" + txt_CCCD.Text.Trim() + "', " +
                      "HoTen = '" + txt_HoTen.Text.Trim() + "', " +
                      "NgaySinh = '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "', " +
                      "Email = '" + txt_Email.Text.Trim() + "', " +
                      "SDT = '" + txt_SDT.Text.Trim() + "', " +
                      "DiaChi = '" + txt_DiaChi.Text.Trim() + "', " +
                      "GhiChu = '" + txt_GhiChu.Text.Trim() + "' " +
                      "WHERE KhachThueID = '" + KhachThueId + "'";

                BaseFunction.RunSQL(sql);
                LoadKhachHang();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (txt_CCCD.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập vào CCCD", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_CCCD.Focus();
                return;
            }
            if (txt_HoTen.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập vào Họ Tên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_HoTen.Focus();
                return;
            }
            if (txt_SDT.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập vào Số Điện Thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_SDT.Focus();
                return;
            }
            if (txt_DiaChi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập vào Địa Chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_DiaChi.Focus();
                return;
            }
            if (txt_Email.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập vào Email", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_Email.Focus();
                return;
            }
            if (txt_GhiChu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập vào Ghi Chú", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_GhiChu.Focus();
                return;
            }
            string sql;
            try
            {string KhachThueId =int .Parse(cbx_khachThue.SelectedValue.ToString()).ToString();

                sql = "INSERT INTO ChiTietKhachThue(CCCD, HoTen, NgaySinh, Email, SDT, DiaChi, GhiChu,KhachThueID) " +
                      "VALUES ('" + txt_CCCD.Text.Trim() + "', '" + txt_HoTen.Text.Trim() + "', '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") +
                      "', '" + txt_Email.Text.Trim() + "', '" + txt_SDT.Text.Trim() + "', '" + txt_DiaChi.Text.Trim() +
                      "', '" + txt_GhiChu.Text.Trim() + "','" +KhachThueId + "')";
                BaseFunction.RunSQL(sql);
                LoadKhachHang();
            }
            catch (Exception)
            {
                MessageBox.Show("Thêm không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (txt_CCCD.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập vào CCCD", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_CCCD.Focus();
                return;
            }
            try
            {
                string sql = "UPDATE ChiTietKhachThue SET DaXoa =0 Where CCCD= '" + txt_CCCD.Text.Trim() + "'";
                BaseFunction.RunSqlDel(sql);
                LoadKhachHang();    
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            BaseFunction.FillCombo("SELECT KhachThueID FROM KhachThue where DaXoa =1", cbx_khachThue, "KhachThueID", "KhachThueID");
        }

        private void dgv_khachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem có phải click vào header row không
            if (e.RowIndex == -1) return;

            // Lấy hàng hiện tại được chọn
            //DataGridViewRow row = dgv_phong.Rows[e.RowIndex];
            DataGridViewRow row = dgv_khachHang.Rows[e.RowIndex];
            if (row.Index == 0)
            {
                return;
            }
            // Chuyển thông tin lên form
            //txt.Text = row.Cells["MaPhong"].Value?.ToString() ?? "";
            txt_CCCD.Text = row.Cells[0].Value?.ToString().Trim() ?? "";
            txt_HoTen.Text = row.Cells[2].Value?.ToString().Trim() ?? "";
            txt_GhiChu.Text = row.Cells[7].Value?.ToString().Trim() ?? "";
            txt_SDT.Text = row.Cells[6].Value?.ToString().Trim() ?? "";
            txt_DiaChi.Text = row.Cells[4].Value?.ToString().Trim() ?? "";
            txt_Email.Text = row.Cells[5].Value?.ToString().Trim() ?? "";
            string dateString = row.Cells[3].Value?.ToString().Trim();
            if (DateTime.TryParse(dateString, out DateTime selectedDate))
            {
                dateTimePicker1.Value = selectedDate;
            }
            else
            {
                // Xử lý trường hợp không parse được ngày
                MessageBox.Show("Dữ liệu ngày không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                // dtp_TuNgay.Value = DateTime.Now; // Hoặc đặt một giá trị mặc định nếu bạn muốn
            }
        }
    }
}
