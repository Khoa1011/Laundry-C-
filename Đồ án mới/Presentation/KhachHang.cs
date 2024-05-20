using Đồ_án_mới.DAO;
using Đồ_án_mới.DTO;
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
        static KhachHangDAO khDAO = new KhachHangDAO();
        static DataTable dt = new DataTable();
        public KhachHang()
        {
            InitializeComponent();
            load();
        }

        public void load()
        {
            dt = khDAO.findALL();
            dgv_KH.DataSource = dt;
        }
        private void bt_back_Click(object sender, EventArgs e)
        {
            //Show(new HeThong());
            this.Hide();
        }



        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bt_search_Click(object sender, EventArgs e)
        {
            if (txt_search.Text == "")
                MessageBox.Show("Vui lòng không để trống !!");
            if (rdo_findByName.Checked)
            {
                dgv_KH.DataSource = khDAO.findByName(txt_search.Text);
            }
            else if (rdo_findBySDT.Checked)
            {
                dgv_KH.DataSource = khDAO.findBySDT(txt_search.Text);
            }
            else if (rdo_findAll.Checked)
                load();
        }

        private void bt_them_Đgia_Click(object sender, EventArgs e)
        {
            KHACHHANG kh = new KHACHHANG();
            kh.TenKhachHang = txt_nameKH.Text;
            kh.TuoiKhachHang = int.Parse(txt_ageKH.Text);
            kh.DiaChiKhachHang = txt_anddressKH.Text;
            kh.SdtKhachHang = txt_sdtKH.Text;
            if (rdo_namKH.Checked)
            {
                kh.GioiTinhKhachHang = "Nam";
            }
            if (rdo_nuKH.Checked)
            {
                kh.GioiTinhKhachHang = "Nu";
            }
            if (khDAO.addKH(kh))
            {
                MessageBox.Show("Thêm thành công!!!");
            }
            else
            {
                MessageBox.Show("Không thêm được!!!");
            }
            load();
        }

        private void bt_sua_Đgia_Click(object sender, EventArgs e)
        {
            KHACHHANG kh = new KHACHHANG();
            kh.TenKhachHang = txt_nameKH.Text;
            kh.TuoiKhachHang = int.Parse(txt_ageKH.Text);
            kh.DiaChiKhachHang = txt_anddressKH.Text;
            kh.SdtKhachHang = txt_sdtKH.Text;
            if (rdo_namKH.Checked)
            {
                kh.GioiTinhKhachHang = "Nam";
            }
            if (rdo_nuKH.Checked)
            {
                kh.GioiTinhKhachHang = "Nu";
            }
            int id = int.Parse(dgv_KH[0, dgv_KH.CurrentRow.Index].Value.ToString());
            if (khDAO.updateKH(kh, id))
            {
                MessageBox.Show("Sửa thành công !!!");
                load();
            }
            else MessageBox.Show("Sửa không thành công !");
        }



        private void bt_deleteKH_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgv_KH[0, dgv_KH.CurrentRow.Index].Value.ToString());
            if (khDAO.deleteKH(id))
            {
                MessageBox.Show("Xóa thành công!");
                load();
            }
            else MessageBox.Show("Xóa thất bại!!");
        }

        private void dgv_KH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_nameKH.Text = dgv_KH[1, dgv_KH.CurrentRow.Index].Value.ToString();
            txt_ageKH.Text = dgv_KH[2, dgv_KH.CurrentRow.Index].Value.ToString();
            txt_anddressKH.Text = dgv_KH[4, dgv_KH.CurrentRow.Index].Value.ToString();
            txt_sdtKH.Text = dgv_KH[5, dgv_KH.CurrentRow.Index].Value.ToString();
            if (dgv_KH[3, dgv_KH.CurrentRow.Index].Value.ToString().Equals("Nam") || dgv_KH[3, dgv_KH.CurrentRow.Index].Value.ToString().Equals("nam"))
            {
                rdo_namKH.Checked = true;

            }
            else if (dgv_KH[3, dgv_KH.CurrentRow.Index].Value.ToString().Equals("Nu") || dgv_KH[3, dgv_KH.CurrentRow.Index].Value.ToString().Equals("nu"))
                rdo_nuKH.Checked = true;
        }
    }
}
