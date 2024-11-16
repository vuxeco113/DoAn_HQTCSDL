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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblMaLichTruc = new System.Windows.Forms.Label();
            this.txtMaLichTruc = new System.Windows.Forms.TextBox();
            this.lblBacSi = new System.Windows.Forms.Label();
            this.lblNgayTruc = new System.Windows.Forms.Label();
            this.dtpNgayTruc = new System.Windows.Forms.DateTimePicker();
            this.lblCaTruc = new System.Windows.Forms.Label();
            this.cboCaTruc = new System.Windows.Forms.ComboBox();
            this.btnLuuLichTruc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(506, 287);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 30);
            this.button1.TabIndex = 20;
            this.button1.Text = "Xem lịch";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(414, 138);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(334, 22);
            this.textBox1.TabIndex = 19;
            // 
            // lblMaLichTruc
            // 
            this.lblMaLichTruc.AutoSize = true;
            this.lblMaLichTruc.Location = new System.Drawing.Point(279, 96);
            this.lblMaLichTruc.Name = "lblMaLichTruc";
            this.lblMaLichTruc.Size = new System.Drawing.Size(99, 16);
            this.lblMaLichTruc.TabIndex = 11;
            this.lblMaLichTruc.Text = "Mã Lịch Trực:";
            // 
            // txtMaLichTruc
            // 
            this.txtMaLichTruc.Location = new System.Drawing.Point(414, 91);
            this.txtMaLichTruc.Name = "txtMaLichTruc";
            this.txtMaLichTruc.Size = new System.Drawing.Size(334, 22);
            this.txtMaLichTruc.TabIndex = 12;
            // 
            // lblBacSi
            // 
            this.lblBacSi.AutoSize = true;
            this.lblBacSi.Location = new System.Drawing.Point(279, 141);
            this.lblBacSi.Name = "lblBacSi";
            this.lblBacSi.Size = new System.Drawing.Size(58, 16);
            this.lblBacSi.TabIndex = 13;
            this.lblBacSi.Text = "Bác Sĩ:";
            // 
            // lblNgayTruc
            // 
            this.lblNgayTruc.AutoSize = true;
            this.lblNgayTruc.Location = new System.Drawing.Point(279, 186);
            this.lblNgayTruc.Name = "lblNgayTruc";
            this.lblNgayTruc.Size = new System.Drawing.Size(83, 16);
            this.lblNgayTruc.TabIndex = 14;
            this.lblNgayTruc.Text = "Ngày Trực:";
            // 
            // dtpNgayTruc
            // 
            this.dtpNgayTruc.Location = new System.Drawing.Point(414, 181);
            this.dtpNgayTruc.Name = "dtpNgayTruc";
            this.dtpNgayTruc.Size = new System.Drawing.Size(334, 22);
            this.dtpNgayTruc.TabIndex = 15;
            // 
            // lblCaTruc
            // 
            this.lblCaTruc.AutoSize = true;
            this.lblCaTruc.Location = new System.Drawing.Point(279, 231);
            this.lblCaTruc.Name = "lblCaTruc";
            this.lblCaTruc.Size = new System.Drawing.Size(65, 16);
            this.lblCaTruc.TabIndex = 16;
            this.lblCaTruc.Text = "Ca Trực:";
            // 
            // cboCaTruc
            // 
            this.cboCaTruc.Location = new System.Drawing.Point(414, 226);
            this.cboCaTruc.Name = "cboCaTruc";
            this.cboCaTruc.Size = new System.Drawing.Size(334, 24);
            this.cboCaTruc.TabIndex = 17;
            // 
            // btnLuuLichTruc
            // 
            this.btnLuuLichTruc.Location = new System.Drawing.Point(342, 287);
            this.btnLuuLichTruc.Name = "btnLuuLichTruc";
            this.btnLuuLichTruc.Size = new System.Drawing.Size(112, 30);
            this.btnLuuLichTruc.TabIndex = 18;
            this.btnLuuLichTruc.Text = "Lưu Lịch Trực";
            // 
            // frm_Phong_LichTruc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1329, 639);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblMaLichTruc;
        private System.Windows.Forms.TextBox txtMaLichTruc;
        private System.Windows.Forms.Label lblBacSi;
        private System.Windows.Forms.Label lblNgayTruc;
        private System.Windows.Forms.DateTimePicker dtpNgayTruc;
        private System.Windows.Forms.Label lblCaTruc;
        private System.Windows.Forms.ComboBox cboCaTruc;
        private System.Windows.Forms.Button btnLuuLichTruc;
    }
}