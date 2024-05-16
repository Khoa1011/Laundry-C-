using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doan
{
    [Serializable]
    class CEmployee : CPerson
    {    
        private String m_chucVu;
        private bool m_GioiTinh;
        public String ChucVu
        {
            get { return m_chucVu; }
            set { m_chucVu = value; }
        }

        public bool GioiTinh { get => m_GioiTinh; set => m_GioiTinh = value; }


        public CEmployee(String ID_nv, String ten_nv, bool gioitinh_nv, DateTime ngaysinh_nv,
            String diachi_nv, int sdt_nv, String chucvu)

            : base(ID_nv, ten_nv ,ngaysinh_nv, diachi_nv, sdt_nv)
        {
            ChucVu = chucvu;
            GioiTinh = gioitinh_nv;
            
        }

        public CEmployee() : base() 
        {
            ChucVu = " ";
            GioiTinh = true;
            
        }
        public override string ToString()
        {
            return ID;
        }
    }
}
