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
    public partial class DoiMatKhau : Form
    {
        string _tenDangNhap;
        public DoiMatKhau(string tenDangNhap)
        {
            _tenDangNhap = tenDangNhap;
            InitializeComponent();
        }

        private void btn_XacNhan_Click(object sender, EventArgs e)
        {
            string mkcu = txt_mkCu.Text.Trim();
            string mkmoi = txt_MatKhauMoi.Text.Trim();
            string xacnhan = txt_xacNhanMK.Text.Trim();

            if (mkmoi.Equals(xacnhan))
            {
                string sql = "Update ChuNha Set MatKhau = '" + txt_MatKhauMoi +"' WHERE TenDangNhap = '" + _tenDangNhap + "'";
                try
                {
                    BaseFunction.RunSQL(sql);
                    this.Hide();
                }
                catch (Exception)
                {

                    MessageBox.Show("Đổi mật khẩu thất bại");
                }

            }
            else
            {
                MessageBox.Show("Đổi mật khẩu thất bại");
            }
        }
    }
}
