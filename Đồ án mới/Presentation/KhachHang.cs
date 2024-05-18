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

namespace Doan
{
    public partial class KhachHang : Form
    {

        public KhachHang()
        {
            InitializeComponent();
        }
        private void DocGia_Load(object sender, EventArgs e)
        {
  
            
        }
        private void HienThi(object sender, EventArgs e)
        {
          
        }
        private void bt_back_Click(object sender, EventArgs e)
        {
            HeThong f = new HeThong();
            f.Show();
            this.Hide();
        }
        private void bt_them_Đgia_Click(object sender, EventArgs e)
        {
          
        }
        private void bt_sua_Đgia_Click(object sender, EventArgs e)
        {
            
        }
        private void bt_xoa_Đgia_Click(object sender, EventArgs e)
        {
  
        }
        private void dgv_Đgia_SelectionChanged(object sender, EventArgs e)
        {
           
        }
        private void dgv_Đgia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
                
        }
        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void bt_timkiemĐgia_Click(object sender, EventArgs e)
        {
        }
    }
}
