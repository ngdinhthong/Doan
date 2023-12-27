using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewDATN
{
    [Serializable]
    public class CMaPhieu
    {
        private string m_ma;

        public string MaPhieu
        {
            get { return m_ma; }
            set { m_ma = value; }
        }   
    }
}
