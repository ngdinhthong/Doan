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
using System.Xml.Linq;

namespace NewDATN
{
    [Serializable]
    public partial class frmCuaHang : Form
    {

        CHangHoa hh;
        CSanPham SP;
        public string Message { get; set; }
        public List<CHangHoa> ReceivedDataList { get; set; }
        public List<CHangHoa>a=new List<CHangHoa>();
        public List<PhieuThanhToan>phieuthanhtoan=new List<PhieuThanhToan>();

        public ListHH hanghoa = new ListHH();
        public CDanhSachNhanVien ds1 = new CDanhSachNhanVien();
        public CListMaPhieu listmaphieu = new CListMaPhieu();

        private List<LichSuThanhToan> listLS = new List<LichSuThanhToan>();

        private List<CHangHoa> hangHoaTam = new List<CHangHoa>();
        private List<CHangHoa> ListLoad = new List<CHangHoa>();

        public frmCuaHang()
        {
            InitializeComponent();
            ListLoad = new List<CHangHoa>();
        }
        
        public void  xoaKhiClick(int index)
        {
            phieuthanhtoan.RemoveAt(index);
        }
        public void xoaDataGridKhiThanhToan(int index)
        {
            phieuthanhtoan = null;
        }



        public void hienDS()
        {
            dgvHangHoa.DataSource = ListLoad.ToList();

        }
        public void luufileLichSu()
        {
            try
            {
                FileStream fs = new FileStream("LichSu.txt", FileMode.Create);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, listLS);
                fs.Close();
                //MessageBox.Show("Thành công");
            }
            catch
            {
                MessageBox.Show("Thất bại");
            }

        }
        public void newHienThi(List<CHangHoa>a)
        {
            dgvHangHoa.DataSource = a.ToList();
        }
        public void hienThiPhieu(List<PhieuThanhToan> a)
        {
            dgvHangHoa.DataSource = a.ToList();
        }
        public void hienthiPhieuNull()
        {
            List<PhieuThanhToan> b = new List<PhieuThanhToan>();
            dgvHangHoa.DataSource = b.ToList();
        }
        private void docFileHangHoa(string tenFile,List<CHangHoa>a)
        {
            try
            {
                FileStream fs = new FileStream(tenFile, FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                a = bf.Deserialize(fs) as List<CHangHoa>;
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ghiFileHangHoa()
        {  
            try
            {
                FileStream fs = new FileStream("HangHoa.txt", FileMode.Create);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, hangHoaTam);
                fs.Close();
                
            }
            catch
            {
                MessageBox.Show("Thất bại");
            }

        }

        public void handleHangHoa()
        {
            docFileHangHoa("HangHoa.txt",hangHoaTam);

            foreach (PhieuThanhToan a in phieuthanhtoan)
            {
                foreach (CHangHoa item in hangHoaTam)
                {
                    if (a.MaSP == item.MaSP)
                    {
                        int soluongCanTru = int.Parse(a.SoLuong);
                        int soLuongGoc = int.Parse(item.SoLuong);
                        int soluongMoi = soLuongGoc - soluongCanTru;
                        item.SoLuong = soluongMoi.ToString();
                    }
                }
            }
            
            ghiFileHangHoa();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            // Xử lí cóa dữ liệu được thêm vào từ hàng hóa thanh toán trừ ra trong listhanghoa
            
            handleHangHoa();
            // phần xử lí lịch sử thnah toán
            string maDon = GenerateRandomCode();

            foreach(PhieuThanhToan item in phieuthanhtoan)
            {
                LichSuThanhToan a = new LichSuThanhToan();
                a.MaDon = maDon;
                a.NgayThanhToan = item.NgayThanhToan;
                a.MaSP = item.MaSP;
                a.TenNV = item.TenNV;
                a.DonGia = item.DonGia;
                a.TenSP = item.TenSP;   
                a.Size = item.Size;
                a.SoLuong = item.SoLuong;
                a.GiaTien = item.GiaTien;
                listLS.Add(a);
                luufileLichSu();
            }





            //////////////
            frmKho kho = new frmKho();
            int count = dgvHangHoa.RowCount;
            //MessageBox.Show(count + "");
            if (count != -1)
            {
                
                for (int i = 0; i < count; i++)
                {
                    phieuthanhtoan.RemoveAt(0);
                }
            }
            else
            {
                MessageBox.Show("Khong co du lieu de thanh toan");
            }
            if (MessageBox.Show("Bạn có muốn thanh toán không?", "Thông báo",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                            DialogResult.Yes)
            {
                MessageBox.Show("Đã thanh toán thành công");
                //kho.ghiFile("HangHoa.txt");
                
                hienthiPhieuNull();
               

            }
            // Xử lí khi cbo mã khi sản phẩm ko còn số lượng
            foreach (CHangHoa item in hangHoaTam)
            {
                if(item.SoLuong == "")
                {
                    cboMa.Items.Add(item.MaSP);
                }
            }
            

        }
        static string GenerateRandomCode()
        {
            Random random = new Random();
            List<int> digits = new List<int>();

            // Tạo 6 chữ số không trùng nhau
            for (int i = 0; i < 6; i++)
            {
                int digit;
                do
                {
                    digit = random.Next(10); // Tạo một số ngẫu nhiên từ 0 đến 9
                } while (digits.Contains(digit));

                digits.Add(digit);
            }

            // Chuyển danh sách chữ số thành chuỗi
            string randomCode = string.Join("", digits);

            return randomCode;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmKho k = new frmKho();
            PhieuThanhToan phieu = new PhieuThanhToan();
            string cbo = cboMa.SelectedItem.ToString();
            // Xử lí xóa cbo khi số lượng còn 0
            //foreach (CHangHoa item in hangHoaTam)
            //{
            //    if (item.SoLuong == "")
            //    {
            //        cboMa.Items.Remove(item.MaSP);
            //    }
            //}

            //MessageBox.Show(cboMa.SelectedItem.ToString());
            foreach (CHangHoa hh in ListLoad)
            {
                if (hh.ToString() == cbo)
                {
                    int tamA = int.Parse(hh.SoLuong);
                    int tamB = int.Parse(txtSoLuong.Text);
                    //MessageBox.Show(int.Parse(txtSL.Text).ToString());
                    if (tamA < tamB)
                    {
                        MessageBox.Show("Số lượng nhập vào vượt quá số lượng trong kho! Vui lòng kiểm tra lại.");
                    }
                    else
                    {

                        int tamC = tamA - tamB;
                        hh.SoLuong = tamC + "";
                        if(hh.SoLuong=="0")
                            a.Remove(hh);
                        a.Add(hh);

                        //thêm vào phiếu
                        // kiểm tra list mã phiếu mà thêm vào list để đảm bảo ko bị trùng mã phiếu
                        string maphieu = GenerateRandomCode();
                        string newmaphieu = "";
                        if(listmaphieu.getAll() != null)
                        {
                            CMaPhieu a = new CMaPhieu();
                            a.MaPhieu = maphieu;
                            listmaphieu.create(a);
                            
                        }
                        else
                        {
                            foreach(CMaPhieu mp in listmaphieu.getAll())
                            {
                                if(maphieu == mp.MaPhieu)
                                {
                                    newmaphieu = GenerateRandomCode();
                                }
                            }
                            CMaPhieu a = new CMaPhieu();
                            a.MaPhieu = newmaphieu;
                            listmaphieu.create(a);
                            
                        }

                        phieu.TenSP = hh.TenSP;
                        phieu.MaSP = hh.MaSP;
                        phieu.SoLuong = tamB + "";
                        phieu.Size = hh.Size;
                        phieu.TenNV = lblTenNhanVienLogin.Text;
                        phieu.DonGia = hh.DonGia;

                        double tien = 0.0;
                        double dg = double.Parse(phieu.DonGia);
                        int sl = int.Parse(phieu.SoLuong);
                        tien = (double)dg * sl;
                        phieu.GiaTien = tien;

                        phieuthanhtoan.Add(phieu);
                        lblSoLuongConLai.Text = tamC.ToString();
                        txtSoLuong.Clear();
                        hienThiPhieu(phieuthanhtoan);
                    }
                }
            }
            
            
            k.newhienthiKho(ListLoad);
        }


            private void txtTenSP_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void frmCuaHang_Load(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream("HangHoa.txt", FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                ListLoad = bf.Deserialize(fs) as List<CHangHoa>;
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            foreach (CHangHoa data in ListLoad)
            {
                // Xử lý dữ liệu nhận được ở đây (ví dụ: hiển thị trong ListBox)
                cboMa.Items.Add(data.MaSP.ToString());
            }
        }



        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cbo = cboMa.SelectedItem.ToString();
            foreach (CHangHoa hh in ListLoad)
            {
                if (hh.ToString() == cbo)
                {
                    lblSoLuongConLai.Text = hh.SoLuong.ToString();
                }
            }
        }

        private void txtSize_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvHangHoa_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
        
        }

        private void frmCuaHang_FormClosing(object sender, FormClosingEventArgs e)
        {
          
        }

        private void btnKho_Click(object sender, EventArgs e)
        {

            frmKho k=new frmKho();
            k.ShowDialog();
        }

        private void lblTenNhanVienLogin_Click(object sender, EventArgs e)
        {

        }

        private void dgvHangHoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnLichSu_Click(object sender, EventArgs e)
        {
            frmLichSu frmLichSu = new frmLichSu();
            frmLichSu.ShowDialog(); 
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            
            if (dgvHangHoa.SelectedRows.Count > 0) {
                
                // xử lí trả lại dữ liệu khi xóa 
                int value = int.Parse(dgvHangHoa.SelectedRows[0].Cells[6].Value.ToString());
                int soluong =int.Parse(lblSoLuongConLai.Text);
                int newSoluong = soluong + value;
                lblSoLuongConLai.Text = newSoluong+"";
                string ma  = dgvHangHoa.SelectedRows[0].Cells[3].Value.ToString();

                // trả sữ liệu cho cbo
                //foreach (CHangHoa item in hangHoaTam)
                //{
                //    if(item.SoLuong == "")
                //    {
                //        cboMa.Items.Add(ma);
                //    }
                    
                //}
                //////////////////////////////// Xóa dữ liệu
                int index = dgvHangHoa.SelectedRows[0].Index;
                phieuthanhtoan.RemoveAt(index);
                hienThiPhieu(phieuthanhtoan);
                
            }

           
           
        }

        private void frmCuaHang_Load_1(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream("HangHoa.txt", FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                ListLoad = bf.Deserialize(fs) as List<CHangHoa>;
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            foreach (CHangHoa data in ListLoad)
            {
                // Xử lý dữ liệu nhận được ở đây (ví dụ: hiển thị trong ListBox)
               
                //cboMa.DisplayMember = "Text";
                //cboMa.ValueMember = "Value";
                //cboMa.Items.Add(new { Text = data.TenSP.ToString(), Value = data.MaSP.ToString() });
                cboMa.Items.Add(data);
            }
        }
    }
    } 
