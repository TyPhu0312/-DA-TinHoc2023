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
    public partial class FMain : Form
    {
        CTruyXuatLK get = new CTruyXuatLK();
        List<CTTLK> dslk = new List<CTTLK>();
        private CTruyXuatGH gett = new CTruyXuatGH();
        private List<CGioHang> gioHang = new List<CGioHang>();
        CXuLyLK xl = new CXuLyLK();
        public FMain()
        {
            InitializeComponent();
        }
        private void hienThi(List<CTTLK> a)
        {
            dgvDSLK.DataSource = a.ToList();
        }
        private void FMain_Load(object sender, EventArgs e)
        {
            
           
            if (get.docFile("linhkien1.out", ref dslk) == true)
            {
                hienThi(dslk);
                MessageBox.Show("đọc được file", "Thông báo");
            }
            else
            {
                MessageBox.Show("Không đọc được file", "Thông báo");
            }
        }

        private void thôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FKH fkh = new FKH();
            fkh.Show();
            this.Hide();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FDangNhap fdn = new FDangNhap();
            fdn.Show();
            this.Close();
        }

        private void giỏHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FGioHang fgh = new FGioHang();
            fgh.ShowDialog();
            
        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FHoaDon fhd = new FHoaDon();
            fhd.Show();
            this.Close();
        }
        // test nhẹ ở đây

       

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void btnThemGioHang_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow i in dgvDSLK.SelectedRows)
            {
                string malk = i.Cells[0].Value.ToString();
                CTTLK n = tim(malk, dslk);
                if (n == null)
                {
                    MessageBox.Show("loi ko tim thay!");
                    return;
                }
                CGioHang gh = new CGioHang();
                gh.MaLK = i.Cells[0].Value.ToString();
                gh.TenLK = i.Cells[1].Value.ToString();
                gh.LoaiLK = i.Cells[2].Value.ToString();
                gh.SoLuong = i.Cells[3].Value.ToString();
                gh.HangLK = i.Cells[4].Value.ToString(); ;
                gh.Gia = i.Cells[5].Value.ToString();


                gioHang.Add(gh);
                if (gett.ghiFile("giohang.out", ref gioHang) == true)
                {
                    MessageBox.Show("Bạn đã ghi file thành công", "Thông báo");
                }
                else MessageBox.Show("Ghi file không thành công", "Thông báo");
            }
        }


        private void Sort(object sender, EventArgs e)
        {
            LocLinhKienDT();
        }
        private void LocLinhKienDT()
        {
            bool flag = false;
            List<CTTLK> dsLoc = new List<CTTLK>();
            string value = txtTimLK.Text; //lấy value trong textbox
            string comboBoxValue = cbbLK.SelectedItem.ToString();
            if (flag == false && txtTimLK.Text != "")
            {
                flag = true;
                CTTLK xuly = new CTTLK();
                xl.timlk(comboBoxValue, value, ref dslk, ref dsLoc);
                dgvDSLK.DataSource = dsLoc.ToList();
                dsLoc.Clear();
            }
        }

        private void cbbLK_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTimLK.Enabled = true;
            Sort(sender, e);


        }
    }
}
