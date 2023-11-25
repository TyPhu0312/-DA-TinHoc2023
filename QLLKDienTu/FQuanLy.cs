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
    public partial class FQuanLy : Form
    {
        private List<CTTTK> dstk = new List<CTTTK>();
        private CTruyXuatTK get = new CTruyXuatTK();
        CXuLyTK xl = new CXuLyTK();
        public FQuanLy()
        {
            InitializeComponent();
        }
        private void hienThi(List<CTTTK> a)
        {
            //if (File.Exists("taikhoan.out") == true)
            //    MessageBox.Show("File ton tai!");
            dgvDSTK.DataSource = a.ToList();
        }
        private void FQuanLy_Load(object sender, EventArgs e)
        {
           
            if (get.docFile("taikhoan.out", ref dstk) == true)
            {
                hienThi(dstk);
                //MessageBox.Show("đọc được file", "Thông báo");
            }
            else
            {
                MessageBox.Show("Không đọc được file", "Thông báo");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDX_Click(object sender, EventArgs e)
        {
            FDangNhap fdn = new FDangNhap();
            fdn.Show();
            this.Close();
        }

        private void quảnLýTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FQLTaiKhoan fqltk = new FQLTaiKhoan();
            fqltk.ShowDialog();
      
        }

        private void quảnLýLinhKiệnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FQLLinhKien fqllk = new FQLLinhKien();
            fqllk.ShowDialog();
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn có muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int selectedIndex = -1;
                for (int i = 0; i < dgvDSTK.SelectedCells.Count; i++)
                {
                    if (dgvDSTK.SelectedCells[i].RowIndex >= 0)
                    {
                        selectedIndex = dgvDSTK.SelectedCells[i].RowIndex;
                        break;
                    }
                }
                if (selectedIndex != -1)
                {
                    //Kiểm tra xem người dùng có click vào dòng không
                    //Nếu đã click thì xóa dòng đó
                    dstk.RemoveAt(selectedIndex);
                    selectedIndex = -1;
                    hienThi(dstk);
                    MessageBox.Show("Xóa thành công!", "Thông báo");
                }
                get.ghiFile("taikhoan.out", ref dstk); //cap nhat lai file sau khi xoa. 
            }
        }

        private void quảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FQLKhachHang fqlkh = new FQLKhachHang();
            fqlkh.ShowDialog();
        }

       

        private void btnReset_Click(object sender, EventArgs e)
        {
            hienThi(dstk);

        }

        

        private void btnTim_Click_1(object sender, EventArgs e)
        {
            CTTTK n = xl.tim(txtTim.Text, dstk);
            if (n == null)
            {
                MessageBox.Show("loi ko tim thay!");
            }
            else
            {
                List<CTTTK> ds = new List<CTTTK>();
                ds.Add(n);
                get.ghiFile("tamtk.out", ref ds);
                hienThi(ds); txtTim.Clear();

            }
        }
    }
}
