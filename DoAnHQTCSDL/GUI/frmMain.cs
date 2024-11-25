using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            // Thiết lập form ở chế độ full màn hình
            this.WindowState = FormWindowState.Maximized;
            // Không hiển thị thanh tiêu đề
            //this.FormBorderStyle = FormBorderStyle.None;
            // Tắt việc chỉnh kích thước form
            //this.MaximizeBox = false;
            //this.MinimizeBox = false;
            //this.TopMost = true;  // Đặt form luôn ở trên cùng (tuỳ chọn)
        }
        private Form CurrentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if (CurrentFormChild != null)
            {
                CurrentFormChild.Close();
            }
            CurrentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_body.Controls.Add(childForm);
            panel_body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        public void load_logo()
        {
            Logo_pic.Image = new Bitmap("C:\\Users\\vuxec\\OneDrive\\Máy tính\\DoAnHQTCSDL\\DoAnHQTCSDL\\GUI\\Imgs\\Logo.jfif");
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            //load_logo();
            
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmDangNhap());
            label_top.Text = "Đăng Nhập";
        }

        private void nhậpThuốcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmNhapThuoc());
            label_top.Text = "Nhập Thuốc";
        }

        private void frmMain_Resize(object sender, EventArgs e)
        {
            this.panel_body.Width = this.Width;
            this.panel_body.Height = this.Height;


        }

        private void lấyThuốcTheoToaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmLayThuoc());
            label_top.Text = "Lấy Thuốc Theo Toa";
        }

        private void thôngTinChiTiếtThuốcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmThongTinThuoc());
            label_top.Text = "Thông Tin Chi Tiết Thuốc";
        }

        private void quảnLýBệnhNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new frm_QuanLyBenhNhan());
        }

        private void thôngTinBệnhNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new frm_TimKiem_ThongTinBenhNhan());
            //label_top.Text = "Tìm Kiếm Thông Tin Bệnh Nhân";
        }

        private void toaThuốcToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new frm_TimKiem_ToaThuoc());
            //label_top.Text = "Tìm Kiếm Thông Tin Toa Thuốc";
        }

        private void phiếuKhámToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new frm_TimKiem_PhieuKham());
            //label_top.Text = "Tìm Kiếm Thông Tin Phiếu Khám";
        }

        private void hồSơBệnhNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new frm_XemChiTiet_HSBN());
            //label_top.Text = "Xem chi Tiết Hồ Sơ Bệnh Nhân";
        }

        private void phiếuKhámToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new frm_XemChiTiet_PhieuKham());
            //label_top.Text = "Xem Chi Tiết Phiếu Khám";
        }

        private void toaThuốcToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new frm_XemChiTiet_ToaThuoc());
            //label_top.Text = "Xem Chi Tiết Toa Thuốc";
        }

        private void toaThuốcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new frm_Tri_ToaThuoc());
            //label_top.Text = "Toa Thuốc";
        }

        private void phiếuKhámToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new frm_Tri_PhieuKham());
            //label_top.Text = "Phiếu Khám";

        }

        private void thanhToánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new frm_Tri_ThanhToan());
            //label_top.Text = "Thanh Toán";
        }

        private void bệnhNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new frm_Tri_ThongKeBenhNhan());
            //label_top.Text = "Thống Kê Bệnh Nhân";
        }

        private void phiếuKhámToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new frm_Tri_ThongKePhieuKham());
            //label_top.Text = "Thống Kê Phiếu Khám";
        }

        private void xemLịchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_Phong_XemLichTruc());
            label_top.Text = "Xem Lịch Trực";
        }

        private void lịchTrựcToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_Phong_LichTruc());
            label_top.Text = "Chia Lịch Trực";
        }

        private void hồSơBệnhÁnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new frm_Duy_HoSoBenhAn());
            //label_top.Text = "Hồ Sơ Bệnh Nhân";
        }

        private void tìmKiếmHồSơBệnhÁnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new frm_Duy_TimKiemHoSoBenhAn());
            //label_top.Text = "Tìm Kiếm Hồ Sơ Bệnh Nhân";
        }

        private void nhậpViệnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new frm_Nguyen_NhapVien());
            //label_top.Text = "Nhập Viện";
        }

        private void xuấtViệnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new frm_Nguyen_XuatVien());
            //label_top.Text = "Xuất Viện";
        }

        private void lịchSửNhậpXuấtViệnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new frm_Nguyen_LichSuNhapVien());
            //label_top.Text = "Tra Cứu Lịch Sử Nhập Viện";
        }

        private void kiểmTraBHYTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new frm_Nguyen_KiemTraBHYT());
            //label_top.Text = "Kiểm Tra BHYT";
        }

        private void danhSáchBácSĩToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_Phong_QuanLyBacSi());
            label_top.Text = "Danh sách Bác sĩ";
        }
    }
}
