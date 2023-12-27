using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewDATN
{
    [Serializable]

    public class CNhanVien
    {
        private string m_MaNV;
        private string m_TenNV;
        private DateTime m_NgaySinh;
        private string m_Phai;
        private string m_Chuc;
        
        public string MaNV { get => m_MaNV; set => m_MaNV = value; }
        public string TenNV { get => m_TenNV;set=> m_TenNV = value; }
        public DateTime NgaySinh { get => m_NgaySinh;set =>m_NgaySinh = value; }
        public string Phai { get => m_Phai;set => m_Phai = value; }
        public string ChucVu { get => m_Chuc; set => m_Chuc = value; }
        public CNhanVien()
        {
            m_MaNV = "";
            m_TenNV = "";
            m_NgaySinh= DateTime.Now;
            m_Phai = "";
        }
        public CNhanVien(string MaNV,string TenNv,DateTime NgaySinh,string phai,string ChucVu)
        {
            m_MaNV=MaNV;
            m_TenNV=TenNv;
            m_NgaySinh=NgaySinh;
            m_Phai=phai;
            m_Chuc=ChucVu;
        }
      
    }
}
