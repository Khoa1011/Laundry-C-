using Đồ_án_mới.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using static Guna.UI2.Native.WinApi;

namespace Doan
{
    public partial class QuanLySach : Form
    {
        private CXuLyBook xuly;
        
        public QuanLySach()
        {
            InitializeComponent();
        }
        private void QuanLySach_Load(object sender, EventArgs e)
        {
            xuly = new CXuLyBook();
            dgv_QLS.AutoGenerateColumns = false;
            //Hiển thị danh sách tác giả lên combobox
            HienThiAuthor(cbb_TenTacGia_QLS, xuly.getListAuthor());
            //Hiển thị danh sách nhà xuất bản lên combobox
            HienThiPublisher(cbb_TenNXB_QLS, xuly.getListPublisher());
            HienThi(xuly.GetValues());
        }
        private void HienThi(LinkedList<CBook> list)
        {
             BindingSource bd = new BindingSource();
             bd.DataSource = list;
             dgv_QLS.DataSource = bd;

            txt_masach_QLS.Clear();
            txt_tensach_QLS.Clear();
            txt_tenTheLoai_QLS.Clear();
            txt_SoLuong_QLS.Clear();
            cbb_TenTacGia_QLS.SelectedItem = null;
            cbb_TenNXB_QLS.SelectedItem = null;
            dtp_NamXuatBan_QLS.Value = DateTime.Now;
        }
        private void HienThiAuthor(ComboBox cbo,LinkedList <CAuthor> at)
        {
            cbo.DisplayMember = "HovaTen";
            cbo.ValueMember = "TenTG";
            cbo.DataSource = at.ToList();
        }
        private void HienThiPublisher(ComboBox cbo,LinkedList <CPublisher> pl)
        {
            cbo.DisplayMember = "HovaTen";
            cbo.ValueMember = "MaNXB";
            cbo.DataSource = pl.ToList();
        }
        private void bt_back_QLS_Click(object sender, EventArgs e)
        {
            HeThong f = new HeThong();
            f.Show();
            this.Hide();
        }
        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void bt_them_QLS_Click(object sender, EventArgs e)
        {
            //Kiểm tra mã sách
            if (String.IsNullOrEmpty(txt_masach_QLS.Text))
            {
                MessageBox.Show("Mã sách không được để trống!");
                return;
            }
            //Kiểm tra tên sách
            if (String.IsNullOrEmpty(txt_tensach_QLS.Text))
            {
                MessageBox.Show("Tên sách không được để trống!");
                return;
            }
            //Kiểm tra tên thể loại sách
            if (String.IsNullOrEmpty(txt_tenTheLoai_QLS.Text))
            {
                MessageBox.Show("Tên thể loại sách không được để trống!");
                return;
            }

            //Kiểm tra tên tác giả
            if(cbb_TenTacGia_QLS.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn tên tác giả cho cuốn sách!");
                return;
            }
            //Kiểm tra tên NXB
            if (cbb_TenNXB_QLS.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn tên nhà xuất bản cho cuốn sách!");
                return;
            }
            //Thông tin sách
            CBook b = new CBook();
            b.ID = txt_masach_QLS.Text;
            b.Name = txt_tensach_QLS.Text;
            b.Genre = txt_tenTheLoai_QLS.Text;
            b.Published_Date = dtp_NamXuatBan_QLS.Value;

            //Thông tin nhà xuất bản
            CPublisher publisher = new CPublisher
            {
                HovaTen = cbb_TenNXB_QLS.Text
            };

            // Tạo đối tượng tác giả
            CAuthor author = new CAuthor
            {
                HovaTen = cbb_TenTacGia_QLS.Text
            };

            // Gán nhà xuất bản và tác giả cho sách
            b.Publisher = publisher;
            b.Author = author;

            // Thêm sách vào danh sách
            if (int.TryParse(txt_SoLuong_QLS.Text, out int soluong) && soluong != 0)
            {
                b.Quantity = soluong;
                if (xuly.AddList(b))
                {
                    // Hiển thị danh sách sau khi thêm sách
                    HienThi(xuly.GetValues());
                }
                else
                {
                    MessageBox.Show("Không thêm được sách mới!");
                }                
            }
            else MessageBox.Show("Số lượng sách không hợp lệ!");
        }
        private void bt_sua_QLS_Click(object sender, EventArgs e)
        {
            //Thông tin sách
            CBook b = new CBook();
            b.ID = txt_masach_QLS.Text;
            b.Name = txt_tensach_QLS.Text;
            b.Genre = txt_tenTheLoai_QLS.Text;
            b.Published_Date = dtp_NamXuatBan_QLS.Value;

            //Thông tin nhà xuất bản
            CPublisher publisher = new CPublisher
            {
                HovaTen = cbb_TenNXB_QLS.Text
            };

            // Tạo đối tượng tác giả
            CAuthor author = new CAuthor
            {
                HovaTen = cbb_TenTacGia_QLS.Text
            };

            // Gán nhà xuất bản và tác giả cho sách
            b.Publisher = publisher;
            b.Author = author;

            // Thêm sách vào danh sách
            if (int.TryParse(txt_SoLuong_QLS.Text, out int soluong) && soluong != 0)
            {
                b.Quantity = soluong;
                if (xuly.EditList(b))
                {
                    // Hiển thị danh sách sau khi thêm sách
                    HienThi(xuly.GetValues());
                }
                else
                {
                    MessageBox.Show("Không sửa được sách mới!");
                }
            }
            else MessageBox.Show("Số lượng sách không hợp lệ!");
        }
        private void bt_xoa_QLS_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow r in dgv_QLS.SelectedRows)
            {
                String maso = r.Cells["MaSach"].Value.ToString();
                if (xuly.DeleteList(maso) == true) break;
                else MessageBox.Show("Không xóa được sách!");
            }
            HienThi(xuly.GetValues());
        }
        private void dgv_QLS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgv_QLS.Rows.Count)
            {
                DataGridViewRow r = dgv_QLS.Rows[e.RowIndex];
                if (r.Cells["MaSach"].Value != null)
                {
                    String maso = r.Cells["MaSach"].Value.ToString();
                    CBook b = xuly.Find(maso);
                    if (b != null)
                    {
                        txt_masach_QLS.Text = b.ID;
                        txt_tensach_QLS.Text = b.Name;
                        txt_tenTheLoai_QLS.Text = b.Genre;
                        dtp_NamXuatBan_QLS.Value = b.Published_Date;
                        txt_SoLuong_QLS.Text = b.Quantity.ToString();
                        cbb_TenNXB_QLS.SelectedItem = b.Publisher;
                        cbb_TenTacGia_QLS.SelectedItem = b.Author;
                    }
                }
            }
        }
        private void dgv_QLS_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in dgv_QLS.SelectedRows)
            {
                String maso = r.Cells["MaSach"].Value.ToString();
                CBook b = xuly.Find(maso);
                if (b != null)
                {
                    txt_masach_QLS.Text = b.ID;
                    txt_tensach_QLS.Text = b.Name;
                    txt_tenTheLoai_QLS.Text = b.Genre;
                    dtp_NamXuatBan_QLS.Value = b.Published_Date;
                    txt_SoLuong_QLS.Text = b.Quantity.ToString();
                    cbb_TenNXB_QLS.SelectedItem = b.Publisher;
                    cbb_TenTacGia_QLS.SelectedItem = b.Author;
                    break;
                }
            }
        }
        private void bt_tim_QLS_Click(object sender, EventArgs e)
        {
            if (rdo_masach_QLS.Checked == true)
            {
                String key = txt_tim_QLS.Text.Trim();
                if (txt_tim_QLS.Text == "")
                {
                    MessageBox.Show("Nhập mã sách bạn muốn tìm kiếm!");
                    return;
                }
                else
                {
                    HienThi(xuly.GetValues());
                    foreach (DataGridViewRow row in dgv_QLS.Rows)
                    {
                        // Kiểm tra nếu mã sách trong dòng đó trùng với key
                        if (row.Cells["MaSach"].Value != null &&
                            string.Equals(row.Cells["MaSach"].Value.ToString(), key, StringComparison.OrdinalIgnoreCase))
                        {
                            // Chọn dòng đó
                            row.Selected = true;
                            txt_tim_QLS.Clear();
                            return; // Dừng vòng lặp khi tìm thấy
                        }
                    }

                    // Hiển thị toàn bộ dữ liệu nếu không tìm thấy
                    MessageBox.Show("Không tìm thấy mã sách bạn muốn tìm!");
                    HienThi(xuly.GetValues());
                }
            }
            else if (rdo_tensach_QLS.Checked==true)
            {
                // Tìm kiếm theo tên sách
                string key = txt_tim_QLS.Text.Trim();
                if (string.IsNullOrEmpty(key))
                {
                    MessageBox.Show("Nhập tên sách bạn muốn tìm kiếm!");
                    return;
                }

                // Duyệt qua từng dòng trong DataGridView
                HienThi(xuly.GetValues());
                foreach (DataGridViewRow row in dgv_QLS.Rows)
                {
                    // Kiểm tra nếu tên sách trong dòng đó chứa key
                    if (row.Cells["TenSach"].Value != null &&
                        string.Equals(row.Cells["TenSach"].Value.ToString(), key, StringComparison.OrdinalIgnoreCase))
                    {
                        // Chọn dòng đó
                        row.Selected = true;
                        txt_tim_QLS.Clear();
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
