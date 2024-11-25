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
    public partial class frm_Tri_Thanhtoan : Form
    {
        DataTable dt_bn = new DataTable();
        DBconnection dbconnection = new DBconnection();
        DataColumn[] key = new DataColumn[1];
        public frm_Tri_Thanhtoan()
        {
            InitializeComponent();
        }
        public void loadcboPK()
        {
            string sql = "select * from PHIEUKHAM";
            DataTable dt_pk = new DataTable();
            dt_pk = dbconnection.GetDataTable(sql);

            cbo_MP.DataSource = dt_pk;
            cbo_MP.DisplayMember = "MaPhieuKham";
            cbo_MP.ValueMember = "MaPhieuKham";


        }
        public void Load_dgrvTT()
        {
            DataTable dt_bn = new DataTable();

            string sql = @"SELECT* FROM THANHTOAN ";

            dt_bn = dbconnection.GetDataTable(sql);
            dataGridView1.DataSource = dt_bn;

            // Đặt khóa chính cho DataTable nếu cần thiết
            key[0] = dt_bn.Columns["Mathanhtoan"];
            dt_bn.PrimaryKey = key;
        }

        private void frm_Tri_Thanhtoan_Load(object sender, EventArgs e)
        {
            loadcboPK();
            Load_dgrvTT();
        }
        public bool kt_primary_key(string makhoa)
        {
            //có rồi:false
            string maPk = txt_mathanhtoan.Text;
            string chuoi = ("select count(*) from THANHTOAN where Mathanhtoan='" + maPk + "'");
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

        private void btn_thanhtoan_Click(object sender, EventArgs e)
        {
            string Mathanhtoan = txt_mathanhtoan.Text;
            string maPhieuKham = cbo_MP.Text;
            float soTien;
            if (kt_primary_key(txt_mathanhtoan.Text) == true)
            {

                if (string.IsNullOrEmpty(maPhieuKham) || !float.TryParse(txt_tien.Text, out soTien))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                bool result = dbconnection.ThanhToanThuTuc(Mathanhtoan, maPhieuKham, soTien);

                if (result)
                {
                    MessageBox.Show("Thanh toán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Load_dgrvTT();
                }
                else
                {
                    MessageBox.Show("Thanh toán thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Trùng khóa chính!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Load_dgrvTT();
        }
    }
}
