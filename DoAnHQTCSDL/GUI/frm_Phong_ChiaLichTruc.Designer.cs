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
            this.lblBacSi = new System.Windows.Forms.Label();
            this.lblNgayTruc = new System.Windows.Forms.Label();
            this.dtpNgayTruc = new System.Windows.Forms.DateTimePicker();
            this.lblCaTruc = new System.Windows.Forms.Label();
            this.cboCaTruc = new System.Windows.Forms.ComboBox();
            this.cboBacsi = new System.Windows.Forms.ComboBox();
            this.dgvLichTruc1 = new System.Windows.Forms.DataGridView();
            this.btnXoaLichTruc = new System.Windows.Forms.Button();
            this.btnThemLichTruc = new System.Windows.Forms.Button();
            this.btnDoiLichTruc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKhoa = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_ChiaTuDong = new System.Windows.Forms.Button();
            this.btn_loctheongayca = new System.Windows.Forms.Button();
            this.btn_loctheoten = new System.Windows.Forms.Button();
            this.btn_loctheongay = new System.Windows.Forms.Button();
            this.btn_HienTatCA = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_ktrcatrong = new System.Windows.Forms.Button();
            this.dgv_catruc1 = new System.Windows.Forms.DataGridView();
            this.btn_LayLichTrucCuaBacSi = new System.Windows.Forms.Button();
            this.btn_LayDanhSachBacSi = new System.Windows.Forms.Button();
            this.btn_LayCaTrucChuaDuocPhanCongTrongNgay = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.btn_LayDanhSachLichTruc = new System.Windows.Forms.Button();
            this.btn_LayBacSiCungCa = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichTruc1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_catruc1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBacSi
            // 
            this.lblBacSi.AutoSize = true;
            this.lblBacSi.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBacSi.Location = new System.Drawing.Point(11, 17);
            this.lblBacSi.Name = "lblBacSi";
            this.lblBacSi.Size = new System.Drawing.Size(97, 35);
            this.lblBacSi.TabIndex = 13;
            this.lblBacSi.Text = "BÁC SĨ:";
            // 
            // lblNgayTruc
            // 
            this.lblNgayTruc.AutoSize = true;
            this.lblNgayTruc.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayTruc.Location = new System.Drawing.Point(11, 75);
            this.lblNgayTruc.Name = "lblNgayTruc";
            this.lblNgayTruc.Size = new System.Drawing.Size(160, 35);
            this.lblNgayTruc.TabIndex = 14;
            this.lblNgayTruc.Text = "NGÀY TRỰC:";
            // 
            // dtpNgayTruc
            // 
            this.dtpNgayTruc.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayTruc.Location = new System.Drawing.Point(172, 76);
            this.dtpNgayTruc.Name = "dtpNgayTruc";
            this.dtpNgayTruc.Size = new System.Drawing.Size(334, 40);
            this.dtpNgayTruc.TabIndex = 15;
            // 
            // lblCaTruc
            // 
            this.lblCaTruc.AutoSize = true;
            this.lblCaTruc.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaTruc.Location = new System.Drawing.Point(11, 133);
            this.lblCaTruc.Name = "lblCaTruc";
            this.lblCaTruc.Size = new System.Drawing.Size(118, 35);
            this.lblCaTruc.TabIndex = 16;
            this.lblCaTruc.Text = "CA TRỰC";
            // 
            // cboCaTruc
            // 
            this.cboCaTruc.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCaTruc.Location = new System.Drawing.Point(172, 134);
            this.cboCaTruc.Name = "cboCaTruc";
            this.cboCaTruc.Size = new System.Drawing.Size(334, 41);
            this.cboCaTruc.TabIndex = 17;
            this.cboCaTruc.SelectedIndexChanged += new System.EventHandler(this.cboCaTruc_SelectedIndexChanged);
            // 
            // cboBacsi
            // 
            this.cboBacsi.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBacsi.Location = new System.Drawing.Point(172, 17);
            this.cboBacsi.Name = "cboBacsi";
            this.cboBacsi.Size = new System.Drawing.Size(334, 41);
            this.cboBacsi.TabIndex = 21;
            // 
            // dgvLichTruc1
            // 
            this.dgvLichTruc1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLichTruc1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLichTruc1.Location = new System.Drawing.Point(12, 299);
            this.dgvLichTruc1.MultiSelect = false;
            this.dgvLichTruc1.Name = "dgvLichTruc1";
            this.dgvLichTruc1.RowHeadersWidth = 51;
            this.dgvLichTruc1.RowTemplate.Height = 24;
            this.dgvLichTruc1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLichTruc1.Size = new System.Drawing.Size(948, 328);
            this.dgvLichTruc1.TabIndex = 22;
            this.dgvLichTruc1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvView_CellClick);
            // 
            // btnXoaLichTruc
            // 
            this.btnXoaLichTruc.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaLichTruc.Location = new System.Drawing.Point(524, 68);
            this.btnXoaLichTruc.Name = "btnXoaLichTruc";
            this.btnXoaLichTruc.Size = new System.Drawing.Size(175, 53);
            this.btnXoaLichTruc.TabIndex = 23;
            this.btnXoaLichTruc.Text = "Xóa Lịch Trực";
            this.btnXoaLichTruc.Click += new System.EventHandler(this.btnXoaLichTruc_Click);
            // 
            // btnThemLichTruc
            // 
            this.btnThemLichTruc.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemLichTruc.Location = new System.Drawing.Point(524, 17);
            this.btnThemLichTruc.Name = "btnThemLichTruc";
            this.btnThemLichTruc.Size = new System.Drawing.Size(175, 53);
            this.btnThemLichTruc.TabIndex = 24;
            this.btnThemLichTruc.Text = "Thêm Lịch Trực";
            this.btnThemLichTruc.Click += new System.EventHandler(this.btnThemLichTruc_Click);
            // 
            // btnDoiLichTruc
            // 
            this.btnDoiLichTruc.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoiLichTruc.Location = new System.Drawing.Point(524, 122);
            this.btnDoiLichTruc.Name = "btnDoiLichTruc";
            this.btnDoiLichTruc.Size = new System.Drawing.Size(175, 53);
            this.btnDoiLichTruc.TabIndex = 25;
            this.btnDoiLichTruc.Text = "Đổi lịch trực";
            this.btnDoiLichTruc.Click += new System.EventHandler(this.btnDoiLichTruc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(540, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 32);
            this.label1.TabIndex = 26;
            this.label1.Text = "QUẢN LÝ LỊCH TRỰC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 35);
            this.label2.TabIndex = 27;
            this.label2.Text = "KHOA";
            // 
            // txtKhoa
            // 
            this.txtKhoa.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKhoa.Location = new System.Drawing.Point(172, 191);
            this.txtKhoa.Name = "txtKhoa";
            this.txtKhoa.ReadOnly = true;
            this.txtKhoa.Size = new System.Drawing.Size(334, 40);
            this.txtKhoa.TabIndex = 28;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_ChiaTuDong);
            this.groupBox1.Controls.Add(this.txtKhoa);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnDoiLichTruc);
            this.groupBox1.Controls.Add(this.btnThemLichTruc);
            this.groupBox1.Controls.Add(this.btnXoaLichTruc);
            this.groupBox1.Controls.Add(this.cboBacsi);
            this.groupBox1.Controls.Add(this.lblBacSi);
            this.groupBox1.Controls.Add(this.lblNgayTruc);
            this.groupBox1.Controls.Add(this.dtpNgayTruc);
            this.groupBox1.Controls.Add(this.lblCaTruc);
            this.groupBox1.Controls.Add(this.cboCaTruc);
            this.groupBox1.Location = new System.Drawing.Point(24, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(705, 240);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chia Lịch trực";
            // 
            // btn_ChiaTuDong
            // 
            this.btn_ChiaTuDong.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ChiaTuDong.Location = new System.Drawing.Point(524, 173);
            this.btn_ChiaTuDong.Name = "btn_ChiaTuDong";
            this.btn_ChiaTuDong.Size = new System.Drawing.Size(175, 53);
            this.btn_ChiaTuDong.TabIndex = 29;
            this.btn_ChiaTuDong.Text = "Chia lịch tự động";
            this.btn_ChiaTuDong.Click += new System.EventHandler(this.btn_ChiaTuDong_Click);
            // 
            // btn_loctheongayca
            // 
            this.btn_loctheongayca.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_loctheongayca.Location = new System.Drawing.Point(11, 125);
            this.btn_loctheongayca.Name = "btn_loctheongayca";
            this.btn_loctheongayca.Size = new System.Drawing.Size(175, 53);
            this.btn_loctheongayca.TabIndex = 32;
            this.btn_loctheongayca.Text = "Lọc theo ngày + ca";
            this.btn_loctheongayca.Click += new System.EventHandler(this.btn_loctheokhoa_Click);
            // 
            // btn_loctheoten
            // 
            this.btn_loctheoten.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_loctheoten.Location = new System.Drawing.Point(11, 20);
            this.btn_loctheoten.Name = "btn_loctheoten";
            this.btn_loctheoten.Size = new System.Drawing.Size(175, 53);
            this.btn_loctheoten.TabIndex = 31;
            this.btn_loctheoten.Text = "Lọc theo Tên";
            this.btn_loctheoten.Click += new System.EventHandler(this.btn_loctheoten_Click);
            // 
            // btn_loctheongay
            // 
            this.btn_loctheongay.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_loctheongay.Location = new System.Drawing.Point(11, 71);
            this.btn_loctheongay.Name = "btn_loctheongay";
            this.btn_loctheongay.Size = new System.Drawing.Size(175, 53);
            this.btn_loctheongay.TabIndex = 30;
            this.btn_loctheongay.Text = "Lọc theo ngày";
            this.btn_loctheongay.Click += new System.EventHandler(this.btn_loctheongay_Click);
            // 
            // btn_HienTatCA
            // 
            this.btn_HienTatCA.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_HienTatCA.Location = new System.Drawing.Point(11, 181);
            this.btn_HienTatCA.Name = "btn_HienTatCA";
            this.btn_HienTatCA.Size = new System.Drawing.Size(175, 53);
            this.btn_HienTatCA.TabIndex = 33;
            this.btn_HienTatCA.Text = "Hiện tất cả";
            this.btn_HienTatCA.Click += new System.EventHandler(this.btn_HienTatCA_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.Location = new System.Drawing.Point(226, 180);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(162, 54);
            this.btn_Clear.TabIndex = 34;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_ktrcatrong
            // 
            this.btn_ktrcatrong.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ktrcatrong.Location = new System.Drawing.Point(226, 100);
            this.btn_ktrcatrong.Name = "btn_ktrcatrong";
            this.btn_ktrcatrong.Size = new System.Drawing.Size(162, 67);
            this.btn_ktrcatrong.TabIndex = 35;
            this.btn_ktrcatrong.Text = "Kiểm tra ca trống (trong ngày)";
            this.btn_ktrcatrong.Click += new System.EventHandler(this.btn_ktrcatrong_Click);
            // 
            // dgv_catruc1
            // 
            this.dgv_catruc1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_catruc1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_catruc1.Location = new System.Drawing.Point(1000, 372);
            this.dgv_catruc1.Name = "dgv_catruc1";
            this.dgv_catruc1.RowHeadersWidth = 51;
            this.dgv_catruc1.RowTemplate.Height = 24;
            this.dgv_catruc1.Size = new System.Drawing.Size(524, 255);
            this.dgv_catruc1.TabIndex = 36;
            // 
            // btn_LayLichTrucCuaBacSi
            // 
            this.btn_LayLichTrucCuaBacSi.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LayLichTrucCuaBacSi.Location = new System.Drawing.Point(226, 20);
            this.btn_LayLichTrucCuaBacSi.Name = "btn_LayLichTrucCuaBacSi";
            this.btn_LayLichTrucCuaBacSi.Size = new System.Drawing.Size(162, 67);
            this.btn_LayLichTrucCuaBacSi.TabIndex = 37;
            this.btn_LayLichTrucCuaBacSi.Text = "Lịch trực của BS trong ngày";
            this.btn_LayLichTrucCuaBacSi.Click += new System.EventHandler(this.btn_LayLichTrucCuaBacSi_Click);
            // 
            // btn_LayDanhSachBacSi
            // 
            this.btn_LayDanhSachBacSi.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LayDanhSachBacSi.Location = new System.Drawing.Point(407, 20);
            this.btn_LayDanhSachBacSi.Name = "btn_LayDanhSachBacSi";
            this.btn_LayDanhSachBacSi.Size = new System.Drawing.Size(162, 67);
            this.btn_LayDanhSachBacSi.TabIndex = 38;
            this.btn_LayDanhSachBacSi.Text = "DS BS có ít hơn 2 ca trong 1 ngày";
            this.btn_LayDanhSachBacSi.Click += new System.EventHandler(this.btn_LayDanhSachBacSi_Click);
            // 
            // btn_LayCaTrucChuaDuocPhanCongTrongNgay
            // 
            this.btn_LayCaTrucChuaDuocPhanCongTrongNgay.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LayCaTrucChuaDuocPhanCongTrongNgay.Location = new System.Drawing.Point(588, 20);
            this.btn_LayCaTrucChuaDuocPhanCongTrongNgay.Name = "btn_LayCaTrucChuaDuocPhanCongTrongNgay";
            this.btn_LayCaTrucChuaDuocPhanCongTrongNgay.Size = new System.Drawing.Size(162, 67);
            this.btn_LayCaTrucChuaDuocPhanCongTrongNgay.TabIndex = 39;
            this.btn_LayCaTrucChuaDuocPhanCongTrongNgay.Text = "Lấy ca trực chưa được phân công trong ngày";
            this.btn_LayCaTrucChuaDuocPhanCongTrongNgay.Click += new System.EventHandler(this.btn_LayCaTrucChuaDuocPhanCongTrongNgay_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(996, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 21);
            this.label3.TabIndex = 40;
            this.label3.Text = "NGÀY BẮT ĐẦU:";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartDate.Location = new System.Drawing.Point(1138, 295);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(334, 28);
            this.dtpStartDate.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(996, 331);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 21);
            this.label4.TabIndex = 42;
            this.label4.Text = "NGÀY KẾT THÚC:";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndDate.Location = new System.Drawing.Point(1138, 329);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(334, 28);
            this.dtpEndDate.TabIndex = 43;
            // 
            // btn_LayDanhSachLichTruc
            // 
            this.btn_LayDanhSachLichTruc.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LayDanhSachLichTruc.Location = new System.Drawing.Point(407, 100);
            this.btn_LayDanhSachLichTruc.Name = "btn_LayDanhSachLichTruc";
            this.btn_LayDanhSachLichTruc.Size = new System.Drawing.Size(162, 67);
            this.btn_LayDanhSachLichTruc.TabIndex = 44;
            this.btn_LayDanhSachLichTruc.Text = "DS BS Trực trong khoảng ngày";
            this.btn_LayDanhSachLichTruc.Click += new System.EventHandler(this.btn_LayDanhSachLichTruc_Click);
            // 
            // btn_LayBacSiCungCa
            // 
            this.btn_LayBacSiCungCa.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LayBacSiCungCa.Location = new System.Drawing.Point(588, 100);
            this.btn_LayBacSiCungCa.Name = "btn_LayBacSiCungCa";
            this.btn_LayBacSiCungCa.Size = new System.Drawing.Size(162, 67);
            this.btn_LayBacSiCungCa.TabIndex = 45;
            this.btn_LayBacSiCungCa.Text = "DS BS Cùng ca trực";
            this.btn_LayBacSiCungCa.Click += new System.EventHandler(this.btn_LayBacSiCungCa_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_LayBacSiCungCa);
            this.groupBox2.Controls.Add(this.btn_LayDanhSachLichTruc);
            this.groupBox2.Controls.Add(this.btn_LayCaTrucChuaDuocPhanCongTrongNgay);
            this.groupBox2.Controls.Add(this.btn_LayDanhSachBacSi);
            this.groupBox2.Controls.Add(this.btn_LayLichTrucCuaBacSi);
            this.groupBox2.Controls.Add(this.btn_ktrcatrong);
            this.groupBox2.Controls.Add(this.btn_Clear);
            this.groupBox2.Controls.Add(this.btn_HienTatCA);
            this.groupBox2.Controls.Add(this.btn_loctheongayca);
            this.groupBox2.Controls.Add(this.btn_loctheoten);
            this.groupBox2.Controls.Add(this.btn_loctheongay);
            this.groupBox2.Location = new System.Drawing.Point(774, 45);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(781, 242);
            this.groupBox2.TabIndex = 46;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Các Chức năng hỗ trợ";
            // 
            // frm_Phong_LichTruc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1591, 639);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgv_catruc1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvLichTruc1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frm_Phong_LichTruc";
            this.Text = "frm_Phong_LichTruc";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichTruc1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_catruc1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblBacSi;
        private System.Windows.Forms.Label lblNgayTruc;
        private System.Windows.Forms.DateTimePicker dtpNgayTruc;
        private System.Windows.Forms.Label lblCaTruc;
        private System.Windows.Forms.ComboBox cboCaTruc;
        private System.Windows.Forms.ComboBox cboBacsi;
        private System.Windows.Forms.DataGridView dgvLichTruc1;
        private System.Windows.Forms.Button btnXoaLichTruc;
        private System.Windows.Forms.Button btnThemLichTruc;
        private System.Windows.Forms.Button btnDoiLichTruc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKhoa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_ChiaTuDong;
        private System.Windows.Forms.Button btn_loctheongayca;
        private System.Windows.Forms.Button btn_loctheoten;
        private System.Windows.Forms.Button btn_loctheongay;
        private System.Windows.Forms.Button btn_HienTatCA;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_ktrcatrong;
        private System.Windows.Forms.DataGridView dgv_catruc1;
        private System.Windows.Forms.Button btn_LayLichTrucCuaBacSi;
        private System.Windows.Forms.Button btn_LayDanhSachBacSi;
        private System.Windows.Forms.Button btn_LayCaTrucChuaDuocPhanCongTrongNgay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Button btn_LayDanhSachLichTruc;
        private System.Windows.Forms.Button btn_LayBacSiCungCa;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}