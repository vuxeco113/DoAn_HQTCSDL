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
    public partial class frm_Tri_timkiemphieukham : Form
    {
        DataTable dt_bn = new DataTable();
        DBconnection dbconnection = new DBconnection();
        DataColumn[] key = new DataColumn[1];
        public frm_Tri_timkiemphieukham()
        {
            InitializeComponent();
        }
        public void loadcboPK()
        {
            string sql = "select * from PHIEUKHAM";
            DataTable dt_pk = new DataTable();
            dt_pk = dbconnection.GetDataTable(sql);

            cbo_maphieukham.DataSource = dt_pk;
            cbo_maphieukham.DisplayMember = "MaPhieuKham";
            cbo_maphieukham.ValueMember = "MaPhieuKham";


        }

        private void frm_Tri_timkiemphieukham_Load(object sender, EventArgs e)
        {
            loadcboPK();
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            DataTable dt = null;

            // Kiểm tra radio button được chọn
            if (rdo_maPK.Checked) // Tìm theo mã phiếu khám
            {
                string maPK = cbo_maphieukham.Text.Trim();

                if (!string.IsNullOrEmpty(maPK))
                {
                    dt = dbconnection.GetDanhSachphieukham(maPK);

                    if (dt != null && dt.Rows.Count > 0)
                    {
                        // Gán dữ liệu vào DataGridView
                        dataGridView1.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy phiếu khám nào với mã này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập mã phiếu khám.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (rdo_ngaykham.Checked) // Tìm theo ngày
            {
                DateTime NgayKham = dateTimePicker1_ngaykham.Value; // Lấy giá trị từ DateTimePicker
                dt = dbconnection.GetDanhSachphieukhamTheoNgay(NgayKham);

                if (dt != null && dt.Rows.Count > 0)
                {
                    // Gán dữ liệu vào DataGridView
                    dataGridView1.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy phiếu khám nào vào ngày này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn phương thức tìm kiếm (Mã phiếu khám hoặc Ngày).", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
