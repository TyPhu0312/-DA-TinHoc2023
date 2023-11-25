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
    public partial class FQLTaiKhoan : Form
    {
        private List<CTTTK> dstk = new List<CTTTK>();
        private CTruyXuatTK get = new CTruyXuatTK();
        public FQLTaiKhoan()
        {
            InitializeComponent();
        }

        private void FQLTaiKhoan_Load(object sender, EventArgs e)
        {
            if (get.docFile("taikhoan.out", ref dstk) == true)
            {
                //hienThi();
                MessageBox.Show("đọc được file", "Thông báo");

            }
            else
            {
                MessageBox.Show("Không đọc được file", "Thông báo");
            }
        }

        private void btnLuuThayDoi_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
