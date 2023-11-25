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
    [Serializable]
    internal class CTTKH
    {
        private string m_MaKH;
        private string m_TenKH;
        private string m_SoDienThoaiKH;
        private string m_DiaChiKH;
        private string m_EMailKH;
        private string m_GioiTinhKH;

        public string TenKH { get => m_TenKH; set => m_TenKH = value; }
        public string MaKH { get => m_MaKH; set => m_MaKH = value; }
        public string SoDienThoaiKH { get => m_SoDienThoaiKH; set => m_SoDienThoaiKH = value; }
        public string DiaChiKH { get => m_DiaChiKH; set => m_DiaChiKH = value; }
        public string EMailKH { get => m_EMailKH; set => m_EMailKH = value; }
        public string GioiTinhKH { get => m_GioiTinhKH; set => m_GioiTinhKH = value; }

        public CTTKH()
        {
            m_TenKH = "";
            m_MaKH = "";
            m_SoDienThoaiKH = "";
            m_DiaChiKH = "";
            m_EMailKH = "";
            m_GioiTinhKH = "";

        }
        public CTTKH(string ma,string ten,string sdt,string diachi,string email, string gioitinh)
        {
            m_MaKH= ma;
            m_TenKH= ten;
            m_SoDienThoaiKH= sdt;
            m_DiaChiKH= diachi;
            m_EMailKH= email;
            m_GioiTinhKH= gioitinh;
        }



    }
}
