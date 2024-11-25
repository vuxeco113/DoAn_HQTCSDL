namespace GUI
{
    partial class frm_Tri_timkiem_BN
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
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
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.rdo_mabn = new System.Windows.Forms.RadioButton();
            this.rdo_mabs = new System.Windows.Forms.RadioButton();
            this.cbo_maBN = new System.Windows.Forms.ComboBox();
            this.cbo_mabs = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 124);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Size = new System.Drawing.Size(1102, 243);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DANH SÁCH BỆNH NHÂN ĐƯỢC MỘT BÁC SĨ ĐIỀU TRỊ";
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
            this.dataGridView1.Location = new System.Drawing.Point(5, 45);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1079, 178);
            this.dataGridView1.TabIndex = 6;
            // 
            // mabn
            // 
            this.mabn.DataPropertyName = "MaBenhNhan";
            this.mabn.HeaderText = "Mã bệnh nhân";
            this.mabn.MinimumWidth = 6;
            this.mabn.Name = "mabn";
            this.mabn.Width = 125;
            // 
            // hoten
            // 
            this.hoten.DataPropertyName = "HoTen";
            this.hoten.HeaderText = "Họ tên bệnh nhân";
            this.hoten.MinimumWidth = 6;
            this.hoten.Name = "hoten";
            this.hoten.Width = 125;
            // 
            // ngaysinh
            // 
            this.ngaysinh.DataPropertyName = "NgaySinh";
            this.ngaysinh.HeaderText = "Ngày sinh";
            this.ngaysinh.MinimumWidth = 6;
            this.ngaysinh.Name = "ngaysinh";
            this.ngaysinh.Width = 125;
            // 
            // gioitinh
            // 
            this.gioitinh.DataPropertyName = "GioiTinh";
            this.gioitinh.HeaderText = "Giới tính";
            this.gioitinh.MinimumWidth = 6;
            this.gioitinh.Name = "gioitinh";
            this.gioitinh.Width = 125;
            // 
            // sdt
            // 
            this.sdt.DataPropertyName = "SoDienThoai";
            this.sdt.HeaderText = "SDT";
            this.sdt.MinimumWidth = 6;
            this.sdt.Name = "sdt";
            this.sdt.Width = 125;
            // 
            // mabhyt
            // 
            this.mabhyt.DataPropertyName = "MaBHYT";
            this.mabhyt.HeaderText = "Mã BHYT";
            this.mabhyt.MinimumWidth = 6;
            this.mabhyt.Name = "mabhyt";
            this.mabhyt.Width = 125;
            // 
            // diachi
            // 
            this.diachi.DataPropertyName = "DiaChi";
            this.diachi.HeaderText = "Địa chỉ ";
            this.diachi.MinimumWidth = 6;
            this.diachi.Name = "diachi";
            this.diachi.Width = 125;
            // 
            // tuoi
            // 
            this.tuoi.DataPropertyName = "Tuoi";
            this.tuoi.HeaderText = "Tuổi";
            this.tuoi.MinimumWidth = 6;
            this.tuoi.Name = "tuoi";
            this.tuoi.Width = 125;
            // 
            // tukhoa
            // 
            this.tukhoa.DataPropertyName = "Tukhoa";
            this.tukhoa.HeaderText = "Từ khoa";
            this.tukhoa.MinimumWidth = 6;
            this.tukhoa.Name = "tukhoa";
            this.tukhoa.Width = 125;
            // 
            // denkhoa
            // 
            this.denkhoa.DataPropertyName = "Denkhoa";
            this.denkhoa.HeaderText = "Đến khoa";
            this.denkhoa.MinimumWidth = 6;
            this.denkhoa.Name = "denkhoa";
            this.denkhoa.Width = 125;
            // 
            // tinhtrang
            // 
            this.tinhtrang.DataPropertyName = "TrangThai";
            this.tinhtrang.HeaderText = "Tình trạng";
            this.tinhtrang.MinimumWidth = 6;
            this.tinhtrang.Name = "tinhtrang";
            this.tinhtrang.Width = 125;
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_timkiem.ForeColor = System.Drawing.Color.Black;
            this.btn_timkiem.Location = new System.Drawing.Point(480, 24);
            this.btn_timkiem.Margin = new System.Windows.Forms.Padding(4);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(120, 44);
            this.btn_timkiem.TabIndex = 10;
            this.btn_timkiem.Text = "Tìm kiếm";
            this.btn_timkiem.UseVisualStyleBackColor = true;
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // rdo_mabn
            // 
            this.rdo_mabn.AutoSize = true;
            this.rdo_mabn.Location = new System.Drawing.Point(606, 34);
            this.rdo_mabn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rdo_mabn.Name = "rdo_mabn";
            this.rdo_mabn.Size = new System.Drawing.Size(149, 27);
            this.rdo_mabn.TabIndex = 5;
            this.rdo_mabn.TabStop = true;
            this.rdo_mabn.Text = "Mã bệnh nhân";
            this.rdo_mabn.UseVisualStyleBackColor = true;
            // 
            // rdo_mabs
            // 
            this.rdo_mabs.AutoSize = true;
            this.rdo_mabs.Location = new System.Drawing.Point(15, 29);
            this.rdo_mabs.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rdo_mabs.Name = "rdo_mabs";
            this.rdo_mabs.Size = new System.Drawing.Size(111, 27);
            this.rdo_mabs.TabIndex = 4;
            this.rdo_mabs.TabStop = true;
            this.rdo_mabs.Text = "Mã bác sĩ";
            this.rdo_mabs.UseVisualStyleBackColor = true;
            // 
            // cbo_maBN
            // 
            this.cbo_maBN.FormattingEnabled = true;
            this.cbo_maBN.Location = new System.Drawing.Point(772, 30);
            this.cbo_maBN.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbo_maBN.Name = "cbo_maBN";
            this.cbo_maBN.Size = new System.Drawing.Size(280, 31);
            this.cbo_maBN.TabIndex = 3;
            // 
            // cbo_mabs
            // 
            this.cbo_mabs.FormattingEnabled = true;
            this.cbo_mabs.Location = new System.Drawing.Point(159, 28);
            this.cbo_mabs.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbo_mabs.Name = "cbo_mabs";
            this.cbo_mabs.Size = new System.Drawing.Size(280, 31);
            this.cbo_mabs.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdo_mabn);
            this.groupBox1.Controls.Add(this.btn_timkiem);
            this.groupBox1.Controls.Add(this.rdo_mabs);
            this.groupBox1.Controls.Add(this.cbo_maBN);
            this.groupBox1.Controls.Add(this.cbo_mabs);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(12, 22);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1102, 81);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm Kiếm";
            // 
            // frm_Tri_timkiem_BN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1263, 449);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "frm_Tri_timkiem_BN";
            this.Text = "frm_TimKiem_ThongTinBenhNhan";
            this.Load += new System.EventHandler(this.frm_Tri_timkiem_BN_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
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
        private System.Windows.Forms.Button btn_timkiem;
        private System.Windows.Forms.RadioButton rdo_mabn;
        private System.Windows.Forms.RadioButton rdo_mabs;
        private System.Windows.Forms.ComboBox cbo_maBN;
        private System.Windows.Forms.ComboBox cbo_mabs;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}