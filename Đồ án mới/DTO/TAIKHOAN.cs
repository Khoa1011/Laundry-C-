using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Đồ_án_mới.DTO
{
    internal class TAIKHOAN
    {
        private string tenTaiKhoan;
       // private NHANVIEN nhanvien; 
        private string matKhau;

        public TAIKHOAN()
        {
        }

        public TAIKHOAN(string tenTaiKhoan/*, NHANVIEN nhanvien*/, string matKhau)
        {
            this.tenTaiKhoan = tenTaiKhoan;
            //this.Nhanvien = nhanvien;
            this.matKhau = matKhau;
        }

        public string TenTaiKhoan { get => tenTaiKhoan; set => tenTaiKhoan = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
        //public NHANVIEN Nhanvien { get => nhanvien; set => nhanvien = value; }
    }
}
