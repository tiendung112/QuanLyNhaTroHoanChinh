using System;
using System.Windows.Forms;

namespace QuanLyNhaTro
{
    public partial class ThongTinBanThan : Form
    {
        public string tenDangNhap;
        public ThongTinBanThan(string _tenDangNhap)
        {
            tenDangNhap = _tenDangNhap;
            InitializeComponent();
        }

        private void btn_thungrac_Click(object sender, EventArgs e)
        {
            ThongTinScreen thongTin = new ThongTinScreen();
            thongTin.Show();
        }
        private void LoadThongTinBanThan()
        {
            try
            {
                string sql = "SELECT * FROM ChuNha Where TenDangNhap = '" + tenDangNhap + "'";
                string hoTen = BaseFunction.GetFieldValues("SELECT HoTen FROM ChuNha Where TenDangNhap = '" + tenDangNhap + "'");
                string NgaySinh = BaseFunction.GetFieldValues("SELECT NgaySinh FROM ChuNha Where TenDangNhap = '" + tenDangNhap + "'");
                string Email = BaseFunction.GetFieldValues("SELECT Email FROM ChuNha Where TenDangNhap = '" + tenDangNhap + "'");
                string SDT = BaseFunction.GetFieldValues("SELECT SDT FROM ChuNha Where TenDangNhap = '" + tenDangNhap + "'");

                txt_hoTen.Text = hoTen;
                txt_email.Text = Email;
                txt_Sdt.Text = SDT;
                txt_TenDangNhap.Text = tenDangNhap;
                string dateString = NgaySinh;
                if (DateTime.TryParse(dateString, out DateTime selectedDate))
                {
                    dtp_NgaySinh.Value = selectedDate;
                }
                else
                {

                    MessageBox.Show("Dữ liệu ngày không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception)
            {

                throw;
            }
        }
        private void ThongTinBanThan_Load(object sender, EventArgs e)
        {
            LoadThongTinBanThan();
        }

        private void btn_DoiMatKhau_Click(object sender, EventArgs e)
        {
            DoiMatKhau doiMatKhau = new DoiMatKhau(tenDangNhap);
            doiMatKhau.Show();

        }

        private void btn_thayThongTin_Click(object sender, EventArgs e)
        {
            string hoten = txt_hoTen.Text.Trim();
            string email = txt_email.Text.Trim();
            string sdt = txt_Sdt.Text.Trim();
            string ngaySinh = dtp_NgaySinh.Value.ToString("yyyy-MM-dd");

            try
            {
                string sql = "UPDATE ChuNha SET HoTen = N'" + hoten + "', Email = '" + email + "', SDT = '" + sdt + "', NgaySinh = '" + ngaySinh + "' WHERE TenDangNhap = '" + tenDangNhap + "'";
                BaseFunction.RunSQL(sql);
                MessageBox.Show("Thay đổi thông tin thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadThongTinBanThan();
            }
            catch (Exception)
            {
                MessageBox.Show("Thay đổi thông tin thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
