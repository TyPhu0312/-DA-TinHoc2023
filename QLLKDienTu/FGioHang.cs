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
    public partial class FGioHang : Form
    {
        private List<CTTLK> dslk = new List<CTTLK>();
        private CTruyXuatGH gett = new CTruyXuatGH();
        private List<CGioHang> gioHang = new List<CGioHang>();
        public FGioHang()
        {
            InitializeComponent();
        }
        private CGioHang tim(string ma, List<CGioHang> gioHangs)
        {
            foreach (CGioHang a in gioHang)
            {
                if (a.MaLK == ma)
                {
                    return a;
                }
            }
            return null;
        }
        private void hienThi()
        {
            dgvGioHang.DataSource = gioHang.ToList();
        }

        private void FGioHang_Load(object sender, EventArgs e)
        {
            if (gett.docFile("giohang.out", ref gioHang) == true)
            {
                hienThi();
                MessageBox.Show("đọc được file", "Thông báo");
            }
            else
            {
                MessageBox.Show("Không đọc được file", "Thông báo");
            }
        }

        private void dgvGioHang_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            double tong = 0;
            foreach (DataGridViewRow i in dgvGioHang.SelectedRows)
            {
                string gia = i.Cells[5].Value.ToString();
                tong += double.Parse(gia);                
                lb.Text = tong.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void dgvGioHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow i in dgvGioHang.SelectedRows)
            {
                string malk = i.Cells[0].Value.ToString();
                CGioHang n = tim(malk, gioHang);
                if (n == null)
                {
                    MessageBox.Show("loi ko tim thay!");
                    return;
                }
                if (MessageBox.Show("ban co muon xoa khong?", "thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    gioHang.Remove(n);
                    hienThi();
                    lb.Text = "";

                }
            }
        }
    }
}
