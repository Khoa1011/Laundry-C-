using System;
using Đồ_án_mới.DTO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Data;

namespace Đồ_án_mới.DAO
{
    class ChiTietHoaDonDAO
    {
        static SqlCommand cmd;
        static SqlDataAdapter adapter;
        static DataTable dt;
        static SqlConnection con = ConnectionTool.GetConnection();
        public DataTable findALL()
        {
            con.Open(); // mở 
            //câu lệnh truy vấn
            string sql = "select NGAY_HOADON, hd.MA_KHACHHANG, kh.TEN_KHACHHANG, dv.MOTA_DICHVU, hd.SOLUONG_DICHVU,hd.TONGTIEN_HOADON from CHITIETHOADON hd right join KHACHHANG kh on hd.MA_KHACHHANG = kh.MA_KHACHHANG  join DICHVU dv on hd.MA_DICHVU = dv.MA_DICHVU";
            cmd = new SqlCommand(sql, con); //thực hiện câu lệnh kết nối, với "con"
            //Lấy dữ liệu từ database
            adapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            //đổ vào table
            adapter.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable loadComboBoxDichVu()
        {
            con.Open(); // mở 
            string sql = "select * from DICHVU";
            cmd = new SqlCommand(sql, con);
            adapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            adapter.Fill(dt);
            con.Close();
            return dt;
        }
        public Boolean addHD(CHITIETHOADON hd, KHACHHANG kh, int id)
        {

            using (SqlConnection con = ConnectionTool.GetConnection())
            {
                con.Open();
                KhachHangDAO khDAO = new KhachHangDAO();

                if (khDAO.add(kh))
                {
                    SqlTransaction transaction = con.BeginTransaction();

                    try
                    {
                        string sqlADD = "INSERT INTO CHITIETHOADON (MA_KHACHHANG, MA_DICHVU, NGAY_HOADON, SOLUONG_DICHVU, TONGTIEN_HOADON) " +
                                        "VALUES (@IDKH, @IDDV, @Date, @Count, @ToTalPrice)";

                        using (SqlCommand cmd = new SqlCommand(sqlADD, con, transaction))
                        {
                            cmd.Parameters.AddWithValue("@IDKH", kh.MaKhachHang);
                            cmd.Parameters.AddWithValue("@IDDV", id);
                            cmd.Parameters.AddWithValue("@Date", hd.NgayHoaDon);
                            cmd.Parameters.AddWithValue("@Count", hd.SoLuongDichVu);
                            cmd.Parameters.AddWithValue("@ToTalPrice", hd.TongTienHoaDon);

                            cmd.ExecuteNonQuery();
                        }

                        transaction.Commit();
                        con.Close();
                        return true; // Thêm thành công
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback(); // Rollback transaction nếu có lỗi
                        Console.WriteLine("Lỗi: " + ex.Message);
                        con.Close();
                        return false; // Thêm không thành công
                    }
                }
                else
                {
                    con.Close();
                    return false; // Thêm không thành công vì không thêm được khách hàng
                }
            }
        }
        public Boolean deleteHD(int idKH, int idDV, DateTime date)
        {
            con.Open();
            SqlTransaction transaction = con.BeginTransaction();
            try
            {
                string sqlDeleteKH = "delete from CHITIETHOADON where MA_KHACHHANG = @IdKH and MA_DICHVU =@IdDV and NGAY_HOADON = @Date ";
                using (SqlCommand cmd = new SqlCommand(sqlDeleteKH, con, transaction))
                {
                    cmd.Parameters.AddWithValue("@IdKH", idKH);
                    cmd.Parameters.AddWithValue("@IdDV", idDV);
                    cmd.Parameters.AddWithValue("@Date", date);
                    cmd.ExecuteNonQuery();
                    transaction.Commit();
                    con.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {
                // Rollback transaction nếu có lỗi
                transaction.Rollback();
                Console.WriteLine("Lỗi: " + ex.Message);
                Console.WriteLine("Lỗi: " + ex.Message);
                con.Close();
                return false;
            }
        }
        public int getIdDV(string name)
        {
            int id = 0;
            con.Open(); // mở 
            //câu lệnh truy vấn
            string sql = "select MA_DICHVU from DICHVU where MOTA_DICHVU = @Name";
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@Name", name);
            object result = cmd.ExecuteScalar();

            if (result != null && result != DBNull.Value)
            {
                id = Convert.ToInt32(result);
            }
            cmd.ExecuteNonQuery();
            con.Close();
            //Lấy dữ liệu từ database
            return id;
        }
        public DataTable findBySDT(string phone)
        {
            con.Open(); // mở 
            //câu lệnh truy vấn
            string sql = "select NGAY_HOADON, hd.MA_KHACHHANG, kh.TEN_KHACHHANG, dv.MOTA_DICHVU, hd.SOLUONG_DICHVU,hd.TONGTIEN_HOADON from CHITIETHOADON hd right join KHACHHANG kh on hd.MA_KHACHHANG = kh.MA_KHACHHANG right join DICHVU dv on hd.MA_DICHVU = dv.MA_DICHVU where kh.SODT_KHACHHANG = @Phone";
            cmd = new SqlCommand(sql, con); //thực hiện câu lệnh kết nối, với "con"
            cmd.Parameters.AddWithValue("@Phone", phone);
            //Lấy dữ liệu từ database
            adapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            //đổ vào table
            adapter.Fill(dt);
            con.Close();
            return dt;
        }
    }
}