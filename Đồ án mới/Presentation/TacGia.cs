using Đồ_án_mới.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doan
{
    public partial class TacGia : Form
    {
        private CXuLyAuthor xuly;
        
        public TacGia()
        {
            InitializeComponent();
        }
        private void TacGia_Load(object sender, EventArgs e)
        {
            xuly = new CXuLyAuthor();
            dgv_TacGia.AutoGenerateColumns = false;
            HienThi(xuly.GetValues());
        }
        private void HienThi(LinkedList<CAuthor> list)
        {
            BindingSource bd = new BindingSource();
            bd.DataSource = list;
            dgv_TacGia.DataSource = bd;

           
            txt_matacgia_TacGia.Clear();
            txt_tentacgia_TacGia.Clear();
            rdo_nam_TacGia.Checked = true;
            dtp_ngaysinh_TacGia.Value= DateTime.Now;
            txt_diachi_TacGia.Clear();
            txt_sdt_TacGia.Clear();
            txt_chuyenTL_TacGia.Clear();
            txt_tieubieu_TacGia.Clear();
        }
        private void guna2ControlBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void bt_back_TacGia_Click(object sender, EventArgs e)
        {
            HeThong f = new HeThong();
            f.Show();
            this.Hide();  
        }
        private void bt_them_TacGia_Click(object sender, EventArgs e)
        {
            //Kiểm tra mã tác giả
            if (String.IsNullOrEmpty(txt_matacgia_TacGia.Text))
            {
                MessageBox.Show("Mã tác giả không được để trống!");
                return;
            }
            //Kiểm tra tên tác giả
            if (String.IsNullOrEmpty(txt_tentacgia_TacGia.Text))
            {
                MessageBox.Show("Tên tác giả không được để trống!");
                return;
            }
            //Kiểm tra địa chỉ tác giả
            if (String.IsNullOrEmpty(txt_diachi_TacGia.Text))
            {
                MessageBox.Show("Địa chỉ tác giả không được để trống!");
                return;
            }
            
            if (String.IsNullOrEmpty(txt_matacgia_TacGia.Text))
            {
                MessageBox.Show("Mã tác giả không được để trống!");
                return;
            }
            CAuthor at = new CAuthor();
            at.ID = txt_matacgia_TacGia.Text;
            at.HovaTen = txt_tentacgia_TacGia.Text;
            at.GioiTinh = rdo_nam_TacGia.Checked;
            at.NgaySinh = dtp_ngaysinh_TacGia.Value;
            at.DiaChi = txt_diachi_TacGia.Text;
            at.Genre = txt_chuyenTL_TacGia.Text;
            at.NotableWorks = txt_tieubieu_TacGia.Text;
            if (int.TryParse(txt_sdt_TacGia.Text, out int sdt) && sdt != 0)
            {
                at.Sdt = sdt;
                if (xuly.AddList(at) == true)
                {
                    HienThi(xuly.GetValues());
                }
                else MessageBox.Show("Không thêm được tác giả!");
            }
            else
            {
                MessageBox.Show("Số điện thoại không hợp lệ!");
            }
        }
        private void bt_sua_TacGia_Click(object sender, EventArgs e)
        {
            CAuthor at = new CAuthor();
            at.ID = txt_matacgia_TacGia.Text;
            at.HovaTen = txt_tentacgia_TacGia.Text;
            at.GioiTinh = rdo_nam_TacGia.Checked;
            at.NgaySinh = dtp_ngaysinh_TacGia.Value;
            at.DiaChi = txt_diachi_TacGia.Text;
            at.Genre = txt_chuyenTL_TacGia.Text;
            at.NotableWorks = txt_tieubieu_TacGia.Text;
            if (int.TryParse(txt_sdt_TacGia.Text, out int sdt) && sdt != 0)
            {
                at.Sdt = sdt;
                if (xuly.EditList(at) == true)
                {
                    HienThi(xuly.GetValues());
                }
                else MessageBox.Show("Không sửa được tác giả!");
            }
            else
            {
                MessageBox.Show("Số điện thoại không hợp lệ!");
            }

        }
        private void bt_xoa_TacGia_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow r in dgv_TacGia.SelectedRows)
            {
                String maso = r.Cells["MaTG"].Value.ToString();
                if (xuly.DeleteList(maso) == true)
                {
                    break;
                }
                else MessageBox.Show("Không xóa được tác giả!");
            }
            HienThi(xuly.GetValues());
        }
        private void dgv_TacGia_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in dgv_TacGia.SelectedRows)
            {
                String maso = r.Cells["MaTG"].Value.ToString();
                CAuthor at = xuly.Find(maso);
                if (at != null)
                {
                    txt_matacgia_TacGia.Text = at.ID;
                    txt_tentacgia_TacGia.Text = at.HovaTen;
                    rdo_nam_TacGia.Checked = at.GioiTinh;
                    dtp_ngaysinh_TacGia.Value = at.NgaySinh;
                    txt_diachi_TacGia.Text = at.DiaChi;
                    txt_chuyenTL_TacGia.Text = at.Genre;
                    txt_tieubieu_TacGia.Text = at.NotableWorks;
                    txt_sdt_TacGia.Text = at.Sdt.ToString();
                    break;
                }
            }
        }
        private void dgv_TacGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string maso = dgv_TacGia.Rows[e.RowIndex].Cells["MaTG"].Value.ToString();
            CAuthor at = xuly.Find(maso);
            if (at != null)
            {
                txt_matacgia_TacGia.Text = at.ID;
                txt_tentacgia_TacGia.Text = at.HovaTen;
                rdo_nam_TacGia.Checked = at.GioiTinh;
                dtp_ngaysinh_TacGia.Value = at.NgaySinh;
                txt_diachi_TacGia.Text = at.DiaChi;
                txt_chuyenTL_TacGia.Text = at.Genre;
                txt_tieubieu_TacGia.Text = at.NotableWorks;
                txt_sdt_TacGia.Text = at.Sdt.ToString();
            }
        }
        private void bt_timkiem_Click(object sender, EventArgs e)
        {
            if (rdo_ma.Checked == true)
            {
                String key = txt_timkiem.Text.Trim();
                if (txt_timkiem.Text == "")
                {
                    MessageBox.Show("Nhập mã tác giả bạn muốn tìm kiếm!");
                    return;
                }
                else
                {
                    HienThi(xuly.GetValues());
                    foreach (DataGridViewRow row in dgv_TacGia.Rows)
                    {
                        // Kiểm tra nếu mã sách trong dòng đó trùng với key
                        if (row.Cells["MaTG"].Value != null &&
                            string.Equals(row.Cells["MaTG"].Value.ToString(), key, StringComparison.OrdinalIgnoreCase))
                        {
                            // Chọn dòng đó
                            row.Selected = true;
                            txt_timkiem.Clear();
                            return; // Dừng vòng lặp khi tìm thấy
                        }
                    }

                    // Hiển thị toàn bộ dữ liệu nếu không tìm thấy
                    MessageBox.Show("Không tìm thấy mã tác giả bạn muốn tìm!");
                    HienThi(xuly.GetValues());
                }
            }
            else if (rdo_ten.Checked == true)
            {
                // Tìm kiếm theo tên sách
                string key = txt_timkiem.Text.Trim();
                if (string.IsNullOrEmpty(key))
                {
                    MessageBox.Show("Nhập tên tác giả bạn muốn tìm kiếm!");
                    return;
                }

                // Duyệt qua từng dòng trong DataGridView
                HienThi(xuly.GetValues());
                foreach (DataGridViewRow row in dgv_TacGia.Rows)
                {
                    // Kiểm tra nếu tên sách trong dòng đó chứa key
                    if (row.Cells["TenNXB"].Value != null &&
                        string.Equals(row.Cells["TenNXB"].Value.ToString(), key, StringComparison.OrdinalIgnoreCase))
                    {
                        // Chọn dòng đó
                        row.Selected = true;
                        txt_timkiem.Clear();
                        return; // Dừng vòng lặp khi tìm thấy
                    }
                }

                // Hiển thị toàn bộ dữ liệu nếu không tìm thấy
                MessageBox.Show("Không tìm thấy tên tác giả!");
                HienThi(xuly.GetValues());
            }
        }
    }
}
