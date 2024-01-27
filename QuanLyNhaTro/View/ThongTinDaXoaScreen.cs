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
    public partial class ThongTinScreen : Form
    {
        public ThongTinScreen()
        {
            InitializeComponent();
            LoadPhongDaXoa();
        }

        private void ThongTinScreen_Load(object sender, EventArgs e)
        {
            LoadPhongDaXoa();
        }
        #region phòng dũng
        DataTable dataPhong = new DataTable();
        private void LoadPhongDaXoa()
        {
            string sql = "SELECT * FROM Phong where DaXoa =0";
            dataPhong = BaseFunction.GetDataToTable(sql); //Đọc dữ liệu từ bảng
            dgv_Phong.DataSource = dataPhong; //Nguồn dữ liệu            
            dgv_Phong.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            dgv_Phong.EditMode = DataGridViewEditMode.EditProgrammatically; //Không cho sửa dữ liệu trực tiếp
        }

        private void btn_KhoiPhucPhong_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "UPDATE Phong SET DaXoa = 1 WHERE SoPhong = '" + txt_SoPhong.Text.Trim() + "'";
                BaseFunction.RunSQL(sql);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void dgv_Phong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem có phải click vào header row không
            if (e.RowIndex == -1) return;

            // Lấy hàng hiện tại được chọn
            //DataGridViewRow row = dgv_phong.Rows[e.RowIndex];
            DataGridViewRow row = dgv_Phong.Rows[e.RowIndex];
            if (row.Index == 0)
            {
                return;
            }
            // Chuyển thông tin lên form
            //txt.Text = row.Cells["MaPhong"].Value?.ToString() ?? "";
            txt_SoPhong.Text = row.Cells[1].Value?.ToString().Trim() ?? "";
            
        }
        #endregion phòng
    }
}
