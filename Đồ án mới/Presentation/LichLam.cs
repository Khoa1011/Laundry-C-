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

namespace Đồ_án_mới.Presentation
{
    public partial class LichLam : Form
    {
        static LichLamDAO llDAO = new LichLamDAO();
        public LichLam()
        {
            InitializeComponent();
            load();
            Combobox();
        }
        public void load()
        {
            DataTable dt = llDAO.findAll();
            dgv_Lich.DataSource = dt;
        }
        public void Combobox()
        {
            DataTable dt = llDAO.loadComboBoxKhungGio();
            cb_khungGio.DataSource = dt;
            cb_khungGio.DisplayMember = "KhungGioLam";
            cb_khungGio.ValueMember = "KhungGioLam";

        }
        private void bt_timkiem_Click(object sender, EventArgs e)
        {
            if (rdo_findByID.Checked)
                dgv_Lich.DataSource = llDAO.findByID(int.Parse(txt_findID.Text));
            if (rdo_All.Checked)
                load();
        }

        private void btn_addSchedule_Click(object sender, EventArgs e)
        {
            LICHLAMVIEC ll = new LICHLAMVIEC();
            ll.LichLamViec = dt_Date.Value.Date;

            // Kiểm tra xem có mục nào được chọn trong ComboBox không
            if (cb_khungGio.SelectedItem != null)
            {
                ll.KhungGio = cb_khungGio.SelectedValue.ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một khung giờ từ ComboBox.");
                return; // Thoát khỏi phương thức nếu không có mục nào được chọn
            }

            if (txt_ID.Text == "")
            {
                MessageBox.Show("Không được để trống!!");
            }
            else
            {
                int id = int.Parse(txt_ID.Text);

                if (llDAO.addSchedule(ll, id))
                {
                    load();
                    MessageBox.Show("Thêm thành công!!");
                }
                else
                {
                    MessageBox.Show("Không thêm được !!");
                }
            }
        }

        private void bt_xoa_lapphieu_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Parse(dgv_Lich[2, dgv_Lich.CurrentRow.Index].Value.ToString());
            int id = int.Parse(dgv_Lich[0, dgv_Lich.CurrentRow.Index].Value.ToString());
            string time = dgv_Lich[3, dgv_Lich.CurrentRow.Index].Value.ToString();

            if (llDAO.deleteSchedule(dt, id, time))
            {
                load();
                MessageBox.Show("Xóa thành công!!");
            }
            else MessageBox.Show("Không Xóa được !!" + dt + id);

        }

        private void btn_updateSchedule_Click(object sender, EventArgs e)
        {
            LICHLAMVIEC ll = new LICHLAMVIEC();
            ll.LichLamViec = dt_Date.Value.Date;
            DateTime lichLamViecCu =DateTime.Parse( dgv_Lich[2, dgv_Lich.CurrentRow.Index].Value.ToString());
            String khungGioCu = dgv_Lich[3, dgv_Lich.CurrentRow.Index].Value.ToString();
            if (cb_khungGio.SelectedItem != null)
            {
                ll.KhungGio = cb_khungGio.SelectedValue.ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một khung giờ từ ComboBox.");
                return; // Thoát khỏi phương thức nếu không có mục nào được chọn
            }
            int id = int.Parse(txt_ID.Text);
            if (llDAO.updateSchedule(ll, id,lichLamViecCu,khungGioCu))
            {
                load();
                MessageBox.Show("Sửa thành công!!");
            }
            else MessageBox.Show("Sửa không thành công!!");
        }

        private void dgv_Lich_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_ID.Text = dgv_Lich[0, dgv_Lich.CurrentRow.Index].Value.ToString();
        }

        private void dgv_Lich_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


    }
}
