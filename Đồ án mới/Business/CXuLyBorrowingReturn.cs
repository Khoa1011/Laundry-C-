using Doan;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Đồ_án_mới.Business
{
    class CXuLyBorrowingReturn : IXuLy<CBorrowing_Return>
    {
        private LinkedList<CBorrowing_Return> listBorrowingRT;
        private LinkedList<CReader> listReader; // Danh sách độc giả
        private LinkedList<CEmployee> listEmployee;// Danh sách nhân viên
        private LinkedList<CBook> listBooks;//Danh sách sách của thư viện
        public CXuLyBorrowingReturn()
        {
            CTruyCapDuLieu data = CTruyCapDuLieu.Init();
            listBorrowingRT = data.GetBorrowing_Return();
            listReader = data.GetCReader();
            listEmployee =data.GetCEmployee();
            listBooks=data.GetBook();
        }
        public LinkedList<CBorrowing_Return> GetValues()
        {
            return listBorrowingRT;
        }
        public LinkedList<CBook>GetBooks()
        {
            return listBooks;
        }
        public LinkedList <CReader> GetlistReader()
        {
            return listReader;
        }
        public LinkedList<CEmployee> GetlistEmployeeee()
        {
            return listEmployee;
        }
        public CBorrowing_Return Find(string ID)
        {
            foreach (CBorrowing_Return item in listBorrowingRT)
            {
                if (item.ID == ID)
                {
                    return item;
                }
            }
            return null;
        }
        public bool AddList(CBorrowing_Return value)
        {
            if(value  == null)return false;
            if(Find(value.ID) != null) return false;
            listBorrowingRT.AddLast(value);
            return true; 
        } 
        public bool EditList(CBorrowing_Return value)
        {
            if (value == null) return false;
            CBorrowing_Return br =Find(value.ID);
            if(br == null) return false;
            //Cập nhật thông tin phiếu
            br.BorrowedDay = value.BorrowedDay;
            br.ReturnDay = value.ReturnDay;
            //Cập nhật thông tin mã nhân viên và độc giả
            br.Reader = value.Reader;
            br.Employee = value.Employee;
            //Cập nhập sách
            br.Book = value.Book;
            return true;
        }
        public bool DeleteList(String ID)
        {
            CBorrowing_Return br = Find(ID);
            if (br == null) return false;
            listBorrowingRT.Remove(br);
            return true;
        }
    }
}
