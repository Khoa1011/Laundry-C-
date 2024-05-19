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
    class TaiKhoanDAO
    {
        static SqlCommand cmd;
        static SqlDataAdapter adapter;
        static DataTable dt;
        static SqlConnection con = ConnectionTool.GetConnection();
        public DataTable findALL()
        {
            con.Open(); // mở 
                        //câu lệnh truy vấn
            string sql = "select * from taikhoan order by IDNhanVien";
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
            string sql = "select * from taikhoan where IDNhanVien =@ID";
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@ID", id);
            adapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            adapter.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable findByName(string name)
        {
            con.Open(); // mở 
            string sql = "select * from taikhoan where TenTaiKhoan like @Name";
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@Name", name);
            adapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            adapter.Fill(dt);
            con.Close();
            return dt;
        }
        public Boolean delete(int id)
        {
            con.Open(); // mở 

            SqlTransaction transaction = con.BeginTransaction();
            try
            {
                string sqlDelete = "DELETE FROM taikhoan WHERE IDNhanVien = @EmployeeID";
                using (cmd = new SqlCommand(sqlDelete, con, transaction))
                {
                    cmd.Parameters.AddWithValue("@EmployeeID", id);
                    cmd.ExecuteNonQuery();
                    transaction.Commit();
                }
                con.Close();
                return true;
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
        public Boolean findUser(string user)
        {
            DataTable dt = findByName(user);
            if (dt.Rows.Count >= 1)
                return true;
            return false;
        }
        public Boolean checkOldPassword(string user ,string oldPass)
        {
            DataTable dt = new DataTable();
            con.Open();
            string sql = "select * from taikhoan where TenTaiKhoan = @user and MatKhau = @oldPass";
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@user", user);
            cmd.Parameters.AddWithValue("@oldPass", oldPass);
            adapter = new SqlDataAdapter(cmd);           
            adapter.Fill(dt);
            con.Close();
            if (dt.Rows.Count == 1)
                return true;
            return false;
        }
        public Boolean changePass(string userName, string newPass)
        {
            con.Open(); // mở 
            SqlTransaction transaction = con.BeginTransaction();
            try
            {
                string sqlChangePass = "update taikhoan set MatKhau = @newPass where TenTaiKhoan =@Name";
                using (cmd = new SqlCommand(sqlChangePass, con, transaction))
                {
                    cmd.Parameters.AddWithValue("@newPass",newPass);
                    cmd.Parameters.AddWithValue("@Name", userName);
                    cmd.ExecuteNonQuery();
                    transaction.Commit();
                }
                con.Close();
                return true;
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
