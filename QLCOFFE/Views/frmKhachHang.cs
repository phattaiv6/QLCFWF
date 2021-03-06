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
using QLCOFFE.DTO;
using QLCOFFE.BUS;
using QLCOFFE.EF;
using System.Text.RegularExpressions;

namespace QLCOFFE.Views
{
    public partial class frmKhachHang : DevExpress.XtraEditors.XtraForm
    {
        KhachHangBUS khachHangBUS = new KhachHangBUS();
        public frmKhachHang()
        {
            InitializeComponent();
            Loadlist();
        }

        private void KhachHang_Load(object sender, EventArgs e)
        {
     
            Loadlist();
           
            HamTuTang();


        }
        void Loadlist()
        {
            gridControl1.DataSource = new UserDAO().FindAll();

          
        }
      

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            try
            {
                HamTuTang();
                
                User user = new User();

                user.MaKH = txtIKhachHang.Text;
                user.TenKH = txtTenKH.Text;
                user.DiaChi = txtDiaChiKH.Text;
                user.MaLKH = "1";
                user.TenLKH = txtTenLoai.Text;
                user.SDT = Convert.ToInt32(txtDienThoaiKH.Text);
                user.DiemTL = Convert.ToInt32(txtDiem.Text);
                user.TrangThai = "1";

                if (kiemtratontai() == false)
               {
                    txtDienThoaiKH_EditValueChanged(sender, e);
                    if (khachHangBUS.Insert(user))
                    {

                        XtraMessageBox.Show("Thêm thành công", "THÔNG BÁO  ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtTenKH.Text = "";

                        txtTT.Text = "";
                        txtDiaChiKH.Text = "";
                        txtDiem.Text = "";
                        txtDienThoaiKH.Text = "";

                        lblT.Text = "";
                        lblF.Text = "";
                        btnThemMoi.Show();
                    }
                }
                else
                {
                    XtraMessageBox.Show("Thêm thất bại", "THÔNG BÁO  ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                KhachHang_Load(sender, e);
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Thêm thất bại", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            }

            private void btnSua_Click(object sender, EventArgs e)
        {
             User  user = new User();
            
            for (int i = 0; i < gridView1.RowCount; i++)
            {

               
                user.MaKH = Convert.ToString(gridView1.GetRowCellValue(i, "MAKH").ToString());
                user.TenKH = gridView1.GetRowCellValue(i, "TENKH").ToString();
                user.DiaChi = gridView1.GetRowCellValue(i, "DIACHI").ToString();
                user.MaLKH = gridView1.GetRowCellValue(i, "MALKH").ToString();
                user.TenLKH = gridView1.GetRowCellValue(i, "TENLKH").ToString();
                user.SDT = Convert.ToInt32(gridView1.GetRowCellValue(i, "SDT").ToString());
                user.DiemTL = Convert.ToInt32(gridView1.GetRowCellValue(i, "DIEMTL").ToString());



                khachHangBUS.Update(user);



            }
            if (khachHangBUS.Update(user))
            {

                XtraMessageBox.Show("Sửa thành công", "THÔNG BÁO  ", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
            }
            else
            {
                XtraMessageBox.Show("Sửa thất bại", "THÔNG BÁO  ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            KhachHang_Load(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
             
            DialogResult dr = XtraMessageBox.Show("Bạn có chắc muốn xóa không ?", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                //khởi tạo đối tượng nhân viên
                KHACHHANG user = new KHACHHANG();
                //lấy mã nhân viên từ gridView1 của devexpress, lưu ý các bạn nhớ viết name của trường cần lấy phải đúng như 
                //trong csdl nhé
                user.MAKH = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MAKH").ToString());
                //thực hienj hàm xóa 
                new UserDAO().delete(user);
                gridControl1.RefreshDataSource();
                XtraMessageBox.Show("Xóa thành công", "THÔNG BÁO  ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                KhachHang_Load(sender, e);

            }
        }

        private void btnQLMain_Click(object sender, EventArgs e)
        {
            txtTenKH.Text = "";
           
            txtTT.Text = "";
            txtDiaChiKH.Text = "";
            txtDiem.Text = "";
            txtDienThoaiKH.Text = "";
            
            lblT.Text = "";
            lblF.Text = "";
            btnThemMoi.Show();
        }
        public void HamTuTang()
        {
            int count = khachHangBUS.DemSLKH();
            string newMANV = string.Format("KH00{0}", ++count);
            txtIKhachHang.Text = newMANV;

        }
        private bool kiemtratontai()
        {

            string SDT = txtDienThoaiKH.Text;

            return UserDAO.Instance.KT(SDT);



        }

       

        private void txtDienThoaiKH_EditValueChanged(object sender, EventArgs e)
        {
            string no = txtDienThoaiKH.Text;
            Regex regex = new Regex(@"^(^[0][1-9]\d{8}$)+$");
            Match match = regex.Match(no);
            if (match.Success)
            {
                lblT.ForeColor = Color.Green;
                lblT.Text = "*";
                lblF.Text = "";
                btnThemMoi.Show();

            }
            else
            {
                lblF.ForeColor = Color.Red;
                lblF.Text = "Số điện thoại sai định dạng";
                lblT.Text = "";
                btnThemMoi.Hide();
            }
        }

        private void txtDienThoaiKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 56)
            {
                e.Handled = true;
            }
        }
    }
}