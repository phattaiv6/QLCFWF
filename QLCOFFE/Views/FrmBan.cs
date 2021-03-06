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
using QLCOFFE.BUS;
using QLCOFFE.DAO;
using QLCOFFE.DTO;
using QLCOFFE.EF;
using System.Text.RegularExpressions;

namespace QLCOFFE.Views
{
    public partial class FrmBan : DevExpress.XtraEditors.XtraForm
    {
        BanBus BanBus = new BanBus();
        public FrmBan()
        {
            InitializeComponent();

        }

        private void FrmBan_Load(object sender, EventArgs e)
        {
            Loadlist();
            HamTuTang();
            loadcontrol(cmbTenKhuVuc);
        }
        void loadcontrol(System.Windows.Forms.ComboBox cb)
        {
            cb.DataSource = ArenaDAO.Instance.LoadArenaList();
            cb.DisplayMember = "TenKV";

        }
        void Loadlist()
        {

            gridControl1.DataSource = new TableDAO().FindAll();




        }
        public void HamTuTang()
        {

            int count = BanBus.DemSLTD();
            count++;
            //string newMANV = string.Format("NV00{0}", ++count);
            txtIdBan.Text = count.ToString();

        }
        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            try
            {

                Table table = new Table();
                string MaKV = (cmbTenKhuVuc.SelectedItem as Arena).MaKV;
                
                table.TenBAn = txtTenBan.Text;
                table.MaKV = MaKV;
                table.TrangThai = "Bàn Trống";
                if (string.IsNullOrEmpty(txtTenBan.Text) && string.IsNullOrEmpty(cmbTenKhuVuc.Text )  )
                {
                    XtraMessageBox.Show("Chưa nhập đầy đủ thông tin", "THÔNG BÁO  ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    labs.ForeColor = Color.Red;
                    labx.ForeColor = Color.Red;
                    labs.Text = "Không được để trống";
                    labx.Text = "Không được để trống";
                    

                }
                else if(string.IsNullOrEmpty(txtTenBan.Text))
                {
                    XtraMessageBox.Show("Chưa nhập đầy đủ thông tin", "THÔNG BÁO  ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //labs.ForeColor = Color.Red;
                    labx.ForeColor = Color.Red;
                   // labs.Text = "Không được để trống";
                    labx.Text = "Không được để trống";
                }
                else if (string.IsNullOrEmpty(cmbTenKhuVuc.Text))
                {
                    XtraMessageBox.Show("Chưa nhập đầy đủ thông tin", "THÔNG BÁO  ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    labs.ForeColor = Color.Red;
                    //labx.ForeColor = Color.Red;
                    labs.Text = "Không được để trống";
                    //labx.Text = "Không được để trống";
                }
                else if (BanBus.Insert(table))
                {

                    XtraMessageBox.Show("Thêm thành công", "THÔNG BÁO  ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTenBan.Text = "";
                    cmbTenKhuVuc.Text = "";
                    labs.Text = "";
                    labx.Text = "";

                }
                else
                {
                    XtraMessageBox.Show("Thêm thất bại", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                FrmBan_Load(sender, e);
            }

            catch (Exception)
            {
                XtraMessageBox.Show("Thêm thất bại", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Table table = new Table();
            table.TrangThai = table.TrangThai = "Bàn Trống";
            for (int i = 0; i < gridView1.RowCount; i++)
            {


                table.MaBan = Convert.ToInt32(gridView1.GetRowCellValue(i, "MABAN").ToString());
                table.TenBAn = gridView1.GetRowCellValue(i, "TENBAN").ToString();
                table.MaKV = gridView1.GetRowCellValue(i, "MAKV").ToString();
                



                BanBus.Update(table);



            }


            XtraMessageBox.Show("Sửa thành công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);



            FrmBan_Load(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = XtraMessageBox.Show("bạn có chắc muốn xóa không ?", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                //khởi tạo đối tượng nhân viên
                BAN table = new BAN();
                //lấy mã nhân viên từ gridView1 của devexpress, lưu ý các bạn nhớ viết name của trường cần lấy phải đúng như 
                //trong csdl nhé
                table.MABAN = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MABAN").ToString());
                //thực hienj hàm xóa 
                new TableDAO().delete(table);
                gridControl1.RefreshDataSource();
                XtraMessageBox.Show("Xóa thành công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FrmBan_Load(sender, e);
            }
        }

       

        private void txtTenBan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnThemMoi.PerformClick();

        }

        private void cmbTenKhuVuc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnThemMoi.PerformClick();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            labx.Text = "";
            labs.Text = "";
        }
    }
}