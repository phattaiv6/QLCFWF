using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLCOFFE.DAO;
using QLCOFFE.BUS;

using QLCOFFE.EF;
using DevExpress.XtraEditors;
using QLCOFFE.DTO;


namespace QLCOFFE.Views
{
    public partial class frmDanhSachTD : Form
    {
        ThucDonBUS ThucDonBUS = new ThucDonBUS();
        public frmDanhSachTD()
        {
            InitializeComponent();
        }

        private void frmDanhSachTD_Load(object sender, EventArgs e)
        {
            LoadList(); loadcontrol(cmbTenLTD);
        }

        void LoadList()
        {
            gridControl1.DataSource = new MenuDAO().FindAll();
            HamTuTang();


        }
        public void HamTuTang()
        {

            int count = ThucDonBUS.DemSLTD();
            count++;
            //string newMANV = string.Format("NV00{0}", ++count);
           txtIdTD.Text = count.ToString();

        }
        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            try
            {
                
                MenuFood menu = new MenuFood();
                int MaLH = (cmbTenLTD.SelectedItem as Category).MaLH;
                menu.GiaBan = (int)cmGia.Value;
                menu.TenHH = txtTenTD.Text;
              
                menu.MaLH = MaLH;

               

                    if (ThucDonBUS.Insert(menu))
                {

                    XtraMessageBox.Show("Thêm thành công", "THÔNG BÁO  ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTenTD.Text = "";
                    cmGia.Text = "";
                    cmbTenLTD.Text = "";
                    
                }
                else
                {
                    XtraMessageBox.Show("Thêm thất bại", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                }

                frmDanhSachTD_Load(sender, e);
            }

            catch (Exception)
            {
                XtraMessageBox.Show("Thêm thất bại", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (string.IsNullOrEmpty(txtTenTD.Text) && string.IsNullOrEmpty(cmGia.Text) && string.IsNullOrEmpty(cmbTenLTD.Text))
                {
                    XtraMessageBox.Show("Chưa nhập đầy đủ thông tin", "THÔNG BÁO  ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    labgia.ForeColor = Color.Red;
                    labelx.ForeColor = Color.Red;
                    labelx.Text = "Không được để trống";
                    labgia.Text = "Không được để trống";
                }
                else if (string.IsNullOrEmpty(txtTenTD.Text))
                {
                    XtraMessageBox.Show("Chưa nhập đầy đủ thông tin", "THÔNG BÁO  ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    labgia.ForeColor = Color.Red;
                    labelx.ForeColor = Color.Red;
                    labelx.Text = "Không được để trống";
                    labgia.Text = "";
                }
                else if (string.IsNullOrEmpty(cmGia.Text))
                {
                    XtraMessageBox.Show("Chưa nhập đầy đủ thông tin", "THÔNG BÁO  ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    labgia.ForeColor = Color.Red;
                    labelx.ForeColor = Color.Red;
                    labelx.Text = "";
                    labgia.Text = "Không được để trống";
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            MenuFood menu = new MenuFood();

            for (int i = 0; i < gridView1.RowCount; i++)
            {


                menu.MaLH = Convert.ToInt32(gridView1.GetRowCellValue(i, "MALH").ToString());
                menu.TenHH = gridView1.GetRowCellValue(i, "TENHH").ToString();
                menu.GiaBan = Convert.ToInt32(gridView1.GetRowCellValue(i, "GIASP"));
                menu.MaHH = Convert.ToInt32(gridView1.GetRowCellValue(i, "MAHH").ToString());



                ThucDonBUS.Update(menu);



            }


            XtraMessageBox.Show("Sửa thành công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);



            frmDanhSachTD_Load(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = XtraMessageBox.Show("bạn có chắc muốn xóa không ?", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                //khởi tạo đối tượng nhân viên
                HANGHOA menu = new HANGHOA();
                //lấy mã nhân viên từ gridView1 của devexpress, lưu ý các bạn nhớ viết name của trường cần lấy phải đúng như 
                //trong csdl nhé
                menu.MAHH = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MAHH").ToString());
                //thực hienj hàm xóa 
                new MenuDAO().delete(menu);
                gridControl1.RefreshDataSource();
                XtraMessageBox.Show("Xóa thành công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmDanhSachTD_Load(sender, e);
            }
        }

        private void cmbTenLTD_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        void loadcontrol(System.Windows.Forms.ComboBox cb)
        {
            cb.DataSource = CategoryDAO.Instance.GetListCategory();
            cb.DisplayMember = "TENLH";

        }
        private void cmbTenLTD_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}


