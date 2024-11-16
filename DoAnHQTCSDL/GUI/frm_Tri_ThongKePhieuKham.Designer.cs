namespace GUI
{
    partial class frm_Tri_ThongKePhieuKham
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.maphieukham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mabenhnhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaykham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chandoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mabacsi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ketqua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1_denngay = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1_tungay = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_huy
            // 
            this.btn_huy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_huy.Location = new System.Drawing.Point(758, 537);
            this.btn_huy.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(145, 48);
            this.btn_huy.TabIndex = 83;
            this.btn_huy.Text = "Hủy";
            this.btn_huy.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(200, 289);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 242);
            this.groupBox2.TabIndex = 82;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách thống kê";
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
            this.ketqua});
            this.dataGridView2.Location = new System.Drawing.Point(11, 30);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(758, 186);
            this.dataGridView2.TabIndex = 80;
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
            this.mabenhnhan.Width = 250;
            // 
            // ngaykham
            // 
            this.ngaykham.HeaderText = "Ngày khám";
            this.ngaykham.MinimumWidth = 6;
            this.ngaykham.Name = "ngaykham";
            this.ngaykham.Width = 200;
            // 
            // chandoan
            // 
            this.chandoan.HeaderText = "Chẩn đoán";
            this.chandoan.MinimumWidth = 6;
            this.chandoan.Name = "chandoan";
            this.chandoan.Width = 250;
            // 
            // mabacsi
            // 
            this.mabacsi.HeaderText = "Mã bác sĩ";
            this.mabacsi.MinimumWidth = 6;
            this.mabacsi.Name = "mabacsi";
            this.mabacsi.Width = 150;
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
            this.ketqua.Width = 250;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(417, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 32);
            this.label1.TabIndex = 80;
            this.label1.Text = "THỐNG KÊ PHIẾU KHÁM";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dateTimePicker1_denngay);
            this.groupBox1.Controls.Add(this.dateTimePicker1_tungay);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(200, 136);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 133);
            this.groupBox1.TabIndex = 81;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Từ ngày - đến ngày";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(7, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 23);
            this.label2.TabIndex = 55;
            this.label2.Text = "Đến ngày :";
            // 
            // dateTimePicker1_denngay
            // 
            this.dateTimePicker1_denngay.Location = new System.Drawing.Point(235, 89);
            this.dateTimePicker1_denngay.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.dateTimePicker1_denngay.Name = "dateTimePicker1_denngay";
            this.dateTimePicker1_denngay.Size = new System.Drawing.Size(317, 30);
            this.dateTimePicker1_denngay.TabIndex = 54;
            // 
            // dateTimePicker1_tungay
            // 
            this.dateTimePicker1_tungay.Location = new System.Drawing.Point(235, 29);
            this.dateTimePicker1_tungay.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.dateTimePicker1_tungay.Name = "dateTimePicker1_tungay";
            this.dateTimePicker1_tungay.Size = new System.Drawing.Size(317, 30);
            this.dateTimePicker1_tungay.TabIndex = 53;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(7, 35);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 23);
            this.label5.TabIndex = 52;
            this.label5.Text = "Từ ngày :";
            // 
            // frm_Tri_ThongKePhieuKham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1176, 671);
            this.Controls.Add(this.btn_huy);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_Tri_ThongKePhieuKham";
            this.Text = "frm_Tri_ThongKePhieuKham";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_huy;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn maphieukham;
        private System.Windows.Forms.DataGridViewTextBoxColumn mabenhnhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaykham;
        private System.Windows.Forms.DataGridViewTextBoxColumn chandoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn mabacsi;
        private System.Windows.Forms.DataGridViewTextBoxColumn matoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ketqua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1_denngay;
        private System.Windows.Forms.DateTimePicker dateTimePicker1_tungay;
        private System.Windows.Forms.Label label5;
    }
}