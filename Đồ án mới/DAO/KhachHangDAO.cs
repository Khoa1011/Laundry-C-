﻿using System;
using Đồ_án_mới.DTO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Data;

namespace Đồ_án_mới.DAO
{
    class KhachHangDAO : interfaceDAO<KHACHHANG>
    {
        static SqlCommand cmd;
        static SqlDataAdapter adapter;
        static DataTable dt;
        static SqlConnection con = ConnectionTool.GetConnection();


        public List<KHACHHANG> getListCus()
        {
            con.Open();
            List<KHACHHANG> list = new List<KHACHHANG>();
            String sql = "select MA_KHACHHANG from KHACHHANG";
            cmd = new SqlCommand(sql, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                KHACHHANG tempCus = new KHACHHANG(id);
                list.Add(tempCus);
            }
            con.Close();
            return list;
        }

        public int getCountCus()
        {
            int count = 0;
            List<KHACHHANG> list = getListCus();
            foreach (KHACHHANG tempCus in list)
                count++;
            return count;
        }

        public DataTable findALL()
        {
            con.Open(); // mở 
            //câu lệnh truy vấn
            string sql = "select * from KHACHHANG";
            cmd = new SqlCommand(sql, con); //thực hiện câu lệnh kết nối, với "con"
            //Lấy dữ liệu từ database
            adapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            //đổ vào table
            adapter.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable findBySDT(string phone)
        {
            con.Open(); // mở 
            string sql = "select * from KHACHHANG where SODT_KHACHHANG =@SDT";
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@SDT", phone);
            adapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            adapter.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable findByName(string name)
        {
            con.Open(); // mở 
            string sql = "select * from KHACHHANG WHERE TEN_KHACHHANG like '%' + @Name ";
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@Name", name);
            adapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            adapter.Fill(dt);
            con.Close();
            return dt;
        }
        public bool add(KHACHHANG kh)
        {
            using (SqlConnection con = ConnectionTool.GetConnection())
            {
                con.Open();
                SqlTransaction transaction = con.BeginTransaction();

                try
                {
                    string sql = "INSERT INTO KHACHHANG (TEN_KHACHHANG, TUOI_KHACHHANG, GIOITINH_KHACHHANG, DIACHI_KHACHHANG, SODT_KHACHHANG) " +
                                 "VALUES (@Name, @Age, @Gender, @Address, @Phone); SELECT SCOPE_IDENTITY();";

                    using (SqlCommand cmd = new SqlCommand(sql, con, transaction))
                    {
                        cmd.Parameters.AddWithValue("@Name", kh.Ten);
                        cmd.Parameters.AddWithValue("@Age", kh.Tuoi);
                        cmd.Parameters.AddWithValue("@Gender", kh.GioiTinh);
                        cmd.Parameters.AddWithValue("@Address", kh.DiaChi);
                        cmd.Parameters.AddWithValue("@Phone", kh.SoDienThoai);

                        // Thực thi câu lệnh INSERT và lấy mã khách hàng tự động tăng
                        int maKhachHang = Convert.ToInt32(cmd.ExecuteScalar());

                        // Gán mã khách hàng vừa thêm vào đối tượng KHACHHANG
                        kh.MaKhachHang = maKhachHang;

                        transaction.Commit();
                        con.Close();
                        return true; // Thêm thành công
                    }
                }
                catch (Exception ex)
                {
                    transaction.Rollback(); // Rollback transaction nếu có lỗi
                    Console.WriteLine("Lỗi: " + ex.Message);
                    con.Close();
                    return false; // Thêm không thành công
                }
            }
        }

        public bool update(KHACHHANG kh, int id)
        {
            con.Open();
            SqlTransaction transaction = con.BeginTransaction();
            try
            {
                string sqlUpdateKH = "update KHACHHANG set TEN_KHACHHANG = @Name, TUOI_KHACHHANG = @Age , GIOITINH_KHACHHANG = @Gender, DIACHI_KHACHHANG = @Address, SODT_KHACHHANG= @Phone where MA_KHACHHANG= @ID";
                using (SqlCommand cmd = new SqlCommand(sqlUpdateKH, con, transaction))
                {
                    cmd.Parameters.AddWithValue("@ID", id);
                    cmd.Parameters.AddWithValue("@Name", kh.Ten);
                    cmd.Parameters.AddWithValue("@Age", kh.Tuoi);
                    cmd.Parameters.AddWithValue("@Gender", kh.GioiTinh);
                    cmd.Parameters.AddWithValue("@Address", kh.DiaChi);
                    cmd.Parameters.AddWithValue("@Phone", kh.SoDienThoai);
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

        public bool delete(int id)
        {

            {
                con.Open();
                SqlTransaction transaction = con.BeginTransaction();
                try
                {
                    string sqlDeleteKH = "delete from KHACHHANG where MA_KHACHHANG = @ID";
                    using (SqlCommand cmd = new SqlCommand(sqlDeleteKH, con, transaction))
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
        }

        //public bool addKH(KHACHHANG kh)
        //{
        //    using (SqlConnection con = ConnectionTool.GetConnection())
        //    {
        //        con.Open();
        //        SqlTransaction transaction = con.BeginTransaction();

        //        try
        //        {
        //            string sql = "INSERT INTO KHACHHANG (TEN_KHACHHANG, TUOI_KHACHHANG, GIOITINH_KHACHHANG, DIACHI_KHACHHANG, SODT_KHACHHANG) " +
        //                         "VALUES (@Name, @Age, @Gender, @Address, @Phone); SELECT SCOPE_IDENTITY();";

        //            using (SqlCommand cmd = new SqlCommand(sql, con, transaction))
        //            {
        //                cmd.Parameters.AddWithValue("@Name", kh.TenKhachHang);
        //                cmd.Parameters.AddWithValue("@Age", kh.TuoiKhachHang);
        //                cmd.Parameters.AddWithValue("@Gender", kh.GioiTinhKhachHang);
        //                cmd.Parameters.AddWithValue("@Address", kh.DiaChiKhachHang);
        //                cmd.Parameters.AddWithValue("@Phone", kh.SdtKhachHang);

        //                // Thực thi câu lệnh INSERT và lấy mã khách hàng tự động tăng
        //                int maKhachHang = Convert.ToInt32(cmd.ExecuteScalar());

        //                // Gán mã khách hàng vừa thêm vào đối tượng KHACHHANG
        //                kh.MaKhachHang = maKhachHang;

        //                transaction.Commit();
        //                con.Close();
        //                return true; // Thêm thành công
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            transaction.Rollback(); // Rollback transaction nếu có lỗi
        //            Console.WriteLine("Lỗi: " + ex.Message);
        //            con.Close();
        //            return false; // Thêm không thành công
        //        }
        //    }
        //}
        //public bool deleteKH(int id)
        //{
        //    con.Open();
        //    SqlTransaction transaction = con.BeginTransaction();
        //    try
        //    {
        //        string sqlDeleteKH = "delete from KHACHHANG where MA_KHACHHANG = @ID";
        //        using (SqlCommand cmd = new SqlCommand(sqlDeleteKH, con, transaction))
        //        {
        //            cmd.Parameters.AddWithValue("@ID", id);
        //            cmd.ExecuteNonQuery();
        //            transaction.Commit();
        //            con.Close();
        //            return true;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        // Rollback transaction nếu có lỗi
        //        transaction.Rollback();
        //        Console.WriteLine("Lỗi: " + ex.Message);
        //        Console.WriteLine("Lỗi: " + ex.Message);
        //        con.Close();
        //        return false;
        //    }
        //}
        //public bool updateKH(KHACHHANG kh, int id)
        //{
        //    con.Open();
        //    SqlTransaction transaction = con.BeginTransaction();
        //    try
        //    {
        //        string sqlUpdateKH = "update KHACHHANG set TEN_KHACHHANG = @Name, TUOI_KHACHHANG = @Age , GIOITINH_KHACHHANG = @Gender, DIACHI_KHACHHANG = @Address, SODT_KHACHHANG= @Phone where MA_KHACHHANG= @ID";
        //        using (SqlCommand cmd = new SqlCommand(sqlUpdateKH, con, transaction))
        //        {
        //            cmd.Parameters.AddWithValue("@ID", id);
        //            cmd.Parameters.AddWithValue("@Name", kh.TenKhachHang);
        //            cmd.Parameters.AddWithValue("@Age", kh.TuoiKhachHang);
        //            cmd.Parameters.AddWithValue("@Gender", kh.GioiTinhKhachHang);
        //            cmd.Parameters.AddWithValue("@Address", kh.DiaChiKhachHang);
        //            cmd.Parameters.AddWithValue("@Phone", kh.SdtKhachHang);
        //            cmd.ExecuteNonQuery();
        //            transaction.Commit();
        //            con.Close();
        //            return true;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        // Rollback transaction nếu có lỗi
        //        transaction.Rollback();
        //        Console.WriteLine("Lỗi: " + ex.Message);
        //        Console.WriteLine("Lỗi: " + ex.Message);
        //        con.Close();
        //        return false;
        //    }
        //}
    }
}
