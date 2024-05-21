using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Đồ_án_mới.DTO
{
     class PERSON
    {
        protected string ten;
        protected int tuoi;
        protected string gioiTinh;
        protected string diaChi;
        protected string soDienThoai;

        public PERSON()
        {
        }

        public PERSON(string ten, int tuoi, string gioiTinh, string diaChi, string soDienThoai)
        {
            this.ten = ten;
            this.tuoi = tuoi;
            this.gioiTinh = gioiTinh;
            this.diaChi = diaChi;
            this.soDienThoai = soDienThoai;
        }

        public string Ten { get => ten; set => ten = value; }
        public int Tuoi { get => tuoi; set => tuoi = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string SoDienThoai { get => soDienThoai; set => soDienThoai = value; }
    }
}
