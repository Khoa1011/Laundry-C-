﻿using System;
using Đồ_án_mới.DAO;
using Đồ_án_mới.DTO;
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
    public partial class DichVu : Form
    {
        static DichVuDAO dvDAO = new DichVuDAO();
        static DataTable dt = new DataTable();
        public DichVu()
        {
            InitializeComponent();
            load();
        }
        public void load()
        {
            dt = dvDAO.findALL();
            dgv_DV.DataSource = dt;
        }
        private void bt_timkiem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("HIỆN TẠI CHƯA CÓ CHỨC NĂNG NÀY !!!");
        }

        private void bt_addDv_Click(object sender, EventArgs e)
        {
            try
            {
                DICHVU dv = new DICHVU();
                if (txt_nameDV.Text != "")
                {
                    dv.MoTaDichVu = txt_nameDV.Text;
                    dv.TongTienDichVu = double.Parse(txt_price.Text);
                    if (dvDAO.add(dv))
                    {
                        MessageBox.Show("Thêm thành công!!!");
                        load();
                    }
                    else MessageBox.Show("Thêm không thành công!!!");
                }
                else MessageBox.Show("Vui lòng không để trống!!!");

            }
            catch
            {
                MessageBox.Show("Vui lòng không để trống!!!");
            }
        }

        private void bt_deleteDV_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgv_DV[0, dgv_DV.CurrentRow.Index].Value.ToString());
            if (dvDAO.delete(id))
            {
                MessageBox.Show("Xóa thành công!!!");
                load();
            }
            else MessageBox.Show("Xóa không thành công!!!");
        }

        private void btn_UpdateDV_Click(object sender, EventArgs e)
        {
            try
            {
                DICHVU dv = new DICHVU();
                if (txt_nameDV.Text != "")
                {
                    dv.MoTaDichVu = txt_nameDV.Text;
                    dv.TongTienDichVu = double.Parse(txt_price.Text);
                    int id = int.Parse(dgv_DV[0, dgv_DV.CurrentRow.Index].Value.ToString());
                    if (dvDAO.update(dv, id))
                    {
                        MessageBox.Show("Sửa thành công!!!");
                        load();
                    }
                    else MessageBox.Show("Sửa không thành công!!!");
                }
                else MessageBox.Show("Vui lòng không để trống");
            }
            catch
            {
                MessageBox.Show("Vui lòng không để trống");
            }
        }

        private void dgv_DV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_nameDV.Text = dgv_DV[1, dgv_DV.CurrentRow.Index].Value.ToString();
            txt_price.Text = dgv_DV[2, dgv_DV.CurrentRow.Index].Value.ToString();
        }

        private void bt_back_QLMTS_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
