using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewDATN
{
    [Serializable]
    public class CDanhSachNhanVien
    {
        private Dictionary<string,CNhanVien> listNV = new Dictionary<string,CNhanVien>();
        
        public void create(string manv,CNhanVien entiny)
        {
            listNV.Add(manv,entiny);
        }

        public void delete(string ma)
        {
            listNV.Remove(ma);
        }

        public Dictionary<string,CNhanVien> getAll()
        {
            return listNV;
        }

        public Dictionary<string, CNhanVien> SetAll
        {
            set { listNV = value; }
            
        }
        


    }
}
