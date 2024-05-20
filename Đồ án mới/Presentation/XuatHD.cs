using Đồ_án_mới.DTO;
using Đồ_án_mới.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Đồ_án_mới.Presentation
{
    public partial class XuatHD : Form
    {
        private int idKH;
        private DateTime dateKH;
        static DataTable dt = new DataTable();
        static XuatHDDAO xHDDAO = new XuatHDDAO();
        public int IdKH { get => idKH; set => idKH = value; }
        public DateTime DateKH { get => dateKH; set => dateKH = value; }
        public XuatHD()
        {
            InitializeComponent();

        }
        public void load()
        {
            XuatHDDAO xHDDAO = new XuatHDDAO();
            DataTable dt = xHDDAO.findObj(IdKH);
            dgv_xHD.DataSource = dt;
            // StringBuilder để xây dựng chuỗi kết quả
            StringBuilder sb = new StringBuilder();

            // Lặp qua từng dòng trong DataTable
            DataTable dataTable = xHDDAO.getIf(idKH, DateKH);
            foreach (DataRow row in dataTable.Rows)
            {
                // Lấy giá trị của cột "Name" và "Age"
                lb_date.Text = row["NGAY_HOADON"].ToString();
                lb_Name.Text = row["TEN_KHACHHANG"].ToString();
                lb_ID.Text = row["MA_KHACHHANG"].ToString();
                lb_Age.Text = row["TUOI_KHACHHANG"].ToString();
                lb_Address.Text = row["DIACHI_KHACHHANG"].ToString();
                lb_Phone.Text = row["SODT_KHACHHANG"].ToString();
                lb_total.Text = row["TONG_TONGTIEN_HOADON"].ToString() + "vnd";
                //Convert.ToInt32(row["Age"]);
                // Xây dựng chuỗi kết quả
                //sb.AppendLine($"Name: {name}, Age: {age}");
            }
        }
        public void LoadData(int idKH, DateTime dateKH)
        {
            IdKH = idKH;
            DateKH = dateKH;
            load();
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void check_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dateKH + "");
            load();
        }


        private void XuatHD_Load(object sender, EventArgs e)
        {

        }

       
    }
}
