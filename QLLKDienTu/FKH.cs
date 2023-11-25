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
    public partial class FKH : Form
    {
        CTruyXuatKH get = new CTruyXuatKH();
        List<CTTKH> dskh = new List<CTTKH>();

        public FKH()
        {
            InitializeComponent();
        }
       
        private void btnLuu_Click(object sender, EventArgs e)
        {
            CTTKH kh = new CTTKH();
            kh.MaKH=txtMaKH.Text;
            kh.TenKH=txtTenKH.Text;
            kh.SoDienThoaiKH=txtSDTKH.Text;
            kh.DiaChiKH = txtDiaChiKH.Text;
            kh.EMailKH = txtEMailKH.Text;
            if(rdbNam.Checked==true)
            {
                kh.GioiTinhKH = "Nam";

            }
            else
            {
                kh.GioiTinhKH = "Nữ";
            }
            dskh.Add(kh);
        
            if (get.ghiFile("khachhang.out", ref dskh) == true)
            {
                MessageBox.Show("Bạn đã ghi file thành công", "Thông báo");
            }
            else MessageBox.Show("Ghi file không thành công", "Thông báo");
        }

        private void FKH_Load(object sender, EventArgs e)
        {
            if (get.docFile("khachhang.out", ref dskh) == true)
            {
                MessageBox.Show("Đọc file thành công", "Thông báo");
            }
            else MessageBox.Show("Đọc file không thành công", "Thông báo");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
