namespace GUI
{
    partial class frm_Phong_ChiaCa
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
            this.lblMaCaTruc = new System.Windows.Forms.Label();
            this.txtMaCaTruc = new System.Windows.Forms.TextBox();
            this.lblTenCa = new System.Windows.Forms.Label();
            this.txtTenCa = new System.Windows.Forms.TextBox();
            this.chkSang = new System.Windows.Forms.CheckBox();
            this.chkChieu = new System.Windows.Forms.CheckBox();
            this.chkToi = new System.Windows.Forms.CheckBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMaCaTruc
            // 
            this.lblMaCaTruc.AutoSize = true;
            this.lblMaCaTruc.Location = new System.Drawing.Point(147, 77);
            this.lblMaCaTruc.Name = "lblMaCaTruc";
            this.lblMaCaTruc.Size = new System.Drawing.Size(90, 16);
            this.lblMaCaTruc.TabIndex = 9;
            this.lblMaCaTruc.Text = "Mã Ca Trực:";
            // 
            // txtMaCaTruc
            // 
            this.txtMaCaTruc.Location = new System.Drawing.Point(282, 72);
            this.txtMaCaTruc.Name = "txtMaCaTruc";
            this.txtMaCaTruc.Size = new System.Drawing.Size(224, 22);
            this.txtMaCaTruc.TabIndex = 10;
            // 
            // lblTenCa
            // 
            this.lblTenCa.AutoSize = true;
            this.lblTenCa.Location = new System.Drawing.Point(147, 122);
            this.lblTenCa.Name = "lblTenCa";
            this.lblTenCa.Size = new System.Drawing.Size(61, 16);
            this.lblTenCa.TabIndex = 11;
            this.lblTenCa.Text = "Tên Ca:";
            // 
            // txtTenCa
            // 
            this.txtTenCa.Location = new System.Drawing.Point(282, 117);
            this.txtTenCa.Name = "txtTenCa";
            this.txtTenCa.Size = new System.Drawing.Size(224, 22);
            this.txtTenCa.TabIndex = 12;
            // 
            // chkSang
            // 
            this.chkSang.Location = new System.Drawing.Point(152, 161);
            this.chkSang.Name = "chkSang";
            this.chkSang.Size = new System.Drawing.Size(117, 36);
            this.chkSang.TabIndex = 13;
            this.chkSang.Text = "Sáng";
            // 
            // chkChieu
            // 
            this.chkChieu.Location = new System.Drawing.Point(282, 167);
            this.chkChieu.Name = "chkChieu";
            this.chkChieu.Size = new System.Drawing.Size(117, 24);
            this.chkChieu.TabIndex = 14;
            this.chkChieu.Text = "Chiều";
            // 
            // chkToi
            // 
            this.chkToi.Location = new System.Drawing.Point(416, 167);
            this.chkToi.Name = "chkToi";
            this.chkToi.Size = new System.Drawing.Size(91, 24);
            this.chkToi.TabIndex = 15;
            this.chkToi.Text = "Tối";
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(226, 247);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(90, 30);
            this.btnLuu.TabIndex = 16;
            this.btnLuu.Text = "Lưu";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(339, 247);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(90, 30);
            this.btnXoa.TabIndex = 17;
            this.btnXoa.Text = "Xóa";
            // 
            // frm_Phong_ChiaCa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(900, 450);
            this.Controls.Add(this.lblMaCaTruc);
            this.Controls.Add(this.txtMaCaTruc);
            this.Controls.Add(this.lblTenCa);
            this.Controls.Add(this.txtTenCa);
            this.Controls.Add(this.chkSang);
            this.Controls.Add(this.chkChieu);
            this.Controls.Add(this.chkToi);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frm_Phong_ChiaCa";
            this.Text = "frm_Phong_ChiaCa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMaCaTruc;
        private System.Windows.Forms.TextBox txtMaCaTruc;
        private System.Windows.Forms.Label lblTenCa;
        private System.Windows.Forms.TextBox txtTenCa;
        private System.Windows.Forms.CheckBox chkSang;
        private System.Windows.Forms.CheckBox chkChieu;
        private System.Windows.Forms.CheckBox chkToi;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
    }
}