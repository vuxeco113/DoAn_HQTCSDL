namespace GUI
{
    partial class frm_QuanLyBenhNhan
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
            this.btn_thoat = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mabn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotenbn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mabhyt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tuoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tukhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.denkhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tinhtrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.txt_tuoi = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_nhapvien = new System.Windows.Forms.Button();
            this.btn_xuatvien = new System.Windows.Forms.Button();
            this.cbo_tinhtrang = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbo_tukhoa = new System.Windows.Forms.ComboBox();
            this.cbo_denkhoa = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePicker1_ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.txt_BHYT2 = new System.Windows.Forms.TextBox();
            this.txt_dc = new System.Windows.Forms.TextBox();
            this.txt_HT2 = new System.Windows.Forms.TextBox();
            this.txt_MBN2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbo_gioitinh = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(1164, 602);
            this.btn_thoat.Margin = new System.Windows.Forms.Padding(4);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(261, 41);
            this.btn_thoat.TabIndex = 38;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mabn,
            this.hotenbn,
            this.ngaysinh,
            this.gioitinh,
            this.sdt,
            this.mabhyt,
            this.diachi,
            this.tuoi,
            this.tukhoa,
            this.denkhoa,
            this.tinhtrang});
            this.dataGridView1.Location = new System.Drawing.Point(30, 393);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1395, 191);
            this.dataGridView1.TabIndex = 37;
            // 
            // mabn
            // 
            this.mabn.HeaderText = "Mã bệnh nhân";
            this.mabn.MinimumWidth = 6;
            this.mabn.Name = "mabn";
            this.mabn.Width = 125;
            // 
            // hotenbn
            // 
            this.hotenbn.HeaderText = "Họ tên bệnh nhân";
            this.hotenbn.MinimumWidth = 6;
            this.hotenbn.Name = "hotenbn";
            this.hotenbn.Width = 125;
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
            this.diachi.HeaderText = "Địa chỉ";
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_xoa);
            this.groupBox2.Controls.Add(this.btn_sua);
            this.groupBox2.Controls.Add(this.btn_them);
            this.groupBox2.Controls.Add(this.txt_tuoi);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.btn_nhapvien);
            this.groupBox2.Controls.Add(this.btn_xuatvien);
            this.groupBox2.Controls.Add(this.cbo_tinhtrang);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.cbo_tukhoa);
            this.groupBox2.Controls.Add(this.cbo_denkhoa);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.dateTimePicker1_ngaysinh);
            this.groupBox2.Controls.Add(this.txt_sdt);
            this.groupBox2.Controls.Add(this.txt_BHYT2);
            this.groupBox2.Controls.Add(this.txt_dc);
            this.groupBox2.Controls.Add(this.txt_HT2);
            this.groupBox2.Controls.Add(this.txt_MBN2);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.cbo_gioitinh);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(28, 32);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1397, 353);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Quản lý";
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(1092, 286);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(4);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(136, 42);
            this.btn_xoa.TabIndex = 36;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(1238, 286);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(4);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(132, 42);
            this.btn_sua.TabIndex = 35;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(912, 286);
            this.btn_them.Margin = new System.Windows.Forms.Padding(4);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(140, 42);
            this.btn_them.TabIndex = 34;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            // 
            // txt_tuoi
            // 
            this.txt_tuoi.Enabled = false;
            this.txt_tuoi.Location = new System.Drawing.Point(664, 216);
            this.txt_tuoi.Margin = new System.Windows.Forms.Padding(4);
            this.txt_tuoi.Name = "txt_tuoi";
            this.txt_tuoi.Size = new System.Drawing.Size(219, 22);
            this.txt_tuoi.TabIndex = 33;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(532, 215);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 16);
            this.label12.TabIndex = 32;
            this.label12.Text = "Tuổi :";
            // 
            // btn_nhapvien
            // 
            this.btn_nhapvien.Location = new System.Drawing.Point(1062, 221);
            this.btn_nhapvien.Margin = new System.Windows.Forms.Padding(4);
            this.btn_nhapvien.Name = "btn_nhapvien";
            this.btn_nhapvien.Size = new System.Drawing.Size(106, 27);
            this.btn_nhapvien.TabIndex = 10;
            this.btn_nhapvien.Text = "Nhập viện";
            this.btn_nhapvien.UseVisualStyleBackColor = true;
            // 
            // btn_xuatvien
            // 
            this.btn_xuatvien.Location = new System.Drawing.Point(1252, 221);
            this.btn_xuatvien.Margin = new System.Windows.Forms.Padding(4);
            this.btn_xuatvien.Name = "btn_xuatvien";
            this.btn_xuatvien.Size = new System.Drawing.Size(106, 27);
            this.btn_xuatvien.TabIndex = 11;
            this.btn_xuatvien.Text = "Xuất viện";
            this.btn_xuatvien.UseVisualStyleBackColor = true;
            // 
            // cbo_tinhtrang
            // 
            this.cbo_tinhtrang.FormattingEnabled = true;
            this.cbo_tinhtrang.Location = new System.Drawing.Point(1063, 170);
            this.cbo_tinhtrang.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_tinhtrang.Name = "cbo_tinhtrang";
            this.cbo_tinhtrang.Size = new System.Drawing.Size(295, 24);
            this.cbo_tinhtrang.TabIndex = 31;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(946, 178);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 16);
            this.label11.TabIndex = 30;
            this.label11.Text = "Tình trạng :";
            // 
            // cbo_tukhoa
            // 
            this.cbo_tukhoa.FormattingEnabled = true;
            this.cbo_tukhoa.Location = new System.Drawing.Point(1063, 87);
            this.cbo_tukhoa.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_tukhoa.Name = "cbo_tukhoa";
            this.cbo_tukhoa.Size = new System.Drawing.Size(295, 24);
            this.cbo_tukhoa.TabIndex = 29;
            // 
            // cbo_denkhoa
            // 
            this.cbo_denkhoa.FormattingEnabled = true;
            this.cbo_denkhoa.Location = new System.Drawing.Point(1062, 133);
            this.cbo_denkhoa.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_denkhoa.Name = "cbo_denkhoa";
            this.cbo_denkhoa.Size = new System.Drawing.Size(295, 24);
            this.cbo_denkhoa.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(946, 136);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 16);
            this.label10.TabIndex = 27;
            this.label10.Text = "Đến khoa :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(946, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 16);
            this.label9.TabIndex = 26;
            this.label9.Text = "Từ khoa :";
            // 
            // dateTimePicker1_ngaysinh
            // 
            this.dateTimePicker1_ngaysinh.Location = new System.Drawing.Point(172, 172);
            this.dateTimePicker1_ngaysinh.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1_ngaysinh.Name = "dateTimePicker1_ngaysinh";
            this.dateTimePicker1_ngaysinh.Size = new System.Drawing.Size(295, 22);
            this.dateTimePicker1_ngaysinh.TabIndex = 20;
            // 
            // txt_sdt
            // 
            this.txt_sdt.Location = new System.Drawing.Point(664, 84);
            this.txt_sdt.Margin = new System.Windows.Forms.Padding(4);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(219, 22);
            this.txt_sdt.TabIndex = 24;
            // 
            // txt_BHYT2
            // 
            this.txt_BHYT2.Location = new System.Drawing.Point(664, 128);
            this.txt_BHYT2.Margin = new System.Windows.Forms.Padding(4);
            this.txt_BHYT2.Name = "txt_BHYT2";
            this.txt_BHYT2.Size = new System.Drawing.Size(219, 22);
            this.txt_BHYT2.TabIndex = 23;
            // 
            // txt_dc
            // 
            this.txt_dc.Location = new System.Drawing.Point(664, 170);
            this.txt_dc.Margin = new System.Windows.Forms.Padding(4);
            this.txt_dc.Name = "txt_dc";
            this.txt_dc.Size = new System.Drawing.Size(219, 22);
            this.txt_dc.TabIndex = 22;
            // 
            // txt_HT2
            // 
            this.txt_HT2.Location = new System.Drawing.Point(172, 128);
            this.txt_HT2.Margin = new System.Windows.Forms.Padding(4);
            this.txt_HT2.Name = "txt_HT2";
            this.txt_HT2.Size = new System.Drawing.Size(295, 22);
            this.txt_HT2.TabIndex = 21;
            // 
            // txt_MBN2
            // 
            this.txt_MBN2.Location = new System.Drawing.Point(172, 79);
            this.txt_MBN2.Margin = new System.Windows.Forms.Padding(4);
            this.txt_MBN2.Name = "txt_MBN2";
            this.txt_MBN2.Size = new System.Drawing.Size(295, 22);
            this.txt_MBN2.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(532, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 16);
            this.label8.TabIndex = 18;
            this.label8.Text = "SDT:";
            // 
            // cbo_gioitinh
            // 
            this.cbo_gioitinh.FormattingEnabled = true;
            this.cbo_gioitinh.Location = new System.Drawing.Point(172, 207);
            this.cbo_gioitinh.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_gioitinh.Name = "cbo_gioitinh";
            this.cbo_gioitinh.Size = new System.Drawing.Size(295, 24);
            this.cbo_gioitinh.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(532, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Mã BHYT :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(532, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Địa chỉ :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(0, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Ngày sinh :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(0, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Mã bệnh nhân : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(438, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 32);
            this.label1.TabIndex = 10;
            this.label1.Text = "QUẢN LÝ BỆNH NHÂN ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(0, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Họ tên bệnh nhân :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(0, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Giới tính :";
            // 
            // frm_QuanLyBenhNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1451, 683);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frm_QuanLyBenhNhan";
            this.Text = "frm_QuanLyBenhNhan";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mabn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotenbn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn mabhyt;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn tuoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn tukhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn denkhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn tinhtrang;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.TextBox txt_tuoi;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_nhapvien;
        private System.Windows.Forms.Button btn_xuatvien;
        private System.Windows.Forms.ComboBox cbo_tinhtrang;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbo_tukhoa;
        private System.Windows.Forms.ComboBox cbo_denkhoa;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimePicker1_ngaysinh;
        private System.Windows.Forms.TextBox txt_sdt;
        private System.Windows.Forms.TextBox txt_BHYT2;
        private System.Windows.Forms.TextBox txt_dc;
        private System.Windows.Forms.TextBox txt_HT2;
        private System.Windows.Forms.TextBox txt_MBN2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbo_gioitinh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}