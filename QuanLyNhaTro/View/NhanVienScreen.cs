using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLyNhaTro
{
    public partial class NhanVienScreen : Form
    {
        //băng
        string ChuNhaId;
        public NhanVienScreen(string ChuNhaID)
        {
            ChuNhaId = ChuNhaID;
            InitializeComponent();
        }
        DataTable dataChuNha = new DataTable();
        private void LoadChuNha()
        {

            string sql = "SELECT * FROM ChuNha WHERE QuyenHanID = 2 and DaXoa = 1";
            dataChuNha = BaseFunction.GetDataToTable(sql);
            dgv_NV.DataSource = dataChuNha;
            dgv_NV.AllowUserToAddRows = false;
            dgv_NV.EditMode = DataGridViewEditMode.EditProgrammatically;
            // Ẩn các cột không muốn hiển thị
            if (dgv_NV.Columns.Contains("DaXoa"))
            {
                dgv_NV.Columns["DaXoa"].Visible = false;
            }
        }

        private void ClearFormData()
        {
            txt_Hoten.Text = "";
            dtp_Ngaysinh.Value = DateTime.Now;
            txt_Email.Text = "";
            txt_SDT.Text = "";
            txt_TenDN.Text = "";
            txt_Matkhau.Text = "";
        }
        private void btn_ThemNV_Click(object sender, EventArgs e)
        {
            string sql;
            if (txt_Hoten.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập vào Họ tên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_Hoten.Focus();
                return;
            }
            if (dtp_Ngaysinh.Value == null)
            {
                MessageBox.Show("Bạn phải chọn ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtp_Ngaysinh.Focus();
                return;
            }
            if (txt_Email.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Email", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_Email.Focus();
                return;
            }
            if (txt_SDT.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_SDT.Focus();
                return;
            }
            if (txt_TenDN.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_TenDN.Focus();
                return;
            }
            if (txt_Matkhau.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_Matkhau.Focus();
                return;
            }
            try
            {
                sql = "SELECT TenDangNhap FROM ChuNha WHERE DaXoa =1 and TenDangNhap=N'" + txt_TenDN.Text.Trim() + "'";
                if (BaseFunction.CheckKey(sql))
                {
                    MessageBox.Show("Tên đăng nhập này đã có, bạn phải nhập tên đăng nhập khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_TenDN.Focus();
                    txt_TenDN.Text = "";
                    return;
                }
                sql = "delete FROM ChuNha WHERE DaXoa =0 and TenDangNhap=N'" + txt_TenDN.Text.Trim() + "'";
                if (BaseFunction.CheckKey(sql))
                {
                    BaseFunction.RunSqlDel(sql);
                }

                sql = "INSERT INTO ChuNha (HoTen, NgaySinh, Email, SDT, QuyenHanID, TenDangNhap, MatKhau, ChuNhaID) " +
                    "VALUES (N'" + txt_Hoten.Text.Trim() + "', N'" + dtp_Ngaysinh.Value.ToString("yyyy-MM-dd") + "', " +
                    " N'" + txt_Email.Text.Trim() + "', N'" + txt_SDT.Text.Trim() + "', " +
                    "2, N'" + txt_TenDN.Text.Trim() + "', N'" + txt_Matkhau.Text.Trim() + "', N'" + txt_ChuNhaID.Text.Trim() + "')";
                BaseFunction.RunSQL(sql);
                LoadChuNha();
                ClearFormData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Thêm không thành công. Lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NhanVienScreen_Load(object sender, EventArgs e)
        {
            dgv_NV.CellContentClick += dgv_NV_CellContentClick;

            LoadChuNha();
        }

        private void dgv_NV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgv_NV.Rows[e.RowIndex];
            if (e.RowIndex == -1)
            {
                return;
            }

            txt_Hoten.Text = row.Cells["HoTen"].Value?.ToString() ?? "";
            if (DateTime.TryParse(row.Cells["NgaySinh"].Value?.ToString(), out DateTime ngaySinh))
            {
                dtp_Ngaysinh.Value = ngaySinh;
            }
            else
            {
                dtp_Ngaysinh.Value = DateTime.Now;
            }
            txt_Email.Text = row.Cells["Email"].Value?.ToString().Trim() ?? "";
            txt_SDT.Text = row.Cells["SDT"].Value?.ToString().Trim() ?? "";
            txt_TenDN.Text = row.Cells["TenDangNhap"].Value?.ToString().Trim() ?? "";
            txt_Matkhau.Text = row.Cells["MatKhau"].Value?.ToString().Trim() ?? "";
            txt_ChuNhaID.Text = row.Cells["ChuNhaID"].Value?.ToString().Trim() ?? "";
        }

        private void btn_SuaNV_Click(object sender, EventArgs e)
        {
            string sql;
            if (txt_Hoten.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn một bản ghi để sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_Hoten.Focus();
                return;
            }
            if (dtp_Ngaysinh.Value == null)
            {
                MessageBox.Show("Bạn phải chọn ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtp_Ngaysinh.Focus();
                return;
            }
            if (txt_Email.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Email", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_Email.Focus();
                return;
            }
            if (txt_SDT.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_SDT.Focus();
                return;
            }
            if (txt_TenDN.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_TenDN.Focus();
                return;
            }
            if (txt_Matkhau.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_Matkhau.Focus();
                return;
            }
            try
            {
                sql = "UPDATE ChuNha " +
                    "SET HoTen=N'" + txt_Hoten.Text.Trim() + "', NgaySinh=N'"
                    + dtp_Ngaysinh.Value.ToString("yyyy-MM-dd") + "', Email=N'" + txt_Email.Text.Trim()
                    + "', SDT=N'" + txt_SDT.Text.Trim() + "', TenDangNhap=N'" + txt_TenDN.Text.Trim()
                    + "', MatKhau=N'" + txt_Matkhau.Text.Trim() + "' WHERE TenDangNhap=N'" + txt_TenDN.Text.Trim() + "'";
                BaseFunction.RunSQL(sql);

                LoadChuNha();
                ClearFormData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Sửa không thành công. Lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_XoaNV_Click(object sender, EventArgs e)
        {
            string sql;
            if (txt_Hoten.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn một bản ghi để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                sql = "UPDATE ChuNha SET DaXoa =0 Where TenDangNhap= '" + txt_TenDN.Text.Trim() + "'";
                BaseFunction.RunSQL(sql);

                LoadChuNha();
                ClearFormData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Xoá không thành công. Lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
