using Doan;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Đồ_án_mới.Business
{
    class CXuLyEmployee : IXuLy<CEmployee>
    {
        private LinkedList<CEmployee> listEmployee;

        public CXuLyEmployee()
        {
            CTruyCapDuLieu data = CTruyCapDuLieu.Init();
            listEmployee = data.GetCEmployee();
        }
        public LinkedList<CEmployee> GetValues()
        {
            return listEmployee;
        }
        public CEmployee Find(string ID)
        {
            foreach (CEmployee item in listEmployee)
            {
                if (item.ID == ID)
                {
                    return item;
                }
            }
            return null;
        }
        public bool AddList(CEmployee value)
        {
            if (value == null) return false;
            if (Find(value.ID) != null) return false;
            listEmployee.AddLast(value);
            return true;
        }
        public bool EditList(CEmployee x)
        {
            if (x == null) return false;
            CEmployee ep = Find(x.ID);
            if (ep == null) return false;
            ep.HovaTen = x.HovaTen;
            ep.GioiTinh = x.GioiTinh;
            ep.NgaySinh = x.NgaySinh;
            ep.DiaChi = x.DiaChi;
            ep.Sdt = x.Sdt;
            ep.ChucVu = x.ChucVu;
            return true;
        }

        public bool DeleteList(string ID)
        {
            CEmployee at = Find(ID);
            if (at == null) return false;
            return listEmployee.Remove(at);
        }
    }
}
