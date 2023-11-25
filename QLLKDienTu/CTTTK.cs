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

namespace _Sales_LinhKienDienTu
{
    [Serializable]
    internal class CTTTK
    {
        private string m_Name;
        private string m_TK;
        private string m_MK;

        public string Name { get => m_Name; set => m_Name = value; }
        public string TK { get => m_TK; set => m_TK = value; }
        public string MK { get => m_MK; set => m_MK = value; }

        public CTTTK()
        {
            Name = "";
            TK = "";
            MK = "";
        }
        public CTTTK(string name, string tk, string mk)
        {
            m_Name = name;
            m_TK = tk;
            m_MK = mk;
        }
    }
}
