using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doan
{
    [Serializable]
    class CPublisher : CPerson 
    {

        
        public String EstablishmentYear { get { return NgaySinh.Year.ToString(); } }

        public CPublisher(): base() 
        {
            
        }
        public CPublisher(String id_NXB,String ten_nxb, DateTime thanhlap_NXB, String dchi_NXB,int sdt_NXB)
            :base(id_NXB, ten_nxb, thanhlap_NXB, dchi_NXB, sdt_NXB)
        {

        }
        public override string ToString()
        {
            return HovaTen;
        }

    }
}
