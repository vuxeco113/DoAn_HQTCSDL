using BLL;
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
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }
        public delegate void BacSiDN(BAC_SI_DTO dn);
        public BacSiDN truyenBS;


        public BAC_SI_DTO bs;
        public BAC_SI_BLL bsBLL = new BAC_SI_BLL();

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            txtMatKhau.PasswordChar= '*';
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtMatKhau.PasswordChar = '\0';
            }
            else
            {
                txtMatKhau.PasswordChar = '*';
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtMaBS.Text.Trim().Length > 0 && txtMatKhau.Text.Trim().Length > 0)
            {
                bs = bsBLL.DangNhap(txtMaBS.Text.Trim(), txtMatKhau.Text.Trim());
                if (bs != null)
                {
                    truyenBS(bs);
                    MessageBox.Show("Đăng nhập thành công! chào "+bs.HoTen+"");
                    this.Close();
                }
                else { MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu"); }
            }
            else
            {
                MessageBox.Show("Dien day du thong tin");
            }
        }
    }
}

