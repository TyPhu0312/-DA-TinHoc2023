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
    [Serializable]
    internal class CGioHang:CTTLK
    {
       
        public CGioHang()
        {
            MaLK = "";
            TenLK = "";
            LoaiLK = "";
            SoLuong = "";
            HangLK = "";
            Gia = "";
        }
        public CGioHang(string ma, string ten, string loai, string soluong, string hang, string gia)
        {
            MaLK = ma;
            TenLK = ten;
            LoaiLK = loai;
            SoLuong = soluong;
            HangLK = hang;
            Gia = gia;

        }
    }
}

