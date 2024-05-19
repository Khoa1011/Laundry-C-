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
    class NhanVienDAO
    {
        static SqlCommand cmd;
        static SqlDataAdapter adapter;
        static DataTable dt;
        static SqlConnection con = ConnectionTool.GetConnection();
        public DataTable findALL()
        {
            con.Open(); // mở 
            //câu lệnh truy vấn
            string sql = "select ID,Ten,GioiTinh,Tuoi,DiaChi,SoDienThoai,TenTaiKhoan from nhanvien left join taikhoan on ID=IDNhanVien order by id";
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
            string sql = "select ID,Ten,GioiTinh,Tuoi,DiaChi,SoDienThoai,TenTaiKhoan from nhanvien join taikhoan on ID=IDNhanVien where ID =@ID";
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
            string sql = "select ID,Ten,GioiTinh,Tuoi,DiaChi,SoDienThoai,TenTaiKhoan from nhanvien left join taikhoan on ID=IDNhanVien WHERE Ten LIKE '%' + @Name  order by id";
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@Name", name);

            adapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            adapter.Fill(dt);
            con.Close();
            return dt;
        }
        public Boolean AddNV(NHANVIEN nv)
        {
            con.Open();
            SqlTransaction transaction = con.BeginTransaction();

            try
            {
                // Tạo câu lệnh INSERT vào bảng nhanvien
                string sqlNhanVien = "INSERT INTO nhanvien (Ten, GioiTinh, Tuoi, DiaChi, SoDienThoai) " +
                                     "VALUES (@Name, @Gender, @Age, @Address, @sdt); " +
                                     "SELECT SCOPE_IDENTITY();";

                using (SqlCommand cmdNhanVien = new SqlCommand(sqlNhanVien, con, transaction))
                {
                    cmdNhanVien.Parameters.AddWithValue("@Name", nv.TenNhanVien);
                    cmdNhanVien.Parameters.AddWithValue("@Gender", nv.GioiTinhNhanVien);
                    cmdNhanVien.Parameters.AddWithValue("@Age", nv.TuoiNhanVien);
                    cmdNhanVien.Parameters.AddWithValue("@Address", nv.DiaChiNhanVien);
                    cmdNhanVien.Parameters.AddWithValue("@sdt", nv.SdtNhanVien);

                    // Lấy ID của nhân viên vừa được chèn vào
                    int nhanVienId = Convert.ToInt32(cmdNhanVien.ExecuteScalar());

                    // Tạo câu lệnh INSERT vào bảng taikhoans
                    string sqlTaiKhoan = "INSERT INTO taikhoan (IDNhanVien, TenTaiKhoan, MatKhau) " +
                                         "VALUES (@IDNhanVien, @TenTaiKhoan, @MatKhau)";

                    using (SqlCommand cmdTaiKhoan = new SqlCommand(sqlTaiKhoan, con, transaction))
                    {
                        cmdTaiKhoan.Parameters.AddWithValue("@IDNhanVien", nhanVienId);
                        cmdTaiKhoan.Parameters.AddWithValue("@TenTaiKhoan", nv.Taikhoan.TenTaiKhoan);
                        cmdTaiKhoan.Parameters.AddWithValue("@MatKhau", nv.Taikhoan.MatKhau);

                        cmdTaiKhoan.ExecuteNonQuery();
                    }
                }

                // Commit transaction
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
        public Boolean Update(int id, NHANVIEN nv)
        {
            con.Open();
            SqlTransaction transaction = con.BeginTransaction();
            try
            {
                String sqlUpdate = "Update nhanvien SET Ten = @Name,GioiTinh = @Gender,Tuoi = @Age,DiaChi = @Address,SoDienThoai = @Phone WHERE ID = @EmployeeID";
                using (SqlCommand cmd = new SqlCommand(@sqlUpdate, con, transaction))
                {
                    cmd.Parameters.AddWithValue("@Name", nv.TenNhanVien);
                    cmd.Parameters.AddWithValue("@Gender", nv.GioiTinhNhanVien);
                    cmd.Parameters.AddWithValue("@Age", nv.TuoiNhanVien);
                    cmd.Parameters.AddWithValue("@Address", nv.DiaChiNhanVien);
                    cmd.Parameters.AddWithValue("@Phone", nv.SdtNhanVien);
                    cmd.Parameters.AddWithValue("@EmployeeID", id);
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
        public Boolean Delete(int id)
        {
            con.Open();
            SqlTransaction transaction = con.BeginTransaction();
            try
            {
                string sqlDeleteTaiKhoan = "DELETE FROM taikhoan WHERE IDNhanVien = @EmployeeID";
                using (SqlCommand cmd = new SqlCommand(sqlDeleteTaiKhoan, con, transaction))
                {
                    cmd.Parameters.AddWithValue("@EmployeeID", id);
                    cmd.ExecuteNonQuery();
                }
                string sqlDeleteNhanVien = "DELETE FROM nhanvien WHERE ID = @EmployeeID";
                using (SqlCommand cmd = new SqlCommand(sqlDeleteNhanVien, con, transaction))
                {
                    cmd.Parameters.AddWithValue("@EmployeeID", id);
                    cmd.ExecuteNonQuery();

                }
                transaction.Commit();
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
