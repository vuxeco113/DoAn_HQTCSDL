namespace GUI
{
    partial class frm_Phong_LichTruc
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
            this.lblMaLichTruc = new System.Windows.Forms.Label();
            this.txtMaLichTruc = new System.Windows.Forms.TextBox();
            this.lblBacSi = new System.Windows.Forms.Label();
            this.lblNgayTruc = new System.Windows.Forms.Label();
            this.dtpNgayTruc = new System.Windows.Forms.DateTimePicker();
            this.lblCaTruc = new System.Windows.Forms.Label();
            this.cboCaTruc = new System.Windows.Forms.ComboBox();
            this.btnLuuLichTruc = new System.Windows.Forms.Button();
            this.cboBacsi = new System.Windows.Forms.ComboBox();
            this.dgvView = new System.Windows.Forms.DataGridView();
            this.btnXoaLichTruc = new System.Windows.Forms.Button();
            this.btnThemLichTruc = new System.Windows.Forms.Button();
            this.btnDoiLichTruc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMaLichTruc
            // 
            this.lblMaLichTruc.AutoSize = true;
            this.lblMaLichTruc.Location = new System.Drawing.Point(163, 40);
            this.lblMaLichTruc.Name = "lblMaLichTruc";
            this.lblMaLichTruc.Size = new System.Drawing.Size(99, 16);
            this.lblMaLichTruc.TabIndex = 11;
            this.lblMaLichTruc.Text = "Mã Lịch Trực:";
            // 
            // txtMaLichTruc
            // 
            this.txtMaLichTruc.Location = new System.Drawing.Point(298, 35);
            this.txtMaLichTruc.Name = "txtMaLichTruc";
            this.txtMaLichTruc.Size = new System.Drawing.Size(334, 22);
            this.txtMaLichTruc.TabIndex = 12;
            // 
            // lblBacSi
            // 
            this.lblBacSi.AutoSize = true;
            this.lblBacSi.Location = new System.Drawing.Point(163, 85);
            this.lblBacSi.Name = "lblBacSi";
            this.lblBacSi.Size = new System.Drawing.Size(58, 16);
            this.lblBacSi.TabIndex = 13;
            this.lblBacSi.Text = "Bác Sĩ:";
            // 
            // lblNgayTruc
            // 
            this.lblNgayTruc.AutoSize = true;
            this.lblNgayTruc.Location = new System.Drawing.Point(163, 130);
            this.lblNgayTruc.Name = "lblNgayTruc";
            this.lblNgayTruc.Size = new System.Drawing.Size(83, 16);
            this.lblNgayTruc.TabIndex = 14;
            this.lblNgayTruc.Text = "Ngày Trực:";
            // 
            // dtpNgayTruc
            // 
            this.dtpNgayTruc.Location = new System.Drawing.Point(298, 125);
            this.dtpNgayTruc.Name = "dtpNgayTruc";
            this.dtpNgayTruc.Size = new System.Drawing.Size(334, 22);
            this.dtpNgayTruc.TabIndex = 15;
            // 
            // lblCaTruc
            // 
            this.lblCaTruc.AutoSize = true;
            this.lblCaTruc.Location = new System.Drawing.Point(163, 175);
            this.lblCaTruc.Name = "lblCaTruc";
            this.lblCaTruc.Size = new System.Drawing.Size(65, 16);
            this.lblCaTruc.TabIndex = 16;
            this.lblCaTruc.Text = "Ca Trực:";
            // 
            // cboCaTruc
            // 
            this.cboCaTruc.Location = new System.Drawing.Point(298, 170);
            this.cboCaTruc.Name = "cboCaTruc";
            this.cboCaTruc.Size = new System.Drawing.Size(334, 24);
            this.cboCaTruc.TabIndex = 17;
            // 
            // btnLuuLichTruc
            // 
            this.btnLuuLichTruc.Location = new System.Drawing.Point(166, 231);
            this.btnLuuLichTruc.Name = "btnLuuLichTruc";
            this.btnLuuLichTruc.Size = new System.Drawing.Size(112, 30);
            this.btnLuuLichTruc.TabIndex = 18;
            this.btnLuuLichTruc.Text = "Lưu Lịch Trực";
            // 
            // cboBacsi
            // 
            this.cboBacsi.Location = new System.Drawing.Point(298, 82);
            this.cboBacsi.Name = "cboBacsi";
            this.cboBacsi.Size = new System.Drawing.Size(334, 24);
            this.cboBacsi.TabIndex = 21;
            // 
            // dgvView
            // 
            this.dgvView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvView.Location = new System.Drawing.Point(12, 299);
            this.dgvView.Name = "dgvView";
            this.dgvView.RowHeadersWidth = 51;
            this.dgvView.RowTemplate.Height = 24;
            this.dgvView.Size = new System.Drawing.Size(1057, 296);
            this.dgvView.TabIndex = 22;
            this.dgvView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvView_CellClick);
            // 
            // btnXoaLichTruc
            // 
            this.btnXoaLichTruc.Location = new System.Drawing.Point(509, 231);
            this.btnXoaLichTruc.Name = "btnXoaLichTruc";
            this.btnXoaLichTruc.Size = new System.Drawing.Size(123, 30);
            this.btnXoaLichTruc.TabIndex = 23;
            this.btnXoaLichTruc.Text = "Xóa Lịch Trực";
            this.btnXoaLichTruc.Click += new System.EventHandler(this.btnXoaLichTruc_Click);
            // 
            // btnThemLichTruc
            // 
            this.btnThemLichTruc.Location = new System.Drawing.Point(328, 231);
            this.btnThemLichTruc.Name = "btnThemLichTruc";
            this.btnThemLichTruc.Size = new System.Drawing.Size(140, 30);
            this.btnThemLichTruc.TabIndex = 24;
            this.btnThemLichTruc.Text = "Thêm Lịch Trực";
            this.btnThemLichTruc.Click += new System.EventHandler(this.btnThemLichTruc_Click);
            // 
            // btnDoiLichTruc
            // 
            this.btnDoiLichTruc.Location = new System.Drawing.Point(669, 231);
            this.btnDoiLichTruc.Name = "btnDoiLichTruc";
            this.btnDoiLichTruc.Size = new System.Drawing.Size(123, 30);
            this.btnDoiLichTruc.TabIndex = 25;
            this.btnDoiLichTruc.Text = "Đổi lịch trực";
            this.btnDoiLichTruc.Click += new System.EventHandler(this.btnDoiLichTruc_Click);
            // 
            // frm_Phong_LichTruc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1329, 639);
            this.Controls.Add(this.btnDoiLichTruc);
            this.Controls.Add(this.btnThemLichTruc);
            this.Controls.Add(this.btnXoaLichTruc);
            this.Controls.Add(this.dgvView);
            this.Controls.Add(this.cboBacsi);
            this.Controls.Add(this.lblMaLichTruc);
            this.Controls.Add(this.txtMaLichTruc);
            this.Controls.Add(this.lblBacSi);
            this.Controls.Add(this.lblNgayTruc);
            this.Controls.Add(this.dtpNgayTruc);
            this.Controls.Add(this.lblCaTruc);
            this.Controls.Add(this.cboCaTruc);
            this.Controls.Add(this.btnLuuLichTruc);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frm_Phong_LichTruc";
            this.Text = "frm_Phong_LichTruc";
            ((System.ComponentModel.ISupportInitialize)(this.dgvView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblMaLichTruc;
        private System.Windows.Forms.TextBox txtMaLichTruc;
        private System.Windows.Forms.Label lblBacSi;
        private System.Windows.Forms.Label lblNgayTruc;
        private System.Windows.Forms.DateTimePicker dtpNgayTruc;
        private System.Windows.Forms.Label lblCaTruc;
        private System.Windows.Forms.ComboBox cboCaTruc;
        private System.Windows.Forms.Button btnLuuLichTruc;
        private System.Windows.Forms.ComboBox cboBacsi;
        private System.Windows.Forms.DataGridView dgvView;
        private System.Windows.Forms.Button btnXoaLichTruc;
        private System.Windows.Forms.Button btnThemLichTruc;
        private System.Windows.Forms.Button btnDoiLichTruc;
    }
}