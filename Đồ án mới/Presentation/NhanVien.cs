using Đồ_án_mới.DAO;
using Đồ_án_mới.DTO;
using Doan;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Đồ_án_mới.Presentation
{
    public partial class NhanVien : Form
    {

        NhanVienDAO nvDAO = new NhanVienDAO();
        public NhanVien()
        {
            InitializeComponent();
            load();
        }
        private void load()
        {
            dgv_NV.DataSource = nvDAO.findALL();
        }

        private void bt_timkiem_Click(object sender, EventArgs e)
        {
            if (rdo_ID.Checked)
            {
                int id = int.Parse(txt_findNV.Text);
                dgv_NV.DataSource = nvDAO.findByID(id);
            }
            if (rdo_Name.Checked)
            {
                string name = txt_findNV.Text;
                dgv_NV.DataSource = nvDAO.findByName(name);
            }
            if (rdo_All.Checked)
            {
                load();
            }

        }

        private void bt_them_NV_Click(object sender, EventArgs e)
        {
            NHANVIEN nv = new NHANVIEN();
            TAIKHOAN tk = new TAIKHOAN();
            nv.TenNhanVien = txt_nameNV.Text;
            nv.TuoiNhanVien = int.Parse(txt_ageNV.Text);
            nv.DiaChiNhanVien = txt_addressNV.Text;
            nv.SdtNhanVien = txt_sdtNV.Text;
            tk.TenTaiKhoan = txt_userName.Text;
            tk.MatKhau = PasswordHelper.HashString(txt_passWord.Text);
            nv.Taikhoan = tk;
            if (rdo_namKH.Checked)
            {
                nv.GioiTinhNhanVien = "Nam";
            }
            if (rdo_nuKH.Checked)
            {
                nv.GioiTinhNhanVien = "Nu";
            }
            if (nvDAO.AddNV(nv))
            {
                MessageBox.Show("Thêm thành công!!!");
            }
            else
            {
                MessageBox.Show("Không thêm được!!!");
            }
            load();
        }

        private void bt_sua_NV_Click(object sender, EventArgs e)
        {
            NHANVIEN nv = new NHANVIEN();
            TAIKHOAN tk = new TAIKHOAN();
            nv.TenNhanVien = txt_nameNV.Text;
            nv.TuoiNhanVien = int.Parse(txt_ageNV.Text);
            nv.DiaChiNhanVien = txt_addressNV.Text;
            nv.SdtNhanVien = txt_sdtNV.Text;
            tk.TenTaiKhoan = txt_userName.Text;
            tk.MatKhau = txt_passWord.Text;
            nv.Taikhoan = tk;
            if (rdo_namKH.Checked)
            {
                nv.GioiTinhNhanVien = "Nam";
            }
            if (rdo_nuKH.Checked)
            {
                nv.GioiTinhNhanVien = "Nu";
            }
            string idString = dgv_NV[0, dgv_NV.CurrentRow.Index].Value.ToString();
            int.TryParse(idString, out int id);
            if (nvDAO.Update(id, nv))
            {
         
                MessageBox.Show("Sửa thành công!!!" );
            }
            else
            {
        
                MessageBox.Show("Sửa thất bại!!!" );
            }
            load();
        }

        private void dgv_NV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_NV.RowCount > 0)
            {

                txt_nameNV.Text = dgv_NV[1, dgv_NV.CurrentRow.Index].Value.ToString();
                txt_ageNV.Text = dgv_NV[3, dgv_NV.CurrentRow.Index].Value.ToString();
                txt_addressNV.Text = dgv_NV[4, dgv_NV.CurrentRow.Index].Value.ToString();
                txt_sdtNV.Text = dgv_NV[5, dgv_NV.CurrentRow.Index].Value.ToString();
                txt_userName.Text = dgv_NV[6, dgv_NV.CurrentRow.Index].Value.ToString();
                if (dgv_NV[2, dgv_NV.CurrentRow.Index].Value.ToString().Equals("Nam") || dgv_NV[2, dgv_NV.CurrentRow.Index].Value.ToString().Equals("nam"))
                {
                    rdo_namKH.Checked = true;
                  
                }else if (dgv_NV[2, dgv_NV.CurrentRow.Index].Value.ToString().Equals("Nu") || dgv_NV[2, dgv_NV.CurrentRow.Index].Value.ToString().Equals("nu"))
                    rdo_nuKH.Checked = true;
            }
        }

        private void bt_xoa_NV_Click(object sender, EventArgs e)
        {
             string idString = dgv_NV[0, dgv_NV.CurrentRow.Index].Value.ToString();
            ////string username = dgv_NV[6, dgv_NV.CurrentRow.Index].Value.ToString();
            int.TryParse(idString, out int id);
            if (nvDAO.Delete(id))
            {
               
                MessageBox.Show("Xóa thành công!!!" );
            }
            else
            {
                
                MessageBox.Show("Xóa thất bại!!!" );
            }
            load();
        }
    }
}
