using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace NewDATN
{
    
    public partial class frmChinh : Form
    {
        
        
        public frmChinh()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)

        {
            this.Hide();
            frmNhanVien f = new frmNhanVien();
            f.ShowDialog();
            f = null;
            this.Show();
            
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin frmLogin = new frmLogin();
            frmLogin.ShowDialog();
            frmLogin = null;
            this.Show();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void frmChinh_Load(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void checkedListBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
        }
    }
}
