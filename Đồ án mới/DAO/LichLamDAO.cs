using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Đồ_án_mới.DTO;

namespace Đồ_án_mới.DAO
{
    class LichLamDAO
    {
        static SqlCommand cmd;
        static SqlDataAdapter adapter;
        static DataTable dt;
        static SqlConnection con = ConnectionTool.GetConnection();
        public DataTable findAll()
        {
            con.Open(); // mở 
                        //câu lệnh truy vấn
            string sql = "select id,Ten,NgayLam,KhungGio from lichlamviec right join nhanvien on ID = IDNhanVien order by ID ";
            cmd = new SqlCommand(sql, con); //thực hiện câu lệnh kết nối, với "con"
            //Lấy dữ liệu từ database
            adapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            //đổ vào table
            adapter.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable findByID(int id)
        {
            con.Open(); // mở 
            string sql = "select id,Ten,NgayLam,KhungGio from lichlamviec right join nhanvien on ID = IDNhanVien where id=@ID  order by ID ";
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@ID", id);
            adapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            adapter.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable loadComboBoxKhungGio()
        {
            con.Open(); // mở 
            string sql = "select * from chitietkhunggio ";
            cmd = new SqlCommand(sql, con);
            adapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            adapter.Fill(dt);
            con.Close();
            return dt;
        }
        public Boolean addSchedule(LICHLAMVIEC ll, int id)
        {
            con.Open();
            SqlTransaction transaction = con.BeginTransaction();

            try
            {
                string sqlADD = "insert into lichlamviec (NgayLam,IDNhanVien,KhungGio) values (@NgayLam, @ID, @KhungGio)";
                using (SqlCommand cmd = new SqlCommand(sqlADD, con, transaction))
                {
                    cmd.Parameters.AddWithValue("@NgayLam", ll.LichLamViec);
                    cmd.Parameters.AddWithValue("@ID", id);
                    cmd.Parameters.AddWithValue("@KhungGio", ll.KhungGio);
                    cmd.ExecuteNonQuery();
                }
                transaction.Commit();
                con.Close();
                return true; // Thêm thành công      
            }
            catch (Exception ex)
            {
                // Rollback transaction nếu có lỗi
                transaction.Rollback();
                Console.WriteLine("Lỗi: " + ex.Message);
                Console.WriteLine("Lỗi: " + ex.Message);
                con.Close();
                return false; // Thêm không thành công
            }
        }
        public Boolean deleteSchedule(DateTime ngaylam, int id, string time)
        {
            con.Open();
            SqlTransaction transaction = con.BeginTransaction();
            try
            {
                string sqlDelete = "delete lichlamviec where IDNhanVien = @id and NgayLam =@Date and KhungGio=@Time";
                using (cmd = new SqlCommand(sqlDelete, con, transaction))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@Date", ngaylam);
                    cmd.Parameters.AddWithValue("@Time", time);
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
        public Boolean updateSchedule(LICHLAMVIEC ll,int id,DateTime dateCu, string timeCu)
        {
            con.Open();
            SqlTransaction transaction = con.BeginTransaction();
            try
            {
                string sqlDelete = "update lichlamviec set NgayLam = @Date, KhungGio = @Time where IDNhanVien = @ID and NgayLam = @DateCu and KhungGio= @TimeCu";
                using (cmd = new SqlCommand(sqlDelete, con, transaction))
                {
                    cmd.Parameters.AddWithValue("@Date",ll.LichLamViec );
                    cmd.Parameters.AddWithValue("@Time", ll.KhungGio );
                    cmd.Parameters.AddWithValue("@ID", id );
                    cmd.Parameters.AddWithValue("@DateCu", dateCu);
                    cmd.Parameters.AddWithValue("@TimeCu", timeCu);
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
    }
}
