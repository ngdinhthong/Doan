using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewDATN
{
    [Serializable]
    public class CListMaPhieu
    {
        private List<CMaPhieu> listMP =new List<CMaPhieu>();

        public void create(CMaPhieu entiny)
        {
            listMP.Add(entiny);
        }

        public void delete(CMaPhieu ma)
        {
            listMP.Remove(ma);
        }

        public List<CMaPhieu> getAll()
        {
            return listMP;
        }

        public List<CMaPhieu> SetAll
        {
            set { listMP = value; }

        }
    }
}
