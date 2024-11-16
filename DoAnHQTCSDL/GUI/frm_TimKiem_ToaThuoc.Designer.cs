namespace GUI
{
    partial class frm_TimKiem_ToaThuoc
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdo_ngayketthuc = new System.Windows.Forms.RadioButton();
            this.rdo_ngayketoa = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1_ngayketthuc = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1_ngayketoa = new System.Windows.Forms.DateTimePicker();
            this.rdo_mabacsi = new System.Windows.Forms.RadioButton();
            this.cbo_mabacsi = new System.Windows.Forms.ComboBox();
            this.cbo_matoathuoc = new System.Windows.Forms.ComboBox();
            this.rdo_matoathuoc = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.matoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotenbn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayketoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayketthuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tuoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.songaydung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soloaithuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mathuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sl_thuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mabacsi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chuandoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cachdung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_timkiem.ForeColor = System.Drawing.Color.Black;
            this.btn_timkiem.Location = new System.Drawing.Point(1011, 557);
            this.btn_timkiem.Margin = new System.Windows.Forms.Padding(4);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(137, 47);
            this.btn_timkiem.TabIndex = 54;
            this.btn_timkiem.Text = "Tìm kiếm";
            this.btn_timkiem.UseVisualStyleBackColor = true;
            // 
            // btn_huy
            // 
            this.btn_huy.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_huy.ForeColor = System.Drawing.Color.Black;
            this.btn_huy.Location = new System.Drawing.Point(1200, 557);
            this.btn_huy.Margin = new System.Windows.Forms.Padding(4);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(137, 47);
            this.btn_huy.TabIndex = 53;
            this.btn_huy.Text = "Hủy";
            this.btn_huy.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdo_ngayketthuc);
            this.groupBox1.Controls.Add(this.rdo_ngayketoa);
            this.groupBox1.Controls.Add(this.dateTimePicker1_ngayketthuc);
            this.groupBox1.Controls.Add(this.dateTimePicker1_ngayketoa);
            this.groupBox1.Controls.Add(this.rdo_mabacsi);
            this.groupBox1.Controls.Add(this.cbo_mabacsi);
            this.groupBox1.Controls.Add(this.cbo_matoathuoc);
            this.groupBox1.Controls.Add(this.rdo_matoathuoc);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(55, 59);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1282, 179);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm toa thuốc";
            // 
            // rdo_ngayketthuc
            // 
            this.rdo_ngayketthuc.AutoSize = true;
            this.rdo_ngayketthuc.ForeColor = System.Drawing.Color.Black;
            this.rdo_ngayketthuc.Location = new System.Drawing.Point(593, 99);
            this.rdo_ngayketthuc.Margin = new System.Windows.Forms.Padding(4);
            this.rdo_ngayketthuc.Name = "rdo_ngayketthuc";
            this.rdo_ngayketthuc.Size = new System.Drawing.Size(162, 27);
            this.rdo_ngayketthuc.TabIndex = 63;
            this.rdo_ngayketthuc.Text = "Ngày kết thúc :";
            this.rdo_ngayketthuc.UseVisualStyleBackColor = true;
            // 
            // rdo_ngayketoa
            // 
            this.rdo_ngayketoa.AutoSize = true;
            this.rdo_ngayketoa.ForeColor = System.Drawing.Color.Black;
            this.rdo_ngayketoa.Location = new System.Drawing.Point(593, 49);
            this.rdo_ngayketoa.Margin = new System.Windows.Forms.Padding(4);
            this.rdo_ngayketoa.Name = "rdo_ngayketoa";
            this.rdo_ngayketoa.Size = new System.Drawing.Size(144, 27);
            this.rdo_ngayketoa.TabIndex = 62;
            this.rdo_ngayketoa.Text = "Ngày kê toa :";
            this.rdo_ngayketoa.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1_ngayketthuc
            // 
            this.dateTimePicker1_ngayketthuc.Location = new System.Drawing.Point(839, 102);
            this.dateTimePicker1_ngayketthuc.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.dateTimePicker1_ngayketthuc.Name = "dateTimePicker1_ngayketthuc";
            this.dateTimePicker1_ngayketthuc.Size = new System.Drawing.Size(360, 30);
            this.dateTimePicker1_ngayketthuc.TabIndex = 61;
            // 
            // dateTimePicker1_ngayketoa
            // 
            this.dateTimePicker1_ngayketoa.Location = new System.Drawing.Point(839, 51);
            this.dateTimePicker1_ngayketoa.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.dateTimePicker1_ngayketoa.Name = "dateTimePicker1_ngayketoa";
            this.dateTimePicker1_ngayketoa.Size = new System.Drawing.Size(360, 30);
            this.dateTimePicker1_ngayketoa.TabIndex = 59;
            // 
            // rdo_mabacsi
            // 
            this.rdo_mabacsi.AutoSize = true;
            this.rdo_mabacsi.ForeColor = System.Drawing.Color.Black;
            this.rdo_mabacsi.Location = new System.Drawing.Point(25, 105);
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
            this.cbo_mabacsi.Location = new System.Drawing.Point(246, 99);
            this.cbo_mabacsi.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cbo_mabacsi.Name = "cbo_mabacsi";
            this.cbo_mabacsi.Size = new System.Drawing.Size(249, 31);
            this.cbo_mabacsi.TabIndex = 48;
            // 
            // cbo_matoathuoc
            // 
            this.cbo_matoathuoc.FormattingEnabled = true;
            this.cbo_matoathuoc.Location = new System.Drawing.Point(246, 44);
            this.cbo_matoathuoc.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cbo_matoathuoc.Name = "cbo_matoathuoc";
            this.cbo_matoathuoc.Size = new System.Drawing.Size(249, 31);
            this.cbo_matoathuoc.TabIndex = 47;
            // 
            // rdo_matoathuoc
            // 
            this.rdo_matoathuoc.AutoSize = true;
            this.rdo_matoathuoc.ForeColor = System.Drawing.Color.Black;
            this.rdo_matoathuoc.Location = new System.Drawing.Point(25, 44);
            this.rdo_matoathuoc.Margin = new System.Windows.Forms.Padding(4);
            this.rdo_matoathuoc.Name = "rdo_matoathuoc";
            this.rdo_matoathuoc.Size = new System.Drawing.Size(154, 27);
            this.rdo_matoathuoc.TabIndex = 18;
            this.rdo_matoathuoc.Text = "Mã toa thuốc :";
            this.rdo_matoathuoc.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.matoa,
            this.hotenbn,
            this.ngayketoa,
            this.ngayketthuc,
            this.tuoi,
            this.songaydung,
            this.soloaithuoc,
            this.mathuoc,
            this.sl_thuoc,
            this.mabacsi,
            this.chuandoan,
            this.cachdung});
            this.dataGridView1.Location = new System.Drawing.Point(55, 274);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1282, 275);
            this.dataGridView1.TabIndex = 51;
            // 
            // matoa
            // 
            this.matoa.HeaderText = "Mã toa thuốc";
            this.matoa.MinimumWidth = 6;
            this.matoa.Name = "matoa";
            this.matoa.Width = 125;
            // 
            // hotenbn
            // 
            this.hotenbn.HeaderText = "Họ tên bệnh nhân";
            this.hotenbn.MinimumWidth = 6;
            this.hotenbn.Name = "hotenbn";
            this.hotenbn.Width = 125;
            // 
            // ngayketoa
            // 
            this.ngayketoa.HeaderText = "Ngày kê toa";
            this.ngayketoa.MinimumWidth = 6;
            this.ngayketoa.Name = "ngayketoa";
            this.ngayketoa.Width = 125;
            // 
            // ngayketthuc
            // 
            this.ngayketthuc.HeaderText = "Ngày kết thúc";
            this.ngayketthuc.MinimumWidth = 6;
            this.ngayketthuc.Name = "ngayketthuc";
            this.ngayketthuc.Width = 125;
            // 
            // tuoi
            // 
            this.tuoi.HeaderText = "Tuổi";
            this.tuoi.MinimumWidth = 6;
            this.tuoi.Name = "tuoi";
            this.tuoi.Width = 125;
            // 
            // songaydung
            // 
            this.songaydung.HeaderText = "Số ngày dùng ";
            this.songaydung.MinimumWidth = 6;
            this.songaydung.Name = "songaydung";
            this.songaydung.Width = 125;
            // 
            // soloaithuoc
            // 
            this.soloaithuoc.HeaderText = "Số loại thuốc";
            this.soloaithuoc.MinimumWidth = 6;
            this.soloaithuoc.Name = "soloaithuoc";
            this.soloaithuoc.Width = 125;
            // 
            // mathuoc
            // 
            this.mathuoc.HeaderText = "Mã thuốc ";
            this.mathuoc.MinimumWidth = 6;
            this.mathuoc.Name = "mathuoc";
            this.mathuoc.Width = 125;
            // 
            // sl_thuoc
            // 
            this.sl_thuoc.HeaderText = "Số lượng thuốc ";
            this.sl_thuoc.MinimumWidth = 6;
            this.sl_thuoc.Name = "sl_thuoc";
            this.sl_thuoc.Width = 125;
            // 
            // mabacsi
            // 
            this.mabacsi.HeaderText = "Mã bác sĩ";
            this.mabacsi.MinimumWidth = 6;
            this.mabacsi.Name = "mabacsi";
            this.mabacsi.Width = 125;
            // 
            // chuandoan
            // 
            this.chuandoan.HeaderText = "Chuẩn đoán ";
            this.chuandoan.MinimumWidth = 6;
            this.chuandoan.Name = "chuandoan";
            this.chuandoan.Width = 125;
            // 
            // cachdung
            // 
            this.cachdung.HeaderText = "Cách dùng ";
            this.cachdung.MinimumWidth = 6;
            this.cachdung.Name = "cachdung";
            this.cachdung.Width = 125;
            // 
            // frm_TimKiem_ToaThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1393, 662);
            this.Controls.Add(this.btn_timkiem);
            this.Controls.Add(this.btn_huy);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frm_TimKiem_ToaThuoc";
            this.Text = "frm_TimKiem_ToaThuoc";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_timkiem;
        private System.Windows.Forms.Button btn_huy;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdo_ngayketthuc;
        private System.Windows.Forms.RadioButton rdo_ngayketoa;
        private System.Windows.Forms.DateTimePicker dateTimePicker1_ngayketthuc;
        private System.Windows.Forms.DateTimePicker dateTimePicker1_ngayketoa;
        private System.Windows.Forms.RadioButton rdo_mabacsi;
        private System.Windows.Forms.ComboBox cbo_mabacsi;
        private System.Windows.Forms.ComboBox cbo_matoathuoc;
        private System.Windows.Forms.RadioButton rdo_matoathuoc;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn matoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotenbn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayketoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayketthuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn tuoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn songaydung;
        private System.Windows.Forms.DataGridViewTextBoxColumn soloaithuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn mathuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn sl_thuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn mabacsi;
        private System.Windows.Forms.DataGridViewTextBoxColumn chuandoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn cachdung;
    }
}