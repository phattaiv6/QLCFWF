using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QLCOFFE.DAO;
using DevExpress.XtraGrid.Views.Grid;
using System.Data.SqlClient;
using QLCOFFE.BUS;
using QLCOFFE.DTO;

using DevExpress.XtraEditors.Mask;
using System.Text.RegularExpressions;
using System.Configuration;

namespace QLCOFFE.Views
{
    public partial class frmNhanVien : DevExpress.XtraEditors.XtraForm
    {
        NhanVienBUS nhanVienBUS = new NhanVienBUS();

        public frmNhanVien()
        {
            InitializeComponent();
            Loadlist();
           
        }
        void Loadlist()
        {
           
            gridControl1.DataSource = new StaffDAO().FindAll();

            

          
            txtThuoctinh.Text = "1";
            txtThuoctinh.Hide();
            txtTrangThai.Hide();

            

        }


       
        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            
            Loadlist();
          
            HamTuTang();

        }
    

      

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            
            try
            {
                HamTuTang();
                
                Staff nv = new Staff();
                string MHMK = frmDangNhap.MD5Hash(txtMK.Text);
                nv.TenNV = txtTen.Text;
                nv.GioiTinh = cmbGioiTinhNV.Text;
                nv.ChucVu = txtChucVu.Text;
                nv.DiaChi = txtDiaChiNV.Text;
                nv.SDT = Convert.ToInt32(txtDienThoaiNV.Text);
                nv.MaNV = txtIdNhanVien.Text;
                nv.TenDangNhap = txtTK.Text;
                nv.MatKhau = MHMK;
                nv.TrangThai = "1";
                txtTrangThai.Text = "1";
                if (txtMK.Text == "")
                {
                    nv.MatKhau = "c4ca4238a0b923820dcc509a6f75849b";
                }




                if ((kiemtratontai() || kiemtratontaiDN()) == false)
                {
                    txtDienThoaiNV_EditValueChanged_1(sender, e);
                    txtTK_EditValueChanged(sender, e);



                    if (nhanVienBUS.Insert(nv))
                    {

                        XtraMessageBox.Show("Thêm thành công", "THÔNG BÁO  ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtTen.Text = "";
                        txtChucVu.Text = "";
                        txtDiaChiNV.Text = "";
                        txtDienThoaiNV.Text = "";
                        txtTK.Text = "";
                        txtMK.Text = "";
                        btnThemMoi.Show();
                        lblphones.Text = "";
                        labphonex.Text = "";
                        labgioitinh.Text = "";
                        labmk.Text = "";
                        labtk.Text = "";
                        labchucvu.Text = "";
                    }

                }
                else
                {
                    XtraMessageBox.Show("Thêm thất bại", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnThemMoi.Show();
                }

                frmNhanVien_Load(sender, e);
            }

            catch (Exception)
            {
                XtraMessageBox.Show("Thêm thất bại", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                
                btnThemMoi.Show();


            }
        }

    

        private void btnSua_Click(object sender, EventArgs e)
        { 
            Staff nv = new Staff();
            
            for (int i = 0; i < gridView1.RowCount; i++)
            {

                txtTrangThai.Text = "1";
                nv.MaNV = Convert.ToString(gridView1.GetRowCellValue(i, "MANV").ToString());
                nv.TenNV = gridView1.GetRowCellValue(i, "TENNV").ToString();
                nv.GioiTinh = gridView1.GetRowCellValue(i, "GIOITINH").ToString();
                nv.ChucVu = gridView1.GetRowCellValue(i, "CHUCVU").ToString();
                nv.DiaChi = gridView1.GetRowCellValue(i, "DIACHI").ToString();
                nv.SDT = Convert.ToInt32(gridView1.GetRowCellValue(i, "SDT").ToString());
                nv.TenDangNhap = gridView1.GetRowCellValue(i, "TENDANGNHAP").ToString();
               


                nhanVienBUS.Update(nv);



            }

            
                XtraMessageBox.Show("Sửa thành công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
                   

            frmNhanVien_Load(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //sự kiện click xóa
            DialogResult dr = XtraMessageBox.Show("Bạn có chắc muốn xóa không ?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                //khởi tạo đối tượng nhân viên
                NHANVIEN nv = new NHANVIEN();
                //lấy mã nhân viên từ gridView1 của devexpress, lưu ý các bạn nhớ viết name của trường cần lấy phải đúng như 
                //trong csdl nhé
                nv.MANV = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MANV").ToString());
                //thực hienj hàm xóa 
                new StaffDAO().delete(nv);
                gridControl1.RefreshDataSource();
                XtraMessageBox.Show("Xóa thành công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmNhanVien_Load(sender, e);

            }
        }

        private void btnQLMain_Click(object sender, EventArgs e)
        {
            txtTen.Text = "";
            cmbGioiTinhNV.Text = "";
            txtChucVu.Text = "";
            txtDiaChiNV.Text = "";
            txtDienThoaiNV.Text = "";
            
            txtTK.Text = "";
            txtMK.Text = "";
            lblphones.Text = "";
            labchucvu.Text = "";
            labdiachi.Text = "";
            labdt.Text = "";
            labtk.Text = "";
            labmk.Text = "";
            labten.Text = "";
            btnThemMoi.Enabled = true;
            btnThemMoi.Show();
        }

     
        //hàm tự tăng mã nhân viên
        public void HamTuTang()
         {

            int count = nhanVienBUS.DemSLNV();
            string newMANV = string.Format("NV00{0}", ++count);
            txtIdNhanVien.Text = newMANV;
            

        }

      
        private bool kiemtratontai()
        {
         
            string SDT = txtDienThoaiNV.Text;
          
          return  StaffDAO.Instance.KT(SDT);

           
       
        }
        private bool kiemtratontaiDN()
        {

            string DN = txtTK.Text;
            return StaffDAO.Instance.KTTK(DN);

        }


        private void txtDienThoaiNV_EditValueChanged_1(object sender, EventArgs e)
        {
            string tk = txtTK.Text;
            string no = txtDienThoaiNV.Text;
          
            Regex regex = new Regex(@"^(^[0][1-9]\d{8}$)+$");
            Match match = regex.Match(no);
            Regex regext = new Regex("^[a-zA-Z0-9]+$");
            Match matcht = regext.Match(tk);




            if (match.Success && matcht.Success)
            {                          
                labtk.ForeColor = Color.Green;
                labtk.Text = "*";
                lblphones.ForeColor = Color.Green;
                lblphones.Text = "Số điện thoại đúng định dạng";              
                btnThemMoi.Show();
                
            }
            else if(match.Success)
            {
                lblphones.ForeColor = Color.Green;
                lblphones.Text = "Số điện thoại đúng định dạng";
            }
            else if(matcht.Success)
            {
                labtk.ForeColor = Color.Green;
                labtk.Text = "*";
            }
          
            else  
            {
               
                labtk.ForeColor = Color.Red;
                labtk.Text = "Không đc để trống";
              
                lblphones.ForeColor = Color.Red;
                lblphones.Text = "Số điện thoại sai định dạng";
               
                btnThemMoi.Hide();
            }

        }

        private void txtDienThoaiNV_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 56)
            {
                e.Handled = true;
            }
        }
       

     
       

        private void txtTK_EditValueChanged(object sender, EventArgs e)
        {
            string no = txtTK.Text;
            Regex regex = new Regex("^[a-zA-Z0-9]+$");
            Match match = regex.Match(no);

            if (txtTK.Text == "") btnThemMoi.Hide();
            if (txtMK.Text == "") btnThemMoi.Hide();
            if (match.Success)
            {
                labtk.ForeColor = Color.Green;
                labtk.Text = "*";


                btnThemMoi.Show();

            }
            else
            {

                btnThemMoi.Hide();
                labtk.ForeColor = Color.Red;
                labtk.Text = "Không đc để trống";

            }
        }
    }
}
