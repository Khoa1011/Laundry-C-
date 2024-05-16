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
    class CXuLyReader : IXuLy<CReader>
    {
        private LinkedList<CReader> listReader;

        public CXuLyReader()
        {
            CTruyCapDuLieu data= CTruyCapDuLieu.Init();
            listReader = data.GetCReader();
        }
        public LinkedList<CReader> GetValues()
        {
            return listReader;
        }
        public CReader Find(string ID)
        {
            foreach (CReader item in listReader)
            {
                if (item.ID == ID)
                {
                    return item;
                }
            }
            return null;
        }

        public bool AddList(CReader value)
        {
            if (value == null) return false;
            if(listReader == null)
                listReader = new LinkedList<CReader>();
            if (Find(value.ID) != null) return false;
            listReader.AddLast(value);
            return true;
        }

        public bool EditList(CReader x)
        {
            if (x == null) return false;
            CReader rd = Find(x.ID);
            if(rd == null) return false;
            rd.HovaTen = x.HovaTen;
            rd.GioiTinh = x.GioiTinh;
            rd.NgaySinh = x.NgaySinh;
            rd.DiaChi = x.DiaChi;
            rd.Sdt = x.Sdt;
            return true;

        }

        public bool DeleteList(string ID)
        {
            CReader rd = Find(ID);
            if (rd == null) return false;
            return listReader.Remove(rd);
        }

        
    }
}
