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
    public partial class frm_Tri_QuanLyBenhNhan : Form
    {
        DataTable dt_bn = new DataTable();
        DBconnection dbconnection = new DBconnection();
        DataColumn[] key = new DataColumn[1];
        public frm_Tri_QuanLyBenhNhan()
        {
            InitializeComponent();
        }

        public void loadcbotukhoa()
        {
            string sql = "select * from Khoa";
            DataTable dt_tukhoa = new DataTable();
            dt_tukhoa = dbconnection.GetDataTable(sql);

            cbo_tukhoa.DataSource = dt_tukhoa;
            cbo_tukhoa.DisplayMember = "TenKhoa";
            cbo_tukhoa.ValueMember = "MaKhoa";


        }
        public void loadcbodenkhoa()
        {
            string sql = "select * from Khoa";
            DataTable dt_denkhoa = new DataTable();
            dt_denkhoa = dbconnection.GetDataTable(sql);



            cbo_denkhoa.DataSource = dt_denkhoa;
            cbo_denkhoa.DisplayMember = "TenKhoa";
            cbo_denkhoa.ValueMember = "MaKhoa";
        }


        public void loadcbotinhtrang()
        {
            // Lọc chỉ lấy 3 trạng thái: "Đang điều trị", "Khỏi bệnh", "Tái khám"
            string sql = "SELECT DISTINCT TrangThai FROM BENHNHAN WHERE TrangThai IN (N'Đang điều trị', N'Xuất viện', N'Tái khám')";
            DataTable dt_tinhtrang = new DataTable();
            dt_tinhtrang = dbconnection.GetDataTable(sql);

            cbo_tinhtrang.DataSource = dt_tinhtrang;
            cbo_tinhtrang.DisplayMember = "TrangThai";
            cbo_tinhtrang.ValueMember = "TrangThai"; // Sử dụng "TrangThai" làm giá trị nếu không cần mã bệnh nhân
        }


        public void Load_dgrvBN()
        {
            DataTable dt_bn = new DataTable();
            // Câu lệnh SQL tính tuổi dựa trên NgaySinh
            string sql = @"SELECT 
                        MaBenhNhan, 
                        HoTen, 
                        NgaySinh, 
                        GioiTinh, 
                        DiaChi, 
                        SoDienThoai, 
                        TrangThai, 
                        MaBHYT, 
                        Tukhoa, 
                        Denkhoa,                
                        DATEDIFF(YEAR, NgaySinh, GETDATE()) AS Tuoi -- Tính tuổi dựa trên NgaySinh
                   FROM BENHNHAN";

            dt_bn = dbconnection.GetDataTable(sql);
            dataGridView1.DataSource = dt_bn;

            // Đặt khóa chính cho DataTable nếu cần thiết
            key[0] = dt_bn.Columns["MaBenhNhan"];
            dt_bn.PrimaryKey = key;
        }
  
        public bool kt_primary_key(string makhoa)
        {
            //có rồi:false
            string maPN = txt_MBN2.Text;
            string chuoi = ("select count(*) from BENHNHAN where MaBenhNhan='" + maPN + "'");
            int kq = (int)dbconnection.getExcecutesalar(chuoi);
            if (kq == 1)
            {
                return false;
            }
            else
            {
                return true;

            }

        }
        private void frm_Tri_QuanLyBenhNhan_Load_1(object sender, EventArgs e)
        {
            loadcbotukhoa();
            loadcbodenkhoa();
            loadcbotinhtrang();
            Load_dgrvBN();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có thực sự muốn thoát không???", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question); ;
            if (r == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (kt_primary_key(txt_MBN2.Text) == true)
            {


                int result = dbconnection.thutucthemBN(
                    txt_MBN2.Text,
                    txt_HT2.Text,
                    dateTimePicker1_ngaysinh.Value,
                    cbo_gioitinh.Text,
                    txt_dc.Text,
                    txt_sdt.Text,
                    txt_BHYT2.Text,
                    cbo_tinhtrang.Text,
                    cbo_tukhoa.Text,
                    cbo_denkhoa.Text
                );

                if (result > 0)
                {
                    MessageBox.Show("Thêm bệnh nhân thành công");
                }
                else
                {
                    MessageBox.Show("Thêm bệnh nhân không thành công");
                }

                Load_dgrvBN();
            }
            else
            {
                MessageBox.Show("Trùng khóa chính!");
            }


            Load_dgrvBN();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string maPN = txt_MBN2.Text;
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                int kq = dbconnection.thutucxoaBN(maPN);
                if (kq > 0)
                {
                    MessageBox.Show("Xóa thành công");
                }
                else
                {
                    MessageBox.Show("Xóa không thành công");
                }

                Load_dgrvBN();
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            int result = dbconnection.thutucsuaBN(
               txt_MBN2.Text,
               txt_HT2.Text,
               dateTimePicker1_ngaysinh.Value,
               cbo_gioitinh.Text,
               txt_dc.Text,
               txt_sdt.Text,
               txt_BHYT2.Text,
               cbo_tukhoa.Text,
               cbo_denkhoa.Text
           );

            if (result > 0)
            {
                MessageBox.Show("Sửa bệnh nhân thành công");
            }
            else
            {
                MessageBox.Show("Sửa bệnh nhân không thành công");
            }

            Load_dgrvBN();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu hàng hợp lệ
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txt_MBN2.Text = row.Cells["mabn"].Value.ToString();
                txt_HT2.Text = row.Cells["hotenbn"].Value.ToString();
                dateTimePicker1_ngaysinh.Text = row.Cells["ngaySinh"].Value.ToString();
                cbo_gioitinh.Text = row.Cells["gioiTinh"].Value.ToString();
                txt_sdt.Text = row.Cells["sdt"].Value.ToString();
                txt_BHYT2.Text = row.Cells["mabhyt"].Value.ToString();
                txt_dc.Text = row.Cells["diachi"].Value.ToString();
                txt_tuoi.Text = row.Cells["tuoi"].Value.ToString();
                cbo_tukhoa.Text = row.Cells["tukhoa"].Value.ToString();
                cbo_denkhoa.Text = row.Cells["denkhoa"].Value.ToString();
                cbo_tinhtrang.Text = row.Cells["tinhtrang"].Value.ToString();
            }
        }

    }
}

