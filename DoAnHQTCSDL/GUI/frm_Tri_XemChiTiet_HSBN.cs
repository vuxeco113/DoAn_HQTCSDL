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
    public partial class frm_Tri_XemChiTiet_HSBN : Form
    {
        DBconnection dbconnection = new DBconnection();
        DataTable dt_bn = new DataTable();
        DataColumn[] key = new DataColumn[1];
        public frm_Tri_XemChiTiet_HSBN()
        {
            InitializeComponent();
        }

        private void btn_xemchitiet_Click(object sender, EventArgs e)
        {
            string maBN = cbo_maBN.Text.Trim();

            if (!string.IsNullOrEmpty(maBN))
            {

                DataTable dtLichSuKham = dbconnection.Getlichsukhambenh(maBN);


                DataTable dtThongTinBN = dbconnection.GetthongtinBN(maBN);

                if (dtLichSuKham != null && dtLichSuKham.Rows.Count > 0)
                {

                    dataGridView1.DataSource = dtLichSuKham;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy lịch sử khám bệnh cho bệnh nhân này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                if (dtThongTinBN != null && dtThongTinBN.Rows.Count > 0)
                {

                    DataRow row = dtThongTinBN.Rows[0];
                    txt_HT2.Text = row["TenBenhNhan"].ToString();
                    cbo_gioitinh.Text = row["GioiTinh"].ToString();
                    dateTimePicker1_ngaysinh.Text = row["NgaySinh"].ToString();
                    txt_dc.Text = row["DiaChi"].ToString();
                    txt_sdt.Text = row["SoDienThoai"].ToString();
                    txt_BHYT2.Text = row["MaBHYT"].ToString();
                    txt_tuoi.Text = row["Tuoi"].ToString();

                }
                else
                {
                    MessageBox.Show("Không tìm thấy thông tin bệnh nhân.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập mã bệnh nhân.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            try
            {
                
                if (string.IsNullOrWhiteSpace(txt_tuoi.Text))
                {
                    
                    if (!string.IsNullOrWhiteSpace(dateTimePicker1_ngaysinh.Text))
                    {                  
                        DateTime ngaySinh = DateTime.Parse(dateTimePicker1_ngaysinh.Text);
                        int tuoi = dbconnection.TinhTuoi(ngaySinh);                     
                        txt_tuoi.Text = tuoi.ToString();
                    }
                    else
                    {

                        MessageBox.Show("Vui lòng nhập ngày sinh trước khi tính tuổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Ô tuổi đã có giá trị, không cần tính lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Ngày sinh không hợp lệ. Vui lòng nhập đúng định dạng (yyyy-MM-dd).", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void frm_Tri_XemChiTiet_HSBN_Load(object sender, EventArgs e)
        {
            loadcboBN();
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {

        }
    }
}
