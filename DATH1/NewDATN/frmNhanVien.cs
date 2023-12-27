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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NewDATN
{
    public partial class frmNhanVien : Form
    {
        public Dictionary<string, CNhanVien> ds = new Dictionary<string, CNhanVien>();
        public CDanhSachNhanVien ds1 = new CDanhSachNhanVien();
        

        public void hienThiDS()
        {
            dgvNhanVien.DataSource = ds.Values.ToList();
            //dgvNhanVien.DataSource = ds.getAll().Values.ToList();
        }
        public CNhanVien timNV(string ma)
        {
            foreach (string n in ds.Keys)
            {
                if (n == ma)
                    return ds[ma];
            }
            return null;
        }
        public CNhanVien timNVListNV(string ma)
        {
            foreach (string n in ds1.getAll().Keys)
            {
                if (n == ma)
                    return ds[ma];
            }
            return null;
        }

        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            CNhanVien id = new CNhanVien();
            id.MaNV = txtMa.Text;
            id.TenNV = txtNV.Text;
            id.NgaySinh = dtpNS.Value.Date;
            if (cbPhai.SelectedIndex == 0)
                id.Phai = "Nam";
            else
                id.Phai = "Nữ";
            id.ChucVu = txtChuc.Text;
            if (timNV(id.MaNV) == null)
            {
                ds.Add(id.MaNV, id);
                ds1.create(id.MaNV, id);
                hienThiDS();
            }
            else
                MessageBox.Show("Bị trùng Mã NV.");
            


        }

        private void dgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvNhanVien_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            CNhanVien n = new CNhanVien();

            txtMa.Text = dgvNhanVien.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNV.Text = dgvNhanVien.Rows[e.RowIndex].Cells[1].Value.ToString();
            dtpNS.Value = Convert.ToDateTime(dgvNhanVien.Rows[e.RowIndex].Cells[2].Value.ToString());
            if (cbPhai.SelectedIndex == 0)
            {
                n.Phai = "Nam";
            }
            else
                n.Phai = "Nữ";
            cbPhai.Text = dgvNhanVien.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtChuc.Text = dgvNhanVien.Rows[e.RowIndex].Cells[4].Value.ToString();


        }


        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("NhanVien.txt", FileMode.OpenOrCreate);
            BinaryFormatter bf = new BinaryFormatter();
            ds = (Dictionary<string, CNhanVien>)bf.Deserialize(fs);

            if (ds != null)
                hienThiDS();
            else
            {
                ds = new Dictionary<string, CNhanVien>();
                hienThiDS();
            }
            fs.Close();

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("NhanVien.txt", FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, ds);
            fs.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            CNhanVien n = timNV(txtMa.Text);
            CNhanVien m = timNVListNV(txtMa.Text);
            if (n == null)
            {
                MessageBox.Show("Khong tim thay");
            }
            else
            {
                
                n.TenNV = txtNV.Text;
                m.TenNV = txtNV.Text;

                n.NgaySinh = dtpNS.Value.Date;
                m.NgaySinh = dtpNS.Value.Date;
                if (cbPhai.SelectedIndex == 0)
                {
                    n.Phai = "Nam";
                    m.Phai = "Nam";
                }
                else
                {
                    n.Phai = "Nữ";
                    m.Phai = "Nữ";
                }
                n.ChucVu=txtChuc.Text;
                m.ChucVu=txtChuc.Text;
                hienThiDS();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            CNhanVien n = timNV(txtMa.Text);
            
            if (n == null)
            {
                MessageBox.Show("Khong tim thay");

            }
            else
            {
                CNhanVien m = timNVListNV(txtMa.Text);
                ds.Remove(n.MaNV);
                ds1.delete(n.MaNV);
                hienThiDS();
            }
        }
    }
}

