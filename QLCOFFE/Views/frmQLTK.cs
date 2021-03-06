using DevExpress.XtraEditors;
using QLCOFFE.BUS;
using QLCOFFE.DAO;
using QLCOFFE.DTO;
using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCOFFE.Views
{
    public partial class frmQLTK : Form
    {
        NhanVienBUS nhanVienBUS = new NhanVienBUS();
        public frmQLTK()
        {
            InitializeComponent();
            Loadlist();
        }

        private void frmNhanSu_Load(object sender, EventArgs e)
        {

        }
        void Loadlist()
        {
            gridControl1.DataSource = new StaffDAO().FindAll();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Staff nv = new Staff();

            for (int i = 0; i < gridView1.RowCount; i++)
            {


                nv.MaNV = Convert.ToString(gridView1.GetRowCellValue(i, "MANV").ToString());
                nv.TenNV = gridView1.GetRowCellValue(i, "TENNV").ToString();
                nv.GioiTinh = gridView1.GetRowCellValue(i, "GIOITINH").ToString();
                nv.ChucVu = gridView1.GetRowCellValue(i, "CHUCVU").ToString();
                nv.DiaChi = gridView1.GetRowCellValue(i, "DIACHI").ToString();
                nv.SDT = Convert.ToInt32(gridView1.GetRowCellValue(i, "SDT").ToString());
                nv.TenDangNhap = gridView1.GetRowCellValue(i, "TENDANGNHAP").ToString();
                nv.MatKhau = gridView1.GetRowCellValue(i, "MATKHAU").ToString();


                nhanVienBUS.Update1(nv);



            }


            XtraMessageBox.Show("Sửa thành công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);



            frmNhanSu_Load(sender, e);
        }
      
     

        private void btnencry_Click_1(object sender, EventArgs e)
        {
            string inputText = textBox1.Text;
            var calculateHash = EasyEncryption.MD5.ComputeMD5Hash(inputText);
            textBox3.Text = calculateHash;

        }
    }
    }
