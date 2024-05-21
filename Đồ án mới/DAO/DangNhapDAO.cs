using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Đồ_án_mới.DTO;

namespace Đồ_án_mới.DAO
{
    class DangNhapDAO
    {
        static SqlCommand cmd;
        static SqlDataAdapter adapter;
        static DataTable dt;
        static SqlConnection con = ConnectionTool.GetConnection();
        private List<TAIKHOAN> listAcnt = new List<TAIKHOAN>();

        public DangNhapDAO()
        {
            listAcnt = getListAccount();
        }
        public List<TAIKHOAN> getListAccount()
        {
            List<TAIKHOAN> tempListAcnt = new List<TAIKHOAN>();
            con.Open();
            String sql = "select TenTaiKhoan,MatKhau from taikhoan";
            cmd = new SqlCommand(sql, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read()) 
            {
                String user = reader.GetString(0);
                String password = reader.GetString(1);
                TAIKHOAN tk = new TAIKHOAN(user, password);
                tempListAcnt.Add(tk);
            }
            con.Close();
            return tempListAcnt;
        }

        public bool checkLogin (String user, String password)
        {
            List<TAIKHOAN> tempListAcnt = getListAccount();
            foreach(TAIKHOAN item in tempListAcnt)
            {
                String tempUser = item.TenTaiKhoan;
                String tempPass = item.MatKhau;
                if(tempUser ==user && tempPass == password)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
