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
    public partial class NhaXuatBan : Form
    {
        private CXuLyPublisher xuly;
        public NhaXuatBan()
        {
            InitializeComponent();
        }
        private void bt_back_NXB_Click(object sender, EventArgs e)
        {
            HeThong f = new HeThong();
            f.Show();
            this.Hide();
        }
        private void guna2ControlBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void NhaXuatBan_Load(object sender, EventArgs e)
        {
            xuly = new CXuLyPublisher();
            dgv_NXB.AutoGenerateColumns = false;
            HienThi(xuly.GetValues());
        }
        private void HienThi(LinkedList <CPublisher> list)
        {
            BindingSource bd = new BindingSource();
            bd.DataSource = list;
            dgv_NXB.DataSource = bd;


            txt_maNXB_NXB.Clear();
            txt_tenNXB_NXB.Clear();
            txt_sdtNXB_NXB.Clear();
            txt_diachiNXB_NXB.Clear();
        }
        private void bt_them_NXB_Click(object sender, EventArgs e)
        {
            //Kiểm tra mã NXB có trống hay không
            if (String.IsNullOrEmpty(txt_maNXB_NXB.Text))
            {
                MessageBox.Show("Mã NXB không được để trống!");
                return;
            }

            //Kiểm tra tên NXB có trống hay không
            if (String.IsNullOrEmpty(txt_tenNXB_NXB.Text))
            {
                MessageBox.Show("Tên NXB không được để trống!");
                return;
            }
            //Kiểm tra địa chỉ NXB có trống hay không
            if (String.IsNullOrEmpty(txt_diachiNXB_NXB.Text))
            {
                MessageBox.Show("Địa chỉ NXB không được để trống!");
                return;
            }
            CPublisher pl = new CPublisher();
            pl.ID = txt_maNXB_NXB.Text;
            pl.HovaTen = txt_tenNXB_NXB.Text;
            pl.NgaySinh = dtp_NamThanhLap_NXB.Value;
            pl.DiaChi = txt_diachiNXB_NXB.Text;

            if (int.TryParse(txt_sdtNXB_NXB.Text, out int sdt) && sdt != 0)
            {
                pl.Sdt = sdt;
                if (xuly.AddList(pl) == true)
                {
                    HienThi(xuly.GetValues());
                }
                else MessageBox.Show("Không thêm được nhà xuất bản mới!");
            }
            else MessageBox.Show("Số điện thoại không hợp lệ!");
        }
        private void bt_sua_NXB_Click(object sender, EventArgs e)
        {
            CPublisher pl = new CPublisher();
            pl.ID = txt_maNXB_NXB.Text;
            pl.HovaTen = txt_tenNXB_NXB.Text;
            pl.NgaySinh = dtp_NamThanhLap_NXB.Value;
            pl.DiaChi = txt_diachiNXB_NXB.Text;

            if (int.TryParse(txt_sdtNXB_NXB.Text, out int sdt) && sdt != 0)
            {
                pl.Sdt = sdt;
                if (xuly.EditList(pl) == true)
                {
                    HienThi(xuly.GetValues());
                }
                else MessageBox.Show("Không sửa được nhà xuất bản mới!");
            }
            else MessageBox.Show("Số điện thoại không hợp lệ!");
        }
        private void bt_xoa_NXB_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in dgv_NXB.SelectedRows)
            {
                String maso = r.Cells["MaNXB"].Value.ToString();
                if (xuly.DeleteList(maso) == true)
                    HienThi(xuly.GetValues());
                else MessageBox.Show("Không xóa được nhà xuất bản này!");
            }
        }
        private void dgv_NXB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgv_NXB.Rows.Count) // Kiểm tra xem có click vào dòng hợp lệ không
            {
                
                DataGridViewRow r = dgv_NXB.Rows[e.RowIndex];

                if (r.Cells["MaNXB"].Value != null)
                {
                    String maso = r.Cells["MaNXB"].Value.ToString();
                    CPublisher pl = xuly.Find(maso);

                    if (pl != null)
                    {
                        txt_maNXB_NXB.Text = pl.ID;
                        txt_tenNXB_NXB.Text = pl.HovaTen;
                        txt_diachiNXB_NXB.Text = pl.DiaChi;
                        txt_sdtNXB_NXB.Text = pl.Sdt.ToString();
                        dtp_NamThanhLap_NXB.Value = pl.NgaySinh;
                    }
                }
            }
        }
        private void dgv_NXB_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in dgv_NXB.SelectedRows)
            {
                String maso = r.Cells["MaNXB"].Value.ToString();
                CPublisher pl = xuly.Find(maso);
                if (pl != null)
                {
                    txt_maNXB_NXB.Text = pl.ID;
                    txt_tenNXB_NXB.Text = pl.HovaTen;
                    txt_diachiNXB_NXB.Text = pl.DiaChi;
                    txt_sdtNXB_NXB.Text = pl.Sdt.ToString();
                    dtp_NamThanhLap_NXB.Value = pl.NgaySinh;
                    break;
                }
            }
        }
        private void bt_timkiem_Click(object sender, EventArgs e)
        {
            if (rdo_ma.Checked == true)
            {
                String key = txt_timkiem.Text.Trim();
                if (txt_timkiem.Text == "")
                {
                    MessageBox.Show("Nhập mã nhà xuất bản bạn muốn tìm kiếm!");
                    return;
                }
                else
                {
                    HienThi(xuly.GetValues());
                    foreach (DataGridViewRow row in dgv_NXB.Rows)
                    {
                        // Kiểm tra nếu mã sách trong dòng đó trùng với key
                        if (row.Cells["MaNXB"].Value != null &&
                            string.Equals(row.Cells["MaNXB"].Value.ToString(), key, StringComparison.OrdinalIgnoreCase))
                        {
                            // Chọn dòng đó
                            row.Selected = true;
                            txt_timkiem.Clear();
                            return; // Dừng vòng lặp khi tìm thấy
                        }
                    }

                    // Hiển thị toàn bộ dữ liệu nếu không tìm thấy
                    MessageBox.Show("Không tìm thấy mã nhà xuất bản bạn muốn tìm!");
                    HienThi(xuly.GetValues());
                }
            }
            else if (rdo_ten.Checked == true)
            {
                // Tìm kiếm theo tên sách
                string key = txt_timkiem.Text.Trim();
                if (string.IsNullOrEmpty(key))
                {
                    MessageBox.Show("Nhập tên nhà xuất bản bạn muốn tìm kiếm!");
                    return;
                }

                // Duyệt qua từng dòng trong DataGridView
                HienThi(xuly.GetValues());
                foreach (DataGridViewRow row in dgv_NXB.Rows)
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
                MessageBox.Show("Không tìm thấy tên nhà xuất bản!");
                HienThi(xuly.GetValues());
            }
        }
    }
}
