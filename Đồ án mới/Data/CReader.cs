using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doan
{
    [Serializable]
    class CReader : CPerson
    {
        private bool m_GioiTinh;
        private LinkedList<CBook> m_Borrowed;
        public LinkedList<CBook> Borrowing
        {
            get { return m_Borrowed; }
            set { m_Borrowed = value; }
        }


        public bool GioiTinh { get => m_GioiTinh; set => m_GioiTinh = value; }
        public CReader():base()
        {
            Borrowing = new LinkedList<CBook>();
            GioiTinh = true;
        }
        public CReader(String ID_DGia, String ten_DGia, bool gioitinh_DGia, DateTime ngaysinh_Dgia,
            String diachi_DGia, int sdt_DGia, LinkedList<CBook> borrowing)
            : base(ID_DGia, ten_DGia, ngaysinh_Dgia, diachi_DGia, sdt_DGia)
        {
            Borrowing = borrowing;
            GioiTinh = gioitinh_DGia;
        }
        public override string ToString()
        {
            return ID;
        }
    }
}
