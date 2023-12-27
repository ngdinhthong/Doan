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
    public partial class frmLogin : Form
    {
        public CDanhSachNhanVien ds1 = new CDanhSachNhanVien();
        public string Ten;
        public frmLogin()
        {
            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            
            int tam = 0;
            foreach(CNhanVien nv in ds1.getAll().Values)
            {
                if(txtLogin.Text == nv.MaNV)
                {
                    Ten = nv.TenNV;
                    tam = 1;
                    CgetTen.tenNV = Ten;
                }
                
            }
            
            if(tam == 1)
            {
                frmCuaHang frmCuaHang = new frmCuaHang();
                frmCuaHang.ShowDialog();
                //frmKho frmKho = new frmKho();
                //frmKho.Message = Ten;
                //frmKho.ShowDialog();
                //this.Close();
            }
            else
            {
                MessageBox.Show("Sai ma nhan vien!");
            }
            //if(txtLogin.Text == )
        }

        private void Login_Enter(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("NhanVien.txt", FileMode.OpenOrCreate);
            BinaryFormatter bf = new BinaryFormatter();
            ds1.SetAll = (Dictionary<string, CNhanVien>)bf.Deserialize(fs);
            fs.Close();
        }

        private void btnLoginKho_Click(object sender, EventArgs e)
        {
            int tam = 0;
            foreach (CNhanVien nv in ds1.getAll().Values)
            {
                if (txtLogin.Text == nv.MaNV)
                {
                    Ten = nv.TenNV;
                    tam = 1;
                    CgetTen.tenNV = Ten;
                }

            }

            if (tam == 1)
            {
                this.Hide();
                frmKho frmKho = new frmKho();
                frmKho.Message = Ten;
                frmKho.ShowDialog();
                frmKho = null;
                this.Show();
                
            }
            else
            {
                MessageBox.Show("Sai ma nhan vien!");
            }
            //if(txtLogin.Text == )
        }
    }
}
