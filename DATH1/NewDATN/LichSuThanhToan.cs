using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewDATN
{
    [Serializable]
    public class LichSuThanhToan:PhieuThanhToan
    {
        protected string m_MaDon;
        public string MaDon
        {
            get { return m_MaDon; }
            set { m_MaDon = value; }
        }

        public LichSuThanhToan() : base()
        {
            m_MaDon = "";
        }
        public LichSuThanhToan(string maSP, string tenSP, string size, string soLuong, string donGia, DateTime ngayThanhToan, double giaTien, string tenNV,string maDon) : base(maSP, tenSP, size, soLuong, donGia,ngayThanhToan,giaTien,tenNV)
        {
            m_MaDon = maDon;
        }
    }
}
