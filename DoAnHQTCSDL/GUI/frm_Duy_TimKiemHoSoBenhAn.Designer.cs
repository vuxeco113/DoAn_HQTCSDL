namespace GUI
{
    partial class frm_Duy_TimKiemHoSoBenhAn
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
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvThongTinCT = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbTong = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvDuLieuTimKiem = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.cbTimKiemTheo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnTaiLai = new System.Windows.Forms.Button();
            this.dtpNgayLapHS = new System.Windows.Forms.DateTimePicker();
            this.txtMaBacSi = new System.Windows.Forms.TextBox();
            this.txtMaHoSo = new System.Windows.Forms.TextBox();
            this.txtMaBenhNhan = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MaHoSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaBenhNhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayLapHoSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaBacSi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoiDungHoSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.MaPhieuKham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenBenhNhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenBacSi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayKham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinCT)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDuLieuTimKiem)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(1125, 630);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(182, 59);
            this.btnThoat.TabIndex = 22;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvThongTinCT);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(1010, 68);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(382, 541);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin chi tiết";
            // 
            // dgvThongTinCT
            // 
            this.dgvThongTinCT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongTinCT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPhieuKham,
            this.TenBenhNhan,
            this.TenBacSi,
            this.NgayKham});
            this.dgvThongTinCT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvThongTinCT.Location = new System.Drawing.Point(3, 20);
            this.dgvThongTinCT.Name = "dgvThongTinCT";
            this.dgvThongTinCT.RowHeadersWidth = 51;
            this.dgvThongTinCT.RowTemplate.Height = 24;
            this.dgvThongTinCT.Size = new System.Drawing.Size(376, 518);
            this.dgvThongTinCT.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbTong);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.dgvDuLieuTimKiem);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(69, 379);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(935, 316);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dữ liệu";
            // 
            // lbTong
            // 
            this.lbTong.AutoSize = true;
            this.lbTong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTong.ForeColor = System.Drawing.Color.Red;
            this.lbTong.Location = new System.Drawing.Point(866, 155);
            this.lbTong.Name = "lbTong";
            this.lbTong.Size = new System.Drawing.Size(17, 18);
            this.lbTong.TabIndex = 2;
            this.lbTong.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(765, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 18);
            this.label7.TabIndex = 1;
            this.label7.Text = "Tổng hồ sơ";
            // 
            // dgvDuLieuTimKiem
            // 
            this.dgvDuLieuTimKiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDuLieuTimKiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHoSo,
            this.MaBenhNhan,
            this.NgayLapHoSo,
            this.MaBacSi,
            this.NoiDungHoSo});
            this.dgvDuLieuTimKiem.Location = new System.Drawing.Point(6, 23);
            this.dgvDuLieuTimKiem.Name = "dgvDuLieuTimKiem";
            this.dgvDuLieuTimKiem.RowHeadersWidth = 51;
            this.dgvDuLieuTimKiem.RowTemplate.Height = 24;
            this.dgvDuLieuTimKiem.Size = new System.Drawing.Size(753, 287);
            this.dgvDuLieuTimKiem.TabIndex = 0;
            this.dgvDuLieuTimKiem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDuLieuTimKiem_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpDenNgay);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.dtpTuNgay);
            this.groupBox1.Controls.Add(this.btnTim);
            this.groupBox1.Controls.Add(this.cbTimKiemTheo);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btnTaiLai);
            this.groupBox1.Controls.Add(this.dtpNgayLapHS);
            this.groupBox1.Controls.Add(this.txtMaBacSi);
            this.groupBox1.Controls.Add(this.txtMaHoSo);
            this.groupBox1.Controls.Add(this.txtMaBenhNhan);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(69, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(935, 305);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.Color.White;
            this.btnTim.Location = new System.Drawing.Point(741, 78);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(135, 54);
            this.btnTim.TabIndex = 13;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // cbTimKiemTheo
            // 
            this.cbTimKiemTheo.FormattingEnabled = true;
            this.cbTimKiemTheo.Location = new System.Drawing.Point(177, 30);
            this.cbTimKiemTheo.Name = "cbTimKiemTheo";
            this.cbTimKiemTheo.Size = new System.Drawing.Size(139, 26);
            this.cbTimKiemTheo.TabIndex = 12;
            this.cbTimKiemTheo.SelectedIndexChanged += new System.EventHandler(this.cbTimKiemTheo_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(65, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 18);
            this.label8.TabIndex = 11;
            this.label8.Text = "Tìm kiếm theo";
            // 
            // btnTaiLai
            // 
            this.btnTaiLai.BackColor = System.Drawing.Color.White;
            this.btnTaiLai.Location = new System.Drawing.Point(741, 177);
            this.btnTaiLai.Name = "btnTaiLai";
            this.btnTaiLai.Size = new System.Drawing.Size(135, 54);
            this.btnTaiLai.TabIndex = 10;
            this.btnTaiLai.Text = "Tải lại";
            this.btnTaiLai.UseVisualStyleBackColor = false;
            this.btnTaiLai.Click += new System.EventHandler(this.btnTaiLai_Click);
            // 
            // dtpNgayLapHS
            // 
            this.dtpNgayLapHS.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayLapHS.Location = new System.Drawing.Point(551, 78);
            this.dtpNgayLapHS.Name = "dtpNgayLapHS";
            this.dtpNgayLapHS.Size = new System.Drawing.Size(139, 24);
            this.dtpNgayLapHS.TabIndex = 8;
            // 
            // txtMaBacSi
            // 
            this.txtMaBacSi.Location = new System.Drawing.Point(551, 137);
            this.txtMaBacSi.Name = "txtMaBacSi";
            this.txtMaBacSi.Size = new System.Drawing.Size(139, 24);
            this.txtMaBacSi.TabIndex = 7;
            // 
            // txtMaHoSo
            // 
            this.txtMaHoSo.Location = new System.Drawing.Point(177, 75);
            this.txtMaHoSo.Name = "txtMaHoSo";
            this.txtMaHoSo.Size = new System.Drawing.Size(139, 24);
            this.txtMaHoSo.TabIndex = 6;
            // 
            // txtMaBenhNhan
            // 
            this.txtMaBenhNhan.Location = new System.Drawing.Point(177, 137);
            this.txtMaBenhNhan.Name = "txtMaBenhNhan";
            this.txtMaBenhNhan.Size = new System.Drawing.Size(139, 24);
            this.txtMaBenhNhan.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(65, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 18);
            this.label6.TabIndex = 4;
            this.label6.Text = "Từ ngày";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(437, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "Mã bác sĩ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(437, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ngày lập hồ sơ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã bệnh nhân";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã hồ sơ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(520, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(441, 45);
            this.label1.TabIndex = 18;
            this.label1.Text = "TÌM KIẾM HỒ SƠ BỆNH ÁN";
            // 
            // MaHoSo
            // 
            this.MaHoSo.DataPropertyName = "MaHoSo";
            this.MaHoSo.HeaderText = "Mã hồ sơ";
            this.MaHoSo.MinimumWidth = 6;
            this.MaHoSo.Name = "MaHoSo";
            this.MaHoSo.Width = 125;
            // 
            // MaBenhNhan
            // 
            this.MaBenhNhan.DataPropertyName = "MaBenhNhan";
            this.MaBenhNhan.HeaderText = "Mã bệnh nhân";
            this.MaBenhNhan.MinimumWidth = 6;
            this.MaBenhNhan.Name = "MaBenhNhan";
            this.MaBenhNhan.Width = 125;
            // 
            // NgayLapHoSo
            // 
            this.NgayLapHoSo.DataPropertyName = "NgayLapHoSo";
            this.NgayLapHoSo.HeaderText = "Ngày lập hồ sơ";
            this.NgayLapHoSo.MinimumWidth = 6;
            this.NgayLapHoSo.Name = "NgayLapHoSo";
            this.NgayLapHoSo.Width = 125;
            // 
            // MaBacSi
            // 
            this.MaBacSi.DataPropertyName = "MaBacSi";
            this.MaBacSi.HeaderText = "Mã bác sĩ";
            this.MaBacSi.MinimumWidth = 6;
            this.MaBacSi.Name = "MaBacSi";
            this.MaBacSi.Width = 125;
            // 
            // NoiDungHoSo
            // 
            this.NoiDungHoSo.DataPropertyName = "NoiDungHoSo";
            this.NoiDungHoSo.HeaderText = "Nội dung";
            this.NoiDungHoSo.MinimumWidth = 6;
            this.NoiDungHoSo.Name = "NoiDungHoSo";
            this.NoiDungHoSo.Width = 125;
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTuNgay.Location = new System.Drawing.Point(177, 195);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(139, 24);
            this.dtpTuNgay.TabIndex = 14;
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDenNgay.Location = new System.Drawing.Point(551, 195);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(139, 24);
            this.dtpDenNgay.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(439, 195);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 18);
            this.label9.TabIndex = 15;
            this.label9.Text = "Đến ngày";
            // 
            // MaPhieuKham
            // 
            this.MaPhieuKham.DataPropertyName = "MaPhieuKham";
            this.MaPhieuKham.HeaderText = "Mã phiếu khám";
            this.MaPhieuKham.MinimumWidth = 6;
            this.MaPhieuKham.Name = "MaPhieuKham";
            this.MaPhieuKham.Width = 125;
            // 
            // TenBenhNhan
            // 
            this.TenBenhNhan.DataPropertyName = "TenBenhNhan";
            this.TenBenhNhan.HeaderText = "Tên bệnh nhân";
            this.TenBenhNhan.MinimumWidth = 6;
            this.TenBenhNhan.Name = "TenBenhNhan";
            this.TenBenhNhan.Width = 125;
            // 
            // TenBacSi
            // 
            this.TenBacSi.DataPropertyName = "TenBacSi";
            this.TenBacSi.HeaderText = "Tên bác sĩ";
            this.TenBacSi.MinimumWidth = 6;
            this.TenBacSi.Name = "TenBacSi";
            this.TenBacSi.Width = 125;
            // 
            // NgayKham
            // 
            this.NgayKham.DataPropertyName = "NgayKham";
            this.NgayKham.HeaderText = "Ngày khám";
            this.NgayKham.MinimumWidth = 6;
            this.NgayKham.Name = "NgayKham";
            this.NgayKham.Width = 125;
            // 
            // frm_Duy_TimKiemHoSoBenhAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1460, 715);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frm_Duy_TimKiemHoSoBenhAn";
            this.Text = "frm_Duy_TimKiemHoSoBenhAn";
            this.Load += new System.EventHandler(this.frm_Duy_TimKiemHoSoBenhAn_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinCT)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDuLieuTimKiem)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvThongTinCT;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbTong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvDuLieuTimKiem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.ComboBox cbTimKiemTheo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnTaiLai;
        private System.Windows.Forms.DateTimePicker dtpNgayLapHS;
        private System.Windows.Forms.TextBox txtMaBacSi;
        private System.Windows.Forms.TextBox txtMaHoSo;
        private System.Windows.Forms.TextBox txtMaBenhNhan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHoSo;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBenhNhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayLapHoSo;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBacSi;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoiDungHoSo;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhieuKham;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenBenhNhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenBacSi;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayKham;
    }
}