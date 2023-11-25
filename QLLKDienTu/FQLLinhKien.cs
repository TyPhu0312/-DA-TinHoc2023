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
    public partial class FQLLinhKien : Form
    {
        private List<CTTLK> dslk = new List<CTTLK>();
        private CTruyXuatLK get = new CTruyXuatLK();
        private CXuLyLK xl = new CXuLyLK();
        public FQLLinhKien()
        {
            InitializeComponent();
        }
        private CTTLK tim(string ma, List<CTTLK> dslk)
        {
            foreach (CTTLK a in dslk)
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
            dgvDSLK.DataSource = dslk.ToList();
        }

        private void FQLLinhKien_Load(object sender, EventArgs e)
        {
            if (get.docFile("linhkien1.out", ref dslk) == true)
            {
                hienThi();
                MessageBox.Show("đọc được file", "Thông báo");
            }
            else
            {
                MessageBox.Show("Không đọc được file", "Thông báo");
            }
        }

        

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (get.ghiFile("linhkien1.out",ref dslk)==true)
            {
                MessageBox.Show("Lưu file thành công", "Thông báo");
            }
            else
            {
                MessageBox.Show("Lưu file không thành công", "Thông báo");
            }

        }
        private void them1LinhKien()
        {

            CTTLK lk = new CTTLK();
            lk.MaLK = txtMaLK.Text;
            lk.TenLK = txtTenLK.Text;
            lk.LoaiLK = txtLoaiLK.Text;
            lk.SoLuong = txtSoLuong.Text;
            lk.HangLK = txtHang.Text;
            lk.Gia = txtGia.Text;
            if (tim(txtMaLK.Text, dslk) == null)
            {
                xl.them(lk, dslk);
                hienThi();
            }
            else
            {
                MessageBox.Show("Mã linh kiện " + txtMaLK.Text + " đã tồn tại", "Thông báo");
            }
            txtMaLK.Clear();
            txtTenLK.Clear();
            txtLoaiLK.Clear();
            txtSoLuong.Clear();
            txtHang.Clear();
            txtGia.Clear();
            txtMaLK.Focus();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            them1LinhKien();
            if (get.ghiFile("QLDSDT.txt", ref dslk) == true)
            {
                //MessageBox.Show("Thêm thành công", "Thông báo");
            }
            else MessageBox.Show("Ghi file không thành công", "Thông báo");

        }



        private void btnSua_Click(object sender, EventArgs e)
        {
            string malk = txtMaLK.Text;
            CTTLK n = tim(malk, dslk);
            if(n==null)
                MessageBox.Show("khong co linh kien");
            n.TenLK = txtTenLK.Text;
            n.LoaiLK = txtLoaiLK.Text;
            n.SoLuong = txtSoLuong.Text;
            n.HangLK = txtHang.Text;
            n.Gia = txtGia.Text;
            hienThi();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int selectedIndex = -1;
                for (int i = 0; i < dgvDSLK.SelectedCells.Count; i++)
                {
                    if (dgvDSLK.SelectedCells[i].RowIndex >= 0)
                    {
                        selectedIndex = dgvDSLK.SelectedCells[i].RowIndex;
                        break;
                    }
                }
                if (selectedIndex != -1)
                {
                    //Kiểm tra xem người dùng có click vào dòng không
                    //Nếu đã click thì xóa dòng đó
                    dslk.RemoveAt(selectedIndex);
                    selectedIndex = -1;
                    hienThi();
                    MessageBox.Show("Xóa thành công!", "Thông báo");
                }
                get.ghiFile("QLDSDT.txt", ref dslk); //cap nhat lai file sau khi xoa. 
            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
