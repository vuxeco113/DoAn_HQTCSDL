namespace GUI
{
    partial class frmLayThuoc
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnLayThuoc = new System.Windows.Forms.Button();
            this.btnTimToaThuoc = new System.Windows.Forms.Button();
            this.txtMaToaThuoc = new System.Windows.Forms.TextBox();
            this.txtMaBS = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSoLoaiThuoc = new System.Windows.Forms.TextBox();
            this.txtNgayKetThuc = new System.Windows.Forms.TextBox();
            this.txtSoNgayDung = new System.Windows.Forms.TextBox();
            this.txtNgayKetToa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView_ChiTietToa = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ChiTietToa)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnThanhToan);
            this.groupBox1.Controls.Add(this.btnLayThuoc);
            this.groupBox1.Controls.Add(this.btnTimToaThuoc);
            this.groupBox1.Controls.Add(this.txtMaToaThuoc);
            this.groupBox1.Controls.Add(this.txtMaBS);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtSoLoaiThuoc);
            this.groupBox1.Controls.Add(this.txtNgayKetThuc);
            this.groupBox1.Controls.Add(this.txtSoNgayDung);
            this.groupBox1.Controls.Add(this.txtNgayKetToa);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(137, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1029, 316);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Toa Thuốc";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(343, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(292, 32);
            this.label7.TabIndex = 16;
            this.label7.Text = "Lấy Thuốc Theo Toa";
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Location = new System.Drawing.Point(616, 239);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(168, 43);
            this.btnThanhToan.TabIndex = 15;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnLayThuoc
            // 
            this.btnLayThuoc.Location = new System.Drawing.Point(369, 239);
            this.btnLayThuoc.Name = "btnLayThuoc";
            this.btnLayThuoc.Size = new System.Drawing.Size(168, 43);
            this.btnLayThuoc.TabIndex = 14;
            this.btnLayThuoc.Text = "Lấy Thuốc";
            this.btnLayThuoc.UseVisualStyleBackColor = true;
            this.btnLayThuoc.Click += new System.EventHandler(this.btnLayThuoc_Click);
            // 
            // btnTimToaThuoc
            // 
            this.btnTimToaThuoc.Location = new System.Drawing.Point(122, 239);
            this.btnTimToaThuoc.Name = "btnTimToaThuoc";
            this.btnTimToaThuoc.Size = new System.Drawing.Size(168, 43);
            this.btnTimToaThuoc.TabIndex = 13;
            this.btnTimToaThuoc.Text = "Tìm Toa Thuốc";
            this.btnTimToaThuoc.UseVisualStyleBackColor = true;
            this.btnTimToaThuoc.Click += new System.EventHandler(this.btnTimToaThuoc_Click);
            // 
            // txtMaToaThuoc
            // 
            this.txtMaToaThuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaToaThuoc.Location = new System.Drawing.Point(227, 91);
            this.txtMaToaThuoc.Name = "txtMaToaThuoc";
            this.txtMaToaThuoc.Size = new System.Drawing.Size(243, 22);
            this.txtMaToaThuoc.TabIndex = 12;
            // 
            // txtMaBS
            // 
            this.txtMaBS.Location = new System.Drawing.Point(741, 167);
            this.txtMaBS.Name = "txtMaBS";
            this.txtMaBS.Size = new System.Drawing.Size(243, 27);
            this.txtMaBS.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(534, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Mã Bác Sĩ Kết Toa";
            // 
            // txtSoLoaiThuoc
            // 
            this.txtSoLoaiThuoc.Location = new System.Drawing.Point(741, 129);
            this.txtSoLoaiThuoc.Name = "txtSoLoaiThuoc";
            this.txtSoLoaiThuoc.Size = new System.Drawing.Size(243, 27);
            this.txtSoLoaiThuoc.TabIndex = 9;
            // 
            // txtNgayKetThuc
            // 
            this.txtNgayKetThuc.Location = new System.Drawing.Point(741, 91);
            this.txtNgayKetThuc.Name = "txtNgayKetThuc";
            this.txtNgayKetThuc.Size = new System.Drawing.Size(243, 27);
            this.txtNgayKetThuc.TabIndex = 8;
            // 
            // txtSoNgayDung
            // 
            this.txtSoNgayDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoNgayDung.Location = new System.Drawing.Point(227, 167);
            this.txtSoNgayDung.Name = "txtSoNgayDung";
            this.txtSoNgayDung.Size = new System.Drawing.Size(243, 22);
            this.txtSoNgayDung.TabIndex = 7;
            // 
            // txtNgayKetToa
            // 
            this.txtNgayKetToa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgayKetToa.Location = new System.Drawing.Point(227, 129);
            this.txtNgayKetToa.Name = "txtNgayKetToa";
            this.txtNgayKetToa.Size = new System.Drawing.Size(243, 22);
            this.txtNgayKetToa.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(534, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Số Loại Thuốc";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(534, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ngày Kết Thúc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Số Ngày Dùng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ngày Kết Toa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập Mã Toa Thuốc";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView_ChiTietToa);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(137, 346);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1029, 335);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi Tiết Toa Thuốc";
            // 
            // dataGridView_ChiTietToa
            // 
            this.dataGridView_ChiTietToa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ChiTietToa.Location = new System.Drawing.Point(19, 36);
            this.dataGridView_ChiTietToa.Name = "dataGridView_ChiTietToa";
            this.dataGridView_ChiTietToa.RowHeadersWidth = 51;
            this.dataGridView_ChiTietToa.RowTemplate.Height = 24;
            this.dataGridView_ChiTietToa.Size = new System.Drawing.Size(979, 276);
            this.dataGridView_ChiTietToa.TabIndex = 0;
            // 
            // frmLayThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1392, 707);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmLayThuoc";
            this.Text = "frmLayThuoc";
            this.Load += new System.EventHandler(this.frmLayThuoc_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ChiTietToa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaToaThuoc;
        private System.Windows.Forms.TextBox txtMaBS;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSoLoaiThuoc;
        private System.Windows.Forms.TextBox txtNgayKetThuc;
        private System.Windows.Forms.TextBox txtSoNgayDung;
        private System.Windows.Forms.TextBox txtNgayKetToa;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnLayThuoc;
        private System.Windows.Forms.Button btnTimToaThuoc;
        private System.Windows.Forms.DataGridView dataGridView_ChiTietToa;
        private System.Windows.Forms.Label label7;
    }
}