namespace GUI
{
    partial class frm_Tri_timkiem_toathuoc
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
            this.rdo_matoa = new System.Windows.Forms.RadioButton();
            this.rdo_maBN = new System.Windows.Forms.RadioButton();
            this.cbo_toathuoc = new System.Windows.Forms.ComboBox();
            this.cbo_maBN = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.matoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayketoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.songaydung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayketthuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soloaithuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mabacsi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_tk = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdo_matoa);
            this.groupBox1.Controls.Add(this.rdo_maBN);
            this.groupBox1.Controls.Add(this.btn_tk);
            this.groupBox1.Controls.Add(this.cbo_toathuoc);
            this.groupBox1.Controls.Add(this.cbo_maBN);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1282, 110);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm toa thuốc";
            // 
            // rdo_matoa
            // 
            this.rdo_matoa.AutoSize = true;
            this.rdo_matoa.Location = new System.Drawing.Point(782, 51);
            this.rdo_matoa.Name = "rdo_matoa";
            this.rdo_matoa.Size = new System.Drawing.Size(142, 27);
            this.rdo_matoa.TabIndex = 56;
            this.rdo_matoa.TabStop = true;
            this.rdo_matoa.Text = "Mã toa thuốc";
            this.rdo_matoa.UseVisualStyleBackColor = true;
            // 
            // rdo_maBN
            // 
            this.rdo_maBN.AutoSize = true;
            this.rdo_maBN.Location = new System.Drawing.Point(46, 48);
            this.rdo_maBN.Name = "rdo_maBN";
            this.rdo_maBN.Size = new System.Drawing.Size(149, 27);
            this.rdo_maBN.TabIndex = 55;
            this.rdo_maBN.TabStop = true;
            this.rdo_maBN.Text = "Mã bệnh nhân";
            this.rdo_maBN.UseVisualStyleBackColor = true;
            // 
            // cbo_toathuoc
            // 
            this.cbo_toathuoc.FormattingEnabled = true;
            this.cbo_toathuoc.Location = new System.Drawing.Point(1003, 47);
            this.cbo_toathuoc.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cbo_toathuoc.Name = "cbo_toathuoc";
            this.cbo_toathuoc.Size = new System.Drawing.Size(249, 31);
            this.cbo_toathuoc.TabIndex = 53;
            // 
            // cbo_maBN
            // 
            this.cbo_maBN.FormattingEnabled = true;
            this.cbo_maBN.Location = new System.Drawing.Point(246, 44);
            this.cbo_maBN.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cbo_maBN.Name = "cbo_maBN";
            this.cbo_maBN.Size = new System.Drawing.Size(249, 31);
            this.cbo_maBN.TabIndex = 47;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(13, 144);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1282, 348);
            this.groupBox2.TabIndex = 54;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách tìm kiếm";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.matoa,
            this.ngayketoa,
            this.songaydung,
            this.ngayketthuc,
            this.soloaithuoc,
            this.mabacsi});
            this.dataGridView1.Location = new System.Drawing.Point(31, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1221, 291);
            this.dataGridView1.TabIndex = 47;
            // 
            // matoa
            // 
            this.matoa.DataPropertyName = "MaToa";
            this.matoa.HeaderText = "Mã toa thuốc";
            this.matoa.MinimumWidth = 6;
            this.matoa.Name = "matoa";
            this.matoa.Width = 200;
            // 
            // ngayketoa
            // 
            this.ngayketoa.DataPropertyName = "NgayKeToa";
            this.ngayketoa.HeaderText = "Ngày kê toa";
            this.ngayketoa.MinimumWidth = 6;
            this.ngayketoa.Name = "ngayketoa";
            this.ngayketoa.Width = 200;
            // 
            // songaydung
            // 
            this.songaydung.DataPropertyName = "SoNgayDung";
            this.songaydung.HeaderText = "Số ngày dùng";
            this.songaydung.MinimumWidth = 6;
            this.songaydung.Name = "songaydung";
            this.songaydung.Width = 200;
            // 
            // ngayketthuc
            // 
            this.ngayketthuc.DataPropertyName = "NgayKetThuc";
            this.ngayketthuc.HeaderText = "Ngày kết thúc";
            this.ngayketthuc.MinimumWidth = 6;
            this.ngayketthuc.Name = "ngayketthuc";
            this.ngayketthuc.Width = 200;
            // 
            // soloaithuoc
            // 
            this.soloaithuoc.DataPropertyName = "SoLoaiThuoc";
            this.soloaithuoc.HeaderText = "Số loại thuốc";
            this.soloaithuoc.MinimumWidth = 6;
            this.soloaithuoc.Name = "soloaithuoc";
            this.soloaithuoc.Width = 200;
            // 
            // mabacsi
            // 
            this.mabacsi.DataPropertyName = "BacSiKeToa";
            this.mabacsi.HeaderText = "Mã bác sĩ kê toa";
            this.mabacsi.MinimumWidth = 6;
            this.mabacsi.Name = "mabacsi";
            this.mabacsi.Width = 300;
            // 
            // btn_tk
            // 
            this.btn_tk.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tk.ForeColor = System.Drawing.Color.Black;
            this.btn_tk.Location = new System.Drawing.Point(575, 37);
            this.btn_tk.Margin = new System.Windows.Forms.Padding(4);
            this.btn_tk.Name = "btn_tk";
            this.btn_tk.Size = new System.Drawing.Size(141, 47);
            this.btn_tk.TabIndex = 55;
            this.btn_tk.Text = "Tìm Kiếm";
            this.btn_tk.UseVisualStyleBackColor = true;
            this.btn_tk.Click += new System.EventHandler(this.btn_tk_Click);
            // 
            // frm_Tri_timkiem_toathuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1334, 580);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "frm_Tri_timkiem_toathuoc";
            this.Text = "frm_TimKiem_ToaThuoc";
            this.Load += new System.EventHandler(this.frm_Tri_timkiem_toathuoc_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdo_matoa;
        private System.Windows.Forms.RadioButton rdo_maBN;
        private System.Windows.Forms.ComboBox cbo_toathuoc;
        private System.Windows.Forms.ComboBox cbo_maBN;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn matoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayketoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn songaydung;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayketthuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn soloaithuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn mabacsi;
        private System.Windows.Forms.Button btn_tk;
    }
}