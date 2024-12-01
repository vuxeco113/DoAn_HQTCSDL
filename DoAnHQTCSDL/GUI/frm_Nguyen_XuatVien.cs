using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UlinityTool;

namespace GUI
{
    public partial class frm_Nguyen_XuatVien : Form
    {
        public frm_Nguyen_XuatVien()
        {
            InitializeComponent();
        }

        DBConnect dBConnect = new DBConnect();
        DataTable dt_dulieu = new DataTable();
        public void Load_DSXV()
        {
            dt_dulieu = dBConnect.LayTatCaBenhNhanXuatVien();
            dataGridView1.DataSource = dt_dulieu;
        }
        public void Load_MaBenhNhan()
        {
            List<string> maBenhNhans = GetMaBenhNhan();
            cmb_MaBenhNhan.DataSource = maBenhNhans;
        }

        private void cmbMaBenhNhan_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maBenhNhan = cmb_MaBenhNhan.SelectedItem.ToString();

            List<string> maNhapViens = GetMaNhapVien(maBenhNhan);
            cmb_MaNhapVien.DataSource = maNhapViens;
        }
        public void Load_BS()
        {
            string sql = "select * from BACSI";
            dt_dulieu = dBConnect.GetDataTable(sql);

            cmb_MaBacSi.DataSource = dt_dulieu;
            cmb_MaBacSi.DisplayMember = "MaBacSi";
            cmb_MaBacSi.ValueMember = "MaBacSi";

        }
        private void frm_Nguyen_XuatVien_Load(object sender, EventArgs e)
        {
            Load_DSXV();
        }
        public List<string> GetMaBenhNhan()
        {
            List<string> maBenhNhans = new List<string>();
            string query = "SELECT MaBenhNhan FROM BenhNhan";
            try
            {
                DataTable dt = dBConnect.GetDataTable(query);

                foreach (DataRow row in dt.Rows)
                {
                    maBenhNhans.Add(row["MaBenhNhan"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }

            return maBenhNhans;
        }

        // Lấy danh sách mã nhập viện theo mã bệnh nhân
        public List<string> GetMaNhapVien(string maBenhNhan)
        {
            List<string> maNhapViens = new List<string>();
            string query = "SELECT dbo.FUNC_HAM_LAY_MA_NHAP_VIEN(@MaBenhNhan)";

            try
            {
                SqlParameter[] parameters = {
                new SqlParameter("@MaBenhNhan", SqlDbType.VarChar) { Value = maBenhNhan }
            };

                object result = dBConnect.ExecuteScalar(query, parameters);

                if (result != DBNull.Value)
                {
                    maNhapViens.Add(result.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }

            return maNhapViens;
        }

        private void btn_XuatVien_Click(object sender, EventArgs e)
        {
            string maRaVien = txt_MaRaVien.Text.Trim();
            string maNhapVien = cmb_MaNhapVien.Text.Trim();
            string maBenhNhan = cmb_MaBenhNhan.Text.Trim();
            string maBacSi = cmb_MaBacSi.Text.Trim();
            DateTime ngayRaVien = dateTimePicker1.Value;
            string tinhTrangRaVien = txt_TinhTrang.Text.Trim();

            try
            {
                int soNgayNamVien;

                bool success = dBConnect.XuatVien(maRaVien, maNhapVien, maBenhNhan, maBacSi, ngayRaVien, tinhTrangRaVien, out soNgayNamVien);

                if (success)
                {
                    MessageBox.Show($"Xuất viện thành công! Số ngày nằm viện: {soNgayNamVien}");
                    Load_DSXV();
                }
                else
                {
                    MessageBox.Show("Xuất viện thất bại.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
