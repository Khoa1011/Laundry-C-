using System;
using Đồ_án_mới.DTO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Data;

namespace Đồ_án_mới.DAO
{
    public interface interfaceDAO<T>
    {
        DataTable findALL();
        Boolean add(T enity);
        Boolean update(T enity, int id);
        Boolean delete(int id);

    }
}
