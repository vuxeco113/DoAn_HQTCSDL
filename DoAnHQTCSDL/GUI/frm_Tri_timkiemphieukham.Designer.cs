namespace GUI
{
    partial class frm_Tri_timkiemphieukham
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.ketqua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mabacsi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chandoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaykham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mabenhnhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maphieukham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.giakham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.rdo_ngaykham = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1_ngaykham = new System.Windows.Forms.DateTimePicker();
            this.cbo_maphieukham = new System.Windows.Forms.ComboBox();
            this.rdo_maPK = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ketqua
            // 
            this.ketqua.DataPropertyName = "KetQua";
            this.ketqua.HeaderText = "Kết quả";
            this.ketqua.MinimumWidth = 6;
            this.ketqua.Name = "ketqua";
            this.ketqua.Width = 250;
            // 
            // matoa
            // 
            this.matoa.DataPropertyName = "MaToa";
            this.matoa.HeaderText = "Mã toa";
            this.matoa.MinimumWidth = 6;
            this.matoa.Name = "matoa";
            this.matoa.Width = 125;
            // 
            // mabacsi
            // 
            this.mabacsi.DataPropertyName = "MaBacSi";
            this.mabacsi.HeaderText = "Mã bác sĩ";
            this.mabacsi.MinimumWidth = 6;
            this.mabacsi.Name = "mabacsi";
            this.mabacsi.Width = 150;
            // 
            // chandoan
            // 
            this.chandoan.DataPropertyName = "ChanDoan";
            this.chandoan.HeaderText = "Chẩn đoán";
            this.chandoan.MinimumWidth = 6;
            this.chandoan.Name = "chandoan";
            this.chandoan.Width = 250;
            // 
            // ngaykham
            // 
            this.ngaykham.DataPropertyName = "NgayKham";
            this.ngaykham.HeaderText = "Ngày khám";
            this.ngaykham.MinimumWidth = 6;
            this.ngaykham.Name = "ngaykham";
            this.ngaykham.Width = 200;
            // 
            // mabenhnhan
            // 
            this.mabenhnhan.DataPropertyName = "MaBenhNhan";
            this.mabenhnhan.HeaderText = "Mã bệnh nhân";
            this.mabenhnhan.MinimumWidth = 6;
            this.mabenhnhan.Name = "mabenhnhan";
            this.mabenhnhan.Width = 250;
            // 
            // maphieukham
            // 
            this.maphieukham.DataPropertyName = "MaPhieuKham";
            this.maphieukham.HeaderText = "Mã phiếu khám";
            this.maphieukham.MinimumWidth = 6;
            this.maphieukham.Name = "maphieukham";
            this.maphieukham.Width = 125;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maphieukham,
            this.mabenhnhan,
            this.ngaykham,
            this.chandoan,
            this.mabacsi,
            this.matoa,
            this.ketqua,
            this.giakham});
            this.dataGridView1.Location = new System.Drawing.Point(10, 28);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1328, 186);
            this.dataGridView1.TabIndex = 49;
            // 
            // giakham
            // 
            this.giakham.DataPropertyName = "GiaKham";
            this.giakham.HeaderText = "Giá khám";
            this.giakham.MinimumWidth = 6;
            this.giakham.Name = "giakham";
            this.giakham.Width = 125;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(13, 149);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1345, 248);
            this.groupBox2.TabIndex = 57;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DANH SÁCH TÌM KIẾM ";
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_timkiem.ForeColor = System.Drawing.Color.Black;
            this.btn_timkiem.Location = new System.Drawing.Point(598, 39);
            this.btn_timkiem.Margin = new System.Windows.Forms.Padding(4);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(137, 47);
            this.btn_timkiem.TabIndex = 56;
            this.btn_timkiem.Text = "Tìm kiếm";
            this.btn_timkiem.UseVisualStyleBackColor = true;
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // rdo_ngaykham
            // 
            this.rdo_ngaykham.AutoSize = true;
            this.rdo_ngaykham.ForeColor = System.Drawing.Color.Black;
            this.rdo_ngaykham.Location = new System.Drawing.Point(785, 51);
            this.rdo_ngaykham.Margin = new System.Windows.Forms.Padding(4);
            this.rdo_ngaykham.Name = "rdo_ngaykham";
            this.rdo_ngaykham.Size = new System.Drawing.Size(138, 27);
            this.rdo_ngaykham.TabIndex = 62;
            this.rdo_ngaykham.Text = "Ngày khám :";
            this.rdo_ngaykham.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1_ngaykham
            // 
            this.dateTimePicker1_ngaykham.Location = new System.Drawing.Point(960, 51);
            this.dateTimePicker1_ngaykham.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.dateTimePicker1_ngaykham.Name = "dateTimePicker1_ngaykham";
            this.dateTimePicker1_ngaykham.Size = new System.Drawing.Size(360, 30);
            this.dateTimePicker1_ngaykham.TabIndex = 59;
            // 
            // cbo_maphieukham
            // 
            this.cbo_maphieukham.FormattingEnabled = true;
            this.cbo_maphieukham.Location = new System.Drawing.Point(278, 50);
            this.cbo_maphieukham.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cbo_maphieukham.Name = "cbo_maphieukham";
            this.cbo_maphieukham.Size = new System.Drawing.Size(249, 31);
            this.cbo_maphieukham.TabIndex = 47;
            // 
            // rdo_maPK
            // 
            this.rdo_maPK.AutoSize = true;
            this.rdo_maPK.ForeColor = System.Drawing.Color.Black;
            this.rdo_maPK.Location = new System.Drawing.Point(56, 50);
            this.rdo_maPK.Margin = new System.Windows.Forms.Padding(4);
            this.rdo_maPK.Name = "rdo_maPK";
            this.rdo_maPK.Size = new System.Drawing.Size(172, 27);
            this.rdo_maPK.TabIndex = 18;
            this.rdo_maPK.Text = "Mã phiếu khám :";
            this.rdo_maPK.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdo_ngaykham);
            this.groupBox1.Controls.Add(this.btn_timkiem);
            this.groupBox1.Controls.Add(this.dateTimePicker1_ngaykham);
            this.groupBox1.Controls.Add(this.cbo_maphieukham);
            this.groupBox1.Controls.Add(this.rdo_maPK);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1345, 111);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm phiếu khám";
            // 
            // frm_Tri_timkiemphieukham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1416, 545);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_Tri_timkiemphieukham";
            this.Text = "frm_TimKiem_PhieuKham";
            this.Load += new System.EventHandler(this.frm_Tri_timkiemphieukham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ketqua;
        private System.Windows.Forms.DataGridViewTextBoxColumn matoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn mabacsi;
        private System.Windows.Forms.DataGridViewTextBoxColumn chandoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaykham;
        private System.Windows.Forms.DataGridViewTextBoxColumn mabenhnhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn maphieukham;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn giakham;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_timkiem;
        private System.Windows.Forms.RadioButton rdo_ngaykham;
        private System.Windows.Forms.DateTimePicker dateTimePicker1_ngaykham;
        private System.Windows.Forms.ComboBox cbo_maphieukham;
        private System.Windows.Forms.RadioButton rdo_maPK;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}