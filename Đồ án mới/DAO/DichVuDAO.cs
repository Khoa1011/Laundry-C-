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
     class DichVuDAO
    {
        static SqlCommand cmd;
        static SqlDataAdapter adapter;
        static DataTable dt;
        static SqlConnection con = ConnectionTool.GetConnection();
        public DataTable findALL()
        {
            con.Open(); // mở 
            //câu lệnh truy vấn
            string sql = "select * from DICHVU";
            cmd = new SqlCommand(sql, con); //thực hiện câu lệnh kết nối, với "con"
            //Lấy dữ liệu từ database
            adapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            //đổ vào table
            adapter.Fill(dt);
            con.Close();
            return dt;
        }
        public Boolean addDV(DICHVU dv)
        {
            con.Open();
            SqlTransaction transaction = con.BeginTransaction();
            try
            {
                string sql = "INSERT INTO DICHVU (MOTA_DICHVU, TONGTIEN_DICHVU) VALUES (@Name, @Price)";
                using (cmd = new SqlCommand(sql, con, transaction))
                {
                    cmd.Parameters.AddWithValue("@Name", dv.MoTaDichVu);
                    cmd.Parameters.AddWithValue("@Price", dv.TongTienDichVu);
                    cmd.ExecuteNonQuery();
                    transaction.Commit();
                    con.Close();
                    return true; // Thêm thành công
                }
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
        public Boolean deleteDV(int id)
        {
            con.Open();
            SqlTransaction transaction = con.BeginTransaction();
            try
            {
                string sqlDeleteDV = "delete from DICHVU where MA_DICHVU = @ID";
                using (SqlCommand cmd = new SqlCommand(sqlDeleteDV, con, transaction))
                {
                    cmd.Parameters.AddWithValue("@ID", id);
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
        public Boolean updateDV(DICHVU dv, int id)
        {
            con.Open();
            SqlTransaction transaction = con.BeginTransaction();
            try
            {
                string sqlUpdateDV = "update DICHVU set MOTA_DICHVU = @Name, TONGTIEN_DICHVU = @Price where MA_DICHVU = @ID";
                using (SqlCommand cmd = new SqlCommand(sqlUpdateDV, con, transaction))
                {
                    cmd.Parameters.AddWithValue("@ID", id);
                    cmd.Parameters.AddWithValue("@Name", dv.MoTaDichVu);
                    cmd.Parameters.AddWithValue("@Price", dv.TongTienDichVu);
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
        public double getPrice(int id)
        {
            double price = 0.0;
            con.Open(); // mở 
            //câu lệnh truy vấn
            string sql = "SELECT TONGTIEN_DICHVU FROM DICHVU WHERE MA_DICHVU = @ID";
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@ID", id);
            object result = cmd.ExecuteScalar();

            if (result != null && result != DBNull.Value)
            {
                price = Convert.ToDouble(result);
            }
            cmd.ExecuteNonQuery();
            con.Close();
            //Lấy dữ liệu từ database
            return price;
        }
    }
}
