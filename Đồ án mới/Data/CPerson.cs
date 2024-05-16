using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Doan
{
    [Serializable]
    class CPerson
    {
        protected String m_ID;
        protected String m_HovaTen;
        protected String m_DiaChi;
        protected int m_Sdt;
        protected DateTime m_NgaySinh;
        
        public String ID
        {
            get { return m_ID; }
            set { m_ID = value; }
        }
        public String HovaTen
        {
            get { return m_HovaTen; }
            set { m_HovaTen = value; }
        }
        
        public DateTime NgaySinh
        {
            get { return m_NgaySinh; }
            set { m_NgaySinh = value; }
        }
        public String DiaChi
        {
            get { return m_DiaChi; } 
            set { m_DiaChi = value;}

        }
        public int Sdt
        {
            get { return m_Sdt; }
            set { m_Sdt = value; }
        }
        public CPerson()
        {
            ID = " ";
            HovaTen = " ";
            NgaySinh = DateTime.Now;
            DiaChi = " ";
            Sdt = 0;
        }
        public CPerson(String MaID, String Ten, DateTime ngaysinh, String diachi, int sodt)
        {
            ID = MaID;
            HovaTen = Ten;
            NgaySinh = ngaysinh;
            DiaChi = diachi;
            Sdt = sodt;
        }
    }
}
