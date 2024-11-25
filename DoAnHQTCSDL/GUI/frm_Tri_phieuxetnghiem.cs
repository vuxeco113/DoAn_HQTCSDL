using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Utility;
using System.Data.Common;


namespace GUI
{
    public partial class frm_Tri_phieuxetnghiem : Form
    {
        DataTable dt_bn = new DataTable();
        DBconnection dbconnection = new DBconnection();
        DataColumn[] key = new DataColumn[1];
        public frm_Tri_phieuxetnghiem()
        {
            InitializeComponent();
        }


        public void loadcboPK()
        {
            string sql = "select * from PHIEUKHAM";
            DataTable dt_denkhoa = new DataTable();
            dt_denkhoa = dbconnection.GetDataTable(sql);



            cbo_pk.DataSource = dt_denkhoa;
            cbo_pk.DisplayMember = "MaPhieuKham";
            cbo_pk.ValueMember = "MaPhieuKham";
        }
        public void loadcboCD()
        {
            string sql = "select * from CHIDINHXETNGHIEM";
            DataTable dt_loai = new DataTable();
            dt_loai = dbconnection.GetDataTable(sql);



            cbo_loai.DataSource = dt_loai;
            cbo_loai.DisplayMember = "LoaiChiDinh";
            cbo_loai.ValueMember = "LoaiChiDinh";
        }
        public void loadcboMCD()
        {
            string sql = "select * from CHIDINHXETNGHIEM";
            DataTable dt_loai = new DataTable();
            dt_loai = dbconnection.GetDataTable(sql);



            cbo_maCD.DataSource = dt_loai;
            cbo_maCD.DisplayMember = "MaChiDinh";
            cbo_maCD.ValueMember = "MaChiDinh";
        }

        private void frm_Tri_phieuxetnghiem_Load(object sender, EventArgs e)
        {
            loadcboPK();
            loadcboCD();
            loadcboMCD();
        }

        private void btn_kt_Click(object sender, EventArgs e)
        {
            string maPhieuKham = cbo_pk.Text;
            if (string.IsNullOrWhiteSpace(maPhieuKham))
            {
                MessageBox.Show("Vui lòng nhập mã phiếu khám!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string tinhTrang = dbconnection.GetTinhTrangSucKhoe(maPhieuKham);
            id_tinhtrangsuckhoe.Text = tinhTrang;

        }

        private void btn_xulyketqua_Click(object sender, EventArgs e)
        {
            string maPhieuKham = cbo_pk.Text.Trim();
            string ketQuaXetNghiem = txt_kqxn.Text.Trim();


            if (string.IsNullOrWhiteSpace(maPhieuKham) || string.IsNullOrWhiteSpace(ketQuaXetNghiem))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            bool success = dbconnection.UpdateKetQuaXetNghiem(maPhieuKham, ketQuaXetNghiem);


            if (success)
            {
                MessageBox.Show("Xử lý kết quả thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);


                DataTable dt = dbconnection.GetAllPhieuKham();
                dataGridView2.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Xử Lý kết quả thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_chidinhxn_Click(object sender, EventArgs e)
        {
            string maPhieuKham = cbo_pk.Text;
            string maCD = cbo_maCD.Text;
            string loaiChiDinh = cbo_loai.Text.Trim();
            DateTime ngayChiDinh = dateTimePicker1.Value;

            if (string.IsNullOrWhiteSpace(maPhieuKham) || string.IsNullOrWhiteSpace(loaiChiDinh))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            bool success = dbconnection.InsertChiDinhXetNghiem(maCD, maPhieuKham, loaiChiDinh, ngayChiDinh);


            if (success)
            {
                MessageBox.Show("Thêm chỉ định thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);


                DataTable dt = dbconnection.GetAllChiDinhXetNghiem();
                dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Thêm chỉ định thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
