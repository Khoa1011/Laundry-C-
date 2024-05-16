using Doan;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Đồ_án_mới.Business
{
    class CXuLyBook : IXuLy<CBook>
    {
        private LinkedList<CBook> listBook;
        private LinkedList<CAuthor> listAuthor; // Danh sách tác giả
        private LinkedList<CPublisher> listPublisher; // Danh sách Nhà xuất bản
        public CXuLyBook()
        {
            
            CTruyCapDuLieu dulieu = CTruyCapDuLieu.Init();
            listBook = dulieu.GetBook();
            listAuthor = dulieu.GetCAuthor();
            listPublisher =dulieu.GetCPublisher();
        }
        public LinkedList<CBook> GetValues()
        {
            return listBook;
        }
        public LinkedList <CAuthor> getListAuthor()
        {
            return listAuthor;
        }
        public LinkedList<CPublisher> getListPublisher()
        {
            return listPublisher;
        }
        public CBook Find(String id)
        {
            foreach(CBook item in listBook)
            {
                if(item.ID == id) 
                    return item;
            }
            return null;
        }
        public bool AddList(CBook b)
        {
            if (b == null) return false;
            if(Find(b.ID) != null) return false;
            listBook.AddLast(b);
            return true;
        }
        public bool EditList(CBook b)
        {
            if (b == null) return false;
            CBook o = Find(b.ID);
            if (o == null) return false;
            //Cập nhật thông tin sách
            o.Name = b.Name;
            o.Genre = b.Genre;
            o.Published_Date = b.Published_Date;
            o.Quantity = b.Quantity;
            //Cập nhật thông tin tác giả và nhà xuất bản
            o.Publisher = b.Publisher;
            o.Author=b.Author;
            return true;
        }
        public bool DeleteList(String id)
        {
            CBook a = Find(id);
            if (a == null) return false;
            listBook.Remove(a);
            return true;
        }
    }
}
