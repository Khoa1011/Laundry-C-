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
using System.Windows.Forms.PropertyGridInternal;


namespace Doan
{
    public partial class DangNhap : Form
    {
        private String user = "admin";
        private String pass = "1";
        private DangNhapDAO dao = new DangNhapDAO();
        public DangNhap()
        {
            InitializeComponent();
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

        private void bt_login_Click(object sender, EventArgs e)
        {
            String lblUser = txt_user.Text;
            String lblPassword = PasswordHelper.HashString( txt_password.Text);
            if(txt_user.Text == "" && txt_password.Text == "")
            {
                MessageBox.Show("Tài khoản mật khẩu không được bỏ trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if(dao.checkLogin(lblUser,lblPassword) == true)
            {
                HeThong ht = new HeThong();
                ht.Show();
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                this.Hide();
            }
        }
    }
}
