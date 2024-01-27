using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Mail;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaTro.Mail
{
    public class SendHoaDon
    {
        public static void SendEmailsForAllBills(int Thang, int Nam)
        {
            string connectionString = "Data Source=DUNGARTORIA;Initial Catalog=QuanLyNhaTro;Integrated Security=True;Encrypt=False"; // Thay thế với chuỗi kết nối của bạn

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                // Lấy tất cả các hóa đơn chưa bị đánh dấu là đã xóa
                string sql = "SELECT * FROM HoaDon WHERE DaXoa = 1 And ThangLap = "+Thang+ "and NamLap = "+Nam;
                SqlCommand command = new SqlCommand(sql, connection);
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    

                    while (reader.Read())
                    {
                        // Tạo nội dung email cho mỗi hóa đơn
                        string emailContent = GenerateNotificationBillEmail(reader["HoaDonID"].ToString());
                        string soHopDong = BaseFunction.GetFieldValues("Select SoHopDong from HoaDon where HoaDonID = " + reader["HoaDonID"].ToString());
                        string KhachThueID = BaseFunction.GetFieldValues("select KhachThueID from HopDong where TrangThaiThue =1 and  SoHopDong = " + soHopDong);
                        string mail = BaseFunction.GetFieldValues("select top 1 Email from ChiTietKhachThue where KhachThueID =" + KhachThueID);
                        EmailTo emailTo = new EmailTo() 
                        {
                            Mail = mail, 
                            Content =emailContent,
                            Subject = "Thông tin hóa đơn" 
                        };

                        BaseFunction.SendEmail(emailTo);
                    }
                }
            }
        }
        public static string GenerateNotificationBillEmail(string maHoaDon, string message = "")
        {
            string connectionString = "Data Source=DUNGARTORIA;Initial Catalog=QuanLyNhaTro;Integrated Security=True;Encrypt=False"; // Thay thế với chuỗi kết nối của bạn
            StringBuilder htmlContent = new StringBuilder();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = "SELECT * FROM HoaDon WHERE HoaDonID = @MaHoaDon AND DaXoa = 1";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@MaHoaDon", maHoaDon);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                // Kiểm tra xem có bản ghi nào không
                if (!reader.HasRows)
                {
                    return "Không tìm thấy hóa đơn với mã: " + maHoaDon;
                }

                while (reader.Read())
                {
                    // Tạo phần đầu hóa đơn
                    htmlContent.AppendLine("<html><body>");
                    htmlContent.AppendLine("<h2 style='background-color: yellow; text-align: center;'>PHIẾU THÔNG BÁO THU TIỀN PHÒNG</h2>");
                    htmlContent.AppendFormat("<h3>Phòng: {0}</h3>", reader["SoPhong"].ToString());
                    htmlContent.AppendFormat("<h3>TOÀ: {0}</h3>", "127 CV2"); // Thay đổi giá trị cố định bằng giá trị động nếu cần
                    htmlContent.AppendFormat("<h3>Tháng: {0}</h3>" ,reader["ThangLap"].ToString()); // Thay đổi giá trị cố định bằng giá trị động nếu cần

                    // Tạo bảng chi tiết hóa đơn
                    htmlContent.AppendLine("<table border='1' style='width:100%; border-collapse: collapse;'>");
                    htmlContent.AppendLine("<tr style='background-color: #f2f2f2;'>");
                    htmlContent.AppendLine("<th>Dịch vụ</th><th>Số mới</th><th>Số cũ</th><th>Số lượng</th><th>Đơn giá</th><th>Thành tiền</th>");
                    htmlContent.AppendLine("</tr>");

                    // Sử dụng các giá trị từ cơ sở dữ liệu để thêm các hàng vào bảng
                    // Ví dụ: dịch vụ điện
                    int soDienCu = Convert.ToInt32(reader["SoDienCu"]);
                    int soDienMoi = Convert.ToInt32(reader["SoDienMoi"]);
                    int soLuongDien = soDienMoi - soDienCu;
                    int donGiaDien = Convert.ToInt32(reader["GiaDien"]);
                    int thanhTienDien = soLuongDien * donGiaDien;
                    int gianuoc =Convert.ToInt32(reader["GiaNuoc"].ToString());
                    int soNuoc = Convert.ToInt32(reader["SoNuoc"].ToString());
                    int tongnuoc = gianuoc* soNuoc;
                    int GiaKhac = Convert.ToInt32(reader["GiaDichVuKhac"].ToString());    

                    htmlContent.AppendFormat("<tr><td>Điện</td><td>{0}</td><td>{1}</td><td>{2}</td><td>{3}</td><td>{4}</td></tr>",
                        soDienMoi, soDienCu, soLuongDien, donGiaDien, thanhTienDien);
                    htmlContent.AppendFormat("<tr><td>Nước<td></td><td></td><td>{0}</td><td>{1}</td><td>{2}</td></tr>",
                        soNuoc, gianuoc,tongnuoc);
                    htmlContent.AppendFormat("<tr><td>Dịch vụ khác<td></td><td></td><td></td><td>{0}</td><td>{1}</td></tr>",
                                                GiaKhac,GiaKhac);
                    // Tổng cộng
                    htmlContent.AppendFormat("<tr><td colspan='5' style='text-align: right;'>Tổng tiền</td><td>{0}</td></tr>",
                        reader["TongTien"].ToString());

                    // Đóng bảng
                    htmlContent.AppendLine("</table>");

                    // Thông tin khác như chân trang hóa đơn
                    htmlContent.AppendLine("<p>Nếu chuyển khoản vui lòng ghi rõ nội dung chuyển tiền: số phòng + tên tòa nhà</p>");
                    htmlContent.AppendLine("<p>* Mọi thắc mắc vui lòng gọi: 0976797227</p>");
                    // Đóng HTML
                    htmlContent.AppendLine("</body></html>");
                }

                reader.Close();
            }

            return htmlContent.ToString();
        }
    }
}
