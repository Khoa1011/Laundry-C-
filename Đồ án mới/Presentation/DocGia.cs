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

namespace Doan
{
    public partial class DocGia : Form
    {
        private CXuLyReader xuly;

        public DocGia()
        {
            InitializeComponent();
        }
        private void DocGia_Load(object sender, EventArgs e)
        {
            xuly = new CXuLyReader();
            dgv_Đgia.AutoGenerateColumns = false;
            HienThi(xuly.GetValues());
            
        }
        private void HienThi(LinkedList <CReader> list)
        {
            BindingSource bd= new BindingSource();
            bd.DataSource = list;
            dgv_Đgia.DataSource = bd;
            
            txt_ma_Đgia.Clear();
            txt_ten_Đgia.Clear();
            rdo_nam_Đgia.Checked = true;
            dtp_ngaysinh_ĐGia.Value = DateTime.Now;
            txt_diachi_Đgia.Clear();
            txt_sdt_ĐGia.Clear();
        }
        private void bt_back_Click(object sender, EventArgs e)
        {
            HeThong f = new HeThong();
            f.Show();
            this.Hide();
        }
        private void bt_them_Đgia_Click(object sender, EventArgs e)
        {
            //Kiểm tra mã có trống hay không
            if (String.IsNullOrEmpty(txt_ma_Đgia.Text))
            {
                MessageBox.Show("Mã độc giả không được để trống!");
                return;
            }

            //kiểm tra tên có trống hay không
            if (String.IsNullOrEmpty(txt_ten_Đgia.Text))
            {
                MessageBox.Show("Tên độc giả không được để trống!");
                return;
            }

            //Kiểm tra địa chỉ có trống hay không
            if (String.IsNullOrEmpty(txt_diachi_Đgia.Text))
            {
                MessageBox.Show("Địa chỉ độc giả không được để trống!");
                return;
            }
            CReader rd=new CReader();
            rd.ID= txt_ma_Đgia.Text;
            rd.HovaTen = txt_ten_Đgia.Text;
            rd.GioiTinh = rdo_nam_Đgia.Checked;
            rd.NgaySinh = dtp_ngaysinh_ĐGia.Value;
            rd.DiaChi = txt_diachi_Đgia.Text;
            if (int.TryParse(txt_sdt_ĐGia.Text, out int sdt) && sdt != 0)
            {
                rd.Sdt = sdt;
                if (xuly.AddList(rd)==true)
                {
                    HienThi(xuly.GetValues());
                }
                else
                {
                    MessageBox.Show("Không thêm được độc giả mới!");
                }
            }
            else
            {
                MessageBox.Show("Số điện thoại không hợp lệ!");
            }
        }
        private void bt_sua_Đgia_Click(object sender, EventArgs e)
        {
            CReader rd = new CReader();
            rd.ID = txt_ma_Đgia.Text;
            rd.HovaTen = txt_ten_Đgia.Text;
            rd.GioiTinh = rdo_nam_Đgia.Checked;
            rd.NgaySinh = dtp_ngaysinh_ĐGia.Value;
            rd.DiaChi = txt_diachi_Đgia.Text;
            if (int.TryParse(txt_sdt_ĐGia.Text, out int sdt) && sdt != 0)
            {
                rd.Sdt = sdt;
                if (xuly.EditList(rd))
                {
                    HienThi(xuly.GetValues());
                }
                else
                {
                    MessageBox.Show("Không sửa được độc giả này!");
                }
            }
            else
            {
                MessageBox.Show("Số điện thoại không hợp lệ!");
            }
        }
        private void bt_xoa_Đgia_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in dgv_Đgia.SelectedRows)
            {
                String ma = r.Cells["MaDG"].Value.ToString();
                if (xuly.DeleteList(ma) == true) break;
            } 
            HienThi(xuly.GetValues());
        }
        private void dgv_Đgia_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in dgv_Đgia.SelectedRows)
            {
                String maso = r.Cells["MaDG"].Value.ToString();
                CReader rd = xuly.Find(maso);
                if(rd != null)
                {
                    txt_ma_Đgia.Text = rd.ID;
                    txt_ten_Đgia.Text = rd.HovaTen;
                    if (rd.GioiTinh == true) rdo_nam_Đgia.Checked = true;
                    else rdo_nu_Đgia.Checked = true;
                    dtp_ngaysinh_ĐGia.Value = rd.NgaySinh;
                    txt_diachi_Đgia.Text = rd.DiaChi;
                    txt_sdt_ĐGia.Text = rd.Sdt.ToString();
                    break;
                }
            }
        }
        private void dgv_Đgia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0 && e.RowIndex < dgv_Đgia.Rows.Count)
            {
                DataGridViewRow r = dgv_Đgia.Rows[e.RowIndex];
                if (r.Cells["MaDG"].Value != null)
                {
                    String maso = r.Cells["MaDG"].Value.ToString();
                    CReader rd = xuly.Find(maso);
                    if(rd != null)
                    {
                        txt_ma_Đgia.Text = rd.ID;
                        txt_ten_Đgia.Text = rd.HovaTen;
                        if (rd.GioiTinh == true) rdo_nam_Đgia.Checked = true;
                        else rdo_nu_Đgia.Checked = true;
                        dtp_ngaysinh_ĐGia.Value = rd.NgaySinh;
                        txt_diachi_Đgia.Text = rd.DiaChi;
                        txt_sdt_ĐGia.Text = rd.Sdt.ToString();
                    }
                }
            }
                
        }
        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void bt_timkiemĐgia_Click(object sender, EventArgs e)
        {
            if (rdo_madocgia_TimKiemĐG.Checked == true)
            {
                String key = txt_timkiemĐgia.Text.Trim();
                if (txt_timkiemĐgia.Text == "")
                {
                    MessageBox.Show("Nhập mã độc giả bạn muốn tìm kiếm!");
                    return;
                }
                else
                {
                    HienThi(xuly.GetValues());
                    foreach (DataGridViewRow row in dgv_Đgia.Rows)
                    {
                        // Kiểm tra nếu mã sách trong dòng đó trùng với key
                        if (row.Cells["MaDG"].Value != null &&
                            string.Equals(row.Cells["MaDG"].Value.ToString(), key, StringComparison.OrdinalIgnoreCase))
                        {
                            // Chọn dòng đó
                            row.Selected = true;
                            txt_timkiemĐgia.Clear();
                            return; // Dừng vòng lặp khi tìm thấy
                        }
                    }

                    // Hiển thị toàn bộ dữ liệu nếu không tìm thấy
                    MessageBox.Show("Không tìm thấy mã sách bạn muốn tìm!");
                    HienThi(xuly.GetValues());
                }
            }
            else if (rdo_tendocgia_TimKiemĐG.Checked == true)
            {
                // Tìm kiếm theo tên sách
                string key = txt_timkiemĐgia.Text.Trim();
                if (string.IsNullOrEmpty(key))
                {
                    MessageBox.Show("Nhập tên độc giả bạn muốn tìm kiếm!");
                    return;
                }

                // Duyệt qua từng dòng trong DataGridView
                HienThi(xuly.GetValues());
                foreach (DataGridViewRow row in dgv_Đgia.Rows)
                {
                    // Kiểm tra nếu tên sách trong dòng đó chứa key
                    if (row.Cells["TenDG"].Value != null &&
                        string.Equals(row.Cells["TenDG"].Value.ToString(), key, StringComparison.OrdinalIgnoreCase))
                    {
                        // Chọn dòng đó
                        row.Selected = true;
                        txt_timkiemĐgia.Clear();
                        return; // Dừng vòng lặp khi tìm thấy
                    }
                }

                // Hiển thị toàn bộ dữ liệu nếu không tìm thấy
                MessageBox.Show("Không tìm thấy tên sách!");
                HienThi(xuly.GetValues());
            }
        }
    }
}
