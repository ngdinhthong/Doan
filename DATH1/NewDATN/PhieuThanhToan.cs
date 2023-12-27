using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewDATN
{
    [Serializable]
    public class PhieuThanhToan : CHangHoa
    {
        //protected string m_MaSP;
        //protected string m_TenSP;
        //protected string m_Size;
        //protected string m_SoLuong;
        protected DateTime m_NgayThanhToan;
        protected double m_giaTien;
        protected string m_TenNV;
        
        public PhieuThanhToan() : base()
        {
            m_NgayThanhToan = DateTime.Now;
            m_giaTien = 0.0;
            m_TenNV = "null";
        }
        public PhieuThanhToan(string maSP, string tenSP, string size, string soLuong, string donGia, DateTime ngayThanhToan, double giaTien, string tenNV) : base(maSP, tenSP, size, soLuong, donGia)
        {
            m_NgayThanhToan = ngayThanhToan;
            m_giaTien = giaTien;
            m_TenNV = tenNV;
        }

        public DateTime NgayThanhToan { get => m_NgayThanhToan; set => m_NgayThanhToan = value; }
        public double GiaTien
        {
            get
            {
                return m_giaTien;
            }
            set
            {
                m_giaTien = value;
            }
            
        }
       
        
        public string TenNV
        {
            get { return m_TenNV; }
            set { m_TenNV = value; }
        }

    }
}
