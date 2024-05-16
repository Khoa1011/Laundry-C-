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
    class CXuLyPublisher : IXuLy<CPublisher>
    {
        private LinkedList<CPublisher> listPublisher;
        public CXuLyPublisher()
        {
            CTruyCapDuLieu data = CTruyCapDuLieu.Init();
            listPublisher = data.GetCPublisher();
        }
        public LinkedList<CPublisher> GetValues()
        {
            return listPublisher;
        }

        public CPublisher Find(string ID)
        {
            foreach (CPublisher item in listPublisher)
            {
                if (item.ID == ID)
                {
                    return item;
                }
            }
            return null;
        }

        public bool AddList(CPublisher value)
        {
            if (value == null) return false;
            if (Find(value.ID) != null) return false;
            listPublisher.AddLast(value);
            return true;
        }

        public bool EditList(CPublisher x)
        {
            if (x == null) return false;
            CPublisher pl = Find(x.ID);
            if(pl==null) return false;
            pl.HovaTen = x.HovaTen;
            pl.NgaySinh= x.NgaySinh;
            pl.DiaChi = x.DiaChi;
            pl.Sdt = x.Sdt;
            return true;

        }

        public bool DeleteList(string ID)
        {
            CPublisher ps = Find(ID);
            if (ps == null) return false;
            return listPublisher.Remove(ps);
        }

        public bool ReadFile(String tenfile)
        {
            try
            {
                FileStream f = new FileStream(tenfile, FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                listPublisher = bf.Deserialize(f) as LinkedList<CPublisher>;
                f.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool WriteFile(String tenfile)
        {
            try
            {
                FileStream f = new FileStream(tenfile, FileMode.Create);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(f, listPublisher);
                f.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
