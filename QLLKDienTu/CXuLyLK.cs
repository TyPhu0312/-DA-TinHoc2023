using _Sales_LinhKienDienTu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLLKDienTu
{
    internal class CXuLyLK
    {
        public CTTLK tim(string ma, List<CTTLK> dslk)
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
        public void timlk(string comboBoxValue, string value, ref List<CTTLK> DsDienThoai, ref List<CTTLK> dsTim)
        {
            foreach (CTTLK a in DsDienThoai)
            {
                switch (comboBoxValue)
                {
                    case "Mã":
                        if (a.MaLK.StartsWith(value))
                        {
                            dsTim.Add(a);
                        }
                        break;

                    case "Tên":
                        if (a.TenLK.StartsWith(value))
                        {
                            dsTim.Add(a);
                        }
                        break;

                    case "Hãng":
                        if (a.HangLK.StartsWith(value))
                        {
                            dsTim.Add(a);
                        }
                        break;
                    case "Loại":
                        if (a.LoaiLK.StartsWith(value))
                        {
                            dsTim.Add(a);
                        }
                        break;
                    case "Số Lượng":
                        if (a.SoLuong.StartsWith(value))
                        {
                            dsTim.Add(a);
                        }
                        break;
                    case "Giá":
                        if (a.Gia.StartsWith(value))
                        {
                            dsTim.Add(a);
                        }
                        break;


                    default:
                        break;
                }
            }
        }
        public void them(CTTLK lk, List<CTTLK> dslk)
        {

            if (tim(lk.MaLK, dslk) == null)
            {
                dslk.Add(lk);
            }
            else
            {
                MessageBox.Show("Mã số " + lk.MaLK + " đã tồn tại", "thông báo");
            }
        }
    }
}

