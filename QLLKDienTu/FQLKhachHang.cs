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
    public partial class FQLKhachHang : Form
    {
        CTruyXuatKH get = new CTruyXuatKH();
        CXuLyKH xl = new CXuLyKH();
        List<CTTKH> dskh = new List<CTTKH>();
        public FQLKhachHang()
        {
            InitializeComponent();
        }
        public void hienThi()
        {

            dgvTTKH.DataSource = dskh.ToList();
        }
        private void FQLKhachHang_Load(object sender, EventArgs e)
        {
            if (get.docFile("khachhang.out", ref dskh) == true)
            {
                hienThi();
                MessageBox.Show("đọc được file", "Thông báo");
            }
            else
            {
                MessageBox.Show("Không đọc được file", "Thông báo");
            }
        }

        private void dgvTTKH_DoubleClick(object sender, EventArgs e)
        {
            FKH fkh = new FKH();
            fkh.ShowDialog();

        }
    }
}
