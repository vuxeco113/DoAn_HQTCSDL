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
using System.Data.Odbc;

namespace GUI
{
    public partial class frm_Tri_ToaThuoc : Form
    {
        DataTable dt_bn = new DataTable();
        DBconnection dbconnection = new DBconnection();
        DataColumn[] key = new DataColumn[1];
        public frm_Tri_ToaThuoc()
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

        public void loadcboToa()
        {
            string sql = "select * from TOATHUOC";
            DataTable dt_denkhoa = new DataTable();
            dt_denkhoa = dbconnection.GetDataTable(sql);



            cbo_matoa.DataSource = dt_denkhoa;
            cbo_matoa.DisplayMember = "MATOA";
            cbo_matoa.ValueMember = "MATOA";
        }
        public void loadcboBN()
        {
            string sql = "select * from BENHNHAN";
            DataTable dt_denkhoa = new DataTable();
            dt_denkhoa = dbconnection.GetDataTable(sql);



            cbo_maBN.DataSource = dt_denkhoa;
            cbo_maBN.DisplayMember = "MaBenhNhan";
            cbo_maBN.ValueMember = "MaBenhNhan";
        }
        public void Load_dgrvtoa()
        {
            DataTable dt_bn = new DataTable();

            string sql = @"SELECT* FROM TOATHUOC";

            dt_bn = dbconnection.GetDataTable(sql);
            dataGridView1.DataSource = dt_bn;

            // Đặt khóa chính cho DataTable nếu cần thiết
            key[0] = dt_bn.Columns["MaToa"];
            dt_bn.PrimaryKey = key;
        }
        public bool kt_primary_key(string matoa)
        {
            //có rồi:false
            string maT = cbo_matoa.Text;
            string chuoi = ("select count(*) from TOATHUOC where MaToa='" + maT + "'");
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

        private void frm_Tri_ToaThuoc_Load(object sender, EventArgs e)
        {
            Load_dgrvtoa();
            loadcboPK();
            loadcboBN();
            loadcboToa();
        }

        private void btn_phacdodieutri_Click(object sender, EventArgs e)
        {
            if (kt_primary_key(cbo_matoa.Text) == true)
            {
                string maPhieuKham = cbo_pk.Text.Trim();
                string maToa = cbo_matoa.Text.Trim();
                DateTime ngayKetToa = dateTimePicker1_ngayketoa.Value;
                int soNgayDung = int.Parse(txt_songaydung.Text);
                DateTime ngayKetThuc = dateTimePicker1_ngayketthuc.Value;
                int soLoaiThuoc = int.Parse(txt_soloaithuoc.Text);
                string maBacSi = txt_mabacsi_ketoa.Text.Trim();


                bool isSuccess = dbconnection.CallPhacDoDieuTri(maPhieuKham, maToa, ngayKetToa, soNgayDung, ngayKetThuc, soLoaiThuoc, maBacSi);

                if (isSuccess)
                {
                    MessageBox.Show("Phác đồ điều trị đã được tạo thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Load_dgrvtoa();

                }
                else
                {
                    MessageBox.Show("Không thể tạo phác đồ điều trị.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Trùng khóa chính!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Load_dgrvtoa();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string matoa = cbo_matoa.Text;
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                int kq = dbconnection.thutucxoaToa(matoa);
                if (kq > 0)
                {
                    MessageBox.Show("Xóa thành công");
                }
                else
                {
                    MessageBox.Show("Xóa không thành công");
                }

                Load_dgrvtoa();
            }
        }

        private void btn_sumSoNgay_Click(object sender, EventArgs e)
        {
            string maBenhNhan = cbo_maBN.Text.Trim();

            if (!string.IsNullOrEmpty(maBenhNhan))
            {

                int tongSoNgay = dbconnection.GetTongSoNgayDungThuoc(maBenhNhan);

                if (tongSoNgay >= 0)
                {

                    id_songay.Text = $"Tổng số ngày sử dụng thuốc: {tongSoNgay} ngày";
                }
                else
                {

                    id_songay.Text = "Không thể tính tổng số ngày sử dụng thuốc.";
                }
            }
            else
            {

                MessageBox.Show("Vui lòng nhập mã bệnh nhân.",
                                "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                cbo_matoa.Text = row.Cells["matoa"].Value.ToString();
                txt_mabacsi_ketoa.Text = row.Cells["mabacsi"].Value.ToString();
                dateTimePicker1_ngayketoa.Text = row.Cells["ngayketoa"].Value.ToString();
                dateTimePicker1_ngayketthuc.Text = row.Cells["ngayketthuc"].Value.ToString();
                txt_songaydung.Text = row.Cells["songaydung"].Value.ToString();
                txt_soloaithuoc.Text = row.Cells["soloaithuoc"].Value.ToString();

            }
        }
    }
}
