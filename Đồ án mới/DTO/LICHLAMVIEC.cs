using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Đồ_án_mới.DTO
{
    internal class LICHLAMVIEC
    {
        private DateTime lichLamViec;
        private string khungGio;
        //private NHANVIEN nhanvien;

        public LICHLAMVIEC()
        {
        }

        public LICHLAMVIEC(DateTime lichLamViec, string khungGio/*, NHANVIEN nhanvien*/)
        {
            this.lichLamViec = lichLamViec;
            this.khungGio = khungGio;
           // this.Nhanvien = nhanvien;
        }

        public DateTime LichLamViec { get => lichLamViec; set => lichLamViec = value; }
        public string KhungGio { get => khungGio; set => khungGio = value; }
       // public NHANVIEN Nhanvien { get => nhanvien; set => nhanvien = value; }
    }
}
