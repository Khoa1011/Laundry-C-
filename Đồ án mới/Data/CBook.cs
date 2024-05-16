using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doan
{
    [Serializable]
    class CBook
    {
        private String m_ID;
        private String m_Name;
        private String m_Genre; // Thể loại
        private DateTime m_Published_date; // Ngày xuất bản
        private int m_Quantity; // Số lượng
        private CPublisher m_Publisher; // Tên nhà xuất bản
        private CAuthor m_Author; // Tên tác giả
        

        public string ID { get => m_ID; set => m_ID = value; }
        public string Name { get => m_Name; set => m_Name = value; }
        public string Genre { get => m_Genre; set => m_Genre = value; }
        public DateTime Published_Date { get => m_Published_date; set => m_Published_date = value; }
        public int Quantity { get => m_Quantity; set => m_Quantity = value; }  
        public CPublisher Publisher { get => m_Publisher; set => m_Publisher = value; }
        public CAuthor Author { get => m_Author; set => m_Author = value; }

        public CBook()
        {
            ID = " ";
            Name = " ";
            Genre = " ";
            Published_Date = DateTime.Now;
            Quantity = 0;
            Author = new CAuthor();
            Publisher = new CPublisher(); 


        }

        public CBook ( string iD, string name, string genre, DateTime published_d, int quantity, string author,string publisher_name,
           CAuthor at, CPublisher pl)
        {
            
            ID = iD;
            Name = name;
            Genre = genre;
            Published_Date = published_d;
            Quantity = quantity;
            Author = at;
            Publisher = pl;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
