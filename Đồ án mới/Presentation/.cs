using Đồ_án_mới.Business;
using Đồ_án_mới.Presentation;
using System;
using System.CodeDom;
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
    public partial class HeThong : Form
    {
        public HeThong()
        {
            InitializeComponent();
        }
        private void HeThong_FormClosing(object sender, FormClosingEventArgs e)
        {
            CTruyCapDuLieu.WriteFile();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menu_docgia_Click(object sender, EventArgs e)
        {
            KhachHang dg= new KhachHang();
            dg.Show();
            this.Hide();
        }

        private void menu_nhanvien_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien();
            nv.Show();
            this.Hide();
        }

        private void menu_qlsach_Click(object sender, EventArgs e)
        {
            QuanLySach qls = new QuanLySach();
            qls.Show();
            this.Hide();
        }

        private void menu_tacgia_Click(object sender, EventArgs e)
        {
            TacGia tg= new TacGia();
            tg.Show();
            this.Hide();
        }

        private void menu_nxb_Click(object sender, EventArgs e)
        {
            NhaXuatBan nhaXB = new NhaXuatBan();
            nhaXB.Show();
            this.Hide();
        }

        private void menu_muontra_Click(object sender, EventArgs e)
        {
           QuanLyDonHang tv = new QuanLyDonHang();
            tv.Show();
            this.Hide();
        }

        private void HeThong_Load(object sender, EventArgs e)
        {
            
        }
    }
}
