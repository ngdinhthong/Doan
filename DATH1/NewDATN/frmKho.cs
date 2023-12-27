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
    public partial class frmKho : Form
        
    {
        public string Message { get; set; }
        public List<CHangHoa>dsHH = new List<CHangHoa>();
        public ListHH ds= new ListHH();
        public List<CHangHoa> DataList { get => dsHH; }
        public List<CHangHoa> a = new List<CHangHoa>();
        public bool ghiFile(string tenfile)
        {
            using (Stream file = File.Open("HangHoa.txt", FileMode.Create))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(file, dsHH);
                return true;
            }

        }

        private void ghiFileHangHoa()
        {
            try
            {
                FileStream fs = new FileStream("HangHoa.txt", FileMode.Create);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, dsHH);
                fs.Close();

            }
            catch
            {
                MessageBox.Show("Thất bại");
            }

        }
        public frmKho()
        {
            InitializeComponent();
            

        }
        public void hienthi()
        {
            dgvKho.DataSource = dsHH.ToList();
        }
        public void hienthiKho()
        {
            dgvKho.DataSource = ds.getAll().ToList();
        }
        public void newhienthiKho(List<CHangHoa>a)
        {
            dgvKho.DataSource = a.ToList();
        }
        public CHangHoa timKho(string ma)
        {
            foreach (CHangHoa n in ds.getAll())
            {
                if (n.MaSP == ma)
                    return n;
            }
            return null;
         }

            private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void frmKho_Load(object sender, EventArgs e)
        {
            lblTest.Text = Message;
            FileStream fs = new FileStream("HangHoa.txt", FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            dsHH = bf.Deserialize(fs) as List<CHangHoa>;

            if (dsHH != null) {
                
                hienthi();
            }
            else
            {
                hienthi();
                MessageBox.Show("loiii");
            }
            fs.Close();

            foreach(DataGridViewRow r in dgvKho.Rows)
            {
                int index = 0;
                if (r.Cells[3].Value.ToString() == "0")
                {
                    index = r.Cells[0].RowIndex;
                    dsHH.RemoveAt(index);
                }
            }
            ghiFileHangHoa();
            hienthi();
        }

        private void dgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvNhanVien_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            CHangHoa n = new CHangHoa();
            txtMaKho.Text = dgvKho.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtKho.Text = dgvKho.Rows[e.RowIndex].Cells[1].Value.ToString();
            string size = dgvKho.Rows[e.RowIndex].Cells[2].Value.ToString();
            if (size == "S")
            {
                radS.Checked = true;
            }
            else if (size == "M")
            {
                radM.Checked = true;
            }
            else if (size == "L")
            {
                radL.Checked = true;
            }
            else if (size == "XL")
            {
                radXL.Checked = true;
            }
            else
                radXXL.Checked = true;
            ///*c/*lb*/Size.Text = dgvKho.Rows[e.RowIndex].Cells[2].Value.ToString();*/
            txtSL.Text = dgvKho.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtDonGia.Text = dgvKho.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            CHangHoa n = new CHangHoa();
            n.MaSP = txtMaKho.Text;
            n.TenSP = txtKho.Text;
            
            //n.Size= clbSize.Text;
            if (radS.Checked == true)
            {
                n.Size = "S";
            }
            else if (radM.Checked == true)
            {
                n.Size = "M";
            }
            else if (radL.Checked == true)
            {
                n.Size = "L";
            }
            else if (radXL.Checked == true)
            {
                n.Size = "XL";
            }
            else
                n.Size = radXXL.Text;
            n.SoLuong = txtSL.Text;
            n.DonGia=txtDonGia.Text;
            if (timKho(n.MaSP) == null)
            {
                dsHH.Add(n);
                //ds.Add(n);
                hienthi();
            }
            else
                MessageBox.Show("Mã sản phẩm  " + n.MaSP + " đã tồn tại.");
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream("HangHoa.txt", FileMode.Create);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, dsHH);
                fs.Close();
                MessageBox.Show("Thành công");
            }
            catch
            {
                MessageBox.Show("Thất bại");
            }
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            if (dgvKho.SelectedRows.Count > 0)
            {
                int index = dgvKho.SelectedRows[0].Index;
                dsHH.RemoveAt(index);
                hienthi();
            }
            else
            {
                MessageBox.Show("Chua chon ô dư liệu cần xóa");
            }
            
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            CHangHoa n = timKho(txtMaKho.Text);
            if (n == null)
            {
                MessageBox.Show("Khong tim thay");

            }
            else
            {
                n.TenSP = txtKho.Text;
                //n.Size = clbSize.Text;
                if (radS.Checked == true)
                {
                    n.Size = radS.Text;
                }
                else if (radM.Checked == true)
                {
                    n.Size = radM.Text;
                }
                else if (radL.Checked == true)
                {
                    n.Size = radL.Text;
                }
                else if (radXL.Checked == true)
                {
                    n.Size = radXL.Text;
                }
                else
                    n.Size = radXXL.Text;
                n.SoLuong =txtSL.Text;
                n.DonGia=txtDonGia.Text;
                hienthiKho();
            }
        }

       
        

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmKho_FormClosing(object sender, FormClosingEventArgs e)
        {
          
        }

        private void frmKho_FormClosed(object sender, FormClosedEventArgs e)
        {
        
        }
    }
}
