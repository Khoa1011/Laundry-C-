using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Đồ_án_mới.DTO
{
    internal class NHANVIEN : PERSON
    {
        private int maNhanVien;
        private TAIKHOAN taiKhoan;

        public NHANVIEN(int ma)
        {
            this.maNhanVien = ma;
        }
        public NHANVIEN()
        {
        }

        public NHANVIEN(string ten, string gioiTinh, int tuoi, string diaChi, string soDienThoai, TAIKHOAN taiKhoan)
            : base(ten, tuoi, gioiTinh, diaChi, soDienThoai)
        {
            this.taiKhoan = taiKhoan;
        }

        public TAIKHOAN TaiKhoan { get => taiKhoan; set => taiKhoan = value; }

    }
}
