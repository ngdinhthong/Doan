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

namespace NewDATN
{
    public partial class frmLichSu : Form
    {
        public frmLichSu()
        {
            InitializeComponent();
        }
        PhieuThanhToan a;
        private List<LichSuThanhToan> listLS = new List<LichSuThanhToan>();
        private void dgvHangHoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void hienThi()
        {
            dgvLichSu.DataSource = listLS.ToList();
        }
        private void frmLichSu_Load(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream("LichSu.txt", FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                listLS = bf.Deserialize(fs) as List<LichSuThanhToan>;
                fs.Close();
                hienThi();

            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
