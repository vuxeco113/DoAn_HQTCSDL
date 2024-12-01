namespace GUI
{
    partial class frm_Nguyen_KiemTraBHYT
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Tinh = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_KiemTra = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_MaBenhNhan = new System.Windows.Forms.ComboBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btn_Tinh);
            this.groupBox2.Location = new System.Drawing.Point(809, 61);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(431, 314);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tổng số bệnh nhân đang điều trị";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(118, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 38);
            this.label3.TabIndex = 3;
            // 
            // btn_Tinh
            // 
            this.btn_Tinh.Location = new System.Drawing.Point(126, 40);
            this.btn_Tinh.Name = "btn_Tinh";
            this.btn_Tinh.Size = new System.Drawing.Size(165, 43);
            this.btn_Tinh.TabIndex = 2;
            this.btn_Tinh.Text = "Tính";
            this.btn_Tinh.UseVisualStyleBackColor = true;
            this.btn_Tinh.Click += new System.EventHandler(this.btn_Tinh_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmb_MaBenhNhan);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btn_KiemTra);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(305, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(431, 314);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kiểm tra bảo hiểm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(118, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 38);
            this.label2.TabIndex = 3;
            // 
            // btn_KiemTra
            // 
            this.btn_KiemTra.Location = new System.Drawing.Point(148, 101);
            this.btn_KiemTra.Name = "btn_KiemTra";
            this.btn_KiemTra.Size = new System.Drawing.Size(165, 43);
            this.btn_KiemTra.TabIndex = 2;
            this.btn_KiemTra.Text = "Kiểm tra ";
            this.btn_KiemTra.UseVisualStyleBackColor = true;
            this.btn_KiemTra.Click += new System.EventHandler(this.btn_KiemTra_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã bệnh nhân :";
            // 
            // cmb_MaBenhNhan
            // 
            this.cmb_MaBenhNhan.FormattingEnabled = true;
            this.cmb_MaBenhNhan.Location = new System.Drawing.Point(150, 50);
            this.cmb_MaBenhNhan.Name = "cmb_MaBenhNhan";
            this.cmb_MaBenhNhan.Size = new System.Drawing.Size(242, 24);
            this.cmb_MaBenhNhan.TabIndex = 5;
            // 
            // frm_Nguyen_KiemTraBHYT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1580, 698);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frm_Nguyen_KiemTraBHYT";
            this.Text = "frm_Nguyen_KiemTraBHYT";
            this.Load += new System.EventHandler(this.frm_Nguyen_KiemTraBHYT_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Tinh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_KiemTra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_MaBenhNhan;
    }
}