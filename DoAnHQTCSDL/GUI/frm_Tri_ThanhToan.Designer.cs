namespace GUI
{
    partial class frm_Tri_Thanhtoan
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
            this.maphieukkham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mathanhtoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maravien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaythanhtoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sotien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbo_MP = new System.Windows.Forms.ComboBox();
            this.btn_thanhtoan = new System.Windows.Forms.Button();
            this.txt_tien = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dateTimePicker1_ngaythanhtoan = new System.Windows.Forms.DateTimePicker();
            this.txt_mathanhtoan = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
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
            this.groupBox2.Location = new System.Drawing.Point(13, 324);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1133, 231);
            this.groupBox2.TabIndex = 79;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách thanh toán";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maphieukkham,
            this.mathanhtoan,
            this.maravien,
            this.ngaythanhtoan,
            this.Sotien});
            this.dataGridView1.Location = new System.Drawing.Point(12, 27);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1080, 147);
            this.dataGridView1.TabIndex = 50;
            // 
            // maphieukkham
            // 
            this.maphieukkham.DataPropertyName = "MaPhieuKham";
            this.maphieukkham.HeaderText = "Mã phiếu khám";
            this.maphieukkham.MinimumWidth = 6;
            this.maphieukkham.Name = "maphieukkham";
            this.maphieukkham.Width = 200;
            // 
            // mathanhtoan
            // 
            this.mathanhtoan.DataPropertyName = "MaThanhToan";
            this.mathanhtoan.HeaderText = "Mã thanh toán";
            this.mathanhtoan.MinimumWidth = 6;
            this.mathanhtoan.Name = "mathanhtoan";
            this.mathanhtoan.Width = 200;
            // 
            // maravien
            // 
            this.maravien.DataPropertyName = "MaRaVien";
            this.maravien.HeaderText = "Mã ra viện";
            this.maravien.MinimumWidth = 6;
            this.maravien.Name = "maravien";
            this.maravien.Width = 200;
            // 
            // ngaythanhtoan
            // 
            this.ngaythanhtoan.DataPropertyName = "NgayThanhToan";
            this.ngaythanhtoan.HeaderText = "Ngày thanh toán";
            this.ngaythanhtoan.MinimumWidth = 6;
            this.ngaythanhtoan.Name = "ngaythanhtoan";
            this.ngaythanhtoan.Width = 200;
            // 
            // Sotien
            // 
            this.Sotien.DataPropertyName = "SoTien";
            this.Sotien.HeaderText = "Số tiền";
            this.Sotien.MinimumWidth = 6;
            this.Sotien.Name = "Sotien";
            this.Sotien.Width = 300;
            // 
            // cbo_MP
            // 
            this.cbo_MP.FormattingEnabled = true;
            this.cbo_MP.Location = new System.Drawing.Point(236, 49);
            this.cbo_MP.Name = "cbo_MP";
            this.cbo_MP.Size = new System.Drawing.Size(295, 31);
            this.cbo_MP.TabIndex = 72;
            // 
            // btn_thanhtoan
            // 
            this.btn_thanhtoan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thanhtoan.Location = new System.Drawing.Point(947, 169);
            this.btn_thanhtoan.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_thanhtoan.Name = "btn_thanhtoan";
            this.btn_thanhtoan.Size = new System.Drawing.Size(145, 48);
            this.btn_thanhtoan.TabIndex = 71;
            this.btn_thanhtoan.Text = "Thanh toán ";
            this.btn_thanhtoan.UseVisualStyleBackColor = true;
            this.btn_thanhtoan.Click += new System.EventHandler(this.btn_thanhtoan_Click);
            // 
            // txt_tien
            // 
            this.txt_tien.Location = new System.Drawing.Point(797, 109);
            this.txt_tien.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txt_tien.Name = "txt_tien";
            this.txt_tien.Size = new System.Drawing.Size(295, 30);
            this.txt_tien.TabIndex = 65;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(569, 109);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 23);
            this.label10.TabIndex = 64;
            this.label10.Text = "Số tiền :";
            // 
            // dateTimePicker1_ngaythanhtoan
            // 
            this.dateTimePicker1_ngaythanhtoan.Enabled = false;
            this.dateTimePicker1_ngaythanhtoan.Location = new System.Drawing.Point(797, 51);
            this.dateTimePicker1_ngaythanhtoan.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.dateTimePicker1_ngaythanhtoan.Name = "dateTimePicker1_ngaythanhtoan";
            this.dateTimePicker1_ngaythanhtoan.Size = new System.Drawing.Size(295, 30);
            this.dateTimePicker1_ngaythanhtoan.TabIndex = 51;
            // 
            // txt_mathanhtoan
            // 
            this.txt_mathanhtoan.Location = new System.Drawing.Point(236, 109);
            this.txt_mathanhtoan.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txt_mathanhtoan.Name = "txt_mathanhtoan";
            this.txt_mathanhtoan.Size = new System.Drawing.Size(295, 30);
            this.txt_mathanhtoan.TabIndex = 53;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(569, 49);
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
            this.label4.Location = new System.Drawing.Point(8, 51);
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
            this.label2.Location = new System.Drawing.Point(7, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 23);
            this.label2.TabIndex = 47;
            this.label2.Text = "Mã thanh toán :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(459, 9);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(296, 32);
            this.label13.TabIndex = 77;
            this.label13.Text = "PHIẾU THANH TOÁN";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbo_MP);
            this.groupBox1.Controls.Add(this.btn_thanhtoan);
            this.groupBox1.Controls.Add(this.txt_tien);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.dateTimePicker1_ngaythanhtoan);
            this.groupBox1.Controls.Add(this.txt_mathanhtoan);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 85);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(1133, 233);
            this.groupBox1.TabIndex = 76;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thanh toán";
            // 
            // frm_Tri_Thanhtoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1184, 615);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_Tri_Thanhtoan";
            this.Text = "frm_Tri_ThanhToan";
            this.Load += new System.EventHandler(this.frm_Tri_Thanhtoan_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maphieukkham;
        private System.Windows.Forms.DataGridViewTextBoxColumn mathanhtoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn maravien;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaythanhtoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sotien;
        private System.Windows.Forms.ComboBox cbo_MP;
        private System.Windows.Forms.Button btn_thanhtoan;
        private System.Windows.Forms.TextBox txt_tien;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateTimePicker1_ngaythanhtoan;
        private System.Windows.Forms.TextBox txt_mathanhtoan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}