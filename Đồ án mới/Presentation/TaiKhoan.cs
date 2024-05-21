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
    public partial class TaiKhoan : Form
    {
        static TaiKhoanDAO tkDAO = new TaiKhoanDAO();
        public TaiKhoan()
        {
            InitializeComponent();
            load();
        }
        public void load()
        {
            DataTable dt = tkDAO.findALL();
            dgv_taiKhoan.DataSource = dt;
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (rdo_ID.Checked)
            {
                try
                {
                    dgv_taiKhoan.DataSource = tkDAO.findByID(int.Parse(txt_findTK.Text));
                }
                catch 
                {
                    MessageBox.Show("Không được để trống!!");
                }

            }
            else if (rdo_Name.Checked)
            {
                if (txt_findTK.Text == "")
                {
                    MessageBox.Show("Không được để trống!!");
                }
                else
                    dgv_taiKhoan.DataSource = tkDAO.findByName(txt_findTK.Text);
            }
            else load();
        }

        private void btn_DeleleTK_Click(object sender, EventArgs e)
        {
            if (tkDAO.delete(int.Parse(dgv_taiKhoan[1, dgv_taiKhoan.CurrentRow.Index].Value.ToString())))
            {
                MessageBox.Show("Xóa thành công!!!");
            }
            else MessageBox.Show("Xóa thất bại !!!");


        }

        private void dgv_taiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_nameTK.Text = dgv_taiKhoan[0, dgv_taiKhoan.CurrentRow.Index].Value.ToString();
        }

        private void btn_changePass_Click(object sender, EventArgs e)
        {
            string userName = txt_nameTK.Text;
            string oldPassword = PasswordHelper.HashString(txt_oldPass.Text);
            string newPassword = PasswordHelper.HashString(txt_newPass.Text);
            string confirmPassword = PasswordHelper.HashString(txt_confirmPass.Text);
            if (txt_oldPass.Text == "" || txt_nameTK.Text == "" || txt_newPass.Text == "" || txt_confirmPass.Text == "")
            {
                MessageBox.Show("Không được để trống!!");
            }else
            {
                if (tkDAO.findUser(userName) == false)
                    MessageBox.Show("Sai tài khoản!!!");
                else
                {
                    if (tkDAO.checkOldPassword(userName, oldPassword))
                    {
                        if (newPassword == confirmPassword)
                        {
                            tkDAO.changePass(userName, newPassword);
                            load();
                            MessageBox.Show("Đổi mật khẩu thành công !!");
                        }
                        else MessageBox.Show("Mật khẩu không khớp!!!");
                    }
                    else MessageBox.Show("Sai mật khẩu!!!");
                }
            }
        }

        private void bt_back_QLMTS_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
