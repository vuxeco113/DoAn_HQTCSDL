using DTO;
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
            /*this.WindowState = FormWindowState.Maximized*/;
            // Không hiển thị thanh tiêu đề
            //this.FormBorderStyle = FormBorderStyle.None;
            // Tắt việc chỉnh kích thước form
            //this.MaximizeBox = false;
            //this.MinimizeBox = false;
            //this.TopMost = true;  // Đặt form luôn ở trên cùng (tuỳ chọn)
        }
        private Form CurrentFormChild;
        BAC_SI_DTO bs;
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

            thuốcToolStripMenuItem.Enabled = false;
            quảnLýBệnhNhânToolStripMenuItem.Enabled = false;
            lịchTrựcToolStripMenuItem.Enabled=false;
            hồSơBệnhÁnToolStripMenuItem.Enabled = false;
            nhậpXuấtViệnToolStripMenuItem.Enabled=false;
            bácSĩToolStripMenuItem.Enabled=false;

            chứcNăngToolStripMenuItem.Enabled=false ;
            danhMụcToolStripMenuItem.Enabled=false ;
            //load_logo();
            frmDangNhap DangNhap = new frmDangNhap();
            if (CurrentFormChild != null)
            {
                CurrentFormChild.Close();
            }
            CurrentFormChild = DangNhap;
            DangNhap.TopLevel = false;
            DangNhap.FormBorderStyle = FormBorderStyle.None;
            DangNhap.Dock = DockStyle.Fill;
            panel_body.Controls.Add(DangNhap);
            panel_body.Tag = DangNhap;
            DangNhap.BringToFront();
            DangNhap.truyenBS = new frmDangNhap.BacSiDN(Load_PhienDN);
            DangNhap.Show();

        }
        public void Load_PhienDN(BAC_SI_DTO a)
        {
            bs = a;
            ten.Text += bs.HoTen;
            if (bs.ChucVu=="Điều Dưỡng")
            {
                thuốcToolStripMenuItem.Enabled = true;
                
            }
            else if(bs.ChucVu=="Thu Ngân")
            {
                quảnLýBệnhNhânToolStripMenuItem.Enabled = true;
                chứcNăngToolStripMenuItem.Enabled = true;
            }
            else
            {
                chứcNăngToolStripMenuItem.Enabled = true;
                thuốcToolStripMenuItem.Enabled = true;
                quảnLýBệnhNhânToolStripMenuItem.Enabled = true;
                lịchTrựcToolStripMenuItem.Enabled = true;
                hồSơBệnhÁnToolStripMenuItem.Enabled = true;
                nhậpXuấtViệnToolStripMenuItem.Enabled = true;
                bácSĩToolStripMenuItem.Enabled = true;
                danhMụcToolStripMenuItem.Enabled = true;
            }
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
            OpenChildForm(new frm_Tri_QuanLyBenhNhan());
        }

        private void thôngTinBệnhNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_Tri_timkiem_BN());
            label_top.Text = "Tìm Kiếm Thông Tin Bệnh Nhân";
        }

        private void toaThuốcToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_Tri_ToaThuoc());
            label_top.Text = "Tìm Kiếm Thông Tin Toa Thuốc";
        }

        private void phiếuKhámToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_Tri_timkiemphieukham());
            label_top.Text = "Tìm Kiếm Thông Tin Phiếu Khám";
        }

        private void hồSơBệnhNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_Tri_XemChiTiet_HSBN());
            label_top.Text = "Xem chi Tiết Hồ Sơ Bệnh Nhân";
        }

        private void toaThuốcToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_Tri_xemchitiettoathuoc());
            label_top.Text = "Xem Chi Tiết Toa Thuốc";
        }

        private void toaThuốcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_Tri_ToaThuoc());
            label_top.Text = "Toa Thuốc";
        }

        private void phiếuKhámToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_Tri_Phieukham());
            label_top.Text = "Phiếu Khám";

        }

        private void thanhToánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_Tri_Thanhtoan());
            label_top.Text = "Thanh Toán";
        }
        

        private void lịchTrựcToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_Phong_LichTruc());
            label_top.Text = "Chia Lịch Trực";
        }

      

        private void hồSơBệnhÁnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_Duy_HoSoBenhAn());
            label_top.Text = "Hồ Sơ Bệnh Nhân";
        }

        private void tìmKiếmHồSơBệnhÁnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_Duy_TimKiemHoSoBenhAn());
            label_top.Text = "Tìm Kiếm Hồ Sơ Bệnh Nhân";
        }

        private void nhậpViệnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_Nguyen_NhapVien());
            label_top.Text = "Nhập Viện";
        }

        private void xuấtViệnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_Nguyen_XuatVien());
            label_top.Text = "Xuất Viện";
        }

        private void lịchSửNhậpXuấtViệnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_Nguyen_LichSuNhapVien());
            label_top.Text = "Tra Cứu Lịch Sử Nhập Viện";
        }

        private void kiểmTraBHYTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_Nguyen_KiemTraBHYT());
            label_top.Text = "Kiểm Tra BHYT";
        }

        private void phiếuXétNghiệmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_Tri_phieuxetnghiem());
            label_top.Text = "Phiếu xét nghiệm";
        }

        private void bácSĩToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_Phong_QuanLyBacSi());
            label_top.Text = "Bác sĩ";
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMain_Load(sender, e);
            ten.Text = "Chào :";
            //CurrentFormChild.Close();
        }
    }
}
