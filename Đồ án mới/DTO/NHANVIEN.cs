using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Đồ_án_mới.DTO
{
    internal class NHANVIEN
    {
        private string maNhanVien;
        private string tenNhanVien;
        private string tuoiNhanVien;
        private string diaChiNhanVien;
        private string sdtNhanVien;
        private TAIKHOAN taikhoan;    
       // private List<LICHLAMVIEC> lichlamviec;
        public NHANVIEN()
        {
        }

        public NHANVIEN(string maNhanVien, string tenNhanVien, string tuoiNhanVien, string diaChiNhanVien, string sdtNhanVien, TAIKHOAN taikhoan)
        {
            this.MaNhanVien = maNhanVien;
            this.TenNhanVien = tenNhanVien;
            this.TuoiNhanVien = tuoiNhanVien;
            this.DiaChiNhanVien = diaChiNhanVien;
            this.SdtNhanVien = sdtNhanVien;
            this.Taikhoan = taikhoan;
        }

        public string MaNhanVien { get => maNhanVien; set => maNhanVien = value; }
        public string TenNhanVien { get => tenNhanVien; set => tenNhanVien = value; }
        public string TuoiNhanVien { get => tuoiNhanVien; set => tuoiNhanVien = value; }
        public string DiaChiNhanVien { get => diaChiNhanVien; set => diaChiNhanVien = value; }
        public string SdtNhanVien { get => sdtNhanVien; set => sdtNhanVien = value; }
        public TAIKHOAN Taikhoan { get => taikhoan; set => taikhoan = value; }
        //public List<LICHLAMVIEC> Lichlamviec { get => lichlamviec; set => lichlamviec = value; }
    }
}
