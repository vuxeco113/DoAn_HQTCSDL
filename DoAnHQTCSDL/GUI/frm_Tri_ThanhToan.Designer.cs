namespace GUI
{
    partial class frm_Tri_ThanhToan
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_chuandoan = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_mabacsi_ketoa = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePicker1_ngaythanhtoan = new System.Windows.Forms.DateTimePicker();
            this.txt_mathanhtoan = new System.Windows.Forms.TextBox();
            this.txt_maphieukham = new System.Windows.Forms.TextBox();
            this.cbo_matoathuoc = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.maphieukkham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mathanhtoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaythanhtoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mabacsi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mabenhnhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sotien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_huy
            // 
            this.btn_huy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_huy.Location = new System.Drawing.Point(1251, 606);
            this.btn_huy.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(145, 48);
            this.btn_huy.TabIndex = 77;
            this.btn_huy.Text = "Hủy";
            this.btn_huy.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_xoa);
            this.groupBox1.Controls.Add(this.btn_sua);
            this.groupBox1.Controls.Add(this.btn_them);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txt_chuandoan);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txt_mabacsi_ketoa);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.dateTimePicker1_ngaythanhtoan);
            this.groupBox1.Controls.Add(this.txt_mathanhtoan);
            this.groupBox1.Controls.Add(this.txt_maphieukham);
            this.groupBox1.Controls.Add(this.cbo_matoathuoc);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(21, 45);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(1375, 429);
            this.groupBox1.TabIndex = 76;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thanh toán";
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(873, 277);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(148, 48);
            this.btn_xoa.TabIndex = 73;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(1061, 277);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(143, 48);
            this.btn_sua.TabIndex = 72;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            // 
            // btn_them
            // 
            this.btn_them.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.Location = new System.Drawing.Point(674, 277);
            this.btn_them.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(145, 48);
            this.btn_them.TabIndex = 71;
            this.btn_them.Text = "Thêm ";
            this.btn_them.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(544, 32);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(249, 25);
            this.label13.TabIndex = 70;
            this.label13.Text = "PHIẾU THANH TOÁN";
            // 
            // txt_chuandoan
            // 
            this.txt_chuandoan.Location = new System.Drawing.Point(935, 221);
            this.txt_chuandoan.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txt_chuandoan.Name = "txt_chuandoan";
            this.txt_chuandoan.Size = new System.Drawing.Size(253, 30);
            this.txt_chuandoan.TabIndex = 65;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(673, 220);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 23);
            this.label10.TabIndex = 64;
            this.label10.Text = "Số tiền :";
            // 
            // txt_mabacsi_ketoa
            // 
            this.txt_mabacsi_ketoa.Location = new System.Drawing.Point(935, 89);
            this.txt_mabacsi_ketoa.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txt_mabacsi_ketoa.Name = "txt_mabacsi_ketoa";
            this.txt_mabacsi_ketoa.Size = new System.Drawing.Size(253, 30);
            this.txt_mabacsi_ketoa.TabIndex = 63;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(673, 103);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(159, 23);
            this.label9.TabIndex = 62;
            this.label9.Text = "Mã bác sĩ kê toa :";
            // 
            // dateTimePicker1_ngaythanhtoan
            // 
            this.dateTimePicker1_ngaythanhtoan.Location = new System.Drawing.Point(236, 212);
            this.dateTimePicker1_ngaythanhtoan.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.dateTimePicker1_ngaythanhtoan.Name = "dateTimePicker1_ngaythanhtoan";
            this.dateTimePicker1_ngaythanhtoan.Size = new System.Drawing.Size(295, 30);
            this.dateTimePicker1_ngaythanhtoan.TabIndex = 51;
            // 
            // txt_mathanhtoan
            // 
            this.txt_mathanhtoan.Location = new System.Drawing.Point(236, 155);
            this.txt_mathanhtoan.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txt_mathanhtoan.Name = "txt_mathanhtoan";
            this.txt_mathanhtoan.Size = new System.Drawing.Size(295, 30);
            this.txt_mathanhtoan.TabIndex = 53;
            // 
            // txt_maphieukham
            // 
            this.txt_maphieukham.Location = new System.Drawing.Point(236, 94);
            this.txt_maphieukham.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txt_maphieukham.Name = "txt_maphieukham";
            this.txt_maphieukham.Size = new System.Drawing.Size(295, 30);
            this.txt_maphieukham.TabIndex = 52;
            // 
            // cbo_matoathuoc
            // 
            this.cbo_matoathuoc.FormattingEnabled = true;
            this.cbo_matoathuoc.Location = new System.Drawing.Point(935, 157);
            this.cbo_matoathuoc.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cbo_matoathuoc.Name = "cbo_matoathuoc";
            this.cbo_matoathuoc.Size = new System.Drawing.Size(253, 31);
            this.cbo_matoathuoc.TabIndex = 46;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(8, 210);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 23);
            this.label5.TabIndex = 50;
            this.label5.Text = "Ngày thanh toán :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(8, 97);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 23);
            this.label4.TabIndex = 49;
            this.label4.Text = "Mã phiếu khám :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(7, 160);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 23);
            this.label2.TabIndex = 47;
            this.label2.Text = "Mã thanh toán :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(673, 166);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 23);
            this.label3.TabIndex = 48;
            this.label3.Text = "Mã bệnh nhân :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maphieukkham,
            this.mathanhtoan,
            this.ngaythanhtoan,
            this.mabacsi,
            this.mabenhnhan,
            this.Sotien});
            this.dataGridView1.Location = new System.Drawing.Point(21, 469);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1375, 110);
            this.dataGridView1.TabIndex = 75;
            // 
            // maphieukkham
            // 
            this.maphieukkham.HeaderText = "Mã phiếu khám";
            this.maphieukkham.MinimumWidth = 6;
            this.maphieukkham.Name = "maphieukkham";
            this.maphieukkham.Width = 125;
            // 
            // mathanhtoan
            // 
            this.mathanhtoan.HeaderText = "Mã thanh toán";
            this.mathanhtoan.MinimumWidth = 6;
            this.mathanhtoan.Name = "mathanhtoan";
            this.mathanhtoan.Width = 125;
            // 
            // ngaythanhtoan
            // 
            this.ngaythanhtoan.HeaderText = "Ngày thanh toán";
            this.ngaythanhtoan.MinimumWidth = 6;
            this.ngaythanhtoan.Name = "ngaythanhtoan";
            this.ngaythanhtoan.Width = 125;
            // 
            // mabacsi
            // 
            this.mabacsi.HeaderText = "Mã bác sĩ kê toa";
            this.mabacsi.MinimumWidth = 6;
            this.mabacsi.Name = "mabacsi";
            this.mabacsi.Width = 125;
            // 
            // mabenhnhan
            // 
            this.mabenhnhan.HeaderText = "Họ tên bệnh nhân";
            this.mabenhnhan.MinimumWidth = 6;
            this.mabenhnhan.Name = "mabenhnhan";
            this.mabenhnhan.Width = 125;
            // 
            // Sotien
            // 
            this.Sotien.HeaderText = "Số tiền";
            this.Sotien.MinimumWidth = 6;
            this.Sotien.Name = "Sotien";
            this.Sotien.Width = 125;
            // 
            // frm_Tri_ThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1417, 698);
            this.Controls.Add(this.btn_huy);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frm_Tri_ThanhToan";
            this.Text = "frm_Tri_ThanhToan";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_huy;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_chuandoan;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_mabacsi_ketoa;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimePicker1_ngaythanhtoan;
        private System.Windows.Forms.TextBox txt_mathanhtoan;
        private System.Windows.Forms.TextBox txt_maphieukham;
        private System.Windows.Forms.ComboBox cbo_matoathuoc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maphieukkham;
        private System.Windows.Forms.DataGridViewTextBoxColumn mathanhtoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaythanhtoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn mabacsi;
        private System.Windows.Forms.DataGridViewTextBoxColumn mabenhnhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sotien;
    }
}