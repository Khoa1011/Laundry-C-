using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Đồ_án_mới.Data
{
    class nhanvien
    {
        private int manv;
        private string tennv;
        private int tuoi;
        private bool gioitinh;
        private String diachi;
        private String sdt;

        public nhanvien(int manv, string tennv,int tuoi, bool gioitinh, string diachi, string sdt)
        {
            this.manv = manv;
            this.tennv = tennv;
            this.tuoi = tuoi;
            this.gioitinh = gioitinh;
            this.diachi = diachi;
            this.sdt = sdt;
        }

        public int Manv { get => manv; set => manv = value; }
        public string Tennv { get => tennv; set => tennv = value; }
        public bool Gioitinh { get => gioitinh; set => gioitinh = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public int Tuoi { get => tuoi; set => tuoi = value; }

        public String toString()
        {
            return $"Mã NV: {Manv}, Tên NV: {Tennv},Tuổi NV {tuoi}, Giới tính: {Gioitinh}, Địa chỉ: {Diachi}, SĐT: {Sdt}";
        }

    }
}
