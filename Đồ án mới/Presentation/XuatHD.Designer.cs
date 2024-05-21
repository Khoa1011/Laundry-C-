namespace Đồ_án_mới.Presentation
{
    partial class XuatHD
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_xHD = new System.Windows.Forms.DataGridView();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_ID = new System.Windows.Forms.Label();
            this.lb_Name = new System.Windows.Forms.Label();
            this.lb_Age = new System.Windows.Forms.Label();
            this.lb_Address = new System.Windows.Forms.Label();
            this.lb_Phone = new System.Windows.Forms.Label();
            this.lb_date = new System.Windows.Forms.Label();
            this.lb_total = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_xHD)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_xHD
            // 
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_xHD.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_xHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_xHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_xHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNV,
            this.Sach,
            this.Column1});
            this.dgv_xHD.Location = new System.Drawing.Point(20, 284);
            this.dgv_xHD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_xHD.Name = "dgv_xHD";
            this.dgv_xHD.RowHeadersWidth = 51;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_xHD.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_xHD.RowTemplate.Height = 24;
            this.dgv_xHD.Size = new System.Drawing.Size(1212, 322);
            this.dgv_xHD.TabIndex = 68;
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MOTA_DICHVU";
            this.MaNV.FillWeight = 138.4569F;
            this.MaNV.HeaderText = "Dịch vụ";
            this.MaNV.MinimumWidth = 6;
            this.MaNV.Name = "MaNV";
            // 
            // Sach
            // 
            this.Sach.DataPropertyName = "TONG_SOLUONG_DICHVU";
            this.Sach.FillWeight = 54.92963F;
            this.Sach.HeaderText = "Số lượng";
            this.Sach.MinimumWidth = 6;
            this.Sach.Name = "Sach";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "TONG_TONGTIEN_HOADON";
            this.Column1.FillWeight = 60.91371F;
            this.Column1.HeaderText = "Tổng tiền";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(145, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 25);
            this.label3.TabIndex = 97;
            this.label3.Text = "Họ và tên  :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label7.Location = new System.Drawing.Point(145, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 25);
            this.label7.TabIndex = 98;
            this.label7.Text = "Mã KH       : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label9.Location = new System.Drawing.Point(669, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(187, 25);
            this.label9.TabIndex = 99;
            this.label9.Text = "Địa chỉ                 :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(668, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 25);
            this.label4.TabIndex = 100;
            this.label4.Text = "Số điện thoại       :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(841, 626);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 25);
            this.label1.TabIndex = 102;
            this.label1.Text = "Tổng tiền:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(381, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 36);
            this.label2.TabIndex = 109;
            this.label2.Text = "Ngày   :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label5.Location = new System.Drawing.Point(145, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 25);
            this.label5.TabIndex = 98;
            this.label5.Text = "Tuổi           :";
            // 
            // lb_ID
            // 
            this.lb_ID.AutoSize = true;
            this.lb_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ID.ForeColor = System.Drawing.Color.Black;
            this.lb_ID.Location = new System.Drawing.Point(297, 138);
            this.lb_ID.Name = "lb_ID";
            this.lb_ID.Size = new System.Drawing.Size(18, 25);
            this.lb_ID.TabIndex = 111;
            this.lb_ID.Text = " ";
            // 
            // lb_Name
            // 
            this.lb_Name.AutoSize = true;
            this.lb_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Name.ForeColor = System.Drawing.Color.Black;
            this.lb_Name.Location = new System.Drawing.Point(297, 97);
            this.lb_Name.Name = "lb_Name";
            this.lb_Name.Size = new System.Drawing.Size(18, 25);
            this.lb_Name.TabIndex = 111;
            this.lb_Name.Text = " ";
            // 
            // lb_Age
            // 
            this.lb_Age.AutoSize = true;
            this.lb_Age.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Age.ForeColor = System.Drawing.Color.Black;
            this.lb_Age.Location = new System.Drawing.Point(297, 174);
            this.lb_Age.Name = "lb_Age";
            this.lb_Age.Size = new System.Drawing.Size(18, 25);
            this.lb_Age.TabIndex = 111;
            this.lb_Age.Text = " ";
            // 
            // lb_Address
            // 
            this.lb_Address.AutoSize = true;
            this.lb_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Address.ForeColor = System.Drawing.Color.Black;
            this.lb_Address.Location = new System.Drawing.Point(880, 97);
            this.lb_Address.Name = "lb_Address";
            this.lb_Address.Size = new System.Drawing.Size(18, 25);
            this.lb_Address.TabIndex = 111;
            this.lb_Address.Text = " ";
            // 
            // lb_Phone
            // 
            this.lb_Phone.AutoSize = true;
            this.lb_Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Phone.ForeColor = System.Drawing.Color.Black;
            this.lb_Phone.Location = new System.Drawing.Point(880, 138);
            this.lb_Phone.Name = "lb_Phone";
            this.lb_Phone.Size = new System.Drawing.Size(18, 25);
            this.lb_Phone.TabIndex = 111;
            this.lb_Phone.Text = " ";
            // 
            // lb_date
            // 
            this.lb_date.AutoSize = true;
            this.lb_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_date.ForeColor = System.Drawing.Color.Black;
            this.lb_date.Location = new System.Drawing.Point(521, 25);
            this.lb_date.Name = "lb_date";
            this.lb_date.Size = new System.Drawing.Size(24, 36);
            this.lb_date.TabIndex = 109;
            this.lb_date.Text = " ";
            // 
            // lb_total
            // 
            this.lb_total.AutoSize = true;
            this.lb_total.BackColor = System.Drawing.Color.Transparent;
            this.lb_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_total.ForeColor = System.Drawing.Color.Black;
            this.lb_total.Location = new System.Drawing.Point(977, 626);
            this.lb_total.Name = "lb_total";
            this.lb_total.Size = new System.Drawing.Size(18, 25);
            this.lb_total.TabIndex = 102;
            this.lb_total.Text = " ";
            // 
            // XuatHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1247, 674);
            this.Controls.Add(this.lb_Address);
            this.Controls.Add(this.lb_Name);
            this.Controls.Add(this.lb_Age);
            this.Controls.Add(this.lb_Phone);
            this.Controls.Add(this.lb_ID);
            this.Controls.Add(this.lb_date);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_total);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgv_xHD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "XuatHD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xuất hóa đơn";
            this.Load += new System.EventHandler(this.XuatHD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_xHD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_xHD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sach;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lb_ID;
        private System.Windows.Forms.Label lb_Name;
        private System.Windows.Forms.Label lb_Age;
        private System.Windows.Forms.Label lb_Address;
        private System.Windows.Forms.Label lb_Phone;
        private System.Windows.Forms.Label lb_date;
        private System.Windows.Forms.Label lb_total;
    }
}