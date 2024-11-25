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
    public partial class frm_Tri_Phieukham : Form
    {
        DataTable dt_bn = new DataTable();
        DBconnection dbconnection = new DBconnection();
        DataColumn[] key = new DataColumn[1];
        public frm_Tri_Phieukham()
        {
            InitializeComponent();
        }
        public void Load_dgrvPK()
        {
            DataTable dt_bn = new DataTable();

            string sql = @"SELECT 
                        MaPhieuKham,NgayKham,ChanDoan,MaBacSi,KetQua,GiaKham,MaToa,BENHNHAN.MaBenhNhan
                   FROM PHIEUKHAM JOIN BENHNHAN ON PHIEUKHAM.MaBenhNhan=BENHNHAN.MaBenhNhan";

            dt_bn = dbconnection.GetDataTable(sql);
            dataGridView1.DataSource = dt_bn;

            // Đặt khóa chính cho DataTable nếu cần thiết
            key[0] = dt_bn.Columns["MaPhieuKham"];
            dt_bn.PrimaryKey = key;
        }

        private void frm_Tri_Phieukham_Load(object sender, EventArgs e)
        {
            Load_dgrvPK();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txt_maphieukham.Text = row.Cells["maphieukham"].Value.ToString();
                txt_mabenhnhan.Text = row.Cells["mabenhnhan"].Value.ToString();
                dateTimePicker1_ngaykham.Text = row.Cells["ngaykham"].Value.ToString();
                txt_chuandoan.Text = row.Cells["chandoan"].Value.ToString();
                txt_mabacsi_ketoa.Text = row.Cells["mabacsi"].Value.ToString();
                txt_matoa.Text = row.Cells["matoa"].Value.ToString();
                txt_ketqua.Text = row.Cells["ketqua"].Value.ToString();
                txt_giakham.Text = row.Cells["giakham"].Value.ToString();

            }
        }

        public bool kt_primary_key(string makhoa)
        {
            //có rồi:false
            string maPk = txt_maphieukham.Text;
            string chuoi = ("select count(*) from PHIEUKHAM where MaPhieuKham='" + maPk + "'");
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

        private void btn_tiepnhanbenhnhan_Click(object sender, EventArgs e)
        {
            if (kt_primary_key(txt_maphieukham.Text) == true)
            {
                // Chuyển giá trị 'GiaKham' từ TextBox và kiểm tra tính hợp lệ
                float giakham = 0;
                if (!float.TryParse(txt_giakham.Text, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out giakham))
                {
                    MessageBox.Show("Giá khám không hợp lệ. Vui lòng nhập lại (chỉ số hợp lệ với dấu '.' hoặc ',').", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Thoát nếu giá trị không hợp lệ
                }


                string ketqua = txt_ketqua.Text;


                int result = dbconnection.TiepNhanBenhNhan(
                    txt_maphieukham.Text,
                    txt_mabenhnhan.Text,
                    dateTimePicker1_ngaykham.Value,
                    txt_chuandoan.Text,
                    txt_mabacsi_ketoa.Text,
                    ketqua,
                    giakham,
                    txt_matoa.Text);


                if (result > 0)
                {
                    MessageBox.Show("Tiếp nhận bệnh nhân thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Tiếp nhận bệnh nhân không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Làm mới DataGridView (giả sử hàm này sẽ tải lại dữ liệu)
                Load_dgrvPK();
            }
            else
            {
                MessageBox.Show("Trùng khóa chính!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Có thể tải lại dữ liệu một lần nữa sau khi kiểm tra
            Load_dgrvPK();

        }

        private void btn_phanbo_bs_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu mã phiếu khám và mã bác sĩ không trống
            if (!string.IsNullOrEmpty(txt_maphieukham.Text) && !string.IsNullOrEmpty(txt_mabacsi_ketoa.Text))
            {
                // Gọi hàm phân bổ bác sĩ và truyền vào mã phiếu khám và mã bác sĩ
                dbconnection.PhanBoBacSiKham(txt_maphieukham.Text, txt_mabacsi_ketoa.Text);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin mã phiếu khám và mã bác sĩ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Load_dgrvPK();
        }

        private void btn_khamlamsan_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_maphieukham.Text) && !string.IsNullOrEmpty(txt_chuandoan.Text) && !string.IsNullOrEmpty(txt_ketqua.Text))
            {
                // Gọi hàm phân bổ bác sĩ và truyền vào mã phiếu khám và mã bác sĩ
                dbconnection.KhamLamSang(txt_maphieukham.Text, txt_chuandoan.Text, txt_ketqua.Text);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin mã phiếu khám và mã bác sĩ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Load_dgrvPK();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string maPK = txt_maphieukham.Text;
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                int kq = dbconnection.thutucxoaPK(maPK);
                if (kq > 0)
                {
                    MessageBox.Show("Xóa thành công");
                }
                else
                {
                    MessageBox.Show("Xóa không thành công");
                }

                Load_dgrvPK();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMain b = new frmMain();
        }
    }
}
