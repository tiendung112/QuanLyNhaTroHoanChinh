using System;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace QuanLyNhaTro
{
    public class BaseFunction
    {


        public static SqlConnection sqlCon;  //Khai báo đối tượng kết nối        
        public static void MoKetNoi()
        {
            sqlCon = new SqlConnection();   //Khởi tạo đối tượng
                                            //Gắn chuỗi kết nối
            sqlCon.ConnectionString = @"Data Source=DUNGARTORIA;Initial Catalog=QuanLyNhaTro;Integrated Security=True;Encrypt=False";
            //Mở chuỗi kết nối
            sqlCon.Open();
            //Kiểm tra kết nối
            if (sqlCon.State == ConnectionState.Open)
            {
                MessageBox.Show("Đã kết nối với dữ liệu");
            }
            else MessageBox.Show("Không thể kết nối với dữ liệu");
        }
        public static void DongKetNoi()
        {
            if (sqlCon.State == ConnectionState.Open)
            {
                sqlCon.Close();     //Đóng kết nối
                sqlCon.Dispose();   //Giải phóng tài nguyên
                sqlCon = null;      // Ngắt chuỗi kết nối
            }
        }
        //Lấy dữ liệu vào bảng  
        public static DataTable GetDataToTable(string sql)
        {
            SqlDataAdapter dap = new SqlDataAdapter(sql, sqlCon); //Định nghĩa đối tượng thuộc lớp SqlDataAdapter
                                                                  //Khai báo đối tượng table thuộc lớp DataTable
            DataTable table = new DataTable();
            dap.Fill(table); //Đổ kết quả từ câu lệnh sql vào table
            return table;
        }


        //Hàm thực hiện câu lệnh SQL
        public static void RunSQL(string sql)
        {
            SqlCommand cmd; //Đối tượng thuộc lớp SqlCommand
            cmd = new SqlCommand(); //Khởi tạo đối tượng
            cmd.Connection = sqlCon; //Gán kết nối
            cmd.CommandText = sql; //Gán lệnh SQL
            try
            {
                int kq = cmd.ExecuteNonQuery(); //Thực hiện câu lệnh SQL
                if (kq > 0) //Vì executeNonQuery trả về kiểu int, cho biết số dòng được áp dụng.
                {
                    //MessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            //Bắt lỗi
            catch (Exception ex)
            {
                //MessageBox.Show("Không thành công", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //MessageBox.Show(ex.ToString());
            }
            cmd.Dispose();//Giải phóng bộ nhớ
                          //cmd = null;
        }

        //Hàm thực thi câu lệnh Xóa của SQL
        public static void RunSqlDel(string sql)
        {
            //Khởi tạo đối tượng
            SqlCommand cmd = new SqlCommand();
            //Nối chuỗi kết nối
            cmd.Connection = sqlCon;
            cmd.CommandText = sql;
            try
            {
                cmd.ExecuteNonQuery();
                //MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Dữ liệu đang được dùng, không thể xoá...", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            cmd.Dispose();
            cmd = null;
        }

        

        //Hàm fill combobox (với dữ liệu lấy từ SQL)
        public static void FillCombo(string sql, ComboBox cbo, string ma, string ten)
        {
            //Khởi tạo đối tượng
            SqlDataAdapter dap = new SqlDataAdapter(sql, sqlCon);
            DataTable table = new DataTable();
            dap.Fill(table);
            cbo.DataSource = table;
            cbo.ValueMember = ma; //Trường giá trị
            cbo.DisplayMember = ten; //Trường hiển thị
        }

        //Get fieldValue
        public static string GetFieldValues(string sql)
        {
            string ma = "";
            SqlCommand cmd = new SqlCommand(sql, sqlCon);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            while (reader.Read())
                ma = reader.GetValue(0).ToString();
            reader.Close();
            return ma;
        }
        public static int GetCount(string sql)
        {
            int count = 0;
            SqlCommand cmd = new SqlCommand(sql, sqlCon);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            if (reader.Read())
                count = Convert.ToInt32(reader.GetValue(0));
            reader.Close();
            return count;
        }
        //Hàm kiểm tra khoá trùng
        public static bool CheckKey(string sql)
        {
            SqlDataAdapter dap = new SqlDataAdapter(sql, sqlCon);
            DataTable table = new DataTable();
            dap.Fill(table);
            if (table.Rows.Count > 0)
                return true;
            else return false;
        }
        //hàm send mail 
        public static string SendEmail(EmailTo emailTo)
        {
            if (!Validate_Mail.IsValidEmail(emailTo.Mail))
            {
                return "Định dạng email không hợp lệ";
            }
            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential("dung0112.dev.test@gmail.com", "xssyibnbzpqhmzsz"),
                EnableSsl = true
            };
            try
            {
                var message = new MailMessage();
                message.From = new MailAddress("dung0112.dev.test@gmail.com");
                message.To.Add(emailTo.Mail);
                message.Subject = emailTo.Subject;
                message.Body = emailTo.Content;
                message.IsBodyHtml = true;
                smtpClient.Send(message);

                return "Gửi email thành công";
            }
            catch (Exception ex)
            {
                return "Lỗi khi gửi email: " + ex.Message;
            }
        }
        //hàm random int
        public static int RandomInt()
        {
            Random random = new Random();
            return random.Next(100000, 999999);
        }
    }
}
