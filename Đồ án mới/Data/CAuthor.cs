using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doan
{
    [Serializable]
    class CAuthor : CPerson
    {
        private bool m_GioiTinh;
        private String m_Genre; //Thể loại
        private String m_notableWorks; // Tác phẩm nổi tiếng 

        public string Genre { get => m_Genre; set => m_Genre = value; }
        public string NotableWorks { get => m_notableWorks; set => m_notableWorks = value; }
        public bool GioiTinh { get => m_GioiTinh; set => m_GioiTinh = value; }

        public CAuthor() :base ()
        {
            Genre = " ";
            NotableWorks = " ";
            GioiTinh = true;
        }
        public CAuthor(String ID_TGia, String hoten_TGia,bool GioiTinh_TGia, DateTime NgaySinh_TGia,
            String diachi_TGia,int sdt_TGia, String genre_TGia,String notableWorks_TGia) 
            : base(ID_TGia, hoten_TGia , NgaySinh_TGia, diachi_TGia, sdt_TGia)
        {
            Genre = genre_TGia;
            NotableWorks = notableWorks_TGia;
            GioiTinh = GioiTinh_TGia; 
        }
        public override string ToString()
        {
            return HovaTen;
        }
    }
    
}
