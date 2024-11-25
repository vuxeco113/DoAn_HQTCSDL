namespace GUI
{
    partial class frm_Tri_XemChiTiet_HSBN
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
            this.ngaykham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbo_maBN = new System.Windows.Forms.ComboBox();
            this.txt_tuoi = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dateTimePicker1_ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.rdo_maBN = new System.Windows.Forms.RadioButton();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.txt_BHYT2 = new System.Windows.Forms.TextBox();
            this.txt_dc = new System.Windows.Forms.TextBox();
            this.txt_HT2 = new System.Windows.Forms.TextBox();
            this.ketqua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.machidinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaichidinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaychidinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_xemchitiet = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cbo_gioitinh = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.chandoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mabacsi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.khoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.maphieukham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ngaykham
            // 
            this.ngaykham.DataPropertyName = "NgayKham";
            this.ngaykham.HeaderText = "Ngày khám";
            this.ngaykham.MinimumWidth = 6;
            this.ngaykham.Name = "ngaykham";
            this.ngaykham.Width = 125;
            // 
            // cbo_maBN
            // 
            this.cbo_maBN.FormattingEnabled = true;
            this.cbo_maBN.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbo_maBN.Location = new System.Drawing.Point(180, 30);
            this.cbo_maBN.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cbo_maBN.Name = "cbo_maBN";
            this.cbo_maBN.Size = new System.Drawing.Size(360, 31);
            this.cbo_maBN.TabIndex = 51;
            // 
            // txt_tuoi
            // 
            this.txt_tuoi.Enabled = false;
            this.txt_tuoi.Location = new System.Drawing.Point(180, 238);
            this.txt_tuoi.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txt_tuoi.Name = "txt_tuoi";
            this.txt_tuoi.Size = new System.Drawing.Size(360, 30);
            this.txt_tuoi.TabIndex = 49;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(19, 237);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 23);
            this.label12.TabIndex = 48;
            this.label12.Text = "Tuổi :";
            // 
            // dateTimePicker1_ngaysinh
            // 
            this.dateTimePicker1_ngaysinh.Enabled = false;
            this.dateTimePicker1_ngaysinh.Location = new System.Drawing.Point(180, 133);
            this.dateTimePicker1_ngaysinh.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.dateTimePicker1_ngaysinh.Name = "dateTimePicker1_ngaysinh";
            this.dateTimePicker1_ngaysinh.Size = new System.Drawing.Size(360, 30);
            this.dateTimePicker1_ngaysinh.TabIndex = 42;
            // 
            // rdo_maBN
            // 
            this.rdo_maBN.AutoSize = true;
            this.rdo_maBN.Checked = true;
            this.rdo_maBN.ForeColor = System.Drawing.Color.Black;
            this.rdo_maBN.Location = new System.Drawing.Point(18, 34);
            this.rdo_maBN.Margin = new System.Windows.Forms.Padding(4);
            this.rdo_maBN.Name = "rdo_maBN";
            this.rdo_maBN.Size = new System.Drawing.Size(161, 27);
            this.rdo_maBN.TabIndex = 7;
            this.rdo_maBN.TabStop = true;
            this.rdo_maBN.Text = "Mã bệnh nhân :";
            this.rdo_maBN.UseVisualStyleBackColor = true;
            // 
            // txt_sdt
            // 
            this.txt_sdt.Enabled = false;
            this.txt_sdt.Location = new System.Drawing.Point(781, 76);
            this.txt_sdt.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(267, 30);
            this.txt_sdt.TabIndex = 47;
            // 
            // txt_BHYT2
            // 
            this.txt_BHYT2.Enabled = false;
            this.txt_BHYT2.Location = new System.Drawing.Point(781, 131);
            this.txt_BHYT2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txt_BHYT2.Name = "txt_BHYT2";
            this.txt_BHYT2.Size = new System.Drawing.Size(267, 30);
            this.txt_BHYT2.TabIndex = 46;
            // 
            // txt_dc
            // 
            this.txt_dc.Enabled = false;
            this.txt_dc.Location = new System.Drawing.Point(781, 184);
            this.txt_dc.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txt_dc.Name = "txt_dc";
            this.txt_dc.Size = new System.Drawing.Size(267, 30);
            this.txt_dc.TabIndex = 45;
            // 
            // txt_HT2
            // 
            this.txt_HT2.Enabled = false;
            this.txt_HT2.Location = new System.Drawing.Point(180, 78);
            this.txt_HT2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txt_HT2.Name = "txt_HT2";
            this.txt_HT2.Size = new System.Drawing.Size(360, 30);
            this.txt_HT2.TabIndex = 44;
            // 
            // ketqua
            // 
            this.ketqua.DataPropertyName = "KetQua";
            this.ketqua.HeaderText = "Kết quả";
            this.ketqua.MinimumWidth = 6;
            this.ketqua.Name = "ketqua";
            this.ketqua.Width = 300;
            // 
            // machidinh
            // 
            this.machidinh.DataPropertyName = "MaChiDinh";
            this.machidinh.HeaderText = "Mã chỉ định";
            this.machidinh.MinimumWidth = 6;
            this.machidinh.Name = "machidinh";
            this.machidinh.Width = 125;
            // 
            // loaichidinh
            // 
            this.loaichidinh.DataPropertyName = "LoaiChiDinh";
            this.loaichidinh.HeaderText = "Loại chỉ định";
            this.loaichidinh.MinimumWidth = 6;
            this.loaichidinh.Name = "loaichidinh";
            this.loaichidinh.Width = 125;
            // 
            // ngaychidinh
            // 
            this.ngaychidinh.DataPropertyName = "NgayChiDinh";
            this.ngaychidinh.HeaderText = "Ngày chỉ định";
            this.ngaychidinh.MinimumWidth = 6;
            this.ngaychidinh.Name = "ngaychidinh";
            this.ngaychidinh.Width = 125;
            // 
            // btn_xemchitiet
            // 
            this.btn_xemchitiet.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xemchitiet.Location = new System.Drawing.Point(781, 229);
            this.btn_xemchitiet.Margin = new System.Windows.Forms.Padding(4);
            this.btn_xemchitiet.Name = "btn_xemchitiet";
            this.btn_xemchitiet.Size = new System.Drawing.Size(268, 44);
            this.btn_xemchitiet.TabIndex = 55;
            this.btn_xemchitiet.Text = "Xem chi tiết";
            this.btn_xemchitiet.UseVisualStyleBackColor = true;
            this.btn_xemchitiet.Click += new System.EventHandler(this.btn_xemchitiet_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(620, 80);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 23);
            this.label8.TabIndex = 41;
            this.label8.Text = "SDT:";
            // 
            // cbo_gioitinh
            // 
            this.cbo_gioitinh.Enabled = false;
            this.cbo_gioitinh.FormattingEnabled = true;
            this.cbo_gioitinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbo_gioitinh.Location = new System.Drawing.Point(180, 177);
            this.cbo_gioitinh.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cbo_gioitinh.Name = "cbo_gioitinh";
            this.cbo_gioitinh.Size = new System.Drawing.Size(360, 31);
            this.cbo_gioitinh.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(620, 141);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 23);
            this.label7.TabIndex = 40;
            this.label7.Text = "Mã BHYT :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(620, 188);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 23);
            this.label6.TabIndex = 39;
            this.label6.Text = "Địa chỉ :";
            // 
            // chandoan
            // 
            this.chandoan.DataPropertyName = "ChanDoan";
            this.chandoan.HeaderText = "Chẩn đoán";
            this.chandoan.MinimumWidth = 6;
            this.chandoan.Name = "chandoan";
            this.chandoan.Width = 300;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(14, 131);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 23);
            this.label5.TabIndex = 38;
            this.label5.Text = "Ngày sinh :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(268, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(549, 32);
            this.label1.TabIndex = 57;
            this.label1.Text = "XEM CHI TIẾT THÔNG TIN BỆNH NHÂN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(14, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 23);
            this.label2.TabIndex = 35;
            this.label2.Text = "Họ tên bệnh nhân :";
            // 
            // mabacsi
            // 
            this.mabacsi.DataPropertyName = "TenBacSi";
            this.mabacsi.HeaderText = "Họ tên bác sĩ";
            this.mabacsi.MinimumWidth = 6;
            this.mabacsi.Name = "mabacsi";
            this.mabacsi.Width = 125;
            // 
            // khoa
            // 
            this.khoa.DataPropertyName = "MaKhoa";
            this.khoa.HeaderText = "Mã Khoa";
            this.khoa.MinimumWidth = 6;
            this.khoa.Name = "khoa";
            this.khoa.Width = 125;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.khoa,
            this.mabacsi,
            this.maphieukham,
            this.ngaykham,
            this.chandoan,
            this.ketqua,
            this.machidinh,
            this.loaichidinh,
            this.ngaychidinh});
            this.dataGridView1.Location = new System.Drawing.Point(0, 26);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1049, 242);
            this.dataGridView1.TabIndex = 0;
            // 
            // maphieukham
            // 
            this.maphieukham.DataPropertyName = "MaPhieuKham";
            this.maphieukham.HeaderText = "Mã phiếu khám";
            this.maphieukham.MinimumWidth = 6;
            this.maphieukham.Name = "maphieukham";
            this.maphieukham.Width = 125;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(13, 382);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1079, 290);
            this.groupBox2.TabIndex = 54;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lịch sử khám bệnh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(14, 177);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 23);
            this.label3.TabIndex = 36;
            this.label3.Text = "Giới tính :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_xemchitiet);
            this.groupBox1.Controls.Add(this.cbo_maBN);
            this.groupBox1.Controls.Add(this.txt_tuoi);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.dateTimePicker1_ngaysinh);
            this.groupBox1.Controls.Add(this.rdo_maBN);
            this.groupBox1.Controls.Add(this.txt_sdt);
            this.groupBox1.Controls.Add(this.txt_BHYT2);
            this.groupBox1.Controls.Add(this.txt_dc);
            this.groupBox1.Controls.Add(this.txt_HT2);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cbo_gioitinh);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 64);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1079, 290);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin cá nhân";
            // 
            // frm_Tri_XemChiTiet_HSBN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1104, 850);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frm_Tri_XemChiTiet_HSBN";
            this.Text = "frm_XemChiTiet_HSBN";
            this.Load += new System.EventHandler(this.frm_Tri_XemChiTiet_HSBN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn ngaykham;
        private System.Windows.Forms.ComboBox cbo_maBN;
        private System.Windows.Forms.TextBox txt_tuoi;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dateTimePicker1_ngaysinh;
        private System.Windows.Forms.RadioButton rdo_maBN;
        private System.Windows.Forms.TextBox txt_sdt;
        private System.Windows.Forms.TextBox txt_BHYT2;
        private System.Windows.Forms.TextBox txt_dc;
        private System.Windows.Forms.TextBox txt_HT2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ketqua;
        private System.Windows.Forms.DataGridViewTextBoxColumn machidinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaichidinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaychidinh;
        private System.Windows.Forms.Button btn_xemchitiet;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbo_gioitinh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn chandoan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn mabacsi;
        private System.Windows.Forms.DataGridViewTextBoxColumn khoa;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maphieukham;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}