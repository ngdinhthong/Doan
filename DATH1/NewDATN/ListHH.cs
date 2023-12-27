using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewDATN
{
    [Serializable]
   public class ListHH
    {
        private List<CHangHoa> listHH = new List<CHangHoa>();
        public void create(CHangHoa entiny)
        {
            listHH.Add(entiny);
        }

        public void delete(CHangHoa id)
        {
            listHH.Remove(id);
        }

        public List<CHangHoa> getAll()
        {
            return listHH;
        }

        public List<CHangHoa> setAll
        {
            set { listHH = value; }

        }
    }
}
