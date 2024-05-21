using Đồ_án_mới.DAO;
using Đồ_án_mới.DTO;
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
    public partial class ChiTietHoaDon : Form
    {
        static ChiTietHoaDonDAO hdDAO = new ChiTietHoaDonDAO();
        static DichVuDAO dvDAO = new DichVuDAO();
        static DataTable dt = new DataTable();
        public ChiTietHoaDon()
        {
            InitializeComponent();
            load();
            Combobox();
        }
        public void load()
        {
            dt = hdDAO.findALL();
            dgv_HD.DataSource = dt;
        }
        public void Combobox()
        {
            DataTable dt = hdDAO.loadComboBoxDichVu();
            cb_hdDV.DataSource = dt;
            cb_hdDV.DisplayMember = "MOTA_DICHVU";
            cb_hdDV.ValueMember = "MA_DICHVU";

        }
        public Double totalPrice(int sl, double price)
        {
            double total = 0.0;
            total = price * sl ;
            return total;
        }
        private void bt_back_QLMTS_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void guna2ControlBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_eHD_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Parse(dgv_HD[0, dgv_HD.CurrentRow.Index].Value.ToString());
            int idKH = int.Parse(dgv_HD[1, dgv_HD.CurrentRow.Index].Value.ToString());
            XuatHD xuatHD = new XuatHD();
            xuatHD.LoadData(idKH, dt);
            xuatHD.ShowDialog(); 
        }

        private void bt_addHD_Click(object sender, EventArgs e)
        {
            try
            {
                KHACHHANG kh = new KHACHHANG();
                CHITIETHOADON hd = new CHITIETHOADON();

                //Khach hang
                if (txt_nameKH.Text != "" || txt_anddressKH.Text != "" || txt_anddressKH.Text != "")
                {
                    kh.Ten = txt_nameKH.Text;
                    kh.Tuoi = int.Parse(txt_ageKH.Text);
                    kh.DiaChi = txt_anddressKH.Text;
                    kh.SoDienThoai = txt_sdtKH.Text;
                    if (rdo_namKH.Checked)
                    {
                        kh.GioiTinh = "Nam";
                    }
                    if (rdo_nuKH.Checked)
                    {
                        kh.GioiTinh = "Nu";
                    }
                    //Hoa Don 
                    int idDV = int.Parse(cb_hdDV.SelectedValue.ToString());
                    hd.NgayHoaDon = dt_dateHD.Value.Date;
                    hd.SoLuongDichVu = int.Parse(txt_countDV.Text);
                    hd.TongTienHoaDon = totalPrice(int.Parse(txt_countDV.Text), dvDAO.getPrice(idDV));
                    if (hdDAO.addHD(hd, kh, idDV))
                    {
                        MessageBox.Show("Tạo hóa đơn thành công");
                        load();
                    }
                    else MessageBox.Show("Không thể tạo hóa đơn!");
                }
                else MessageBox.Show("Vui lòng không để trống");
            }
            catch
            {
                MessageBox.Show("Vui lòng không để trống");
            }
        }

        private void dgv_HD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //txt_nameKH.Text = dgv_HD[1, dgv_HD.CurrentRow.Index].Value.ToString();
            //txt_ageKH.Text = dgv_HD[2, dgv_HD.CurrentRow.Index].Value.ToString();
            //txt_anddressKH.Text = dgv_HD[4, dgv_HD.CurrentRow.Index].Value.ToString();
            //txt_sdtKH.Text = dgv_HD[5, dgv_HD.CurrentRow.Index].Value.ToString();
            //if (dgv_HD[3, dgv_HD.CurrentRow.Index].Value.ToString().Equals("Nam") || dgv_HD[3, dgv_HD.CurrentRow.Index].Value.ToString().Equals("nam"))
            //{
            //    rdo_namKH.Checked = true;

            //}
            //else if (dgv_HD[3, dgv_HD.CurrentRow.Index].Value.ToString().Equals("Nu") || dgv_HD[3, dgv_HD.CurrentRow.Index].Value.ToString().Equals("nu"))
            //    rdo_nuKH.Checked = true;
        }

        private void bt_deleteHD_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Parse(dgv_HD[0, dgv_HD.CurrentRow.Index].Value.ToString());
            int idKH = int.Parse(dgv_HD[1, dgv_HD.CurrentRow.Index].Value.ToString());
            int idDV = hdDAO.getIdDV(dgv_HD[3, dgv_HD.CurrentRow.Index].Value.ToString());
            if (hdDAO.deleteHD(idKH, idDV, dt)){
                MessageBox.Show("Xóa thành công!");
                load();
            }
            else MessageBox.Show("Xóa không thành công!");
        }

        private void bt_timkiem_Click(object sender, EventArgs e)
        {
            DataTable dt = null;
            dt = hdDAO.findBySDT(txt_findSDT.Text);
            if (dt.Rows.Count >0)
            {
                dgv_HD.DataSource = dt;
            }
            else MessageBox.Show("Không tìm thấy");
        }

        private void dt_dateHD_ValueChanged(object sender, EventArgs e)
        {
            try { }
            catch
            {
                MessageBox.Show("Không tìm thấy");
            }
        }
    }
}
