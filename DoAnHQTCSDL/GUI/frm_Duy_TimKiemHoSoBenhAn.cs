using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utility;

namespace GUI
{
    public partial class frm_Duy_TimKiemHoSoBenhAn : Form
    {
        private HO_SO_BENH_AN_BLL hoSoBenhAnBLL;

        private DBconnection dbConnection;
        public frm_Duy_TimKiemHoSoBenhAn()
        {
            InitializeComponent();
            hoSoBenhAnBLL = new HO_SO_BENH_AN_BLL();
        }

        private void frm_Duy_TimKiemHoSoBenhAn_Load(object sender, EventArgs e)
        {
            LoadDataHOSOBENHAN();
            LoadTongHoSo();
            cbTimKiemTheo.SelectedIndex = 0; // Mặc định chọn "Tất cả"
            SetControlsEnabled(false); // Vô hiệu hóa tất cả các điều khiển nhập ban đầu
        }

        private void LoadDataHOSOBENHAN()
        {
            // Thêm các mục vào ComboBox
            cbTimKiemTheo.Items.Clear();
            cbTimKiemTheo.Items.Add("Tất cả");
            cbTimKiemTheo.Items.Add("Mã hồ sơ");
            cbTimKiemTheo.Items.Add("Mã bệnh nhân");
            cbTimKiemTheo.Items.Add("Mã bác sĩ");
            cbTimKiemTheo.Items.Add("Ngày lập");
            cbTimKiemTheo.Items.Add("Khoảng thời gian");
            
            try
            {
                dgvDuLieuTimKiem.DataSource = hoSoBenhAnBLL.GetHoSoBenhAn();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu hồ sơ bệnh án: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadTongHoSo()
        {
            try
            {
                // Gọi phương thức GetTotalHoSoBenhAn từ lớp BLL
                int tong = hoSoBenhAnBLL.GetTotalHoSoBenhAn();
                lbTong.Text = tong.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy tổng số hồ sơ bệnh án: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbTimKiemTheo_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetControlsEnabled(false); // Vô hiệu hóa tất cả các điều khiển nhập
            switch (cbTimKiemTheo.SelectedItem.ToString())
            {
                case "Mã hồ sơ":
                    txtMaHoSo.Enabled = true; // Kích hoạt textbox cho mã hồ sơ
                    break;
                case "Mã bệnh nhân":
                    txtMaBenhNhan.Enabled = true; // Kích hoạt textbox cho mã bệnh nhân
                    break;
                case "Mã bác sĩ":
                    txtMaBacSi.Enabled = true; // Kích hoạt textbox cho mã bác sĩ
                    break;
                case "Ngày lập":
                    dtpNgayLapHS.Enabled = true; // Kích hoạt DateTimePicker cho ngày lập
                    break;
                case "Khoảng thời gian":
                    dtpTuNgay.Enabled = true; // Kích hoạt DateTimePicker cho ngày bắt đầu
                    dtpDenNgay.Enabled = true; // Kích hoạt DateTimePicker cho ngày kết thúc
                    break;
                case "Tất cả":
                    break; // Không cần kích hoạt điều khiển nào khi chọn "Tất cả"
            }
        }

        private void SetControlsEnabled(bool enabled)
        {
            // Vô hiệu hóa hoặc kích hoạt các điều khiển nhập
            txtMaHoSo.Enabled = enabled;
            txtMaBenhNhan.Enabled = enabled;
            txtMaBacSi.Enabled = enabled;
            dtpNgayLapHS.Enabled = enabled;
            dtpTuNgay.Enabled = enabled;
            dtpDenNgay.Enabled = enabled;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable result; // Biến lưu trữ kết quả tìm kiếm
                switch (cbTimKiemTheo.SelectedItem.ToString())
                {
                    case "Tất cả":
                        result = hoSoBenhAnBLL.GetHoSoBenhAn(); // Lấy tất cả hồ sơ bệnh án                        
                        break;
                    case "Mã hồ sơ":
                        result = hoSoBenhAnBLL.GetHoSoByMaHoSo(txtMaHoSo.Text.Trim()); // Tìm theo mã hồ sơ                        
                        break;
                    case "Mã bệnh nhân":
                        result = hoSoBenhAnBLL.GetHoSoBenhAnByMaBenhNhan(txtMaBenhNhan.Text.Trim()); // Tìm theo mã bệnh nhân                      
                        break;
                    case "Mã bác sĩ":
                        result = hoSoBenhAnBLL.GetHoSoBenhAnByMaBacSi(txtMaBacSi.Text.Trim()); // Tìm theo mã bác sĩ                      
                        break;
                    case "Ngày lập":
                        result = hoSoBenhAnBLL.GetHoSoBenhAnByNgayLap(dtpNgayLapHS.Value.Date); // Tìm theo ngày lập                      
                        break;
                    case "Khoảng thời gian":
                        result = hoSoBenhAnBLL.GetHoSoBenhAnByKhoangThoiGian(dtpTuNgay.Value.Date, dtpDenNgay.Value.Date); // Tìm theo khoảng thời gian                      
                        break;
                    default:
                        result = null; // Không có tiêu chí tìm kiếm hợp lệ
                        break;
                }

                // Kiểm tra và hiển thị kết quả
                if (result != null && result.Rows.Count > 0)
                {
                    dgvDuLieuTimKiem.DataSource = result; // Hiển thị kết quả vào DataGridView
                    lbTong.Text = result.Rows.Count.ToString(); // Hiển thị tổng số hồ sơ tìm thấy
                }
                else
                {                    
                    // Tạo một DataTable rỗng để giữ lại tiêu đề cột
                    DataTable emptyTable = new DataTable();
                    emptyTable.Columns.Add("MaHoSo", typeof(string));
                    emptyTable.Columns.Add("MaBenhNhan", typeof(string));
                    emptyTable.Columns.Add("NgayLapHoSo", typeof(DateTime));
                    emptyTable.Columns.Add("MaBacSi", typeof(string));
                    emptyTable.Columns.Add("NoiDungHoSo", typeof(string));

                    dgvDuLieuTimKiem.DataSource = emptyTable; // Gán DataTable rỗng vào DataGridView
                    lbTong.Text = "0"; // Tổng số hồ sơ bằng 0
                    MessageBox.Show("Không tìm thấy hồ sơ nào theo nội dung tiêu chí bạn đã nhập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tìm kiếm: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            cbTimKiemTheo.SelectedIndex = 0; // Mặc định chọn "Tất cả"
            SetControlsEnabled(false); // Vô hiệu hóa tất cả các điều khiển nhập ban đầu
            txtMaHoSo.Text = "";
            txtMaBenhNhan.Text = "";
            txtMaBacSi.Text = "";
            dtpNgayLapHS.Value = DateTime.Now;
            dtpTuNgay.Value = DateTime.Now;
            dtpDenNgay.Value = DateTime.Now;
            // Tạo một DataTable rỗng để giữ lại tiêu đề cột
            DataTable emptyTable = new DataTable();
            emptyTable.Columns.Add("MaPhieuKham", typeof(string));
            emptyTable.Columns.Add("TenBenhNhan", typeof(string));
            emptyTable.Columns.Add("TenBacSi", typeof(string));
            emptyTable.Columns.Add("NgayKham", typeof(DateTime));
            
            dgvThongTinCT.DataSource = emptyTable; // Gán DataTable rỗng vào DataGridView       
            LoadDataHOSOBENHAN();
            LoadTongHoSo();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close(); // Đóng form
            }
        }

        private void dgvDuLieuTimKiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem có phải hàng hợp lệ không
            if (e.RowIndex >= 0)
            {
                // Lấy Mã Bệnh Nhân từ cột tương ứng trong dgvDuLieuTimKiem
                string maBenhNhan = dgvDuLieuTimKiem.Rows[e.RowIndex].Cells["MaBenhNhan"].Value.ToString();

                // Gọi hàm load dữ liệu chi tiết
                LoadThongTinChiTiet(maBenhNhan);
            }
        }

        private void LoadThongTinChiTiet(string maBenhNhan)
        {
            try
            {
                // Gọi phương thức từ BLL để lấy dữ liệu chi tiết
                DataTable dt = hoSoBenhAnBLL.GetThongTinChiTietByMaBenhNhan(maBenhNhan);

                // Hiển thị dữ liệu trong dgvThongTinTT
                dgvThongTinCT.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy thông tin chi tiết: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
