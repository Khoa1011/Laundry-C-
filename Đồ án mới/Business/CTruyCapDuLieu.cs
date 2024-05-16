using Doan;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Web.UI.WebControls;

namespace Đồ_án_mới.Business
{
    [Serializable]
    class CTruyCapDuLieu
    {
        private static CTruyCapDuLieu instance = null;
        private LinkedList<CAuthor> listAuthor;
        private LinkedList<CPublisher> listPublisher;
        private LinkedList<CBook> listBook;
        private LinkedList<CReader> listReader;
        private LinkedList<CEmployee> listEmPloyee;
        private LinkedList<CBorrowing_Return> listBorrowing;
        private const string tenfile = "ds.dat";
        private CTruyCapDuLieu()
        {
            listAuthor = new LinkedList<CAuthor>();
            listPublisher = new LinkedList<CPublisher>();
            listBook = new LinkedList<CBook>();
            listReader = new LinkedList<CReader>();
            listEmPloyee = new LinkedList<CEmployee>();
            listBorrowing = new LinkedList<CBorrowing_Return>();

        }
        public static CTruyCapDuLieu Init()
        {
            if (instance == null)
                instance = new CTruyCapDuLieu();
            return instance;
        }
        
        public LinkedList<CAuthor> GetCAuthor()
        {
            return listAuthor;
        }
        public LinkedList<CPublisher> GetCPublisher()
        {
            return listPublisher;
        }
        public LinkedList<CBook> GetBook() 
        {
            return listBook;
        }

        public LinkedList<CReader> GetCReader()
        {
            return listReader;
        }
        public LinkedList<CEmployee> GetCEmployee()
        {
            return listEmPloyee;
        }
        public LinkedList<CBorrowing_Return> GetBorrowing_Return()
        {
            return listBorrowing;
        }
        public static bool ReadFile()
        {
            try
            {
                FileStream f = new FileStream(tenfile, FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                instance = (CTruyCapDuLieu)bf.Deserialize(f);
                f.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static bool WriteFile()
        {
            try
            {
                FileStream f = new FileStream(tenfile, FileMode.Create);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(f,instance);
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
