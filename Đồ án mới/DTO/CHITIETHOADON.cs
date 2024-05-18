using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Đồ_án_mới.DTO
{
    internal class CHITIETHOADON
    {
        private DateTime ngayHoaDon;
        private int soLuongDichVu;
        private float tongTienHoaDon;
        private KHACHHANG khachhang;
        private DICHVU dichvu;

        public CHITIETHOADON()
        {
        }

        public CHITIETHOADON(DateTime ngayHoaDon, int soLuongDichVu, float tongTienHoaDon, KHACHHANG khachhang, DICHVU dichvu)
        {
            this.ngayHoaDon = ngayHoaDon;
            this.soLuongDichVu = soLuongDichVu;
            this.tongTienHoaDon = tongTienHoaDon;
            this.khachhang = khachhang;
            this.dichvu = dichvu;
        }

        public DateTime NgayHoaDon { get => ngayHoaDon; set => ngayHoaDon = value; }
        public int SoLuongDichVu { get => soLuongDichVu; set => soLuongDichVu = value; }
        public float TongTienHoaDon { get => tongTienHoaDon; set => tongTienHoaDon = value; }
        internal KHACHHANG Khachhang { get => khachhang; set => khachhang = value; }
        internal DICHVU Dichvu { get => dichvu; set => dichvu = value; }
    }
}
