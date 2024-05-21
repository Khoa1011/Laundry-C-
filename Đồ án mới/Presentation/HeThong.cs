using Đồ_án_mới.DAO;
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

        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void HeThong_Load(object sender, EventArgs e)
        {
            
        }
        private Form currentFormChild;

        private void OpenChildForm (Form childForm)
        {
            if(currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelBody.Controls.Add(childForm);
            panelBody.Tag = childForm;
            childForm.BringToFront();
            childForm.Show(); 
        }

        private void btn_donhang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ChiTietHoaDon());
            lbl_title.Text = btn_donhang.Text;
        }

        private void btn_nhanvien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new NhanVien());
            lbl_title.Text = btn_nhanvien.Text;

        }

        private void btn_schedule_Click(object sender, EventArgs e)
        {
            OpenChildForm(new LichLam());
            lbl_title.Text = btn_schedule.Text;
        }

        private void btn_account_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TaiKhoan());
            lbl_title.Text = btn_account.Text;
        }


        private void btn_khachhang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new KhachHang());
            lbl_title.Text = btn_khachhang.Text;

        }

        private void btn_dichvu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DichVu());
            lbl_title.Text = btn_dichvu.Text;
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2ControlBox1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_DangXuat_Click(object sender, EventArgs e)
        {
            DangNhap dn = new DangNhap();
            dn.Show();
            MessageBox.Show("Đăng xuất thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
            this.Hide();
        }
    }
}
