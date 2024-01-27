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
    public partial class PhongScreen : Form
    {
        public PhongScreen(string ChuNhaID)
        {

            InitializeComponent();
        }

        private void PhongScreen_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyNhaTroDataSet.Phong' table. You can move, or remove it, as needed.
            this.phongTableAdapter.Fill(this.quanLyNhaTroDataSet.Phong);
            LoadPhong();
        }
        DataTable dataPhong = new DataTable();
        private void LoadPhong()
        {
            string sql = "SELECT * FROM Phong Where DaXoa =1";
            dataPhong = BaseFunction.GetDataToTable(sql); //Đọc dữ liệu từ bảng
            dgv_phong.DataSource = dataPhong; //Nguồn dữ liệu            
            dgv_phong.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            dgv_phong.EditMode = DataGridViewEditMode.EditProgrammatically; //Không cho sửa dữ liệu trực tiếp
        }
        private void cbx_TTphong_Click(object sender, EventArgs e)
        {
            BaseFunction.FillCombo("SELECT DISTINCT TrangThaiPhongID FROM Phong Where DaXoa =1", cbx_TTphong, "TrangThaiPhongID", "TenTrangThai");
        }


        private void btn_ThemPhong_Click(object sender, EventArgs e)
        {
            string sql;
            if (txt_Tang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập vào số tầng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_Tang.Focus();
                return;
            }
            if (txt_SoPhong.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số phòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_SoPhong.Focus();
                return;
            }
            if (txt_GiaPhong.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập giá phòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_GiaPhong.Focus();
                return;
            }
            if (txt_GhiChu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập ghi chú", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_GhiChu.Focus();
                return;
            }
            try
            {
                sql = "SELECT SoPhong FROM Phong WHERE DaXoa =1 and SoPhong=N'" + txt_SoPhong.Text.Trim() + "'";
                if (BaseFunction.CheckKey(sql))
                {
                    MessageBox.Show("Số phòng này đã có, bạn phải nhập số khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_SoPhong.Focus();
                    txt_SoPhong.Text = "";
                    return;
                }
                sql = "delete from Phong where DaXoa =0 and SoPhong = '" + txt_SoPhong.Text.Trim() + "'";
                if (BaseFunction.CheckKey(sql))
                {
                    BaseFunction.RunSqlDel(sql);
                }

                sql = "INSERT INTO Phong(ViTriPhongID, SoPhong, GiaPhong, GhiChu, TrangThaiPhongID) " +
                    "VALUES (N'" + txt_Tang.Text.Trim() + "', N'" + txt_SoPhong.Text.Trim() +
                    "', N'" + txt_GiaPhong.Text.Trim() + "', N'" + txt_GhiChu.Text.Trim() + "', 1)";
                BaseFunction.RunSQL(sql);
                LoadPhong();
            }
            catch (Exception)
            {
                MessageBox.Show("Thêm không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dgv_phong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem có phải click vào header row không
            if (e.RowIndex == -1) return;

            // Lấy hàng hiện tại được chọn
            //DataGridViewRow row = dgv_phong.Rows[e.RowIndex];
            DataGridViewRow row = dgv_phong.Rows[e.RowIndex];
            if (row.Index == 0)
            {
                return;
            }
            // Chuyển thông tin lên form
            //txt.Text = row.Cells["MaPhong"].Value?.ToString() ?? "";
            txt_Tang.Text = row.Cells[1].Value?.ToString().Trim() ?? "";
            txt_GiaPhong.Text = row.Cells[2].Value?.ToString().Trim() ?? "";
            txt_GhiChu.Text = row.Cells[3].Value?.ToString().Trim() ?? "";
            txt_SoPhong.Text = row.Cells[0].Value?.ToString().Trim() ?? "";
            
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string sql;
            if (txt_Tang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập vào số tầng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_Tang.Focus();
                return;
            }
            if (txt_SoPhong.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số phòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_SoPhong.Focus();
                return;
            }
            if (txt_GiaPhong.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập giá phòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_GiaPhong.Focus();
                return;
            }
            if (txt_GhiChu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập ghi chú", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_GhiChu.Focus();
                return;
            }
            try
            {
                sql = "UPDATE Phong " +
                    "SET ViTriPhongID=N'" + txt_Tang.Text.Trim() + "',GiaPhong=N'"
                    + txt_GiaPhong.Text.Trim() + "',GhiChu=N'" + txt_GhiChu.Text.Trim()
                    + "' WHERE SoPhong=N'" + txt_SoPhong.Text.Trim() + "'";
                BaseFunction.RunSQL(sql);
                LoadPhong();
            }
            catch (Exception)
            {
                MessageBox.Show("Sửa không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string sql;
            
            if (txt_SoPhong.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số phòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_SoPhong.Focus();
                return;
            }
            try
            {
                string sophong = txt_SoPhong.Text.Trim();
                int SoHopDong = BaseFunction.GetCount("Select Count(*) from HopDong where SoPhong = '" + sophong + "'");
                if (SoHopDong > 0)
                {
                    sql = "UPDATE HopDong SET DaXoa =0 Where SoPhong= '" + sophong + "'";
                    BaseFunction.RunSqlDel(sql);
                }
                sql = "UPDATE Phong SET DaXoa =0 Where SoPhong= '" + sophong + "'";
                BaseFunction.RunSqlDel(sql);
                LoadPhong();
            }
            catch (Exception)
            {
                MessageBox.Show("Xoá không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
