using Đồ_án_mới.Business;
using Doan;
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
    public partial class PhieuThuVien : Form
    {
        private CXuLyBorrowingReturn xuly;
        public PhieuThuVien()
        {
            InitializeComponent();
        }
        private void bt_back_QLMTS_Click(object sender, EventArgs e)
        {
            HeThong ht = new HeThong();
            ht.Show();
            this.Hide();
        }

        private void guna2ControlBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PhieuThuVien_Load(object sender, EventArgs e)
        {
            xuly = new CXuLyBorrowingReturn();
            dgv_taophieu.AutoGenerateColumns = false;
            //Hiển thị danh sách mã độc giả lên combobox
            HienThiReader(cbb_MaDGmuon, xuly.GetlistReader());
            //Hiển thị danh sách mã nhân viên lên combobox
            HienThiEmployee(cbb_NVlapphieu, xuly.GetlistEmployeeee());
            //Hiển thị danh sách sách trong thư viện lên combobox
            HienThiSach(cbb_sach_taophieu, xuly.GetBooks());
            //Hiển thị dữ liệu
            HienThi(xuly.GetValues());
        }
        private void HienThiSach(ComboBox cbo, LinkedList<CBook> b)
        {
            cbo.DisplayMember = "TenSach";
            cbo.ValueMember = "Name";
            cbo.DataSource = b.ToList();
        }
        private void HienThiReader(ComboBox cbo, LinkedList <CReader> rd)
        {
            cbo.DisplayMember = "ID";
            cbo.ValueMember = "ID";
            cbo.DataSource = rd.ToList();
        }
        private void HienThiEmployee(ComboBox cbo, LinkedList<CEmployee> ep)
        {
            cbo.DisplayMember = "ID";
            cbo.ValueMember = "ID";
            cbo.DataSource = ep.ToList();
        }
        private void HienThi(LinkedList<CBorrowing_Return> list)
        {
            BindingSource bd = new BindingSource();
            bd.DataSource = list;
            dgv_taophieu.DataSource = bd;
            

            txt_maphieu_lapphieu.Clear();
            cbb_MaDGmuon.SelectedItem = null;
            cbb_NVlapphieu.SelectedItem = null;
            cbb_sach_taophieu.SelectedItem = null;
            dtp_ngayMuon_lapphieu.Value = DateTime.Now;
        }
        private void bt_them_lapphieu_Click(object sender, EventArgs e)
        {

            //Kiểm tra mã phiếu
            if (String.IsNullOrEmpty(txt_maphieu_lapphieu.Text))
            {
                MessageBox.Show("Mã phiếu không được để trống!");
                return;
            }
            // Kiểm tra mã độc giả
            if (cbb_MaDGmuon.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn mã độc giả!");
                return;
            }

            // Kiểm tra mã NV lập phiếu 
            if (cbb_NVlapphieu.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn mã nhân viên lập phiếu!");
                return;
            }

            // Kiểm tra sách 
            if (cbb_sach_taophieu.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn sách muốn mượn!");
                return;
            }
            //Thông tin tạo phiếu
            CBorrowing_Return br = new CBorrowing_Return();
            br.ID = txt_maphieu_lapphieu.Text;
            br.BorrowedDay = dtp_ngayMuon_lapphieu.Value;
            // Mã nhân viên
            CEmployee ep = new CEmployee()
            {
                ID = cbb_NVlapphieu.Text
            };
            // Mã độc giả
            CReader rd = new CReader()
            {
                ID = cbb_MaDGmuon.Text
            };
            //Sách 
            CBook b = new CBook()
            {
                Name = cbb_sach_taophieu.Text
            };
            br.Book = b;
            br.Employee = ep;
            br.Reader = rd;

            if (xuly.AddList(br) == true)
            {
                HienThi(xuly.GetValues());
            }
            else MessageBox.Show("Tạo phiếu không thành công!");
        }
        private void bt_sua_lapphieu_Click(object sender, EventArgs e)
        {
            //Thông tin tạo phiếu
            CBorrowing_Return br = new CBorrowing_Return();
            br.ID = txt_maphieu_lapphieu.Text;
            br.BorrowedDay = dtp_ngayMuon_lapphieu.Value;
            // Mã nhân viên
            CEmployee ep = new CEmployee()
            {
                ID = cbb_NVlapphieu.Text
            };
            br.Employee = ep;

            // Mã độc giả
            CReader rd = new CReader()
            {
                ID = cbb_MaDGmuon.Text
            };
            br.Reader = rd;

            //Sách
            CBook b = new CBook()
            {
                Name = cbb_sach_taophieu.Text
            };
            br.Book = b;

            if (xuly.EditList(br) == true)
            {
                HienThi(xuly.GetValues());
            }
            else MessageBox.Show("Sửa phiếu không thành công!");
        }
        private void bt_xoa_lapphieu_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in dgv_taophieu.SelectedRows)
            {
                String maso = r.Cells["MaPhieu"].Value.ToString();
                if (xuly.DeleteList(maso) == true) break;
                else MessageBox.Show("Không xóa được phiếu!");
            }
            HienThi(xuly.GetValues()); 
        }
        private void bt_timkiem_Click(object sender, EventArgs e)
        {
            String key = txt_timkiemMaPhieu.Text.Trim();
            if (txt_timkiemMaPhieu.Text == "")
            {
                MessageBox.Show("Nhập mã phiếu bạn muốn tra cứu!");
                return;
            }
            else
            {
                foreach (DataGridViewRow r in dgv_taophieu.Rows)
                {
                    // Kiểm tra nếu mã sách trong dòng đó trùng với key
                    if (r.Cells["MaPhieu"].Value != null &&
                        string.Equals(r.Cells["MaPhieu"].Value.ToString(), key, StringComparison.OrdinalIgnoreCase))
                    {
                        // Chọn dòng đó
                        dgv_taophieu.Rows[r.Index].Selected = true;
                        HienThiTraCuu();
                        txt_timkiemMaPhieu.Clear();
                        return; // Dừng vòng lặp khi tìm thấy
                        
                    }
                }
                // Hiển thị toàn bộ dữ liệu nếu không tìm thấy
                MessageBox.Show("Không tìm thấy mã phiếu bạn muốn tìm!");
                HienThi(xuly.GetValues());
            }
        }
        private bool HienThiTraCuu()
        {
            int MaDGV = dgv_taophieu.Columns["MaPhieu"].Index;
            int NgayMuonDGV = dgv_taophieu.Columns["NgayMuon"].Index;
            int sachDGV = dgv_taophieu.Columns["Sach"].Index;

            foreach (DataGridViewRow r in dgv_taophieu.SelectedRows)
            {
                String Maphieu = r.Cells[MaDGV].Value.ToString();
                DateTime ngayMuon = Convert.ToDateTime(r.Cells[NgayMuonDGV].Value);
                if (r.Cells[sachDGV].Value != null)
                {
                    String Sach = r.Cells[sachDGV].Value.ToString();

                    // Lấy giá trị ngày trả từ dtp_NgayTra_TraCuu
                    DateTime reDay = dtp_NgayTra_TraCuu.Value;

                    // Tính số ngày quá hạn
                    CBorrowing_Return br = new CBorrowing_Return();
                    br.ReturnDay = reDay;
                    br.BorrowedDay = ngayMuon;
                    int kq = br.SoNgayMuon(br.ReturnDay, br.BorrowedDay);

                    // Kiểm tra số ngày quá hạn để đặt màu
                    if (kq > 7)
                    {
                        int index = dgv_TraCuu.Rows.Add(Maphieu, Sach, ngayMuon, reDay, kq);
                        dgv_TraCuu.Rows[index].Cells["TinhTrang"].Style.BackColor = Color.Red;
                        return true;
                    }
                    else if (kq < 0)
                    {
                        MessageBox.Show("Số ngày mượn hoặc số ngày trả không lệ. Vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    else
                    {
                        int index = dgv_TraCuu.Rows.Add(Maphieu, Sach, ngayMuon, reDay, kq);
                        dgv_TraCuu.Rows[index].Cells["TinhTrang"].Style.BackColor = Color.Green;
                        return true;
                    }
                }
                else MessageBox.Show("Độc giả này chưa mượn cuốn sách nào!");
            }
            return false;
        }
        private void bt_trasach_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có dòng được chọn trong dgv_TraCuu không

            if (dgv_TraCuu.SelectedRows.Count > 0)
            {
                string maPhieuTraCuu = dgv_TraCuu.SelectedRows[0].Cells["Ma"].Value.ToString();
                foreach (DataGridViewRow r in dgv_taophieu.SelectedRows)
                {
                    string maPhieu = r.Cells["MaPhieu"].Value.ToString();

                    if (string.Equals(maPhieu, maPhieuTraCuu, StringComparison.OrdinalIgnoreCase))
                    {

                        r.Cells["Sach"].Value = null;
                    }
                }
                HienThi(xuly.GetValues());
                dgv_TraCuu.Rows.Clear();
            }
            else MessageBox.Show("Vui lòng chọn phiếu mà bạn muốn trả!");
            
        }
        private void dgv_TraCuu_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in dgv_taophieu.SelectedRows)
            {
                String maso = r.Cells["MaPhieu"].Value.ToString();
                CBorrowing_Return br = xuly.Find(maso);
                if (br != null)
                {
                    txt_timkiemMaPhieu.Text = br.ID;
                    dtp_ngaymuon_TraCuu.Value = br.BorrowedDay;
                    dtp_NgayTra_TraCuu.Value = br.ReturnDay;
                    break;
                }
            }
        }
        private void dgv_taophieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgv_taophieu.Rows.Count)
            {
                DataGridViewRow r = dgv_taophieu.Rows[e.RowIndex];
                if (r.Cells["MaPhieu"].Value != null)
                {
                    String maso = r.Cells["MaPhieu"].Value.ToString();
                    CBorrowing_Return br = xuly.Find(maso);
                    if (br != null)
                    {
                        txt_maphieu_lapphieu.Text = br.ID;
                        cbb_MaDGmuon.SelectedValue = br.Reader.ToString();
                        cbb_NVlapphieu.SelectedValue = br.Employee.ToString();
                        if (br.Book != null)
                        {
                            cbb_sach_taophieu.SelectedValue = br.Book.ToString();
                        }
                        else cbb_sach_taophieu.SelectedItem = null;
                        dtp_ngayMuon_lapphieu.Value = br.BorrowedDay;
                    }
                }
            }
        }
        private void dgv_taophieu_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in dgv_taophieu.SelectedRows)
            {
                String maso = r.Cells["Manv"].Value.ToString();
                CBorrowing_Return br = xuly.Find(maso);
                if (br != null)
                {
                    txt_maphieu_lapphieu.Text = br.ID;
                    cbb_MaDGmuon.SelectedValue = br.Reader.ToString();
                    cbb_NVlapphieu.SelectedValue = br.Employee.ToString();
                    if (br.Book != null)
                    {
                        cbb_sach_taophieu.SelectedValue = br.Book.ToString();
                    }
                    else cbb_sach_taophieu.SelectedItem = null;
                    dtp_ngayMuon_lapphieu.Value = br.BorrowedDay;
                    break;
                }
            }
        }
        private void bt_timkiem_taophieu_Click(object sender, EventArgs e)
        {
            String key = txt_maphieu_lapphieu.Text.Trim();
            if (key == "")
            {
                MessageBox.Show("Nhập mã phiếu bạn muốn tìm kiếm!");
                return;
            }
            else
            {
                HienThi(xuly.GetValues());
                foreach (DataGridViewRow row in dgv_taophieu.Rows)
                {
                    // Kiểm tra nếu mã sách trong dòng đó trùng với key
                    if (row.Cells["MaPhieu"].Value != null &&
                        string.Equals(row.Cells["MaPhieu"].Value.ToString(), key, StringComparison.OrdinalIgnoreCase))
                    {
                        // Chọn dòng đó
                        row.Selected = true;
                        txt_maphieu_lapphieu.Clear();
                        return; // Dừng vòng lặp khi tìm thấy
                    }
                }

                // Hiển thị toàn bộ dữ liệu nếu không tìm thấy
                MessageBox.Show("Không tìm thấy mã nhân viên bạn muốn tìm!");
                HienThi(xuly.GetValues());
            }
        }
    }
}
