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

namespace GUI
{
    public partial class frm_Nguyen_LichSuNhapVien : Form
    {
        public frm_Nguyen_LichSuNhapVien()
        {
            InitializeComponent();
        }

        DBConnect dBConnect = new DBConnect();
        DataTable dt_dulieu = new DataTable();
        private void frm_Nguyen_LichSuNhapVien_Load(object sender, EventArgs e)
        {
            Load_BN();
        }
        public void Load_BN()
        {
            string sql = "select * from BENHNHAN";
            dt_dulieu = dBConnect.GetDataTable(sql);

            cmb_MaBenhNhan.DataSource = dt_dulieu;
            cmb_MaBenhNhan.DisplayMember = "MaBenhNhan";
            cmb_MaBenhNhan.ValueMember = "MaBenhNhan";

        }
        private void btn_KiemTra_Click(object sender, EventArgs e)
        {
            string maBenhNhan = cmb_MaBenhNhan.Text.Trim();

            try
            {
                dt_dulieu = dBConnect.LayLichSuNhapVien(maBenhNhan);
                dataGridView1.DataSource = dt_dulieu;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void cmb_MaBenhNhan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
