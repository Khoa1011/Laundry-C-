using Đồ_án_mới.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Đồ_án_mới.Until
{
    class ConnectionToolKit
    {
        private const string url= @"Data Source=DESKTOP-FJ21MLU\TESTDB;Initial Catalog=QuanLyGiatSay;Integrated Security=True";
        SqlConnection con = null;

        public List<nhanvien> getList()
        {
            List<nhanvien> list = new List<nhanvien>();

            try
            {
                using (SqlConnection connection = new SqlConnection(url))
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM nhanvien", connection))
                    {
                        using (SqlDataReader rd = cmd.ExecuteReader())
                        {
                            while (rd.Read())
                            {
                                int Manv = rd.GetInt32(0);
                                string Tennv = rd.GetString(1);
                                int tuoi = rd.GetInt32(2);
                                bool gioitinh = rd.GetBoolean(3);
                                string Diachi = rd.GetString(4);
                                string Sdt = rd.GetString(5);
                                nhanvien nv = new nhanvien(Manv, Tennv, tuoi, gioitinh, Diachi, Sdt);
                                list.Add(nv);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi lấy danh sách nhân viên! Lỗi: " + ex.Message);
            }

            return list;
        }

        public SqlConnection getConnection()
        {

            if (con == null)
            {
                con = new SqlConnection(url);
            }

            if (con.State == ConnectionState.Closed)
            {
                try
                {
                    con.Open();
                    Console.WriteLine("Kết nối thành công!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Không kết nối được đến SQL Server! Lỗi: " + ex.Message);
                    throw;
                }
            }

            return con;
        }



    }
}

