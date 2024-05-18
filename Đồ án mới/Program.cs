using Đồ_án_mới.Data;
using Đồ_án_mới.Until;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doan
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        //[STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new HeThong());

            ConnectionToolKit connect = new ConnectionToolKit();
            List<nhanvien>getList = connect.getList();
            foreach (nhanvien item in getList)
            {
                Console.WriteLine(item.toString());
            }

        }
    }
}
