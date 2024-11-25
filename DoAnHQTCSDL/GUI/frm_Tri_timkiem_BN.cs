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
    public partial class frm_Tri_timkiem_BN : Form
    {
        DBconnection dbconnection = new DBconnection();
        DataTable dt_bn = new DataTable();
        DataColumn[] key = new DataColumn[1];
        public frm_Tri_timkiem_BN()
        {
            InitializeComponent();
        }
        public void loadcboBS()
        {
            string sql = "select * from BACSI";
            DataTable dt_bs = new DataTable();
            dt_bs = dbconnection.GetDataTable(sql);

            cbo_mabs.DataSource = dt_bs;
            cbo_mabs.DisplayMember = "MaBacSi";
            cbo_mabs.ValueMember = "MaBacSi";


        }
        public void loadcboBN()
        {
            string sql = "select * from BENHNHAN";
            DataTable dt_bs = new DataTable();
            dt_bs = dbconnection.GetDataTable(sql);

            cbo_maBN.DataSource = dt_bs;
            cbo_maBN.DisplayMember = "MaBenhNhan";
            cbo_maBN.ValueMember = "MaBenhNhan";


        }

        private void frm_Tri_timkiem_BN_Load(object sender, EventArgs e)
        {
            loadcboBN();
            loadcboBS();
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            string maBacSi = cbo_mabs.Text.Trim();
            string MaBenhNhan = cbo_maBN.Text.Trim();

            if (rdo_mabs.Checked)
            {
                if (!string.IsNullOrEmpty(maBacSi))
                {
                    DataTable dt = dbconnection.GetDanhSachBenhNhanDieuTri(maBacSi);

                    if (dt != null && dt.Rows.Count > 0)
                    {
                        // Gán dữ liệu vào DataGridView
                        dataGridView1.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy bệnh nhân nào thuộc bác sĩ này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập mã bác sĩ.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (rdo_mabn.Checked)
            {
                if (!string.IsNullOrEmpty(MaBenhNhan))
                {
                    DataTable dt = dbconnection.GetDanhSachBenhNhan(MaBenhNhan);

                    if (dt != null && dt.Rows.Count > 0)
                    {
                        // Gán dữ liệu vào DataGridView
                        dataGridView1.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy bệnh nhân  này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập mã bệnh nhân.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
