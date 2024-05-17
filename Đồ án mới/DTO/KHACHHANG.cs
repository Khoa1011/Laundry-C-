using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Đồ_án_mới.DTO
{
    internal class KHACHHANG
    {
        private string maKhachHang;
        private string tenKhachHang;
        private string tuoiKhachHang;
        private string gioiTinhKhachHang;
        private string diaChiKhachHang;
        private string sdtKhachHang;

        public KHACHHANG()
        {
        }

        public KHACHHANG(string maKhachHang, string tenKhachHang, string tuoiKhachHang, string gioiTinhKhachHang, string diaChiKhachHang, string sdtKhachHang)
        {
            this.MaKhachHang = maKhachHang;
            this.TenKhachHang = tenKhachHang;
            this.TuoiKhachHang = tuoiKhachHang;
            this.GioiTinhKhachHang = gioiTinhKhachHang;
            this.DiaChiKhachHang = diaChiKhachHang;
            this.SdtKhachHang = sdtKhachHang;
        }

        public string MaKhachHang { get => maKhachHang; set => maKhachHang = value; }
        public string TenKhachHang { get => tenKhachHang; set => tenKhachHang = value; }
        public string TuoiKhachHang { get => tuoiKhachHang; set => tuoiKhachHang = value; }
        public string GioiTinhKhachHang { get => gioiTinhKhachHang; set => gioiTinhKhachHang = value; }
        public string DiaChiKhachHang { get => diaChiKhachHang; set => diaChiKhachHang = value; }
        public string SdtKhachHang { get => sdtKhachHang; set => sdtKhachHang = value; }
    }
}
