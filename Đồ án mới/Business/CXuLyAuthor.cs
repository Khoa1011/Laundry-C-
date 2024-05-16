using Doan;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Đồ_án_mới.Business
{
    class CXuLyAuthor : IXuLy<CAuthor>
    {
        private LinkedList<CAuthor> listAuthor;

        public CXuLyAuthor()
        {
            CTruyCapDuLieu data = CTruyCapDuLieu.Init();
            listAuthor = data.GetCAuthor();
        }
        public LinkedList<CAuthor> GetValues()
        {
            return listAuthor;
        }
        public CAuthor Find(string ID)
        {
            foreach (CAuthor item in listAuthor)
            {
                if (item.ID == ID)
                {
                    return item;
                }
            }
            return null;
        }
        public bool AddList(CAuthor value)
        {
            if (value == null) return false;
            if (Find(value.ID) != null) return false;
            listAuthor.AddLast(value);
            return true;
        }
        public bool EditList(CAuthor x)
        {
            if (x == null) return false;
            CAuthor at = Find(x.ID);
            if(at==null) return false;
            at.HovaTen = x.HovaTen;
            at.GioiTinh = x.GioiTinh;
            at.NgaySinh = x.NgaySinh;
            at.DiaChi = x.DiaChi;
            at.Sdt = x.Sdt;
            at.Genre = x.Genre;
            at.NotableWorks = x.NotableWorks;
            return true;
        }

        public bool DeleteList(string ID)
        {
            CAuthor at = Find(ID);
            if (at == null) return false;
            return listAuthor.Remove(at);
        }
    }
}
