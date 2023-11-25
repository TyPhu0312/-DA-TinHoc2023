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
    internal class CXuLyKH
    {
        private CTTKH tim(string ma, List<CTTKH> dskh)
        {
            foreach (CTTKH a in dskh)
            {
                if (a.MaKH == ma)
                {
                    return a;
                }
            }
            return null;
        }
        public void them(CTTKH kh, List<CTTKH> dslk)
        {

            if (tim(kh.MaKH, dslk) == null)
            {
                dslk.Add(kh);

            }
            else
            {
                MessageBox.Show("Mã số " + kh.MaKH + " đã tồn tại", "thông báo");
            }
        }
    }
}
