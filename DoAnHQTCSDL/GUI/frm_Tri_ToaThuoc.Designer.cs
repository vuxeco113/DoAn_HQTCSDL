namespace GUI
{
    partial class frm_Tri_ToaThuoc
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.matoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayketoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.songaydung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayketthuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soloaithuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mabacsi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label13 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.id_songay = new System.Windows.Forms.Label();
            this.cbo_maBN = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbo_matoa = new System.Windows.Forms.ComboBox();
            this.cbo_pk = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_sumSoNgay = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_phacdodieutri = new System.Windows.Forms.Button();
            this.txt_mabacsi_ketoa = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_soloaithuoc = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_songaydung = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker1_ngayketthuc = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1_ngayketoa = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 374);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1266, 185);
            this.groupBox2.TabIndex = 75;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sach toa";
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
            this.dataGridView1.Location = new System.Drawing.Point(14, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1221, 138);
            this.dataGridView1.TabIndex = 46;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
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
            this.mabacsi.DataPropertyName = "MaBsKetoa";
            this.mabacsi.HeaderText = "Mã bác sĩ kê toa";
            this.mabacsi.MinimumWidth = 6;
            this.mabacsi.Name = "mabacsi";
            this.mabacsi.Width = 200;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(582, 14);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(179, 32);
            this.label13.TabIndex = 74;
            this.label13.Text = "TOA THUỐC";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(172, 257);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 49);
            this.button1.TabIndex = 72;
            this.button1.Text = "Xóa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // id_songay
            // 
            this.id_songay.AutoSize = true;
            this.id_songay.ForeColor = System.Drawing.Color.Black;
            this.id_songay.Location = new System.Drawing.Point(887, 168);
            this.id_songay.Name = "id_songay";
            this.id_songay.Size = new System.Drawing.Size(194, 23);
            this.id_songay.TabIndex = 83;
            this.id_songay.Text = "số ngày sử dụng thuốc";
            // 
            // cbo_maBN
            // 
            this.cbo_maBN.FormattingEnabled = true;
            this.cbo_maBN.Location = new System.Drawing.Point(609, 165);
            this.cbo_maBN.Name = "cbo_maBN";
            this.cbo_maBN.Size = new System.Drawing.Size(182, 31);
            this.cbo_maBN.TabIndex = 82;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(465, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 23);
            this.label2.TabIndex = 81;
            this.label2.Text = "Mã bệnh nhân";
            // 
            // cbo_matoa
            // 
            this.cbo_matoa.FormattingEnabled = true;
            this.cbo_matoa.Location = new System.Drawing.Point(172, 38);
            this.cbo_matoa.Name = "cbo_matoa";
            this.cbo_matoa.Size = new System.Drawing.Size(263, 31);
            this.cbo_matoa.TabIndex = 80;
            // 
            // cbo_pk
            // 
            this.cbo_pk.FormattingEnabled = true;
            this.cbo_pk.Location = new System.Drawing.Point(172, 165);
            this.cbo_pk.Name = "cbo_pk";
            this.cbo_pk.Size = new System.Drawing.Size(263, 31);
            this.cbo_pk.TabIndex = 79;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(6, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 23);
            this.label3.TabIndex = 78;
            this.label3.Text = "Mã phiếu khám";
            // 
            // btn_sumSoNgay
            // 
            this.btn_sumSoNgay.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sumSoNgay.Location = new System.Drawing.Point(469, 257);
            this.btn_sumSoNgay.Name = "btn_sumSoNgay";
            this.btn_sumSoNgay.Size = new System.Drawing.Size(332, 44);
            this.btn_sumSoNgay.TabIndex = 73;
            this.btn_sumSoNgay.Text = "Tổng số ngày sử dụng thuốc";
            this.btn_sumSoNgay.UseVisualStyleBackColor = true;
            this.btn_sumSoNgay.Click += new System.EventHandler(this.btn_sumSoNgay_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.id_songay);
            this.groupBox1.Controls.Add(this.cbo_maBN);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbo_matoa);
            this.groupBox1.Controls.Add(this.cbo_pk);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btn_sumSoNgay);
            this.groupBox1.Controls.Add(this.btn_phacdodieutri);
            this.groupBox1.Controls.Add(this.txt_mabacsi_ketoa);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txt_soloaithuoc);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txt_songaydung);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.dateTimePicker1_ngayketthuc);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dateTimePicker1_ngayketoa);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1266, 312);
            this.groupBox1.TabIndex = 72;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Toa thuốc";
            // 
            // btn_phacdodieutri
            // 
            this.btn_phacdodieutri.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_phacdodieutri.Location = new System.Drawing.Point(972, 257);
            this.btn_phacdodieutri.Name = "btn_phacdodieutri";
            this.btn_phacdodieutri.Size = new System.Drawing.Size(263, 44);
            this.btn_phacdodieutri.TabIndex = 71;
            this.btn_phacdodieutri.Text = "Phác đồ điều trị";
            this.btn_phacdodieutri.UseVisualStyleBackColor = true;
            this.btn_phacdodieutri.Click += new System.EventHandler(this.btn_phacdodieutri_Click);
            // 
            // txt_mabacsi_ketoa
            // 
            this.txt_mabacsi_ketoa.Location = new System.Drawing.Point(172, 96);
            this.txt_mabacsi_ketoa.Margin = new System.Windows.Forms.Padding(4);
            this.txt_mabacsi_ketoa.Name = "txt_mabacsi_ketoa";
            this.txt_mabacsi_ketoa.Size = new System.Drawing.Size(263, 30);
            this.txt_mabacsi_ketoa.TabIndex = 63;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(6, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(159, 23);
            this.label9.TabIndex = 62;
            this.label9.Text = "Mã bác sĩ kê toa :";
            // 
            // txt_soloaithuoc
            // 
            this.txt_soloaithuoc.Location = new System.Drawing.Point(609, 100);
            this.txt_soloaithuoc.Margin = new System.Windows.Forms.Padding(4);
            this.txt_soloaithuoc.Name = "txt_soloaithuoc";
            this.txt_soloaithuoc.Size = new System.Drawing.Size(182, 30);
            this.txt_soloaithuoc.TabIndex = 61;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(465, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 23);
            this.label8.TabIndex = 60;
            this.label8.Text = "Số loại thuốc :";
            // 
            // txt_songaydung
            // 
            this.txt_songaydung.Location = new System.Drawing.Point(609, 39);
            this.txt_songaydung.Margin = new System.Windows.Forms.Padding(4);
            this.txt_songaydung.Name = "txt_songaydung";
            this.txt_songaydung.Size = new System.Drawing.Size(182, 30);
            this.txt_songaydung.TabIndex = 59;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(465, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 23);
            this.label7.TabIndex = 58;
            this.label7.Text = "Số ngày dùng :";
            // 
            // dateTimePicker1_ngayketthuc
            // 
            this.dateTimePicker1_ngayketthuc.AllowDrop = true;
            this.dateTimePicker1_ngayketthuc.Enabled = false;
            this.dateTimePicker1_ngayketthuc.Location = new System.Drawing.Point(972, 101);
            this.dateTimePicker1_ngayketthuc.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1_ngayketthuc.Name = "dateTimePicker1_ngayketthuc";
            this.dateTimePicker1_ngayketthuc.Size = new System.Drawing.Size(263, 30);
            this.dateTimePicker1_ngayketthuc.TabIndex = 57;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(806, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 23);
            this.label6.TabIndex = 56;
            this.label6.Text = "Ngày kết thúc :";
            // 
            // dateTimePicker1_ngayketoa
            // 
            this.dateTimePicker1_ngayketoa.Enabled = false;
            this.dateTimePicker1_ngayketoa.Location = new System.Drawing.Point(972, 42);
            this.dateTimePicker1_ngayketoa.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1_ngayketoa.Name = "dateTimePicker1_ngayketoa";
            this.dateTimePicker1_ngayketoa.Size = new System.Drawing.Size(263, 30);
            this.dateTimePicker1_ngayketoa.TabIndex = 51;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(806, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 23);
            this.label5.TabIndex = 50;
            this.label5.Text = "Ngày kê toa :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(6, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 23);
            this.label4.TabIndex = 49;
            this.label4.Text = "Mã toa thuốc :";
            // 
            // frm_Tri_ToaThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1312, 627);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_Tri_ToaThuoc";
            this.Text = "frm_Tri_ToaThuoc";
            this.Load += new System.EventHandler(this.frm_Tri_ToaThuoc_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn matoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayketoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn songaydung;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayketthuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn soloaithuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn mabacsi;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label id_songay;
        private System.Windows.Forms.ComboBox cbo_maBN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbo_matoa;
        private System.Windows.Forms.ComboBox cbo_pk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_sumSoNgay;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_phacdodieutri;
        private System.Windows.Forms.TextBox txt_mabacsi_ketoa;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_soloaithuoc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_songaydung;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker1_ngayketthuc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1_ngayketoa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}