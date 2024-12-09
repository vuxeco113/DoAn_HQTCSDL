namespace GUI
{
    partial class frmPhieuNhap
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
            this.txtMaPN = new System.Windows.Forms.TextBox();
            this.txtNCC = new System.Windows.Forms.TextBox();
            this.txtNgayNhap = new System.Windows.Forms.TextBox();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView_PNT = new System.Windows.Forms.DataGridView();
            this.btnxemChiTiet = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_PNT)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnxemChiTiet);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtThanhTien);
            this.groupBox1.Controls.Add(this.txtNgayNhap);
            this.groupBox1.Controls.Add(this.txtNCC);
            this.groupBox1.Controls.Add(this.txtMaPN);
            this.groupBox1.Location = new System.Drawing.Point(168, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1008, 208);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phiếu Nhập Thuốc";
            // 
            // txtMaPN
            // 
            this.txtMaPN.Location = new System.Drawing.Point(170, 51);
            this.txtMaPN.Name = "txtMaPN";
            this.txtMaPN.Size = new System.Drawing.Size(286, 22);
            this.txtMaPN.TabIndex = 0;
            // 
            // txtNCC
            // 
            this.txtNCC.Location = new System.Drawing.Point(673, 51);
            this.txtNCC.Name = "txtNCC";
            this.txtNCC.Size = new System.Drawing.Size(286, 22);
            this.txtNCC.TabIndex = 1;
            // 
            // txtNgayNhap
            // 
            this.txtNgayNhap.Location = new System.Drawing.Point(170, 104);
            this.txtNgayNhap.Name = "txtNgayNhap";
            this.txtNgayNhap.Size = new System.Drawing.Size(286, 22);
            this.txtNgayNhap.TabIndex = 2;
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Location = new System.Drawing.Point(673, 104);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(286, 22);
            this.txtThanhTien.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mã phiếu nhập :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(537, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mã Nhà Cung Cấp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(537, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Thành Tiền";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ngày Nhập";
            // 
            // dataGridView_PNT
            // 
            this.dataGridView_PNT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_PNT.Location = new System.Drawing.Point(168, 299);
            this.dataGridView_PNT.Name = "dataGridView_PNT";
            this.dataGridView_PNT.RowHeadersWidth = 51;
            this.dataGridView_PNT.RowTemplate.Height = 24;
            this.dataGridView_PNT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_PNT.Size = new System.Drawing.Size(1008, 381);
            this.dataGridView_PNT.TabIndex = 1;
            this.dataGridView_PNT.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_PNT_CellClick);
            // 
            // btnxemChiTiet
            // 
            this.btnxemChiTiet.Location = new System.Drawing.Point(188, 150);
            this.btnxemChiTiet.Name = "btnxemChiTiet";
            this.btnxemChiTiet.Size = new System.Drawing.Size(226, 35);
            this.btnxemChiTiet.TabIndex = 8;
            this.btnxemChiTiet.Text = "Xem Chi Tiết";
            this.btnxemChiTiet.UseVisualStyleBackColor = true;
            this.btnxemChiTiet.Click += new System.EventHandler(this.btnxemChiTiet_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(687, 150);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(226, 35);
            this.button1.TabIndex = 9;
            this.button1.Text = "Làm Mới";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1408, 771);
            this.Controls.Add(this.dataGridView_PNT);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmPhieuNhap";
            this.Text = "frmPhieuNhap";
            this.Load += new System.EventHandler(this.frmPhieuNhap_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_PNT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.TextBox txtNgayNhap;
        private System.Windows.Forms.TextBox txtNCC;
        private System.Windows.Forms.TextBox txtMaPN;
        private System.Windows.Forms.DataGridView dataGridView_PNT;
        private System.Windows.Forms.Button btnxemChiTiet;
        private System.Windows.Forms.Button button1;
    }
}