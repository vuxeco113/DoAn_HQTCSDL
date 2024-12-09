using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UlinityTool;
using Utility;
namespace GUI
{
    public partial class frm_Nguyen_LichSuNhapVien : Form
    {
        public frm_Nguyen_LichSuNhapVien()
        {
            InitializeComponent();
        }
        DBconnection dbc = new DBconnection();
        DBConnect dBConnect = new DBConnect();
        DataTable dt_dulieu = new DataTable();
        private void frm_Nguyen_LichSuNhapVien_Load(object sender, EventArgs e)
        {
            Load_BN();
        }
        public void Load_BN()
        {
            string sql = "select * from BENHNHAN";
            dt_dulieu = dbc.GetDataTable(sql);

            cmb_MaBenhNhan.DataSource = dt_dulieu;
            cmb_MaBenhNhan.DisplayMember = "MaBenhNhan";
            cmb_MaBenhNhan.ValueMember = "MaBenhNhan";

        }
        private void btn_KiemTra_Click(object sender, EventArgs e)
        {
            string maBenhNhan = cmb_MaBenhNhan.Text.Trim();

            try
            {
                DataTable dt_dulieu = dBConnect.LayLichSuNhapVien(maBenhNhan);

                if (dt_dulieu.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dt_dulieu;
                }
                else
                {
                    MessageBox.Show("Không có lịch sử nhập viện cho bệnh nhân này.");
                    dataGridView1.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
 
    }
}
