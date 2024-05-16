using Đồ_án_mới.Business;
using Doan;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Đồ_án_mới.Presentation
{
    public partial class NhanVien : Form
    {
        private CXuLyEmployee xuly;
        public NhanVien()
        {
            InitializeComponent();
        }

        private void NhanVien1_Load(object sender, EventArgs e)
        {
            xuly = new CXuLyEmployee();
            dgv_NV.AutoGenerateColumns = false;
            HienThi(xuly.GetValues());
        }
        private void HienThi(LinkedList<CEmployee> list)
        {
            BindingSource bd = new BindingSource();
            bd.DataSource = list;
            dgv_NV.DataSource = bd;

            txt_ma_NV.Clear();
            txt_ten_NV.Clear();
            dtp_ngaysinh_NV.Value = DateTime.Now;
            txt_diachi_NV.Clear();
            txt_sdt_NV.Clear();
            cbb_chucvu_nv.SelectedItem = null;
        }
        private void bt_them_NV_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem mã nhân viên có giá trị không
            if (string.IsNullOrEmpty(txt_ma_NV.Text))
            {
                MessageBox.Show("Mã nhân viên không được để trống!");
                return;
            }

            // Kiểm tra xem họ và tên có giá trị không
            if (string.IsNullOrEmpty(txt_ten_NV.Text))
            {
                MessageBox.Show("Họ và tên không được để trống!");
                return;
            }

            // Kiểm tra xem địa chỉ có giá trị không
            if (string.IsNullOrEmpty(txt_diachi_NV.Text))
            {
                MessageBox.Show("Địa chỉ không được để trống!");
                return;
            }
            CEmployee ep = new CEmployee();
            ep.ID = txt_ma_NV.Text;
            ep.HovaTen = txt_ten_NV.Text;
            ep.NgaySinh = dtp_ngaysinh_NV.Value;
            ep.DiaChi = txt_diachi_NV.Text;

            //Kiểm tra số điện thoại phải khác 0
            if (int.TryParse(txt_sdt_NV.Text, out int sdtnv) && sdtnv != 0)
            {
                ep.Sdt = sdtnv;

                // Kiểm tra giá trị của ChucVu
                if (!String.IsNullOrEmpty(cbb_chucvu_nv.SelectedItem?.ToString()))
                {
                    ep.ChucVu = cbb_chucvu_nv.SelectedItem.ToString();

                    if (xuly.AddList(ep))
                    {
                        HienThi(xuly.GetValues());
                    }
                    else
                    {
                        MessageBox.Show("Không thêm được nhân viên mới!");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng lựa chọn chức vụ cho nhân viên!");
                }
            }
            else
            {
                MessageBox.Show("Số điện thoại không hợp lệ!");
            }
        }
        private void bt_sua_NV_Click(object sender, EventArgs e)
        {
            CEmployee ep = new CEmployee();
            ep.ID = txt_ma_NV.Text;
            ep.HovaTen = txt_ten_NV.Text;
            ep.NgaySinh = dtp_ngaysinh_NV.Value;
            ep.DiaChi = txt_diachi_NV.Text;
            if (int.TryParse(txt_sdt_NV.Text, out int sdtnv) && sdtnv != 0)
            {
                ep.Sdt = sdtnv;

                // Kiểm tra giá trị của ChucVu
                if (!String.IsNullOrEmpty(cbb_chucvu_nv.SelectedItem?.ToString()))
                {
                    ep.ChucVu = cbb_chucvu_nv.SelectedItem.ToString();

                    if (xuly.EditList(ep))
                    {
                        HienThi(xuly.GetValues());
                    }
                    else
                    {
                        MessageBox.Show("Không sửa được nhân viên mới!");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng lựa chọn chức vụ cho nhân viên!");
                }
            }
            else
            {
                MessageBox.Show("Số điện thoại không hợp lệ!");
            }
        }
        private void bt_xoa_NV_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in dgv_NV.SelectedRows)
            {
                String ma = r.Cells["MaNV"].Value.ToString();
                if (xuly.DeleteList(ma) == true) break;
                else MessageBox.Show("Không xóa được nhân viên!");
            }
            HienThi(xuly.GetValues());
        }
        private void bt_back_NV_Click(object sender, EventArgs e)
        {
            HeThong ht = new HeThong();
            ht.Show();
            this.Hide();
        }
        private void guna2ControlBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void dgv_NV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgv_NV.Rows.Count)
            {
                DataGridViewRow r = dgv_NV.Rows[e.RowIndex];
                if (r.Cells["MaNV"].Value != null)
                {
                    String maso = r.Cells["MaNV"].Value.ToString();
                    CEmployee ep = xuly.Find(maso);
                    if (ep != null)
                    {
                        txt_ma_NV.Text = ep.ID;
                        txt_ten_NV.Text = ep.HovaTen;
                        if (ep.GioiTinh == true) rdo_nam_NV.Checked = true;
                        else rdo_nu_NV.Checked = true;
                        dtp_ngaysinh_NV.Value = ep.NgaySinh;
                        txt_diachi_NV.Text = ep.DiaChi;
                        txt_sdt_NV.Text = ep.Sdt.ToString();
                        cbb_chucvu_nv.SelectedItem = ep.ChucVu;
                    }
                }
            }
        }
        private void dgv_NV_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in dgv_NV.SelectedRows)
            {
                String maso = r.Cells["Manv"].Value.ToString();
                CEmployee ep = xuly.Find(maso);
                if (ep != null)
                {
                    txt_ma_NV.Text = ep.ID;
                    txt_ten_NV.Text = ep.HovaTen;
                    if (ep.GioiTinh == true) rdo_nam_NV.Checked = true;
                    else rdo_nu_NV.Checked = true;
                    dtp_ngaysinh_NV.Value = ep.NgaySinh;
                    txt_diachi_NV.Text = ep.DiaChi;
                    txt_sdt_NV.Text = ep.Sdt.ToString();
                    cbb_chucvu_nv.SelectedItem = ep.ChucVu;
                    break;
                }
            }
        }
        private void bt_timkiem_Click(object sender, EventArgs e)
        {
            if (rdo_Ma.Checked == true)
            {
                String key = txt_timkiem.Text.Trim();
                if (txt_timkiem.Text == "")
                {
                    MessageBox.Show("Nhập mã nhân viên bạn muốn tìm kiếm!");
                    return;
                }
                else
                {
                    HienThi(xuly.GetValues());
                    foreach (DataGridViewRow row in dgv_NV.Rows)
                    {
                        // Kiểm tra nếu mã sách trong dòng đó trùng với key
                        if (row.Cells["MaNV"].Value != null &&
                            string.Equals(row.Cells["MaNV"].Value.ToString(), key, StringComparison.OrdinalIgnoreCase))
                        {
                            // Chọn dòng đó
                            row.Selected = true;
                            txt_timkiem.Clear();
                            return; // Dừng vòng lặp khi tìm thấy
                        }
                    }

                    // Hiển thị toàn bộ dữ liệu nếu không tìm thấy
                    MessageBox.Show("Không tìm thấy mã nhân viên bạn muốn tìm!");
                    HienThi(xuly.GetValues());
                }
            }
            else if (rdo_Ten.Checked == true)
            {
                // Tìm kiếm theo tên sách
                string key = txt_timkiem.Text.Trim();
                if (string.IsNullOrEmpty(key))
                {
                    MessageBox.Show("Nhập tên nhân viên bạn muốn tìm kiếm!");
                    return;
                }

                // Duyệt qua từng dòng trong DataGridView
                HienThi(xuly.GetValues());
                foreach (DataGridViewRow row in dgv_NV.Rows)
                {
                    // Kiểm tra nếu tên sách trong dòng đó chứa key
                    if (row.Cells["TenNV"].Value != null &&
                        string.Equals(row.Cells["TenNV"].Value.ToString(), key, StringComparison.OrdinalIgnoreCase))
                    {
                        // Chọn dòng đó
                        row.Selected = true;
                        txt_timkiem.Clear();
                        return; // Dừng vòng lặp khi tìm thấy
                    }
                }

                // Hiển thị toàn bộ dữ liệu nếu không tìm thấy
                MessageBox.Show("Không tìm thấy tên nhân viên!");
                HienThi(xuly.GetValues());
            }
        }
    }
}
