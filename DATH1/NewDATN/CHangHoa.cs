using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace NewDATN
{
    [Serializable]
    public class CHangHoa

    {
        
      protected string m_MaSP;
       protected string m_TenSP;
        protected string m_Size;
       protected string m_SoLuong;
        protected string m_DonGia;
        public string MaSP { get => m_MaSP; set => m_MaSP = value; }
        public string TenSP { get => m_TenSP; set => m_TenSP = value; }

        public string Size { get => m_Size; set => m_Size = value; }
        public string SoLuong { get => m_SoLuong; set => m_SoLuong = value; }
        public string DonGia { get => m_DonGia; set => m_DonGia = value; }
        public CHangHoa() { }
        
        public CHangHoa(string maSP, string tenSP, string size, string soLuong,string donGia)
        {
            MaSP = maSP;
            TenSP = tenSP;
            Size = size;
            SoLuong = soLuong;
            DonGia = donGia;

        }

        public override string ToString()
        {
            return m_MaSP + "_" + m_TenSP;
        }

    }
}
