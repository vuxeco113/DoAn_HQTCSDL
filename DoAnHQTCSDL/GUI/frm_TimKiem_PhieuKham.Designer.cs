namespace GUI
{
    partial class frm_TimKiem_PhieuKham
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
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.btn_huy = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.maphieukham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mabenhnhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaykham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chandoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mabacsi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ketqua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbo_matoa = new System.Windows.Forms.ComboBox();
            this.rdo_matoa = new System.Windows.Forms.RadioButton();
            this.rdo_ngaykham = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1_ngaykham = new System.Windows.Forms.DateTimePicker();
            this.rdo_mabacsi = new System.Windows.Forms.RadioButton();
            this.cbo_mabacsi = new System.Windows.Forms.ComboBox();
            this.cbo_maphieukham = new System.Windows.Forms.ComboBox();
            this.rdo_matoathuoc = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_timkiem.ForeColor = System.Drawing.Color.Black;
            this.btn_timkiem.Location = new System.Drawing.Point(1029, 509);
            this.btn_timkiem.Margin = new System.Windows.Forms.Padding(4);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(137, 47);
            this.btn_timkiem.TabIndex = 56;
            this.btn_timkiem.Text = "Tìm kiếm";
            this.btn_timkiem.UseVisualStyleBackColor = true;
            // 
            // btn_huy
            // 
            this.btn_huy.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_huy.ForeColor = System.Drawing.Color.Black;
            this.btn_huy.Location = new System.Drawing.Point(1222, 509);
            this.btn_huy.Margin = new System.Windows.Forms.Padding(4);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(137, 47);
            this.btn_huy.TabIndex = 55;
            this.btn_huy.Text = "Hủy";
            this.btn_huy.UseVisualStyleBackColor = true;
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
            this.ketqua});
            this.dataGridView1.Location = new System.Drawing.Point(24, 251);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1345, 242);
            this.dataGridView1.TabIndex = 54;
            // 
            // maphieukham
            // 
            this.maphieukham.HeaderText = "Mã phiếu khám";
            this.maphieukham.MinimumWidth = 6;
            this.maphieukham.Name = "maphieukham";
            this.maphieukham.Width = 125;
            // 
            // mabenhnhan
            // 
            this.mabenhnhan.HeaderText = "Mã bệnh nhân";
            this.mabenhnhan.MinimumWidth = 6;
            this.mabenhnhan.Name = "mabenhnhan";
            this.mabenhnhan.Width = 125;
            // 
            // ngaykham
            // 
            this.ngaykham.HeaderText = "Ngày khám";
            this.ngaykham.MinimumWidth = 6;
            this.ngaykham.Name = "ngaykham";
            this.ngaykham.Width = 125;
            // 
            // chandoan
            // 
            this.chandoan.HeaderText = "Chẩn đoán";
            this.chandoan.MinimumWidth = 6;
            this.chandoan.Name = "chandoan";
            this.chandoan.Width = 150;
            // 
            // mabacsi
            // 
            this.mabacsi.HeaderText = "Mã bác sĩ";
            this.mabacsi.MinimumWidth = 6;
            this.mabacsi.Name = "mabacsi";
            this.mabacsi.Width = 125;
            // 
            // matoa
            // 
            this.matoa.HeaderText = "Mã toa";
            this.matoa.MinimumWidth = 6;
            this.matoa.Name = "matoa";
            this.matoa.Width = 125;
            // 
            // ketqua
            // 
            this.ketqua.HeaderText = "Kết quả";
            this.ketqua.MinimumWidth = 6;
            this.ketqua.Name = "ketqua";
            this.ketqua.Width = 200;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbo_matoa);
            this.groupBox1.Controls.Add(this.rdo_matoa);
            this.groupBox1.Controls.Add(this.rdo_ngaykham);
            this.groupBox1.Controls.Add(this.dateTimePicker1_ngaykham);
            this.groupBox1.Controls.Add(this.rdo_mabacsi);
            this.groupBox1.Controls.Add(this.cbo_mabacsi);
            this.groupBox1.Controls.Add(this.cbo_maphieukham);
            this.groupBox1.Controls.Add(this.rdo_matoathuoc);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(24, 52);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1345, 179);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm phiếu khám";
            // 
            // cbo_matoa
            // 
            this.cbo_matoa.FormattingEnabled = true;
            this.cbo_matoa.Location = new System.Drawing.Point(870, 110);
            this.cbo_matoa.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cbo_matoa.Name = "cbo_matoa";
            this.cbo_matoa.Size = new System.Drawing.Size(360, 31);
            this.cbo_matoa.TabIndex = 64;
            // 
            // rdo_matoa
            // 
            this.rdo_matoa.AutoSize = true;
            this.rdo_matoa.ForeColor = System.Drawing.Color.Black;
            this.rdo_matoa.Location = new System.Drawing.Point(624, 105);
            this.rdo_matoa.Margin = new System.Windows.Forms.Padding(4);
            this.rdo_matoa.Name = "rdo_matoa";
            this.rdo_matoa.Size = new System.Drawing.Size(154, 27);
            this.rdo_matoa.TabIndex = 63;
            this.rdo_matoa.Text = "Mã toa thuốc :";
            this.rdo_matoa.UseVisualStyleBackColor = true;
            // 
            // rdo_ngaykham
            // 
            this.rdo_ngaykham.AutoSize = true;
            this.rdo_ngaykham.ForeColor = System.Drawing.Color.Black;
            this.rdo_ngaykham.Location = new System.Drawing.Point(624, 55);
            this.rdo_ngaykham.Margin = new System.Windows.Forms.Padding(4);
            this.rdo_ngaykham.Name = "rdo_ngaykham";
            this.rdo_ngaykham.Size = new System.Drawing.Size(138, 27);
            this.rdo_ngaykham.TabIndex = 62;
            this.rdo_ngaykham.Text = "Ngày khám :";
            this.rdo_ngaykham.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1_ngaykham
            // 
            this.dateTimePicker1_ngaykham.Location = new System.Drawing.Point(870, 56);
            this.dateTimePicker1_ngaykham.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.dateTimePicker1_ngaykham.Name = "dateTimePicker1_ngaykham";
            this.dateTimePicker1_ngaykham.Size = new System.Drawing.Size(360, 30);
            this.dateTimePicker1_ngaykham.TabIndex = 59;
            // 
            // rdo_mabacsi
            // 
            this.rdo_mabacsi.AutoSize = true;
            this.rdo_mabacsi.ForeColor = System.Drawing.Color.Black;
            this.rdo_mabacsi.Location = new System.Drawing.Point(56, 111);
            this.rdo_mabacsi.Margin = new System.Windows.Forms.Padding(4);
            this.rdo_mabacsi.Name = "rdo_mabacsi";
            this.rdo_mabacsi.Size = new System.Drawing.Size(123, 27);
            this.rdo_mabacsi.TabIndex = 49;
            this.rdo_mabacsi.Text = "Mã bác sĩ :";
            this.rdo_mabacsi.UseVisualStyleBackColor = true;
            // 
            // cbo_mabacsi
            // 
            this.cbo_mabacsi.FormattingEnabled = true;
            this.cbo_mabacsi.Location = new System.Drawing.Point(278, 105);
            this.cbo_mabacsi.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cbo_mabacsi.Name = "cbo_mabacsi";
            this.cbo_mabacsi.Size = new System.Drawing.Size(249, 31);
            this.cbo_mabacsi.TabIndex = 48;
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
            // rdo_matoathuoc
            // 
            this.rdo_matoathuoc.AutoSize = true;
            this.rdo_matoathuoc.ForeColor = System.Drawing.Color.Black;
            this.rdo_matoathuoc.Location = new System.Drawing.Point(56, 50);
            this.rdo_matoathuoc.Margin = new System.Windows.Forms.Padding(4);
            this.rdo_matoathuoc.Name = "rdo_matoathuoc";
            this.rdo_matoathuoc.Size = new System.Drawing.Size(172, 27);
            this.rdo_matoathuoc.TabIndex = 18;
            this.rdo_matoathuoc.Text = "Mã phiếu khám :";
            this.rdo_matoathuoc.UseVisualStyleBackColor = true;
            // 
            // frm_TimKiem_PhieuKham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1402, 686);
            this.Controls.Add(this.btn_timkiem);
            this.Controls.Add(this.btn_huy);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_TimKiem_PhieuKham";
            this.Text = "frm_TimKiem_PhieuKham";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_timkiem;
        private System.Windows.Forms.Button btn_huy;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maphieukham;
        private System.Windows.Forms.DataGridViewTextBoxColumn mabenhnhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaykham;
        private System.Windows.Forms.DataGridViewTextBoxColumn chandoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn mabacsi;
        private System.Windows.Forms.DataGridViewTextBoxColumn matoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ketqua;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbo_matoa;
        private System.Windows.Forms.RadioButton rdo_matoa;
        private System.Windows.Forms.RadioButton rdo_ngaykham;
        private System.Windows.Forms.DateTimePicker dateTimePicker1_ngaykham;
        private System.Windows.Forms.RadioButton rdo_mabacsi;
        private System.Windows.Forms.ComboBox cbo_mabacsi;
        private System.Windows.Forms.ComboBox cbo_maphieukham;
        private System.Windows.Forms.RadioButton rdo_matoathuoc;
    }
}