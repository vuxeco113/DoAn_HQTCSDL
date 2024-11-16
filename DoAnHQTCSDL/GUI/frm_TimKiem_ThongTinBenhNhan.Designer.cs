namespace GUI
{
    partial class frm_TimKiem_ThongTinBenhNhan
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
            this.btn_huy = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mabn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mabhyt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tuoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tukhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.denkhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tinhtrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_mabs = new System.Windows.Forms.TextBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.txt_BHYT1 = new System.Windows.Forms.TextBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.txt_PK = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.rdo_ngaykham = new System.Windows.Forms.RadioButton();
            this.rdo_hoten = new System.Windows.Forms.RadioButton();
            this.rdo_maBN = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1_ngaykham = new System.Windows.Forms.DateTimePicker();
            this.txt_hotenBN1 = new System.Windows.Forms.TextBox();
            this.txt_maBN1 = new System.Windows.Forms.TextBox();
            this.btn_timkiem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_huy
            // 
            this.btn_huy.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_huy.ForeColor = System.Drawing.Color.Black;
            this.btn_huy.Location = new System.Drawing.Point(1125, 599);
            this.btn_huy.Margin = new System.Windows.Forms.Padding(4);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(137, 47);
            this.btn_huy.TabIndex = 11;
            this.btn_huy.Text = "Hủy";
            this.btn_huy.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mabn,
            this.hoten,
            this.ngaysinh,
            this.gioitinh,
            this.sdt,
            this.mabhyt,
            this.diachi,
            this.tuoi,
            this.tukhoa,
            this.denkhoa,
            this.tinhtrang});
            this.dataGridView1.Location = new System.Drawing.Point(29, 212);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1233, 358);
            this.dataGridView1.TabIndex = 10;
            // 
            // mabn
            // 
            this.mabn.HeaderText = "Mã bệnh nhân";
            this.mabn.MinimumWidth = 6;
            this.mabn.Name = "mabn";
            this.mabn.Width = 125;
            // 
            // hoten
            // 
            this.hoten.HeaderText = "Họ tên bệnh nhân";
            this.hoten.MinimumWidth = 6;
            this.hoten.Name = "hoten";
            this.hoten.Width = 125;
            // 
            // ngaysinh
            // 
            this.ngaysinh.HeaderText = "Ngày sinh";
            this.ngaysinh.MinimumWidth = 6;
            this.ngaysinh.Name = "ngaysinh";
            this.ngaysinh.Width = 125;
            // 
            // gioitinh
            // 
            this.gioitinh.HeaderText = "Giới tính";
            this.gioitinh.MinimumWidth = 6;
            this.gioitinh.Name = "gioitinh";
            this.gioitinh.Width = 125;
            // 
            // sdt
            // 
            this.sdt.HeaderText = "SDT";
            this.sdt.MinimumWidth = 6;
            this.sdt.Name = "sdt";
            this.sdt.Width = 125;
            // 
            // mabhyt
            // 
            this.mabhyt.HeaderText = "Mã BHYT";
            this.mabhyt.MinimumWidth = 6;
            this.mabhyt.Name = "mabhyt";
            this.mabhyt.Width = 125;
            // 
            // diachi
            // 
            this.diachi.HeaderText = "Địa chỉ ";
            this.diachi.MinimumWidth = 6;
            this.diachi.Name = "diachi";
            this.diachi.Width = 125;
            // 
            // tuoi
            // 
            this.tuoi.HeaderText = "Tuổi";
            this.tuoi.MinimumWidth = 6;
            this.tuoi.Name = "tuoi";
            this.tuoi.Width = 125;
            // 
            // tukhoa
            // 
            this.tukhoa.HeaderText = "Từ khoa";
            this.tukhoa.MinimumWidth = 6;
            this.tukhoa.Name = "tukhoa";
            this.tukhoa.Width = 125;
            // 
            // denkhoa
            // 
            this.denkhoa.HeaderText = "Đến khoa";
            this.denkhoa.MinimumWidth = 6;
            this.denkhoa.Name = "denkhoa";
            this.denkhoa.Width = 125;
            // 
            // tinhtrang
            // 
            this.tinhtrang.HeaderText = "Tình trạng";
            this.tinhtrang.MinimumWidth = 6;
            this.tinhtrang.Name = "tinhtrang";
            this.tinhtrang.Width = 125;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_mabs);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.txt_BHYT1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.txt_PK);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.rdo_ngaykham);
            this.groupBox1.Controls.Add(this.rdo_hoten);
            this.groupBox1.Controls.Add(this.rdo_maBN);
            this.groupBox1.Controls.Add(this.dateTimePicker1_ngaykham);
            this.groupBox1.Controls.Add(this.txt_hotenBN1);
            this.groupBox1.Controls.Add(this.txt_maBN1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(33, 36);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1229, 155);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm Kiếm";
            // 
            // txt_mabs
            // 
            this.txt_mabs.Location = new System.Drawing.Point(1097, 95);
            this.txt_mabs.Margin = new System.Windows.Forms.Padding(4);
            this.txt_mabs.Name = "txt_mabs";
            this.txt_mabs.Size = new System.Drawing.Size(124, 30);
            this.txt_mabs.TabIndex = 21;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.ForeColor = System.Drawing.Color.Black;
            this.radioButton3.Location = new System.Drawing.Point(943, 99);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(123, 27);
            this.radioButton3.TabIndex = 20;
            this.radioButton3.Text = "Mã bác sĩ :";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // txt_BHYT1
            // 
            this.txt_BHYT1.Location = new System.Drawing.Point(1093, 46);
            this.txt_BHYT1.Margin = new System.Windows.Forms.Padding(4);
            this.txt_BHYT1.Name = "txt_BHYT1";
            this.txt_BHYT1.Size = new System.Drawing.Size(124, 30);
            this.txt_BHYT1.TabIndex = 19;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.ForeColor = System.Drawing.Color.Black;
            this.radioButton2.Location = new System.Drawing.Point(943, 46);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(130, 27);
            this.radioButton2.TabIndex = 18;
            this.radioButton2.Text = "Mã BHYT :";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // txt_PK
            // 
            this.txt_PK.Location = new System.Drawing.Point(574, 40);
            this.txt_PK.Margin = new System.Windows.Forms.Padding(4);
            this.txt_PK.Name = "txt_PK";
            this.txt_PK.Size = new System.Drawing.Size(306, 30);
            this.txt_PK.TabIndex = 17;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.ForeColor = System.Drawing.Color.Black;
            this.radioButton1.Location = new System.Drawing.Point(395, 43);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(172, 27);
            this.radioButton1.TabIndex = 16;
            this.radioButton1.Text = "Mã phiếu khám :";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // rdo_ngaykham
            // 
            this.rdo_ngaykham.AutoSize = true;
            this.rdo_ngaykham.ForeColor = System.Drawing.Color.Black;
            this.rdo_ngaykham.Location = new System.Drawing.Point(395, 99);
            this.rdo_ngaykham.Name = "rdo_ngaykham";
            this.rdo_ngaykham.Size = new System.Drawing.Size(138, 27);
            this.rdo_ngaykham.TabIndex = 15;
            this.rdo_ngaykham.Text = "Ngày khám :";
            this.rdo_ngaykham.UseVisualStyleBackColor = true;
            // 
            // rdo_hoten
            // 
            this.rdo_hoten.AutoSize = true;
            this.rdo_hoten.ForeColor = System.Drawing.Color.Black;
            this.rdo_hoten.Location = new System.Drawing.Point(0, 96);
            this.rdo_hoten.Name = "rdo_hoten";
            this.rdo_hoten.Size = new System.Drawing.Size(189, 27);
            this.rdo_hoten.TabIndex = 14;
            this.rdo_hoten.Text = "Họ tên bệnh nhân :";
            this.rdo_hoten.UseVisualStyleBackColor = true;
            // 
            // rdo_maBN
            // 
            this.rdo_maBN.AutoSize = true;
            this.rdo_maBN.Checked = true;
            this.rdo_maBN.ForeColor = System.Drawing.Color.Black;
            this.rdo_maBN.Location = new System.Drawing.Point(0, 40);
            this.rdo_maBN.Name = "rdo_maBN";
            this.rdo_maBN.Size = new System.Drawing.Size(161, 27);
            this.rdo_maBN.TabIndex = 0;
            this.rdo_maBN.TabStop = true;
            this.rdo_maBN.Text = "Mã bệnh nhân :";
            this.rdo_maBN.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1_ngaykham
            // 
            this.dateTimePicker1_ngaykham.Location = new System.Drawing.Point(574, 95);
            this.dateTimePicker1_ngaykham.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1_ngaykham.Name = "dateTimePicker1_ngaykham";
            this.dateTimePicker1_ngaykham.Size = new System.Drawing.Size(306, 30);
            this.dateTimePicker1_ngaykham.TabIndex = 8;
            // 
            // txt_hotenBN1
            // 
            this.txt_hotenBN1.Location = new System.Drawing.Point(196, 96);
            this.txt_hotenBN1.Margin = new System.Windows.Forms.Padding(4);
            this.txt_hotenBN1.Name = "txt_hotenBN1";
            this.txt_hotenBN1.Size = new System.Drawing.Size(124, 30);
            this.txt_hotenBN1.TabIndex = 12;
            // 
            // txt_maBN1
            // 
            this.txt_maBN1.Location = new System.Drawing.Point(196, 43);
            this.txt_maBN1.Margin = new System.Windows.Forms.Padding(4);
            this.txt_maBN1.Name = "txt_maBN1";
            this.txt_maBN1.Size = new System.Drawing.Size(124, 30);
            this.txt_maBN1.TabIndex = 6;
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_timkiem.ForeColor = System.Drawing.Color.Black;
            this.btn_timkiem.Location = new System.Drawing.Point(976, 599);
            this.btn_timkiem.Margin = new System.Windows.Forms.Padding(4);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(137, 47);
            this.btn_timkiem.TabIndex = 9;
            this.btn_timkiem.Text = "Tìm kiếm";
            this.btn_timkiem.UseVisualStyleBackColor = true;
            // 
            // frm_TimKiem_ThongTinBenhNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1410, 708);
            this.Controls.Add(this.btn_huy);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_timkiem);
            this.Name = "frm_TimKiem_ThongTinBenhNhan";
            this.Text = "frm_TimKiem_ThongTinBenhNhan";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_huy;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mabn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn mabhyt;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn tuoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn tukhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn denkhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn tinhtrang;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_mabs;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.TextBox txt_BHYT1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.TextBox txt_PK;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton rdo_ngaykham;
        private System.Windows.Forms.RadioButton rdo_hoten;
        private System.Windows.Forms.RadioButton rdo_maBN;
        private System.Windows.Forms.DateTimePicker dateTimePicker1_ngaykham;
        private System.Windows.Forms.TextBox txt_hotenBN1;
        private System.Windows.Forms.TextBox txt_maBN1;
        private System.Windows.Forms.Button btn_timkiem;
    }
}