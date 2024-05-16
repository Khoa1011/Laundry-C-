using Đồ_án_mới.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.PropertyGridInternal;


namespace Doan
{
    public partial class DangNhap : Form
    {
        private String user = "admin";
        private String pass = "1";
        public DangNhap()
        {
            InitializeComponent();
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void bt_login_Click(object sender, EventArgs e)
        {
            string enteredUsername = txt_user.Text;
            string enteredPassword = txt_password.Text;

            if (Kiemtradangnhap(enteredUsername, enteredPassword))
            {        
                HeThong f = new HeThong();
                f.Show();
                if (CTruyCapDuLieu.ReadFile() != true)
                {
                    MessageBox.Show("Hiển thị dữ liệu không thành công!");
                }
                this.Hide();
                
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng! Vui lòng kiểm tra lại.");
            }
        }
        bool Kiemtradangnhap (string tentaikhoan,string matkhau)
        {
            if (tentaikhoan == user && matkhau == pass)
                return true;      
            return false;
        }

        private void sw_remember_CheckedChanged(object sender, EventArgs e)
        {
            if(sw_remember.Checked == true)
            {
                txt_user.Text = user;
                txt_password.Text = pass;
            }
            else
            {
                txt_user.Text = "";
                txt_password.Text = "";
            }
        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
