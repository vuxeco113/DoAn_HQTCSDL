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
    public partial class frm_Nguyen_NhapVien : Form
    {
        public frm_Nguyen_NhapVien()
        {
            InitializeComponent();
        }

        DBConnect dBConnect = new DBConnect();
        DataTable dt_dulieu = new DataTable();

        public void Load_DSNV()
        {
            dt_dulieu = dBConnect.LayTatCaBenhNhanNhapVien();
            dataGridView1.DataSource = dt_dulieu;
        }
        private void btn_NhapVien_Click(object sender, EventArgs e)
        {
            string maNhapVien = txt_MaNhapVien.Text.Trim();
            string maBenhNhan = cmb_MaBN.Text.Trim();
            DateTime ngayNhapVien = dateTimePicker1.Value;
            string maBacSi = cmb_MaBacSi.Text.Trim();
            string maPhong = txt_MaPhong.Text.Trim();
            string lyDoNhapVien = txt_LyDo.Text.Trim();

            try
            {
                bool success = dBConnect.NhapVien(maNhapVien, maBenhNhan, ngayNhapVien, maBacSi, maPhong, lyDoNhapVien);
                if (success)
                {
                    MessageBox.Show("Nhập viện thành công.");
                    Load_DSNV();
                }
                else
                {
                    MessageBox.Show("Nhập viện thất bại.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        public void Load_BN()
        {
            string sql = "select * from BENHNHAN";
            dt_dulieu = dBConnect.GetDataTable(sql);

            cmb_MaBN.DataSource = dt_dulieu;
            cmb_MaBN.DisplayMember = "MaBenhNhan";
            cmb_MaBN.ValueMember = "MaBenhNhan";

        }
        public void Load_BS()
        {
            string sql = "select * from BACSI";
            dt_dulieu = dBConnect.GetDataTable(sql);

            cmb_MaBacSi.DataSource = dt_dulieu;
            cmb_MaBacSi.DisplayMember = "MaBacSi";
            cmb_MaBacSi.ValueMember = "MaBacSi";

        }
        private void frm_Nguyen_NhapVien_Load(object sender, EventArgs e)
        {
            Load_DSNV();
            Load_BN();
            Load_BS();
        }
    }
}
