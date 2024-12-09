namespace GUI
{
    partial class frm_Nguyen_XuatVien
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_TinhTrang = new System.Windows.Forms.TextBox();
            this.btn_XuatVien = new System.Windows.Forms.Button();
            this.cmb_MaNhapVien = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_MaBenhNhan = new System.Windows.Forms.ComboBox();
            this.txt_MaRaVien = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.cmb_MaNhapVien);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmb_MaBenhNhan);
            this.groupBox1.Controls.Add(this.txt_MaRaVien);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(157, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1155, 539);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_TinhTrang);
            this.groupBox2.Controls.Add(this.btn_XuatVien);
            this.groupBox2.Location = new System.Drawing.Point(822, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(308, 214);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tình trạng sức khỏe";
            // 
            // txt_TinhTrang
            // 
            this.txt_TinhTrang.Location = new System.Drawing.Point(45, 48);
            this.txt_TinhTrang.Name = "txt_TinhTrang";
            this.txt_TinhTrang.Size = new System.Drawing.Size(236, 22);
            this.txt_TinhTrang.TabIndex = 15;
            // 
            // btn_XuatVien
            // 
            this.btn_XuatVien.Location = new System.Drawing.Point(104, 106);
            this.btn_XuatVien.Name = "btn_XuatVien";
            this.btn_XuatVien.Size = new System.Drawing.Size(124, 42);
            this.btn_XuatVien.TabIndex = 4;
            this.btn_XuatVien.Text = "Xuất viện";
            this.btn_XuatVien.UseVisualStyleBackColor = true;
            this.btn_XuatVien.Click += new System.EventHandler(this.btn_XuatVien_Click);
            // 
            // cmb_MaNhapVien
            // 
            this.cmb_MaNhapVien.FormattingEnabled = true;
            this.cmb_MaNhapVien.Location = new System.Drawing.Point(583, 27);
            this.cmb_MaNhapVien.Name = "cmb_MaNhapVien";
            this.cmb_MaNhapVien.Size = new System.Drawing.Size(178, 24);
            this.cmb_MaNhapVien.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(471, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Mã nhập viện :";
            // 
            // cmb_MaBenhNhan
            // 
            this.cmb_MaBenhNhan.FormattingEnabled = true;
            this.cmb_MaBenhNhan.Location = new System.Drawing.Point(158, 98);
            this.cmb_MaBenhNhan.Name = "cmb_MaBenhNhan";
            this.cmb_MaBenhNhan.Size = new System.Drawing.Size(186, 24);
            this.cmb_MaBenhNhan.TabIndex = 9;
            this.cmb_MaBenhNhan.SelectedIndexChanged += new System.EventHandler(this.cmb_MaBenhNhan_SelectedIndexChanged);
            // 
            // txt_MaRaVien
            // 
            this.txt_MaRaVien.Location = new System.Drawing.Point(158, 29);
            this.txt_MaRaVien.Name = "txt_MaRaVien";
            this.txt_MaRaVien.Size = new System.Drawing.Size(186, 22);
            this.txt_MaRaVien.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mã ra viện :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 280);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1114, 257);
            this.dataGridView1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(460, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ngày xuất viện :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(583, 101);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(224, 22);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã bệnh nhân :";
            // 
            // frm_Nguyen_XuatVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1611, 707);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frm_Nguyen_XuatVien";
            this.Text = "frm_Nguyen_XuatVien";
            this.Load += new System.EventHandler(this.frm_Nguyen_XuatVien_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_TinhTrang;
        private System.Windows.Forms.Button btn_XuatVien;
        private System.Windows.Forms.ComboBox cmb_MaNhapVien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_MaBenhNhan;
        private System.Windows.Forms.TextBox txt_MaRaVien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
    }
}