using _Sales_LinhKienDienTu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLLKDienTu
{
    internal class CXuLyTK
    {
        public CTTTK tim(string ma,List<CTTTK> dstk)
        {
            foreach (CTTTK a in dstk)
            {
                if (a.TK == ma)
                {
                    return a;
                }
            }
            return null;
        }
        public void them(CTTTK tk, List<CTTTK> dstk)
        {
            
            if (tim(tk.TK,dstk) == null)
            {
                dstk.Add(tk);
                //hienThi();
            }
            else
            {
                MessageBox.Show("Mã số " + tk.TK + " đã tồn tại", "thông báo");
            }
        }
    }
}
