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
     class XuatHDDAO
    {
        static SqlCommand cmd;
        static SqlDataAdapter adapter;
        static DataTable dt;
        static SqlConnection con = ConnectionTool.GetConnection();
        public DataTable findObj(int id)
        {
            con.Open(); // mở 
            //câu lệnh truy vấn
            string sql = "SELECT dv.MOTA_DICHVU,SUM(hd.SOLUONG_DICHVU) AS TONG_SOLUONG_DICHVU,SUM(hd.TONGTIEN_HOADON) AS TONG_TONGTIEN_HOADON FROM CHITIETHOADON hd JOIN KHACHHANG kh ON hd.MA_KHACHHANG = kh.MA_KHACHHANG JOIN DICHVU dv ON hd.MA_DICHVU = dv.MA_DICHVU WHERE KH.MA_KHACHHANG = @IdKH GROUP BY dv.MOTA_DICHVU";
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@IdKH", id);
            adapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            adapter.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable getIf(int id, DateTime date)
        {
            string sql = "select hd.NGAY_HOADON,kh.TEN_KHACHHANG, KH.MA_KHACHHANG, kh.TUOI_KHACHHANG, kh.DIACHI_KHACHHANG, kh.SODT_KHACHHANG,SUM(hd.TONGTIEN_HOADON) AS TONG_TONGTIEN_HOADON from CHITIETHOADON hd join KHACHHANG kh on hd.MA_KHACHHANG = kh.MA_KHACHHANG join DICHVU dv on hd.MA_DICHVU = dv.MA_DICHVU where KH.MA_KHACHHANG = @ID and NGAY_HOADON = @Date GROUP BY hd.NGAY_HOADON,kh.TEN_KHACHHANG,kh.MA_KHACHHANG,kh.TUOI_KHACHHANG,kh.DIACHI_KHACHHANG,kh.SODT_KHACHHANG ";
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@ID", id);
            cmd.Parameters.AddWithValue("@Date", date);
            adapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            adapter.Fill(dt);
            con.Close();
            return dt;
        }
    }
}
