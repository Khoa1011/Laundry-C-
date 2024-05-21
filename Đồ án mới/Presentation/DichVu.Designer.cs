namespace Đồ_án_mới.Presentation
{
    partial class DichVu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label8 = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_addDv = new Guna.UI2.WinForms.Guna2Button();
            this.bt_timkiem = new Guna.UI2.WinForms.Guna2Button();
            this.txt_nameDV = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_price = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.bt_deleteDV = new Guna.UI2.WinForms.Guna2Button();
            this.btn_UpdateDV = new Guna.UI2.WinForms.Guna2Button();
            this.bt_back_QLMTS = new Guna.UI2.WinForms.Guna2Button();
            this.dgv_DV = new System.Windows.Forms.DataGridView();
            this.MaDocGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2GroupBox1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DV)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Image = global::Đồ_án_mới.Properties.Resources.borrwing_45;
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label8.Location = new System.Drawing.Point(266, 9);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(353, 40);
            this.label8.TabIndex = 76;
            this.label8.Text = "QUẢN LÝ DỊCH VỤ";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.groupBox1);
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(12, 66);
            this.guna2GroupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(827, 258);
            this.guna2GroupBox1.TabIndex = 77;
            this.guna2GroupBox1.Text = "Thông tin";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.bt_addDv);
            this.groupBox1.Controls.Add(this.bt_timkiem);
            this.groupBox1.Controls.Add(this.txt_nameDV);
            this.groupBox1.Controls.Add(this.txt_price);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.bt_deleteDV);
            this.groupBox1.Controls.Add(this.btn_UpdateDV);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 13F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
            this.groupBox1.Location = new System.Drawing.Point(48, 42);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(737, 204);
            this.groupBox1.TabIndex = 76;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dịch Vụ";
            // 
            // bt_addDv
            // 
            this.bt_addDv.Animated = true;
            this.bt_addDv.AutoRoundedCorners = true;
            this.bt_addDv.BorderRadius = 16;
            this.bt_addDv.BorderThickness = 2;
            this.bt_addDv.CustomImages.Image = global::Đồ_án_mới.Properties.Resources.add;
            this.bt_addDv.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bt_addDv.CustomImages.ImageSize = new System.Drawing.Size(30, 30);
            this.bt_addDv.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bt_addDv.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bt_addDv.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bt_addDv.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bt_addDv.FillColor = System.Drawing.Color.White;
            this.bt_addDv.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.bt_addDv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bt_addDv.Location = new System.Drawing.Point(165, 155);
            this.bt_addDv.Margin = new System.Windows.Forms.Padding(2);
            this.bt_addDv.Name = "bt_addDv";
            this.bt_addDv.Size = new System.Drawing.Size(97, 34);
            this.bt_addDv.TabIndex = 90;
            this.bt_addDv.Text = "Thêm";
            this.bt_addDv.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.bt_addDv.Click += new System.EventHandler(this.bt_addDv_Click);
            // 
            // bt_timkiem
            // 
            this.bt_timkiem.Animated = true;
            this.bt_timkiem.AutoRoundedCorners = true;
            this.bt_timkiem.BackColor = System.Drawing.Color.White;
            this.bt_timkiem.BorderRadius = 16;
            this.bt_timkiem.BorderThickness = 2;
            this.bt_timkiem.CustomImages.Image = global::Đồ_án_mới.Properties.Resources.icons8_find_4005;
            this.bt_timkiem.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bt_timkiem.CustomImages.ImageSize = new System.Drawing.Size(30, 30);
            this.bt_timkiem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bt_timkiem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bt_timkiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bt_timkiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bt_timkiem.FillColor = System.Drawing.Color.White;
            this.bt_timkiem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.bt_timkiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bt_timkiem.Location = new System.Drawing.Point(563, 55);
            this.bt_timkiem.Margin = new System.Windows.Forms.Padding(2);
            this.bt_timkiem.Name = "bt_timkiem";
            this.bt_timkiem.Size = new System.Drawing.Size(120, 34);
            this.bt_timkiem.TabIndex = 69;
            this.bt_timkiem.Text = "Tìm kiếm";
            this.bt_timkiem.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.bt_timkiem.Click += new System.EventHandler(this.bt_timkiem_Click);
            // 
            // txt_nameDV
            // 
            this.txt_nameDV.Animated = true;
            this.txt_nameDV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_nameDV.DefaultText = "";
            this.txt_nameDV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_nameDV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_nameDV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_nameDV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_nameDV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_nameDV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_nameDV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_nameDV.Location = new System.Drawing.Point(269, 55);
            this.txt_nameDV.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_nameDV.Name = "txt_nameDV";
            this.txt_nameDV.PasswordChar = '\0';
            this.txt_nameDV.PlaceholderText = "Nhập";
            this.txt_nameDV.SelectedText = "";
            this.txt_nameDV.Size = new System.Drawing.Size(253, 27);
            this.txt_nameDV.TabIndex = 89;
            // 
            // txt_price
            // 
            this.txt_price.Animated = true;
            this.txt_price.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_price.DefaultText = "";
            this.txt_price.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_price.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_price.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_price.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_price.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_price.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_price.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_price.Location = new System.Drawing.Point(269, 103);
            this.txt_price.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_price.Name = "txt_price";
            this.txt_price.PasswordChar = '\0';
            this.txt_price.PlaceholderText = "Nhập";
            this.txt_price.SelectedText = "";
            this.txt_price.Size = new System.Drawing.Size(253, 27);
            this.txt_price.TabIndex = 88;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(165, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 85;
            this.label1.Text = "Tên dịch vụ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(168, 110);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 20);
            this.label6.TabIndex = 66;
            this.label6.Text = "Đơn giá";
            // 
            // bt_deleteDV
            // 
            this.bt_deleteDV.Animated = true;
            this.bt_deleteDV.AutoRoundedCorners = true;
            this.bt_deleteDV.BackColor = System.Drawing.Color.White;
            this.bt_deleteDV.BorderRadius = 16;
            this.bt_deleteDV.BorderThickness = 2;
            this.bt_deleteDV.CustomImages.Image = global::Đồ_án_mới.Properties.Resources.icons8_remove_484;
            this.bt_deleteDV.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bt_deleteDV.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bt_deleteDV.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bt_deleteDV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bt_deleteDV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bt_deleteDV.FillColor = System.Drawing.Color.White;
            this.bt_deleteDV.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.bt_deleteDV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bt_deleteDV.Location = new System.Drawing.Point(424, 155);
            this.bt_deleteDV.Margin = new System.Windows.Forms.Padding(2);
            this.bt_deleteDV.Name = "bt_deleteDV";
            this.bt_deleteDV.Size = new System.Drawing.Size(101, 34);
            this.bt_deleteDV.TabIndex = 65;
            this.bt_deleteDV.Text = "Xóa";
            this.bt_deleteDV.TextOffset = new System.Drawing.Point(12, 0);
            this.bt_deleteDV.Click += new System.EventHandler(this.bt_deleteDV_Click);
            // 
            // btn_UpdateDV
            // 
            this.btn_UpdateDV.Animated = true;
            this.btn_UpdateDV.AutoRoundedCorners = true;
            this.btn_UpdateDV.BackColor = System.Drawing.Color.White;
            this.btn_UpdateDV.BorderRadius = 16;
            this.btn_UpdateDV.BorderThickness = 2;
            this.btn_UpdateDV.CustomImages.Image = global::Đồ_án_mới.Properties.Resources.icons8_edit_644;
            this.btn_UpdateDV.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_UpdateDV.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_UpdateDV.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_UpdateDV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_UpdateDV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_UpdateDV.FillColor = System.Drawing.Color.White;
            this.btn_UpdateDV.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btn_UpdateDV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_UpdateDV.Location = new System.Drawing.Point(293, 155);
            this.btn_UpdateDV.Margin = new System.Windows.Forms.Padding(2);
            this.btn_UpdateDV.Name = "btn_UpdateDV";
            this.btn_UpdateDV.Size = new System.Drawing.Size(101, 34);
            this.btn_UpdateDV.TabIndex = 64;
            this.btn_UpdateDV.Text = "Sửa";
            this.btn_UpdateDV.TextOffset = new System.Drawing.Point(12, 0);
            this.btn_UpdateDV.Click += new System.EventHandler(this.btn_UpdateDV_Click);
            // 
            // bt_back_QLMTS
            // 
            this.bt_back_QLMTS.Animated = true;
            this.bt_back_QLMTS.AutoRoundedCorners = true;
            this.bt_back_QLMTS.BorderRadius = 16;
            this.bt_back_QLMTS.BorderThickness = 2;
            this.bt_back_QLMTS.CustomImages.Image = global::Đồ_án_mới.Properties.Resources.icons8_u_turn_to_left_1005;
            this.bt_back_QLMTS.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bt_back_QLMTS.CustomImages.ImageSize = new System.Drawing.Size(30, 30);
            this.bt_back_QLMTS.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bt_back_QLMTS.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bt_back_QLMTS.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bt_back_QLMTS.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bt_back_QLMTS.FillColor = System.Drawing.Color.Transparent;
            this.bt_back_QLMTS.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.bt_back_QLMTS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bt_back_QLMTS.Location = new System.Drawing.Point(12, 15);
            this.bt_back_QLMTS.Margin = new System.Windows.Forms.Padding(2);
            this.bt_back_QLMTS.Name = "bt_back_QLMTS";
            this.bt_back_QLMTS.Size = new System.Drawing.Size(109, 34);
            this.bt_back_QLMTS.TabIndex = 80;
            this.bt_back_QLMTS.Text = "Quay lại";
            this.bt_back_QLMTS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.bt_back_QLMTS.Click += new System.EventHandler(this.bt_back_QLMTS_Click);
            // 
            // dgv_DV
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_DV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_DV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDocGia,
            this.MaNV,
            this.NgayMuon});
            this.dgv_DV.Location = new System.Drawing.Point(12, 328);
            this.dgv_DV.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_DV.Name = "dgv_DV";
            this.dgv_DV.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_DV.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_DV.RowTemplate.Height = 24;
            this.dgv_DV.Size = new System.Drawing.Size(828, 396);
            this.dgv_DV.TabIndex = 81;
            this.dgv_DV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DV_CellClick);
            // 
            // MaDocGia
            // 
            this.MaDocGia.DataPropertyName = "MA_DICHVU";
            this.MaDocGia.HeaderText = "Mã dịch vụ";
            this.MaDocGia.MinimumWidth = 6;
            this.MaDocGia.Name = "MaDocGia";
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MOTA_DICHVU";
            this.MaNV.HeaderText = "Tên dịch vụ";
            this.MaNV.MinimumWidth = 6;
            this.MaNV.Name = "MaNV";
            // 
            // NgayMuon
            // 
            this.NgayMuon.DataPropertyName = "TONGTIEN_DICHVU";
            this.NgayMuon.HeaderText = "Đơn giá";
            this.NgayMuon.MinimumWidth = 6;
            this.NgayMuon.Name = "NgayMuon";
            // 
            // DichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(188)))), ((int)(((byte)(183)))));
            this.ClientSize = new System.Drawing.Size(850, 735);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.bt_back_QLMTS);
            this.Controls.Add(this.dgv_DV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DichVu";
            this.Text = "DichVu";
            this.guna2GroupBox1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2Button bt_timkiem;
        private Guna.UI2.WinForms.Guna2TextBox txt_nameDV;
        private Guna.UI2.WinForms.Guna2TextBox txt_price;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Button bt_deleteDV;
        private Guna.UI2.WinForms.Guna2Button btn_UpdateDV;
        private Guna.UI2.WinForms.Guna2Button bt_back_QLMTS;
        private System.Windows.Forms.DataGridView dgv_DV;
        private Guna.UI2.WinForms.Guna2Button bt_addDv;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDocGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayMuon;
    }
}