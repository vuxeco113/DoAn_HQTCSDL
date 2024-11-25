namespace GUI
{
    partial class frm_Tri_phieuxetnghiem
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
            this.maphieukham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaykham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chandoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mabacsi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbo_pk = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.matoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ketqua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giakham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_xulyketqua = new System.Windows.Forms.Button();
            this.btn_chidinhxn = new System.Windows.Forms.Button();
            this.cbo_maCD = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cbo_loai = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.maCD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mapk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaichidinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mabenhnhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_kt = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.txt_kqxn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.id_tinhtrangsuckhoe = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // maphieukham
            // 
            this.maphieukham.DataPropertyName = "MaPhieuKham";
            this.maphieukham.HeaderText = "Mã phiếu khám";
            this.maphieukham.MinimumWidth = 6;
            this.maphieukham.Name = "maphieukham";
            this.maphieukham.Width = 125;
            // 
            // ngaykham
            // 
            this.ngaykham.DataPropertyName = "NgayKham";
            this.ngaykham.HeaderText = "Ngày khám";
            this.ngaykham.MinimumWidth = 6;
            this.ngaykham.Name = "ngaykham";
            this.ngaykham.Width = 200;
            // 
            // chandoan
            // 
            this.chandoan.DataPropertyName = "ChanDoan";
            this.chandoan.HeaderText = "Chẩn đoán";
            this.chandoan.MinimumWidth = 6;
            this.chandoan.Name = "chandoan";
            this.chandoan.Width = 250;
            // 
            // mabacsi
            // 
            this.mabacsi.DataPropertyName = "MaBacSi";
            this.mabacsi.HeaderText = "Mã bác sĩ";
            this.mabacsi.MinimumWidth = 6;
            this.mabacsi.Name = "mabacsi";
            this.mabacsi.Width = 150;
            // 
            // cbo_pk
            // 
            this.cbo_pk.FormattingEnabled = true;
            this.cbo_pk.Location = new System.Drawing.Point(885, 38);
            this.cbo_pk.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cbo_pk.Name = "cbo_pk";
            this.cbo_pk.Size = new System.Drawing.Size(165, 31);
            this.cbo_pk.TabIndex = 72;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(682, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 23);
            this.label1.TabIndex = 84;
            this.label1.Text = "Mã phiếu khám";
            // 
            // matoa
            // 
            this.matoa.DataPropertyName = "MaToa";
            this.matoa.HeaderText = "Mã toa";
            this.matoa.MinimumWidth = 6;
            this.matoa.Name = "matoa";
            this.matoa.Width = 125;
            // 
            // ketqua
            // 
            this.ketqua.DataPropertyName = "KetQua";
            this.ketqua.HeaderText = "Kết quả";
            this.ketqua.MinimumWidth = 6;
            this.ketqua.Name = "ketqua";
            this.ketqua.Width = 250;
            // 
            // giakham
            // 
            this.giakham.DataPropertyName = "GiaKham";
            this.giakham.HeaderText = "Giá khám";
            this.giakham.MinimumWidth = 6;
            this.giakham.Name = "giakham";
            this.giakham.Width = 125;
            // 
            // btn_xulyketqua
            // 
            this.btn_xulyketqua.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xulyketqua.Location = new System.Drawing.Point(821, 27);
            this.btn_xulyketqua.Margin = new System.Windows.Forms.Padding(4);
            this.btn_xulyketqua.Name = "btn_xulyketqua";
            this.btn_xulyketqua.Size = new System.Drawing.Size(230, 44);
            this.btn_xulyketqua.TabIndex = 78;
            this.btn_xulyketqua.Text = "Xử lý kết quả";
            this.btn_xulyketqua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_xulyketqua.UseVisualStyleBackColor = true;
            this.btn_xulyketqua.Click += new System.EventHandler(this.btn_xulyketqua_Click);
            // 
            // btn_chidinhxn
            // 
            this.btn_chidinhxn.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_chidinhxn.Location = new System.Drawing.Point(332, 33);
            this.btn_chidinhxn.Margin = new System.Windows.Forms.Padding(4);
            this.btn_chidinhxn.Name = "btn_chidinhxn";
            this.btn_chidinhxn.Size = new System.Drawing.Size(232, 44);
            this.btn_chidinhxn.TabIndex = 92;
            this.btn_chidinhxn.Text = " Chỉ định xét nghiệm";
            this.btn_chidinhxn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_chidinhxn.UseVisualStyleBackColor = true;
            this.btn_chidinhxn.Click += new System.EventHandler(this.btn_chidinhxn_Click);
            // 
            // cbo_maCD
            // 
            this.cbo_maCD.FormattingEnabled = true;
            this.cbo_maCD.Location = new System.Drawing.Point(1266, 98);
            this.cbo_maCD.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cbo_maCD.Name = "cbo_maCD";
            this.cbo_maCD.Size = new System.Drawing.Size(165, 31);
            this.cbo_maCD.TabIndex = 90;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(1107, 101);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 23);
            this.label6.TabIndex = 91;
            this.label6.Text = "Mã chỉ định";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(1266, 41);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(165, 30);
            this.dateTimePicker1.TabIndex = 89;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(1107, 47);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 23);
            this.label5.TabIndex = 88;
            this.label5.Text = "Ngày chỉ định";
            // 
            // cbo_loai
            // 
            this.cbo_loai.FormattingEnabled = true;
            this.cbo_loai.Location = new System.Drawing.Point(885, 98);
            this.cbo_loai.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cbo_loai.Name = "cbo_loai";
            this.cbo_loai.Size = new System.Drawing.Size(165, 31);
            this.cbo_loai.TabIndex = 85;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(682, 98);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 23);
            this.label4.TabIndex = 86;
            this.label4.Text = "Loại chỉ định";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maCD,
            this.mapk,
            this.loaichidinh,
            this.ngay});
            this.dataGridView1.Location = new System.Drawing.Point(63, 154);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1253, 121);
            this.dataGridView1.TabIndex = 74;
            // 
            // maCD
            // 
            this.maCD.DataPropertyName = "MaChiDinh";
            this.maCD.HeaderText = "Mã chỉ định";
            this.maCD.MinimumWidth = 6;
            this.maCD.Name = "maCD";
            this.maCD.Width = 300;
            // 
            // mapk
            // 
            this.mapk.DataPropertyName = "MaPhieuKham";
            this.mapk.HeaderText = "Mã phiếu khám";
            this.mapk.MinimumWidth = 6;
            this.mapk.Name = "mapk";
            this.mapk.Width = 300;
            // 
            // loaichidinh
            // 
            this.loaichidinh.DataPropertyName = "LoaiChiDinh";
            this.loaichidinh.HeaderText = "Loại chỉ định";
            this.loaichidinh.MinimumWidth = 6;
            this.loaichidinh.Name = "loaichidinh";
            this.loaichidinh.Width = 300;
            // 
            // ngay
            // 
            this.ngay.DataPropertyName = "NgayChiDinh";
            this.ngay.HeaderText = "Ngày chỉ định";
            this.ngay.MinimumWidth = 6;
            this.ngay.Name = "ngay";
            this.ngay.Width = 300;
            // 
            // mabenhnhan
            // 
            this.mabenhnhan.DataPropertyName = "MaBenhNhan";
            this.mabenhnhan.HeaderText = "Mã bệnh nhân";
            this.mabenhnhan.MinimumWidth = 6;
            this.mabenhnhan.Name = "mabenhnhan";
            this.mabenhnhan.Width = 250;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(18, 39);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 20);
            this.label3.TabIndex = 76;
            this.label3.Text = "Kết quả xét nghiệm";
            // 
            // btn_kt
            // 
            this.btn_kt.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_kt.Location = new System.Drawing.Point(30, 33);
            this.btn_kt.Margin = new System.Windows.Forms.Padding(4);
            this.btn_kt.Name = "btn_kt";
            this.btn_kt.Size = new System.Drawing.Size(233, 44);
            this.btn_kt.TabIndex = 25;
            this.btn_kt.Text = "Kiểm tra tình trạng sức khỏe trước";
            this.btn_kt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_kt.UseVisualStyleBackColor = true;
            this.btn_kt.Click += new System.EventHandler(this.btn_kt_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView2);
            this.groupBox1.Controls.Add(this.btn_xulyketqua);
            this.groupBox1.Controls.Add(this.txt_kqxn);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 335);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1455, 288);
            this.groupBox1.TabIndex = 91;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Xử lý kết quả xét nghiệm";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maphieukham,
            this.mabenhnhan,
            this.ngaykham,
            this.chandoan,
            this.mabacsi,
            this.matoa,
            this.ketqua,
            this.giakham});
            this.dataGridView2.Location = new System.Drawing.Point(64, 79);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1253, 184);
            this.dataGridView2.TabIndex = 88;
            // 
            // txt_kqxn
            // 
            this.txt_kqxn.Location = new System.Drawing.Point(213, 27);
            this.txt_kqxn.Multiline = true;
            this.txt_kqxn.Name = "txt_kqxn";
            this.txt_kqxn.Size = new System.Drawing.Size(530, 43);
            this.txt_kqxn.TabIndex = 77;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(600, 1);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(292, 32);
            this.label2.TabIndex = 90;
            this.label2.Text = "PHIẾU XÉT NGHIỆM";
            // 
            // id_tinhtrangsuckhoe
            // 
            this.id_tinhtrangsuckhoe.AutoSize = true;
            this.id_tinhtrangsuckhoe.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_tinhtrangsuckhoe.ForeColor = System.Drawing.Color.Black;
            this.id_tinhtrangsuckhoe.Location = new System.Drawing.Point(8, 97);
            this.id_tinhtrangsuckhoe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.id_tinhtrangsuckhoe.Name = "id_tinhtrangsuckhoe";
            this.id_tinhtrangsuckhoe.Size = new System.Drawing.Size(217, 25);
            this.id_tinhtrangsuckhoe.TabIndex = 73;
            this.id_tinhtrangsuckhoe.Text = "id_tinhtrangsuckhoe";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_chidinhxn);
            this.groupBox3.Controls.Add(this.cbo_maCD);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.dateTimePicker1);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.cbo_loai);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Controls.Add(this.cbo_pk);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.btn_kt);
            this.groupBox3.Controls.Add(this.id_tinhtrangsuckhoe);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(4, 37);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(1454, 282);
            this.groupBox3.TabIndex = 88;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chỉ định xét nghiệm";
            // 
            // frm_Tri_phieuxetnghiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1660, 716);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frm_Tri_phieuxetnghiem";
            this.Text = "Phiếu Xét Nghiệm";
            this.Load += new System.EventHandler(this.frm_Tri_phieuxetnghiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn maphieukham;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaykham;
        private System.Windows.Forms.DataGridViewTextBoxColumn chandoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn mabacsi;
        private System.Windows.Forms.ComboBox cbo_pk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn matoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ketqua;
        private System.Windows.Forms.DataGridViewTextBoxColumn giakham;
        private System.Windows.Forms.Button btn_xulyketqua;
        private System.Windows.Forms.Button btn_chidinhxn;
        private System.Windows.Forms.ComboBox cbo_maCD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbo_loai;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maCD;
        private System.Windows.Forms.DataGridViewTextBoxColumn mapk;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaichidinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngay;
        private System.Windows.Forms.DataGridViewTextBoxColumn mabenhnhan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_kt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox txt_kqxn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label id_tinhtrangsuckhoe;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}