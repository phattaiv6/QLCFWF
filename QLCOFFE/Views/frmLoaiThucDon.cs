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
using QLCOFFE.BUS;
using QLCOFFE.DTO;
using QLCOFFE.EF;
namespace QLCOFFE.Views
{
    public partial class frmLoaiThucDon : DevExpress.XtraEditors.XtraForm
    {
        LoaiHangHoaBUS LoaiHangHoaBUS = new LoaiHangHoaBUS();
        public frmLoaiThucDon()
        {
            InitializeComponent();
        }

        private void frmLoaiThucDon_Load(object sender, EventArgs e)
        {
            LoadList();
            HamTuTang();
        }
        public void HamTuTang()
        {

            int count = LoaiHangHoaBUS.DemSLTD();
            count++;
            //string newMANV = string.Format("NV00{0}", ++count);
            txtIdLTDon.Text = count.ToString();

        }
        void LoadList()
        {
            gridControl1.DataSource = new CategoryDAO().FindAll();
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            try
            {

                Category category = new Category();

                // table.MaBan = Convert.ToInt32(txtIdBan.Text);
                category.TenLH = txtTenLTDon.Text;
                category.MoTa = txtDienGiaiLTDon.Text;
                if (string.IsNullOrEmpty(txtTenLTDon.Text) && string.IsNullOrEmpty(txtDienGiaiLTDon.Text) )
                {
                    XtraMessageBox.Show("Chưa nhập đầy đủ thông tin", "THÔNG BÁO  ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    labs.ForeColor = Color.Red;
                    labx.ForeColor = Color.Red;
                    labs.Text = "Không được để trống";
                    labx.Text = "Không được để trống";

                }
                else if( string.IsNullOrEmpty(txtDienGiaiLTDon.Text))
                { 
                    XtraMessageBox.Show("Chưa nhập đầy đủ thông tin", "THÔNG BÁO  ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   // labs.ForeColor = Color.Red;
                    labx.ForeColor = Color.Red;
                  //  labs.Text = "Không được để trống";
                    labx.Text = "Không được để trống";
                    labs.Text = "";

                }
                else if (string.IsNullOrEmpty(txtTenLTDon.Text))
                {
                    XtraMessageBox.Show("Chưa nhập đầy đủ thông tin", "THÔNG BÁO  ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                      labs.ForeColor = Color.Red;
                    //labx.ForeColor = Color.Red;
                      labs.Text = "Không được để trống";
                    // labx.Text = "Không được để trống";
                    labx.Text = "";
                }
                else if (LoaiHangHoaBUS.Insert(category))
                {

                    XtraMessageBox.Show("Thêm thành công", "THÔNG BÁO  ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTenLTDon.Text = "";
                    txtDienGiaiLTDon.Text = "";
                    labs.Text = "";
                    labx.Text = "";
                }
                else
                {
                    XtraMessageBox.Show("Thêm thất bại", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                frmLoaiThucDon_Load(sender, e);
            }

            catch (Exception)
            {
                XtraMessageBox.Show("Thêm thất bại", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Category category = new Category();

            for (int i = 0; i < gridView1.RowCount; i++)
            {


                category.MaLH = Convert.ToInt32(gridView1.GetRowCellValue(i, "MALH").ToString());
                category.TenLH = gridView1.GetRowCellValue(i, "TENLH").ToString();
                category.MoTa = gridView1.GetRowCellValue(i, "MOTA").ToString();




                LoaiHangHoaBUS.Update(category);



            }


            XtraMessageBox.Show("Sửa thành công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);



            frmLoaiThucDon_Load(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = XtraMessageBox.Show("bạn có chắc muốn xóa không ?", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                //khởi tạo đối tượng nhân viên
                LOAIHANGHOA category = new LOAIHANGHOA();
                //lấy mã nhân viên từ gridView1 của devexpress, lưu ý các bạn nhớ viết name của trường cần lấy phải đúng như 
                //trong csdl nhé
                category.MALH = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MALH").ToString());
                //thực hienj hàm xóa 
                new CategoryDAO().delete(category);
                gridControl1.RefreshDataSource();
                XtraMessageBox.Show("Xóa thành công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmLoaiThucDon_Load(sender, e);
            }
        }

        private void txtTenLTDon_TextChanged(object sender, EventArgs e)
        {

        }
    }
 }
