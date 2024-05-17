using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Đồ_án_mới.DTO
{
    internal class DICHVU
    {
        private int maDichVu;
        private string moTaDichVu;
        private float tongTienDichVu;

        public DICHVU()
        {
        }

        public DICHVU(int maDichVu, string moTaDichVu, float tongTienDichVu)
        {
            this.MaDichVu = maDichVu;
            this.MoTaDichVu = moTaDichVu;
            this.TongTienDichVu = tongTienDichVu;
        }

        public int MaDichVu { get => maDichVu; set => maDichVu = value; }
        public string MoTaDichVu { get => moTaDichVu; set => moTaDichVu = value; }
        public float TongTienDichVu { get => tongTienDichVu; set => tongTienDichVu = value; }
    }
}
