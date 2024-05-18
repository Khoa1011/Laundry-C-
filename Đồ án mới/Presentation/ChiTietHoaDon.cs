
using Doan;
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
    public partial class ChiTietHoaDon : Form
    {
        public ChiTietHoaDon()
        {
            InitializeComponent();
        }
        private void bt_back_QLMTS_Click(object sender, EventArgs e)
        {
            HeThong ht = new HeThong();
            ht.Show();
            this.Hide();
        }

        private void guna2ControlBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PhieuThuVien_Load(object sender, EventArgs e)
        {
          
        }
        private void HienThiSach(object sender, EventArgs e)
        {

        }
        private void HienThiReader(object sender, EventArgs e)
        {

        }
        private void HienThiEmployee(object sender, EventArgs e)
        {

        }
        private void HienThi(object sender, EventArgs e)
        {          
        }
        private void bt_them_lapphieu_Click(object sender, EventArgs e)
        {
        }
        private void bt_sua_lapphieu_Click(object sender, EventArgs e)
        {
        }
        private void bt_xoa_lapphieu_Click(object sender, EventArgs e)
        {
          
        }
        private void bt_timkiem_Click(object sender, EventArgs e)
        {
        }
        private void bt_trasach_Click(object sender, EventArgs e)
        {
         
        }
        private void dgv_TraCuu_SelectionChanged(object sender, EventArgs e)
        {
        }
        private void dgv_taophieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }
        private void dgv_taophieu_SelectionChanged(object sender, EventArgs e)
        {
           
        }
        private void bt_timkiem_taophieu_Click(object sender, EventArgs e)
        {
            
        }
    }
}
