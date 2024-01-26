using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyNhaTro
{//dũng 
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
            txt_MatKhau.UseSystemPasswordChar = true;
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            Error.Clear();
            // kiem tra rong
            bool check = false;
            if (txt_TaiKhoan.Text.Trim() == "")
            {
                //error_Tk.SetError(txt_TaiKhoan, "Không được bỏ trống!");
                //MessageBox.Show("Khong duoc bo trong!", "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //return;
            }
            if (txt_MatKhau.Text.Trim() == "")
            {
                //error_Pass.SetError(txt_TaiKhoan, "Không được bỏ trống!");
                //MessageBox.Show("Khong duoc bo trong!", "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //return;
            }

            string query = "SELECT TenDangNhap,MatKhau FROM ChuNha";
            SqlCommand cmd = new SqlCommand(query, BaseFunction.sqlCon);
            SqlDataReader reader = cmd.ExecuteReader();
            bool checkDangNhap = false;
            while (reader.Read())
            {
                if (txt_TaiKhoan.Text.Trim() == reader.GetString(0).Trim() && txt_MatKhau.Text.Trim()
                    == reader.GetString(1).Trim())
                {
                    checkDangNhap = true;
                }
            }
            /* if (!checkDangNhap)
             {
                 MessageBox.Show("Tài Khoản hoặc mật khẩu không đúng!");
                 txt_MatKhau.Text = "";
                 reader.Close();
                 return;
             }*/
            reader.Close();
            this.Hide();
            Home home = new Home(txt_TaiKhoan.Text.Trim());

            //load.Hide();
            home.Show();
        }

        private void LoginScreen_Load(object sender, EventArgs e)
        {
            BaseFunction.MoKetNoi();
        }

        private void btn_QuenMatKhau_Click(object sender, EventArgs e)
        {
            QuenMatKhau quenMatKhau = new QuenMatKhau();
            quenMatKhau.Show();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn muốn thoát à?", "Đồng ý"
                , MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (rs == DialogResult.OK)
            {
                Close();
            }
        }

        private void ckHienThiMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (!ckHienThiMatKhau.Checked)
            {
                txt_MatKhau.UseSystemPasswordChar = true;
            }
            if (ckHienThiMatKhau.Checked)
            {
                txt_MatKhau.UseSystemPasswordChar = false;

            }
        }
    }
}
