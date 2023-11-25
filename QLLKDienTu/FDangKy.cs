using _Sales_LinhKienDienTu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLLKDienTu
{
    public partial class FDangKy : Form
    {
        private List<CTTTK> dstk = new List<CTTTK>();
        private CTruyXuatTK get = new CTruyXuatTK();
        private CXuLyTK xl = new CXuLyTK();
        public FDangKy()
        {
            InitializeComponent();
        }
        
        
       
        private void Form1_Load(object sender, EventArgs e)
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

        private void btnDK_Click(object sender, EventArgs e)
        {
            CTTTK tk = new CTTTK();
            tk.Name = txtTen.Text;
            tk.TK = txtTK.Text;
            tk.MK = txtMK.Text;
            xl.them(tk,dstk);
            if (get.ghiFile("taikhoan.out",ref dstk) == true)
            {
                MessageBox.Show("Bạn đã ghi file thành công", "Thông báo");
            }
            else MessageBox.Show("Ghi file không thành công", "Thông báo");
            txtTK.Clear();
            txtTen.Clear();
            txtMK.Clear();
            txtTen.Focus();

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            FDangNhap fdn = new FDangNhap();
            fdn.Show();
            this.Close();
        }
    }
}
