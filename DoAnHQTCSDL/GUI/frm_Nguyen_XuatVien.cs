using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using UlinityTool;
using Utility;

namespace GUI
{
    public partial class frm_Nguyen_XuatVien : Form
    {
        public frm_Nguyen_XuatVien()
        {
            InitializeComponent();
        }

        private readonly DBconnection dbc = new DBconnection();
        private readonly DBConnect dBConnect = new DBConnect();

        private DataTable dt_dulieu = new DataTable();

        private void frm_Nguyen_XuatVien_Load(object sender, EventArgs e)
        {
            Load_DSXV();
            Load_MaBenhNhan();
        }

        public void Load_DSXV()
        {
            string query = "SELECT * FROM RAVIEN";
            try
            {
                dt_dulieu = dbc.GetDataTable(query);
                if (dt_dulieu != null && dt_dulieu.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dt_dulieu;
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu để hiển thị.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách xuất viện: " + ex.Message);
            }
        }

        public void Load_MaBenhNhan()
        {
            List<string> maBenhNhans = GetMaBenhNhan();
            if (maBenhNhans != null && maBenhNhans.Count > 0)
            {
                cmb_MaBenhNhan.DataSource = maBenhNhans;
            }
            else
            {
                MessageBox.Show("Không có mã bệnh nhân nào để hiển thị.");
            }
        }

        private void cmb_MaBenhNhan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_MaBenhNhan.SelectedIndex >= 0) // Kiểm tra nếu có phần tử được chọn
            {
                string maBenhNhan = cmb_MaBenhNhan.SelectedItem?.ToString();
                if (!string.IsNullOrEmpty(maBenhNhan))
                {
                    string maNhapVien = GetMaNhapVien(maBenhNhan);
                    if (!string.IsNullOrEmpty(maNhapVien))
                    {
                        List<string> maNhapViens = new List<string> { maNhapVien };
                        cmb_MaNhapVien.DataSource = maNhapViens;
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy mã nhập viện cho bệnh nhân này.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một mã bệnh nhân hợp lệ.");
            }
        }

        public List<string> GetMaBenhNhan()
        {
            List<string> maBenhNhans = new List<string>();
            string query = "SELECT MaBenhNhan FROM BENHNHAN";
            try
            {
                DataTable dt = dbc.GetDataTable(query);
                if (dt != null && dt.Rows.Count > 0 && dt.Columns.Contains("MaBenhNhan"))
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        maBenhNhans.Add(row["MaBenhNhan"].ToString());
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy dữ liệu mã bệnh nhân.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy mã bệnh nhân: " + ex.Message);
            }
            return maBenhNhans;
        }

        public string GetMaNhapVien(string maBenhNhan)
        {
            string maNhapVien = string.Empty;
            string query = "SELECT dbo.FUNC_LAY_MA_NHAP_VIEN(@MaBenhNhan) AS MaNhapVien";
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>
                {
                    new SqlParameter("@MaBenhNhan", SqlDbType.Char) { Value = maBenhNhan }
                };

                DataTable dt = dbc.GetDataTable(query, parameters);
                if (dt != null && dt.Rows.Count > 0 && dt.Columns.Contains("MaNhapVien"))
                {
                    maNhapVien = dt.Rows[0]["MaNhapVien"].ToString();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy dữ liệu mã nhập viện.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy mã nhập viện: " + ex.Message);
            }

            return maNhapVien;
        }

        private void btn_XuatVien_Click(object sender, EventArgs e)
        {
            string maRaVien = txt_MaRaVien.Text.Trim();
            string maNhapVien = cmb_MaNhapVien.Text.Trim();
            string maBenhNhan = cmb_MaBenhNhan.Text.Trim();
            DateTime ngayRaVien = dateTimePicker1.Value;
            string tinhTrangRaVien = txt_TinhTrang.Text.Trim();

            if (string.IsNullOrEmpty(maRaVien) || string.IsNullOrEmpty(maNhapVien) || string.IsNullOrEmpty(maBenhNhan))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                return;
            }

            try
            {
                int soNgayNamVien;
                bool success = dBConnect.XuatVien(maRaVien, maNhapVien, maBenhNhan, ngayRaVien, tinhTrangRaVien, out soNgayNamVien);

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