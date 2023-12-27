using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace NewDATN
{
    [Serializable]
    class CSanPham:CHangHoa 
    {
        private List<CHangHoa> dsSP;
        public CSanPham()
        {
            dsSP = new List<CHangHoa>();
        }
        public List<CHangHoa> hienDSSP()
        {
            return dsSP.ToList();
        }
        public void them(CHangHoa pt)
        {
            dsSP.Add(pt);
        }
        public bool ghiFile(string tenfile)
        {
            using (Stream file = File.Open("HangHoa.txt", FileMode.Create))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(file, dsSP);
                return true;
            }

        }
        public bool docFile(string tenfile)
        {

            BinaryFormatter bin = new BinaryFormatter();
            if (File.Exists("HangHoa.txt"))
            {
                using (FileStream reader = new FileStream(tenfile, FileMode.Open, System.IO.FileAccess.Read))
                {
                    dsSP = (List<CHangHoa>)bin.Deserialize(reader);
                    return true;
                }
            }
            return false;
        }
      
    }
}
