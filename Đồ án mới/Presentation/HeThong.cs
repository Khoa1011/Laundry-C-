using Đồ_án_mới.Business;
using Đồ_án_mới.Presentation;
using System;
using System.CodeDom;
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
    public partial class HeThong : Form
    {
        public HeThong()
        {
            InitializeComponent();
        }
        private void HeThong_FormClosing(object sender, FormClosingEventArgs e)
        {
            CTruyCapDuLieu.WriteFile();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void HeThong_Load(object sender, EventArgs e)
        {
            
        }
        private Form currentFormChild;

        private void OpenChildForm (Form childForm)
        {
            if(currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelBody.Controls.Add(childForm);
            panelBody.Tag = childForm;
            childForm.BringToFront();
            childForm.Show(); 
        }

        private void btn_donhang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DocGia());
            lbl_title.Text = btn_donhang.Text;
        }
    }
}
