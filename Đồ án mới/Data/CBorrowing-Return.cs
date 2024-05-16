using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doan
{
    [Serializable]
    class CBorrowing_Return
    {
        private String m_ID;
        private CReader m_Reader;
        private CEmployee m_Employee;
        private CBook m_Book;
        private DateTime m_borrowedDay;
        private DateTime m_returnDay;

        public String ID { get => m_ID; set => m_ID = value; }
        public DateTime BorrowedDay { get => m_borrowedDay; set => m_borrowedDay = value; }
        public DateTime ReturnDay { get => m_returnDay; set => m_returnDay = value; }
        public CReader Reader { get => m_Reader; set => m_Reader = value; }
        public CEmployee Employee { get => m_Employee; set => m_Employee = value; }
        public CBook Book { get => m_Book; set => m_Book = value; }

        public CBorrowing_Return()
        {
            ID = " ";
            Reader = new CReader();
            Employee = new CEmployee();
            Book = new CBook();
            BorrowedDay = DateTime.Now;
            ReturnDay = DateTime.Now;
        }

        public CBorrowing_Return(string iD, string iDBook, DateTime borrowedDay, DateTime returnDay, CReader rd, CEmployee ep,CBook b)
        {
            ID = iD;
            Reader = rd;
            Employee = ep;
            Book = b;
            BorrowedDay = borrowedDay;
            ReturnDay = returnDay;
            
        }

        public int SoNgayMuon(DateTime ngaymuon, DateTime ngaytra)
        {
            ngaymuon = BorrowedDay;
            ngaytra = ReturnDay;
            TimeSpan a = ngaytra - ngaymuon;
            return (int)a.TotalDays;
        }
    }
}
