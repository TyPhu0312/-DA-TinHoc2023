using _Sales_LinhKienDienTu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLLKDienTu
{
    public partial class FDangNhap : Form
    {
        private CTruyXuatTK get = new CTruyXuatTK();
        List<CTTTK> dstk = new List<CTTTK>();
        private CXuLyTK xl = new CXuLyTK();
        public FDangNhap()
        {
            InitializeComponent();
        }
        private CTTTK tim(string ma)
        {
            foreach (CTTTK a in dstk)
            {
                if (a.TK == ma)
                {
                    return a;
                }
            }
            return null;
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            
            if (txtTaiKhoan.Text=="admin"&&txtMatKhau.Text=="admin")
            {
                this.Hide();
                FQuanLy fql = new FQuanLy();
                fql.Show();
            }
            else if(tim(txtTaiKhoan.Text) ==null||tim(txtMatKhau.Text)==null)
            {
                MessageBox.Show("Tài khoản hoặc mặt khẩu không đúng. Vui lòng thử lại", "Thông báo");
                txtMatKhau.Text = "";
                txtMatKhau.Focus();
            }
            else
            {
                FMain fm = new FMain();
                fm.Show();
                this.Hide();
            }

 
        }

        private void FDangNhap_Load(object sender, EventArgs e)
        {
            get.docFile("taikhoan.out", ref dstk);
            //if (get.docFile("taikhoan.out", ref dstk) == true)
            //{
            //    //hienThi();
            //    MessageBox.Show("đọc được file", "Thông báo");
            //}
            //else
            //{
            //    MessageBox.Show("Không đọc được file", "Thông báo");
            //}
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            FDangKy fdk = new FDangKy();
            fdk.Show();
            this.Hide();
        }
    }
}
