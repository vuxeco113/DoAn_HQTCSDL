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
    public partial class frm_Tri_timkiem_toathuoc : Form
    {
        DataTable dt_bn = new DataTable();
        DBconnection dbconnection = new DBconnection();
        DataColumn[] key = new DataColumn[1];
        public frm_Tri_timkiem_toathuoc()
        {
            InitializeComponent();
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

        public void loadcboToaThuoc()
        {
            string sql = "select * from TOATHUOC";
            DataTable dt_denkhoa = new DataTable();
            dt_denkhoa = dbconnection.GetDataTable(sql);



            cbo_toathuoc.DataSource = dt_denkhoa;
            cbo_toathuoc.DisplayMember = "MaToa";
            cbo_toathuoc.ValueMember = "MaToa";
        }

        private void frm_Tri_timkiem_toathuoc_Load(object sender, EventArgs e)
        {
            loadcboBN();
            loadcboToaThuoc();
        }

        private void btn_tk_Click(object sender, EventArgs e)
        {
            string maBenhNhan = cbo_maBN.Text;
            string MaToa = cbo_toathuoc.Text;
            if (rdo_maBN.Checked)
            {
                if (!string.IsNullOrEmpty(maBenhNhan))
                {
                    DataTable dt = dbconnection.GetToaThuocTheoBenhNhan(maBenhNhan);

                    if (dt != null && dt.Rows.Count > 0)
                    {
                        // Gán dữ liệu vào DataGridView
                        dataGridView1.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy toa thuốc nào.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập mã bệnh nhân.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (rdo_matoa.Checked)
            {
                if (!string.IsNullOrEmpty(MaToa))
                {
                    DataTable dt = dbconnection.GetToaThuocTheoToathuoc(MaToa);

                    if (dt != null && dt.Rows.Count > 0)
                    {
                        // Gán dữ liệu vào DataGridView
                        dataGridView1.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy toa thuốc nào.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập mã toa thuốc.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
