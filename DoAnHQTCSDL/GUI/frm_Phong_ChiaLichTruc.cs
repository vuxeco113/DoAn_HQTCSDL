using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace GUI
{
    public partial class frm_Phong_LichTruc : Form
    {
        CA_TRUC_BLL catruc = new CA_TRUC_BLL();
        BAC_SI_BLL bacsi = new BAC_SI_BLL();
        LICH_TRUC_BLL lichTrucBLL = new LICH_TRUC_BLL();
        public frm_Phong_LichTruc()
        {
            InitializeComponent();
            LoadCaTruc();
            LoadBacSi();
            //txtMaLichTruc.Text = SinhMaLichTruc();
            Loaddgv();
            dgvLichTruc1.CellClick += new DataGridViewCellEventHandler(dgvView_CellClick);
        }
        public void LoadCaTruc()
        {
            cboCaTruc.DataSource = catruc.get_all();
            cboCaTruc.DisplayMember = "ThoiGianCa";
            cboCaTruc.ValueMember = "MaCaTruc";
        }
        public void LoadBacSi()
        {
            cboBacsi.Items.Clear();
            cboBacsi.DataSource = bacsi.GetAllBacSi();
            cboBacsi.DisplayMember = "HoTen";
            cboBacsi.ValueMember = "MaBacSi";
        }

        public void Loaddgv()
        {
            LICH_TRUC_BLL bll = new LICH_TRUC_BLL();
            DataTable dt = bll.GetAllLichTruc();
            dgvLichTruc1.DataSource = dt;

            // Thiết lập tên cột hiển thị (nếu cần)
            dgvLichTruc1.Columns["MaBacSi"].HeaderText = "Mã Bác Sĩ";
            dgvLichTruc1.Columns["TenBacSi"].HeaderText = "Tên Bác Sĩ";
            dgvLichTruc1.Columns["NgayTruc"].HeaderText = "Ngày Trực";
            dgvLichTruc1.Columns["MaCaTruc"].HeaderText = "Mã Ca Trực";
            dgvLichTruc1.Columns["ThoiGianCa"].HeaderText = "Thời Gian Ca";
            dgvLichTruc1.Columns["Khoa"].HeaderText = "Khoa";
            dgvLichTruc1.Columns["MaCaTruc"].Visible = false; 
            dgvLichTruc1.Refresh();

        }

        private void btnThemLichTruc_Click(object sender, EventArgs e)
        {
            try
            {
                LICH_TRUC_DTO lichTruc = new LICH_TRUC_DTO
                {
                    MaBacSi = cboBacsi.SelectedValue.ToString(),
                    NgayTruc = dtpNgayTruc.Value,
                    MaCaTruc = cboCaTruc.SelectedValue.ToString()
                };

                LICH_TRUC_BLL bll = new LICH_TRUC_BLL();
                bool isSaved = bll.AddLichTruc(lichTruc);

                if (isSaved)
                {
                    MessageBox.Show("Thêm thành công!");
                    Loaddgv();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnXoaLichTruc_Click(object sender, EventArgs e)
        {
            if (dgvLichTruc1.CurrentRow != null)
            {
                string maBacSi = dgvLichTruc1.CurrentRow.Cells["MaBacSi"].Value.ToString();
                DateTime ngayTruc = DateTime.Parse(dgvLichTruc1.CurrentRow.Cells["NgayTruc"].Value.ToString());
                string maCaTruc = dgvLichTruc1.CurrentRow.Cells["MaCaTruc"].Value.ToString();

                try
                {
                    LICH_TRUC_BLL bll = new LICH_TRUC_BLL();
                    bool isDeleted = bll.DeleteLichTruc(maBacSi, ngayTruc, maCaTruc);

                    if (isDeleted)
                    {
                        MessageBox.Show("Xóa thành công!");
                        Loaddgv();
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }

        private void btnDoiLichTruc_Click(object sender, EventArgs e)
        {
            if (dgvLichTruc1.CurrentRow != null)
            {
                try
                {
                    LICH_TRUC_DTO lichTruc = new LICH_TRUC_DTO
                    {
                        MaBacSi = cboBacsi.SelectedValue.ToString(),
                        NgayTruc = dtpNgayTruc.Value,
                        MaCaTruc = cboCaTruc.SelectedValue.ToString()
                    };

                    LICH_TRUC_BLL bll = new LICH_TRUC_BLL();
                    bool isUpdated = bll.UpdateLichTruc(lichTruc);

                    if (isUpdated)
                    {
                        MessageBox.Show("Sửa thành công!");
                        Loaddgv();
                    }
                    else
                    {
                        MessageBox.Show("Sửa thất bại!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }

        private void dgvView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvLichTruc1.Rows.Count - 1) // Kiểm tra hàng hợp lệ và không phải hàng trống cuối cùng
            {
                DataGridViewRow row = dgvLichTruc1.Rows[e.RowIndex];
                // Kiểm tra và chuyển đổi dữ liệu an toàn
                cboBacsi.SelectedValue = row.Cells["MaBacSi"].Value.ToString();
                dtpNgayTruc.Value = Convert.ToDateTime(row.Cells["NgayTruc"].Value);
                cboCaTruc.SelectedValue = row.Cells["MaCaTruc"].Value.ToString(); // Sử dụng SelectedValue để phù hợp với cột giá trị
                txtKhoa.Text = row.Cells["Khoa"].Value.ToString();


            }
        }

        private void cboCaTruc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_loctheoten_Click(object sender, EventArgs e)
        {
            try
            {
                LICH_TRUC_BLL bll = new LICH_TRUC_BLL();
                string selectedName = cboBacsi.SelectedValue.ToString(); // Lấy giá trị được chọn từ ComboBox
                DataTable dt = bll.FilterByName(selectedName);
                dgvLichTruc1.DataSource = dt;

                // Cập nhật tiêu đề và ẩn cột nếu cần
                dgvLichTruc1.Columns["MaBacSi"].HeaderText = "Mã Bác Sĩ";
                dgvLichTruc1.Columns["TenBacSi"].HeaderText = "Tên Bác Sĩ";
                dgvLichTruc1.Columns["NgayTruc"].HeaderText = "Ngày Trực";
                dgvLichTruc1.Columns["ThoiGianCa"].HeaderText = "Thời Gian Ca";
                dgvLichTruc1.Columns["Khoa"].HeaderText = "Khoa";
                dgvLichTruc1.Columns["MaCaTruc"].Visible = false;

                    dgvLichTruc1.Refresh(); // Làm mới DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_loctheongay_Click(object sender, EventArgs e)
        {
            try
            {
                LICH_TRUC_BLL bll = new LICH_TRUC_BLL();
                DateTime selectedDate = dtpNgayTruc.Value; // Lấy giá trị ngày từ DateTimePicker
                DataTable dt = bll.FilterByDate(selectedDate);
                dgvLichTruc1.DataSource = dt;

                // Cập nhật tiêu đề và ẩn cột nếu cần
                dgvLichTruc1.Columns["MaBacSi"].HeaderText = "Mã Bác Sĩ";
                dgvLichTruc1.Columns["TenBacSi"].HeaderText = "Tên Bác Sĩ";
                dgvLichTruc1.Columns["NgayTruc"].HeaderText = "Ngày Trực";
                dgvLichTruc1.Columns["ThoiGianCa"].HeaderText = "Thời Gian Ca";
                dgvLichTruc1.Columns["Khoa"].HeaderText = "Khoa";
                dgvLichTruc1.Columns["MaCaTruc"].Visible = false;

                dgvLichTruc1.Refresh(); // Làm mới DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_loctheokhoa_Click(object sender, EventArgs e)
        {
            try
            {
                LICH_TRUC_BLL bll = new LICH_TRUC_BLL();
                DateTime selectedDate = dtpNgayTruc.Value;
                string selectedShift = cboCaTruc.SelectedValue.ToString();
                DataTable dt = bll.FilterByDateAndShift(selectedDate, selectedShift);
                dgvLichTruc1.DataSource = dt;

                // Cập nhật tiêu đề và ẩn cột nếu cần
                dgvLichTruc1.Columns["MaBacSi"].HeaderText = "Mã Bác Sĩ";
                dgvLichTruc1.Columns["TenBacSi"].HeaderText = "Tên Bác Sĩ";
                dgvLichTruc1.Columns["NgayTruc"].HeaderText = "Ngày Trực";
                dgvLichTruc1.Columns["ThoiGianCa"].HeaderText = "Thời Gian Ca";
                dgvLichTruc1.Columns["Khoa"].HeaderText = "Khoa";

                // Kiểm tra và ẩn cột MaCaTruc nếu tồn tại
                if (dgvLichTruc1.Columns.Contains("MaCaTruc"))
                {
                    dgvLichTruc1.Columns["MaCaTruc"].HeaderText = "Mã Ca Trực";
                    dgvLichTruc1.Columns["MaCaTruc"].Visible = false;
                }

                dgvLichTruc1.Refresh(); // Làm mới DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_HienTatCA_Click(object sender, EventArgs e)
        {
            Loaddgv();
        }

        private void btn_ChiaTuDong_Click(object sender, EventArgs e)
        {
            DateTime ngayTruc = dtpNgayTruc.Value;
            LICH_TRUC_BLL bll = new LICH_TRUC_BLL();

            try
            {
                bll.PhanLichTrucTuDong(ngayTruc);
                MessageBox.Show("Phân lịch trực tự động thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Loaddgv(); // Tải lại dữ liệu lên DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txtKhoa.Clear();

            // Giữ nguyên dữ liệu và không chọn mục nào
            cboBacsi.SelectedIndex = -1; // Đặt không chọn mục nào
            cboCaTruc.SelectedIndex = -1; // Đặt không chọn mục nào

            // Đặt Text về chuỗi rỗng để không hiển thị văn bản
            cboBacsi.Text = string.Empty;
            cboCaTruc.Text = string.Empty;

            // Đặt DateTimePicker về ngày hiện tại hoặc ngày cụ thể
            dtpNgayTruc.Value = DateTime.Now; // Đặt về ngày hiện tại
        }

        private void btn_ktrcatrong_Click(object sender, EventArgs e)
        {
            DateTime ngayTruc = dtpNgayTruc.Value;
            LICH_TRUC_BLL bll = new LICH_TRUC_BLL();

            try
            {
                DataTable dt = bll.KiemTraCaTrucTrongTrongNgay(ngayTruc);

                if (dt.Rows.Count > 0)
                {
                    dgv_catruc1.DataSource = dt;
                    MessageBox.Show("Có ca trực trống trong ngày này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không có ca trực trống trong ngày này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_LayLichTrucCuaBacSi_Click(object sender, EventArgs e)
        {
            string maBacSi = cboBacsi.SelectedValue.ToString();
            DateTime ngayTruc = dtpNgayTruc.Value;
            LICH_TRUC_BLL bll = new LICH_TRUC_BLL();

            try
            {
                DataTable dt = bll.LayLichTrucCuaBacSi(maBacSi, ngayTruc);
                dgv_catruc1.DataSource = dt;

                MessageBox.Show("Lấy lịch trực của bác sĩ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_LayDanhSachBacSi_Click(object sender, EventArgs e)
        {
            DateTime ngayTruc = dtpNgayTruc.Value;
            LICH_TRUC_BLL bll = new LICH_TRUC_BLL();

            try
            {
                DataTable dt = bll.LayDanhSachBacSi(ngayTruc);
                dgv_catruc1.DataSource = dt;

                MessageBox.Show("Lấy danh sách bác sĩ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_LayCaTrucChuaDuocPhanCongTrongNgay_Click(object sender, EventArgs e)
        {
            DateTime ngayTruc = dtpNgayTruc.Value;
            LICH_TRUC_BLL bll = new LICH_TRUC_BLL();

            try
            {
                DataTable dt = bll.LayCaTrucChuaDuocPhanCongTrongNgay(ngayTruc);
                dgv_catruc1.DataSource = dt;

                MessageBox.Show("Lấy ca trực chưa được phân công trong ngày thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_LayDanhSachLichTruc_Click(object sender, EventArgs e)
        {
            DateTime startDate = dtpStartDate.Value;
            DateTime endDate = dtpEndDate.Value;
            LICH_TRUC_BLL bll = new LICH_TRUC_BLL();

            try
            {
                DataTable dt = bll.LayDanhSachLichTruc(startDate, endDate);
                dgv_catruc1.DataSource = dt;

                MessageBox.Show("Lấy danh sách lịch trực bác sĩ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_LayBacSiCungCa_Click(object sender, EventArgs e)
        {
            DateTime ngayTruc = dtpNgayTruc.Value;
            string maCaTruc = cboCaTruc.SelectedValue.ToString();
            LICH_TRUC_BLL bll = new LICH_TRUC_BLL();

            try
            {
                DataTable dt = bll.LayBacSiCungCa(ngayTruc, maCaTruc);
                dgv_catruc1.DataSource = dt;

                MessageBox.Show("Lấy bác sĩ cùng ca trực thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
