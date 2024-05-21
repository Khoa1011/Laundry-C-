using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Đồ_án_mới.DTO
{
    internal class KHACHHANG : PERSON
    {
        private int maKhachHang;

        public KHACHHANG()
        {
        }

        public KHACHHANG(int maKhachHang, string ten, int tuoi, string gioiTinh, string diaChi, string soDienThoai)
            : base(ten, tuoi, gioiTinh, diaChi, soDienThoai)
        {
            this.maKhachHang = maKhachHang;
        }

        public int MaKhachHang { get => maKhachHang; set => maKhachHang = value; }
    }
}
