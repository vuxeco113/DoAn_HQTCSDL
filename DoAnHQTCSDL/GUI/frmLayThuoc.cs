using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using DTO;
using BLL;
namespace GUI
{
    public partial class frmLayThuoc : Form
    {
        public frmLayThuoc()
        {
            InitializeComponent();
        }

        private void frmLayThuoc_Load(object sender, EventArgs e)
        {

        }
        TOA_THUOC_BLL ttBLL= new TOA_THUOC_BLL();
        CHI_TIET_TOA_THUOC_BLL ctttBLL = new CHI_TIET_TOA_THUOC_BLL();


        List<CHI_TIET_TOA_THUOC_DTO> ds_tim;
        LUUKHO_BLL lkBLL = new LUUKHO_BLL();
        List<LUUKHO_DTO> khoTHUOC;
        private void btnTimToaThuoc_Click(object sender, EventArgs e)
        {
            List<TOA_THUOC_DTO> dsToaThuoc = ttBLL.get_all();
            if(txtMaToaThuoc.Text.Trim().Length>0)
            {
                TOA_THUOC_DTO tmp = dsToaThuoc.Find(d=>d.MaToa==txtMaToaThuoc.Text);
                if(tmp==null)
                {
                    MessageBox.Show("Tìm KHông Thấy Toa Thuốc");
                }
                else
                {
                    txtNgayKetToa.Text = tmp.NgayKetToa;
                    txtNgayKetThuc.Text = tmp.NgayKetThuc;
                    txtSoNgayDung.Text = tmp.SoNgayDung.ToString();
                    txtSoLoaiThuoc.Text=tmp.SoLoaiThuoc.ToString();
                    txtMaBS.Text = tmp.MaBacSi;
                    ds_tim=ctttBLL.get_all().Where(d=>d.MaToa==txtMaToaThuoc.Text.Trim()).ToList();
                    dataGridView_ChiTietToa.DataSource = null;
                    dataGridView_ChiTietToa.DataSource = ds_tim;
                }
                
            }
            else
            {
                MessageBox.Show("Nhập Mã Toa Thuốc");
            }
        }

        private void btnLayThuoc_Click(object sender, EventArgs e)
        {


            khoTHUOC = lkBLL.get_all();
         
            foreach(CHI_TIET_TOA_THUOC_DTO tmp in ds_tim)
            {
                LUUKHO_DTO tmp1 = khoTHUOC.Find(d => d.MaThuoc.Trim() == tmp.MaThuoc.Trim());
                if (tmp1 == null && tmp1.SLTon < tmp.SL) 
                {
                    MessageBox.Show("Không Có Đủ Thuốc Trong Kho");
                    return;
                }
            }
            MessageBox.Show("Có Đủ Thuốc Cho Toa Thuốc");
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
        

            THUOC_BLL DS_Thuoc= new THUOC_BLL();
            THANH_TOAN_BLL thanhtoanBLL = new THANH_TOAN_BLL();
            string ma = "TT" + DateTime.Today.ToString("yyMMdd") + string.Format("{0:00}",thanhtoanBLL.Dem_SL_THANHTAON_ToaThuoc()+1);
            float tongtien = 0;

            foreach (CHI_TIET_TOA_THUOC_DTO tmp in ds_tim)
            {
                THUOC_DTO th = DS_Thuoc.get_all().Find(d => d.MaThuoc.Trim() == tmp.MaThuoc.Trim());

                
                if(lkBLL.layThuoc1Loai(tmp)==false && th==null)
                {
                    MessageBox.Show("Thanh Toán Thất Bại");
                    return;
                }
                tongtien = tongtien + (th.Gia*tmp.SL);
            }
            THANH_TOAN_DTO thanhtoanDT0 = new THANH_TOAN_DTO();
            thanhtoanDT0.MaThanhToan = ma;
            thanhtoanDT0.MaPhieuKham = "NULL";
            thanhtoanDT0.MaRaVien = "NULL";
            thanhtoanDT0.SoTien=tongtien;
            thanhtoanDT0.NgayThanhToan = DateTime.Today.ToString("yyyy-MM-dd");
            if (thanhtoanBLL.Them_ThanhToan_ToaThuoc(thanhtoanDT0))
            {
                MessageBox.Show("Thanh Toán Thành Công : Số Tiền Là : " + tongtien + "");
            }
            else
            {
                MessageBox.Show("Thanh Toán Thất Bại");
            }
        }
    }
}
