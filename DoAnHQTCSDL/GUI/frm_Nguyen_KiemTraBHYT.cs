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
    public partial class frm_Nguyen_KiemTraBHYT : Form
    {
        public frm_Nguyen_KiemTraBHYT()
        {
            InitializeComponent();
        }

        DBConnect dBConnect = new DBConnect();
        DataTable dt_dulieu = new DataTable();
        private void frm_Nguyen_KiemTraBHYT_Load(object sender, EventArgs e)
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
                bool BaoHiem = dBConnect.KiemTraBaoHiem(maBenhNhan);

                MessageBox.Show(BaoHiem ? "Bệnh nhân có bảo hiểm." : "Bệnh nhân không có bảo hiểm.");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btn_Tinh_Click(object sender, EventArgs e)
        {
            try
            {
                int tong = dBConnect.TongBenhNhanDangDieuTri();
                label3.Text = $"Tổng số bệnh nhân đang điều trị: {tong}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}
