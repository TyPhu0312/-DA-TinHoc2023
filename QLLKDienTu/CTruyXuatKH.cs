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
    internal class CTruyXuatKH
    {

        public bool docFile(string fileName, ref List<CTTKH> dskh)
        {
            try
            {
                FileStream f = new FileStream(fileName, FileMode.OpenOrCreate);
                BinaryFormatter bf = new BinaryFormatter();
                dskh = bf.Deserialize(f) as List<CTTKH>;
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
        public bool ghiFile(string fileName, ref List<CTTKH> dskh)
        {
            try
            {
                FileStream f = new FileStream(fileName, FileMode.OpenOrCreate);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(f, dskh);
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
