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
    public partial class frm_Tri_xemchitiettoathuoc : Form
    {
        DataTable dt_bn = new DataTable();
        DBconnection dbconnection = new DBconnection();
        DataColumn[] key = new DataColumn[1];
        public frm_Tri_xemchitiettoathuoc()
        {
            InitializeComponent();
        }
        public void loadcboToa()
        {
            string sql = "select * from TOATHUOC";
            DataTable dt_denkhoa = new DataTable();
            dt_denkhoa = dbconnection.GetDataTable(sql);



            cbo_matoathuoc.DataSource = dt_denkhoa;
            cbo_matoathuoc.DisplayMember = "MATOA";
            cbo_matoathuoc.ValueMember = "MATOA";
        }

        private void frm_Tri_xemchitiettoathuoc_Load(object sender, EventArgs e)
        {
            loadcboToa();
        }

        private void btn_xemchitiet_Click(object sender, EventArgs e)
        {
            string maToa = cbo_matoathuoc.Text;

            if (!string.IsNullOrEmpty(maToa))
            {

                DataTable chiTietToaThuoc = dbconnection.GetChiTietToaThuoc(maToa);

                int tongSoThuoc = dbconnection.GetTongSoThuocTrongToa(maToa);


                txt_sum.Text = tongSoThuoc.ToString();

                if (chiTietToaThuoc != null && chiTietToaThuoc.Rows.Count > 0)
                {

                    dataGridView1.DataSource = chiTietToaThuoc;
                }
                else
                {

                    MessageBox.Show("Không tìm thấy chi tiết toa thuốc cho mã toa này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập mã toa thuốc.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
