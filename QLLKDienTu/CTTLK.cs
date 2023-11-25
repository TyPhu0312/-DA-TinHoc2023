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
    internal class CTTLK
    {
        private string m_malk;
        private string m_tenlk;
        private string m_loailk;
        private string m_soluong;
        private string m_hanglk;
        private string m_gialk;
        public string MaLK { get => m_malk; set => m_malk = value; }
        public string TenLK { get => m_tenlk; set => m_tenlk = value; }
        public string LoaiLK { get => m_loailk; set => m_loailk = value; }
        public string SoLuong { get => m_soluong; set => m_soluong = value; }
        public string HangLK { get => m_hanglk; set => m_hanglk = value; }
        public string Gia { get => m_gialk; set => m_gialk = value; }
        public CTTLK()
        {
            MaLK = "";
            TenLK = "";
            LoaiLK = "";
            SoLuong = "";
            HangLK = "";
            Gia = "";
        }
        public CTTLK(string ma,string ten,string loai, string soluong,string hang, string gia)
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
