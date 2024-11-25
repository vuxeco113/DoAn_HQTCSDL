namespace GUI
{
    partial class frm_Tri_xemchitiettoathuoc
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
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.matoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mathuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sl_thuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cachdung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenthuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhphan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbo_matoathuoc = new System.Windows.Forms.ComboBox();
            this.txt_sum = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btn_xemchitiet = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(336, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(379, 32);
            this.label2.TabIndex = 85;
            this.label2.Text = "XEM CHI TIẾT TOA THUỐC";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 295);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1051, 194);
            this.groupBox1.TabIndex = 82;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách chi tiết toa thuốc";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.matoa,
            this.mathuoc,
            this.sl_thuoc,
            this.cachdung,
            this.tenthuoc,
            this.thanhphan});
            this.dataGridView1.Location = new System.Drawing.Point(6, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1026, 147);
            this.dataGridView1.TabIndex = 47;
            // 
            // matoa
            // 
            this.matoa.DataPropertyName = "MATOA";
            this.matoa.HeaderText = "Mã toa thuốc";
            this.matoa.MinimumWidth = 6;
            this.matoa.Name = "matoa";
            this.matoa.Width = 125;
            // 
            // mathuoc
            // 
            this.mathuoc.DataPropertyName = "MATHUOC";
            this.mathuoc.HeaderText = "Mã thuốc ";
            this.mathuoc.MinimumWidth = 6;
            this.mathuoc.Name = "mathuoc";
            this.mathuoc.Width = 125;
            // 
            // sl_thuoc
            // 
            this.sl_thuoc.DataPropertyName = "SOLUONG";
            this.sl_thuoc.HeaderText = "Số lượng thuốc ";
            this.sl_thuoc.MinimumWidth = 6;
            this.sl_thuoc.Name = "sl_thuoc";
            this.sl_thuoc.Width = 125;
            // 
            // cachdung
            // 
            this.cachdung.DataPropertyName = "CACHDUNG";
            this.cachdung.HeaderText = "Cách dùng ";
            this.cachdung.MinimumWidth = 6;
            this.cachdung.Name = "cachdung";
            this.cachdung.Width = 200;
            // 
            // tenthuoc
            // 
            this.tenthuoc.DataPropertyName = "TENTHUOC";
            this.tenthuoc.HeaderText = "Tên thuốc";
            this.tenthuoc.MinimumWidth = 6;
            this.tenthuoc.Name = "tenthuoc";
            this.tenthuoc.Width = 200;
            // 
            // thanhphan
            // 
            this.thanhphan.DataPropertyName = "THANHPHAN";
            this.thanhphan.HeaderText = "Thành phần";
            this.thanhphan.MinimumWidth = 6;
            this.thanhphan.Name = "thanhphan";
            this.thanhphan.Width = 200;
            // 
            // cbo_matoathuoc
            // 
            this.cbo_matoathuoc.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_matoathuoc.FormattingEnabled = true;
            this.cbo_matoathuoc.Location = new System.Drawing.Point(185, 50);
            this.cbo_matoathuoc.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_matoathuoc.Name = "cbo_matoathuoc";
            this.cbo_matoathuoc.Size = new System.Drawing.Size(263, 28);
            this.cbo_matoathuoc.TabIndex = 51;
            // 
            // txt_sum
            // 
            this.txt_sum.Enabled = false;
            this.txt_sum.Location = new System.Drawing.Point(822, 48);
            this.txt_sum.Margin = new System.Windows.Forms.Padding(4);
            this.txt_sum.Name = "txt_sum";
            this.txt_sum.Size = new System.Drawing.Size(210, 30);
            this.txt_sum.TabIndex = 79;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(534, 47);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(209, 23);
            this.label13.TabIndex = 78;
            this.label13.Text = "Tổng số thuốc trong toa";
            // 
            // btn_xemchitiet
            // 
            this.btn_xemchitiet.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xemchitiet.Location = new System.Drawing.Point(822, 108);
            this.btn_xemchitiet.Name = "btn_xemchitiet";
            this.btn_xemchitiet.Size = new System.Drawing.Size(210, 35);
            this.btn_xemchitiet.TabIndex = 55;
            this.btn_xemchitiet.Text = "Xem chi tiết";
            this.btn_xemchitiet.UseVisualStyleBackColor = true;
            this.btn_xemchitiet.Click += new System.EventHandler(this.btn_xemchitiet_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_sum);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btn_xemchitiet);
            this.groupBox2.Controls.Add(this.cbo_matoathuoc);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 105);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1051, 172);
            this.groupBox2.TabIndex = 83;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin cần xem";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(22, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 23);
            this.label1.TabIndex = 79;
            this.label1.Text = "Mã toa thuốc";
            // 
            // frm_Tri_xemchitiettoathuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1089, 552);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "frm_Tri_xemchitiettoathuoc";
            this.Text = "frm_XemChiTiet_ToaThuoc";
            this.Load += new System.EventHandler(this.frm_Tri_xemchitiettoathuoc_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn matoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn mathuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn sl_thuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn cachdung;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenthuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhphan;
        private System.Windows.Forms.ComboBox cbo_matoathuoc;
        private System.Windows.Forms.TextBox txt_sum;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btn_xemchitiet;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
    }
}