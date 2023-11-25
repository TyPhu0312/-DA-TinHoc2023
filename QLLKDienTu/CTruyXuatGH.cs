using _Sales_LinhKienDienTu;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLLKDienTu
{
    class CTruyXuatGH
    {
        public bool docFile(string fileName, ref List<CGioHang> dsgh)
        {
            try
            {
                FileStream f = new FileStream(fileName, FileMode.OpenOrCreate);
                BinaryFormatter bf = new BinaryFormatter();
                dsgh = bf.Deserialize(f) as List<CGioHang>;
                f.Close();
                return true;
            }
            catch (IOException)
            {
                MessageBox.Show("Đã xảy ra lỗi khi đọc file dữ liệu!", "Thông báo");
                return false;
            }
            catch (Exception)
            {
                MessageBox.Show("Không thể đọc file dữ liệu!", "Thông báo");
                return false;
            }

        }
        public bool ghiFile(string fileName, ref List<CGioHang> dsgh)
        {
            try
            {
                FileStream f = new FileStream(fileName, FileMode.Create);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(f, dsgh);
                f.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
